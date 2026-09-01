using System;

namespace Ejercicio_3
{
    internal class Nodo
    {
        public DateTime Fecha { get; set; }
        public int NumeroExpediente { get; set; }
        public string Caratula { get; set; }
        
        public Nodo SiguienteNodo { get; set; }

        public override string ToString()
        {
            return $"-> Fecha: {Fecha.ToString("dd/MM/yyyy")}, Número Expediente: {NumeroExpediente}, Caratula: {Caratula}";
        }
    }
}
