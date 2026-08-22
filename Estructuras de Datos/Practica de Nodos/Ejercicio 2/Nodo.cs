using System;

namespace Ejercicio_2
{
    public class Nodo
    {
        public string nombre;
        public string apellido;
        public int dni;
        public DateTime fechaNacimiento;
        public string direccion;
        public long telefono;

        public Nodo siguienteNodo;

        public override string ToString()
        {
            return $"-> {nombre}, {apellido}, {dni}, {fechaNacimiento.ToString("dd/MM/yyyy")}, {direccion}, {telefono}";
        }
    }
}