namespace Ejercicio_2
{
    public class Pila
    {
        public Nodo tope;

        public void IngresarPueblo(Nodo unNodo)
        {
            if (tope == null)
                tope = unNodo;
            else
            {
                unNodo.siguienteNodo = tope;
                tope = unNodo;
            }
        }

        public void QuitarUltimoPueblo()
        {
            if (tope == null)
                return;

            tope = tope.siguienteNodo;
        }
    }
}
