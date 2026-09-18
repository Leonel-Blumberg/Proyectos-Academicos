using Entidades;
using Microsoft.EntityFrameworkCore;
namespace Modelo
{
    public class RepositorioLibros
    {

        private static RepositorioLibros? instancia;
        private readonly Context context = new();

        public RepositorioLibros() { }

        public static RepositorioLibros Instancia
        {
            get
            {
                instancia ??= new RepositorioLibros();
                return instancia;
            }
        }

        public void Agregar(Libro libro)
        {
            context.Libros.Add(libro);
            context.SaveChanges();
        }

        public void Modificar(string ISBN, Libro libro)
        {
            Libro? libroExistente = context.Libros.FirstOrDefault(l => l.ISBN == ISBN);

            if (libroExistente != null)
            {
                libroExistente.Titulo = libro.Titulo;
                libroExistente.Autor = libro.Autor;

                context.SaveChanges();
            }
        }

        public void CambiarEstado(string ISBN, string estado)
        {
            Libro? libroExistente = context.Libros.FirstOrDefault(l => l.ISBN == ISBN);

            if (libroExistente != null)
            {
                libroExistente.Estado = estado;
                context.SaveChanges();
            }
        }

        public void Eliminar(string ISBN)
        {
            List<Prestamo> prestamosAsociados = [.. context.Prestamos.Where(p => p.ISBN == ISBN)];

            if (prestamosAsociados.Count != 0)
                context.Prestamos.RemoveRange(prestamosAsociados);

            Libro? libroExistente = context.Libros.FirstOrDefault(l => l.ISBN == ISBN);

            if (libroExistente != null)
                context.Libros.Remove(libroExistente);

            context.SaveChanges();
        }

        public IReadOnlyCollection<Libro> Listar()
        {
            return context.Libros.AsNoTracking().ToList().AsReadOnly();
        }

        public bool ExisteISBN(string isbn)
        {
            return context.Libros.Any(l => l.ISBN == isbn);
        }

        public Libro? ObtenerPorISBN(string isbn)
        {
            return context.Libros.AsNoTracking().FirstOrDefault(l => l.ISBN == isbn);
        }
    }
}