namespace Practica_de_Colas
{
    internal class Nodo
    {
        public int conteoPedido { get; set; }
        public int numPedido { get; set; }
        public string producCompr { get; set; }
        public int precioPedido { get; set; }
        public string fechaEntrEst { get; set; }

        public Nodo siguienteNodo;

        public override string ToString()
        {
            return $"-> Pedido: {conteoPedido}, Número pedido: {numPedido}, Producto comprado: {producCompr}, Precio Pedido: USD {precioPedido}, Fecha de entrega estimada: {fechaEntrEst}";
        }
    }
}
