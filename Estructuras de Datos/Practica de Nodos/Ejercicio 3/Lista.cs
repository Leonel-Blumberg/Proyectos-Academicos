namespace Ejercicio_3
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

        public void AgregarPersona(Nodo unNodo)
        {
            if (inicio == null)
                inicio = unNodo;

            else
            {
                Nodo ultimo = BuscarUltimo(inicio);
                ultimo.siguienteNodo = unNodo;
            }
        }

        public Nodo BuscarAnterior(Nodo unNodo, int numeroIngreso)
        {
            if (unNodo.siguienteNodo != null)
            {
                if (unNodo.siguienteNodo.numeroIngreso == numeroIngreso)
                    return unNodo;

                return BuscarAnterior(unNodo.siguienteNodo, numeroIngreso);
            }

            return null;
        }

        // BuscarAnterior devuelve null tanto si el número de ingreso es el del
        // primer nodo como si no está en la lista, así que esos dos casos se
        // resuelven antes.
        public void EliminarPersona(int numeroIngreso)
        {
            if (inicio == null)
                return;

            if (inicio.numeroIngreso == numeroIngreso)
            {
                inicio = inicio.siguienteNodo;
                return;
            }

            Nodo anterior = BuscarAnterior(inicio, numeroIngreso);

            if (anterior != null)
                anterior.siguienteNodo = anterior.siguienteNodo.siguienteNodo;
        }

        public Nodo BuscarActual(Nodo unNodo, int numeroIngreso)
        {
            if (unNodo == null)
                return null;

            if (unNodo.numeroIngreso == numeroIngreso)
                return unNodo;

            return BuscarActual(unNodo.siguienteNodo, numeroIngreso);
        }

        // El número de ingreso identifica al nodo, así que no se pisa: si se
        // copiara del nodo nuevo quedaría repetido con el del próximo ingreso.
        public void ActualizarPersona(Nodo unNodo, int numeroIngreso)
        {
            Nodo actual = BuscarActual(inicio, numeroIngreso);

            if (actual != null)
            {
                actual.valorEntrada = unNodo.valorEntrada;
                actual.edad = unNodo.edad;
            }
        }

        public void AgregarDespSeleccionado(Nodo unNodo, int numeroIngreso)
        {
            Nodo actual = BuscarActual(inicio, numeroIngreso);

            if (actual != null)
            {
                unNodo.siguienteNodo = actual.siguienteNodo;
                actual.siguienteNodo = unNodo;
            }
        }
    }
}