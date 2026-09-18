using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Libro
    {
        [Key]
        public string ISBN { get; set; } = string.Empty;
        public string Titulo { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
    }
}
