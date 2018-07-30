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
    public partial class OficinaBuscar : Form
    {
        public OficinaBuscar()
        {
            InitializeComponent();
        }

        private void BttBuscar_Click(object sender, EventArgs e)
        {
            matSeg1.TblOficina.ReadXml(Application.StartupPath + "\\ArchOficina.xml");
            System.Data.DataRow[] datos;

            datos = matSeg1.TblOficina.Select("Codigo='" + TxtBxCodigo.Text + "'");
            OficinaMostrar objMostrar = new OficinaMostrar();

            if (datos.Length > 0)
            {
                this.Hide();
                objMostrar.LblNombre.Text = datos[0]["Nombre"].ToString();
                objMostrar.LblCodigo.Text = datos[0]["Codigo"].ToString();
                objMostrar.LblFechaI.Text = datos[0]["FechaI"].ToString();
                objMostrar.LblFechaS.Text = datos[0]["FechaS"].ToString();
                objMostrar.LblCantidad.Text = datos[0]["Cantidad"].ToString();
                objMostrar.LblPrecioU.Text = datos[0]["Precio"].ToString();
                objMostrar.ShowDialog();

                if (objMostrar.DialogResult == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No se ha encontrado ningun material de oficina", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                TxtBxCodigo.Text = "";
            }
        }
    }
}
