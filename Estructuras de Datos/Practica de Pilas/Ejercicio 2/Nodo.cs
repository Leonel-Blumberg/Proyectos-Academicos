namespace Ejercicio_2
{
    public class Nodo
    {
        public int numeroPueblo;
        public string nombrePueblo;
        public Nodo siguienteNodo;

        public override string ToString()
        {
            return $"-> Número pueblo: {numeroPueblo}, Nombre: {nombrePueblo}";
        }
    }
}
