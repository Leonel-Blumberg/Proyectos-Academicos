using System;
using System.Linq;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class FrmFormularioPrincipal : Form
    {
        private readonly Pila pila = new Pila();
        int contadorPueblos = 0;

        public FrmFormularioPrincipal()
        {
            InitializeComponent();
        }

        private int VerificarValidezPueblo()
        {
            if (txtPueblo.Text.Length < 1)
            {
                MessageBox.Show("Debe ingresar un pueblo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPueblo.Text = "";
                return 0;
            }
            else if (txtPueblo.Text.All(char.IsDigit))
            {
                MessageBox.Show("Debe ingresar un pueblo válido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPueblo.Text = "";
                return 0;
            }

            return 1;
        }

        private Nodo IngresarDatosNodo()
        {
            Nodo unNuevoNodo = new Nodo
            {
                numeroPueblo = contadorPueblos + 1,
                nombrePueblo = txtPueblo.Text
            };

            txtPueblo.Text = "";

            return unNuevoNodo;
        }

        private void MostrarLista()
        {
            lstSalidaDatos.Items.Clear();

            if (pila.tope != null)
                AgregarElementoALista(pila.tope);
        }

        private void AgregarElementoALista(Nodo unNodo)
        {
            lstSalidaDatos.Items.Add(unNodo);

            if (unNodo.siguienteNodo != null)
                AgregarElementoALista(unNodo.siguienteNodo);
        }

        private void BtnIngresarPueblo_Click(object sender, EventArgs e)
        {
            if (VerificarValidezPueblo() == 1)
            {
                pila.IngresarPueblo(IngresarDatosNodo());
                contadorPueblos++;
                MostrarLista();

                btnMarcarPuebloDestino.Enabled = true;
                btnQuitarUltimoPueblo.Enabled = true;
            }
        }

        private void BtnMarcarPuebloDestino_Click(object sender, EventArgs e)
        {
            txtPueblo.Text = "";

            lblPueblo.Enabled = false;
            txtPueblo.Enabled = false;
            btnIngresarPueblo.Enabled = false;
            btnMarcarPuebloDestino.Enabled = false;

            btnQuitarUltimoPueblo.Focus();

            MessageBox.Show($"El pueblo destino fue:\r\nPueblo número: {pila.tope.numeroPueblo}\r\nNombre: {pila.tope.nombrePueblo}", "PUEBLO DESTINO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnQuitarUltimoPueblo_Click(object sender, EventArgs e)
        {
            pila.QuitarUltimoPueblo();
            contadorPueblos--;
            MostrarLista();

            if (pila.tope == null && !(btnMarcarPuebloDestino.Enabled))
            {
                gboxEntradaDatos.Enabled = false;
                btnQuitarUltimoPueblo.Enabled = false;
            }
            else if (pila.tope == null)
            {
                btnQuitarUltimoPueblo.Enabled = false;
                btnMarcarPuebloDestino.Enabled = false;
            }
        }

        private void BtnReiniciarPrograma_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void BtnSalirPrograma_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
