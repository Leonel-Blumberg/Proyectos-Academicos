namespace Ejercicio_1
{
    public class Lista
    {
        public Nodo inicio;

        public Nodo BuscarUltimo(Nodo unNodo)
        {
            if (unNodo.siguienteNodo == null)
                return unNodo;

            return BuscarUltimo(unNodo.siguienteNodo);
        }

        public void AgregarPaciente(Nodo unNodo)
        {
            if (inicio == null)
                inicio = unNodo;

            else
            {
                Nodo ultimo = BuscarUltimo(inicio);
                ultimo.siguienteNodo = unNodo;
            }
        }

        public Nodo BuscarAnterior(Nodo unNodo, int codigo)
        {
            if (unNodo.siguienteNodo != null)
            {
                if (unNodo.siguienteNodo.codigo == codigo)
                    return unNodo;

                return BuscarAnterior(unNodo.siguienteNodo, codigo);
            }

            return null;
        }

        // BuscarAnterior devuelve null tanto si el código es el del primer nodo
        // como si no está en la lista, así que esos dos casos se resuelven antes.
        public void EliminarPaciente(int codigo)
        {
            if (inicio == null)
                return;

            if (inicio.codigo == codigo)
            {
                inicio = inicio.siguienteNodo;
                return;
            }

            Nodo anterior = BuscarAnterior(inicio, codigo);

            if (anterior != null)
                anterior.siguienteNodo = anterior.siguienteNodo.siguienteNodo;
        }

        public Nodo BuscarActual(Nodo unNodo, int codigo)
        {
            if (unNodo == null)
                return null;

            if (unNodo.codigo == codigo)
                return unNodo;

            return BuscarActual(unNodo.siguienteNodo, codigo);
        }

        public void ActualizarPaciente(Nodo unNodo, int codigo)
        {
            Nodo actual = BuscarActual(inicio, codigo);

            if (actual != null)
            {
                actual.codigo = unNodo.codigo;
                actual.nombres = unNodo.nombres;
                actual.apellido = unNodo.apellido;
                actual.direccion = unNodo.direccion;
                actual.telefono = unNodo.telefono;
            }
        }

        public void AgregarDespSeleccionado(Nodo unNodo, int codigo)
        {
            Nodo actual = BuscarActual(inicio, codigo);

            if (actual != null)
            {
                unNodo.siguienteNodo = actual.siguienteNodo;
                actual.siguienteNodo = unNodo;
            }
        }
    }
}