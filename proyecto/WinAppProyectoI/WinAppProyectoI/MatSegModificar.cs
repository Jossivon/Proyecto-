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
    public partial class MatSegModificar : Form
    {
        int codigo;
        int cont = 0;
        int cant,r,a;
        string fecha, fechas, estado;
        double precio,preciot;

        public MatSegModificar()
        {
            InitializeComponent();
        }

        private void BttModificar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();

            
        }

        private void BttCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void TxtBxModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                if (TxtBxModelo.Text == "")
                {
                    MessageBox.Show("Datos ingresado vacio, ingrese un nombre del material de seguridad");
                    TxtBxModelo.Text = "";
                }
                else
                {

                    Date.Focus();
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
                    LblTxtMarca.Focus();
                }
            }
        }



        private void Date_ValueChanged(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            Date.MaxDate = thisDay;
            DateS.MinDate = Date.Value;
            DateS.Focus();
        }

        private void DateS_ValueChanged(object sender, EventArgs e)
        {
            fechas = DateS.Text;
            CmBxEstado.Focus();
        }

       
        private void Restaurar_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Mazimizar.Visible = true;
        }

        private void Mazimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Mazimizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void CmBxEstado_ValueMemberChanged(object sender, EventArgs e)
        {
            try
            {
                estado = CmBxEstado.SelectedItem.ToString();
                if (estado == "")
                {
                    MessageBox.Show("No se ha seleccionado ningun dato", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CmBxEstado.Focus();
                }
                else
                    TxtBxNombreUsuario.Focus();
            }
            catch
            {
                MessageBox.Show("Valores mal ingresados, seleccione los valores en la flecha", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CmBxEstado.Text = "";
            }
        }

        private void comboBox1_ValueMemberChanged(object sender, EventArgs e)
        {
            try
            {
                estado = CmbBxMarca.SelectedItem.ToString();
                if (estado == "")
                {
                    MessageBox.Show("No se ha seleccionado ningun dato", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CmbBxMarca.Focus();
                }
                else
                    TxtBxNombreUsuario.Focus();
            }
            catch
            {
                MessageBox.Show("Valores mal ingresados, seleccione los valores en la flecha", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CmBxEstado.Text = "";
            }
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

        private void TxtBxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                try
                {
                    precio = double.Parse(TxtBxPrecio.Text);
                    if (precio > 0&& precio <1000)
                    {
                        preciot= (cant*precio);
                        LblPrecioT.Text = preciot.ToString();
                        BttModificar.Focus();
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
}
