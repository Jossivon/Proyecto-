﻿namespace WinAppProyectoI
{
    partial class FrmUniforme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUniforme));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BttResporte2 = new System.Windows.Forms.Button();
            this.BttReporte1 = new System.Windows.Forms.Button();
            this.BttEliminar = new System.Windows.Forms.Button();
            this.BttModificar = new System.Windows.Forms.Button();
            this.BttBuscar = new System.Windows.Forms.Button();
            this.BttIngresar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Menu = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.BttResporte2);
            this.panel1.Controls.Add(this.BttReporte1);
            this.panel1.Controls.Add(this.BttEliminar);
            this.panel1.Controls.Add(this.BttModificar);
            this.panel1.Controls.Add(this.BttBuscar);
            this.panel1.Controls.Add(this.BttIngresar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 529);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button3.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::WinAppProyectoI.Properties.Resources.ver;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(4, 97);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(245, 45);
            this.button3.TabIndex = 11;
            this.button3.Text = "Mostrar datos ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::WinAppProyectoI.Properties.Resources.lista1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(5, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 45);
            this.button2.TabIndex = 15;
            this.button2.Text = "Reporte Cantidad";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::WinAppProyectoI.Properties.Resources.lista;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(4, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 45);
            this.button1.TabIndex = 14;
            this.button1.Text = "Reporte Estado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BttResporte2
            // 
            this.BttResporte2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttResporte2.Image = global::WinAppProyectoI.Properties.Resources.lista;
            this.BttResporte2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BttResporte2.Location = new System.Drawing.Point(5, 350);
            this.BttResporte2.Name = "BttResporte2";
            this.BttResporte2.Size = new System.Drawing.Size(245, 45);
            this.BttResporte2.TabIndex = 9;
            this.BttResporte2.Text = "Reporte Fecha";
            this.BttResporte2.UseVisualStyleBackColor = true;
            this.BttResporte2.Click += new System.EventHandler(this.BttResporte2_Click);
            // 
            // BttReporte1
            // 
            this.BttReporte1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttReporte1.Image = global::WinAppProyectoI.Properties.Resources.sl;
            this.BttReporte1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BttReporte1.Location = new System.Drawing.Point(5, 299);
            this.BttReporte1.Name = "BttReporte1";
            this.BttReporte1.Size = new System.Drawing.Size(245, 45);
            this.BttReporte1.TabIndex = 10;
            this.BttReporte1.Text = "Salida";
            this.BttReporte1.UseVisualStyleBackColor = true;
            this.BttReporte1.Click += new System.EventHandler(this.BttReporte1_Click);
            // 
            // BttEliminar
            // 
            this.BttEliminar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttEliminar.Image = global::WinAppProyectoI.Properties.Resources.eli;
            this.BttEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BttEliminar.Location = new System.Drawing.Point(5, 248);
            this.BttEliminar.Name = "BttEliminar";
            this.BttEliminar.Size = new System.Drawing.Size(245, 45);
            this.BttEliminar.TabIndex = 11;
            this.BttEliminar.Text = "Eliminar";
            this.BttEliminar.UseVisualStyleBackColor = true;
            this.BttEliminar.Click += new System.EventHandler(this.BttEliminar_Click);
            // 
            // BttModificar
            // 
            this.BttModificar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttModificar.Image = global::WinAppProyectoI.Properties.Resources.m;
            this.BttModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BttModificar.Location = new System.Drawing.Point(4, 197);
            this.BttModificar.Name = "BttModificar";
            this.BttModificar.Size = new System.Drawing.Size(245, 45);
            this.BttModificar.TabIndex = 12;
            this.BttModificar.Text = "Modificar";
            this.BttModificar.UseVisualStyleBackColor = true;
            this.BttModificar.Click += new System.EventHandler(this.BttModificar_Click);
            // 
            // BttBuscar
            // 
            this.BttBuscar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttBuscar.Image = global::WinAppProyectoI.Properties.Resources.bus;
            this.BttBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BttBuscar.Location = new System.Drawing.Point(4, 146);
            this.BttBuscar.Name = "BttBuscar";
            this.BttBuscar.Size = new System.Drawing.Size(245, 45);
            this.BttBuscar.TabIndex = 13;
            this.BttBuscar.Text = "Buscar";
            this.BttBuscar.UseVisualStyleBackColor = true;
            this.BttBuscar.Click += new System.EventHandler(this.BttBuscar_Click);
            // 
            // BttIngresar
            // 
            this.BttIngresar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttIngresar.Image = global::WinAppProyectoI.Properties.Resources.ingresar;
            this.BttIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BttIngresar.Location = new System.Drawing.Point(4, 47);
            this.BttIngresar.Name = "BttIngresar";
            this.BttIngresar.Size = new System.Drawing.Size(245, 45);
            this.BttIngresar.TabIndex = 8;
            this.BttIngresar.Text = "Ingresar Datos";
            this.BttIngresar.UseVisualStyleBackColor = true;
            this.BttIngresar.Click += new System.EventHandler(this.BttIngresar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Restaurar);
            this.panel2.Controls.Add(this.Menu);
            this.panel2.Controls.Add(this.Maximizar);
            this.panel2.Controls.Add(this.Minimizar);
            this.panel2.Controls.Add(this.Cerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(50, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(911, 40);
            this.panel2.TabIndex = 1;
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(850, 8);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(25, 25);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restaurar.TabIndex = 11;
            this.Restaurar.TabStop = false;
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Menu
            // 
            this.Menu.Image = global::WinAppProyectoI.Properties.Resources.menu;
            this.Menu.Location = new System.Drawing.Point(3, 3);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(35, 35);
            this.Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Menu.TabIndex = 4;
            this.Menu.TabStop = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.Location = new System.Drawing.Point(850, 8);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(25, 25);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizar.TabIndex = 12;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(819, 8);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(25, 25);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 9;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.Location = new System.Drawing.Point(881, 8);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(25, 25);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cerrar.TabIndex = 10;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(50, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(911, 489);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(147, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 297);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 48);
            this.label1.TabIndex = 6;
            this.label1.Text = "UNIFORMES";
            // 
            // FrmUniforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 529);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUniforme";
            this.Text = "FrmUniforme";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BttResporte2;
        private System.Windows.Forms.Button BttReporte1;
        private System.Windows.Forms.Button BttEliminar;
        private System.Windows.Forms.Button BttModificar;
        private System.Windows.Forms.Button BttBuscar;
        private System.Windows.Forms.Button BttIngresar;
        private System.Windows.Forms.PictureBox Menu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Cerrar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}