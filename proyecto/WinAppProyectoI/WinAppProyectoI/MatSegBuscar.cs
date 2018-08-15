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
    public partial class MatSegBuscar : Form
    {
        int codigo;
        public MatSegBuscar()
        {
            InitializeComponent();
        }

        private void BttBuscar_Click(object sender, EventArgs e)
        {
            matSeg1.ReadXml(Application.StartupPath +"\\ArchMatSeg.xml");
            System.Data.DataRow[] datos;

            datos = matSeg1.TblMatSeg.Select("Codigo='" + TxtBxCodigo.Text + "'");
            MatSegMostrar buscar = new MatSegMostrar();

            if (datos.Length > 0)
            {
                this.Hide();
                buscar.LblNombreA.Text = datos[0]["NombreMat"].ToString();
                buscar.LblCodigo.Text = datos[0]["Codigo"].ToString();
                buscar.LblMarca.Text = datos[0]["Marca"].ToString();
                buscar.LblModelo.Text = datos[0]["Modelo"].ToString();
                buscar.LblFechaI.Text = datos[0]["FechaI"].ToString();
                buscar.LblFechaS.Text = datos[0]["FechaS"].ToString();
                buscar.LblNombreR.Text = datos[0]["Cedula"].ToString();
                buscar.LblEstado.Text = datos[0]["Estado"].ToString();
                buscar.LblCantidad.Text = datos[0]["Cantidad"].ToString();
                buscar.LblPrecioU.Text = datos[0]["Precio"].ToString();
                buscar.ShowDialog();

            }
            else
            {
                MessageBox.Show("No se ha encontrado ningun material de seguridad registrado con el código"+TxtBxCodigo.Text, "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                TxtBxCodigo.Text = "";
            }
        }

        private void TxtBxCodigo_TextChanged(object sender, EventArgs e)
        {
            
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
                        MessageBox.Show("Ingrese números mayores a 0", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TxtBxCodigo.Text = "";
                    }
                }
                catch
                {
                    MessageBox.Show("Ingrese solo números positivos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void LblTxtCodigo_Click(object sender, EventArgs e)
        {

        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
