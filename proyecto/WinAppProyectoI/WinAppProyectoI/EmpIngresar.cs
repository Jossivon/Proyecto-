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
    public partial class EmpIngresar : Form
    {
        string estado;
        int edad,cont,r;
        int a = 0;

        public EmpIngresar()
        {
            InitializeComponent();
        }

        private void TxtBxCedula_KeyPress(object sender, KeyPressEventArgs e)
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
                        TxtBxCedula.ReadOnly = true;
                        TxtBxNombre.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Cédula Incorrecta");
                        TxtBxCedula.Text = "";
                    }
                }else
                {
                    MessageBox.Show("Cedula con mayor a 10 dígitos, INCORRECTO");
                    TxtBxCedula.Text = "";
                }
            }
        }

        private void TxtBxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string Nombre = TxtBxNombre.Text;
                char[] num = Nombre.ToArray();
                r = 0;
                a = 0;
                for (int i = 0; i < num.Length; i++)
                {
                    if ((num[i] >= 65 && num[i] <= 90) || (num[i] >= 97 && num[i] <= 122) || num[i] == 127 || num[i]==239)
                    {
                        r++;
                    }
                    else
                    {
                        a++;
                    }
                }

                if (a > 0)
                {
                    MessageBox.Show("Ingrese solo letras");
                    TxtBxNombre.Text = "";
                }
                else
                {
                    TxtBxApellido.Focus();
                }
            }
        }

        private void TxtBxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string Apellido = TxtBxApellido.Text;
                char[] num = Apellido.ToArray();
                r = 0;
                a = 0;
                for (int i=0; i<num.Length; i++)
                {
                    if ((num[i] >= 65 && num[i] <= 90) || (num[i] >= 97 && num[i] <= 122) || num[i] == 127 || num[i] == 239)
                    {
                        r++;
                    }
                    else
                    {
                        a++;
                    }    
                }

                if (a>0)
                {
                    MessageBox.Show("Ingrese solo letras");
                    TxtBxApellido.Text = "";
                }
                else
                {
                    Date.Focus();
                }
            }
        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            Date.MaxDate = thisDay;
            CmBxCargo.Focus();
        }

        private void CmBxpProvincia_ValueMemberChanged(object sender, EventArgs e)
        {
            try
            {
                estado = CmBxpProvincia.SelectedItem.ToString();
                if (estado == "")
                {
                    MessageBox.Show("No se ha seleccionado ningun dato", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                   TxtBxCiudad.Focus();

            }
            catch
            {
                MessageBox.Show("Valores mal ingresados, seleccione los valores en la flecha", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CmBxpProvincia.Text = "";
            }
        }

        private void TxtBxCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string Ciudad = TxtBxCiudad.Text;
                char[] num = Ciudad.ToArray();
                r = 0;
                a = 0;
                for (int i = 0; i < num.Length; i++)
                {
                    if ((num[i] >= 65 && num[i] <= 90) || (num[i] >= 97 && num[i] <= 122) ||num[i]==127)
                    {
                        r++;
                    }
                    else
                    {
                        a++;
                    }
                }

                if (a > 0)
                {
                    MessageBox.Show("Ingrese solo letras");
                    TxtBxApellido.Text = "";
                }
                else
                {
                    TxtBxEdad.Focus();
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                try
                {
                    edad = int.Parse(TxtBxEdad.Text); 
                    if (edad >= 18 && edad <=65)
                    {
                        BttGuardar.Focus();

                    }
                    else
                    {
                        MessageBox.Show("Edad Incorrecta debe ser mayor a los 18 años y menor a 65", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("Ingrese solo números","¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    BttGuardar.Focus();
                }
            }
        }

        private void CmBxCargo_ValueMemberChanged(object sender, EventArgs e)
        {
            try
            {
                estado = CmBxCargo.SelectedItem.ToString();
                if (estado == "")
                {
                    MessageBox.Show("No se ha seleccionado ningun dato", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    CmBxpProvincia.Focus();

            }
            catch
            {
                MessageBox.Show("Valores mal ingresados, seleccione los valores en la flecha", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CmBxCargo.Text = "";
            }
        }

        private void BttGuardar_Click(object sender, EventArgs e)
        {
            cont = 0;


            if (CmBxCargo.Text == "")
            {
                MessageBox.Show("El cargo del empleado esta vacio", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                CmBxCargo.Focus();
                cont++;
            }

           
            if (TxtBxNombre.Text == "")
            {
                MessageBox.Show("El nombre del empleado esta vacio ", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                TxtBxNombre.Focus();
                cont++;
            }

            if (TxtBxEdad.Text == "")
            {
                MessageBox.Show("La edad del empleado esta vacia", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                TxtBxEdad.Focus();
                cont++;
            }
            if (TxtBxApellido.Text == "")
            {
                MessageBox.Show("El apellido del empleado esta vacio", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                TxtBxApellido.Focus();
                cont++;
            }
            if (TxtBxCedula.Text == "")
            {
                MessageBox.Show("El número de cédula esta vacio", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                TxtBxCedula.Focus();
                cont++;
            }




            if (cont == 0)
            {
               
                matSeg1.ReadXml(Application.StartupPath + "\\ArchEmpleados.xml");

                object[] emp = new object[8];

                emp[0] = TxtBxCedula.Text;
                emp[1] = TxtBxNombre.Text;
                emp[2] = TxtBxApellido.Text;
                emp[3] = Date.Text;
                emp[4] = CmBxCargo.Text;
                emp[5] = TxtBxEdad.Text;
                emp[6] = CmBxpProvincia.Text;
                emp[7] = TxtBxCiudad.Text;

               
                System.Data.DataRow[] vct;
                vct = matSeg1.TblEmpleados.Select("Cedula='" + TxtBxCedula.Text + "'");
                if (vct.Length > 0)
                {

                    MessageBox.Show("El Número de Cédula ya existe", "ALERTA", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    TxtBxCedula.Enabled = false;
                    this.Close();
                }
                else
                {
                    matSeg1.TblEmpleados.Rows.Add(emp);
                    matSeg1.WriteXml(Application.StartupPath + "\\ArchEmpleados.xml");
                    MessageBox.Show("Se ha guardado exitosamente", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }

            }
        }
    }
}
