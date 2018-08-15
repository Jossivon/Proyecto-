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
    public partial class UniformesModificar : Form
    {
        int cant,d,c;
        double precio, preciot,pr;
        string fecha,estado;
        public UniformesModificar()
        {
            InitializeComponent();
        }

        private void TxtBxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string Nombre = TxtBxNombre.Text;
                char[] num = Nombre.ToArray();
                d = 0;
                c = 0;
                for (int i = 0; i < num.Length; i++)
                {
                    if ((num[i] >= 65 && num[i] <= 90) || (num[i] >= 97 && num[i] <= 122) || num[i] == 127)
                    {
                        d++;
                    }
                    else
                    {
                        c++;
                    }
                }

                if (c > 0)
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

        private void TxtBxCantidad_TextChanged(object sender, EventArgs e)
        {

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
                    if (precio > 0 && precio<1000)
                    { 
                        pr = cant * precio;
                        LblPrecioT.Text = pr.ToString();
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

        private void TxtNombreR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                int lim = 10;
                int res;
                string Cedula = TxtNombreR.Text;
                char[] num = Cedula.ToArray();

                if (num.Length == 10)
                {
                    ClCedula objVerificar = new ClCedula(num, lim);
                    res = objVerificar.Verificar();
                    if (res > 0)
                    {
                        matSeg1.TblEmpleados.ReadXml(Application.StartupPath + "\\ArchEmpleados.xml");
                        System.Data.DataRow[] mats;
                        mats = matSeg1.TblEmpleados.Select("Cedula='" + TxtNombreR.Text + "'");

                        if (mats.Length > 0)
                        {
                            LblNombre.Text = mats[0]["Nombre"].ToString();
                            LblApellido.Text = mats[0]["Apellido"].ToString();
                            TxtBxCantidad.Focus();
                        }
                        else
                        {
                            MessageBox.Show("La cédula del responsable no existe en la empresa", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            TxtNombreR.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cédula Incorrecta");
                        TxtNombreR.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Cedula con mayor a 10 dígitos, INCORRECTO");
                    TxtNombreR.Text = "";
                }


            }
        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            Date.MaxDate = thisDay;
            datas.MinDate = Date.Value;
            CbxTalla.Focus();
        }

       

        private void datas_Validated(object sender, EventArgs e)
        {
            CbxTalla.Focus(); 
        }

        private void CbxTalla_ValueMemberChanged(object sender, EventArgs e)
        {
            try
            {
                estado = CbxTalla.SelectedItem.ToString();
                if (estado == "")
                {
                    MessageBox.Show("No se ha seleccionado ningun dato", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CbxTalla.Focus();
                }
                else
                    CmBxEstado.Focus();

            }
            catch
            {
                MessageBox.Show("Valores mal ingresados, seleccione los valores en la flecha", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CbxTalla.Text = "";
            }
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
                    TxtBxCantidad.Focus();

            }
            catch
            {
                MessageBox.Show("Valores mal ingresados, seleccione los valores en la flecha", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CmBxEstado.Text = "";
            }
        }

        private void BttGuardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; 
        }
    }
}
