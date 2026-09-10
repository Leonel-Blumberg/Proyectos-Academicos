namespace Practica_de_Colas
{
    internal class Cola
    {
        Nodo _inicio;

        public Nodo Inicio()
        {
            return _inicio;
        }

        public Nodo BuscarUltimo(Nodo unNodo)
        {
            if (unNodo.siguienteNodo == null)
                return unNodo;

            else
                return BuscarUltimo(unNodo.siguienteNodo);
        }

        public void Encolar(Nodo unNodo)
        {
            if (_inicio == null)
            {
                _inicio = unNodo;
            }

            else
            {
                Nodo ultimo = BuscarUltimo(_inicio);
                ultimo.siguienteNodo = unNodo;
            }
        }

        public void Desencolar()
        {
            if (_inicio == null)
                return;

            _inicio = _inicio.siguienteNodo;
        }
    }
}
