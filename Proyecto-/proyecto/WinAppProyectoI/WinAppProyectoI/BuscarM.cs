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
    public partial class BuscarM : Form
    {
        public BuscarM()
        {
            InitializeComponent();
        }

        private void BttBuscar_Click(object sender, EventArgs e)
        {
            matSeg1.TblMatSeg.ReadXml(Application.StartupPath + "\\ArchMatSeg.xml");
            System.Data.DataRow[] mats;
            mats = matSeg1.TblMatSeg.Select("Codigo='" + TxtBxCodigo.Text + "'");

            if (mats.Length > 0)
            {
                ModificarMatS objModificar = new ModificarMatS();
                objModificar.TxtBxNombre.Text = mats[0]["NombreMat"].ToString();
                objModificar.TxtBxCodigo.Text = mats[0]["Codigo"].ToString();
                objModificar.TxtBxMarca.Text = mats[0]["Marca"].ToString();
                objModificar.TxtBxModelo.Text = mats[0]["Modelo"].ToString();
                objModificar.Date.Text = mats[0]["FechaI"].ToString();
                objModificar.DateS.Text = mats[0]["FechaS"].ToString();
                objModificar.TxtBxNombreUsuario.Text = mats[0]["NombreRes"].ToString();
                objModificar.CmBxEstado.Text = mats[0]["Estado"].ToString();
                objModificar.TxtBxCantidad.Text = mats[0]["Cantidad"].ToString();
                objModificar.TxtBxPrecio.Text = mats[0]["Precio"].ToString();
                objModificar.LblTxtPrecioT.Text = mats[0]["PrecioTotal"].ToString();

                if (objModificar.ShowDialog() == DialogResult.OK)
                {
                    mats[0]["NombreMat"]= objModificar.TxtBxNombre.Text;
                    mats[0]["Codigo"]= objModificar.TxtBxCodigo.Text;
                    mats[0]["Marca"] = objModificar.TxtBxMarca.Text;
                    mats[0]["Modelo"] = objModificar.TxtBxModelo.Text;
                    mats[0]["FechaI"] = objModificar.Date.Text;
                    mats[0]["FechaS"] = objModificar.DateS.Text;
                    mats[0]["NombreRes"] = objModificar.TxtBxNombreUsuario.Text;
                    mats[0]["Estado"] = objModificar.CmBxEstado.Text;
                    mats[0]["Cantidad"] = objModificar.TxtBxCantidad.Text;
                    mats[0]["Precio"] = objModificar.TxtBxPrecio.Text;
                    mats[0]["PrecioTotal"] = objModificar.LblTxtPrecioT.Text;
                    mats[0].AcceptChanges();
                    matSeg1.TblMatSeg.WriteXml(Application.StartupPath + "\\ArchMatSeg.xml");

                }
                else
                {
                    MessageBox.Show("No se ha modificado ningún material de seguridad", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("No se ha encontrado ningun material de seguridad", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                TxtBxCodigo.Text = "";
            }
        }
    }
}
