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
    public partial class UniformesSalida : Form
    {
        string fecha;
        int cant, c,a=0;
        int cantd;
        public UniformesSalida()
        {
            InitializeComponent();
        }

        private void TxtBxNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                int lim = 10;
                int res;
                string Cedula = TxtBxNombreUsuario.Text;
                char[] num = Cedula.ToArray();

                if (num.Length == 10)
                {
                    ClCedula objVerificar = new ClCedula(num, lim);
                    res = objVerificar.Verificar();
                    if (res > 0)
                    {
                        matSeg1.TblEmpleados.ReadXml(Application.StartupPath + "\\ArchEmpleados.xml");
                        System.Data.DataRow[] mats;
                        mats = matSeg1.TblEmpleados.Select("Cedula='" + TxtBxNombreUsuario.Text + "'");

                        if (mats.Length > 0)
                        {
                            cant = int.Parse(LblCantidad.Text);
                            if (cant == 0)
                            {
                                MessageBox.Show("No existe ningun material de oficina");
                                TxtBxCantidad.Enabled = false;
                                BttGuardar.Enabled = false;
                                this.Close();
                            }
                            LblNombre.Text = mats[0]["Nombre"].ToString();
                            LblApellido.Text = mats[0]["Apellido"].ToString();
                            TxtBxCantidad.Focus();
                        }
                        else
                        {
                            MessageBox.Show("La cédula del responsable no existe en la empresa", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            TxtBxNombreUsuario.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cédula Incorrecta");
                        TxtBxNombreUsuario.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Cedula con mayor a 10 dígitos, INCORRECTO");
                    TxtBxNombreUsuario.Text = "";
                }


            }
        }

        private void dates_Validated(object sender, EventArgs e)
        {
            fecha = dates.Text;
            LblTxtNomreUsuario.Focus();
        }

        private void BttGuardar_Click(object sender, EventArgs e)
        {
            a = 0;
            if (TxtBxNombreUsuario.Text == "")
            {
                MessageBox.Show("campo de cédula vacio");
                date.Text = "";
                BttGuardar.Enabled = false;
                TxtBxNombreUsuario.Focus();
                a++;
            }
            if (TxtBxCantidad.Text == "")
            {
                MessageBox.Show("la cantidad no se ha ingresado");
                TxtBxCantidad.Focus();
                BttGuardar.Enabled = false;
                a++;
            }

            if (a == 0)
            {
                this.DialogResult = DialogResult.OK;
                BttGuardar.Enabled = true;
            }
        }

        private void TxtBxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                try
                {
                    c = int.Parse(TxtBxCantidad.Text);
                    cant = int.Parse(LblCantidad.Text);
                    if (cant > 0 && cant<1000)
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
