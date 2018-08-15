namespace WinAppProyectoI
{
    partial class EmpBuscar
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
            this.TxtBxCedula = new System.Windows.Forms.TextBox();
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
            this.BttBuscar.Font = new System.Drawing.Font("Colonna MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttBuscar.Location = new System.Drawing.Point(373, 227);
            this.BttBuscar.Name = "BttBuscar";
            this.BttBuscar.Size = new System.Drawing.Size(100, 53);
            this.BttBuscar.TabIndex = 45;
            this.BttBuscar.Text = "Buscar";
            this.BttBuscar.UseVisualStyleBackColor = false;
            this.BttBuscar.Click += new System.EventHandler(this.BttBuscar_Click);
            // 
            // TxtBxCedula
            // 
            this.TxtBxCedula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxCedula.Font = new System.Drawing.Font("Colonna MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxCedula.Location = new System.Drawing.Point(373, 143);
            this.TxtBxCedula.Name = "TxtBxCedula";
            this.TxtBxCedula.Size = new System.Drawing.Size(116, 30);
            this.TxtBxCedula.TabIndex = 44;
            this.TxtBxCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxCedul_KeyPress);
            // 
            // LblTxtCodigo
            // 
            this.LblTxtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTxtCodigo.AutoSize = true;
            this.LblTxtCodigo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LblTxtCodigo.Font = new System.Drawing.Font("Colonna MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxtCodigo.Location = new System.Drawing.Point(269, 151);
            this.LblTxtCodigo.Name = "LblTxtCodigo";
            this.LblTxtCodigo.Size = new System.Drawing.Size(75, 22);
            this.LblTxtCodigo.TabIndex = 43;
            this.LblTxtCodigo.Text = "Cédula";
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Colonna MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(278, 52);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(263, 28);
            this.LblTitulo.TabIndex = 42;
            this.LblTitulo.Text = "BUSCAR EMPLEADO";
            // 
            // matSeg1
            // 
            this.matSeg1.DataSetName = "MatSeg";
            this.matSeg1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EmpBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BttBuscar);
            this.Controls.Add(this.TxtBxCedula);
            this.Controls.Add(this.LblTxtCodigo);
            this.Controls.Add(this.LblTitulo);
            this.Name = "EmpBuscar";
            this.Text = "EmpBuscar";
            ((System.ComponentModel.ISupportInitialize)(this.matSeg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BttBuscar;
        private System.Windows.Forms.TextBox TxtBxCedula;
        private System.Windows.Forms.Label LblTxtCodigo;
        private System.Windows.Forms.Label LblTitulo;
        private MatSeg matSeg1;
    }
}