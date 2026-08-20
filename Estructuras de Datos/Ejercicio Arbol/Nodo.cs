namespace Ejercicio_Arbol
{
    internal class Nodo
    {
        public string Nombre { get; set; }
        public Nodo Hijo { get; set; }
        public Nodo Hermano { get; set; }

        public Nodo()
        {
            Nombre = "";
            Hijo = null;
            Hermano = null;
        }
    }
}
