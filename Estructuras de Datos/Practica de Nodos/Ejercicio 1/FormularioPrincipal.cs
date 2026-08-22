using System;
using System.Linq;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class frmFormularioPrincipal : Form
    {
        Lista lista = new Lista();
        Nodo nodoSeleccionado;

        public frmFormularioPrincipal()
        {
            InitializeComponent();
        }

        // codigoActual es el código que ya tiene el paciente que se está
        // actualizando, o 0 al cargar uno nuevo, para no rechazarlo como
        // duplicado de sí mismo.
        public int validarDatos(int codigoActual)
        {
            try
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);

                if (codigo < 1)
                {
                    MessageBox.Show("El código debe ser mayor o igual a 1.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodigo.Text = "";
                    return 0;
                }

                if (codigo != codigoActual && lista.BuscarActual(lista.inicio, codigo) != null)
                {
                    MessageBox.Show("Ya existe un paciente con ese código.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodigo.Text = "";
                    return 0;
                }
            }
            catch
            {
                MessageBox.Show("Ingrese un código válido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Text = "";
                return 0;
            }

            if (txtNombres.Text.Length < 3)
            {
                MessageBox.Show("El nombre debe tener al menos 3 caracteres.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombres.Text = "";
                return 0;
            }
            else if (!txtNombres.Text.All(c => char.IsLetter(c) || c == ' '))
            {
                MessageBox.Show("Ingrese un nombre válido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombres.Text = "";
                return 0;
            }

            if (txtApellido.Text.Length < 3)
            {
                MessageBox.Show("El apellido debe tener al menos 3 caracteres.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Text = "";
                return 0;
            }
            else if (!txtApellido.Text.All(c => char.IsLetter(c) || c == ' '))
            {
                MessageBox.Show("Ingrese un apellido válido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Text = "";
                return 0;
            }

            if (txtDireccion.Text.Length < 1)
            {
                MessageBox.Show("La dirección debe tener al menos 1 carácter.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDireccion.Text = "";
                return 0;
            }

            try
            {
                Convert.ToInt64(txtTelefono.Text);

                if (!txtTelefono.Text.All(char.IsDigit))
                {
                    MessageBox.Show("El teléfono solo puede tener dígitos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTelefono.Text = "";
                    return 0;
                }

                if (txtTelefono.Text.Length < 8)
                {
                    MessageBox.Show("El teléfono debe tener al menos 8 caracteres.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTelefono.Text = "";
                    return 0;
                }
            }
            catch
            {
                MessageBox.Show("Ingrese un teléfono válido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Text = "";
                return 0;
            }

            return 1;
        }

        public Nodo ingresarDatosNodo()
        {
            Nodo unNuevoNodo = new Nodo();
            unNuevoNodo.codigo = Convert.ToInt32(txtCodigo.Text);
            unNuevoNodo.nombres = txtNombres.Text;
            unNuevoNodo.apellido = txtApellido.Text;
            unNuevoNodo.direccion = txtDireccion.Text;
            unNuevoNodo.telefono = Convert.ToInt64(txtTelefono.Text);

            txtCodigo.Text = "";
            txtNombres.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";

            return unNuevoNodo;
        }

        public void MostrarLista()
        {
            lstSalidaDatos.Items.Clear();

            if (lista.inicio != null)
                AgregarPacientesLista(lista.inicio);
        }

        public void AgregarPacientesLista(Nodo unNodo)
        {
            if (unNodo != null)
            {
                lstSalidaDatos.Items.Add(unNodo);
                AgregarPacientesLista(unNodo.siguienteNodo);
            }
        }

        private void btnIngresarPaciente_Click(object sender, EventArgs e)
        {
            if (validarDatos(0) == 1)
            {
                lista.AgregarPaciente(ingresarDatosNodo());
                MostrarLista();
            }
        }
        private void lstSalidaDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            nodoSeleccionado = (Nodo)lstSalidaDatos.SelectedItem;
        }

        private void btnEliminarPaciente_Click(object sender, EventArgs e)
        {
            if (nodoSeleccionado != null)
            {
                lista.EliminarPaciente(nodoSeleccionado.codigo);
                nodoSeleccionado = null;
                MostrarLista();
            }
            else
                MessageBox.Show("Debe seleccionar un nodo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnActualizarPaciente_Click(object sender, EventArgs e)
        {
            if (nodoSeleccionado != null)
            {
                if (validarDatos(nodoSeleccionado.codigo) == 1)
                {
                    lista.ActualizarPaciente(ingresarDatosNodo(), nodoSeleccionado.codigo);
                    nodoSeleccionado = null;
                    MostrarLista();
                }
            }
            else
                MessageBox.Show("Debe seleccionar un nodo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAgregarDespSeleccionado_Click(object sender, EventArgs e)
        {
            if (nodoSeleccionado != null)
            {
                if (validarDatos(0) == 1)
                {
                    lista.AgregarDespSeleccionado(ingresarDatosNodo(), nodoSeleccionado.codigo);
                    nodoSeleccionado = null;
                    MostrarLista();
                }
            }
            else
                MessageBox.Show("Debe seleccionar un nodo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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