namespace WinAppProyectoI
{
    partial class UniformesModificar
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
            this.CbxTalla = new System.Windows.Forms.ComboBox();
            this.LblPrecioT = new System.Windows.Forms.Label();
            this.LblTctPrecio = new System.Windows.Forms.Label();
            this.LblTxtCodigo = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.BttGuardar = new System.Windows.Forms.Button();
            this.TxtBxPrecio = new System.Windows.Forms.TextBox();
            this.LblTxtPrecio = new System.Windows.Forms.Label();
            this.TxtBxCantidad = new System.Windows.Forms.TextBox();
            this.LblTxtCantidad = new System.Windows.Forms.Label();
            this.LblTxtFechaIngreso = new System.Windows.Forms.Label();
            this.CmBxEstado = new System.Windows.Forms.ComboBox();
            this.TxtBxNombre = new System.Windows.Forms.TextBox();
            this.LblTxtNombre = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.datas = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombreR = new System.Windows.Forms.TextBox();
            this.matSeg1 = new WinAppProyectoI.MatSeg();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblApellido = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matSeg1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbxTalla
            // 
            this.CbxTalla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CbxTalla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxTalla.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxTalla.FormattingEnabled = true;
            this.CbxTalla.Items.AddRange(new object[] {
            "32",
            "34",
            "36",
            "38",
            "40",
            "42",
            "46",
            "48"});
            this.CbxTalla.Location = new System.Drawing.Point(263, 285);
            this.CbxTalla.Name = "CbxTalla";
            this.CbxTalla.Size = new System.Drawing.Size(116, 29);
            this.CbxTalla.TabIndex = 113;
            this.CbxTalla.ValueMemberChanged += new System.EventHandler(this.CbxTalla_ValueMemberChanged);
            // 
            // LblPrecioT
            // 
            this.LblPrecioT.AutoSize = true;
            this.LblPrecioT.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioT.Location = new System.Drawing.Point(674, 302);
            this.LblPrecioT.Name = "LblPrecioT";
            this.LblPrecioT.Size = new System.Drawing.Size(121, 21);
            this.LblPrecioT.TabIndex = 112;
            this.LblPrecioT.Text = "Precio Total";
            // 
            // LblTctPrecio
            // 
            this.LblTctPrecio.AutoSize = true;
            this.LblTctPrecio.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTctPrecio.Location = new System.Drawing.Point(521, 302);
            this.LblTctPrecio.Name = "LblTctPrecio";
            this.LblTctPrecio.Size = new System.Drawing.Size(121, 21);
            this.LblTctPrecio.TabIndex = 111;
            this.LblTctPrecio.Text = "Precio Total";
            // 
            // LblTxtCodigo
            // 
            this.LblTxtCodigo.AutoSize = true;
            this.LblTxtCodigo.Font = new System.Drawing.Font("Colonna MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtCodigo.Location = new System.Drawing.Point(354, 49);
            this.LblTxtCodigo.Name = "LblTxtCodigo";
            this.LblTxtCodigo.Size = new System.Drawing.Size(90, 25);
            this.LblTxtCodigo.TabIndex = 110;
            this.LblTxtCodigo.Text = "Código";
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Colonna MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(499, 49);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(90, 25);
            this.LblCodigo.TabIndex = 109;
            this.LblCodigo.Text = "Codigo";
            // 
            // Date
            // 
            this.Date.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(262, 148);
            this.Date.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.Date.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(115, 28);
            this.Date.TabIndex = 108;
            this.Date.ValueChanged += new System.EventHandler(this.Date_ValueChanged);
            // 
            // BttGuardar
            // 
            this.BttGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BttGuardar.BackColor = System.Drawing.Color.DarkCyan;
            this.BttGuardar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BttGuardar.FlatAppearance.BorderSize = 3;
            this.BttGuardar.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttGuardar.Location = new System.Drawing.Point(393, 391);
            this.BttGuardar.Name = "BttGuardar";
            this.BttGuardar.Size = new System.Drawing.Size(133, 57);
            this.BttGuardar.TabIndex = 107;
            this.BttGuardar.Text = "Modificar";
            this.BttGuardar.UseVisualStyleBackColor = false;
            this.BttGuardar.Click += new System.EventHandler(this.BttGuardar_Click);
            // 
            // TxtBxPrecio
            // 
            this.TxtBxPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxPrecio.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxPrecio.Location = new System.Drawing.Point(677, 260);
            this.TxtBxPrecio.Name = "TxtBxPrecio";
            this.TxtBxPrecio.Size = new System.Drawing.Size(115, 28);
            this.TxtBxPrecio.TabIndex = 106;
            this.TxtBxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxPrecio_KeyPress);
            // 
            // LblTxtPrecio
            // 
            this.LblTxtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtPrecio.AutoSize = true;
            this.LblTxtPrecio.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtPrecio.Location = new System.Drawing.Point(494, 263);
            this.LblTxtPrecio.Name = "LblTxtPrecio";
            this.LblTxtPrecio.Size = new System.Drawing.Size(148, 21);
            this.LblTxtPrecio.TabIndex = 105;
            this.LblTxtPrecio.Text = "Precio Unitario";
            // 
            // TxtBxCantidad
            // 
            this.TxtBxCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxCantidad.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxCantidad.Location = new System.Drawing.Point(678, 217);
            this.TxtBxCantidad.Name = "TxtBxCantidad";
            this.TxtBxCantidad.Size = new System.Drawing.Size(116, 28);
            this.TxtBxCantidad.TabIndex = 104;
            this.TxtBxCantidad.TextChanged += new System.EventHandler(this.TxtBxCantidad_TextChanged);
            this.TxtBxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxCantidad_KeyPress);
            // 
            // LblTxtCantidad
            // 
            this.LblTxtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtCantidad.AutoSize = true;
            this.LblTxtCantidad.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtCantidad.Location = new System.Drawing.Point(555, 224);
            this.LblTxtCantidad.Name = "LblTxtCantidad";
            this.LblTxtCantidad.Size = new System.Drawing.Size(87, 21);
            this.LblTxtCantidad.TabIndex = 103;
            this.LblTxtCantidad.Text = "Cantidad";
            // 
            // LblTxtFechaIngreso
            // 
            this.LblTxtFechaIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtFechaIngreso.AutoSize = true;
            this.LblTxtFechaIngreso.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtFechaIngreso.Location = new System.Drawing.Point(67, 155);
            this.LblTxtFechaIngreso.Name = "LblTxtFechaIngreso";
            this.LblTxtFechaIngreso.Size = new System.Drawing.Size(162, 21);
            this.LblTxtFechaIngreso.TabIndex = 102;
            this.LblTxtFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // CmBxEstado
            // 
            this.CmBxEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CmBxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmBxEstado.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmBxEstado.FormattingEnabled = true;
            this.CmBxEstado.Items.AddRange(new object[] {
            "Bueno",
            "Malo"});
            this.CmBxEstado.Location = new System.Drawing.Point(263, 232);
            this.CmBxEstado.Name = "CmBxEstado";
            this.CmBxEstado.Size = new System.Drawing.Size(116, 29);
            this.CmBxEstado.TabIndex = 101;
            this.CmBxEstado.ValueMemberChanged += new System.EventHandler(this.CmBxEstado_ValueMemberChanged);
            // 
            // TxtBxNombre
            // 
            this.TxtBxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxNombre.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxNombre.Location = new System.Drawing.Point(262, 102);
            this.TxtBxNombre.Name = "TxtBxNombre";
            this.TxtBxNombre.Size = new System.Drawing.Size(116, 28);
            this.TxtBxNombre.TabIndex = 100;
            this.TxtBxNombre.TextChanged += new System.EventHandler(this.TxtBxNombre_TextChanged);
            this.TxtBxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxNombre_KeyPress);
            // 
            // LblTxtNombre
            // 
            this.LblTxtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtNombre.AutoSize = true;
            this.LblTxtNombre.BackColor = System.Drawing.Color.Transparent;
            this.LblTxtNombre.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtNombre.ForeColor = System.Drawing.Color.Black;
            this.LblTxtNombre.Location = new System.Drawing.Point(18, 109);
            this.LblTxtNombre.Name = "LblTxtNombre";
            this.LblTxtNombre.Size = new System.Drawing.Size(211, 21);
            this.LblTxtNombre.TabIndex = 99;
            this.LblTxtNombre.Text = "Nombre del uniformes";
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Colonna MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(389, 6);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(165, 28);
            this.LblTitulo.TabIndex = 98;
            this.LblTitulo.Text = "UNIFORMES";
            // 
            // datas
            // 
            this.datas.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datas.Location = new System.Drawing.Point(262, 194);
            this.datas.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.datas.Name = "datas";
            this.datas.Size = new System.Drawing.Size(115, 28);
            this.datas.TabIndex = 115;
            this.datas.Validated += new System.EventHandler(this.datas_Validated);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 21);
            this.label1.TabIndex = 114;
            this.label1.Text = "Fecha de Salida";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 116;
            this.label2.Text = "Cédula ";
            // 
            // TxtNombreR
            // 
            this.TxtNombreR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtNombreR.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreR.Location = new System.Drawing.Point(202, 19);
            this.TxtNombreR.Name = "TxtNombreR";
            this.TxtNombreR.Size = new System.Drawing.Size(115, 28);
            this.TxtNombreR.TabIndex = 117;
            this.TxtNombreR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreR_KeyPress);
            // 
            // matSeg1
            // 
            this.matSeg1.DataSetName = "MatSeg";
            this.matSeg1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 118;
            this.label3.Text = "Estado";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 119;
            this.label4.Text = "Talla";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblApellido);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.LblNombre);
            this.groupBox1.Controls.Add(this.TxtNombreR);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Colonna MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(433, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 117);
            this.groupBox1.TabIndex = 120;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Personal Responsable";
            // 
            // LblApellido
            // 
            this.LblApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellido.Location = new System.Drawing.Point(274, 70);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(75, 21);
            this.LblApellido.TabIndex = 120;
            this.LblApellido.Text = "Cédula ";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 21);
            this.label6.TabIndex = 119;
            this.label6.Text = "Nombre:";
            // 
            // LblNombre
            // 
            this.LblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(134, 69);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(75, 21);
            this.LblNombre.TabIndex = 118;
            this.LblNombre.Text = "Cédula ";
            // 
            // UniformesModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(852, 473);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbxTalla);
            this.Controls.Add(this.LblPrecioT);
            this.Controls.Add(this.LblTctPrecio);
            this.Controls.Add(this.LblTxtCodigo);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.BttGuardar);
            this.Controls.Add(this.TxtBxPrecio);
            this.Controls.Add(this.LblTxtPrecio);
            this.Controls.Add(this.TxtBxCantidad);
            this.Controls.Add(this.LblTxtCantidad);
            this.Controls.Add(this.LblTxtFechaIngreso);
            this.Controls.Add(this.CmBxEstado);
            this.Controls.Add(this.TxtBxNombre);
            this.Controls.Add(this.LblTxtNombre);
            this.Controls.Add(this.LblTitulo);
            this.Name = "UniformesModificar";
            this.Text = "UniformesModificar";
            ((System.ComponentModel.ISupportInitialize)(this.matSeg1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox CbxTalla;
        public System.Windows.Forms.Label LblPrecioT;
        private System.Windows.Forms.Label LblTctPrecio;
        public System.Windows.Forms.Label LblTxtCodigo;
        public System.Windows.Forms.Label LblCodigo;
        public System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Button BttGuardar;
        public System.Windows.Forms.TextBox TxtBxPrecio;
        private System.Windows.Forms.Label LblTxtPrecio;
        public System.Windows.Forms.TextBox TxtBxCantidad;
        private System.Windows.Forms.Label LblTxtCantidad;
        private System.Windows.Forms.Label LblTxtFechaIngreso;
        public System.Windows.Forms.ComboBox CmBxEstado;
        public System.Windows.Forms.TextBox TxtBxNombre;
        private System.Windows.Forms.Label LblTxtNombre;
        private System.Windows.Forms.Label LblTitulo;
        public System.Windows.Forms.DateTimePicker datas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtNombreR;
        private MatSeg matSeg1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label LblNombre;
    }
}