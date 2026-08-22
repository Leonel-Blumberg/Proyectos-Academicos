using System;
using System.Linq;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class frmFormularioPrincipal : Form
    {
        Lista lista = new Lista();
        Nodo nodoSeleccionado;

        public frmFormularioPrincipal()
        {
            InitializeComponent();
        }

        // dniActual es el DNI que ya tiene el alumno que se está actualizando,
        // o 0 al cargar uno nuevo, para no rechazarlo como duplicado de sí mismo.
        public int ControlarIngresoDatos(int dniActual)
        {
            if (!txtNombre.Text.All(c => char.IsLetter(c) || c == ' '))
            {
                MessageBox.Show("Ingrese un nombre válido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Text = "";
                return 0;
            }
            else if (txtNombre.Text.Length < 3)
            {
                MessageBox.Show("El nombre debe tener al menos 3 caracteres.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Text = "";
                return 0;
            }

            if (!txtApellido.Text.All(c => char.IsLetter(c) || c == ' '))
            {
                MessageBox.Show("Ingrese un apellido válido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Text = "";
                return 0;
            }
            else if (txtApellido.Text.Length < 3)
            {
                MessageBox.Show("El apellido debe tener al menos 3 caracteres.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Text = "";
                return 0;
            }

            try
            {
                int dni = Convert.ToInt32(txtDni.Text);

                if (txtDni.Text.Length != 8)
                {
                    MessageBox.Show("El DNI debe tener 8 caracteres.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDni.Text = "";
                    return 0;
                }

                if (!txtDni.Text.All(char.IsDigit))
                {
                    MessageBox.Show("El DNI solo puede tener dígitos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDni.Text = "";
                    return 0;
                }

                if (dni != dniActual && lista.BuscarNodoActual(lista.inicio, dni) != null)
                {
                    MessageBox.Show("Ya existe un alumno con ese DNI.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDni.Text = "";
                    return 0;
                }
            }
            catch
            {
                MessageBox.Show("Ingrese un DNI válido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDni.Text = "";
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

        public Nodo IngresarDatosNodo()
        {
            Nodo unNuevoNodo = new Nodo();
            unNuevoNodo.nombre = txtNombre.Text;
            unNuevoNodo.apellido = txtApellido.Text;
            unNuevoNodo.dni = Convert.ToInt32(txtDni.Text);
            unNuevoNodo.fechaNacimiento = dtpFechaNacimiento.Value;
            unNuevoNodo.direccion = txtDireccion.Text;
            unNuevoNodo.telefono = Convert.ToInt64(txtTelefono.Text);

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            dtpFechaNacimiento.Value = new DateTime(2024, 1, 1);
            txtDireccion.Text = "";
            txtTelefono.Text = "";

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

        private void btnIngresarDatos_Click(object sender, EventArgs e)
        {
            if (ControlarIngresoDatos(0) == 1)
            {
                lista.IngresarNuevoAlumno(IngresarDatosNodo());
                MostrarLista();
            }
        }

        private void lstSalidaDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            nodoSeleccionado = (Nodo)lstSalidaDatos.SelectedItem;
        }

        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            if (nodoSeleccionado != null)
            {
                lista.EliminarAlumno(nodoSeleccionado.dni);
                nodoSeleccionado = null;
                MostrarLista();
            }
            else
                MessageBox.Show("Debe seleccionar un nodo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnActualizarAlumno_Click(object sender, EventArgs e)
        {
            if (nodoSeleccionado != null)
            {
                if (ControlarIngresoDatos(nodoSeleccionado.dni) == 1)
                {
                    lista.ActualizarAlumno(nodoSeleccionado.dni, IngresarDatosNodo());
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
                if (ControlarIngresoDatos(0) == 1)
                {
                    lista.AgregarDespSeleccionado(nodoSeleccionado.dni, IngresarDatosNodo());
                    nodoSeleccionado = null;
                    MostrarLista();
                }
            }
            else
                MessageBox.Show("Debe seleccionar un nodo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAgregarAntesSeleccionado_Click(object sender, EventArgs e)
        {
            if (nodoSeleccionado != null)
            {
                if (ControlarIngresoDatos(0) == 1)
                {
                    lista.AgregarAntesSeleccionado(nodoSeleccionado.dni, IngresarDatosNodo());
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