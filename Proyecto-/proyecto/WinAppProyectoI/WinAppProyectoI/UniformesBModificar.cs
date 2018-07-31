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
    public partial class UniformesBModificar : Form
    {
        int codigo;

        public UniformesBModificar()
        {
            InitializeComponent();
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

        private void BttBuscar_Click(object sender, EventArgs e)
        {
            matSeg1.TblUniformes.ReadXml(Application.StartupPath + "\\ArchUniformes.xml");
            System.Data.DataRow[] mats;
            mats = matSeg1.TblUniformes.Select("Codigo='" + TxtBxCodigo.Text + "'");

            if (mats.Length > 0)
            {
                this.Hide();
                UniformesModificar objModificar = new UniformesModificar();
                objModificar.TxtBxNombre.Text = mats[0]["Nombre"].ToString();
                objModificar.LblCodigo.Text = mats[0]["Codigo"].ToString();
                objModificar.Date.Text = mats[0]["FechaI"].ToString();
                objModificar.datas.Text = mats[0]["FechaS"].ToString();
                objModificar.TxtNombreR.Text = mats[0]["NombreR"].ToString();
                objModificar.TxtBxCantidad.Text = mats[0]["Cantidad"].ToString();
                objModificar.TxtBxPrecio.Text = mats[0]["Precio"].ToString();
                objModificar.LblPrecioT.Text = mats[0]["PrecioT"].ToString();
                objModificar.CbxTalla.Text = mats[0]["Talla"].ToString();
                objModificar.CmBxEstado.Text = mats[0]["Estado"].ToString(); 


                if (objModificar.ShowDialog() == DialogResult.OK)
                {
                    mats[0]["Nombre"] = objModificar.TxtBxNombre.Text;
                    mats[0]["Codigo"] = objModificar.LblCodigo.Text;
                    mats[0]["FechaI"] = objModificar.Date.Text;
                    mats[0]["FechaS"] = objModificar.Date.Text;
                    mats[0]["NombreR"] = objModificar.TxtNombreR.Text;
                    mats[0]["Cantidad"] = objModificar.TxtBxCantidad.Text;
                    mats[0]["Precio"] = objModificar.TxtBxPrecio.Text;
                    mats[0]["Estado"] = objModificar.CmBxEstado.Text;
                    mats[0]["Talla"]= objModificar.CbxTalla.Text;

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
    }
}
