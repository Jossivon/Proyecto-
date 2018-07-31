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
    public partial class UniformesBSalida : Form
    {
        int codigo;

        public UniformesBSalida()
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
                    MessageBox.Show("El código debe ser númerico", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    TxtBxCodigo.Text = "";
                }

            }
        }

        private void BttBuscar_Click(object sender, EventArgs e)
        {
            matSeg1.TblUniformes.ReadXml(Application.StartupPath + "\\ArchUniformes.xml");
            System.Data.DataRow[] oficina;
            oficina = matSeg1.TblUniformes.Select("Codigo='" + TxtBxCodigo.Text + "'");

            if (oficina.Length > 0)
            {
                this.Hide();
                UniformesSalida objModificar = new UniformesSalida();
                objModificar.LblCantidad.Text = oficina[0]["Cantidad"].ToString();
                //objModificar.LblTxtFechaE.Text = mats[0]["FechaI"].ToString();
                objModificar.date.Text = oficina[0]["FechaI"].ToString();
                objModificar.dates.MinDate = objModificar.date.Value;
                if (objModificar.ShowDialog() == DialogResult.OK)
                {

                    oficina[0]["FechaS"] = objModificar.date.Text;
                    oficina[0]["NombreR"] = objModificar.TxtBxNombreUsuario.Text;
                    oficina[0]["Cantidad"] = objModificar.LblC.Text;
                    oficina[0].AcceptChanges();
                    matSeg1.TblUniformes.WriteXml(Application.StartupPath + "\\ArchUniformes.xml");
                    MessageBox.Show("Se ha guardado con ÉXITO la salida de los uniformes", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se ha guardado ninguna salidad de los uniformes", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

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
