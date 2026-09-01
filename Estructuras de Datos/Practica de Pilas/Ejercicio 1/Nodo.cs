namespace Ejercicio_1
{
    internal class Nodo
    {
        public int NumeroContenedor { get; set; }
        public int NumeroIdentificacion { get; set; }

        public Nodo SiguienteNodo { get; set; }

        public override string ToString()
        {
            return $"-> Número Contenedor: {NumeroContenedor}, Número Identificación: {NumeroIdentificacion}";
        }
    }
}
