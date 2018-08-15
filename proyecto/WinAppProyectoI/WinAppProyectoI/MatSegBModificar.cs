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
    public partial class MatSegBModificar : Form
    {
        int codigo;
        public MatSegBModificar()
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
                this.Hide();
                MatSegModificar objModificar = new MatSegModificar();
                objModificar.TxtBxNombre.Text = mats[0]["NombreMat"].ToString();
                objModificar.LblCodigo.Text = mats[0]["Codigo"].ToString();
                objModificar.CmbBxMarca.Text = mats[0]["Marca"].ToString();
                objModificar.TxtBxModelo.Text = mats[0]["Modelo"].ToString();
                objModificar.Date.Text = mats[0]["FechaI"].ToString();
                objModificar.DateS.Text = mats[0]["FechaS"].ToString();
                objModificar.TxtBxNombreUsuario.Text = mats[0]["Cedula"].ToString();
                objModificar.CmBxEstado.Text = mats[0]["Estado"].ToString();
                objModificar.TxtBxCantidad.Text = mats[0]["Cantidad"].ToString();
                objModificar.TxtBxPrecio.Text = mats[0]["Precio"].ToString();
                objModificar.LblPrecioT.Text = mats[0]["PrecioTotal"].ToString();

                if (objModificar.ShowDialog() == DialogResult.OK)
                {
                    mats[0]["NombreMat"]= objModificar.TxtBxNombre.Text;
                    mats[0]["Marca"] = objModificar.CmbBxMarca.Text;
                    mats[0]["Modelo"] = objModificar.TxtBxModelo.Text;
                    mats[0]["FechaI"] = objModificar.Date.Text;
                    mats[0]["FechaS"] = objModificar.DateS.Text;
                    mats[0]["Cedula"] = objModificar.TxtBxNombreUsuario.Text;
                    mats[0]["Estado"] = objModificar.CmBxEstado.Text;
                    mats[0]["Cantidad"] = objModificar.TxtBxCantidad.Text;
                    mats[0]["Precio"] = objModificar.TxtBxPrecio.Text;
                    mats[0]["PrecioTotal"] = objModificar.LblPrecioT.Text;
                    mats[0]["Nombre"] = objModificar.LblNombre.Text;
                    mats[0]["Apellido"] = objModificar.LblApellido.Text;
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
                        MessageBox.Show("No se ha encontrado ningun material de seguridad", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                        TxtBxCodigo.Text = "";
                    }
                }
                catch
                {
                    MessageBox.Show("No se ha encontrado ningun material de seguridad", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    TxtBxCodigo.Text = "";
                }
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Mazimizar.Visible = true;
        }

        private void Mazimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Mazimizar.Visible = false;
            Restaurar.Visible = true;
        }
    }
}
