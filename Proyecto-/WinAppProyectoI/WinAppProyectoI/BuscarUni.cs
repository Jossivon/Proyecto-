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
    public partial class BuscarUni : Form
    {
        public BuscarUni()
        {
            InitializeComponent();
        }

        private void BttBuscar_Click(object sender, EventArgs e)
        {
            matSeg1.TblUniformes.ReadXml(Application.StartupPath + "\\ArchUniformes.xml");
            System.Data.DataRow[] datos;

            datos = matSeg1.TblUniformes.Select("Codigo='" + TxtBxCodigo.Text + "'");
            MostrarUni objMostrar = new MostrarUni();

            if (datos.Length > 0)
            {
                objMostrar.LblNombreU.Text = datos[0]["Nombre"].ToString();
                objMostrar.LblCodigoU.Text = datos[0]["Codigo"].ToString();
                objMostrar.FechaI.Text = datos[0]["FechaI"].ToString();
                objMostrar.FechaS.Text = datos[0]["FechaS"].ToString();
                objMostrar.LblCan.Text = datos[0]["Cantidad"].ToString();
                objMostrar.LblPrecio.Text = datos[0]["Precio"].ToString();
                objMostrar.LblNombreR.Text = datos[0]["NombreR"].ToString();
                objMostrar.LblTala.Text = datos[0]["Talla"].ToString();
                objMostrar.LblEstado.Text = datos[0]["Estado"].ToString();
                objMostrar.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se ha encontrado ningun uniforme", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                TxtBxCodigo.Text = "";
            }
        }
    }
}
