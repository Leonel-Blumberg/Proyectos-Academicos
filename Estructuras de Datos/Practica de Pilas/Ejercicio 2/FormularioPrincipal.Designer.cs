namespace Ejercicio_2
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
            this.gboxSalidaDatos = new System.Windows.Forms.GroupBox();
            this.lblPueblos = new System.Windows.Forms.Label();
            this.lstSalidaDatos = new System.Windows.Forms.ListBox();
            this.gboxEntradaDatos = new System.Windows.Forms.GroupBox();
            this.btnMarcarPuebloDestino = new System.Windows.Forms.Button();
            this.btnQuitarUltimoPueblo = new System.Windows.Forms.Button();
            this.btnIngresarPueblo = new System.Windows.Forms.Button();
            this.txtPueblo = new System.Windows.Forms.TextBox();
            this.lblPueblo = new System.Windows.Forms.Label();
            this.btnReiniciarPrograma = new System.Windows.Forms.Button();
            this.btnSalirPrograma = new System.Windows.Forms.Button();
            this.gboxSalidaDatos.SuspendLayout();
            this.gboxEntradaDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxSalidaDatos
            // 
            this.gboxSalidaDatos.Controls.Add(this.lblPueblos);
            this.gboxSalidaDatos.Controls.Add(this.lstSalidaDatos);
            this.gboxSalidaDatos.Location = new System.Drawing.Point(12, 12);
            this.gboxSalidaDatos.Name = "gboxSalidaDatos";
            this.gboxSalidaDatos.Size = new System.Drawing.Size(370, 426);
            this.gboxSalidaDatos.TabIndex = 0;
            this.gboxSalidaDatos.TabStop = false;
            this.gboxSalidaDatos.Text = "Salida Datos";
            // 
            // lblPueblos
            // 
            this.lblPueblos.AutoSize = true;
            this.lblPueblos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPueblos.Location = new System.Drawing.Point(130, 25);
            this.lblPueblos.Name = "lblPueblos";
            this.lblPueblos.Size = new System.Drawing.Size(68, 16);
            this.lblPueblos.TabIndex = 1;
            this.lblPueblos.Text = "Pueblos:";
            // 
            // lstSalidaDatos
            // 
            this.lstSalidaDatos.FormattingEnabled = true;
            this.lstSalidaDatos.Location = new System.Drawing.Point(15, 54);
            this.lstSalidaDatos.Name = "lstSalidaDatos";
            this.lstSalidaDatos.Size = new System.Drawing.Size(334, 342);
            this.lstSalidaDatos.TabIndex = 0;
            // 
            // gboxEntradaDatos
            // 
            this.gboxEntradaDatos.Controls.Add(this.btnMarcarPuebloDestino);
            this.gboxEntradaDatos.Controls.Add(this.btnQuitarUltimoPueblo);
            this.gboxEntradaDatos.Controls.Add(this.btnIngresarPueblo);
            this.gboxEntradaDatos.Controls.Add(this.txtPueblo);
            this.gboxEntradaDatos.Controls.Add(this.lblPueblo);
            this.gboxEntradaDatos.Location = new System.Drawing.Point(388, 12);
            this.gboxEntradaDatos.Name = "gboxEntradaDatos";
            this.gboxEntradaDatos.Size = new System.Drawing.Size(400, 180);
            this.gboxEntradaDatos.TabIndex = 1;
            this.gboxEntradaDatos.TabStop = false;
            this.gboxEntradaDatos.Text = "Entrada Datos";
            // 
            // btnMarcarPuebloDestino
            // 
            this.btnMarcarPuebloDestino.Enabled = false;
            this.btnMarcarPuebloDestino.Location = new System.Drawing.Point(106, 81);
            this.btnMarcarPuebloDestino.Name = "btnMarcarPuebloDestino";
            this.btnMarcarPuebloDestino.Size = new System.Drawing.Size(177, 23);
            this.btnMarcarPuebloDestino.TabIndex = 6;
            this.btnMarcarPuebloDestino.Text = "Marcar Pueblo Como Destino";
            this.btnMarcarPuebloDestino.UseVisualStyleBackColor = true;
            this.btnMarcarPuebloDestino.Click += new System.EventHandler(this.BtnMarcarPuebloDestino_Click);
            // 
            // btnQuitarUltimoPueblo
            // 
            this.btnQuitarUltimoPueblo.Enabled = false;
            this.btnQuitarUltimoPueblo.Location = new System.Drawing.Point(106, 141);
            this.btnQuitarUltimoPueblo.Name = "btnQuitarUltimoPueblo";
            this.btnQuitarUltimoPueblo.Size = new System.Drawing.Size(177, 23);
            this.btnQuitarUltimoPueblo.TabIndex = 5;
            this.btnQuitarUltimoPueblo.Text = "Quitar Último pueblo";
            this.btnQuitarUltimoPueblo.UseVisualStyleBackColor = true;
            this.btnQuitarUltimoPueblo.Click += new System.EventHandler(this.BtnQuitarUltimoPueblo_Click);
            // 
            // btnIngresarPueblo
            // 
            this.btnIngresarPueblo.Location = new System.Drawing.Point(106, 54);
            this.btnIngresarPueblo.Name = "btnIngresarPueblo";
            this.btnIngresarPueblo.Size = new System.Drawing.Size(177, 23);
            this.btnIngresarPueblo.TabIndex = 4;
            this.btnIngresarPueblo.Text = "Ingresar Pueblo";
            this.btnIngresarPueblo.UseVisualStyleBackColor = true;
            this.btnIngresarPueblo.Click += new System.EventHandler(this.BtnIngresarPueblo_Click);
            // 
            // txtPueblo
            // 
            this.txtPueblo.Location = new System.Drawing.Point(71, 22);
            this.txtPueblo.MaxLength = 120;
            this.txtPueblo.Name = "txtPueblo";
            this.txtPueblo.Size = new System.Drawing.Size(313, 20);
            this.txtPueblo.TabIndex = 1;
            this.txtPueblo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPueblo
            // 
            this.lblPueblo.AutoSize = true;
            this.lblPueblo.Location = new System.Drawing.Point(22, 25);
            this.lblPueblo.Name = "lblPueblo";
            this.lblPueblo.Size = new System.Drawing.Size(43, 13);
            this.lblPueblo.TabIndex = 0;
            this.lblPueblo.Text = "Pueblo:";
            // 
            // btnReiniciarPrograma
            // 
            this.btnReiniciarPrograma.Location = new System.Drawing.Point(398, 207);
            this.btnReiniciarPrograma.Name = "btnReiniciarPrograma";
            this.btnReiniciarPrograma.Size = new System.Drawing.Size(177, 23);
            this.btnReiniciarPrograma.TabIndex = 2;
            this.btnReiniciarPrograma.Text = "Reiniciar Programa";
            this.btnReiniciarPrograma.UseVisualStyleBackColor = true;
            this.btnReiniciarPrograma.Click += new System.EventHandler(this.BtnReiniciarPrograma_Click);
            // 
            // btnSalirPrograma
            // 
            this.btnSalirPrograma.Location = new System.Drawing.Point(595, 207);
            this.btnSalirPrograma.Name = "btnSalirPrograma";
            this.btnSalirPrograma.Size = new System.Drawing.Size(177, 23);
            this.btnSalirPrograma.TabIndex = 3;
            this.btnSalirPrograma.Text = "Salir Programa";
            this.btnSalirPrograma.UseVisualStyleBackColor = true;
            this.btnSalirPrograma.Click += new System.EventHandler(this.BtnSalirPrograma_Click);
            // 
            // frmFormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalirPrograma);
            this.Controls.Add(this.btnReiniciarPrograma);
            this.Controls.Add(this.gboxEntradaDatos);
            this.Controls.Add(this.gboxSalidaDatos);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "frmFormularioPrincipal";
            this.Text = "Ejercicio 2";
            this.gboxSalidaDatos.ResumeLayout(false);
            this.gboxSalidaDatos.PerformLayout();
            this.gboxEntradaDatos.ResumeLayout(false);
            this.gboxEntradaDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxSalidaDatos;
        private System.Windows.Forms.Label lblPueblos;
        private System.Windows.Forms.ListBox lstSalidaDatos;
        private System.Windows.Forms.GroupBox gboxEntradaDatos;
        private System.Windows.Forms.Label lblPueblo;
        private System.Windows.Forms.Button btnReiniciarPrograma;
        private System.Windows.Forms.Button btnSalirPrograma;
        private System.Windows.Forms.Button btnMarcarPuebloDestino;
        private System.Windows.Forms.Button btnQuitarUltimoPueblo;
        private System.Windows.Forms.Button btnIngresarPueblo;
        private System.Windows.Forms.TextBox txtPueblo;
    }
}

