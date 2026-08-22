using System;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class frmFormularioPrincipal : Form
    {
        Lista lista = new Lista();
        Nodo nodoSeleccionado;
        Random random = new Random();

        int cantMaxPersLista;
        int contadorIngresos = 0;

        public frmFormularioPrincipal()
        {
            InitializeComponent();
        }

        private void frmFormularioPrincipal_Load(object sender, EventArgs e)
        {
            // Arranca en 1 para que el cupo no pueda salir cero y dejar el
            // programa bloqueado con la lista vacía.
            cantMaxPersLista = random.Next(1, 50);
        }

        public Nodo IngresarDatosNodo()
        {
            Nodo unNuevoNodo = new Nodo();
            unNuevoNodo.numeroIngreso = contadorIngresos + 1;
            unNuevoNodo.edad = random.Next(5, 60);

            if (unNuevoNodo.edad < 18 || unNuevoNodo.edad >= 50)
                unNuevoNodo.valorEntrada = 50;
            else
                unNuevoNodo.valorEntrada = 100;

            return unNuevoNodo;
        }

        public void MostrarLista()
        {
            lstSalidaDatos.Items.Clear();

            if (lista.inicio != null)
                AgregarItemsLista(lista.inicio);
        }

        public void AgregarItemsLista(Nodo unNodo)
        {
            if (unNodo != null)
            {
                lstSalidaDatos.Items.Add(unNodo);
                AgregarItemsLista(unNodo.siguienteNodo);
            }
        }

        public void BloquearBotones()
        {
            btnIngresarPersona.Enabled = false;
            btnEliminarPersona.Enabled = false;
            btnActualizarPersona.Enabled = false;
            btnAgregarDespSeleccionado.Enabled = false;
        }

        private void btnIngresarPersona_Click(object sender, EventArgs e)
        {
            if (contadorIngresos != cantMaxPersLista)
            {
                lista.AgregarPersona(IngresarDatosNodo());
                contadorIngresos++;
                MostrarLista();
            }

            if (contadorIngresos == cantMaxPersLista)
                BloquearBotones();
        }
        private void lstSalidaDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            nodoSeleccionado = (Nodo)lstSalidaDatos.SelectedItem;
        }

        private void btnEliminarPersona_Click(object sender, EventArgs e)
        {
            if (nodoSeleccionado != null)
            {
                lista.EliminarPersona(nodoSeleccionado.numeroIngreso);
                nodoSeleccionado = null;
                MostrarLista();
            }
            else
                MessageBox.Show("Debe seleccionar un nodo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnActualizarPersona_Click(object sender, EventArgs e)
        {
            if (nodoSeleccionado != null)
            {
                lista.ActualizarPersona(IngresarDatosNodo(), nodoSeleccionado.numeroIngreso);
                nodoSeleccionado = null;
                MostrarLista();
            }
            else
                MessageBox.Show("Debe seleccionar un nodo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAgregarDespSeleccionado_Click(object sender, EventArgs e)
        {
            if (contadorIngresos != cantMaxPersLista)
            {
                if (nodoSeleccionado != null)
                {
                    lista.AgregarDespSeleccionado(IngresarDatosNodo(), nodoSeleccionado.numeroIngreso);
                    contadorIngresos++;
                    nodoSeleccionado = null;
                    MostrarLista();
                }
                else
                    MessageBox.Show("Debe seleccionar un nodo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (contadorIngresos == cantMaxPersLista)
                BloquearBotones();
        }

        private void btnSalirPrograma_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReiniciarPrograma_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}