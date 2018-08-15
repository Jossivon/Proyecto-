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
    public partial class EmpModificar : Form
    {
        string estado;
        int edad, r;
        int a = 0;

        public EmpModificar()
        {
            InitializeComponent();
        }

        private void BttGuardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
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
                }
                else
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
                    if ((num[i] >= 65 && num[i] <= 90) || (num[i] >= 97 && num[i] <= 122) || num[i] == 127)
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
                    Date.Focus();
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
                for (int i = 0; i < num.Length; i++)
                {
                    if ((num[i] >= 65 && num[i] <= 90) || (num[i] >= 97 && num[i] <= 122) || num[i] == 127)
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
                    if ((num[i] >= 65 && num[i] <= 90) || (num[i] >= 97 && num[i] <= 122) || num[i] == 127)
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
                    Date.Focus();
                }
            }
        }

        private void TxtBxEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                try
                {
                    edad = int.Parse(TxtBxEdad.Text);
                    if (edad > 18 && edad < 65)
                    {
                        BttGuardar.Focus();

                    }
                    else
                    {
                        MessageBox.Show("Edad Incorrecta");
                    }
                }
                catch
                {
                    MessageBox.Show("Ingrese solo números");
                    TxtBxEdad.Focus();
                }
            }
        }

    }
}
