﻿namespace WinAppProyectoI
{
    partial class MostrarUni
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
            this.LblCodigo = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblQuienRecibe = new System.Windows.Forms.Label();
            this.lblFechaSalida = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.LblCodigoU = new System.Windows.Forms.Label();
            this.LblNombreR = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.LblCan = new System.Windows.Forms.Label();
            this.LblTala = new System.Windows.Forms.Label();
            this.LblEstado = new System.Windows.Forms.Label();
            this.LblNombreU = new System.Windows.Forms.Label();
            this.FechaI = new System.Windows.Forms.Label();
            this.FechaS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblCodigo
            // 
            this.LblCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.BackColor = System.Drawing.Color.White;
            this.LblCodigo.Font = new System.Drawing.Font("Colonna MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(42, 120);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(96, 25);
            this.LblCodigo.TabIndex = 65;
            this.LblCodigo.Text = "Código:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Colonna MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(598, 389);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 34);
            this.btnGuardar.TabIndex = 63;
            this.btnGuardar.Text = "Aceptar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.BackColor = System.Drawing.Color.White;
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Colonna MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnitario.Location = new System.Drawing.Point(22, 227);
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
            this.lblTipo.Location = new System.Drawing.Point(423, 178);
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
            this.lblQuienRecibe.Location = new System.Drawing.Point(22, 175);
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
            this.lblFechaSalida.Location = new System.Drawing.Point(423, 277);
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
            this.lblFechaIngreso.Location = new System.Drawing.Point(419, 228);
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
            this.lblCantidad.Location = new System.Drawing.Point(65, 277);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(115, 25);
            this.lblCantidad.TabIndex = 52;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // LblCodigoU
            // 
            this.LblCodigoU.AutoSize = true;
            this.LblCodigoU.Location = new System.Drawing.Point(240, 120);
            this.LblCodigoU.Name = "LblCodigoU";
            this.LblCodigoU.Size = new System.Drawing.Size(35, 13);
            this.LblCodigoU.TabIndex = 70;
            this.LblCodigoU.Text = "label1";
            // 
            // LblNombreR
            // 
            this.LblNombreR.AutoSize = true;
            this.LblNombreR.Location = new System.Drawing.Point(240, 180);
            this.LblNombreR.Name = "LblNombreR";
            this.LblNombreR.Size = new System.Drawing.Size(35, 13);
            this.LblNombreR.TabIndex = 71;
            this.LblNombreR.Text = "label1";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Location = new System.Drawing.Point(240, 233);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(35, 13);
            this.LblPrecio.TabIndex = 72;
            this.LblPrecio.Text = "label1";
            // 
            // LblCan
            // 
            this.LblCan.AutoSize = true;
            this.LblCan.Location = new System.Drawing.Point(240, 283);
            this.LblCan.Name = "LblCan";
            this.LblCan.Size = new System.Drawing.Size(35, 13);
            this.LblCan.TabIndex = 73;
            this.LblCan.Text = "label1";
            // 
            // LblTala
            // 
            this.LblTala.AutoSize = true;
            this.LblTala.Location = new System.Drawing.Point(496, 116);
            this.LblTala.Name = "LblTala";
            this.LblTala.Size = new System.Drawing.Size(35, 13);
            this.LblTala.TabIndex = 74;
            this.LblTala.Text = "label1";
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Location = new System.Drawing.Point(602, 116);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(35, 13);
            this.LblEstado.TabIndex = 75;
            this.LblEstado.Text = "label1";
            // 
            // LblNombreU
            // 
            this.LblNombreU.AutoSize = true;
            this.LblNombreU.Location = new System.Drawing.Point(602, 187);
            this.LblNombreU.Name = "LblNombreU";
            this.LblNombreU.Size = new System.Drawing.Size(35, 13);
            this.LblNombreU.TabIndex = 76;
            this.LblNombreU.Text = "label1";
            // 
            // FechaI
            // 
            this.FechaI.AutoSize = true;
            this.FechaI.Location = new System.Drawing.Point(629, 233);
            this.FechaI.Name = "FechaI";
            this.FechaI.Size = new System.Drawing.Size(35, 13);
            this.FechaI.TabIndex = 77;
            this.FechaI.Text = "label1";
            // 
            // FechaS
            // 
            this.FechaS.AutoSize = true;
            this.FechaS.Location = new System.Drawing.Point(620, 283);
            this.FechaS.Name = "FechaS";
            this.FechaS.Size = new System.Drawing.Size(35, 13);
            this.FechaS.TabIndex = 78;
            this.FechaS.Text = "label1";
            // 
            // MostrarUni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FechaS);
            this.Controls.Add(this.FechaI);
            this.Controls.Add(this.LblNombreU);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.LblTala);
            this.Controls.Add(this.LblCan);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.LblNombreR);
            this.Controls.Add(this.LblCodigoU);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblPrecioUnitario);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblQuienRecibe);
            this.Controls.Add(this.lblFechaSalida);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.lblCantidad);
            this.Name = "MostrarUni";
            this.Text = "MostrarUt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblQuienRecibe;
        private System.Windows.Forms.Label lblFechaSalida;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblCantidad;
        public System.Windows.Forms.Label LblCodigoU;
        public System.Windows.Forms.Label LblNombreR;
        public System.Windows.Forms.Label LblPrecio;
        public System.Windows.Forms.Label LblCan;
        public System.Windows.Forms.Label LblTala;
        public System.Windows.Forms.Label LblEstado;
        public System.Windows.Forms.Label LblNombreU;
        public System.Windows.Forms.Label FechaI;
        public System.Windows.Forms.Label FechaS;
    }
}