namespace WinAppProyectoI
{
    partial class ModificarMatS
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
            this.DateS = new System.Windows.Forms.DateTimePicker();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.BttModificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBxPrecio = new System.Windows.Forms.TextBox();
            this.LblTxtPrecio = new System.Windows.Forms.Label();
            this.TxtBxCantidad = new System.Windows.Forms.TextBox();
            this.LblTxtCantidad = new System.Windows.Forms.Label();
            this.TxtBxNombreUsuario = new System.Windows.Forms.TextBox();
            this.LblTxtNomreUsuario = new System.Windows.Forms.Label();
            this.LblTxtFechaSalida = new System.Windows.Forms.Label();
            this.LblTxtFechaIngreso = new System.Windows.Forms.Label();
            this.TxtBxModelo = new System.Windows.Forms.TextBox();
            this.LblTxtModelo = new System.Windows.Forms.Label();
            this.TxtBxMarca = new System.Windows.Forms.TextBox();
            this.LblTxtMarca = new System.Windows.Forms.Label();
            this.TxtBxCodigo = new System.Windows.Forms.TextBox();
            this.LblTxtCodigo = new System.Windows.Forms.Label();
            this.CmBxEstado = new System.Windows.Forms.ComboBox();
            this.TxtBxNombre = new System.Windows.Forms.TextBox();
            this.LblTxtNombre = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblTxtPrecioT = new System.Windows.Forms.Label();
            this.LblPrecioT = new System.Windows.Forms.Label();
            this.BttCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateS
            // 
            this.DateS.CalendarFont = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateS.Font = new System.Drawing.Font("Colonna MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateS.Location = new System.Drawing.Point(843, 100);
            this.DateS.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.DateS.Name = "DateS";
            this.DateS.Size = new System.Drawing.Size(117, 24);
            this.DateS.TabIndex = 94;
            this.DateS.ValueChanged += new System.EventHandler(this.DateS_ValueChanged);
            // 
            // Date
            // 
            this.Date.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(359, 281);
            this.Date.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(115, 28);
            this.Date.TabIndex = 93;
            this.Date.ValueChanged += new System.EventHandler(this.Date_ValueChanged);
            // 
            // BttModificar
            // 
            this.BttModificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BttModificar.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttModificar.Location = new System.Drawing.Point(359, 409);
            this.BttModificar.Name = "BttModificar";
            this.BttModificar.Size = new System.Drawing.Size(133, 57);
            this.BttModificar.TabIndex = 92;
            this.BttModificar.Text = "Modificar";
            this.BttModificar.UseVisualStyleBackColor = true;
            this.BttModificar.Click += new System.EventHandler(this.BttModificar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(738, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 91;
            this.label1.Text = "Estado";
            // 
            // TxtBxPrecio
            // 
            this.TxtBxPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxPrecio.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxPrecio.Location = new System.Drawing.Point(843, 296);
            this.TxtBxPrecio.Name = "TxtBxPrecio";
            this.TxtBxPrecio.Size = new System.Drawing.Size(115, 28);
            this.TxtBxPrecio.TabIndex = 90;
            this.TxtBxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxPrecio_KeyPress);
            // 
            // LblTxtPrecio
            // 
            this.LblTxtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtPrecio.AutoSize = true;
            this.LblTxtPrecio.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtPrecio.Location = new System.Drawing.Point(652, 296);
            this.LblTxtPrecio.Name = "LblTxtPrecio";
            this.LblTxtPrecio.Size = new System.Drawing.Size(148, 21);
            this.LblTxtPrecio.TabIndex = 89;
            this.LblTxtPrecio.Text = "Precio Unitario";
            // 
            // TxtBxCantidad
            // 
            this.TxtBxCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxCantidad.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxCantidad.Location = new System.Drawing.Point(842, 235);
            this.TxtBxCantidad.Name = "TxtBxCantidad";
            this.TxtBxCantidad.Size = new System.Drawing.Size(116, 28);
            this.TxtBxCantidad.TabIndex = 88;
            this.TxtBxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxCantidad_KeyPress);
            // 
            // LblTxtCantidad
            // 
            this.LblTxtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtCantidad.AutoSize = true;
            this.LblTxtCantidad.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtCantidad.Location = new System.Drawing.Point(717, 244);
            this.LblTxtCantidad.Name = "LblTxtCantidad";
            this.LblTxtCantidad.Size = new System.Drawing.Size(87, 21);
            this.LblTxtCantidad.TabIndex = 87;
            this.LblTxtCantidad.Text = "Cantidad";
            // 
            // TxtBxNombreUsuario
            // 
            this.TxtBxNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxNombreUsuario.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxNombreUsuario.Location = new System.Drawing.Point(843, 191);
            this.TxtBxNombreUsuario.Name = "TxtBxNombreUsuario";
            this.TxtBxNombreUsuario.Size = new System.Drawing.Size(116, 28);
            this.TxtBxNombreUsuario.TabIndex = 86;
            this.TxtBxNombreUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxNombreUsuario_KeyPress);
            // 
            // LblTxtNomreUsuario
            // 
            this.LblTxtNomreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtNomreUsuario.AutoSize = true;
            this.LblTxtNomreUsuario.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtNomreUsuario.Location = new System.Drawing.Point(574, 198);
            this.LblTxtNomreUsuario.Name = "LblTxtNomreUsuario";
            this.LblTxtNomreUsuario.Size = new System.Drawing.Size(226, 21);
            this.LblTxtNomreUsuario.TabIndex = 85;
            this.LblTxtNomreUsuario.Text = "Nombre del responsable";
            // 
            // LblTxtFechaSalida
            // 
            this.LblTxtFechaSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtFechaSalida.AutoSize = true;
            this.LblTxtFechaSalida.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtFechaSalida.Location = new System.Drawing.Point(662, 100);
            this.LblTxtFechaSalida.Name = "LblTxtFechaSalida";
            this.LblTxtFechaSalida.Size = new System.Drawing.Size(144, 21);
            this.LblTxtFechaSalida.TabIndex = 84;
            this.LblTxtFechaSalida.Text = "Fecha de Salida";
            // 
            // LblTxtFechaIngreso
            // 
            this.LblTxtFechaIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtFechaIngreso.AutoSize = true;
            this.LblTxtFechaIngreso.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtFechaIngreso.Location = new System.Drawing.Point(164, 287);
            this.LblTxtFechaIngreso.Name = "LblTxtFechaIngreso";
            this.LblTxtFechaIngreso.Size = new System.Drawing.Size(162, 21);
            this.LblTxtFechaIngreso.TabIndex = 83;
            this.LblTxtFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // TxtBxModelo
            // 
            this.TxtBxModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxModelo.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxModelo.Location = new System.Drawing.Point(359, 230);
            this.TxtBxModelo.Name = "TxtBxModelo";
            this.TxtBxModelo.Size = new System.Drawing.Size(116, 28);
            this.TxtBxModelo.TabIndex = 82;
            this.TxtBxModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxModelo_KeyPress);
            // 
            // LblTxtModelo
            // 
            this.LblTxtModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtModelo.AutoSize = true;
            this.LblTxtModelo.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtModelo.Location = new System.Drawing.Point(246, 238);
            this.LblTxtModelo.Name = "LblTxtModelo";
            this.LblTxtModelo.Size = new System.Drawing.Size(75, 21);
            this.LblTxtModelo.TabIndex = 81;
            this.LblTxtModelo.Text = "Modelo";
            // 
            // TxtBxMarca
            // 
            this.TxtBxMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxMarca.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxMarca.Location = new System.Drawing.Point(359, 190);
            this.TxtBxMarca.Name = "TxtBxMarca";
            this.TxtBxMarca.Size = new System.Drawing.Size(116, 28);
            this.TxtBxMarca.TabIndex = 80;
            this.TxtBxMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxMarca_KeyPress);
            // 
            // LblTxtMarca
            // 
            this.LblTxtMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtMarca.AutoSize = true;
            this.LblTxtMarca.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtMarca.Location = new System.Drawing.Point(261, 198);
            this.LblTxtMarca.Name = "LblTxtMarca";
            this.LblTxtMarca.Size = new System.Drawing.Size(63, 21);
            this.LblTxtMarca.TabIndex = 79;
            this.LblTxtMarca.Text = "Marca";
            // 
            // TxtBxCodigo
            // 
            this.TxtBxCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxCodigo.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxCodigo.Location = new System.Drawing.Point(359, 145);
            this.TxtBxCodigo.Name = "TxtBxCodigo";
            this.TxtBxCodigo.Size = new System.Drawing.Size(116, 28);
            this.TxtBxCodigo.TabIndex = 78;
            this.TxtBxCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxCodigo_KeyPress);
            // 
            // LblTxtCodigo
            // 
            this.LblTxtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtCodigo.AutoSize = true;
            this.LblTxtCodigo.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtCodigo.Location = new System.Drawing.Point(253, 150);
            this.LblTxtCodigo.Name = "LblTxtCodigo";
            this.LblTxtCodigo.Size = new System.Drawing.Size(73, 21);
            this.LblTxtCodigo.TabIndex = 77;
            this.LblTxtCodigo.Text = "Código";
            // 
            // CmBxEstado
            // 
            this.CmBxEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CmBxEstado.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmBxEstado.FormattingEnabled = true;
            this.CmBxEstado.Items.AddRange(new object[] {
            "Bueno",
            "Malo"});
            this.CmBxEstado.Location = new System.Drawing.Point(843, 146);
            this.CmBxEstado.Name = "CmBxEstado";
            this.CmBxEstado.Size = new System.Drawing.Size(116, 29);
            this.CmBxEstado.TabIndex = 76;
            this.CmBxEstado.Validated += new System.EventHandler(this.CmBxEstado_Validated);
            // 
            // TxtBxNombre
            // 
            this.TxtBxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxNombre.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxNombre.Location = new System.Drawing.Point(359, 99);
            this.TxtBxNombre.Name = "TxtBxNombre";
            this.TxtBxNombre.Size = new System.Drawing.Size(116, 28);
            this.TxtBxNombre.TabIndex = 75;
            this.TxtBxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxNombre_KeyPress);
            // 
            // LblTxtNombre
            // 
            this.LblTxtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtNombre.AutoSize = true;
            this.LblTxtNombre.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblTxtNombre.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtNombre.ForeColor = System.Drawing.Color.White;
            this.LblTxtNombre.Location = new System.Drawing.Point(11, 99);
            this.LblTxtNombre.Name = "LblTxtNombre";
            this.LblTxtNombre.Size = new System.Drawing.Size(315, 21);
            this.LblTxtNombre.TabIndex = 74;
            this.LblTxtNombre.Text = "Nombre del material de seguridad";
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Colonna MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(404, 28);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(380, 28);
            this.LblTitulo.TabIndex = 73;
            this.LblTitulo.Text = "MATERIALES DE SEGURIDAD";
            // 
            // LblTxtPrecioT
            // 
            this.LblTxtPrecioT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtPrecioT.AutoSize = true;
            this.LblTxtPrecioT.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtPrecioT.Location = new System.Drawing.Point(343, 346);
            this.LblTxtPrecioT.Name = "LblTxtPrecioT";
            this.LblTxtPrecioT.Size = new System.Drawing.Size(121, 21);
            this.LblTxtPrecioT.TabIndex = 95;
            this.LblTxtPrecioT.Text = "Precio Total";
            // 
            // LblPrecioT
            // 
            this.LblPrecioT.AutoSize = true;
            this.LblPrecioT.Font = new System.Drawing.Font("Colonna MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioT.Location = new System.Drawing.Point(512, 349);
            this.LblPrecioT.Name = "LblPrecioT";
            this.LblPrecioT.Size = new System.Drawing.Size(54, 17);
            this.LblPrecioT.TabIndex = 96;
            this.LblPrecioT.Text = "label3";
            // 
            // BttCancelar
            // 
            this.BttCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BttCancelar.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttCancelar.Location = new System.Drawing.Point(549, 409);
            this.BttCancelar.Name = "BttCancelar";
            this.BttCancelar.Size = new System.Drawing.Size(133, 57);
            this.BttCancelar.TabIndex = 97;
            this.BttCancelar.Text = "Cancelar";
            this.BttCancelar.UseVisualStyleBackColor = true;
            this.BttCancelar.Click += new System.EventHandler(this.BttCancelar_Click);
            // 
            // ModificarMatS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 492);
            this.Controls.Add(this.BttCancelar);
            this.Controls.Add(this.LblPrecioT);
            this.Controls.Add(this.LblTxtPrecioT);
            this.Controls.Add(this.DateS);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.BttModificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBxPrecio);
            this.Controls.Add(this.LblTxtPrecio);
            this.Controls.Add(this.TxtBxCantidad);
            this.Controls.Add(this.LblTxtCantidad);
            this.Controls.Add(this.TxtBxNombreUsuario);
            this.Controls.Add(this.LblTxtNomreUsuario);
            this.Controls.Add(this.LblTxtFechaSalida);
            this.Controls.Add(this.LblTxtFechaIngreso);
            this.Controls.Add(this.TxtBxModelo);
            this.Controls.Add(this.LblTxtModelo);
            this.Controls.Add(this.TxtBxMarca);
            this.Controls.Add(this.LblTxtMarca);
            this.Controls.Add(this.TxtBxCodigo);
            this.Controls.Add(this.LblTxtCodigo);
            this.Controls.Add(this.CmBxEstado);
            this.Controls.Add(this.TxtBxNombre);
            this.Controls.Add(this.LblTxtNombre);
            this.Controls.Add(this.LblTitulo);
            this.Name = "ModificarMatS";
            this.Text = "ModificarMatS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker DateS;
        public System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Button BttModificar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtBxPrecio;
        private System.Windows.Forms.Label LblTxtPrecio;
        public System.Windows.Forms.TextBox TxtBxCantidad;
        private System.Windows.Forms.Label LblTxtCantidad;
        public System.Windows.Forms.TextBox TxtBxNombreUsuario;
        private System.Windows.Forms.Label LblTxtNomreUsuario;
        private System.Windows.Forms.Label LblTxtFechaSalida;
        private System.Windows.Forms.Label LblTxtFechaIngreso;
        public System.Windows.Forms.TextBox TxtBxModelo;
        private System.Windows.Forms.Label LblTxtModelo;
        public System.Windows.Forms.TextBox TxtBxMarca;
        private System.Windows.Forms.Label LblTxtMarca;
        public System.Windows.Forms.TextBox TxtBxCodigo;
        private System.Windows.Forms.Label LblTxtCodigo;
        public System.Windows.Forms.ComboBox CmBxEstado;
        public System.Windows.Forms.TextBox TxtBxNombre;
        private System.Windows.Forms.Label LblTxtNombre;
        private System.Windows.Forms.Label LblTitulo;
        public System.Windows.Forms.Label LblTxtPrecioT;
        private System.Windows.Forms.Label LblPrecioT;
        private System.Windows.Forms.Button BttCancelar;
    }
}