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
        public OficinaModificar()
        {
            InitializeComponent();
        }

        private void TxtBxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                if (TxtBxNombre.Text == "")
                {
                    MessageBox.Show("El nombre se encuentra vacio", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                    TxtBxNombre.Text = "";
                }
            }
        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {
            fecha = Date.Text;
            dates.MinDate = Date.Value;
            TxtBxNombreR.Focus();

        }

        private void TxtBxNombreR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                if (TxtBxNombreR.Text == "")
                {
                    MessageBox.Show("El nombre se encuentra vacio", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                    TxtBxNombreR.Text = "";
                }
                else
                {
                    TxtBxCantidad.Focus();
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

        private void BttGuardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void TxtBxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                precio = double.Parse(TxtBxPrecio.Text);
                if (precio > 0)
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
