namespace WinAppProyectoI
{
    partial class MatSegIngresar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatSegIngresar));
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.BttGuardar = new System.Windows.Forms.Button();
            this.TxtBxPrecio = new System.Windows.Forms.TextBox();
            this.LblTxtPrecio = new System.Windows.Forms.Label();
            this.TxtBxCantidad = new System.Windows.Forms.TextBox();
            this.LblTxtCantidad = new System.Windows.Forms.Label();
            this.LblTxtFechaIngreso = new System.Windows.Forms.Label();
            this.TxtBxModelo = new System.Windows.Forms.TextBox();
            this.LblTxtModelo = new System.Windows.Forms.Label();
            this.TxtBxMarca = new System.Windows.Forms.TextBox();
            this.LblTxtMarca = new System.Windows.Forms.Label();
            this.CmBxEstado = new System.Windows.Forms.ComboBox();
            this.TxtBxNombre = new System.Windows.Forms.TextBox();
            this.LblTxtNombre = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.matSeg1 = new WinAppProyectoI.MatSeg();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Mazimizar = new System.Windows.Forms.PictureBox();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblTxtCodigo = new System.Windows.Forms.Label();
            this.LblTctPrecio = new System.Windows.Forms.Label();
            this.LblPrecioT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matSeg1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mazimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // Date
            // 
            this.Date.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(366, 328);
            this.Date.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(115, 28);
            this.Date.TabIndex = 71;
            this.Date.ValueChanged += new System.EventHandler(this.Date_ValueChanged);
            // 
            // BttGuardar
            // 
            this.BttGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BttGuardar.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttGuardar.Location = new System.Drawing.Point(482, 449);
            this.BttGuardar.Name = "BttGuardar";
            this.BttGuardar.Size = new System.Drawing.Size(133, 57);
            this.BttGuardar.TabIndex = 69;
            this.BttGuardar.Text = "Guardar";
            this.BttGuardar.UseVisualStyleBackColor = true;
            this.BttGuardar.Click += new System.EventHandler(this.BttGuardar_Click);
            // 
            // TxtBxPrecio
            // 
            this.TxtBxPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxPrecio.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxPrecio.Location = new System.Drawing.Point(826, 281);
            this.TxtBxPrecio.Name = "TxtBxPrecio";
            this.TxtBxPrecio.Size = new System.Drawing.Size(115, 28);
            this.TxtBxPrecio.TabIndex = 67;
            this.TxtBxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxPrecio_KeyPress);
            // 
            // LblTxtPrecio
            // 
            this.LblTxtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtPrecio.AutoSize = true;
            this.LblTxtPrecio.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtPrecio.Location = new System.Drawing.Point(633, 284);
            this.LblTxtPrecio.Name = "LblTxtPrecio";
            this.LblTxtPrecio.Size = new System.Drawing.Size(148, 21);
            this.LblTxtPrecio.TabIndex = 66;
            this.LblTxtPrecio.Text = "Precio Unitario";
            // 
            // TxtBxCantidad
            // 
            this.TxtBxCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxCantidad.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxCantidad.Location = new System.Drawing.Point(825, 224);
            this.TxtBxCantidad.Name = "TxtBxCantidad";
            this.TxtBxCantidad.Size = new System.Drawing.Size(116, 28);
            this.TxtBxCantidad.TabIndex = 65;
            this.TxtBxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxCantidad_KeyPress);
            // 
            // LblTxtCantidad
            // 
            this.LblTxtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtCantidad.AutoSize = true;
            this.LblTxtCantidad.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtCantidad.Location = new System.Drawing.Point(693, 227);
            this.LblTxtCantidad.Name = "LblTxtCantidad";
            this.LblTxtCantidad.Size = new System.Drawing.Size(87, 21);
            this.LblTxtCantidad.TabIndex = 64;
            this.LblTxtCantidad.Text = "Cantidad";
            // 
            // LblTxtFechaIngreso
            // 
            this.LblTxtFechaIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtFechaIngreso.AutoSize = true;
            this.LblTxtFechaIngreso.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtFechaIngreso.Location = new System.Drawing.Point(170, 334);
            this.LblTxtFechaIngreso.Name = "LblTxtFechaIngreso";
            this.LblTxtFechaIngreso.Size = new System.Drawing.Size(162, 21);
            this.LblTxtFechaIngreso.TabIndex = 60;
            this.LblTxtFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // TxtBxModelo
            // 
            this.TxtBxModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxModelo.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxModelo.Location = new System.Drawing.Point(365, 277);
            this.TxtBxModelo.Name = "TxtBxModelo";
            this.TxtBxModelo.Size = new System.Drawing.Size(116, 28);
            this.TxtBxModelo.TabIndex = 59;
            this.TxtBxModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxModelo_KeyPress);
            // 
            // LblTxtModelo
            // 
            this.LblTxtModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtModelo.AutoSize = true;
            this.LblTxtModelo.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtModelo.Location = new System.Drawing.Point(252, 284);
            this.LblTxtModelo.Name = "LblTxtModelo";
            this.LblTxtModelo.Size = new System.Drawing.Size(75, 21);
            this.LblTxtModelo.TabIndex = 58;
            this.LblTxtModelo.Text = "Modelo";
            // 
            // TxtBxMarca
            // 
            this.TxtBxMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxMarca.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxMarca.Location = new System.Drawing.Point(365, 227);
            this.TxtBxMarca.Name = "TxtBxMarca";
            this.TxtBxMarca.Size = new System.Drawing.Size(116, 28);
            this.TxtBxMarca.TabIndex = 57;
            this.TxtBxMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxMarca_KeyPress);
            // 
            // LblTxtMarca
            // 
            this.LblTxtMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtMarca.AutoSize = true;
            this.LblTxtMarca.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtMarca.Location = new System.Drawing.Point(264, 230);
            this.LblTxtMarca.Name = "LblTxtMarca";
            this.LblTxtMarca.Size = new System.Drawing.Size(63, 21);
            this.LblTxtMarca.TabIndex = 56;
            this.LblTxtMarca.Text = "Marca";
            // 
            // CmBxEstado
            // 
            this.CmBxEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CmBxEstado.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmBxEstado.FormattingEnabled = true;
            this.CmBxEstado.Items.AddRange(new object[] {
            "Buen",
            "Mal"});
            this.CmBxEstado.Location = new System.Drawing.Point(749, 154);
            this.CmBxEstado.Name = "CmBxEstado";
            this.CmBxEstado.Size = new System.Drawing.Size(116, 29);
            this.CmBxEstado.TabIndex = 53;
            this.CmBxEstado.Text = "ESTADO";
            this.CmBxEstado.Validated += new System.EventHandler(this.CmBxEstado_Validated);
            // 
            // TxtBxNombre
            // 
            this.TxtBxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxNombre.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxNombre.Location = new System.Drawing.Point(365, 174);
            this.TxtBxNombre.Name = "TxtBxNombre";
            this.TxtBxNombre.Size = new System.Drawing.Size(116, 28);
            this.TxtBxNombre.TabIndex = 52;
            this.TxtBxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxNombre_KeyPress);
            // 
            // LblTxtNombre
            // 
            this.LblTxtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtNombre.AutoSize = true;
            this.LblTxtNombre.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblTxtNombre.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtNombre.ForeColor = System.Drawing.Color.White;
            this.LblTxtNombre.Location = new System.Drawing.Point(17, 177);
            this.LblTxtNombre.Name = "LblTxtNombre";
            this.LblTxtNombre.Size = new System.Drawing.Size(315, 21);
            this.LblTxtNombre.TabIndex = 51;
            this.LblTxtNombre.Text = "Nombre del material de seguridad";
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Colonna MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(361, 59);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(380, 28);
            this.LblTitulo.TabIndex = 50;
            this.LblTitulo.Text = "MATERIALES DE SEGURIDAD";
            // 
            // matSeg1
            // 
            this.matSeg1.DataSetName = "MatSeg";
            this.matSeg1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.panel1.Size = new System.Drawing.Size(1034, 40);
            this.panel1.TabIndex = 73;
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(970, 8);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(25, 25);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restaurar.TabIndex = 20;
            this.Restaurar.TabStop = false;
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Mazimizar
            // 
            this.Mazimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Mazimizar.Image = ((System.Drawing.Image)(resources.GetObject("Mazimizar.Image")));
            this.Mazimizar.Location = new System.Drawing.Point(970, 8);
            this.Mazimizar.Name = "Mazimizar";
            this.Mazimizar.Size = new System.Drawing.Size(25, 25);
            this.Mazimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mazimizar.TabIndex = 21;
            this.Mazimizar.TabStop = false;
            this.Mazimizar.Click += new System.EventHandler(this.Mazimizar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.Location = new System.Drawing.Point(1001, 8);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(25, 25);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cerrar.TabIndex = 22;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(939, 8);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(25, 25);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 19;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Colonna MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(391, 116);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(90, 25);
            this.LblCodigo.TabIndex = 74;
            this.LblCodigo.Text = "Codigo";
            // 
            // LblTxtCodigo
            // 
            this.LblTxtCodigo.AutoSize = true;
            this.LblTxtCodigo.Font = new System.Drawing.Font("Colonna MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtCodigo.Location = new System.Drawing.Point(535, 116);
            this.LblTxtCodigo.Name = "LblTxtCodigo";
            this.LblTxtCodigo.Size = new System.Drawing.Size(90, 25);
            this.LblTxtCodigo.TabIndex = 75;
            this.LblTxtCodigo.Text = "Codigo";
            // 
            // LblTctPrecio
            // 
            this.LblTctPrecio.AutoSize = true;
            this.LblTctPrecio.Font = new System.Drawing.Font("Colonna MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTctPrecio.Location = new System.Drawing.Point(632, 348);
            this.LblTctPrecio.Name = "LblTctPrecio";
            this.LblTctPrecio.Size = new System.Drawing.Size(148, 25);
            this.LblTctPrecio.TabIndex = 76;
            this.LblTctPrecio.Text = "Precio Total";
            // 
            // LblPrecioT
            // 
            this.LblPrecioT.AutoSize = true;
            this.LblPrecioT.Font = new System.Drawing.Font("Colonna MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioT.Location = new System.Drawing.Point(821, 348);
            this.LblPrecioT.Name = "LblPrecioT";
            this.LblPrecioT.Size = new System.Drawing.Size(148, 25);
            this.LblPrecioT.TabIndex = 77;
            this.LblPrecioT.Text = "Precio Total";
            // 
            // FrmIngresarMatS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 518);
            this.Controls.Add(this.LblPrecioT);
            this.Controls.Add(this.LblTctPrecio);
            this.Controls.Add(this.LblTxtCodigo);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.BttGuardar);
            this.Controls.Add(this.TxtBxPrecio);
            this.Controls.Add(this.LblTxtPrecio);
            this.Controls.Add(this.TxtBxCantidad);
            this.Controls.Add(this.LblTxtCantidad);
            this.Controls.Add(this.LblTxtFechaIngreso);
            this.Controls.Add(this.TxtBxModelo);
            this.Controls.Add(this.LblTxtModelo);
            this.Controls.Add(this.TxtBxMarca);
            this.Controls.Add(this.LblTxtMarca);
            this.Controls.Add(this.CmBxEstado);
            this.Controls.Add(this.TxtBxNombre);
            this.Controls.Add(this.LblTxtNombre);
            this.Controls.Add(this.LblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIngresarMatS";
            this.Text = "FrmIngresarMatS";
            ((System.ComponentModel.ISupportInitialize)(this.matSeg1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mazimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Button BttGuardar;
        private System.Windows.Forms.TextBox TxtBxPrecio;
        private System.Windows.Forms.Label LblTxtPrecio;
        private System.Windows.Forms.TextBox TxtBxCantidad;
        private System.Windows.Forms.Label LblTxtCantidad;
        private System.Windows.Forms.Label LblTxtFechaIngreso;
        private System.Windows.Forms.TextBox TxtBxModelo;
        private System.Windows.Forms.Label LblTxtModelo;
        private System.Windows.Forms.TextBox TxtBxMarca;
        private System.Windows.Forms.Label LblTxtMarca;
        private System.Windows.Forms.ComboBox CmBxEstado;
        private System.Windows.Forms.TextBox TxtBxNombre;
        private System.Windows.Forms.Label LblTxtNombre;
        private System.Windows.Forms.Label LblTitulo;
        private MatSeg matSeg1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.PictureBox Mazimizar;
        private System.Windows.Forms.PictureBox Cerrar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.Label LblCodigo;
        public System.Windows.Forms.Label LblTxtCodigo;
        private System.Windows.Forms.Label LblTctPrecio;
        private System.Windows.Forms.Label LblPrecioT;
    }
}