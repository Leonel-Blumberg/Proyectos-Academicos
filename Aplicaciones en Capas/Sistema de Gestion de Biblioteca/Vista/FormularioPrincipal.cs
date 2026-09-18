using Controladora;
using Entidades;
using System.Net.Mail;

namespace Vista
{
    public partial class FrmFormularioPrincipal : Form
    {
        public FrmFormularioPrincipal()
        {
            InitializeComponent();

            cmbLibro.DisplayMember = nameof(Libro.Titulo);
            cmbLibro.ValueMember = nameof(Libro.ISBN);
            cmbSocio.DisplayMember = nameof(Socio.DNI);
            cmbSocio.ValueMember = nameof(Socio.DNI);

            RellenarDGVyCMB();


            dtpFechaPrestamo.MaxDate = DateTime.Today;
            dtpFechaDevolucion.MinDate = DateTime.Today;
        }

        private readonly Controladora.Controladora controladora = Controladora.Controladora.Instancia;

        // Lógica para libros

        private void BtnAgregarLibro_Click(object sender, EventArgs e)
        {
            try
            {

                if (tbAutor.Text == string.Empty)
                    throw new DatosInvalidosException("El campo Autor no puede estar vacío.");

                if (tbTitulo.Text == string.Empty)
                    throw new DatosInvalidosException("El campo Título no puede estar vacío.");

                Libro libro = new()
                {
                    Autor = tbAutor.Text,
                    Titulo = tbTitulo.Text,
                };

                controladora.AgregarLibro(libro);
                LimpiarCamposLibros();
                RellenarDGVyCMB();
            }
            catch (DatosInvalidosException ex)
            {
                MessageBox.Show(ex.Message, "Error: Datos Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ElementoEnLaBaseDeDatosException ex)
            {
                MessageBox.Show(ex.Message, "Error: Elemento en base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModificarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbAutor.Text == string.Empty)
                    throw new DatosInvalidosException("El campo Autor no puede estar vacío.");

                if (tbTitulo.Text == string.Empty)
                    throw new DatosInvalidosException("El campo Título no puede estar vacío.");

                Libro libro = new()
                {
                    Autor = tbAutor.Text,
                    Titulo = tbTitulo.Text,
                };

                string isbn = ObtenerISBNLibro();

                if (isbn == string.Empty)
                    throw new DatosInvalidosException("Por favor, seleccione un libro a modificar.");

                controladora.ModificarLibro(libro, isbn);
                LimpiarCamposLibros();
                RellenarDGVyCMB();
            }
            catch (DatosInvalidosException ex)
            {
                MessageBox.Show(ex.Message, "Error: Datos Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ElementoEnLaBaseDeDatosException ex)
            {
                MessageBox.Show(ex.Message, "Error: Elemento en base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                string isbn = ObtenerISBNLibro();

                if (isbn == string.Empty)
                    throw new DatosInvalidosException("Por favor, seleccione un libro a eliminar.");

                controladora.EliminarLibro(isbn);
                RellenarDGVyCMB();
            }
            catch (DatosInvalidosException ex)
            {
                MessageBox.Show(ex.Message, "Error: Datos Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ElementoEnLaBaseDeDatosException ex)
            {
                MessageBox.Show(ex.Message, "Error: Elemento en base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgregarSocio_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbDNI.Text))
                    throw new DatosInvalidosException("El campo DNI no puede estar vacío.");

                if (!int.TryParse(tbDNI.Text, out int dni))
                    throw new DatosInvalidosException("El DNI debe contener solo números.");

                if (string.IsNullOrWhiteSpace(tbNombreCompleto.Text))
                    throw new DatosInvalidosException("El campo Nombre no puede estar vacío.");

                if (string.IsNullOrWhiteSpace(tbEmail.Text))
                    throw new DatosInvalidosException("El campo Email no puede estar vacío.");

                try
                {
                    MailAddress ma = new(tbEmail.Text);
                }
                catch (FormatException)
                {
                    throw new DatosInvalidosException("El formato del Email ingresado no es válido (ej: usuario@dominio.com).");
                }

                if (string.IsNullOrWhiteSpace(tbTelefono.Text))
                    throw new DatosInvalidosException("El campo Teléfono no puede estar vacío.");

                if (!long.TryParse(tbTelefono.Text, out long telefono))
                    throw new DatosInvalidosException("El Teléfono debe contener solo números.");

                Socio socio = new()
                {
                    DNI = dni,
                    NombreCompleto = tbNombreCompleto.Text,
                    Email = tbEmail.Text,
                    Telefono = telefono,
                };

                controladora.AgregarSocio(socio);
                LimpiarCamposSocios();
                RellenarDGVyCMB();
            }
            catch (DatosInvalidosException ex)
            {
                MessageBox.Show(ex.Message, "Error: Datos Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ElementoEnLaBaseDeDatosException ex)
            {
                MessageBox.Show(ex.Message, "Error: Elemento en base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModificarSocio_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbNombreCompleto.Text))
                    throw new DatosInvalidosException("El campo Nombre no puede estar vacío.");

                if (string.IsNullOrWhiteSpace(tbEmail.Text))
                    throw new DatosInvalidosException("El campo Email no puede estar vacío.");

                if (string.IsNullOrWhiteSpace(tbTelefono.Text))
                    throw new DatosInvalidosException("El campo Teléfono no puede estar vacío.");

                if (!long.TryParse(tbTelefono.Text, out long telefono))
                    throw new DatosInvalidosException("El Teléfono debe contener solo números.");

                Socio socio = new()
                {
                    NombreCompleto = tbNombreCompleto.Text,
                    Email = tbEmail.Text,
                    Telefono = telefono
                };

                int dni = ObtenerIdSocio();

                if (dni == -1)
                    throw new DatosInvalidosException("Por favor, seleccione un socio a modificar.");

                controladora.ModificarSocio(socio, dni);
                LimpiarCamposSocios();
                RellenarDGVyCMB();
            }
            catch (DatosInvalidosException ex)
            {
                MessageBox.Show(ex.Message, "Error: Datos Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ElementoEnLaBaseDeDatosException ex)
            {
                MessageBox.Show(ex.Message, "Error: Elemento en base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminarSocio_Click(object sender, EventArgs e)
        {
            try
            {
                int dni = ObtenerIdSocio();

                if (dni == -1)
                    throw new DatosInvalidosException("Por favor, seleccione un socio a eliminar.");

                controladora.EliminarSocio(dni);
                RellenarDGVyCMB();
            }
            catch (DatosInvalidosException ex)
            {
                MessageBox.Show(ex.Message, "Error: Datos Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ElementoEnLaBaseDeDatosException ex)
            {
                MessageBox.Show(ex.Message, "Error: Elemento en base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgregarPrestamo_Click(object sender, EventArgs e)
        {
            try
            {
                Prestamo prestamo = ArmarPrestamo();

                string mensaje = controladora.AgregarPrestamo(prestamo);

                RellenarDGVyCMB();
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModificarPrestamo_Click(object sender, EventArgs e)
        {
            try
            {
                int id = ObtenerIdPrestamo();

                if (id == -1)
                    throw new DatosInvalidosException("Debe seleccionar un préstamo.");

                Prestamo prestamo = ArmarPrestamo();

                controladora.ModificarPrestamo(prestamo, id);
                RellenarDGVyCMB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDevolverPrestamo_Click(object sender, EventArgs e)
        {
            try
            {
                int id = ObtenerIdPrestamo();

                if (id == -1)
                    throw new DatosInvalidosException("Debe seleccionar un préstamo.");

                controladora.DevolverPrestamo(id);
                RellenarDGVyCMB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Métodos auxiliares
        private void RellenarDGVyCMB()
        {
            // Cada control recibe su propia lista. Si dos controles comparten la
            // misma, el formulario sincroniza la posición y seleccionar una fila
            // de la tabla cambia el combo.
            cmbLibro.DataSource = controladora.ListarLibros();
            cmbSocio.DataSource = controladora.ListarSocios();

            dgvPrestamos.DataSource = null;
            dgvPrestamos.DataSource = controladora.ListarPrestamos();

            dgvLibros.DataSource = null;
            dgvLibros.DataSource = controladora.ListarLibros();

            dgvSocios.DataSource = null;
            dgvSocios.DataSource = controladora.ListarSocios();
        }

        private Prestamo ArmarPrestamo()
        {
            if (cmbLibro.SelectedValue is not string isbn)
                throw new DatosInvalidosException("Debe seleccionar un libro.");

            if (cmbSocio.SelectedValue is not int dni)
                throw new DatosInvalidosException("Debe seleccionar un socio.");

            return new Prestamo()
            {
                FechaPrestamo = DateOnly.FromDateTime(dtpFechaPrestamo.Value),
                FechaDevolucion = DateOnly.FromDateTime(dtpFechaDevolucion.Value),
                ISBN = isbn,
                DNI = dni
            };
        }

        private string ObtenerISBNLibro()
        {
            try
            {
                if (dgvLibros.CurrentRow == null)
                    return string.Empty;

                object? valor = dgvLibros.CurrentRow.Cells["ISBN"].Value;

                if (valor == null || valor == DBNull.Value)
                    return string.Empty;

                return valor.ToString()!;
            }
            catch
            {
                return string.Empty;
            }
        }

        private int ObtenerIdSocio()
        {
            if (dgvSocios.CurrentRow?.Cells["DNI"].Value is int dni)
                return dni;

            return -1;
        }

        private int ObtenerIdPrestamo()
        {
            if (dgvPrestamos.CurrentRow?.Cells["ID"].Value is int id)
                return id;

            return -1;
        }

        private void LimpiarCamposLibros()
        {
            tbAutor.Clear();
            tbTitulo.Clear();
        }

        private void LimpiarCamposSocios()
        {
            tbDNI.Clear();
            tbNombreCompleto.Clear();
            tbEmail.Clear();
            tbTelefono.Clear();
        }
    }
}
