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
    public partial class OficinaModificar : Form
    {
        int cant;
        double precio, preciot;
        string fecha;
        int r, a;
        public OficinaModificar()
        {
            InitializeComponent();
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

        private void Date_ValueChanged(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            Date.MaxDate = thisDay;
            dates.MinDate = Date.Value;
            dates.Focus();

        }

        private void TxtBxNombreR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                int lim = 10;
                int res;
                string Cedula = TxtBxNombreR.Text;
                char[] num = Cedula.ToArray();

                if (num.Length == 10)
                {
                    ClCedula objVerificar = new ClCedula(num, lim);
                    res = objVerificar.Verificar();
                    if (res > 0)
                    {
                        matSeg1.TblEmpleados.ReadXml(Application.StartupPath + "\\ArchEmpleados.xml");
                        System.Data.DataRow[] mats;
                        mats = matSeg1.TblEmpleados.Select("Cedula='" + TxtBxNombreR.Text + "'");

                        if (mats.Length > 0)
                        {
                            LblNombre.Text = mats[0]["Nombre"].ToString();
                            LblApellido.Text = mats[0]["Apellido"].ToString();
                            TxtBxCantidad.Focus();
                        }
                        else
                        {
                            MessageBox.Show("La cédula del responsable no existe en la empresa", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            TxtBxNombreR.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cédula Incorrecta");
                        TxtBxNombreR.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("La cédula debe ser con mas de 10 dígitos, INCORRECTO");
                    TxtBxNombreR.Text = "";
                }


            }
        }

        private void TxtBxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                try
                {
                    cant = int.Parse(TxtBxCantidad.Text);
                    if (cant > 0 && cant<1000)
                    {
                        TxtBxPrecio.Focus();
                    }
                    else
                    {
                        MessageBox.Show("La cantidad debe ser mayor a 1", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TxtBxCantidad.Text = "";
                    }
                }
                catch
                {
                    MessageBox.Show("La cantidad debe ser un valor númerico", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtBxCantidad.Text = "";
                }

            }
        }

        private void BttGuardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void TxtBxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                precio = double.Parse(TxtBxPrecio.Text);
                if (precio > 0 && precio <1000)
                {
                    preciot = precio * cant;
                    LblPrecioT.Text = preciot.ToString();
                    BttGuardar.Focus();
                }
                else
                {
                    MessageBox.Show("El precio debe ser un valor positivo", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtBxPrecio.Text = "";
                }

            }
            catch
            {
                MessageBox.Show("El precio debe ser un valor númerico", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtBxPrecio.Text = "";
            }
        }
    }
}
