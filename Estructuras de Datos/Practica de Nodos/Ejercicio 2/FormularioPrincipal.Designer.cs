namespace Ejercicio_2
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
            this.lblDatosAlumnos = new System.Windows.Forms.Label();
            this.lblClickSeleccion = new System.Windows.Forms.Label();
            this.lstSalidaDatos = new System.Windows.Forms.ListBox();
            this.gboxEntradaDatos = new System.Windows.Forms.GroupBox();
            this.btnAgregarAntesSeleccionado = new System.Windows.Forms.Button();
            this.btnAgregarDespSeleccionado = new System.Windows.Forms.Button();
            this.btnActualizarAlumno = new System.Windows.Forms.Button();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnIngresarDatos = new System.Windows.Forms.Button();
            this.gboxDatosAlumnos = new System.Windows.Forms.GroupBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gboxSalidaDatos.SuspendLayout();
            this.gboxEntradaDatos.SuspendLayout();
            this.gboxDatosAlumnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalirPrograma
            // 
            this.btnSalirPrograma.Location = new System.Drawing.Point(734, 257);
            this.btnSalirPrograma.Name = "btnSalirPrograma";
            this.btnSalirPrograma.Size = new System.Drawing.Size(166, 23);
            this.btnSalirPrograma.TabIndex = 24;
            this.btnSalirPrograma.Text = "Salir Programa";
            this.btnSalirPrograma.UseVisualStyleBackColor = true;
            this.btnSalirPrograma.Click += new System.EventHandler(this.btnSalirPrograma_Click);
            // 
            // btnReiniciarPrograma
            // 
            this.btnReiniciarPrograma.Location = new System.Drawing.Point(530, 257);
            this.btnReiniciarPrograma.Name = "btnReiniciarPrograma";
            this.btnReiniciarPrograma.Size = new System.Drawing.Size(166, 23);
            this.btnReiniciarPrograma.TabIndex = 23;
            this.btnReiniciarPrograma.Text = "Reiniciar Programa";
            this.btnReiniciarPrograma.UseVisualStyleBackColor = true;
            this.btnReiniciarPrograma.Click += new System.EventHandler(this.btnReiniciarPrograma_Click);
            // 
            // gboxSalidaDatos
            // 
            this.gboxSalidaDatos.Controls.Add(this.lblDatosAlumnos);
            this.gboxSalidaDatos.Controls.Add(this.lblClickSeleccion);
            this.gboxSalidaDatos.Controls.Add(this.lstSalidaDatos);
            this.gboxSalidaDatos.Location = new System.Drawing.Point(12, 12);
            this.gboxSalidaDatos.Name = "gboxSalidaDatos";
            this.gboxSalidaDatos.Size = new System.Drawing.Size(475, 426);
            this.gboxSalidaDatos.TabIndex = 22;
            this.gboxSalidaDatos.TabStop = false;
            this.gboxSalidaDatos.Text = "Salida Datos";
            // 
            // lblDatosAlumnos
            // 
            this.lblDatosAlumnos.AutoSize = true;
            this.lblDatosAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosAlumnos.Location = new System.Drawing.Point(185, 16);
            this.lblDatosAlumnos.Name = "lblDatosAlumnos";
            this.lblDatosAlumnos.Size = new System.Drawing.Size(103, 15);
            this.lblDatosAlumnos.TabIndex = 2;
            this.lblDatosAlumnos.Text = "Datos Alumnos";
            // 
            // lblClickSeleccion
            // 
            this.lblClickSeleccion.AutoSize = true;
            this.lblClickSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClickSeleccion.Location = new System.Drawing.Point(74, 399);
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
            this.lstSalidaDatos.Size = new System.Drawing.Size(443, 342);
            this.lstSalidaDatos.TabIndex = 0;
            this.lstSalidaDatos.SelectedIndexChanged += new System.EventHandler(this.lstSalidaDatos_SelectedIndexChanged);
            // 
            // gboxEntradaDatos
            // 
            this.gboxEntradaDatos.Controls.Add(this.btnAgregarAntesSeleccionado);
            this.gboxEntradaDatos.Controls.Add(this.btnAgregarDespSeleccionado);
            this.gboxEntradaDatos.Controls.Add(this.btnActualizarAlumno);
            this.gboxEntradaDatos.Controls.Add(this.btnEliminarAlumno);
            this.gboxEntradaDatos.Controls.Add(this.txtTelefono);
            this.gboxEntradaDatos.Controls.Add(this.btnIngresarDatos);
            this.gboxEntradaDatos.Controls.Add(this.gboxDatosAlumnos);
            this.gboxEntradaDatos.Location = new System.Drawing.Point(493, 12);
            this.gboxEntradaDatos.Name = "gboxEntradaDatos";
            this.gboxEntradaDatos.Size = new System.Drawing.Size(441, 239);
            this.gboxEntradaDatos.TabIndex = 21;
            this.gboxEntradaDatos.TabStop = false;
            this.gboxEntradaDatos.Text = "Entrada Datos";
            // 
            // btnAgregarAntesSeleccionado
            // 
            this.btnAgregarAntesSeleccionado.Location = new System.Drawing.Point(284, 174);
            this.btnAgregarAntesSeleccionado.Name = "btnAgregarAntesSeleccionado";
            this.btnAgregarAntesSeleccionado.Size = new System.Drawing.Size(138, 36);
            this.btnAgregarAntesSeleccionado.TabIndex = 10;
            this.btnAgregarAntesSeleccionado.Text = "Agregar Antes Seleccionado";
            this.btnAgregarAntesSeleccionado.UseVisualStyleBackColor = true;
            this.btnAgregarAntesSeleccionado.Click += new System.EventHandler(this.btnAgregarAntesSeleccionado_Click);
            // 
            // btnAgregarDespSeleccionado
            // 
            this.btnAgregarDespSeleccionado.Location = new System.Drawing.Point(284, 129);
            this.btnAgregarDespSeleccionado.Name = "btnAgregarDespSeleccionado";
            this.btnAgregarDespSeleccionado.Size = new System.Drawing.Size(138, 36);
            this.btnAgregarDespSeleccionado.TabIndex = 5;
            this.btnAgregarDespSeleccionado.Text = "Agregar Después Seleccionado";
            this.btnAgregarDespSeleccionado.UseVisualStyleBackColor = true;
            this.btnAgregarDespSeleccionado.Click += new System.EventHandler(this.btnAgregarDespSeleccionado_Click);
            // 
            // btnActualizarAlumno
            // 
            this.btnActualizarAlumno.Location = new System.Drawing.Point(284, 100);
            this.btnActualizarAlumno.Name = "btnActualizarAlumno";
            this.btnActualizarAlumno.Size = new System.Drawing.Size(138, 23);
            this.btnActualizarAlumno.TabIndex = 4;
            this.btnActualizarAlumno.Text = "Actualizar Alumno";
            this.btnActualizarAlumno.UseVisualStyleBackColor = true;
            this.btnActualizarAlumno.Click += new System.EventHandler(this.btnActualizarAlumno_Click);
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.Location = new System.Drawing.Point(284, 73);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Size = new System.Drawing.Size(138, 23);
            this.btnEliminarAlumno.TabIndex = 3;
            this.btnEliminarAlumno.Text = "Eliminar Alumno";
            this.btnEliminarAlumno.UseVisualStyleBackColor = true;
            this.btnEliminarAlumno.Click += new System.EventHandler(this.btnEliminarAlumno_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(141, 183);
            this.txtTelefono.MaxLength = 100;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 9;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnIngresarDatos
            // 
            this.btnIngresarDatos.Location = new System.Drawing.Point(284, 44);
            this.btnIngresarDatos.Name = "btnIngresarDatos";
            this.btnIngresarDatos.Size = new System.Drawing.Size(138, 23);
            this.btnIngresarDatos.TabIndex = 2;
            this.btnIngresarDatos.Text = "Ingresar Datos";
            this.btnIngresarDatos.UseVisualStyleBackColor = true;
            this.btnIngresarDatos.Click += new System.EventHandler(this.btnIngresarDatos_Click);
            // 
            // gboxDatosAlumnos
            // 
            this.gboxDatosAlumnos.Controls.Add(this.lblDireccion);
            this.gboxDatosAlumnos.Controls.Add(this.txtDireccion);
            this.gboxDatosAlumnos.Controls.Add(this.dtpFechaNacimiento);
            this.gboxDatosAlumnos.Controls.Add(this.lblDni);
            this.gboxDatosAlumnos.Controls.Add(this.txtDni);
            this.gboxDatosAlumnos.Controls.Add(this.txtApellido);
            this.gboxDatosAlumnos.Controls.Add(this.txtNombre);
            this.gboxDatosAlumnos.Controls.Add(this.lblTelefono);
            this.gboxDatosAlumnos.Controls.Add(this.lblFechaNacimiento);
            this.gboxDatosAlumnos.Controls.Add(this.lblApellido);
            this.gboxDatosAlumnos.Controls.Add(this.lblNombre);
            this.gboxDatosAlumnos.Location = new System.Drawing.Point(17, 33);
            this.gboxDatosAlumnos.Name = "gboxDatosAlumnos";
            this.gboxDatosAlumnos.Size = new System.Drawing.Size(244, 186);
            this.gboxDatosAlumnos.TabIndex = 1;
            this.gboxDatosAlumnos.TabStop = false;
            this.gboxDatosAlumnos.Text = "Datos Alumnos";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(17, 124);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 23;
            this.lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(124, 124);
            this.txtDireccion.MaxLength = 100;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 22;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(124, 96);
            this.dtpFechaNacimiento.MaxDate = new System.DateTime(2024, 9, 21, 0, 0, 0, 0);
            this.dtpFechaNacimiento.MinDate = new System.DateTime(1924, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaNacimiento.TabIndex = 21;
            this.dtpFechaNacimiento.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(17, 73);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 10;
            this.lblDni.Text = "DNI:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(124, 70);
            this.txtDni.MaxLength = 100;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 7;
            this.txtDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(124, 44);
            this.txtApellido.MaxLength = 100;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 6;
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(124, 18);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(17, 150);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(15, 98);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(96, 13);
            this.lblFechaNacimiento.TabIndex = 3;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(16, 47);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 21);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // frmFormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 450);
            this.Controls.Add(this.btnSalirPrograma);
            this.Controls.Add(this.btnReiniciarPrograma);
            this.Controls.Add(this.gboxSalidaDatos);
            this.Controls.Add(this.gboxEntradaDatos);
            this.Name = "frmFormularioPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 2";
            this.gboxSalidaDatos.ResumeLayout(false);
            this.gboxSalidaDatos.PerformLayout();
            this.gboxEntradaDatos.ResumeLayout(false);
            this.gboxEntradaDatos.PerformLayout();
            this.gboxDatosAlumnos.ResumeLayout(false);
            this.gboxDatosAlumnos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalirPrograma;
        private System.Windows.Forms.Button btnReiniciarPrograma;
        private System.Windows.Forms.GroupBox gboxSalidaDatos;
        private System.Windows.Forms.Label lblDatosAlumnos;
        private System.Windows.Forms.Label lblClickSeleccion;
        private System.Windows.Forms.ListBox lstSalidaDatos;
        private System.Windows.Forms.GroupBox gboxEntradaDatos;
        private System.Windows.Forms.Button btnAgregarAntesSeleccionado;
        private System.Windows.Forms.Button btnAgregarDespSeleccionado;
        private System.Windows.Forms.Button btnActualizarAlumno;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnIngresarDatos;
        private System.Windows.Forms.GroupBox gboxDatosAlumnos;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
    }
}

