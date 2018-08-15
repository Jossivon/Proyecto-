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
    public partial class MatSegSalida : Form
    {
        int codigo;
        public MatSegSalida()
        {
            InitializeComponent();
        }

        private void BttBuscar_Click(object sender, EventArgs e)
        {
            matSeg1.TblMatSeg.ReadXml(Application.StartupPath + "\\ArchMatSeg.xml");
            System.Data.DataRow[] mats;

            System.Data.DataRow[] td; 

            mats = matSeg1.TblMatSeg.Select("Codigo='" + TxtBxCodigo.Text + "'");

            if (mats.Length > 0)
            {
                this.Hide();
                MatSegBSalida objModificar = new MatSegBSalida();
                objModificar.LblCExis.Text = mats[0]["Cantidad"].ToString();
                //objModificar.dateTimePicker1.Text = mats[0]["FechaI"].ToString();
                objModificar.LblCodigo.Text = mats[0]["Codigo"].ToString();
                objModificar.LblNombreM.Text = mats[0]["NombreMat"].ToString();
                objModificar.dateTimePicker1.Text = mats[0]["FechaI"].ToString();
                objModificar.DateS.MinDate = objModificar.dateTimePicker1.Value;
                if (objModificar.ShowDialog() == DialogResult.OK)
                {

                    mats[0]["FechaS"] = objModificar.DateS.Text;
                    mats[0]["Cedula"] = objModificar.TxtBxCedula.Text;
                    mats[0]["Cantidad"] = objModificar.LblCanN.Text;
                    mats[0]["Nombre"] = objModificar.LblNombre.Text;
                    mats[0]["Apellido"] = objModificar.LblApellido.Text;

                    mats[0].AcceptChanges();
                    matSeg1.TblMatSeg.WriteXml(Application.StartupPath + "\\ArchMatSeg.xml");
                    MessageBox.Show("Se ha guardado con ÉXITO la salida del material de seguridad", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha guardado ninguna salidad del material de seguridad", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

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
                        MessageBox.Show("El código debe ser mayor a cero", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                        TxtBxCodigo.Text = "";
                    }


                }

                catch
                {
                    MessageBox.Show("El código debe ser un valor númerico", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    TxtBxCodigo.Text = "";
                }
            }
        }
    }
}
