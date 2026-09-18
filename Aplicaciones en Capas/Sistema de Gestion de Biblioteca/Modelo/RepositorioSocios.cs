using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public class RepositorioSocios
    {
        private readonly Context context = new();

        private static RepositorioSocios? instancia;

        // Patrón singleton
        public static RepositorioSocios Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new RepositorioSocios();
                    return instancia;
                }

                return instancia;
            }
        }

        public void Agregar(Socio socio)
        {
            context.Socios.Add(socio);
            context.SaveChanges();
        }

        public void Modificar(int DNI, Socio socio)
        {
            Socio? socioExistente = context.Socios.FirstOrDefault(s => s.DNI == DNI);

            if (socioExistente != null)
            {
                socioExistente.NombreCompleto = socio.NombreCompleto;
                socioExistente.Email = socio.Email;
                socioExistente.Telefono = socio.Telefono;

                context.SaveChanges();
            }
        }

        public void Eliminar(int dni)
        {
            List<Prestamo> prestamosAsociados = [.. context.Prestamos.Where(p => p.DNI == dni)];

            if (prestamosAsociados.Count != 0)
                context.Prestamos.RemoveRange(prestamosAsociados);

            Socio? socioExistente = context.Socios.FirstOrDefault(s => s.DNI == dni);

            if (socioExistente != null)
                context.Socios.Remove(socioExistente);

            context.SaveChanges();
        }

        public IReadOnlyCollection<Socio> Listar()
        {
            return context.Socios.AsNoTracking().ToList().AsReadOnly();
        }
    }
}
