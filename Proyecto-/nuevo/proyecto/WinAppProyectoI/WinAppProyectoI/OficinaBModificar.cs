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
    public partial class OficinaBModificar : Form
    {
        int codigo; 

        public OficinaBModificar()
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
                this.Hide();
                OficinaModificar objModificar = new OficinaModificar();
                objModificar.TxtBxNombre.Text = mats[0]["Nombre"].ToString();
                objModificar.LblCod.Text = mats[0]["Codigo"].ToString();
                objModificar.Date.Text = mats[0]["FechaI"].ToString();
                objModificar.dates.Text = mats[0]["FechaS"].ToString();
                objModificar.TxtBxNombreR.Text = mats[0]["NombreR"].ToString();
                objModificar.TxtBxCantidad.Text = mats[0]["Cantidad"].ToString();
                objModificar.TxtBxPrecio.Text = mats[0]["Precio"].ToString();

                if (objModificar.ShowDialog() == DialogResult.OK)
                {
                    mats[0]["Nombre"] = objModificar.TxtBxNombre.Text;
                    mats[0]["Codigo"] = objModificar.LblCod.Text;
                    mats[0]["FechaI"] = objModificar.Date.Text;
                    mats[0]["FechaS"] = objModificar.Date.Text;
                    mats[0]["NombreR"] = objModificar.TxtBxNombreR.Text;
                    mats[0]["Cantidad"] = objModificar.TxtBxCantidad.Text;
                    mats[0]["Precio"] = objModificar.TxtBxPrecio.Text;
                    mats[0].AcceptChanges();
                    matSeg1.TblOficina.WriteXml(Application.StartupPath + "\\ArchOficina.xml");
                    MessageBox.Show("Se ha modificado con éxito el material de oficina", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha modificado ningún material de oficina", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

                }
            }
            else
            {
                this.Hide();
                MessageBox.Show("No se ha encontrado ningun material de oficina", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                TxtBxCodigo.Text = "";
            }
        }

        private void TxtBxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            codigo = int.Parse(TxtBxCodigo.Text); 
            if (codigo > 0)
            {
                BttBuscar.Focus();
            }
            else
            {
                MessageBox.Show("El código debe ser mayor a cero", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
        }
    }
}
