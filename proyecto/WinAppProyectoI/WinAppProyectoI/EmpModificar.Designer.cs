namespace WinAppProyectoI
{
    partial class EmpModificar
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
            this.TxtBxEdad = new System.Windows.Forms.TextBox();
            this.CmBxCargo = new System.Windows.Forms.ComboBox();
            this.LblTxtEdad = new System.Windows.Forms.Label();
            this.LblTxtCiudad = new System.Windows.Forms.Label();
            this.TxtBxApellido = new System.Windows.Forms.TextBox();
            this.LblTxtApellido = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.BttGuardar = new System.Windows.Forms.Button();
            this.TxtBxCiudad = new System.Windows.Forms.TextBox();
            this.LblTxtLugar = new System.Windows.Forms.Label();
            this.LblTxtFechaIngreso = new System.Windows.Forms.Label();
            this.TxtBxCedula = new System.Windows.Forms.TextBox();
            this.LblTxtCedula = new System.Windows.Forms.Label();
            this.CmBxpProvincia = new System.Windows.Forms.ComboBox();
            this.TxtBxNombre = new System.Windows.Forms.TextBox();
            this.LblTxtNombre = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtBxEdad
            // 
            this.TxtBxEdad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxEdad.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxEdad.Location = new System.Drawing.Point(656, 286);
            this.TxtBxEdad.Name = "TxtBxEdad";
            this.TxtBxEdad.Size = new System.Drawing.Size(147, 28);
            this.TxtBxEdad.TabIndex = 121;
            this.TxtBxEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxEdad_KeyPress);
            // 
            // CmBxCargo
            // 
            this.CmBxCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CmBxCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmBxCargo.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmBxCargo.FormattingEnabled = true;
            this.CmBxCargo.Items.AddRange(new object[] {
            "Supervisor",
            "Guardia"});
            this.CmBxCargo.Location = new System.Drawing.Point(221, 287);
            this.CmBxCargo.Name = "CmBxCargo";
            this.CmBxCargo.Size = new System.Drawing.Size(160, 29);
            this.CmBxCargo.TabIndex = 120;
            this.CmBxCargo.ValueMemberChanged += new System.EventHandler(this.CmBxCargo_ValueMemberChanged);
            // 
            // LblTxtEdad
            // 
            this.LblTxtEdad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtEdad.AutoSize = true;
            this.LblTxtEdad.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtEdad.Location = new System.Drawing.Point(584, 290);
            this.LblTxtEdad.Name = "LblTxtEdad";
            this.LblTxtEdad.Size = new System.Drawing.Size(52, 21);
            this.LblTxtEdad.TabIndex = 119;
            this.LblTxtEdad.Text = "Edad";
            // 
            // LblTxtCiudad
            // 
            this.LblTxtCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtCiudad.AutoSize = true;
            this.LblTxtCiudad.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtCiudad.Location = new System.Drawing.Point(110, 84);
            this.LblTxtCiudad.Name = "LblTxtCiudad";
            this.LblTxtCiudad.Size = new System.Drawing.Size(70, 21);
            this.LblTxtCiudad.TabIndex = 118;
            this.LblTxtCiudad.Text = "Ciudad";
            // 
            // TxtBxApellido
            // 
            this.TxtBxApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxApellido.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxApellido.Location = new System.Drawing.Point(219, 204);
            this.TxtBxApellido.Name = "TxtBxApellido";
            this.TxtBxApellido.Size = new System.Drawing.Size(162, 28);
            this.TxtBxApellido.TabIndex = 117;
            this.TxtBxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxApellido_KeyPress);
            // 
            // LblTxtApellido
            // 
            this.LblTxtApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtApellido.AutoSize = true;
            this.LblTxtApellido.BackColor = System.Drawing.Color.Transparent;
            this.LblTxtApellido.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtApellido.ForeColor = System.Drawing.Color.Black;
            this.LblTxtApellido.Location = new System.Drawing.Point(113, 204);
            this.LblTxtApellido.Name = "LblTxtApellido";
            this.LblTxtApellido.Size = new System.Drawing.Size(85, 21);
            this.LblTxtApellido.TabIndex = 116;
            this.LblTxtApellido.Text = "Apellido";
            // 
            // Date
            // 
            this.Date.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(221, 244);
            this.Date.MaxDate = new System.DateTime(2018, 8, 17, 0, 0, 0, 0);
            this.Date.MinDate = new System.DateTime(1998, 1, 1, 0, 0, 0, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(160, 28);
            this.Date.TabIndex = 115;
            this.Date.Value = new System.DateTime(2018, 8, 9, 0, 0, 0, 0);
            this.Date.ValueChanged += new System.EventHandler(this.Date_ValueChanged);
            // 
            // BttGuardar
            // 
            this.BttGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BttGuardar.BackColor = System.Drawing.Color.Teal;
            this.BttGuardar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BttGuardar.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttGuardar.Location = new System.Drawing.Point(400, 378);
            this.BttGuardar.Name = "BttGuardar";
            this.BttGuardar.Size = new System.Drawing.Size(133, 57);
            this.BttGuardar.TabIndex = 114;
            this.BttGuardar.Text = "Modificar";
            this.BttGuardar.UseVisualStyleBackColor = false;
            this.BttGuardar.Click += new System.EventHandler(this.BttGuardar_Click);
            // 
            // TxtBxCiudad
            // 
            this.TxtBxCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxCiudad.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxCiudad.Location = new System.Drawing.Point(200, 80);
            this.TxtBxCiudad.Name = "TxtBxCiudad";
            this.TxtBxCiudad.Size = new System.Drawing.Size(147, 28);
            this.TxtBxCiudad.TabIndex = 113;
            this.TxtBxCiudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxCiudad_KeyPress);
            // 
            // LblTxtLugar
            // 
            this.LblTxtLugar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtLugar.AutoSize = true;
            this.LblTxtLugar.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtLugar.Location = new System.Drawing.Point(85, 33);
            this.LblTxtLugar.Name = "LblTxtLugar";
            this.LblTxtLugar.Size = new System.Drawing.Size(95, 21);
            this.LblTxtLugar.TabIndex = 112;
            this.LblTxtLugar.Text = "Provincia";
            // 
            // LblTxtFechaIngreso
            // 
            this.LblTxtFechaIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtFechaIngreso.AutoSize = true;
            this.LblTxtFechaIngreso.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtFechaIngreso.Location = new System.Drawing.Point(36, 251);
            this.LblTxtFechaIngreso.Name = "LblTxtFechaIngreso";
            this.LblTxtFechaIngreso.Size = new System.Drawing.Size(162, 21);
            this.LblTxtFechaIngreso.TabIndex = 111;
            this.LblTxtFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // TxtBxCedula
            // 
            this.TxtBxCedula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxCedula.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxCedula.Location = new System.Drawing.Point(413, 82);
            this.TxtBxCedula.Name = "TxtBxCedula";
            this.TxtBxCedula.Size = new System.Drawing.Size(161, 28);
            this.TxtBxCedula.TabIndex = 110;
            this.TxtBxCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxCedula_KeyPress);
            // 
            // LblTxtCedula
            // 
            this.LblTxtCedula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtCedula.AutoSize = true;
            this.LblTxtCedula.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtCedula.Location = new System.Drawing.Point(313, 89);
            this.LblTxtCedula.Name = "LblTxtCedula";
            this.LblTxtCedula.Size = new System.Drawing.Size(69, 21);
            this.LblTxtCedula.TabIndex = 109;
            this.LblTxtCedula.Text = "Cédula";
            // 
            // CmBxpProvincia
            // 
            this.CmBxpProvincia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CmBxpProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmBxpProvincia.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmBxpProvincia.FormattingEnabled = true;
            this.CmBxpProvincia.Items.AddRange(new object[] {
            "Azuay, Cuenca",
            "Bolívar, Guaranda",
            "Cañar, Azogues",
            "Carchi, Tulcán",
            "Chimborazo, Riobamba",
            "Cotopaxi, Latacunga",
            "El Oro, Machala",
            "Esmeraldas, Esmeraldas",
            "Galápagos, Puerto Baquerizo Moreno",
            "Guayas, Guayaquil",
            "Imbabura",
            "Loja",
            "Los Ríos",
            "Manabí",
            "Morona Santiago",
            "Napo",
            "Orellana",
            "Pastaza",
            "Pichincha",
            "Santa Elena",
            "Santo Domingo de los Tsáchilas",
            "Sucumbíos",
            "Tungurahua",
            "Zamora Chinchipe"});
            this.CmBxpProvincia.Location = new System.Drawing.Point(203, 25);
            this.CmBxpProvincia.Name = "CmBxpProvincia";
            this.CmBxpProvincia.Size = new System.Drawing.Size(147, 29);
            this.CmBxpProvincia.TabIndex = 108;
            this.CmBxpProvincia.ValueMemberChanged += new System.EventHandler(this.CmBxpProvincia_ValueMemberChanged);
            // 
            // TxtBxNombre
            // 
            this.TxtBxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxNombre.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxNombre.Location = new System.Drawing.Point(221, 150);
            this.TxtBxNombre.Name = "TxtBxNombre";
            this.TxtBxNombre.Size = new System.Drawing.Size(162, 28);
            this.TxtBxNombre.TabIndex = 107;
            this.TxtBxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxNombre_KeyPress);
            // 
            // LblTxtNombre
            // 
            this.LblTxtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtNombre.AutoSize = true;
            this.LblTxtNombre.BackColor = System.Drawing.Color.Transparent;
            this.LblTxtNombre.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtNombre.ForeColor = System.Drawing.Color.Black;
            this.LblTxtNombre.Location = new System.Drawing.Point(115, 153);
            this.LblTxtNombre.Name = "LblTxtNombre";
            this.LblTxtNombre.Size = new System.Drawing.Size(83, 21);
            this.LblTxtNombre.TabIndex = 106;
            this.LblTxtNombre.Text = "Nombre";
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Colonna MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(317, 21);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(319, 28);
            this.LblTitulo.TabIndex = 105;
            this.LblTitulo.Text = "MODIFICAR EMPLEADOS";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 122;
            this.label1.Text = "Cargo";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.LblTxtCiudad);
            this.groupBox1.Controls.Add(this.TxtBxCiudad);
            this.groupBox1.Controls.Add(this.LblTxtLugar);
            this.groupBox1.Controls.Add(this.CmBxpProvincia);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Colonna MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(456, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 124);
            this.groupBox1.TabIndex = 123;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lugar de Trabajo";
            // 
            // EmpModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(910, 483);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBxEdad);
            this.Controls.Add(this.CmBxCargo);
            this.Controls.Add(this.LblTxtEdad);
            this.Controls.Add(this.TxtBxApellido);
            this.Controls.Add(this.LblTxtApellido);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.BttGuardar);
            this.Controls.Add(this.LblTxtFechaIngreso);
            this.Controls.Add(this.TxtBxCedula);
            this.Controls.Add(this.LblTxtCedula);
            this.Controls.Add(this.TxtBxNombre);
            this.Controls.Add(this.LblTxtNombre);
            this.Controls.Add(this.LblTitulo);
            this.Name = "EmpModificar";
            this.Text = "EmpModificar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TxtBxEdad;
        public System.Windows.Forms.ComboBox CmBxCargo;
        private System.Windows.Forms.Label LblTxtEdad;
        private System.Windows.Forms.Label LblTxtCiudad;
        public System.Windows.Forms.TextBox TxtBxApellido;
        private System.Windows.Forms.Label LblTxtApellido;
        public System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Button BttGuardar;
        public System.Windows.Forms.TextBox TxtBxCiudad;
        private System.Windows.Forms.Label LblTxtLugar;
        private System.Windows.Forms.Label LblTxtFechaIngreso;
        public System.Windows.Forms.TextBox TxtBxCedula;
        private System.Windows.Forms.Label LblTxtCedula;
        public System.Windows.Forms.ComboBox CmBxpProvincia;
        public System.Windows.Forms.TextBox TxtBxNombre;
        private System.Windows.Forms.Label LblTxtNombre;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}