namespace Ejercicio_1
{
    public class Nodo
    {
        public int codigo;
        public string nombres;
        public string apellido;
        public string direccion;
        public long telefono;

        public Nodo siguienteNodo;

        public override string ToString()
        {
            return $"-> Código: {codigo}, Nombres: {nombres}, Apellido: {apellido}, Dirección: {direccion}, Teléfono: {telefono}";
        }
    }
}