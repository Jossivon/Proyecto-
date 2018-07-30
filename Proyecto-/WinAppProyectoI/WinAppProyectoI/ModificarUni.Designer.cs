namespace WinAppProyectoI
{
    partial class ModificarUni
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
            this.dates = new System.Windows.Forms.DateTimePicker();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.CbxTalla = new System.Windows.Forms.ComboBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.TxtBxCodigo = new System.Windows.Forms.TextBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtbPrecioUnitario = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbQuienRecibe = new System.Windows.Forms.TextBox();
            this.txtbCantidad = new System.Windows.Forms.TextBox();
            this.CbxEstado = new System.Windows.Forms.ComboBox();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblQuienRecibe = new System.Windows.Forms.Label();
            this.lblFechaSalida = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dates
            // 
            this.dates.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dates.Location = new System.Drawing.Point(613, 268);
            this.dates.Name = "dates";
            this.dates.Size = new System.Drawing.Size(98, 20);
            this.dates.TabIndex = 70;
            this.dates.Value = new System.DateTime(2018, 7, 28, 11, 14, 33, 0);
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(630, 219);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(100, 20);
            this.date.TabIndex = 69;
            // 
            // CbxTalla
            // 
            this.CbxTalla.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxTalla.FormattingEnabled = true;
            this.CbxTalla.Location = new System.Drawing.Point(448, 101);
            this.CbxTalla.Name = "CbxTalla";
            this.CbxTalla.Size = new System.Drawing.Size(110, 29);
            this.CbxTalla.TabIndex = 68;
            this.CbxTalla.Text = "Talla";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Colonna MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(230, 37);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(320, 28);
            this.LblTitulo.TabIndex = 67;
            this.LblTitulo.Text = "MODIFICAR UNIFORMES";
            // 
            // TxtBxCodigo
            // 
            this.TxtBxCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxCodigo.Font = new System.Drawing.Font("Colonna MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxCodigo.Location = new System.Drawing.Point(233, 106);
            this.TxtBxCodigo.Name = "TxtBxCodigo";
            this.TxtBxCodigo.Size = new System.Drawing.Size(100, 30);
            this.TxtBxCodigo.TabIndex = 66;
            // 
            // LblCodigo
            // 
            this.LblCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.BackColor = System.Drawing.Color.White;
            this.LblCodigo.Font = new System.Drawing.Font("Colonna MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(45, 111);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(96, 25);
            this.LblCodigo.TabIndex = 65;
            this.LblCodigo.Text = "Código:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Colonna MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(523, 374);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 34);
            this.btnGuardar.TabIndex = 63;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtbPrecioUnitario
            // 
            this.txtbPrecioUnitario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtbPrecioUnitario.Font = new System.Drawing.Font("Colonna MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPrecioUnitario.Location = new System.Drawing.Point(233, 213);
            this.txtbPrecioUnitario.Name = "txtbPrecioUnitario";
            this.txtbPrecioUnitario.Size = new System.Drawing.Size(100, 30);
            this.txtbPrecioUnitario.TabIndex = 62;
            // 
            // txtbNombre
            // 
            this.txtbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtbNombre.Font = new System.Drawing.Font("Colonna MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNombre.Location = new System.Drawing.Point(540, 164);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(100, 30);
            this.txtbNombre.TabIndex = 61;
            // 
            // txtbQuienRecibe
            // 
            this.txtbQuienRecibe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtbQuienRecibe.Font = new System.Drawing.Font("Colonna MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbQuienRecibe.Location = new System.Drawing.Point(233, 161);
            this.txtbQuienRecibe.Name = "txtbQuienRecibe";
            this.txtbQuienRecibe.Size = new System.Drawing.Size(100, 30);
            this.txtbQuienRecibe.TabIndex = 60;
            // 
            // txtbCantidad
            // 
            this.txtbCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtbCantidad.Font = new System.Drawing.Font("Colonna MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbCantidad.Location = new System.Drawing.Point(233, 268);
            this.txtbCantidad.Name = "txtbCantidad";
            this.txtbCantidad.Size = new System.Drawing.Size(100, 30);
            this.txtbCantidad.TabIndex = 59;
            // 
            // CbxEstado
            // 
            this.CbxEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CbxEstado.Font = new System.Drawing.Font("Colonna MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxEstado.FormattingEnabled = true;
            this.CbxEstado.Items.AddRange(new object[] {
            "Nuevo",
            "Usado",
            "Dañado"});
            this.CbxEstado.Location = new System.Drawing.Point(623, 100);
            this.CbxEstado.Name = "CbxEstado";
            this.CbxEstado.Size = new System.Drawing.Size(106, 30);
            this.CbxEstado.TabIndex = 58;
            this.CbxEstado.Text = "Estado";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.BackColor = System.Drawing.Color.White;
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Colonna MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnitario.Location = new System.Drawing.Point(25, 218);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(185, 25);
            this.lblPrecioUnitario.TabIndex = 57;
            this.lblPrecioUnitario.Text = "Precio unitario:";
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.White;
            this.lblTipo.Font = new System.Drawing.Font("Colonna MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(426, 169);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(108, 25);
            this.lblTipo.TabIndex = 56;
            this.lblTipo.Text = "Nombre:";
            // 
            // lblQuienRecibe
            // 
            this.lblQuienRecibe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblQuienRecibe.AutoSize = true;
            this.lblQuienRecibe.BackColor = System.Drawing.Color.White;
            this.lblQuienRecibe.Font = new System.Drawing.Font("Colonna MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuienRecibe.Location = new System.Drawing.Point(25, 166);
            this.lblQuienRecibe.Name = "lblQuienRecibe";
            this.lblQuienRecibe.Size = new System.Drawing.Size(158, 25);
            this.lblQuienRecibe.TabIndex = 55;
            this.lblQuienRecibe.Text = "Quien recibe:";
            // 
            // lblFechaSalida
            // 
            this.lblFechaSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblFechaSalida.AutoSize = true;
            this.lblFechaSalida.BackColor = System.Drawing.Color.White;
            this.lblFechaSalida.Font = new System.Drawing.Font("Colonna MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaSalida.Location = new System.Drawing.Point(426, 268);
            this.lblFechaSalida.Name = "lblFechaSalida";
            this.lblFechaSalida.Size = new System.Drawing.Size(181, 25);
            this.lblFechaSalida.TabIndex = 54;
            this.lblFechaSalida.Text = "Fecha de salida:";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.BackColor = System.Drawing.Color.White;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Colonna MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIngreso.Location = new System.Drawing.Point(422, 219);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(202, 25);
            this.lblFechaIngreso.TabIndex = 53;
            this.lblFechaIngreso.Text = "Fecha de ingreso:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.White;
            this.lblCantidad.Font = new System.Drawing.Font("Colonna MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(68, 268);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(115, 25);
            this.lblCantidad.TabIndex = 52;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Colonna MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(646, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 34);
            this.button1.TabIndex = 71;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModificarUni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dates);
            this.Controls.Add(this.date);
            this.Controls.Add(this.CbxTalla);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.TxtBxCodigo);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtbPrecioUnitario);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.txtbQuienRecibe);
            this.Controls.Add(this.txtbCantidad);
            this.Controls.Add(this.CbxEstado);
            this.Controls.Add(this.lblPrecioUnitario);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblQuienRecibe);
            this.Controls.Add(this.lblFechaSalida);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.lblCantidad);
            this.Name = "ModificarUni";
            this.Text = "ModificarUni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dates;
        public System.Windows.Forms.DateTimePicker date;
        public System.Windows.Forms.ComboBox CbxTalla;
        private System.Windows.Forms.Label LblTitulo;
        public System.Windows.Forms.TextBox TxtBxCodigo;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.TextBox txtbPrecioUnitario;
        public System.Windows.Forms.TextBox txtbNombre;
        public System.Windows.Forms.TextBox txtbQuienRecibe;
        public System.Windows.Forms.TextBox txtbCantidad;
        public System.Windows.Forms.ComboBox CbxEstado;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblQuienRecibe;
        private System.Windows.Forms.Label lblFechaSalida;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button button1;
    }
}