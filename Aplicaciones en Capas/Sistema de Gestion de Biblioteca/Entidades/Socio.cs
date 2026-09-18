using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    public class Socio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DNI { get; set; }
        public string NombreCompleto { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public long Telefono { get; set; }
    }
}
