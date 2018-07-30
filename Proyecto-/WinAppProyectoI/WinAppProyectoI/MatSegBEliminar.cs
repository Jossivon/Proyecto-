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
    public partial class MatSegBEliminar : Form
    {
        int codigo;
        public MatSegBEliminar()
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
                MatSegEliminar objEliminar = new MatSegEliminar();
                objEliminar.LblNombreA.Text = mats[0]["NombreMat"].ToString();
                objEliminar.LblCodigo.Text = mats[0]["Codigo"].ToString();
                objEliminar.LblMarca.Text = mats[0]["Marca"].ToString();
                objEliminar.LblModelo.Text = mats[0]["Modelo"].ToString();
                objEliminar.LblFechaI.Text = mats[0]["FechaI"].ToString();
                objEliminar.LblFechaS.Text = mats[0]["FechaS"].ToString();
                objEliminar.LblNombreR.Text = mats[0]["NombreRes"].ToString();
                objEliminar.LblEstado.Text = mats[0]["Estado"].ToString();
                objEliminar.LblCantidad.Text = mats[0]["Cantidad"].ToString();
                objEliminar.LblPrecioU.Text = mats[0]["Precio"].ToString();
                this.Hide();
                if (objEliminar.ShowDialog() == DialogResult.OK)
                {
                    MatSegCodigo codigoc = new MatSegCodigo();
                    codigoc.LblCodigo.Text = mats[0]["Codigo"].ToString();
                    mats[0].Delete();
                    matSeg1.TblMatSeg.WriteXml(Application.StartupPath + "\\ArchMatSeg.xml");
                }
                else
                    MessageBox.Show("No se ha eliminado el material de seguridad", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("No se han encontrado datos registrados con ese codigo", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
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
                        MessageBox.Show("El codigo a buscar debe ser mayor a 1", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                        TxtBxCodigo.Text = "";
                    }

                }
                catch
                {
                    MessageBox.Show("El código debe ser númerico", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
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

        private void Mazimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Mazimizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Mazimizar.Visible = true;
        }
    }
}
