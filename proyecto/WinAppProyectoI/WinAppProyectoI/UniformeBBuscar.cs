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
    public partial class UniformeBBuscar : Form
    {
        int codigo;

        public UniformeBBuscar()
        {
            InitializeComponent();
        }

        private void BttBuscar_Click(object sender, EventArgs e)
        {
            matSeg1.TblUniformes.ReadXml(Application.StartupPath + "\\ArchUniformes.xml");
            System.Data.DataRow[] datos;

            datos = matSeg1.TblUniformes.Select("Codigo='" + TxtBxCodigo.Text + "'");
            UniformesMostrar objMostrar = new UniformesMostrar();

            if (datos.Length > 0)
            {
                this.Hide();
                objMostrar.LblNombre.Text = datos[0]["Nombre"].ToString();
                objMostrar.LblCodigo.Text = datos[0]["Codigo"].ToString();
                objMostrar.LblFechaI.Text = datos[0]["FechaI"].ToString();
                objMostrar.LblFechaS.Text = datos[0]["FechaS"].ToString();
                objMostrar.LblCantidad.Text = datos[0]["Cantidad"].ToString();
                objMostrar.LblPrecioU.Text = datos[0]["Precio"].ToString();
                objMostrar.LblTalla.Text = datos[0]["Talla"].ToString();
                objMostrar.LblEstado.Text = datos[0]["Estado"].ToString();
                objMostrar.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se ha encontrado ningun material de oficina", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                TxtBxCodigo.Text = "";
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
                        BttBuscar.Focus();
                    }
                    else
                    {
                        MessageBox.Show("El código debe ser mayor a cero", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                        TxtBxCodigo.Text = "";
                    }
                }
                catch
                {
                    MessageBox.Show("No se ha encontrado ningun material de oficina", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    TxtBxCodigo.Text = "";
                }

            }
        }
    }
}
