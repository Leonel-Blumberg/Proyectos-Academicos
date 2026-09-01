using System;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class FrmFormularioPrincipal : Form
    {
        private readonly Pila pila = new Pila();

        public FrmFormularioPrincipal()
        {
            InitializeComponent();

            dtpFecha.MinDate = DateTime.Today.AddYears(-100);
            dtpFecha.MaxDate = DateTime.Today;
            dtpFecha.Value = DateTime.Today;
        }

        private int VerificarDatos()
        {
            try
            {
                if (Convert.ToInt32(txtNumExpe.Text) < 1)
                {
                    MessageBox.Show("El número de expediente debe ser mayor o igual a 1.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumExpe.Text = "";
                    return 0;
                }
            }
            catch
            {
                MessageBox.Show("Debe ingresar un número de expediente válido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumExpe.Text = "";
                return 0;
            }

            if (txtCaratula.Text.Length < 1)
            {
                MessageBox.Show("Debe ingresar una carátula.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCaratula.Text = "";
                return 0;
            }

            return 1;
        }

        private Nodo IngresarDatosNodo()
        {
            Nodo unNuevoNodo = new Nodo
            {
                Fecha = dtpFecha.Value,
                NumeroExpediente = Convert.ToInt32(txtNumExpe.Text),
                Caratula = txtCaratula.Text
            };

            dtpFecha.Value = DateTime.Today;
            txtNumExpe.Text = "";
            txtCaratula.Text = "";

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

                btnDesapilar.Enabled = true;
                btnVerTope.Enabled = true;
            }
        }

        private void BtnDesapilar_Click(object sender, EventArgs e)
        {
            pila.Desapilar();
            MostrarLista();

            if (pila.Tope() == null)
            {
                btnDesapilar.Enabled = false;
                btnVerTope.Enabled = false;
                btnApilar.Focus();
            }
        }

        private void BtnVerTope_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"El tope es:\r\nFecha: {pila.Tope().Fecha.ToString("dd/MM/yyyy")}, Número Expediente: {pila.Tope().NumeroExpediente}, Caratula: {pila.Tope().Caratula}", "TOPE", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
