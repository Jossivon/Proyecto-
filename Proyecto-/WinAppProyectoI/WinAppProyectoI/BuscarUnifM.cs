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
    public partial class BuscarUnifM : Form
    {
        public BuscarUnifM()
        {
            InitializeComponent();
        }

        private void BttBuscar_Click(object sender, EventArgs e)
        {
            matSeg1.TblUniformes.ReadXml(Application.StartupPath + "\\ArchUniformes.xml");
            System.Data.DataRow[] uniformes;
            uniformes = matSeg1.TblUniformes.Select("Codigo='" + TxtBxCodigo.Text + "'");

            if (uniformes.Length > 0)
            {
                ModificarUni objModificar = new ModificarUni();
                objModificar.txtbNombre.Text = uniformes[0]["Nombre"].ToString();
                objModificar.TxtBxCodigo.Text = uniformes[0]["Codigo"].ToString();
                objModificar.date.Text = uniformes[0]["FechaI"].ToString();
                objModificar.dates.Text = uniformes[0]["FechaS"].ToString();
                objModificar.txtbQuienRecibe.Text = uniformes[0]["NombreR"].ToString();
                objModificar.txtbCantidad.Text = uniformes[0]["Cantidad"].ToString();
                objModificar.txtbPrecioUnitario.Text = uniformes[0]["Precio"].ToString();
                objModificar.CbxEstado.Text = uniformes[0]["Estado"].ToString();
                objModificar.CbxTalla.Text = uniformes[0]["Talla"].ToString();

                if (objModificar.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Se ha modificado con éxito el material de seguridad", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    uniformes[0]["Nombre"] = objModificar.txtbNombre.Text;
                    uniformes[0]["Codigo"] = objModificar.TxtBxCodigo.Text;
                    uniformes[0]["FechaI"] = objModificar.date.Text;
                    uniformes[0]["FechaS"] = objModificar.dates.Text;
                    uniformes[0]["NombreR"] = objModificar.txtbQuienRecibe.Text;
                    uniformes[0]["Cantidad"] = objModificar.txtbCantidad.Text;
                    uniformes[0]["Precio"] = objModificar.txtbPrecioUnitario.Text;
                    uniformes[0]["Estado"] = objModificar.CbxEstado.Text;
                    uniformes[0]["Talla"] = objModificar.CbxTalla.Text;
                    uniformes[0].AcceptChanges();
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
