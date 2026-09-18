using Entidades;
using Modelo;
using System.Text;

namespace Controladora
{
    public class Controladora
    {
        private readonly RepositorioLibros repositorioLibros = new();
        private readonly RepositorioPrestamos repositorioPrestamos = new();
        private readonly RepositorioSocios repositorioSocios = new();

        private static Controladora? instancia;

        // Patrón singleton
        public static Controladora Instancia
        {
            get
            {
                if (instancia == null)
                    return instancia = new Controladora();

                return instancia;
            }
        }

        public IReadOnlyCollection<Libro> ListarLibros() => repositorioLibros.Listar();

        public IReadOnlyCollection<Prestamo> ListarPrestamos() => repositorioPrestamos.Listar();

        public IReadOnlyCollection<Socio> ListarSocios() => repositorioSocios.Listar();

        public string AgregarLibro(Libro libro)
        {
            libro.ISBN = GenerarISBN();
            libro.Estado = "Disponible";

            repositorioLibros.Agregar(libro);
            return "Se ha agregado el libro con éxito.";
        }

        public string AgregarPrestamo(Prestamo prestamo)
        {
            ValidarFechas(prestamo);
            ValidarSocio(prestamo.DNI);
            ValidarLibroDisponible(prestamo.ISBN);

            repositorioPrestamos.Agregar(prestamo);
            repositorioLibros.CambiarEstado(prestamo.ISBN, "Prestado");
            return "Se ha agregado el préstamo con éxito.";
        }

        public string AgregarSocio(Socio socio)
        {
            if (!repositorioSocios.Listar().Any(x => x.DNI == socio.DNI))
            {
                repositorioSocios.Agregar(socio);
                return "Se ha agregado el socio con éxito.";
            }

            throw new ElementoEnLaBaseDeDatosException("Ya existe un socio con ese DNI.");
        }

        public string ModificarLibro(Libro libro, string ISBN)
        {
            if (repositorioLibros.Listar().Any(x => x.ISBN == ISBN))
            {
                repositorioLibros.Modificar(ISBN, libro);
                return "Se ha modificado el libro con éxito.";
            }

            throw new DatosInvalidosException("El libro seleccionado no existe.");
        }

        public string ModificarPrestamo(Prestamo prestamo, int id)
        {
            Prestamo prestamoExistente = repositorioPrestamos.ObtenerPorId(id) ?? throw new DatosInvalidosException("El préstamo seleccionado no existe.");

            ValidarFechas(prestamo);
            ValidarSocio(prestamo.DNI);

            bool cambioDeLibro = prestamo.ISBN != prestamoExistente.ISBN;

            if (cambioDeLibro)
                ValidarLibroDisponible(prestamo.ISBN);

            repositorioPrestamos.Modificar(id, prestamo);

            if (cambioDeLibro)
            {
                repositorioLibros.CambiarEstado(prestamoExistente.ISBN, "Disponible");
                repositorioLibros.CambiarEstado(prestamo.ISBN, "Prestado");
            }

            return "Se ha modificado el préstamo con éxito.";
        }

        public string ModificarSocio(Socio socio, int DNI)
        {
            if (repositorioSocios.Listar().Any(x => x.DNI == DNI))
            {
                repositorioSocios.Modificar(DNI, socio);
                return "Se ha modificado el socio con éxito.";
            }

            throw new DatosInvalidosException("El socio seleccionado no existe.");
        }

        public string EliminarLibro(string ISBN)
        {
            repositorioLibros.Eliminar(ISBN);
            return "Se ha eliminado el libro con éxito.";

        }

        public string DevolverPrestamo(int id)
        {
            Prestamo prestamo = repositorioPrestamos.ObtenerPorId(id) ?? throw new DatosInvalidosException("El préstamo seleccionado no existe.");

            repositorioPrestamos.Devolver(id);
            repositorioLibros.CambiarEstado(prestamo.ISBN, "Disponible");
            return "Se ha devuelto el préstamo con éxito.";
        }

        public string EliminarSocio(int DNI)
        {
            // Los préstamos del socio se borran junto con él, así que sus libros tienen que volver a quedar disponibles.
            List<string> librosPrestados = [.. repositorioPrestamos.Listar().Where(p => p.DNI == DNI).Select(p => p.ISBN)];

            repositorioSocios.Eliminar(DNI);

            foreach (string isbn in librosPrestados)
                repositorioLibros.CambiarEstado(isbn, "Disponible");

            return "Se ha eliminado el socio con éxito.";
        }

        private static void ValidarFechas(Prestamo prestamo)
        {
            if (prestamo.FechaDevolucion <= prestamo.FechaPrestamo)
                throw new DatosInvalidosException("La fecha de devolución debe ser posterior a la de préstamo.");
        }

        private void ValidarSocio(int DNI)
        {
            if (!repositorioSocios.Listar().Any(x => x.DNI == DNI))
                throw new DatosInvalidosException("El socio seleccionado no existe.");
        }

        private void ValidarLibroDisponible(string ISBN)
        {
            Libro libro = repositorioLibros.ObtenerPorISBN(ISBN) ?? throw new DatosInvalidosException("El libro seleccionado no existe.");

            if (libro.Estado == "Prestado")
                throw new DatosInvalidosException("El libro seleccionado ya está prestado.");
        }

        private string GenerarISBN()
        {
            const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new();
            string nuevoISBN;

            do
            {
                StringBuilder sb = new();

                for (int i = 0; i < 20; i++)
                {
                    int index = random.Next(caracteres.Length);
                    sb.Append(caracteres[index]);
                }

                nuevoISBN = sb.ToString();

            } while (repositorioLibros.ExisteISBN(nuevoISBN));

            return nuevoISBN;
        }
    }
}
