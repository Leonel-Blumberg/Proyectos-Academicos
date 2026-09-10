namespace Practica_de_Colas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFormularioPrincipal));
            this.gbxSalidaDatos = new System.Windows.Forms.GroupBox();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.lstSalidaDatos = new System.Windows.Forms.ListBox();
            this.gboxEntradaDatos = new System.Windows.Forms.GroupBox();
            this.btnQuitarPrimerDato = new System.Windows.Forms.Button();
            this.btnIngresarDaos = new System.Windows.Forms.Button();
            this.txtFechaEntregaEstimada = new System.Windows.Forms.TextBox();
            this.lblFechaEntregaEstimada = new System.Windows.Forms.Label();
            this.txtPrecioPedido = new System.Windows.Forms.TextBox();
            this.lblPrecioPedido = new System.Windows.Forms.Label();
            this.txtProdCompr = new System.Windows.Forms.TextBox();
            this.lblProductoComprado = new System.Windows.Forms.Label();
            this.lblNumPedido = new System.Windows.Forms.Label();
            this.txtNumPedido = new System.Windows.Forms.TextBox();
            this.btnReiniciarPrograma = new System.Windows.Forms.Button();
            this.btnSalirPrograma = new System.Windows.Forms.Button();
            this.lblMaximoPrecioPedido = new System.Windows.Forms.Label();
            this.lblMinimoPrecioPedido = new System.Windows.Forms.Label();
            this.lblPromedioPrecioPedidos = new System.Windows.Forms.Label();
            this.lblTotalPrecioPedidos = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblProm = new System.Windows.Forms.Label();
            this.lblTot = new System.Windows.Forms.Label();
            this.lblDatosDesencolados = new System.Windows.Forms.Label();
            this.gbxSalidaDatos.SuspendLayout();
            this.gboxEntradaDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSalidaDatos
            // 
            this.gbxSalidaDatos.Controls.Add(this.lblPedidos);
            this.gbxSalidaDatos.Controls.Add(this.lstSalidaDatos);
            this.gbxSalidaDatos.Location = new System.Drawing.Point(12, 12);
            this.gbxSalidaDatos.Name = "gbxSalidaDatos";
            this.gbxSalidaDatos.Size = new System.Drawing.Size(693, 426);
            this.gbxSalidaDatos.TabIndex = 0;
            this.gbxSalidaDatos.TabStop = false;
            this.gbxSalidaDatos.Text = "Salida Datos";
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidos.Location = new System.Drawing.Point(292, 16);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(67, 15);
            this.lblPedidos.TabIndex = 2;
            this.lblPedidos.Text = "Pedidos: ";
            // 
            // lstSalidaDatos
            // 
            this.lstSalidaDatos.FormattingEnabled = true;
            this.lstSalidaDatos.HorizontalScrollbar = true;
            this.lstSalidaDatos.Location = new System.Drawing.Point(15, 45);
            this.lstSalidaDatos.Name = "lstSalidaDatos";
            this.lstSalidaDatos.Size = new System.Drawing.Size(662, 368);
            this.lstSalidaDatos.TabIndex = 0;
            // 
            // gboxEntradaDatos
            // 
            this.gboxEntradaDatos.Controls.Add(this.btnQuitarPrimerDato);
            this.gboxEntradaDatos.Controls.Add(this.btnIngresarDaos);
            this.gboxEntradaDatos.Controls.Add(this.txtFechaEntregaEstimada);
            this.gboxEntradaDatos.Controls.Add(this.lblFechaEntregaEstimada);
            this.gboxEntradaDatos.Controls.Add(this.txtPrecioPedido);
            this.gboxEntradaDatos.Controls.Add(this.lblPrecioPedido);
            this.gboxEntradaDatos.Controls.Add(this.txtProdCompr);
            this.gboxEntradaDatos.Controls.Add(this.lblProductoComprado);
            this.gboxEntradaDatos.Controls.Add(this.lblNumPedido);
            this.gboxEntradaDatos.Controls.Add(this.txtNumPedido);
            this.gboxEntradaDatos.Location = new System.Drawing.Point(711, 12);
            this.gboxEntradaDatos.Name = "gboxEntradaDatos";
            this.gboxEntradaDatos.Size = new System.Drawing.Size(328, 182);
            this.gboxEntradaDatos.TabIndex = 1;
            this.gboxEntradaDatos.TabStop = false;
            this.gboxEntradaDatos.Text = "Entrada Datos";
            // 
            // btnQuitarPrimerDato
            // 
            this.btnQuitarPrimerDato.Enabled = false;
            this.btnQuitarPrimerDato.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnQuitarPrimerDato.Location = new System.Drawing.Point(167, 139);
            this.btnQuitarPrimerDato.Name = "btnQuitarPrimerDato";
            this.btnQuitarPrimerDato.Size = new System.Drawing.Size(133, 23);
            this.btnQuitarPrimerDato.TabIndex = 8;
            this.btnQuitarPrimerDato.Text = "Quitar Primer Dato";
            this.btnQuitarPrimerDato.UseVisualStyleBackColor = true;
            this.btnQuitarPrimerDato.Click += new System.EventHandler(this.btnQuitarPrimerDato_Click);
            // 
            // btnIngresarDaos
            // 
            this.btnIngresarDaos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnIngresarDaos.Location = new System.Drawing.Point(19, 139);
            this.btnIngresarDaos.Name = "btnIngresarDaos";
            this.btnIngresarDaos.Size = new System.Drawing.Size(133, 23);
            this.btnIngresarDaos.TabIndex = 4;
            this.btnIngresarDaos.Text = "Ingresar Datos";
            this.btnIngresarDaos.UseVisualStyleBackColor = true;
            this.btnIngresarDaos.Click += new System.EventHandler(this.btnIngresarDatos_Click);
            // 
            // txtFechaEntregaEstimada
            // 
            this.txtFechaEntregaEstimada.Location = new System.Drawing.Point(158, 105);
            this.txtFechaEntregaEstimada.MaxLength = 120;
            this.txtFechaEntregaEstimada.Name = "txtFechaEntregaEstimada";
            this.txtFechaEntregaEstimada.Size = new System.Drawing.Size(154, 20);
            this.txtFechaEntregaEstimada.TabIndex = 7;
            this.txtFechaEntregaEstimada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFechaEntregaEstimada
            // 
            this.lblFechaEntregaEstimada.AutoSize = true;
            this.lblFechaEntregaEstimada.Location = new System.Drawing.Point(16, 108);
            this.lblFechaEntregaEstimada.Name = "lblFechaEntregaEstimada";
            this.lblFechaEntregaEstimada.Size = new System.Drawing.Size(136, 13);
            this.lblFechaEntregaEstimada.TabIndex = 6;
            this.lblFechaEntregaEstimada.Text = "Fecha de entrega estimada:";
            // 
            // txtPrecioPedido
            // 
            this.txtPrecioPedido.Location = new System.Drawing.Point(158, 78);
            this.txtPrecioPedido.MaxLength = 8;
            this.txtPrecioPedido.Name = "txtPrecioPedido";
            this.txtPrecioPedido.Size = new System.Drawing.Size(154, 20);
            this.txtPrecioPedido.TabIndex = 5;
            this.txtPrecioPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPrecioPedido
            // 
            this.lblPrecioPedido.AutoSize = true;
            this.lblPrecioPedido.Location = new System.Drawing.Point(16, 81);
            this.lblPrecioPedido.Name = "lblPrecioPedido";
            this.lblPrecioPedido.Size = new System.Drawing.Size(92, 13);
            this.lblPrecioPedido.TabIndex = 4;
            this.lblPrecioPedido.Text = "Precio del pedido:";
            // 
            // txtProdCompr
            // 
            this.txtProdCompr.Location = new System.Drawing.Point(158, 52);
            this.txtProdCompr.MaxLength = 120;
            this.txtProdCompr.Name = "txtProdCompr";
            this.txtProdCompr.Size = new System.Drawing.Size(154, 20);
            this.txtProdCompr.TabIndex = 3;
            this.txtProdCompr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProductoComprado
            // 
            this.lblProductoComprado.AutoSize = true;
            this.lblProductoComprado.Location = new System.Drawing.Point(16, 55);
            this.lblProductoComprado.Name = "lblProductoComprado";
            this.lblProductoComprado.Size = new System.Drawing.Size(103, 13);
            this.lblProductoComprado.TabIndex = 2;
            this.lblProductoComprado.Text = "Producto comprado:";
            // 
            // lblNumPedido
            // 
            this.lblNumPedido.AutoSize = true;
            this.lblNumPedido.Location = new System.Drawing.Point(16, 29);
            this.lblNumPedido.Name = "lblNumPedido";
            this.lblNumPedido.Size = new System.Drawing.Size(97, 13);
            this.lblNumPedido.TabIndex = 1;
            this.lblNumPedido.Text = "Número de pedido:";
            // 
            // txtNumPedido
            // 
            this.txtNumPedido.Location = new System.Drawing.Point(158, 26);
            this.txtNumPedido.MaxLength = 8;
            this.txtNumPedido.Name = "txtNumPedido";
            this.txtNumPedido.Size = new System.Drawing.Size(154, 20);
            this.txtNumPedido.TabIndex = 0;
            this.txtNumPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReiniciarPrograma
            // 
            this.btnReiniciarPrograma.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReiniciarPrograma.Location = new System.Drawing.Point(746, 403);
            this.btnReiniciarPrograma.Name = "btnReiniciarPrograma";
            this.btnReiniciarPrograma.Size = new System.Drawing.Size(114, 23);
            this.btnReiniciarPrograma.TabIndex = 2;
            this.btnReiniciarPrograma.Text = "Reiniciar Programa";
            this.btnReiniciarPrograma.UseVisualStyleBackColor = true;
            this.btnReiniciarPrograma.Click += new System.EventHandler(this.btnReiniciarPrograma_Click);
            // 
            // btnSalirPrograma
            // 
            this.btnSalirPrograma.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSalirPrograma.Location = new System.Drawing.Point(897, 403);
            this.btnSalirPrograma.Name = "btnSalirPrograma";
            this.btnSalirPrograma.Size = new System.Drawing.Size(114, 23);
            this.btnSalirPrograma.TabIndex = 3;
            this.btnSalirPrograma.Text = "Salir Programa";
            this.btnSalirPrograma.UseVisualStyleBackColor = true;
            this.btnSalirPrograma.Click += new System.EventHandler(this.btnSalirPrograma_Click);
            // 
            // lblMaximoPrecioPedido
            // 
            this.lblMaximoPrecioPedido.AutoSize = true;
            this.lblMaximoPrecioPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximoPrecioPedido.Location = new System.Drawing.Point(781, 248);
            this.lblMaximoPrecioPedido.Name = "lblMaximoPrecioPedido";
            this.lblMaximoPrecioPedido.Size = new System.Drawing.Size(156, 15);
            this.lblMaximoPrecioPedido.TabIndex = 9;
            this.lblMaximoPrecioPedido.Text = "Máximo Precio Pedido:";
            // 
            // lblMinimoPrecioPedido
            // 
            this.lblMinimoPrecioPedido.AutoSize = true;
            this.lblMinimoPrecioPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimoPrecioPedido.Location = new System.Drawing.Point(781, 275);
            this.lblMinimoPrecioPedido.Name = "lblMinimoPrecioPedido";
            this.lblMinimoPrecioPedido.Size = new System.Drawing.Size(153, 15);
            this.lblMinimoPrecioPedido.TabIndex = 10;
            this.lblMinimoPrecioPedido.Text = "Mínimo Precio Pedido:";
            // 
            // lblPromedioPrecioPedidos
            // 
            this.lblPromedioPrecioPedidos.AutoSize = true;
            this.lblPromedioPrecioPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioPrecioPedidos.Location = new System.Drawing.Point(781, 301);
            this.lblPromedioPrecioPedidos.Name = "lblPromedioPrecioPedidos";
            this.lblPromedioPrecioPedidos.Size = new System.Drawing.Size(181, 15);
            this.lblPromedioPrecioPedidos.TabIndex = 11;
            this.lblPromedioPrecioPedidos.Text = "Promedio Precios Pedidos:";
            // 
            // lblTotalPrecioPedidos
            // 
            this.lblTotalPrecioPedidos.AutoSize = true;
            this.lblTotalPrecioPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrecioPedidos.Location = new System.Drawing.Point(781, 327);
            this.lblTotalPrecioPedidos.Name = "lblTotalPrecioPedidos";
            this.lblTotalPrecioPedidos.Size = new System.Drawing.Size(151, 15);
            this.lblTotalPrecioPedidos.TabIndex = 12;
            this.lblTotalPrecioPedidos.Text = "Total Precios Pedidos:";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(943, 248);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(12, 15);
            this.lblMax.TabIndex = 13;
            this.lblMax.Text = "-";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(943, 275);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(12, 15);
            this.lblMin.TabIndex = 14;
            this.lblMin.Text = "-";
            // 
            // lblProm
            // 
            this.lblProm.AutoSize = true;
            this.lblProm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProm.Location = new System.Drawing.Point(968, 301);
            this.lblProm.Name = "lblProm";
            this.lblProm.Size = new System.Drawing.Size(12, 15);
            this.lblProm.TabIndex = 15;
            this.lblProm.Text = "-";
            // 
            // lblTot
            // 
            this.lblTot.AutoSize = true;
            this.lblTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTot.Location = new System.Drawing.Point(938, 327);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(12, 15);
            this.lblTot.TabIndex = 16;
            this.lblTot.Text = "-";
            // 
            // lblDatosDesencolados
            // 
            this.lblDatosDesencolados.AutoSize = true;
            this.lblDatosDesencolados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosDesencolados.Location = new System.Drawing.Point(743, 217);
            this.lblDatosDesencolados.Name = "lblDatosDesencolados";
            this.lblDatosDesencolados.Size = new System.Drawing.Size(256, 16);
            this.lblDatosDesencolados.TabIndex = 17;
            this.lblDatosDesencolados.Text = "Datos de Elementos Desencolados:";
            // 
            // FrmFormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 450);
            this.Controls.Add(this.lblDatosDesencolados);
            this.Controls.Add(this.lblTot);
            this.Controls.Add(this.lblProm);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblTotalPrecioPedidos);
            this.Controls.Add(this.lblPromedioPrecioPedidos);
            this.Controls.Add(this.lblMinimoPrecioPedido);
            this.Controls.Add(this.lblMaximoPrecioPedido);
            this.Controls.Add(this.btnSalirPrograma);
            this.Controls.Add(this.btnReiniciarPrograma);
            this.Controls.Add(this.gboxEntradaDatos);
            this.Controls.Add(this.gbxSalidaDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFormularioPrincipal";
            this.Text = "Cola de Pedidos en una Empresa de Comercio";
            this.gbxSalidaDatos.ResumeLayout(false);
            this.gbxSalidaDatos.PerformLayout();
            this.gboxEntradaDatos.ResumeLayout(false);
            this.gboxEntradaDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSalidaDatos;
        private System.Windows.Forms.GroupBox gboxEntradaDatos;
        private System.Windows.Forms.ListBox lstSalidaDatos;
        private System.Windows.Forms.Button btnReiniciarPrograma;
        private System.Windows.Forms.Button btnSalirPrograma;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.TextBox txtPrecioPedido;
        private System.Windows.Forms.Label lblPrecioPedido;
        private System.Windows.Forms.TextBox txtProdCompr;
        private System.Windows.Forms.Label lblProductoComprado;
        private System.Windows.Forms.Label lblNumPedido;
        private System.Windows.Forms.TextBox txtNumPedido;
        private System.Windows.Forms.Button btnQuitarPrimerDato;
        private System.Windows.Forms.Button btnIngresarDaos;
        private System.Windows.Forms.TextBox txtFechaEntregaEstimada;
        private System.Windows.Forms.Label lblFechaEntregaEstimada;
        private System.Windows.Forms.Label lblMaximoPrecioPedido;
        private System.Windows.Forms.Label lblMinimoPrecioPedido;
        private System.Windows.Forms.Label lblPromedioPrecioPedidos;
        private System.Windows.Forms.Label lblTotalPrecioPedidos;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblProm;
        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.Label lblDatosDesencolados;
    }
}

