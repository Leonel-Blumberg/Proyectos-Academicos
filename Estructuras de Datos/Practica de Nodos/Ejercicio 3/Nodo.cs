namespace Ejercicio_3
{
    public class Nodo
    {
        public int numeroIngreso;
        public float valorEntrada;
        public int edad;

        public Nodo siguienteNodo;

        public override string ToString()
        {
            return $"-> Valor Entrada: {valorEntrada}, Edad: {edad}";
        }
    }
}