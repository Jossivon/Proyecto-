namespace WinAppProyectoI
{
    partial class MatSegCodigo
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
            this.LblTxtTitulo = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.BttAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblTxtTitulo
            // 
            this.LblTxtTitulo.AutoSize = true;
            this.LblTxtTitulo.Font = new System.Drawing.Font("Colonna MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtTitulo.Location = new System.Drawing.Point(33, 43);
            this.LblTxtTitulo.Name = "LblTxtTitulo";
            this.LblTxtTitulo.Size = new System.Drawing.Size(356, 25);
            this.LblTxtTitulo.TabIndex = 0;
            this.LblTxtTitulo.Text = "SU MATERIAL DE SEGURIDAD";
            this.LblTxtTitulo.Click += new System.EventHandler(this.LblTxtTitulo_Click);
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Colonna MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(223, 163);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(0, 25);
            this.LblCodigo.TabIndex = 1;
            // 
            // BttAceptar
            // 
            this.BttAceptar.Font = new System.Drawing.Font("Colonna MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttAceptar.Location = new System.Drawing.Point(152, 239);
            this.BttAceptar.Name = "BttAceptar";
            this.BttAceptar.Size = new System.Drawing.Size(128, 45);
            this.BttAceptar.TabIndex = 2;
            this.BttAceptar.Text = "ACEPTAR";
            this.BttAceptar.UseVisualStyleBackColor = true;
            this.BttAceptar.Click += new System.EventHandler(this.BttAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Colonna MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "SE HA GUARDADO CON EL CÓDIGO";
            // 
            // MatSegCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(440, 296);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BttAceptar);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.LblTxtTitulo);
            this.Name = "MatSegCodigo";
            this.Text = "Codigo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTxtTitulo;
        public System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Button BttAceptar;
        private System.Windows.Forms.Label label1;
    }
}