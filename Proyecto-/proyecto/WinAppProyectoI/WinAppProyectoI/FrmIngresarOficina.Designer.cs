namespace WinAppProyectoI
{
    partial class FrmIngresarOficina
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Mazimizar = new System.Windows.Forms.PictureBox();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.DateS = new System.Windows.Forms.DateTimePicker();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.BttGuardar = new System.Windows.Forms.Button();
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
            this.matSeg1 = new WinAppProyectoI.MatSeg();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mazimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matSeg1)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(936, 40);
            this.panel1.TabIndex = 0;
            // 
            // Restaurar
            // 
            this.Restaurar.Location = new System.Drawing.Point(809, 7);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(25, 25);
            this.Restaurar.TabIndex = 16;
            this.Restaurar.TabStop = false;
            // 
            // Mazimizar
            // 
            this.Mazimizar.Location = new System.Drawing.Point(840, 7);
            this.Mazimizar.Name = "Mazimizar";
            this.Mazimizar.Size = new System.Drawing.Size(25, 25);
            this.Mazimizar.TabIndex = 17;
            this.Mazimizar.TabStop = false;
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(871, 7);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(25, 25);
            this.Cerrar.TabIndex = 18;
            this.Cerrar.TabStop = false;
            // 
            // Minimizar
            // 
            this.Minimizar.Location = new System.Drawing.Point(778, 7);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(25, 25);
            this.Minimizar.TabIndex = 15;
            this.Minimizar.TabStop = false;
            // 
            // DateS
            // 
            this.DateS.CalendarFont = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateS.Font = new System.Drawing.Font("Colonna MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateS.Location = new System.Drawing.Point(274, 274);
            this.DateS.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.DateS.Name = "DateS";
            this.DateS.Size = new System.Drawing.Size(117, 24);
            this.DateS.TabIndex = 94;
            this.DateS.ValueChanged += new System.EventHandler(this.Date2_ValueChanged);
            // 
            // Date
            // 
            this.Date.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(275, 219);
            this.Date.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(115, 28);
            this.Date.TabIndex = 93;
            this.Date.ValueChanged += new System.EventHandler(this.Date_ValueChanged_1);
            // 
            // BttGuardar
            // 
            this.BttGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BttGuardar.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttGuardar.Location = new System.Drawing.Point(464, 386);
            this.BttGuardar.Name = "BttGuardar";
            this.BttGuardar.Size = new System.Drawing.Size(133, 57);
            this.BttGuardar.TabIndex = 91;
            this.BttGuardar.Text = "Guardar";
            this.BttGuardar.UseVisualStyleBackColor = true;
            this.BttGuardar.Click += new System.EventHandler(this.BttGuardar_Click);
            // 
            // TxtBxPrecio
            // 
            this.TxtBxPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxPrecio.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxPrecio.Location = new System.Drawing.Point(736, 270);
            this.TxtBxPrecio.Name = "TxtBxPrecio";
            this.TxtBxPrecio.Size = new System.Drawing.Size(116, 28);
            this.TxtBxPrecio.TabIndex = 89;
            this.TxtBxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxPrecio_KeyPress);
            // 
            // LblTxtPrecio
            // 
            this.LblTxtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtPrecio.AutoSize = true;
            this.LblTxtPrecio.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtPrecio.Location = new System.Drawing.Point(568, 270);
            this.LblTxtPrecio.Name = "LblTxtPrecio";
            this.LblTxtPrecio.Size = new System.Drawing.Size(148, 21);
            this.LblTxtPrecio.TabIndex = 88;
            this.LblTxtPrecio.Text = "Precio Unitario";
            // 
            // TxtBxCantidad
            // 
            this.TxtBxCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxCantidad.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxCantidad.Location = new System.Drawing.Point(736, 218);
            this.TxtBxCantidad.Name = "TxtBxCantidad";
            this.TxtBxCantidad.Size = new System.Drawing.Size(116, 28);
            this.TxtBxCantidad.TabIndex = 87;
            this.TxtBxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxCantidad_KeyPress);
            // 
            // LblTxtCantidad
            // 
            this.LblTxtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtCantidad.AutoSize = true;
            this.LblTxtCantidad.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtCantidad.Location = new System.Drawing.Point(629, 218);
            this.LblTxtCantidad.Name = "LblTxtCantidad";
            this.LblTxtCantidad.Size = new System.Drawing.Size(87, 21);
            this.LblTxtCantidad.TabIndex = 86;
            this.LblTxtCantidad.Text = "Cantidad";
            // 
            // TxtBxNombreUsuario
            // 
            this.TxtBxNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxNombreUsuario.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxNombreUsuario.Location = new System.Drawing.Point(736, 174);
            this.TxtBxNombreUsuario.Name = "TxtBxNombreUsuario";
            this.TxtBxNombreUsuario.Size = new System.Drawing.Size(116, 28);
            this.TxtBxNombreUsuario.TabIndex = 85;
            this.TxtBxNombreUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxNombreUsuario_KeyPress);
            // 
            // LblTxtNomreUsuario
            // 
            this.LblTxtNomreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtNomreUsuario.AutoSize = true;
            this.LblTxtNomreUsuario.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtNomreUsuario.Location = new System.Drawing.Point(490, 174);
            this.LblTxtNomreUsuario.Name = "LblTxtNomreUsuario";
            this.LblTxtNomreUsuario.Size = new System.Drawing.Size(226, 21);
            this.LblTxtNomreUsuario.TabIndex = 84;
            this.LblTxtNomreUsuario.Text = "Nombre del responsable";
            // 
            // LblTxtFechaSalida
            // 
            this.LblTxtFechaSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtFechaSalida.AutoSize = true;
            this.LblTxtFechaSalida.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtFechaSalida.Location = new System.Drawing.Point(103, 277);
            this.LblTxtFechaSalida.Name = "LblTxtFechaSalida";
            this.LblTxtFechaSalida.Size = new System.Drawing.Size(144, 21);
            this.LblTxtFechaSalida.TabIndex = 83;
            this.LblTxtFechaSalida.Text = "Fecha de Salida";
            // 
            // LblTxtFechaIngreso
            // 
            this.LblTxtFechaIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtFechaIngreso.AutoSize = true;
            this.LblTxtFechaIngreso.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtFechaIngreso.Location = new System.Drawing.Point(85, 225);
            this.LblTxtFechaIngreso.Name = "LblTxtFechaIngreso";
            this.LblTxtFechaIngreso.Size = new System.Drawing.Size(162, 21);
            this.LblTxtFechaIngreso.TabIndex = 82;
            this.LblTxtFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // TxtBxCodigo
            // 
            this.TxtBxCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxCodigo.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxCodigo.Location = new System.Drawing.Point(280, 166);
            this.TxtBxCodigo.Name = "TxtBxCodigo";
            this.TxtBxCodigo.Size = new System.Drawing.Size(116, 28);
            this.TxtBxCodigo.TabIndex = 77;
            this.TxtBxCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxCodigo_KeyPress);
            // 
            // LblTxtCodigo
            // 
            this.LblTxtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtCodigo.AutoSize = true;
            this.LblTxtCodigo.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtCodigo.Location = new System.Drawing.Point(174, 174);
            this.LblTxtCodigo.Name = "LblTxtCodigo";
            this.LblTxtCodigo.Size = new System.Drawing.Size(73, 21);
            this.LblTxtCodigo.TabIndex = 76;
            this.LblTxtCodigo.Text = "Código";
            // 
            // TxtBxNombre
            // 
            this.TxtBxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxNombre.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxNombre.Location = new System.Drawing.Point(494, 114);
            this.TxtBxNombre.Name = "TxtBxNombre";
            this.TxtBxNombre.Size = new System.Drawing.Size(116, 28);
            this.TxtBxNombre.TabIndex = 74;
            this.TxtBxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxNombre_KeyPress);
            // 
            // LblTxtNombre
            // 
            this.LblTxtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtNombre.AutoSize = true;
            this.LblTxtNombre.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblTxtNombre.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtNombre.ForeColor = System.Drawing.Color.White;
            this.LblTxtNombre.Location = new System.Drawing.Point(186, 117);
            this.LblTxtNombre.Name = "LblTxtNombre";
            this.LblTxtNombre.Size = new System.Drawing.Size(288, 21);
            this.LblTxtNombre.TabIndex = 73;
            this.LblTxtNombre.Text = "Nombre del material de oficina";
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Colonna MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(365, 63);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(336, 28);
            this.LblTitulo.TabIndex = 72;
            this.LblTitulo.Text = "MATERIALES DE OFICINA";
            // 
            // matSeg1
            // 
            this.matSeg1.DataSetName = "MatSeg";
            this.matSeg1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmIngresarOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 503);
            this.Controls.Add(this.DateS);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.BttGuardar);
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
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIngresarOficina";
            this.Text = "FrmIngresarOficina";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mazimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matSeg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.PictureBox Mazimizar;
        private System.Windows.Forms.PictureBox Cerrar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.DateTimePicker DateS;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Button BttGuardar;
        private System.Windows.Forms.TextBox TxtBxPrecio;
        private System.Windows.Forms.Label LblTxtPrecio;
        private System.Windows.Forms.TextBox TxtBxCantidad;
        private System.Windows.Forms.Label LblTxtCantidad;
        private System.Windows.Forms.TextBox TxtBxNombreUsuario;
        private System.Windows.Forms.Label LblTxtNomreUsuario;
        private System.Windows.Forms.Label LblTxtFechaSalida;
        private System.Windows.Forms.Label LblTxtFechaIngreso;
        private System.Windows.Forms.TextBox TxtBxCodigo;
        private System.Windows.Forms.Label LblTxtCodigo;
        private System.Windows.Forms.TextBox TxtBxNombre;
        private System.Windows.Forms.Label LblTxtNombre;
        private System.Windows.Forms.Label LblTitulo;
        private MatSeg matSeg1;
    }
}