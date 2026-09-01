namespace Ejercicio_3
{
    internal class Pila
    {
        Nodo tope;

        public Nodo Tope()
        {
            return tope;
        }

        public void Apilar(Nodo unNodo)
        {
            if (tope == null)
                tope = unNodo;

            else
            {
                Nodo aux = tope;
                tope = unNodo;
                unNodo.SiguienteNodo = aux;
            }
        }

        public void Desapilar()
        {
            if (tope == null)
                return;

            tope = tope.SiguienteNodo;
        }
    }
}
