namespace Ejercicio_3
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
            this.gboxEntradaDatos = new System.Windows.Forms.GroupBox();
            this.lblExpedientes = new System.Windows.Forms.Label();
            this.lstSalidaDatos = new System.Windows.Forms.ListBox();
            this.gboxEntrDatos = new System.Windows.Forms.GroupBox();
            this.btnVerTope = new System.Windows.Forms.Button();
            this.btnDesapilar = new System.Windows.Forms.Button();
            this.btnApilar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtCaratula = new System.Windows.Forms.TextBox();
            this.txtNumExpe = new System.Windows.Forms.TextBox();
            this.lblCaratula = new System.Windows.Forms.Label();
            this.lblNumExpe = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnReiniciarAplicacion = new System.Windows.Forms.Button();
            this.btnSalirAplicacion = new System.Windows.Forms.Button();
            this.gboxEntradaDatos.SuspendLayout();
            this.gboxEntrDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxEntradaDatos
            // 
            this.gboxEntradaDatos.Controls.Add(this.lblExpedientes);
            this.gboxEntradaDatos.Controls.Add(this.lstSalidaDatos);
            this.gboxEntradaDatos.Location = new System.Drawing.Point(12, 12);
            this.gboxEntradaDatos.Name = "gboxEntradaDatos";
            this.gboxEntradaDatos.Size = new System.Drawing.Size(377, 426);
            this.gboxEntradaDatos.TabIndex = 0;
            this.gboxEntradaDatos.TabStop = false;
            this.gboxEntradaDatos.Text = "Salida Datos";
            // 
            // lblExpedientes
            // 
            this.lblExpedientes.AutoSize = true;
            this.lblExpedientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpedientes.Location = new System.Drawing.Point(126, 22);
            this.lblExpedientes.Name = "lblExpedientes";
            this.lblExpedientes.Size = new System.Drawing.Size(97, 16);
            this.lblExpedientes.TabIndex = 2;
            this.lblExpedientes.Text = "Expedientes:";
            // 
            // lstSalidaDatos
            // 
            this.lstSalidaDatos.FormattingEnabled = true;
            this.lstSalidaDatos.Location = new System.Drawing.Point(15, 55);
            this.lstSalidaDatos.Name = "lstSalidaDatos";
            this.lstSalidaDatos.Size = new System.Drawing.Size(344, 355);
            this.lstSalidaDatos.TabIndex = 0;
            // 
            // gboxEntrDatos
            // 
            this.gboxEntrDatos.Controls.Add(this.btnVerTope);
            this.gboxEntrDatos.Controls.Add(this.btnDesapilar);
            this.gboxEntrDatos.Controls.Add(this.btnApilar);
            this.gboxEntrDatos.Controls.Add(this.dtpFecha);
            this.gboxEntrDatos.Controls.Add(this.txtCaratula);
            this.gboxEntrDatos.Controls.Add(this.txtNumExpe);
            this.gboxEntrDatos.Controls.Add(this.lblCaratula);
            this.gboxEntrDatos.Controls.Add(this.lblNumExpe);
            this.gboxEntrDatos.Controls.Add(this.lblFecha);
            this.gboxEntrDatos.Location = new System.Drawing.Point(395, 12);
            this.gboxEntrDatos.Name = "gboxEntrDatos";
            this.gboxEntrDatos.Size = new System.Drawing.Size(420, 115);
            this.gboxEntrDatos.TabIndex = 1;
            this.gboxEntrDatos.TabStop = false;
            this.gboxEntrDatos.Text = "Entrada Datos";
            // 
            // btnVerTope
            // 
            this.btnVerTope.Enabled = false;
            this.btnVerTope.Location = new System.Drawing.Point(281, 71);
            this.btnVerTope.Name = "btnVerTope";
            this.btnVerTope.Size = new System.Drawing.Size(123, 23);
            this.btnVerTope.TabIndex = 9;
            this.btnVerTope.Text = "Ver Tope";
            this.btnVerTope.UseVisualStyleBackColor = true;
            this.btnVerTope.Click += new System.EventHandler(this.BtnVerTope_Click);
            // 
            // btnDesapilar
            // 
            this.btnDesapilar.Enabled = false;
            this.btnDesapilar.Location = new System.Drawing.Point(281, 42);
            this.btnDesapilar.Name = "btnDesapilar";
            this.btnDesapilar.Size = new System.Drawing.Size(123, 23);
            this.btnDesapilar.TabIndex = 8;
            this.btnDesapilar.Text = "Desapilar";
            this.btnDesapilar.UseVisualStyleBackColor = true;
            this.btnDesapilar.Click += new System.EventHandler(this.BtnDesapilar_Click);
            // 
            // btnApilar
            // 
            this.btnApilar.Location = new System.Drawing.Point(281, 19);
            this.btnApilar.Name = "btnApilar";
            this.btnApilar.Size = new System.Drawing.Size(123, 23);
            this.btnApilar.TabIndex = 7;
            this.btnApilar.Text = "Apilar";
            this.btnApilar.UseVisualStyleBackColor = true;
            this.btnApilar.Click += new System.EventHandler(this.BtnApilar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(129, 19);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(133, 20);
            this.dtpFecha.TabIndex = 6;
            // 
            // txtCaratula
            // 
            this.txtCaratula.Location = new System.Drawing.Point(129, 74);
            this.txtCaratula.MaxLength = 120;
            this.txtCaratula.Name = "txtCaratula";
            this.txtCaratula.Size = new System.Drawing.Size(133, 20);
            this.txtCaratula.TabIndex = 5;
            // 
            // txtNumExpe
            // 
            this.txtNumExpe.Location = new System.Drawing.Point(129, 45);
            this.txtNumExpe.MaxLength = 8;
            this.txtNumExpe.Name = "txtNumExpe";
            this.txtNumExpe.Size = new System.Drawing.Size(133, 20);
            this.txtNumExpe.TabIndex = 4;
            // 
            // lblCaratula
            // 
            this.lblCaratula.AutoSize = true;
            this.lblCaratula.Location = new System.Drawing.Point(18, 77);
            this.lblCaratula.Name = "lblCaratula";
            this.lblCaratula.Size = new System.Drawing.Size(49, 13);
            this.lblCaratula.TabIndex = 2;
            this.lblCaratula.Text = "Caratula:";
            // 
            // lblNumExpe
            // 
            this.lblNumExpe.AutoSize = true;
            this.lblNumExpe.Location = new System.Drawing.Point(18, 52);
            this.lblNumExpe.Name = "lblNumExpe";
            this.lblNumExpe.Size = new System.Drawing.Size(103, 13);
            this.lblNumExpe.TabIndex = 1;
            this.lblNumExpe.Text = "Número Expediente:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(18, 29);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha:";
            // 
            // btnReiniciarAplicacion
            // 
            this.btnReiniciarAplicacion.Location = new System.Drawing.Point(416, 133);
            this.btnReiniciarAplicacion.Name = "btnReiniciarAplicacion";
            this.btnReiniciarAplicacion.Size = new System.Drawing.Size(179, 23);
            this.btnReiniciarAplicacion.TabIndex = 10;
            this.btnReiniciarAplicacion.Text = "Reiniciar Aplicación";
            this.btnReiniciarAplicacion.UseVisualStyleBackColor = true;
            this.btnReiniciarAplicacion.Click += new System.EventHandler(this.BtnReiniciarAplicacion_Click);
            // 
            // btnSalirAplicacion
            // 
            this.btnSalirAplicacion.Location = new System.Drawing.Point(611, 133);
            this.btnSalirAplicacion.Name = "btnSalirAplicacion";
            this.btnSalirAplicacion.Size = new System.Drawing.Size(188, 23);
            this.btnSalirAplicacion.TabIndex = 11;
            this.btnSalirAplicacion.Text = "Salir Aplicación";
            this.btnSalirAplicacion.UseVisualStyleBackColor = true;
            this.btnSalirAplicacion.Click += new System.EventHandler(this.BtnSalirAplicacion_Click);
            // 
            // frmFormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 450);
            this.Controls.Add(this.btnSalirAplicacion);
            this.Controls.Add(this.btnReiniciarAplicacion);
            this.Controls.Add(this.gboxEntrDatos);
            this.Controls.Add(this.gboxEntradaDatos);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(845, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(845, 489);
            this.Name = "frmFormularioPrincipal";
            this.Text = "Ejercicio 3";
            this.gboxEntradaDatos.ResumeLayout(false);
            this.gboxEntradaDatos.PerformLayout();
            this.gboxEntrDatos.ResumeLayout(false);
            this.gboxEntrDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxEntradaDatos;
        private System.Windows.Forms.ListBox lstSalidaDatos;
        private System.Windows.Forms.GroupBox gboxEntrDatos;
        private System.Windows.Forms.Label lblNumExpe;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnVerTope;
        private System.Windows.Forms.Button btnDesapilar;
        private System.Windows.Forms.Button btnApilar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtCaratula;
        private System.Windows.Forms.TextBox txtNumExpe;
        private System.Windows.Forms.Label lblCaratula;
        private System.Windows.Forms.Button btnReiniciarAplicacion;
        private System.Windows.Forms.Button btnSalirAplicacion;
        private System.Windows.Forms.Label lblExpedientes;
    }
}

