namespace WinAppProyectoI
{
    partial class OficinaCodigo
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
            this.label1 = new System.Windows.Forms.Label();
            this.BttAceptar = new System.Windows.Forms.Button();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblTxtTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Colonna MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "SE HA GUARDADO CON EL CÓDIGO";
            // 
            // BttAceptar
            // 
            this.BttAceptar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BttAceptar.Font = new System.Drawing.Font("Colonna MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttAceptar.Location = new System.Drawing.Point(147, 238);
            this.BttAceptar.Name = "BttAceptar";
            this.BttAceptar.Size = new System.Drawing.Size(128, 49);
            this.BttAceptar.TabIndex = 6;
            this.BttAceptar.Text = "ACEPTAR";
            this.BttAceptar.UseVisualStyleBackColor = true;
            this.BttAceptar.Click += new System.EventHandler(this.BttAceptar_Click);
            // 
            // LblCodigo
            // 
            this.LblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Colonna MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(218, 162);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(0, 25);
            this.LblCodigo.TabIndex = 5;
            // 
            // LblTxtTitulo
            // 
            this.LblTxtTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblTxtTitulo.AutoSize = true;
            this.LblTxtTitulo.Font = new System.Drawing.Font("Colonna MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtTitulo.Location = new System.Drawing.Point(28, 42);
            this.LblTxtTitulo.Name = "LblTxtTitulo";
            this.LblTxtTitulo.Size = new System.Drawing.Size(316, 25);
            this.LblTxtTitulo.TabIndex = 4;
            this.LblTxtTitulo.Text = "EL MATERIAL DE OFICINA";
            // 
            // OficinaCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(436, 344);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BttAceptar);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.LblTxtTitulo);
            this.Name = "OficinaCodigo";
            this.Text = "OficinaCodigo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BttAceptar;
        public System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label LblTxtTitulo;
    }
}