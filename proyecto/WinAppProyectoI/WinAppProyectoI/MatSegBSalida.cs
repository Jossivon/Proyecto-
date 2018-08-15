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
                    

                    if (c > 0 && c<1000)
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
                    MessageBox.Show("La cantidad debe ser un valor númerico positivo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                int lim = 10;
                int res;
                string Cedula = TxtBxCedula.Text;
                char[] num = Cedula.ToArray();

                if (num.Length == 10)
                {
                    ClCedula objVerificar = new ClCedula(num, lim);
                    res = objVerificar.Verificar();
                    if (res > 0)
                    {
                        matSeg1.TblEmpleados.ReadXml(Application.StartupPath + "\\ArchEmpleados.xml");
                        System.Data.DataRow[] mats;
                        mats = matSeg1.TblEmpleados.Select("Cedula='" + TxtBxCedula.Text + "'");

                        if (mats.Length > 0)
                        {
                            LblNombre.Text = mats[0]["Nombre"].ToString();
                            LblApellido.Text = mats[0]["Apellido"].ToString();


                            cant = int.Parse(LblCExis.Text);

                            if (cant == 0)
                            {
                                MessageBox.Show("No existe ningún material de seguridad", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                TxtBxCantidad.Enabled = false;
                                Bttguardar.Enabled = false;
                                this.Close();
                            }
                            TxtBxCantidad.Focus();
                        }
                        else
                        {
                            MessageBox.Show("La cédula del responsable no existe en la empresa", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            TxtBxCedula.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cédula Incorrecta");
                        TxtBxCedula.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Cedula con mayor a 10 dígitos, INCORRECTO");
                    TxtBxCedula.Text = "";
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

        private void TxtBxCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            
        }
    }
}
