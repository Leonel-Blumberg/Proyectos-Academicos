namespace Vista
{
    partial class FrmFormularioPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFormularioPrincipal));
            groupBox1 = new GroupBox();
            label6 = new Label();
            dgvLibros = new DataGridView();
            label23 = new Label();
            label24 = new Label();
            dgvPrestamos = new DataGridView();
            label21 = new Label();
            label22 = new Label();
            dgvSocios = new DataGridView();
            label19 = new Label();
            label20 = new Label();
            groupBox2 = new GroupBox();
            btnEliminarSocio = new Button();
            btnModificarPrestamo = new Button();
            btnAgregarPrestamo = new Button();
            cmbSocio = new ComboBox();
            label18 = new Label();
            cmbLibro = new ComboBox();
            label17 = new Label();
            dtpFechaDevolucion = new DateTimePicker();
            label16 = new Label();
            dtpFechaPrestamo = new DateTimePicker();
            label15 = new Label();
            label10 = new Label();
            label14 = new Label();
            btnDevolverPrestamo = new Button();
            btnModificar = new Button();
            btnAgregarSocio = new Button();
            label13 = new Label();
            tbTelefono = new TextBox();
            label12 = new Label();
            tbEmail = new TextBox();
            label11 = new Label();
            tbNombreCompleto = new TextBox();
            btnEliminarLibro = new Button();
            btnModificarLibro = new Button();
            btnAgregarLibro = new Button();
            label9 = new Label();
            tbDNI = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label5 = new Label();
            tbAutor = new TextBox();
            label3 = new Label();
            tbTitulo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dgvLibros);
            groupBox1.Controls.Add(label23);
            groupBox1.Controls.Add(label24);
            groupBox1.Controls.Add(dgvPrestamos);
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(label22);
            groupBox1.Controls.Add(dgvSocios);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(label20);
            groupBox1.Location = new Point(505, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(684, 685);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 648);
            label6.Name = "label6";
            label6.Size = new Size(430, 15);
            label6.TabIndex = 49;
            label6.Text = "* Para modificar o eliminar, seleccione dando click sobre el elemento en la tabla.";
            // 
            // dgvLibros
            // 
            dgvLibros.AllowUserToAddRows = false;
            dgvLibros.AllowUserToDeleteRows = false;
            dgvLibros.AllowUserToResizeColumns = false;
            dgvLibros.AllowUserToResizeRows = false;
            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLibros.BackgroundColor = Color.LightSteelBlue;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(21, 361);
            dgvLibros.MultiSelect = false;
            dgvLibros.Name = "dgvLibros";
            dgvLibros.ReadOnly = true;
            dgvLibros.ScrollBars = ScrollBars.Vertical;
            dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLibros.Size = new Size(650, 275);
            dgvLibros.TabIndex = 48;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label23.Location = new Point(79, 337);
            label23.Name = "label23";
            label23.Size = new Size(56, 21);
            label23.TabIndex = 47;
            label23.Text = "Libros";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F);
            label24.Location = new Point(21, 337);
            label24.Name = "label24";
            label24.Size = new Size(63, 21);
            label24.TabIndex = 46;
            label24.Text = "Lista de";
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.AllowUserToAddRows = false;
            dgvPrestamos.AllowUserToDeleteRows = false;
            dgvPrestamos.AllowUserToResizeColumns = false;
            dgvPrestamos.AllowUserToResizeRows = false;
            dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrestamos.BackgroundColor = Color.LightSteelBlue;
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Location = new Point(356, 52);
            dgvPrestamos.MultiSelect = false;
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.ReadOnly = true;
            dgvPrestamos.ScrollBars = ScrollBars.Vertical;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamos.Size = new Size(315, 264);
            dgvPrestamos.TabIndex = 45;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label21.Location = new Point(416, 28);
            label21.Name = "label21";
            label21.Size = new Size(89, 21);
            label21.TabIndex = 44;
            label21.Text = "Préstamos";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F);
            label22.Location = new Point(358, 28);
            label22.Name = "label22";
            label22.Size = new Size(63, 21);
            label22.TabIndex = 43;
            label22.Text = "Lista de";
            // 
            // dgvSocios
            // 
            dgvSocios.AllowUserToAddRows = false;
            dgvSocios.AllowUserToDeleteRows = false;
            dgvSocios.AllowUserToResizeColumns = false;
            dgvSocios.AllowUserToResizeRows = false;
            dgvSocios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSocios.BackgroundColor = Color.LightSteelBlue;
            dgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSocios.Location = new Point(21, 52);
            dgvSocios.MultiSelect = false;
            dgvSocios.Name = "dgvSocios";
            dgvSocios.ReadOnly = true;
            dgvSocios.ScrollBars = ScrollBars.Vertical;
            dgvSocios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSocios.Size = new Size(315, 264);
            dgvSocios.TabIndex = 42;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label19.Location = new Point(79, 28);
            label19.Name = "label19";
            label19.Size = new Size(59, 21);
            label19.TabIndex = 41;
            label19.Text = "Socios";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F);
            label20.Location = new Point(21, 28);
            label20.Name = "label20";
            label20.Size = new Size(63, 21);
            label20.TabIndex = 40;
            label20.Text = "Lista de";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnEliminarSocio);
            groupBox2.Controls.Add(btnModificarPrestamo);
            groupBox2.Controls.Add(btnAgregarPrestamo);
            groupBox2.Controls.Add(cmbSocio);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(cmbLibro);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(dtpFechaDevolucion);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(dtpFechaPrestamo);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(btnDevolverPrestamo);
            groupBox2.Controls.Add(btnModificar);
            groupBox2.Controls.Add(btnAgregarSocio);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(tbTelefono);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(tbEmail);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(tbNombreCompleto);
            groupBox2.Controls.Add(btnEliminarLibro);
            groupBox2.Controls.Add(btnModificarLibro);
            groupBox2.Controls.Add(btnAgregarLibro);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(tbDNI);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(tbAutor);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(tbTitulo);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(475, 685);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btnEliminarSocio
            // 
            btnEliminarSocio.BackColor = Color.CornflowerBlue;
            btnEliminarSocio.Cursor = Cursors.Hand;
            btnEliminarSocio.FlatStyle = FlatStyle.Flat;
            btnEliminarSocio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminarSocio.ForeColor = SystemColors.Control;
            btnEliminarSocio.Location = new Point(344, 425);
            btnEliminarSocio.Name = "btnEliminarSocio";
            btnEliminarSocio.Size = new Size(100, 32);
            btnEliminarSocio.TabIndex = 41;
            btnEliminarSocio.Text = "Eliminar";
            btnEliminarSocio.UseVisualStyleBackColor = false;
            btnEliminarSocio.Click += BtnEliminarSocio_Click;
            // 
            // btnModificarPrestamo
            // 
            btnModificarPrestamo.BackColor = Color.CornflowerBlue;
            btnModificarPrestamo.Cursor = Cursors.Hand;
            btnModificarPrestamo.FlatStyle = FlatStyle.Flat;
            btnModificarPrestamo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModificarPrestamo.ForeColor = SystemColors.Control;
            btnModificarPrestamo.Location = new Point(130, 639);
            btnModificarPrestamo.Name = "btnModificarPrestamo";
            btnModificarPrestamo.Size = new Size(100, 32);
            btnModificarPrestamo.TabIndex = 40;
            btnModificarPrestamo.Text = "Modificar";
            btnModificarPrestamo.UseVisualStyleBackColor = false;
            btnModificarPrestamo.Click += BtnModificarPrestamo_Click;
            // 
            // btnAgregarPrestamo
            // 
            btnAgregarPrestamo.BackColor = Color.CornflowerBlue;
            btnAgregarPrestamo.Cursor = Cursors.Hand;
            btnAgregarPrestamo.FlatStyle = FlatStyle.Flat;
            btnAgregarPrestamo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregarPrestamo.ForeColor = SystemColors.Control;
            btnAgregarPrestamo.Location = new Point(24, 639);
            btnAgregarPrestamo.Name = "btnAgregarPrestamo";
            btnAgregarPrestamo.Size = new Size(100, 32);
            btnAgregarPrestamo.TabIndex = 39;
            btnAgregarPrestamo.Text = "Agregar";
            btnAgregarPrestamo.UseVisualStyleBackColor = false;
            btnAgregarPrestamo.Click += BtnAgregarPrestamo_Click;
            // 
            // cmbSocio
            // 
            cmbSocio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSocio.FormattingEnabled = true;
            cmbSocio.Location = new Point(238, 600);
            cmbSocio.Name = "cmbSocio";
            cmbSocio.Size = new Size(206, 23);
            cmbSocio.TabIndex = 38;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F);
            label18.Location = new Point(238, 582);
            label18.Name = "label18";
            label18.Size = new Size(36, 15);
            label18.TabIndex = 37;
            label18.Text = "Socio";
            // 
            // cmbLibro
            // 
            cmbLibro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLibro.FormattingEnabled = true;
            cmbLibro.Location = new Point(24, 600);
            cmbLibro.Name = "cmbLibro";
            cmbLibro.Size = new Size(206, 23);
            cmbLibro.TabIndex = 36;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F);
            label17.Location = new Point(24, 582);
            label17.Name = "label17";
            label17.Size = new Size(34, 15);
            label17.TabIndex = 35;
            label17.Text = "Libro";
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Format = DateTimePickerFormat.Short;
            dtpFechaDevolucion.Location = new Point(238, 542);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(206, 23);
            dtpFechaDevolucion.TabIndex = 34;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F);
            label16.Location = new Point(238, 524);
            label16.Name = "label16";
            label16.Size = new Size(117, 15);
            label16.TabIndex = 33;
            label16.Text = "Fecha de Devolución";
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Format = DateTimePickerFormat.Short;
            dtpFechaPrestamo.Location = new Point(24, 542);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(206, 23);
            dtpFechaPrestamo.TabIndex = 32;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F);
            label15.Location = new Point(24, 524);
            label15.Name = "label15";
            label15.Size = new Size(107, 15);
            label15.TabIndex = 31;
            label15.Text = "Fecha de Préstamo";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.Location = new Point(91, 480);
            label10.Name = "label10";
            label10.Size = new Size(82, 21);
            label10.TabIndex = 30;
            label10.Text = "Préstamo";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(24, 480);
            label14.Name = "label14";
            label14.Size = new Size(73, 21);
            label14.TabIndex = 29;
            label14.Text = "Registrar";
            // 
            // btnDevolverPrestamo
            // 
            btnDevolverPrestamo.BackColor = Color.CornflowerBlue;
            btnDevolverPrestamo.Cursor = Cursors.Hand;
            btnDevolverPrestamo.FlatStyle = FlatStyle.Flat;
            btnDevolverPrestamo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDevolverPrestamo.ForeColor = SystemColors.Control;
            btnDevolverPrestamo.Location = new Point(344, 639);
            btnDevolverPrestamo.Name = "btnDevolverPrestamo";
            btnDevolverPrestamo.Size = new Size(100, 32);
            btnDevolverPrestamo.TabIndex = 28;
            btnDevolverPrestamo.Text = "Devolver";
            btnDevolverPrestamo.UseVisualStyleBackColor = false;
            btnDevolverPrestamo.Click += BtnDevolverPrestamo_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.CornflowerBlue;
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModificar.ForeColor = SystemColors.Control;
            btnModificar.Location = new Point(130, 425);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(100, 32);
            btnModificar.TabIndex = 27;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += BtnModificarSocio_Click;
            // 
            // btnAgregarSocio
            // 
            btnAgregarSocio.BackColor = Color.CornflowerBlue;
            btnAgregarSocio.Cursor = Cursors.Hand;
            btnAgregarSocio.FlatStyle = FlatStyle.Flat;
            btnAgregarSocio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregarSocio.ForeColor = SystemColors.Control;
            btnAgregarSocio.Location = new Point(24, 425);
            btnAgregarSocio.Name = "btnAgregarSocio";
            btnAgregarSocio.Size = new Size(100, 32);
            btnAgregarSocio.TabIndex = 26;
            btnAgregarSocio.Text = "Agregar";
            btnAgregarSocio.UseVisualStyleBackColor = false;
            btnAgregarSocio.Click += BtnAgregarSocio_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F);
            label13.Location = new Point(242, 358);
            label13.Name = "label13";
            label13.Size = new Size(52, 15);
            label13.TabIndex = 25;
            label13.Text = "Teléfono";
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(242, 376);
            tbTelefono.MaxLength = 9;
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(202, 23);
            tbTelefono.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F);
            label12.Location = new Point(24, 358);
            label12.Name = "label12";
            label12.Size = new Size(36, 15);
            label12.TabIndex = 23;
            label12.Text = "Email";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(24, 376);
            tbEmail.MaxLength = 50;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(206, 23);
            tbEmail.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F);
            label11.Location = new Point(197, 301);
            label11.Name = "label11";
            label11.Size = new Size(107, 15);
            label11.TabIndex = 21;
            label11.Text = "Nombre y Apellido";
            // 
            // tbNombreCompleto
            // 
            tbNombreCompleto.Location = new Point(197, 319);
            tbNombreCompleto.MaxLength = 50;
            tbNombreCompleto.Name = "tbNombreCompleto";
            tbNombreCompleto.Size = new Size(247, 23);
            tbNombreCompleto.TabIndex = 20;
            // 
            // btnEliminarLibro
            // 
            btnEliminarLibro.BackColor = Color.CornflowerBlue;
            btnEliminarLibro.Cursor = Cursors.Hand;
            btnEliminarLibro.FlatStyle = FlatStyle.Flat;
            btnEliminarLibro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminarLibro.ForeColor = SystemColors.Control;
            btnEliminarLibro.Location = new Point(344, 194);
            btnEliminarLibro.Name = "btnEliminarLibro";
            btnEliminarLibro.Size = new Size(100, 32);
            btnEliminarLibro.TabIndex = 17;
            btnEliminarLibro.Text = "Eliminar";
            btnEliminarLibro.UseVisualStyleBackColor = false;
            btnEliminarLibro.Click += BtnEliminarLibro_Click;
            // 
            // btnModificarLibro
            // 
            btnModificarLibro.BackColor = Color.CornflowerBlue;
            btnModificarLibro.Cursor = Cursors.Hand;
            btnModificarLibro.FlatStyle = FlatStyle.Flat;
            btnModificarLibro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModificarLibro.ForeColor = SystemColors.Control;
            btnModificarLibro.Location = new Point(130, 194);
            btnModificarLibro.Name = "btnModificarLibro";
            btnModificarLibro.Size = new Size(100, 32);
            btnModificarLibro.TabIndex = 16;
            btnModificarLibro.Text = "Modificar";
            btnModificarLibro.UseVisualStyleBackColor = false;
            btnModificarLibro.Click += BtnModificarLibro_Click;
            // 
            // btnAgregarLibro
            // 
            btnAgregarLibro.BackColor = Color.CornflowerBlue;
            btnAgregarLibro.Cursor = Cursors.Hand;
            btnAgregarLibro.FlatStyle = FlatStyle.Flat;
            btnAgregarLibro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregarLibro.ForeColor = SystemColors.Control;
            btnAgregarLibro.Location = new Point(24, 194);
            btnAgregarLibro.Name = "btnAgregarLibro";
            btnAgregarLibro.Size = new Size(100, 32);
            btnAgregarLibro.TabIndex = 15;
            btnAgregarLibro.Text = "Agregar";
            btnAgregarLibro.UseVisualStyleBackColor = false;
            btnAgregarLibro.Click += BtnAgregarLibro_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F);
            label9.Location = new Point(24, 301);
            label9.Name = "label9";
            label9.Size = new Size(27, 15);
            label9.TabIndex = 14;
            label9.Text = "DNI";
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(24, 319);
            tbDNI.MaxLength = 9;
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(158, 23);
            tbDNI.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(91, 252);
            label7.Name = "label7";
            label7.Size = new Size(59, 21);
            label7.TabIndex = 12;
            label7.Text = "Socios";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(24, 252);
            label8.Name = "label8";
            label8.Size = new Size(73, 21);
            label8.TabIndex = 11;
            label8.Text = "Registrar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(24, 68);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 7;
            label5.Text = "Autor";
            // 
            // tbAutor
            // 
            tbAutor.Location = new Point(24, 86);
            tbAutor.MaxLength = 50;
            tbAutor.Name = "tbAutor";
            tbAutor.Size = new Size(420, 23);
            tbAutor.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(24, 126);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 3;
            label3.Text = "Título";
            // 
            // tbTitulo
            // 
            tbTitulo.Location = new Point(24, 144);
            tbTitulo.MaxLength = 50;
            tbTitulo.Name = "tbTitulo";
            tbTitulo.Size = new Size(420, 23);
            tbTitulo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(91, 28);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 1;
            label2.Text = "Libros";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(24, 28);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 0;
            label1.Text = "Registrar";
            // 
            // FrmFormularioPrincipal
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 698);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1217, 737);
            MinimumSize = new Size(1217, 737);
            Name = "FrmFormularioPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestión de Biblioteca";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox tbAutor;
        private Label label3;
        private TextBox tbTitulo;
        private Button btnEliminarLibro;
        private Button btnModificarLibro;
        private Button btnAgregarLibro;
        private Label label9;
        private TextBox tbDNI;
        private Label label7;
        private Label label8;
        private Label label13;
        private TextBox tbTelefono;
        private Label label12;
        private TextBox tbEmail;
        private Label label11;
        private TextBox tbNombreCompleto;
        private Label label10;
        private Label label14;
        private Button btnDevolverPrestamo;
        private Button btnModificar;
        private Button btnAgregarSocio;
        private ComboBox cmbSocio;
        private Label label18;
        private ComboBox cmbLibro;
        private Label label17;
        private DateTimePicker dtpFechaDevolucion;
        private Label label16;
        private DateTimePicker dtpFechaPrestamo;
        private Label label15;
        private DataGridView dgvLibros;
        private Label label23;
        private Label label24;
        private DataGridView dgvPrestamos;
        private Label label21;
        private Label label22;
        private DataGridView dgvSocios;
        private Label label19;
        private Label label20;
        private Button btnAgregarPrestamo;
        private Button btnEliminarSocio;
        private Button btnModificarPrestamo;
        private Label label6;
    }
}