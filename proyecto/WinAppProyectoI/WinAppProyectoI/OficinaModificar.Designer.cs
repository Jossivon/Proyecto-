namespace WinAppProyectoI
{
    partial class OficinaModificar
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
            this.LblPrecioT = new System.Windows.Forms.Label();
            this.LblTxtPrecioT = new System.Windows.Forms.Label();
            this.LblCod = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.BttGuardar = new System.Windows.Forms.Button();
            this.TxtBxPrecio = new System.Windows.Forms.TextBox();
            this.LblTxtPrecio = new System.Windows.Forms.Label();
            this.TxtBxCantidad = new System.Windows.Forms.TextBox();
            this.LblTxtCantidad = new System.Windows.Forms.Label();
            this.LblTxtFechaIngreso = new System.Windows.Forms.Label();
            this.LblTxtCodigo = new System.Windows.Forms.Label();
            this.TxtBxNombre = new System.Windows.Forms.TextBox();
            this.LblTxtNombre = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.dates = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTxtNombreR = new System.Windows.Forms.Label();
            this.TxtBxNombreR = new System.Windows.Forms.TextBox();
            this.matSeg1 = new WinAppProyectoI.MatSeg();
            this.label2 = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.matSeg1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblPrecioT
            // 
            this.LblPrecioT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblPrecioT.AutoSize = true;
            this.LblPrecioT.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioT.Location = new System.Drawing.Point(686, 293);
            this.LblPrecioT.Name = "LblPrecioT";
            this.LblPrecioT.Size = new System.Drawing.Size(148, 21);
            this.LblPrecioT.TabIndex = 110;
            this.LblPrecioT.Text = "Precio Unitario";
            // 
            // LblTxtPrecioT
            // 
            this.LblTxtPrecioT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtPrecioT.AutoSize = true;
            this.LblTxtPrecioT.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtPrecioT.Location = new System.Drawing.Point(542, 293);
            this.LblTxtPrecioT.Name = "LblTxtPrecioT";
            this.LblTxtPrecioT.Size = new System.Drawing.Size(121, 21);
            this.LblTxtPrecioT.TabIndex = 109;
            this.LblTxtPrecioT.Text = "Precio Total";
            // 
            // LblCod
            // 
            this.LblCod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblCod.AutoSize = true;
            this.LblCod.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCod.Location = new System.Drawing.Point(434, 70);
            this.LblCod.Name = "LblCod";
            this.LblCod.Size = new System.Drawing.Size(73, 21);
            this.LblCod.TabIndex = 108;
            this.LblCod.Text = "Código";
            // 
            // Date
            // 
            this.Date.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(304, 191);
            this.Date.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.Date.MinDate = new System.DateTime(2000, 8, 15, 0, 0, 0, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(115, 28);
            this.Date.TabIndex = 107;
            this.Date.Value = new System.DateTime(2018, 8, 15, 0, 0, 0, 0);
            this.Date.ValueChanged += new System.EventHandler(this.Date_ValueChanged);
            // 
            // BttGuardar
            // 
            this.BttGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BttGuardar.BackColor = System.Drawing.Color.DarkCyan;
            this.BttGuardar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BttGuardar.FlatAppearance.BorderSize = 3;
            this.BttGuardar.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttGuardar.Location = new System.Drawing.Point(411, 373);
            this.BttGuardar.Name = "BttGuardar";
            this.BttGuardar.Size = new System.Drawing.Size(133, 57);
            this.BttGuardar.TabIndex = 106;
            this.BttGuardar.Text = "Guardar";
            this.BttGuardar.UseVisualStyleBackColor = false;
            this.BttGuardar.Click += new System.EventHandler(this.BttGuardar_Click);
            // 
            // TxtBxPrecio
            // 
            this.TxtBxPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxPrecio.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxPrecio.Location = new System.Drawing.Point(690, 253);
            this.TxtBxPrecio.Name = "TxtBxPrecio";
            this.TxtBxPrecio.Size = new System.Drawing.Size(116, 28);
            this.TxtBxPrecio.TabIndex = 105;
            this.TxtBxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxPrecio_KeyPress);
            // 
            // LblTxtPrecio
            // 
            this.LblTxtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtPrecio.AutoSize = true;
            this.LblTxtPrecio.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtPrecio.Location = new System.Drawing.Point(515, 253);
            this.LblTxtPrecio.Name = "LblTxtPrecio";
            this.LblTxtPrecio.Size = new System.Drawing.Size(148, 21);
            this.LblTxtPrecio.TabIndex = 104;
            this.LblTxtPrecio.Text = "Precio Unitario";
            // 
            // TxtBxCantidad
            // 
            this.TxtBxCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxCantidad.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxCantidad.Location = new System.Drawing.Point(304, 286);
            this.TxtBxCantidad.Name = "TxtBxCantidad";
            this.TxtBxCantidad.Size = new System.Drawing.Size(116, 28);
            this.TxtBxCantidad.TabIndex = 103;
            this.TxtBxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxCantidad_KeyPress);
            // 
            // LblTxtCantidad
            // 
            this.LblTxtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtCantidad.AutoSize = true;
            this.LblTxtCantidad.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtCantidad.Location = new System.Drawing.Point(199, 289);
            this.LblTxtCantidad.Name = "LblTxtCantidad";
            this.LblTxtCantidad.Size = new System.Drawing.Size(87, 21);
            this.LblTxtCantidad.TabIndex = 102;
            this.LblTxtCantidad.Text = "Cantidad";
            // 
            // LblTxtFechaIngreso
            // 
            this.LblTxtFechaIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtFechaIngreso.AutoSize = true;
            this.LblTxtFechaIngreso.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtFechaIngreso.Location = new System.Drawing.Point(124, 191);
            this.LblTxtFechaIngreso.Name = "LblTxtFechaIngreso";
            this.LblTxtFechaIngreso.Size = new System.Drawing.Size(162, 21);
            this.LblTxtFechaIngreso.TabIndex = 101;
            this.LblTxtFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // LblTxtCodigo
            // 
            this.LblTxtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtCodigo.AutoSize = true;
            this.LblTxtCodigo.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtCodigo.Location = new System.Drawing.Point(336, 70);
            this.LblTxtCodigo.Name = "LblTxtCodigo";
            this.LblTxtCodigo.Size = new System.Drawing.Size(73, 21);
            this.LblTxtCodigo.TabIndex = 100;
            this.LblTxtCodigo.Text = "Código";
            // 
            // TxtBxNombre
            // 
            this.TxtBxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxNombre.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxNombre.Location = new System.Drawing.Point(304, 137);
            this.TxtBxNombre.Name = "TxtBxNombre";
            this.TxtBxNombre.Size = new System.Drawing.Size(116, 28);
            this.TxtBxNombre.TabIndex = 99;
            this.TxtBxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxNombre_KeyPress);
            // 
            // LblTxtNombre
            // 
            this.LblTxtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtNombre.AutoSize = true;
            this.LblTxtNombre.BackColor = System.Drawing.Color.Transparent;
            this.LblTxtNombre.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtNombre.ForeColor = System.Drawing.Color.Black;
            this.LblTxtNombre.Location = new System.Drawing.Point(-2, 137);
            this.LblTxtNombre.Name = "LblTxtNombre";
            this.LblTxtNombre.Size = new System.Drawing.Size(288, 21);
            this.LblTxtNombre.TabIndex = 98;
            this.LblTxtNombre.Text = "Nombre del material de oficina";
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Colonna MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(267, 19);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(336, 28);
            this.LblTitulo.TabIndex = 97;
            this.LblTitulo.Text = "MATERIALES DE OFICINA";
            // 
            // dates
            // 
            this.dates.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dates.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dates.Location = new System.Drawing.Point(304, 244);
            this.dates.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.dates.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dates.Name = "dates";
            this.dates.Size = new System.Drawing.Size(115, 28);
            this.dates.TabIndex = 112;
            this.dates.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 21);
            this.label1.TabIndex = 111;
            this.label1.Text = "Fecha de Salida";
            // 
            // LblTxtNombreR
            // 
            this.LblTxtNombreR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtNombreR.AutoSize = true;
            this.LblTxtNombreR.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtNombreR.Location = new System.Drawing.Point(130, 35);
            this.LblTxtNombreR.Name = "LblTxtNombreR";
            this.LblTxtNombreR.Size = new System.Drawing.Size(75, 21);
            this.LblTxtNombreR.TabIndex = 113;
            this.LblTxtNombreR.Text = "Cédula ";
            // 
            // TxtBxNombreR
            // 
            this.TxtBxNombreR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxNombreR.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxNombreR.Location = new System.Drawing.Point(234, 28);
            this.TxtBxNombreR.Name = "TxtBxNombreR";
            this.TxtBxNombreR.Size = new System.Drawing.Size(116, 28);
            this.TxtBxNombreR.TabIndex = 114;
            this.TxtBxNombreR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxNombreR_KeyPress);
            // 
            // matSeg1
            // 
            this.matSeg1.DataSetName = "MatSeg";
            this.matSeg1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 115;
            this.label2.Text = "Nombre:";
            // 
            // LblApellido
            // 
            this.LblApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellido.Location = new System.Drawing.Point(266, 73);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(88, 21);
            this.LblApellido.TabIndex = 116;
            this.LblApellido.Text = "Nombre:";
            // 
            // LblNombre
            // 
            this.LblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(121, 73);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(88, 21);
            this.LblNombre.TabIndex = 117;
            this.LblNombre.Text = "Nombre:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblNombre);
            this.groupBox1.Controls.Add(this.LblApellido);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtBxNombreR);
            this.groupBox1.Controls.Add(this.LblTxtNombreR);
            this.groupBox1.Font = new System.Drawing.Font("Colonna MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(458, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 115);
            this.groupBox1.TabIndex = 118;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Personal Responsable";
            // 
            // OficinaModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(873, 466);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dates);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblPrecioT);
            this.Controls.Add(this.LblTxtPrecioT);
            this.Controls.Add(this.LblCod);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.BttGuardar);
            this.Controls.Add(this.TxtBxPrecio);
            this.Controls.Add(this.LblTxtPrecio);
            this.Controls.Add(this.TxtBxCantidad);
            this.Controls.Add(this.LblTxtCantidad);
            this.Controls.Add(this.LblTxtFechaIngreso);
            this.Controls.Add(this.LblTxtCodigo);
            this.Controls.Add(this.TxtBxNombre);
            this.Controls.Add(this.LblTxtNombre);
            this.Controls.Add(this.LblTitulo);
            this.Name = "OficinaModificar";
            this.Text = "OficinaModificar";
            ((System.ComponentModel.ISupportInitialize)(this.matSeg1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LblPrecioT;
        public System.Windows.Forms.Label LblTxtPrecioT;
        public System.Windows.Forms.Label LblCod;
        public System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Button BttGuardar;
        public System.Windows.Forms.TextBox TxtBxPrecio;
        private System.Windows.Forms.Label LblTxtPrecio;
        public System.Windows.Forms.TextBox TxtBxCantidad;
        private System.Windows.Forms.Label LblTxtCantidad;
        private System.Windows.Forms.Label LblTxtFechaIngreso;
        private System.Windows.Forms.Label LblTxtCodigo;
        public System.Windows.Forms.TextBox TxtBxNombre;
        private System.Windows.Forms.Label LblTxtNombre;
        private System.Windows.Forms.Label LblTitulo;
        public System.Windows.Forms.DateTimePicker dates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTxtNombreR;
        public  System.Windows.Forms.TextBox TxtBxNombreR;
        private MatSeg matSeg1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label LblApellido;
        public System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}