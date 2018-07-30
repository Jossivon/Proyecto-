using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppProyectoI
{
    public partial class MatSegBSalida : Form
    {
        int cant,c;
        int cantidadn;
        string nombre;
        
        public MatSegBSalida()
        {
            InitializeComponent();
        }

        private void TxtBxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                try
                {
                    cant = int.Parse(LblCExis.Text);
                    c = int.Parse(TxtBxCantidad.Text);
                    if (c > 0)
                    {
                        if (cant >= c)
                        {
                            cantidadn = cant - c;
                            LblCanN.Text = cantidadn.ToString();
                            Bttguardar.Focus();
                        }
                        else
                        {
                            MessageBox.Show("La cantidad de salida no puede ser mayor a la que existe en la empresa", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            TxtBxCantidad.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("La cantidad debe ser mayor a 1", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TxtBxCantidad.Text = "";
                    }
                }
                catch
                {
                    MessageBox.Show("La cantidad debe ser un valor númerico", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtBxCantidad.Text = "";
                }
                    
            }
        }

        private void DateS_ValueChanged(object sender, EventArgs e)
        {
            DateS.MinDate = dateTimePicker1.Value;

        }

        private void TxtBxNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                nombre = LblTxtNomreUsuario.Text; 
                if (nombre == "")
                {
                    MessageBox.Show("Debe ingresar un Nombre de quien va a recibir el producto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LblTxtNomreUsuario.Text = "";
                }
                else
                {
                    TxtBxCantidad.Focus();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Mazimizar.Visible = true;
        }

        private void Mazimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Mazimizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            
        }
    }
}
