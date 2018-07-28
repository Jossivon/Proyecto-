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
    public partial class ModificarMatS : Form
    {
        int codigo;
        int cont = 0;
        int cant;
        string fecha, fechas, estado;
        double precio,preciot;

        public ModificarMatS()
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
            if (e.KeyChar == (Char)Keys.Enter)
            {

                if (TxtBxNombre.Text == "")
                {
                    MessageBox.Show("Datos ingresado vacio, ingrese un nombre del material de seguridad");
                    TxtBxNombre.Text = "";
                }
                else
                {
                    TxtBxCodigo.Focus();
                }
            }
        }

        private void TxtBxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                try
                {
                    codigo = int.Parse(TxtBxCodigo.Text);
                    if (codigo > 0)
                    {
                        TxtBxMarca.Focus();
                    }
                    else
                    {
                        MessageBox.Show("El código debe ser un valor positivo", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TxtBxCodigo.Text = "";
                    }
                }
                catch
                {
                    MessageBox.Show("El código ingresado debe ser númerico", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtBxCodigo.Text = "";
                }
            }
        }

        private void TxtBxMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                if (TxtBxMarca.Text == "")
                {
                    MessageBox.Show("Datos ingresado vacio, ingrese un nombre del material de seguridad");
                    TxtBxMarca.Text = "";
                }
                else
                {
                    TxtBxModelo.Focus();
                }
            }
        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {
            fecha = Date.Text;
            DateS.MinDate = Date.Value;
            DateS.Focus();
        }

        private void DateS_ValueChanged(object sender, EventArgs e)
        {
            fechas = DateS.Text;
            CmBxEstado.Focus();
        }

        private void CmBxEstado_Validated(object sender, EventArgs e)
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

        private void TxtBxNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
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
                TxtBxCantidad.Focus();
            }
        }

        private void TxtBxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                try
                {
                    cant = int.Parse(TxtBxCantidad.Text);
                    if (cant > 0)
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
                    if (precio > 0)
                    {
                        preciot = cant * precio;
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
