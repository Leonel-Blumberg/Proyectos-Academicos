using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public class RepositorioPrestamos
    {
        private readonly Context context = new();

        private static RepositorioPrestamos? instancia;

        // Patrón singleton
        public static RepositorioPrestamos Instancia
        {
            get
            {
                if(instancia == null)
                {
                    instancia = new RepositorioPrestamos();
                    return instancia;
                }

                return instancia;
            }
        }

        public void Agregar(Prestamo prestamo)
        {
            context.Prestamos.Add(prestamo);
            context.SaveChanges();
        }

        public void Modificar(int id, Prestamo prestamo)
        {
            Prestamo? prestamoExistente = context.Prestamos.FirstOrDefault(p => p.ID == id);

            if (prestamoExistente != null)
            {
                prestamoExistente.FechaPrestamo = prestamo.FechaPrestamo;
                prestamoExistente.FechaDevolucion = prestamo.FechaDevolucion;
                prestamoExistente.ISBN = prestamo.ISBN;
                prestamoExistente.DNI = prestamo.DNI;

                context.SaveChanges();
            }
        }

        public void Devolver(int id)
        {
            Prestamo? prestamoExistente = context.Prestamos.FirstOrDefault(p => p.ID == id);

            if (prestamoExistente != null)
            {
                context.Prestamos.Remove(prestamoExistente);
                context.SaveChanges();
            }
        }

        public IReadOnlyCollection<Prestamo> Listar()
        {
            return context.Prestamos.AsNoTracking().ToList().AsReadOnly();
        }

        public Prestamo? ObtenerPorId(int id)
        {
            return context.Prestamos.AsNoTracking().FirstOrDefault(p => p.ID == id);
        }
    }
}
