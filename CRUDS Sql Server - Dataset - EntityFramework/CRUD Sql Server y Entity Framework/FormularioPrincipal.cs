using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using CRUD_Sql_Server_y_Entity_Framework.Models;

namespace CRUD_Sql_Server_y_Entity_Framework
{
    public partial class frmFormularioPrincipal : Form
    {
        public frmFormularioPrincipal()
        {
            InitializeComponent();

            ActualizarDTPFechaNacimiento();
            RefrescarDGV();
        }

        private void ActualizarDTPFechaNacimiento()
        {
            dtpFechaNacimiento.MaxDate = DateTime.Today;
            dtpFechaNacimiento.Value = DateTime.Today;
        }

        private void RefrescarDGV()
        {
            try
            {
                using CRUDconEntityFramework db = new();
                var listaDatos = db.Personas3.ToList();
                dgvVisDatos.DataSource = listaDatos;
                dgvVisDatos.Columns["FechaDeNacimiento"].HeaderText = "Fecha de Nacimiento";
            }
            catch (DbException ex)
            {
                MessageBox.Show("Error al obtener los datos de la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ModificarDato(null);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int? id = GetID();

            if (id != null)
                ModificarDato(id);
            else
                MessageBox.Show("No se pudo obtener el ID de la persona seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ModificarDato(int? id)
        {
            if (VerificarDatos() == true)
            {
                try
                {
                    using CRUDconEntityFramework db = new();
                    Personas3 oPersonas3 = new();

                    if (id != null)
                    {
                        Personas3? oExistente = db.Personas3.Find(id);

                        if (oExistente == null)
                        {
                            MessageBox.Show("La persona seleccionada ya no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            RefrescarDGV();
                            return;
                        }

                        oPersonas3 = oExistente;
                    }

                    oPersonas3.Nombre = txtNombre.Text.Trim();
                    oPersonas3.Correo = txtCorreo.Text.Trim();
                    oPersonas3.FechaDeNacimiento = DateOnly.FromDateTime(dtpFechaNacimiento.Value);

                    if (id == null)
                        db.Personas3.Add(oPersonas3);

                    db.SaveChanges();

                    txtNombre.Text = "";
                    txtCorreo.Text = "";
                    ActualizarDTPFechaNacimiento();

                    if (id == null)
                        MessageBox.Show("Persona agregada con éxito.", "Info: Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Persona modificada con éxito.", "Info: Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show("Error al guardar los datos en la base de datos: " + (ex.InnerException?.Message ?? ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (DbException ex)
                {
                    MessageBox.Show("Error al guardar los datos en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                RefrescarDGV();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetID();

            if (id != null)
            {
                try
                {
                    using CRUDconEntityFramework db = new();

                    Personas3? oPersonas3 = db.Personas3.Find(id);

                    if (oPersonas3 == null)
                        MessageBox.Show("La persona seleccionada ya no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        db.Personas3.Remove(oPersonas3);
                        db.SaveChanges();

                        MessageBox.Show("Persona eliminada con éxito.", "Info: Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show("Error al eliminar los datos de la base de datos: " + (ex.InnerException?.Message ?? ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (DbException ex)
                {
                    MessageBox.Show("Error al eliminar los datos de la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                RefrescarDGV();
            }
            else
                MessageBox.Show("No se pudo obtener el ID de la persona seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #region HELPER
        private int? GetID()
        {
            try { return int.Parse(dgvVisDatos.Rows[dgvVisDatos.CurrentRow.Index].Cells[0].Value.ToString()!); }
            catch { return null; }
        }
        #endregion

        private bool VerificarDatos()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                    throw new DatoIncompletoException("Debe ingresar un nombre.");

                if (string.IsNullOrWhiteSpace(txtCorreo.Text))
                    throw new DatoIncompletoException("Debe ingresar un correo.");
            }
            catch (DatoIncompletoException ex)
            {
                MessageBox.Show(ex.Message, "Aviso: Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            RefrescarDGV();
        }

        private void DgvVisDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVisDatos.SelectedRows.Count > 0)
            {
                btnEditar.BackColor = Color.DarkOrange;
                btnEditar.Enabled = true;

                btnEliminar.BackColor = Color.DarkOrange;
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEditar.BackColor = Color.Silver;
                btnEditar.Enabled = false;

                btnEliminar.BackColor = Color.Silver;
                btnEliminar.Enabled = false;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnReiniciar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
