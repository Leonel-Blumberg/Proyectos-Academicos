using System;
using System.Windows.Forms;

namespace Practica_de_Colas
{
    public partial class FrmFormularioPrincipal : Form
    {
        Cola miCola = new Cola();

        int cantidadPedidos = 0;

        int precioPedidoMaximo = 0, precioPedidoMinimo = 0, cantidadPedidosDesencolados = 0;
        float totalPrecioPedidos = 0;

        public FrmFormularioPrincipal()
        {
            InitializeComponent();
        }

        private int VerificarDatos()
        {
            try
            {
                if (txtNumPedido.Text.Length < 1)
                {
                    MessageBox.Show("Debe ingresar un número de pedido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumPedido.Text = "";
                    return 0;

                }
                else if (Convert.ToInt32(txtNumPedido.Text) < 1)
                {
                    MessageBox.Show("El número de pedido no puede ser menor que 1.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumPedido.Text = "";
                    return 0;
                }
            }
            catch
            {
                MessageBox.Show("Ingrese un número de pedido válido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumPedido.Text = "";
                return 0;
            }

            if (txtProdCompr.Text.Length < 1)
            {
                MessageBox.Show("Debe ingresar un producto comprado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProdCompr.Text = "";
                return 0;

            }

            try
            {
                if (txtPrecioPedido.Text.Length < 1)
                {
                    MessageBox.Show("Debe ingresar el precio del pedido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPrecioPedido.Text = "";
                    return 0;

                }
                else if (Convert.ToInt32(txtPrecioPedido.Text) < 0)
                {
                    MessageBox.Show("El precio del pedido no puede ser negativo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPrecioPedido.Text = "";
                    return 0;
                }
            }
            catch
            {
                MessageBox.Show("Ingrese un precio de pedido válido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecioPedido.Text = "";
                return 0;
            }

            if (txtFechaEntregaEstimada.Text.Length < 1)
            {
                MessageBox.Show("Debe ingresar una fecha de entrega estimada.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFechaEntregaEstimada.Text = "";
                return 0;

            }

            return 1;
        }

        private Nodo IngresarDatosNodo()
        {
            Nodo unNuevoNodo = new Nodo();
            unNuevoNodo.conteoPedido = cantidadPedidos + 1;
            unNuevoNodo.numPedido = Convert.ToInt32(txtNumPedido.Text);
            unNuevoNodo.producCompr = txtProdCompr.Text;
            unNuevoNodo.precioPedido = Convert.ToInt32(txtPrecioPedido.Text);
            unNuevoNodo.fechaEntrEst = txtFechaEntregaEstimada.Text;

            txtNumPedido.Text = "";
            txtProdCompr.Text = "";
            txtPrecioPedido.Text = "";
            txtFechaEntregaEstimada.Text = "";

            return unNuevoNodo;
        }

        private void MostrarLista()
        {
            lstSalidaDatos.Items.Clear();

            if (miCola.Inicio() != null)
                AgregarElementosALista(miCola.Inicio());
        }

        private void AgregarElementosALista(Nodo unNodo)
        {
            lstSalidaDatos.Items.Add(unNodo);

            if (unNodo.siguienteNodo != null)
                AgregarElementosALista(unNodo.siguienteNodo);
        }

        private void btnIngresarDatos_Click(object sender, EventArgs e)
        {
            if (VerificarDatos() == 1)
            {
                miCola.Encolar(IngresarDatosNodo());

                cantidadPedidos++;
                MostrarLista();

                btnQuitarPrimerDato.Enabled = true;
            }
        }

        private void MostrarDatosElementosDesencolados()
        {
            int precioDesencolado = miCola.Inicio().precioPedido;

            if (cantidadPedidosDesencolados == 0)
            {
                precioPedidoMaximo = precioDesencolado;
                precioPedidoMinimo = precioDesencolado;
            }

            if (precioDesencolado > precioPedidoMaximo)
                precioPedidoMaximo = precioDesencolado;

            if (precioDesencolado < precioPedidoMinimo)
                precioPedidoMinimo = precioDesencolado;

            totalPrecioPedidos += precioDesencolado;
            cantidadPedidosDesencolados++;

            lblMax.Text = Convert.ToString(precioPedidoMaximo);
            lblMin.Text = Convert.ToString(precioPedidoMinimo);
            lblProm.Text = Convert.ToString(totalPrecioPedidos / cantidadPedidosDesencolados);
            lblTot.Text = Convert.ToString(totalPrecioPedidos);
        }

        private void btnQuitarPrimerDato_Click(object sender, EventArgs e)
        {
            MostrarDatosElementosDesencolados();

            miCola.Desencolar();
            MostrarLista();

            if (miCola.Inicio() == null)
                btnQuitarPrimerDato.Enabled = false;
        }

        private void btnReiniciarPrograma_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnSalirPrograma_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
