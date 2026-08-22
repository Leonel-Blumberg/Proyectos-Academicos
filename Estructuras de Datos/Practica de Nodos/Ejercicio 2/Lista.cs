namespace Ejercicio_2
{
    public class Lista
    {
        public Nodo inicio;

        public Nodo BuscarUltimo(Nodo unNodo)
        {
            if (unNodo.siguienteNodo == null)
                return unNodo;
            else
                return BuscarUltimo(unNodo.siguienteNodo);
        }

        public void IngresarNuevoAlumno(Nodo unNodo)
        {
            if (inicio == null)
                inicio = unNodo;

            else
            {
                Nodo aux = BuscarUltimo(inicio);
                aux.siguienteNodo = unNodo;
            }
        }

        public Nodo BuscarAnterior(Nodo buscador, int dni)
        {
            if (buscador.siguienteNodo != null)
            {
                if (buscador.siguienteNodo.dni == dni)
                    return buscador;

                return BuscarAnterior(buscador.siguienteNodo, dni);
            }
            return null;
        }

        // BuscarAnterior devuelve null tanto si el DNI es el del primer nodo
        // como si no está en la lista, así que esos dos casos se resuelven antes.
        public void EliminarAlumno(int dni)
        {
            if (inicio == null)
                return;

            if (inicio.dni == dni)
            {
                inicio = inicio.siguienteNodo;
                return;
            }

            Nodo anterior = BuscarAnterior(inicio, dni);

            if (anterior != null)
                anterior.siguienteNodo = anterior.siguienteNodo.siguienteNodo;
        }

        public Nodo BuscarNodoActual(Nodo buscador, int dni)
        {
            if (buscador == null)
                return null;

            if (buscador.dni == dni)
                return buscador;

            return BuscarNodoActual(buscador.siguienteNodo, dni);
        }

        public void ActualizarAlumno(int dni, Nodo nodoActualizado)
        {
            Nodo Actual = BuscarNodoActual(inicio, dni);

            if (Actual != null)
            {
                Actual.nombre = nodoActualizado.nombre;
                Actual.apellido = nodoActualizado.apellido;
                Actual.dni = nodoActualizado.dni;
                Actual.fechaNacimiento = nodoActualizado.fechaNacimiento;
                Actual.direccion = nodoActualizado.direccion;
                Actual.telefono = nodoActualizado.telefono;
            }
        }

        public void AgregarDespSeleccionado(int dni, Nodo nodoActualizado)
        {
            Nodo Actual = BuscarNodoActual(inicio, dni);

            if (Actual != null)
            {
                nodoActualizado.siguienteNodo = Actual.siguienteNodo;
                Actual.siguienteNodo = nodoActualizado;
            }
        }

        // Si el seleccionado es el primero no hay anterior donde colgarlo, así
        // que el nodo nuevo pasa a ser el inicio de la lista.
        public void AgregarAntesSeleccionado(int dni, Nodo nodoActualizado)
        {
            if (inicio == null)
                return;

            if (inicio.dni == dni)
            {
                nodoActualizado.siguienteNodo = inicio;
                inicio = nodoActualizado;
                return;
            }

            Nodo Anterior = BuscarAnterior(inicio, dni);

            if (Anterior != null)
            {
                nodoActualizado.siguienteNodo = Anterior.siguienteNodo;
                Anterior.siguienteNodo = nodoActualizado;
            }
        }
    }
}