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
    public partial class BuscarModU : Form
    {
        public BuscarModU()
        {
            InitializeComponent();
        }

        private void BttBuscar_Click(object sender, EventArgs e)
        {
            matSeg1.TblOficina.ReadXml(Application.StartupPath + "\\ArchOficina.xml");
            System.Data.DataRow[] mats;
            mats = matSeg1.TblOficina.Select("Codigo='" + TxtBxCodigo.Text + "'");

            if (mats.Length > 0)
            {
                UMostrarM objModificar = new UMostrarM();
                objModificar.TxtBxNombre.Text = mats[0]["Nombre"].ToString();
                objModificar.TxtBxCodigo.Text = mats[0]["Codigo"].ToString();
                objModificar.Date.Text = mats[0]["FechaI"].ToString();
                objModificar.DateS.Text = mats[0]["FechaS"].ToString();
                objModificar.TxtBxNombreUsuario.Text = mats[0]["NombreR"].ToString();
                objModificar.TxtBxCantidad.Text = mats[0]["Cantidad"].ToString();
                objModificar.TxtBxPrecio.Text = mats[0]["Precio"].ToString();

                if (objModificar.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Se ha modificado con éxito el material de seguridad", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    mats[0]["Nombre"] = objModificar.TxtBxNombre.Text;
                    mats[0]["Codigo"] = objModificar.TxtBxCodigo.Text;
                    mats[0]["FechaI"] = objModificar.Date.Text;
                    mats[0]["FechaS"] = objModificar.DateS.Text;
                    mats[0]["NombreR"] = objModificar.TxtBxNombreUsuario.Text;
                    mats[0]["Cantidad"] = objModificar.TxtBxCantidad.Text;
                    mats[0]["Precio"] = objModificar.TxtBxPrecio.Text;
                    mats[0].AcceptChanges();
                    matSeg1.TblOficina.WriteXml(Application.StartupPath + "\\ArchOficina.xml");

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
