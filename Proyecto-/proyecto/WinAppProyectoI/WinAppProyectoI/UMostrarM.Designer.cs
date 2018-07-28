namespace WinAppProyectoI
{
    partial class UMostrarM
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
            this.TxtBxPrecio = new System.Windows.Forms.TextBox();
            this.LblTxtPrecio = new System.Windows.Forms.Label();
            this.TxtBxCantidad = new System.Windows.Forms.TextBox();
            this.LblTxtCantidad = new System.Windows.Forms.Label();
            this.TxtBxNombreUsuario = new System.Windows.Forms.TextBox();
            this.LblTxtNomreUsuario = new System.Windows.Forms.Label();
            this.LblTxtFechaSalida = new System.Windows.Forms.Label();
            this.LblTxtFechaIngreso = new System.Windows.Forms.Label();
            this.TxtBxCodigo = new System.Windows.Forms.TextBox();
            this.LblTxtCodigo = new System.Windows.Forms.Label();
            this.TxtBxNombre = new System.Windows.Forms.TextBox();
            this.LblTxtNombre = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.bttCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateS
            // 
            this.DateS.CalendarFont = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateS.Font = new System.Drawing.Font("Colonna MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateS.Location = new System.Drawing.Point(221, 246);
            this.DateS.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.DateS.Name = "DateS";
            this.DateS.Size = new System.Drawing.Size(117, 24);
            this.DateS.TabIndex = 110;
            // 
            // Date
            // 
            this.Date.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(221, 191);
            this.Date.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(115, 28);
            this.Date.TabIndex = 109;
            // 
            // BttModificar
            // 
            this.BttModificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BttModificar.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttModificar.Location = new System.Drawing.Point(286, 346);
            this.BttModificar.Name = "BttModificar";
            this.BttModificar.Size = new System.Drawing.Size(133, 57);
            this.BttModificar.TabIndex = 108;
            this.BttModificar.Text = "MODIFICAR";
            this.BttModificar.UseVisualStyleBackColor = true;
            this.BttModificar.Click += new System.EventHandler(this.BttGuardar_Click);
            // 
            // TxtBxPrecio
            // 
            this.TxtBxPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxPrecio.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxPrecio.Location = new System.Drawing.Point(704, 242);
            this.TxtBxPrecio.Name = "TxtBxPrecio";
            this.TxtBxPrecio.Size = new System.Drawing.Size(116, 28);
            this.TxtBxPrecio.TabIndex = 107;
            // 
            // LblTxtPrecio
            // 
            this.LblTxtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtPrecio.AutoSize = true;
            this.LblTxtPrecio.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtPrecio.Location = new System.Drawing.Point(536, 242);
            this.LblTxtPrecio.Name = "LblTxtPrecio";
            this.LblTxtPrecio.Size = new System.Drawing.Size(148, 21);
            this.LblTxtPrecio.TabIndex = 106;
            this.LblTxtPrecio.Text = "Precio Unitario";
            // 
            // TxtBxCantidad
            // 
            this.TxtBxCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxCantidad.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxCantidad.Location = new System.Drawing.Point(704, 190);
            this.TxtBxCantidad.Name = "TxtBxCantidad";
            this.TxtBxCantidad.Size = new System.Drawing.Size(116, 28);
            this.TxtBxCantidad.TabIndex = 105;
            // 
            // LblTxtCantidad
            // 
            this.LblTxtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtCantidad.AutoSize = true;
            this.LblTxtCantidad.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtCantidad.Location = new System.Drawing.Point(597, 190);
            this.LblTxtCantidad.Name = "LblTxtCantidad";
            this.LblTxtCantidad.Size = new System.Drawing.Size(87, 21);
            this.LblTxtCantidad.TabIndex = 104;
            this.LblTxtCantidad.Text = "Cantidad";
            // 
            // TxtBxNombreUsuario
            // 
            this.TxtBxNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxNombreUsuario.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxNombreUsuario.Location = new System.Drawing.Point(704, 146);
            this.TxtBxNombreUsuario.Name = "TxtBxNombreUsuario";
            this.TxtBxNombreUsuario.Size = new System.Drawing.Size(116, 28);
            this.TxtBxNombreUsuario.TabIndex = 103;
            // 
            // LblTxtNomreUsuario
            // 
            this.LblTxtNomreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtNomreUsuario.AutoSize = true;
            this.LblTxtNomreUsuario.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtNomreUsuario.Location = new System.Drawing.Point(458, 146);
            this.LblTxtNomreUsuario.Name = "LblTxtNomreUsuario";
            this.LblTxtNomreUsuario.Size = new System.Drawing.Size(226, 21);
            this.LblTxtNomreUsuario.TabIndex = 102;
            this.LblTxtNomreUsuario.Text = "Nombre del responsable";
            // 
            // LblTxtFechaSalida
            // 
            this.LblTxtFechaSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtFechaSalida.AutoSize = true;
            this.LblTxtFechaSalida.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtFechaSalida.Location = new System.Drawing.Point(71, 249);
            this.LblTxtFechaSalida.Name = "LblTxtFechaSalida";
            this.LblTxtFechaSalida.Size = new System.Drawing.Size(144, 21);
            this.LblTxtFechaSalida.TabIndex = 101;
            this.LblTxtFechaSalida.Text = "Fecha de Salida";
            // 
            // LblTxtFechaIngreso
            // 
            this.LblTxtFechaIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtFechaIngreso.AutoSize = true;
            this.LblTxtFechaIngreso.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtFechaIngreso.Location = new System.Drawing.Point(53, 197);
            this.LblTxtFechaIngreso.Name = "LblTxtFechaIngreso";
            this.LblTxtFechaIngreso.Size = new System.Drawing.Size(162, 21);
            this.LblTxtFechaIngreso.TabIndex = 100;
            this.LblTxtFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // TxtBxCodigo
            // 
            this.TxtBxCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxCodigo.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxCodigo.Location = new System.Drawing.Point(220, 142);
            this.TxtBxCodigo.Name = "TxtBxCodigo";
            this.TxtBxCodigo.Size = new System.Drawing.Size(116, 28);
            this.TxtBxCodigo.TabIndex = 99;
            // 
            // LblTxtCodigo
            // 
            this.LblTxtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtCodigo.AutoSize = true;
            this.LblTxtCodigo.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtCodigo.Location = new System.Drawing.Point(127, 146);
            this.LblTxtCodigo.Name = "LblTxtCodigo";
            this.LblTxtCodigo.Size = new System.Drawing.Size(73, 21);
            this.LblTxtCodigo.TabIndex = 98;
            this.LblTxtCodigo.Text = "Código";
            // 
            // TxtBxNombre
            // 
            this.TxtBxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxNombre.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxNombre.Location = new System.Drawing.Point(462, 86);
            this.TxtBxNombre.Name = "TxtBxNombre";
            this.TxtBxNombre.Size = new System.Drawing.Size(116, 28);
            this.TxtBxNombre.TabIndex = 97;
            // 
            // LblTxtNombre
            // 
            this.LblTxtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtNombre.AutoSize = true;
            this.LblTxtNombre.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblTxtNombre.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtNombre.ForeColor = System.Drawing.Color.White;
            this.LblTxtNombre.Location = new System.Drawing.Point(154, 89);
            this.LblTxtNombre.Name = "LblTxtNombre";
            this.LblTxtNombre.Size = new System.Drawing.Size(288, 21);
            this.LblTxtNombre.TabIndex = 96;
            this.LblTxtNombre.Text = "Nombre del material de oficina";
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Colonna MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(268, 35);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(336, 28);
            this.LblTitulo.TabIndex = 95;
            this.LblTitulo.Text = "MATERIALES DE OFICINA";
            // 
            // bttCancelar
            // 
            this.bttCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttCancelar.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCancelar.Location = new System.Drawing.Point(462, 346);
            this.bttCancelar.Name = "bttCancelar";
            this.bttCancelar.Size = new System.Drawing.Size(133, 57);
            this.bttCancelar.TabIndex = 111;
            this.bttCancelar.Text = "CANCELAR";
            this.bttCancelar.UseVisualStyleBackColor = true;
            this.bttCancelar.Click += new System.EventHandler(this.bttCancelar_Click);
            // 
            // UMostrarM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 473);
            this.Controls.Add(this.bttCancelar);
            this.Controls.Add(this.DateS);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.BttModificar);
            this.Controls.Add(this.TxtBxPrecio);
            this.Controls.Add(this.LblTxtPrecio);
            this.Controls.Add(this.TxtBxCantidad);
            this.Controls.Add(this.LblTxtCantidad);
            this.Controls.Add(this.TxtBxNombreUsuario);
            this.Controls.Add(this.LblTxtNomreUsuario);
            this.Controls.Add(this.LblTxtFechaSalida);
            this.Controls.Add(this.LblTxtFechaIngreso);
            this.Controls.Add(this.TxtBxCodigo);
            this.Controls.Add(this.LblTxtCodigo);
            this.Controls.Add(this.TxtBxNombre);
            this.Controls.Add(this.LblTxtNombre);
            this.Controls.Add(this.LblTitulo);
            this.Name = "UMostrarM";
            this.Text = "UMostrarM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker DateS;
        public System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Button BttModificar;
        public System.Windows.Forms.TextBox TxtBxPrecio;
        private System.Windows.Forms.Label LblTxtPrecio;
        public System.Windows.Forms.TextBox TxtBxCantidad;
        private System.Windows.Forms.Label LblTxtCantidad;
        public System.Windows.Forms.TextBox TxtBxNombreUsuario;
        private System.Windows.Forms.Label LblTxtNomreUsuario;
        private System.Windows.Forms.Label LblTxtFechaSalida;
        private System.Windows.Forms.Label LblTxtFechaIngreso;
        public System.Windows.Forms.TextBox TxtBxCodigo;
        private System.Windows.Forms.Label LblTxtCodigo;
        public System.Windows.Forms.TextBox TxtBxNombre;
        private System.Windows.Forms.Label LblTxtNombre;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button bttCancelar;
    }
}