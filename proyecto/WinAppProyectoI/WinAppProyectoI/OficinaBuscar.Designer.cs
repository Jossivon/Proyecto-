namespace WinAppProyectoI
{
    partial class OficinaBuscar
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
            this.BttBuscar = new System.Windows.Forms.Button();
            this.TxtBxCodigo = new System.Windows.Forms.TextBox();
            this.LblTxtCodigo = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.matSeg1 = new WinAppProyectoI.MatSeg();
            ((System.ComponentModel.ISupportInitialize)(this.matSeg1)).BeginInit();
            this.SuspendLayout();
            // 
            // BttBuscar
            // 
            this.BttBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BttBuscar.BackColor = System.Drawing.Color.DarkCyan;
            this.BttBuscar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BttBuscar.FlatAppearance.BorderSize = 3;
            this.BttBuscar.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttBuscar.Location = new System.Drawing.Point(340, 254);
            this.BttBuscar.Name = "BttBuscar";
            this.BttBuscar.Size = new System.Drawing.Size(100, 53);
            this.BttBuscar.TabIndex = 45;
            this.BttBuscar.Text = "Buscar";
            this.BttBuscar.UseVisualStyleBackColor = false;
            this.BttBuscar.Click += new System.EventHandler(this.BttBuscar_Click);
            // 
            // TxtBxCodigo
            // 
            this.TxtBxCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxCodigo.Font = new System.Drawing.Font("Colonna MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxCodigo.Location = new System.Drawing.Point(340, 170);
            this.TxtBxCodigo.Name = "TxtBxCodigo";
            this.TxtBxCodigo.Size = new System.Drawing.Size(116, 30);
            this.TxtBxCodigo.TabIndex = 44;
            this.TxtBxCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxCodigo_KeyPress);
            // 
            // LblTxtCodigo
            // 
            this.LblTxtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtCodigo.AutoSize = true;
            this.LblTxtCodigo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LblTxtCodigo.Font = new System.Drawing.Font("Colonna MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtCodigo.Location = new System.Drawing.Point(236, 178);
            this.LblTxtCodigo.Name = "LblTxtCodigo";
            this.LblTxtCodigo.Size = new System.Drawing.Size(79, 22);
            this.LblTxtCodigo.TabIndex = 43;
            this.LblTxtCodigo.Text = "Código";
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Colonna MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(191, 83);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(420, 28);
            this.LblTitulo.TabIndex = 42;
            this.LblTitulo.Text = "BUSCAR MATERIAL DE OFICINA";
            // 
            // matSeg1
            // 
            this.matSeg1.DataSetName = "MatSeg";
            this.matSeg1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OficinaBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BttBuscar);
            this.Controls.Add(this.TxtBxCodigo);
            this.Controls.Add(this.LblTxtCodigo);
            this.Controls.Add(this.LblTitulo);
            this.Name = "OficinaBuscar";
            this.Text = "BuscarUt";
            ((System.ComponentModel.ISupportInitialize)(this.matSeg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BttBuscar;
        private System.Windows.Forms.TextBox TxtBxCodigo;
        private System.Windows.Forms.Label LblTxtCodigo;
        private System.Windows.Forms.Label LblTitulo;
        private MatSeg matSeg1;
    }
}