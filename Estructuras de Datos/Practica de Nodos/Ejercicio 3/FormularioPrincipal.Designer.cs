namespace Ejercicio_3
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
            this.btnAgregarDespSeleccionado = new System.Windows.Forms.Button();
            this.btnSalirPrograma = new System.Windows.Forms.Button();
            this.btnActualizarPersona = new System.Windows.Forms.Button();
            this.btnReiniciarPrograma = new System.Windows.Forms.Button();
            this.btnEliminarPersona = new System.Windows.Forms.Button();
            this.gboxSalidaDatos = new System.Windows.Forms.GroupBox();
            this.lblDatosPersonas = new System.Windows.Forms.Label();
            this.lblClickSeleccion = new System.Windows.Forms.Label();
            this.lstSalidaDatos = new System.Windows.Forms.ListBox();
            this.btnIngresarPersona = new System.Windows.Forms.Button();
            this.gboxSalidaDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarDespSeleccionado
            // 
            this.btnAgregarDespSeleccionado.Location = new System.Drawing.Point(503, 179);
            this.btnAgregarDespSeleccionado.Name = "btnAgregarDespSeleccionado";
            this.btnAgregarDespSeleccionado.Size = new System.Drawing.Size(138, 36);
            this.btnAgregarDespSeleccionado.TabIndex = 35;
            this.btnAgregarDespSeleccionado.Text = "Agregar Después Seleccionado";
            this.btnAgregarDespSeleccionado.UseVisualStyleBackColor = true;
            this.btnAgregarDespSeleccionado.Click += new System.EventHandler(this.btnAgregarDespSeleccionado_Click);
            // 
            // btnSalirPrograma
            // 
            this.btnSalirPrograma.Location = new System.Drawing.Point(503, 307);
            this.btnSalirPrograma.Name = "btnSalirPrograma";
            this.btnSalirPrograma.Size = new System.Drawing.Size(138, 23);
            this.btnSalirPrograma.TabIndex = 38;
            this.btnSalirPrograma.Text = "Salir Programa";
            this.btnSalirPrograma.UseVisualStyleBackColor = true;
            this.btnSalirPrograma.Click += new System.EventHandler(this.btnSalirPrograma_Click);
            // 
            // btnActualizarPersona
            // 
            this.btnActualizarPersona.Location = new System.Drawing.Point(503, 150);
            this.btnActualizarPersona.Name = "btnActualizarPersona";
            this.btnActualizarPersona.Size = new System.Drawing.Size(138, 23);
            this.btnActualizarPersona.TabIndex = 34;
            this.btnActualizarPersona.Text = "Actualizar Persona";
            this.btnActualizarPersona.UseVisualStyleBackColor = true;
            this.btnActualizarPersona.Click += new System.EventHandler(this.btnActualizarPersona_Click);
            // 
            // btnReiniciarPrograma
            // 
            this.btnReiniciarPrograma.Location = new System.Drawing.Point(503, 336);
            this.btnReiniciarPrograma.Name = "btnReiniciarPrograma";
            this.btnReiniciarPrograma.Size = new System.Drawing.Size(138, 23);
            this.btnReiniciarPrograma.TabIndex = 37;
            this.btnReiniciarPrograma.Text = "Reiniciar Programa";
            this.btnReiniciarPrograma.UseVisualStyleBackColor = true;
            this.btnReiniciarPrograma.Click += new System.EventHandler(this.btnReiniciarPrograma_Click);
            // 
            // btnEliminarPersona
            // 
            this.btnEliminarPersona.Location = new System.Drawing.Point(503, 121);
            this.btnEliminarPersona.Name = "btnEliminarPersona";
            this.btnEliminarPersona.Size = new System.Drawing.Size(138, 23);
            this.btnEliminarPersona.TabIndex = 33;
            this.btnEliminarPersona.Text = "Eliminar Persona";
            this.btnEliminarPersona.UseVisualStyleBackColor = true;
            this.btnEliminarPersona.Click += new System.EventHandler(this.btnEliminarPersona_Click);
            // 
            // gboxSalidaDatos
            // 
            this.gboxSalidaDatos.Controls.Add(this.lblDatosPersonas);
            this.gboxSalidaDatos.Controls.Add(this.lblClickSeleccion);
            this.gboxSalidaDatos.Controls.Add(this.lstSalidaDatos);
            this.gboxSalidaDatos.Location = new System.Drawing.Point(12, 12);
            this.gboxSalidaDatos.Name = "gboxSalidaDatos";
            this.gboxSalidaDatos.Size = new System.Drawing.Size(475, 426);
            this.gboxSalidaDatos.TabIndex = 36;
            this.gboxSalidaDatos.TabStop = false;
            this.gboxSalidaDatos.Text = "Salida Datos";
            // 
            // lblDatosPersonas
            // 
            this.lblDatosPersonas.AutoSize = true;
            this.lblDatosPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosPersonas.Location = new System.Drawing.Point(185, 16);
            this.lblDatosPersonas.Name = "lblDatosPersonas";
            this.lblDatosPersonas.Size = new System.Drawing.Size(108, 15);
            this.lblDatosPersonas.TabIndex = 2;
            this.lblDatosPersonas.Text = "Datos Personas";
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
            // btnIngresarPersona
            // 
            this.btnIngresarPersona.Location = new System.Drawing.Point(503, 92);
            this.btnIngresarPersona.Name = "btnIngresarPersona";
            this.btnIngresarPersona.Size = new System.Drawing.Size(138, 23);
            this.btnIngresarPersona.TabIndex = 32;
            this.btnIngresarPersona.Text = "Ingresar Persona";
            this.btnIngresarPersona.UseVisualStyleBackColor = true;
            this.btnIngresarPersona.Click += new System.EventHandler(this.btnIngresarPersona_Click);
            // 
            // frmFormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.btnAgregarDespSeleccionado);
            this.Controls.Add(this.btnSalirPrograma);
            this.Controls.Add(this.btnActualizarPersona);
            this.Controls.Add(this.btnReiniciarPrograma);
            this.Controls.Add(this.btnEliminarPersona);
            this.Controls.Add(this.gboxSalidaDatos);
            this.Controls.Add(this.btnIngresarPersona);
            this.Name = "frmFormularioPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 3";
            this.Load += new System.EventHandler(this.frmFormularioPrincipal_Load);
            this.gboxSalidaDatos.ResumeLayout(false);
            this.gboxSalidaDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarDespSeleccionado;
        private System.Windows.Forms.Button btnSalirPrograma;
        private System.Windows.Forms.Button btnActualizarPersona;
        private System.Windows.Forms.Button btnReiniciarPrograma;
        private System.Windows.Forms.Button btnEliminarPersona;
        private System.Windows.Forms.GroupBox gboxSalidaDatos;
        private System.Windows.Forms.Label lblDatosPersonas;
        private System.Windows.Forms.Label lblClickSeleccion;
        private System.Windows.Forms.ListBox lstSalidaDatos;
        private System.Windows.Forms.Button btnIngresarPersona;
    }
}

