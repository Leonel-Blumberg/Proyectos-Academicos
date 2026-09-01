namespace Ejercicio_1
{
    partial class FrmFormularioPrincipal
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
            this.btnSalirAplicacion = new System.Windows.Forms.Button();
            this.btnReiniciarAplicacion = new System.Windows.Forms.Button();
            this.gboxEntrDatos = new System.Windows.Forms.GroupBox();
            this.btnVerTope = new System.Windows.Forms.Button();
            this.btnApilar = new System.Windows.Forms.Button();
            this.txtNumIdent = new System.Windows.Forms.TextBox();
            this.lblNumIdent = new System.Windows.Forms.Label();
            this.gboxEntradaDatos = new System.Windows.Forms.GroupBox();
            this.lblDobleClick = new System.Windows.Forms.Label();
            this.lblContenedores = new System.Windows.Forms.Label();
            this.lstSalidaDatos = new System.Windows.Forms.ListBox();
            this.gboxEntrDatos.SuspendLayout();
            this.gboxEntradaDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalirAplicacion
            // 
            this.btnSalirAplicacion.Location = new System.Drawing.Point(544, 142);
            this.btnSalirAplicacion.Name = "btnSalirAplicacion";
            this.btnSalirAplicacion.Size = new System.Drawing.Size(123, 23);
            this.btnSalirAplicacion.TabIndex = 15;
            this.btnSalirAplicacion.Text = "Salir Aplicación";
            this.btnSalirAplicacion.UseVisualStyleBackColor = true;
            this.btnSalirAplicacion.Click += new System.EventHandler(this.BtnSalirAplicacion_Click);
            // 
            // btnReiniciarAplicacion
            // 
            this.btnReiniciarAplicacion.Location = new System.Drawing.Point(408, 142);
            this.btnReiniciarAplicacion.Name = "btnReiniciarAplicacion";
            this.btnReiniciarAplicacion.Size = new System.Drawing.Size(123, 23);
            this.btnReiniciarAplicacion.TabIndex = 14;
            this.btnReiniciarAplicacion.Text = "Reiniciar Aplicación";
            this.btnReiniciarAplicacion.UseVisualStyleBackColor = true;
            this.btnReiniciarAplicacion.Click += new System.EventHandler(this.BtnReiniciarAplicacion_Click);
            // 
            // gboxEntrDatos
            // 
            this.gboxEntrDatos.Controls.Add(this.btnVerTope);
            this.gboxEntrDatos.Controls.Add(this.btnApilar);
            this.gboxEntrDatos.Controls.Add(this.txtNumIdent);
            this.gboxEntrDatos.Controls.Add(this.lblNumIdent);
            this.gboxEntrDatos.Location = new System.Drawing.Point(392, 12);
            this.gboxEntrDatos.Name = "gboxEntrDatos";
            this.gboxEntrDatos.Size = new System.Drawing.Size(298, 124);
            this.gboxEntrDatos.TabIndex = 13;
            this.gboxEntrDatos.TabStop = false;
            this.gboxEntrDatos.Text = "Entrada Datos";
            // 
            // btnVerTope
            // 
            this.btnVerTope.Enabled = false;
            this.btnVerTope.Location = new System.Drawing.Point(83, 84);
            this.btnVerTope.Name = "btnVerTope";
            this.btnVerTope.Size = new System.Drawing.Size(123, 23);
            this.btnVerTope.TabIndex = 9;
            this.btnVerTope.Text = "Ver Tope";
            this.btnVerTope.UseVisualStyleBackColor = true;
            this.btnVerTope.Click += new System.EventHandler(this.BtnVerTope_Click);
            // 
            // btnApilar
            // 
            this.btnApilar.Location = new System.Drawing.Point(83, 55);
            this.btnApilar.Name = "btnApilar";
            this.btnApilar.Size = new System.Drawing.Size(123, 23);
            this.btnApilar.TabIndex = 7;
            this.btnApilar.Text = "Apilar";
            this.btnApilar.UseVisualStyleBackColor = true;
            this.btnApilar.Click += new System.EventHandler(this.BtnApilar_Click);
            // 
            // txtNumIdent
            // 
            this.txtNumIdent.Location = new System.Drawing.Point(142, 22);
            this.txtNumIdent.MaxLength = 12;
            this.txtNumIdent.Name = "txtNumIdent";
            this.txtNumIdent.Size = new System.Drawing.Size(133, 20);
            this.txtNumIdent.TabIndex = 5;
            // 
            // lblNumIdent
            // 
            this.lblNumIdent.AutoSize = true;
            this.lblNumIdent.Location = new System.Drawing.Point(18, 25);
            this.lblNumIdent.Name = "lblNumIdent";
            this.lblNumIdent.Size = new System.Drawing.Size(113, 13);
            this.lblNumIdent.TabIndex = 1;
            this.lblNumIdent.Text = "Número Identificación:";
            // 
            // gboxEntradaDatos
            // 
            this.gboxEntradaDatos.Controls.Add(this.lblDobleClick);
            this.gboxEntradaDatos.Controls.Add(this.lblContenedores);
            this.gboxEntradaDatos.Controls.Add(this.lstSalidaDatos);
            this.gboxEntradaDatos.Location = new System.Drawing.Point(-1, 12);
            this.gboxEntradaDatos.Name = "gboxEntradaDatos";
            this.gboxEntradaDatos.Size = new System.Drawing.Size(377, 426);
            this.gboxEntradaDatos.TabIndex = 12;
            this.gboxEntradaDatos.TabStop = false;
            this.gboxEntradaDatos.Text = "Salida Datos";
            // 
            // lblDobleClick
            // 
            this.lblDobleClick.AutoSize = true;
            this.lblDobleClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobleClick.Location = new System.Drawing.Point(25, 386);
            this.lblDobleClick.Name = "lblDobleClick";
            this.lblDobleClick.Size = new System.Drawing.Size(326, 16);
            this.lblDobleClick.TabIndex = 3;
            this.lblDobleClick.Text = "Haga doble click para eliminar un contenedor.";
            // 
            // lblContenedores
            // 
            this.lblContenedores.AutoSize = true;
            this.lblContenedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContenedores.Location = new System.Drawing.Point(126, 22);
            this.lblContenedores.Name = "lblContenedores";
            this.lblContenedores.Size = new System.Drawing.Size(108, 16);
            this.lblContenedores.TabIndex = 2;
            this.lblContenedores.Text = "Contenedores:";
            // 
            // lstSalidaDatos
            // 
            this.lstSalidaDatos.FormattingEnabled = true;
            this.lstSalidaDatos.Location = new System.Drawing.Point(15, 55);
            this.lstSalidaDatos.Name = "lstSalidaDatos";
            this.lstSalidaDatos.Size = new System.Drawing.Size(344, 316);
            this.lstSalidaDatos.TabIndex = 0;
            this.lstSalidaDatos.DoubleClick += new System.EventHandler(this.LstSalidaDatos_DoubleClick);
            // 
            // frmFormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.btnSalirAplicacion);
            this.Controls.Add(this.btnReiniciarAplicacion);
            this.Controls.Add(this.gboxEntrDatos);
            this.Controls.Add(this.gboxEntradaDatos);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(718, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(718, 489);
            this.Name = "frmFormularioPrincipal";
            this.Text = "Ejercicio 1";
            this.gboxEntrDatos.ResumeLayout(false);
            this.gboxEntrDatos.PerformLayout();
            this.gboxEntradaDatos.ResumeLayout(false);
            this.gboxEntradaDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalirAplicacion;
        private System.Windows.Forms.Button btnReiniciarAplicacion;
        private System.Windows.Forms.GroupBox gboxEntrDatos;
        private System.Windows.Forms.Button btnVerTope;
        private System.Windows.Forms.Button btnApilar;
        private System.Windows.Forms.TextBox txtNumIdent;
        private System.Windows.Forms.Label lblNumIdent;
        private System.Windows.Forms.GroupBox gboxEntradaDatos;
        private System.Windows.Forms.Label lblContenedores;
        private System.Windows.Forms.ListBox lstSalidaDatos;
        private System.Windows.Forms.Label lblDobleClick;
    }
}

