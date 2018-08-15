namespace WinAppProyectoI
{
    partial class FrmEmpleados
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BttResporte2 = new System.Windows.Forms.Button();
            this.BttModificar = new System.Windows.Forms.Button();
            this.BttEliminar = new System.Windows.Forms.Button();
            this.BttBuscar = new System.Windows.Forms.Button();
            this.BttIngresar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.BttResporte2);
            this.panel1.Controls.Add(this.BttModificar);
            this.panel1.Controls.Add(this.BttEliminar);
            this.panel1.Controls.Add(this.BttBuscar);
            this.panel1.Controls.Add(this.BttIngresar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 491);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button3.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(22, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(246, 45);
            this.button3.TabIndex = 19;
            this.button3.Text = "Mostrar datos ingresados";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(21, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(246, 45);
            this.button2.TabIndex = 18;
            this.button2.Text = "Reporte Cantidad";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 45);
            this.button1.TabIndex = 17;
            this.button1.Text = "Reporte Estado";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BttResporte2
            // 
            this.BttResporte2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BttResporte2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttResporte2.Location = new System.Drawing.Point(21, 274);
            this.BttResporte2.Name = "BttResporte2";
            this.BttResporte2.Size = new System.Drawing.Size(247, 45);
            this.BttResporte2.TabIndex = 12;
            this.BttResporte2.Text = "Reporte 1";
            this.BttResporte2.UseVisualStyleBackColor = true;
            this.BttResporte2.Click += new System.EventHandler(this.BttResporte2_Click);
            // 
            // BttModificar
            // 
            this.BttModificar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BttModificar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttModificar.Location = new System.Drawing.Point(22, 223);
            this.BttModificar.Name = "BttModificar";
            this.BttModificar.Size = new System.Drawing.Size(246, 45);
            this.BttModificar.TabIndex = 14;
            this.BttModificar.Text = "Modificar";
            this.BttModificar.UseVisualStyleBackColor = true;
            this.BttModificar.Click += new System.EventHandler(this.BttModificar_Click);
            // 
            // BttEliminar
            // 
            this.BttEliminar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BttEliminar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttEliminar.Location = new System.Drawing.Point(21, 172);
            this.BttEliminar.Name = "BttEliminar";
            this.BttEliminar.Size = new System.Drawing.Size(247, 45);
            this.BttEliminar.TabIndex = 15;
            this.BttEliminar.Text = "Eliminar";
            this.BttEliminar.UseVisualStyleBackColor = true;
            this.BttEliminar.Click += new System.EventHandler(this.BttEliminar_Click);
            // 
            // BttBuscar
            // 
            this.BttBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BttBuscar.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttBuscar.Location = new System.Drawing.Point(21, 121);
            this.BttBuscar.Name = "BttBuscar";
            this.BttBuscar.Size = new System.Drawing.Size(247, 45);
            this.BttBuscar.TabIndex = 16;
            this.BttBuscar.Text = "Buscar ";
            this.BttBuscar.UseVisualStyleBackColor = true;
            this.BttBuscar.Click += new System.EventHandler(this.BttBuscar_Click);
            // 
            // BttIngresar
            // 
            this.BttIngresar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BttIngresar.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttIngresar.Location = new System.Drawing.Point(22, 19);
            this.BttIngresar.Name = "BttIngresar";
            this.BttIngresar.Size = new System.Drawing.Size(246, 45);
            this.BttIngresar.TabIndex = 11;
            this.BttIngresar.Text = "Ingresar datos";
            this.BttIngresar.UseVisualStyleBackColor = true;
            this.BttIngresar.Click += new System.EventHandler(this.BttIngresar_Click);
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 491);
            this.Controls.Add(this.panel1);
            this.Name = "FrmEmpleados";
            this.Text = "FrmEmpleados";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BttResporte2;
        private System.Windows.Forms.Button BttModificar;
        private System.Windows.Forms.Button BttEliminar;
        private System.Windows.Forms.Button BttBuscar;
        private System.Windows.Forms.Button BttIngresar;
    }
}