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
    public partial class OficinaBSalida : Form
    {
        int codigo;
            
        public OficinaBSalida()
        {
            InitializeComponent();
        }

        private void BttBuscar_Click(object sender, EventArgs e)
        {
            matSeg1.TblOficina.ReadXml(Application.StartupPath + "\\ArchOficina.xml");
            System.Data.DataRow[] oficina;
            oficina = matSeg1.TblOficina.Select("Codigo='" + TxtBxCodigo.Text + "'");

            if (oficina.Length > 0)
            {
                this.Hide();
                OficinaSalida objModificar = new OficinaSalida();
                objModificar.LblCantidad.Text = oficina[0]["Cantidad"].ToString();
                //objModificar.LblTxtFechaE.Text = mats[0]["FechaI"].ToString();
                objModificar.LblCodigo.Text = oficina[0]["Codigo"].ToString();
                objModificar.LblNombreO.Text = oficina[0]["Nombre"].ToString();
                objModificar.date.Text = oficina[0]["FechaI"].ToString();
                objModificar.dates.MinDate = objModificar.date.Value;
                if (objModificar.ShowDialog() == DialogResult.OK)
                {

                    oficina[0]["FechaS"] = objModificar.date.Text;
                    oficina[0]["NombreR"] = objModificar.TxtBxNombreUsuario.Text;
                    oficina[0]["Cantidad"] = objModificar.LblC.Text;
                    oficina[0]["Nom"] = objModificar.LblNombre.Text;
                    oficina[0]["Apellido"] = objModificar.LblApellid.Text;
                    oficina[0].AcceptChanges();
                    matSeg1.TblOficina.WriteXml(Application.StartupPath + "\\ArchOficina.xml");
                    MessageBox.Show("Se ha guardado con ÉXITO la salida del material de oficina", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se ha guardado ninguna salidad del material de oficina", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

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
    }
}
