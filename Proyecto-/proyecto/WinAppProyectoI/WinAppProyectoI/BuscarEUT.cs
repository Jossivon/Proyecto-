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
    public partial class BuscarEUT : Form
    {
        public BuscarEUT()
        {
            InitializeComponent();
        }

        private void BttBuscar_Click(object sender, EventArgs e)
        {
            matSeg1.TblOficina.ReadXml(Application.StartupPath + "\\ArchOficina.xml");

            System.Data.DataRow[] matu;

            matu = matSeg1.TblOficina.Select("Codigo='" + TxtBxCodigo.Text + "'");

            if (matu.Length > 0)
            {
                MostrarElU objEliminar = new MostrarElU();
                objEliminar.LblNombre.Text = matu[0]["Nombre"].ToString();
                objEliminar.LblCodigo.Text = matu[0]["Codigo"].ToString();
                objEliminar.LblFechaI.Text = matu[0]["FechaI"].ToString();
                objEliminar.LblFechaS.Text = matu[0]["FechaS"].ToString();
                objEliminar.LblNombreR.Text = matu[0]["NombreR"].ToString();
                objEliminar.LblCantidad.Text = matu[0]["Cantidad"].ToString();
                objEliminar.LblPrecioU.Text = matu[0]["Precio"].ToString();

                if (objEliminar.ShowDialog() == DialogResult.OK)
                {
                    matu[0].Delete();
                    matSeg1.TblOficina.WriteXml(Application.StartupPath + "\\ArchOficina.xml");
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
    }
}
