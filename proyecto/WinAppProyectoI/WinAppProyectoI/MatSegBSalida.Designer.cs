namespace WinAppProyectoI
{
    partial class MatSegBSalida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatSegBSalida));
            this.DateS = new System.Windows.Forms.DateTimePicker();
            this.LblTxtFechaSalida = new System.Windows.Forms.Label();
            this.TxtBxCantidad = new System.Windows.Forms.TextBox();
            this.LblTxtCantidad = new System.Windows.Forms.Label();
            this.TxtBxCedula = new System.Windows.Forms.TextBox();
            this.LblTxtNomreUsuario = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.Bttguardar = new System.Windows.Forms.Button();
            this.LblCantExi = new System.Windows.Forms.Label();
            this.LblCExis = new System.Windows.Forms.Label();
            this.LblCanN = new System.Windows.Forms.Label();
            this.LblTxtCantidadN = new System.Windows.Forms.Label();
            this.LblFechaE = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Mazimizar = new System.Windows.Forms.PictureBox();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.matSeg1 = new WinAppProyectoI.MatSeg();
            this.label1 = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblNombreM = new System.Windows.Forms.Label();
            this.LblN = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mazimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matSeg1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateS
            // 
            this.DateS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DateS.CalendarFont = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateS.Font = new System.Drawing.Font("Colonna MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateS.Location = new System.Drawing.Point(445, 179);
            this.DateS.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.DateS.Name = "DateS";
            this.DateS.Size = new System.Drawing.Size(117, 24);
            this.DateS.TabIndex = 74;
            this.DateS.ValueChanged += new System.EventHandler(this.DateS_ValueChanged);
            // 
            // LblTxtFechaSalida
            // 
            this.LblTxtFechaSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtFechaSalida.AutoSize = true;
            this.LblTxtFechaSalida.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtFechaSalida.Location = new System.Drawing.Point(258, 179);
            this.LblTxtFechaSalida.Name = "LblTxtFechaSalida";
            this.LblTxtFechaSalida.Size = new System.Drawing.Size(144, 21);
            this.LblTxtFechaSalida.TabIndex = 73;
            this.LblTxtFechaSalida.Text = "Fecha de Salida";
            // 
            // TxtBxCantidad
            // 
            this.TxtBxCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxCantidad.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxCantidad.Location = new System.Drawing.Point(450, 348);
            this.TxtBxCantidad.Name = "TxtBxCantidad";
            this.TxtBxCantidad.Size = new System.Drawing.Size(116, 28);
            this.TxtBxCantidad.TabIndex = 78;
            this.TxtBxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxCantidad_KeyPress);
            // 
            // LblTxtCantidad
            // 
            this.LblTxtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtCantidad.AutoSize = true;
            this.LblTxtCantidad.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtCantidad.Location = new System.Drawing.Point(319, 355);
            this.LblTxtCantidad.Name = "LblTxtCantidad";
            this.LblTxtCantidad.Size = new System.Drawing.Size(87, 21);
            this.LblTxtCantidad.TabIndex = 77;
            this.LblTxtCantidad.Text = "Cantidad";
            // 
            // TxtBxCedula
            // 
            this.TxtBxCedula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxCedula.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxCedula.Location = new System.Drawing.Point(232, 17);
            this.TxtBxCedula.Name = "TxtBxCedula";
            this.TxtBxCedula.Size = new System.Drawing.Size(116, 28);
            this.TxtBxCedula.TabIndex = 76;
            this.TxtBxCedula.TextChanged += new System.EventHandler(this.TxtBxCedula_TextChanged);
            this.TxtBxCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxNombreUsuario_KeyPress);
            // 
            // LblTxtNomreUsuario
            // 
            this.LblTxtNomreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtNomreUsuario.AutoSize = true;
            this.LblTxtNomreUsuario.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtNomreUsuario.Location = new System.Drawing.Point(119, 20);
            this.LblTxtNomreUsuario.Name = "LblTxtNomreUsuario";
            this.LblTxtNomreUsuario.Size = new System.Drawing.Size(69, 21);
            this.LblTxtNomreUsuario.TabIndex = 75;
            this.LblTxtNomreUsuario.Text = "Cédula";
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Colonna MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(158, 53);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(525, 28);
            this.LblTitulo.TabIndex = 79;
            this.LblTitulo.Text = "SALIDA DE MATERIALES DE SEGURIDAD";
            // 
            // Bttguardar
            // 
            this.Bttguardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Bttguardar.BackColor = System.Drawing.Color.DarkCyan;
            this.Bttguardar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Bttguardar.FlatAppearance.BorderSize = 3;
            this.Bttguardar.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttguardar.Location = new System.Drawing.Point(349, 470);
            this.Bttguardar.Name = "Bttguardar";
            this.Bttguardar.Size = new System.Drawing.Size(142, 43);
            this.Bttguardar.TabIndex = 80;
            this.Bttguardar.Text = "GUARDAR";
            this.Bttguardar.UseVisualStyleBackColor = false;
            this.Bttguardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblCantExi
            // 
            this.LblCantExi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblCantExi.AutoSize = true;
            this.LblCantExi.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantExi.Location = new System.Drawing.Point(33, 144);
            this.LblCantExi.Name = "LblCantExi";
            this.LblCantExi.Size = new System.Drawing.Size(175, 21);
            this.LblCantExi.TabIndex = 81;
            this.LblCantExi.Text = "Cantidad existente";
            // 
            // LblCExis
            // 
            this.LblCExis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblCExis.AutoSize = true;
            this.LblCExis.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCExis.Location = new System.Drawing.Point(226, 144);
            this.LblCExis.Name = "LblCExis";
            this.LblCExis.Size = new System.Drawing.Size(35, 21);
            this.LblCExis.TabIndex = 82;
            this.LblCExis.Text = ".....";
            // 
            // LblCanN
            // 
            this.LblCanN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblCanN.AutoSize = true;
            this.LblCanN.Font = new System.Drawing.Font("Colonna MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCanN.Location = new System.Drawing.Point(444, 410);
            this.LblCanN.Name = "LblCanN";
            this.LblCanN.Size = new System.Drawing.Size(155, 17);
            this.LblCanN.TabIndex = 84;
            this.LblCanN.Text = "Cantidad existente";
            // 
            // LblTxtCantidadN
            // 
            this.LblTxtCantidadN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtCantidadN.AutoSize = true;
            this.LblTxtCantidadN.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtCantidadN.Location = new System.Drawing.Point(332, 406);
            this.LblTxtCantidadN.Name = "LblTxtCantidadN";
            this.LblTxtCantidadN.Size = new System.Drawing.Size(70, 21);
            this.LblTxtCantidadN.TabIndex = 83;
            this.LblTxtCantidadN.Text = "Existe ";
            // 
            // LblFechaE
            // 
            this.LblFechaE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblFechaE.AutoSize = true;
            this.LblFechaE.Font = new System.Drawing.Font("Colonna MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaE.Location = new System.Drawing.Point(467, 150);
            this.LblFechaE.Name = "LblFechaE";
            this.LblFechaE.Size = new System.Drawing.Size(139, 17);
            this.LblFechaE.TabIndex = 86;
            this.LblFechaE.Text = "Fecha de entrada";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Restaurar);
            this.panel1.Controls.Add(this.Mazimizar);
            this.panel1.Controls.Add(this.Cerrar);
            this.panel1.Controls.Add(this.Minimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 40);
            this.panel1.TabIndex = 88;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(782, 7);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(25, 25);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restaurar.TabIndex = 134;
            this.Restaurar.TabStop = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Mazimizar
            // 
            this.Mazimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Mazimizar.Image = ((System.Drawing.Image)(resources.GetObject("Mazimizar.Image")));
            this.Mazimizar.Location = new System.Drawing.Point(782, 7);
            this.Mazimizar.Name = "Mazimizar";
            this.Mazimizar.Size = new System.Drawing.Size(25, 25);
            this.Mazimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mazimizar.TabIndex = 135;
            this.Mazimizar.TabStop = false;
            this.Mazimizar.Click += new System.EventHandler(this.Mazimizar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.Location = new System.Drawing.Point(813, 7);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(25, 25);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cerrar.TabIndex = 136;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(751, 7);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(25, 25);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 133;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // matSeg1
            // 
            this.matSeg1.DataSetName = "MatSeg";
            this.matSeg1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 89;
            this.label1.Text = "Nombre:";
            // 
            // LblNombre
            // 
            this.LblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(160, 72);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(0, 21);
            this.LblNombre.TabIndex = 90;
            // 
            // LblApellido
            // 
            this.LblApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellido.Location = new System.Drawing.Point(278, 72);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(0, 21);
            this.LblApellido.TabIndex = 91;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblApellido);
            this.groupBox1.Controls.Add(this.LblNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtBxCedula);
            this.groupBox1.Controls.Add(this.LblTxtNomreUsuario);
            this.groupBox1.Font = new System.Drawing.Font("Colonna MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(213, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 119);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL RESPONSABLE";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Colonna MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(612, 144);
            this.dateTimePicker1.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(103, 24);
            this.dateTimePicker1.TabIndex = 87;
            this.dateTimePicker1.Value = new System.DateTime(2018, 7, 30, 5, 45, 21, 0);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 93;
            this.label2.Text = "Codigo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblCodigo
            // 
            this.LblCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(235, 100);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(70, 21);
            this.LblCodigo.TabIndex = 94;
            this.LblCodigo.Text = "Existe ";
            // 
            // LblNombreM
            // 
            this.LblNombreM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblNombreM.AutoSize = true;
            this.LblNombreM.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreM.Location = new System.Drawing.Point(536, 100);
            this.LblNombreM.Name = "LblNombreM";
            this.LblNombreM.Size = new System.Drawing.Size(70, 21);
            this.LblNombreM.TabIndex = 95;
            this.LblNombreM.Text = "Existe ";
            // 
            // LblN
            // 
            this.LblN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblN.AutoSize = true;
            this.LblN.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblN.Location = new System.Drawing.Point(431, 100);
            this.LblN.Name = "LblN";
            this.LblN.Size = new System.Drawing.Size(83, 21);
            this.LblN.TabIndex = 96;
            this.LblN.Text = "Nombre";
            // 
            // MatSegBSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(843, 528);
            this.Controls.Add(this.LblN);
            this.Controls.Add(this.LblNombreM);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LblFechaE);
            this.Controls.Add(this.LblCanN);
            this.Controls.Add(this.LblTxtCantidadN);
            this.Controls.Add(this.LblCExis);
            this.Controls.Add(this.LblCantExi);
            this.Controls.Add(this.Bttguardar);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.TxtBxCantidad);
            this.Controls.Add(this.LblTxtCantidad);
            this.Controls.Add(this.DateS);
            this.Controls.Add(this.LblTxtFechaSalida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MatSegBSalida";
            this.Text = "EntregarMatS";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mazimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matSeg1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker DateS;
        private System.Windows.Forms.Label LblTxtFechaSalida;
        public System.Windows.Forms.TextBox TxtBxCantidad;
        private System.Windows.Forms.Label LblTxtCantidad;
        public System.Windows.Forms.TextBox TxtBxCedula;
        private System.Windows.Forms.Label LblTxtNomreUsuario;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button Bttguardar;
        private System.Windows.Forms.Label LblCantExi;
        public System.Windows.Forms.Label LblCExis;
        public System.Windows.Forms.Label LblCanN;
        private System.Windows.Forms.Label LblTxtCantidadN;
        private System.Windows.Forms.Label LblFechaE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.PictureBox Mazimizar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Cerrar;
        private MatSeg matSeg1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label LblNombre;
        public System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label LblCodigo;
        public System.Windows.Forms.Label LblNombreM;
        private System.Windows.Forms.Label LblN;
    }
}