namespace WinAppProyectoI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PnlIzq = new System.Windows.Forms.Panel();
            this.Ayuda = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BttUtil = new System.Windows.Forms.Button();
            this.BttUniformes = new System.Windows.Forms.Button();
            this.BttMatSeg = new System.Windows.Forms.Button();
            this.PnlTitulo = new System.Windows.Forms.Panel();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Menu = new System.Windows.Forms.PictureBox();
            this.PnlIzq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ayuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlIzq
            // 
            this.PnlIzq.Controls.Add(this.Ayuda);
            this.PnlIzq.Controls.Add(this.pictureBox1);
            this.PnlIzq.Controls.Add(this.BttUtil);
            this.PnlIzq.Controls.Add(this.BttUniformes);
            this.PnlIzq.Controls.Add(this.BttMatSeg);
            this.PnlIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlIzq.Location = new System.Drawing.Point(0, 0);
            this.PnlIzq.Name = "PnlIzq";
            this.PnlIzq.Size = new System.Drawing.Size(305, 536);
            this.PnlIzq.TabIndex = 0;
            // 
            // Ayuda
            // 
            this.Ayuda.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Ayuda.Location = new System.Drawing.Point(241, 457);
            this.Ayuda.Name = "Ayuda";
            this.Ayuda.Size = new System.Drawing.Size(48, 39);
            this.Ayuda.TabIndex = 2;
            this.Ayuda.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 85);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // BttUtil
            // 
            this.BttUtil.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BttUtil.Image = ((System.Drawing.Image)(resources.GetObject("BttUtil.Image")));
            this.BttUtil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BttUtil.Location = new System.Drawing.Point(12, 297);
            this.BttUtil.Name = "BttUtil";
            this.BttUtil.Size = new System.Drawing.Size(277, 44);
            this.BttUtil.TabIndex = 4;
            this.BttUtil.Text = "Materiales de oficina";
            this.BttUtil.UseVisualStyleBackColor = true;
            this.BttUtil.Click += new System.EventHandler(this.BttUtil_Click);
            // 
            // BttUniformes
            // 
            this.BttUniformes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BttUniformes.Image = ((System.Drawing.Image)(resources.GetObject("BttUniformes.Image")));
            this.BttUniformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BttUniformes.Location = new System.Drawing.Point(12, 357);
            this.BttUniformes.Name = "BttUniformes";
            this.BttUniformes.Size = new System.Drawing.Size(277, 45);
            this.BttUniformes.TabIndex = 3;
            this.BttUniformes.Text = "Uniformes";
            this.BttUniformes.UseVisualStyleBackColor = true;
            this.BttUniformes.Click += new System.EventHandler(this.BttUniformes_Click);
            // 
            // BttMatSeg
            // 
            this.BttMatSeg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BttMatSeg.Image = ((System.Drawing.Image)(resources.GetObject("BttMatSeg.Image")));
            this.BttMatSeg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BttMatSeg.Location = new System.Drawing.Point(12, 230);
            this.BttMatSeg.Name = "BttMatSeg";
            this.BttMatSeg.Size = new System.Drawing.Size(277, 44);
            this.BttMatSeg.TabIndex = 2;
            this.BttMatSeg.Text = "Materiales de Seguridad";
            this.BttMatSeg.UseVisualStyleBackColor = true;
            this.BttMatSeg.Click += new System.EventHandler(this.BttMatSeg_Click);
            // 
            // PnlTitulo
            // 
            this.PnlTitulo.Controls.Add(this.Restaurar);
            this.PnlTitulo.Controls.Add(this.Maximizar);
            this.PnlTitulo.Controls.Add(this.Cerrar);
            this.PnlTitulo.Controls.Add(this.Minimizar);
            this.PnlTitulo.Controls.Add(this.Menu);
            this.PnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitulo.Location = new System.Drawing.Point(305, 0);
            this.PnlTitulo.Name = "PnlTitulo";
            this.PnlTitulo.Size = new System.Drawing.Size(598, 40);
            this.PnlTitulo.TabIndex = 1;
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(539, 7);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(25, 25);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restaurar.TabIndex = 7;
            this.Restaurar.TabStop = false;
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.Location = new System.Drawing.Point(539, 7);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(25, 25);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizar.TabIndex = 8;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.Location = new System.Drawing.Point(570, 7);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(25, 25);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cerrar.TabIndex = 6;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(508, 7);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(25, 25);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 3;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Menu
            // 
            this.Menu.Image = ((System.Drawing.Image)(resources.GetObject("Menu.Image")));
            this.Menu.Location = new System.Drawing.Point(6, 3);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(35, 35);
            this.Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Menu.TabIndex = 2;
            this.Menu.TabStop = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 536);
            this.Controls.Add(this.PnlTitulo);
            this.Controls.Add(this.PnlIzq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.PnlIzq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ayuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlIzq;
        private System.Windows.Forms.Panel PnlTitulo;
        private System.Windows.Forms.PictureBox Menu;
        private System.Windows.Forms.PictureBox Cerrar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.Button BttUtil;
        private System.Windows.Forms.Button BttUniformes;
        private System.Windows.Forms.Button BttMatSeg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Ayuda;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.PictureBox Maximizar;
    }
}

