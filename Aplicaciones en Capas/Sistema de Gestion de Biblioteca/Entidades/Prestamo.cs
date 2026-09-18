using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    public class Prestamo
    {
        [Key]
        public int ID { get; set; }
        public DateOnly FechaPrestamo { get; set; }
        public DateOnly FechaDevolucion { get; set; }
        [ForeignKey(nameof(Libro))]
        public string ISBN { get; set; } = string.Empty;
        [ForeignKey(nameof(Socio))]
        public int DNI { get; set; }
    }
}
