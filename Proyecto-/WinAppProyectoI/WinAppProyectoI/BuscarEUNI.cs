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
    public partial class BuscarEUNI : Form
    {
        public BuscarEUNI()
        {
            InitializeComponent();
        }

        private void BttBuscar_Click(object sender, EventArgs e)
        {
            matSeg1.TblUniformes.ReadXml(Application.StartupPath + "\\ArchUniformes.xml");

            System.Data.DataRow[] matu;

            matu = matSeg1.TblUniformes.Select("Codigo='" + TxtBxCodigo.Text + "'");

            if (matu.Length > 0)
            {
                MostrarEliUni objEliminar = new MostrarEliUni();
                objEliminar.LblNombreU.Text = matu[0]["Nombre"].ToString();
                objEliminar.LblCodigoU.Text = matu[0]["Codigo"].ToString();
                objEliminar.FechaI.Text = matu[0]["FechaI"].ToString();
                objEliminar.FechaS.Text = matu[0]["FechaS"].ToString();
                objEliminar.LblNombreR.Text = matu[0]["NombreR"].ToString();
                objEliminar.LblCan.Text = matu[0]["Cantidad"].ToString();
                objEliminar.LblPrecio.Text = matu[0]["Precio"].ToString();

                if (objEliminar.ShowDialog() == DialogResult.OK)
                {
                    matu[0].Delete();
                    MessageBox.Show("Se haeliminado el uniformes", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    matSeg1.TblUniformes.WriteXml(Application.StartupPath + "\\ArchUniformes.xml");
                }
                else
                    MessageBox.Show("No se ha eliminado el uniformes", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se han encontrado datos registrador del uniformes buscado", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }
    }
}
