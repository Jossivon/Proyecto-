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
    public partial class OficinaSalida : Form
    {
        string fecha;
        int cant,c;
        int cantd;
        public OficinaSalida()
        {
            InitializeComponent();
        }

        private void date_Validated(object sender, EventArgs e)
        {
            fecha = dates.Text;
            LblTxtNomreUsuario.Focus();
        }

        private void TxtBxNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
               if (TxtBxNombreUsuario.Text == "") {
                    MessageBox.Show("El campo del nombre del responsable esta vacio", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                    TxtBxNombreUsuario.Text = "";
                }
                else
                {
                    TxtBxCantidad.Focus();
                }
            }
        }

        private void BttGuardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void TxtBxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            { 
                try
                {
                    c= int.Parse(TxtBxCantidad.Text);
                    cant = int.Parse(LblCantidad.Text);
                    if (cant > 0)
                    {
                        if (cant >= c)
                        {
                            cantd = cant - c;
                            LblC.Text = cantd.ToString();
                            BttGuardar.Focus();
                        }
                        else
                        {
                            MessageBox.Show("La cantidad de salida no puede ser mayor a la que existe en la empresa", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            TxtBxCantidad.Text = "";
                        }
                      
                    }
                    else
                    {
                        MessageBox.Show("La cantidad debe ser mayor a cero ", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                        TxtBxCantidad.Text = "";
                    }
                }
                catch
                {
                    MessageBox.Show("La cantidad debe ser númerica ", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                    TxtBxCantidad.Text = "";
                }
            }
        }
    }
}
