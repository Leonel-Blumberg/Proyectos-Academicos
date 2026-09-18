using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public class Context : DbContext
    {
        private readonly string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=SistemaGestionBibliotecaDB;Integrated Security=True;TrustServerCertificate=True";

        public DbSet<Libro> Libros { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<Socio> Socios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(connectionString);
    }
}