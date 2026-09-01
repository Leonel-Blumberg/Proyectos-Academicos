using System;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class FrmFormularioPrincipal : Form
    {
        private readonly Pila pila = new Pila();
        Nodo nodoSeleccionado = new Nodo();

        private readonly Pila pilaAuxiliar = new Pila();

        int numeroContenedor = 0;

        public FrmFormularioPrincipal()
        {
            InitializeComponent();
        }

        private int VerificarDatos()
        {
            try
            {
                if (Convert.ToInt32(txtNumIdent.Text) < 0)
                {
                    MessageBox.Show("El número de identificación no puede ser negativo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumIdent.Text = "";
                    return 0;
                }
            }
            catch
            {
                MessageBox.Show("Debe ingresar un número de identificación válido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumIdent.Text = "";
                return 0;
            }

            return 1;
        }

        private Nodo IngresarDatosNodo()
        {
            Nodo unNuevoNodo = new Nodo
            {
                NumeroContenedor = numeroContenedor + 1,
                NumeroIdentificacion = Convert.ToInt32(txtNumIdent.Text)
            };

            txtNumIdent.Text = "";

            return unNuevoNodo;
        }

        private void MostrarLista()
        {
            lstSalidaDatos.Items.Clear();

            if (pila.Tope() != null)
                AgregarItemLista(pila.Tope());
        }

        private void AgregarItemLista(Nodo unNodo)
        {
            lstSalidaDatos.Items.Add(unNodo);

            if (unNodo.SiguienteNodo != null)
                AgregarItemLista(unNodo.SiguienteNodo);
        }

        private void BtnApilar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos() == 1)
            {
                pila.Apilar(IngresarDatosNodo());
                MostrarLista();

                numeroContenedor++;

                btnVerTope.Enabled = true;
            }
        }

        private void MoverElementosAPilaAuxiliar(int numeroContenedor)
        {
            if (pila.Tope().NumeroContenedor == numeroContenedor)
                pila.Desapilar();

            else
            {
                Nodo aux = new Nodo
                {
                    NumeroContenedor = pila.Tope().NumeroContenedor,
                    NumeroIdentificacion = pila.Tope().NumeroIdentificacion
                };

                pilaAuxiliar.Apilar(aux);
                pila.Desapilar();

                MoverElementosAPilaAuxiliar(numeroContenedor);
            }
        }

        private void MoverElementosAPilaPrincipal()
        {
            if (pilaAuxiliar.Tope() != null)
            {
                Nodo aux = new Nodo
                {
                    NumeroContenedor = pilaAuxiliar.Tope().NumeroContenedor,
                    NumeroIdentificacion = pilaAuxiliar.Tope().NumeroIdentificacion
                };

                pila.Apilar(aux);
                pilaAuxiliar.Desapilar();

                MoverElementosAPilaPrincipal();
            }
        }

        private void LstSalidaDatos_DoubleClick(object sender, EventArgs e)
        {
            nodoSeleccionado = (Nodo) lstSalidaDatos.SelectedItem;

            if (nodoSeleccionado == null)
                return;

            MoverElementosAPilaAuxiliar(nodoSeleccionado.NumeroContenedor);
            MoverElementosAPilaPrincipal();

            nodoSeleccionado = null;
            MostrarLista();

            if (pila.Tope() == null)
                btnVerTope.Enabled = false;
        }

        private void BtnVerTope_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"El tope es:\r\nNúmero Contenedor: {pila.Tope().NumeroContenedor}, Número Identificación: {pila.Tope().NumeroIdentificacion}", "TOPE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnReiniciarAplicacion_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void BtnSalirAplicacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
