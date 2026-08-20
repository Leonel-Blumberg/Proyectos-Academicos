namespace Ejercicio_con_Archivos
{
    internal class Alumno
    {
        public int? CodigoAlumno { get; set; }
        public string? Apellidos { get; set; }
        public string? Nombres { get; set; }
        public string? FechaNacimiento { get; set; }
        public long? Telefono { get; set; }
        public string? Mail { get; set; }

        public string GenerarRegistro()
        {
            return $"{CodigoAlumno}|{Apellidos}|{Nombres}|{FechaNacimiento}|{Telefono}|{Mail}";
        }
    }
}