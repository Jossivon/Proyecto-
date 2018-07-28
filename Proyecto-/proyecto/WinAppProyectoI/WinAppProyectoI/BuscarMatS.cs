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
    public partial class BuscarMatS : Form
    {
        public BuscarMatS()
        {
            InitializeComponent();
        }

        private void BttBuscar_Click(object sender, EventArgs e)
        {
            matSeg1.ReadXml(Application.StartupPath +"\\ArchMatSeg.xml");
            System.Data.DataRow[] datos;

            datos = matSeg1.TblMatSeg.Select("Codigo='" + TxtBxCodigo.Text + "'");
            MostrarMatS buscar = new MostrarMatS();

            if (datos.Length > 0)
            {
                buscar.LblNombreA.Text = datos[0]["NombreMat"].ToString();
                buscar.LblCodigo.Text = datos[0]["Codigo"].ToString();
                buscar.LblMarca.Text = datos[0]["Marca"].ToString();
                buscar.LblModelo.Text = datos[0]["Modelo"].ToString();
                buscar.LblFechaI.Text = datos[0]["FechaI"].ToString();
                buscar.LblFechaS.Text = datos[0]["FechaS"].ToString();
                buscar.LblNombreR.Text = datos[0]["NombreRes"].ToString();
                buscar.LblEstado.Text = datos[0]["Estado"].ToString();
                buscar.LblCantidad.Text = datos[0]["Cantidad"].ToString();
                buscar.LblPrecioU.Text = datos[0]["Precio"].ToString();
                buscar.ShowDialog();

            }
            else
            {
                MessageBox.Show("No se ha encontrado ningun material de seguridad", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                TxtBxCodigo.Text = "";
            }
        }
    }
}
