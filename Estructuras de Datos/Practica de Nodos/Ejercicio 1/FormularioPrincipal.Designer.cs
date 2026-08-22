namespace Ejercicio_1
{
    partial class frmFormularioPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalirPrograma = new System.Windows.Forms.Button();
            this.btnReiniciarPrograma = new System.Windows.Forms.Button();
            this.gboxSalidaDatos = new System.Windows.Forms.GroupBox();
            this.lblDatosPacientes = new System.Windows.Forms.Label();
            this.lblClickSeleccion = new System.Windows.Forms.Label();
            this.lstSalidaDatos = new System.Windows.Forms.ListBox();
            this.gboxEntradaDatos = new System.Windows.Forms.GroupBox();
            this.btnAgregarDespSeleccionado = new System.Windows.Forms.Button();
            this.btnActualizarPaciente = new System.Windows.Forms.Button();
            this.btnEliminarPaciente = new System.Windows.Forms.Button();
            this.btnIngresarPaciente = new System.Windows.Forms.Button();
            this.gboxDatosPaciente = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gboxSalidaDatos.SuspendLayout();
            this.gboxEntradaDatos.SuspendLayout();
            this.gboxDatosPaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalirPrograma
            // 
            this.btnSalirPrograma.Location = new System.Drawing.Point(808, 234);
            this.btnSalirPrograma.Name = "btnSalirPrograma";
            this.btnSalirPrograma.Size = new System.Drawing.Size(166, 23);
            this.btnSalirPrograma.TabIndex = 20;
            this.btnSalirPrograma.Text = "Salir Programa";
            this.btnSalirPrograma.UseVisualStyleBackColor = true;
            this.btnSalirPrograma.Click += new System.EventHandler(this.btnSalirPrograma_Click);
            // 
            // btnReiniciarPrograma
            // 
            this.btnReiniciarPrograma.Location = new System.Drawing.Point(630, 234);
            this.btnReiniciarPrograma.Name = "btnReiniciarPrograma";
            this.btnReiniciarPrograma.Size = new System.Drawing.Size(166, 23);
            this.btnReiniciarPrograma.TabIndex = 19;
            this.btnReiniciarPrograma.Text = "Reiniciar Programa";
            this.btnReiniciarPrograma.UseVisualStyleBackColor = true;
            this.btnReiniciarPrograma.Click += new System.EventHandler(this.btnReiniciarPrograma_Click);
            // 
            // gboxSalidaDatos
            // 
            this.gboxSalidaDatos.Controls.Add(this.lblDatosPacientes);
            this.gboxSalidaDatos.Controls.Add(this.lblClickSeleccion);
            this.gboxSalidaDatos.Controls.Add(this.lstSalidaDatos);
            this.gboxSalidaDatos.Location = new System.Drawing.Point(12, 12);
            this.gboxSalidaDatos.Name = "gboxSalidaDatos";
            this.gboxSalidaDatos.Size = new System.Drawing.Size(584, 426);
            this.gboxSalidaDatos.TabIndex = 18;
            this.gboxSalidaDatos.TabStop = false;
            this.gboxSalidaDatos.Text = "Salida Datos";
            // 
            // lblDatosPacientes
            // 
            this.lblDatosPacientes.AutoSize = true;
            this.lblDatosPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosPacientes.Location = new System.Drawing.Point(223, 16);
            this.lblDatosPacientes.Name = "lblDatosPacientes";
            this.lblDatosPacientes.Size = new System.Drawing.Size(115, 15);
            this.lblDatosPacientes.TabIndex = 2;
            this.lblDatosPacientes.Text = "Datos Pacientes:";
            // 
            // lblClickSeleccion
            // 
            this.lblClickSeleccion.AutoSize = true;
            this.lblClickSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClickSeleccion.Location = new System.Drawing.Point(113, 399);
            this.lblClickSeleccion.Name = "lblClickSeleccion";
            this.lblClickSeleccion.Size = new System.Drawing.Size(345, 15);
            this.lblClickSeleccion.TabIndex = 1;
            this.lblClickSeleccion.Text = "Haga click sobre algún elemento para seleccionarlo.";
            // 
            // lstSalidaDatos
            // 
            this.lstSalidaDatos.FormattingEnabled = true;
            this.lstSalidaDatos.HorizontalScrollbar = true;
            this.lstSalidaDatos.Location = new System.Drawing.Point(15, 45);
            this.lstSalidaDatos.Name = "lstSalidaDatos";
            this.lstSalidaDatos.Size = new System.Drawing.Size(552, 342);
            this.lstSalidaDatos.TabIndex = 0;
            this.lstSalidaDatos.SelectedIndexChanged += new System.EventHandler(this.lstSalidaDatos_SelectedIndexChanged);
            // 
            // gboxEntradaDatos
            // 
            this.gboxEntradaDatos.Controls.Add(this.btnAgregarDespSeleccionado);
            this.gboxEntradaDatos.Controls.Add(this.btnActualizarPaciente);
            this.gboxEntradaDatos.Controls.Add(this.btnEliminarPaciente);
            this.gboxEntradaDatos.Controls.Add(this.btnIngresarPaciente);
            this.gboxEntradaDatos.Controls.Add(this.gboxDatosPaciente);
            this.gboxEntradaDatos.Location = new System.Drawing.Point(602, 12);
            this.gboxEntradaDatos.Name = "gboxEntradaDatos";
            this.gboxEntradaDatos.Size = new System.Drawing.Size(391, 216);
            this.gboxEntradaDatos.TabIndex = 17;
            this.gboxEntradaDatos.TabStop = false;
            this.gboxEntradaDatos.Text = "Entrada Datos";
            // 
            // btnAgregarDespSeleccionado
            // 
            this.btnAgregarDespSeleccionado.Location = new System.Drawing.Point(234, 138);
            this.btnAgregarDespSeleccionado.Name = "btnAgregarDespSeleccionado";
            this.btnAgregarDespSeleccionado.Size = new System.Drawing.Size(138, 36);
            this.btnAgregarDespSeleccionado.TabIndex = 5;
            this.btnAgregarDespSeleccionado.Text = "Agregar Después Seleccionado";
            this.btnAgregarDespSeleccionado.UseVisualStyleBackColor = true;
            this.btnAgregarDespSeleccionado.Click += new System.EventHandler(this.btnAgregarDespSeleccionado_Click);
            // 
            // btnActualizarPaciente
            // 
            this.btnActualizarPaciente.Location = new System.Drawing.Point(234, 109);
            this.btnActualizarPaciente.Name = "btnActualizarPaciente";
            this.btnActualizarPaciente.Size = new System.Drawing.Size(138, 23);
            this.btnActualizarPaciente.TabIndex = 4;
            this.btnActualizarPaciente.Text = "Actualizar Paciente";
            this.btnActualizarPaciente.UseVisualStyleBackColor = true;
            this.btnActualizarPaciente.Click += new System.EventHandler(this.btnActualizarPaciente_Click);
            // 
            // btnEliminarPaciente
            // 
            this.btnEliminarPaciente.Location = new System.Drawing.Point(234, 80);
            this.btnEliminarPaciente.Name = "btnEliminarPaciente";
            this.btnEliminarPaciente.Size = new System.Drawing.Size(138, 23);
            this.btnEliminarPaciente.TabIndex = 3;
            this.btnEliminarPaciente.Text = "Eliminar Paciente";
            this.btnEliminarPaciente.UseVisualStyleBackColor = true;
            this.btnEliminarPaciente.Click += new System.EventHandler(this.btnEliminarPaciente_Click);
            // 
            // btnIngresarPaciente
            // 
            this.btnIngresarPaciente.Location = new System.Drawing.Point(234, 49);
            this.btnIngresarPaciente.Name = "btnIngresarPaciente";
            this.btnIngresarPaciente.Size = new System.Drawing.Size(138, 23);
            this.btnIngresarPaciente.TabIndex = 2;
            this.btnIngresarPaciente.Text = "Ingresar Paciente";
            this.btnIngresarPaciente.UseVisualStyleBackColor = true;
            this.btnIngresarPaciente.Click += new System.EventHandler(this.btnIngresarPaciente_Click);
            // 
            // gboxDatosPaciente
            // 
            this.gboxDatosPaciente.Controls.Add(this.txtTelefono);
            this.gboxDatosPaciente.Controls.Add(this.txtDireccion);
            this.gboxDatosPaciente.Controls.Add(this.txtApellido);
            this.gboxDatosPaciente.Controls.Add(this.txtNombres);
            this.gboxDatosPaciente.Controls.Add(this.txtCodigo);
            this.gboxDatosPaciente.Controls.Add(this.lblTelefono);
            this.gboxDatosPaciente.Controls.Add(this.lblDireccion);
            this.gboxDatosPaciente.Controls.Add(this.lblApellido);
            this.gboxDatosPaciente.Controls.Add(this.lblNombre);
            this.gboxDatosPaciente.Controls.Add(this.lblCodigo);
            this.gboxDatosPaciente.Location = new System.Drawing.Point(17, 33);
            this.gboxDatosPaciente.Name = "gboxDatosPaciente";
            this.gboxDatosPaciente.Size = new System.Drawing.Size(198, 163);
            this.gboxDatosPaciente.TabIndex = 1;
            this.gboxDatosPaciente.TabStop = false;
            this.gboxDatosPaciente.Text = "Datos Paciente";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(77, 125);
            this.txtTelefono.MaxLength = 100;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 9;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(77, 99);
            this.txtDireccion.MaxLength = 100;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 8;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(77, 73);
            this.txtApellido.MaxLength = 100;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 7;
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(77, 47);
            this.txtNombres.MaxLength = 100;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(100, 20);
            this.txtNombres.TabIndex = 6;
            this.txtNombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(77, 18);
            this.txtCodigo.MaxLength = 100;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 5;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(12, 128);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(12, 102);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 76);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(52, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombres:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 25);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // frmFormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 450);
            this.Controls.Add(this.btnSalirPrograma);
            this.Controls.Add(this.btnReiniciarPrograma);
            this.Controls.Add(this.gboxSalidaDatos);
            this.Controls.Add(this.gboxEntradaDatos);
            this.Name = "frmFormularioPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 1";
            this.gboxSalidaDatos.ResumeLayout(false);
            this.gboxSalidaDatos.PerformLayout();
            this.gboxEntradaDatos.ResumeLayout(false);
            this.gboxDatosPaciente.ResumeLayout(false);
            this.gboxDatosPaciente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalirPrograma;
        private System.Windows.Forms.Button btnReiniciarPrograma;
        private System.Windows.Forms.GroupBox gboxSalidaDatos;
        private System.Windows.Forms.Label lblDatosPacientes;
        private System.Windows.Forms.Label lblClickSeleccion;
        private System.Windows.Forms.ListBox lstSalidaDatos;
        private System.Windows.Forms.GroupBox gboxEntradaDatos;
        private System.Windows.Forms.Button btnAgregarDespSeleccionado;
        private System.Windows.Forms.Button btnActualizarPaciente;
        private System.Windows.Forms.Button btnEliminarPaciente;
        private System.Windows.Forms.Button btnIngresarPaciente;
        private System.Windows.Forms.GroupBox gboxDatosPaciente;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
    }
}

