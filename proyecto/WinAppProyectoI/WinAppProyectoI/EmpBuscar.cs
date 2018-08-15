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
    public partial class EmpBuscar : Form
    {
        public EmpBuscar()
        {
            InitializeComponent();
        }

        private void BttBuscar_Click(object sender, EventArgs e)
        {
            matSeg1.ReadXml(Application.StartupPath + "\\ArchEmpleados.xml");
            System.Data.DataRow[] datos;

            datos = matSeg1.TblEmpleados.Select("Cedula='" + TxtBxCedula.Text + "'");
            EmpMostrar buscar = new EmpMostrar();

            if (datos.Length > 0)
            {
                this.Hide();
                buscar.LblNombre.Text = datos[0]["Nombre"].ToString();
                buscar.LblCedula.Text = datos[0]["Cedula"].ToString();
                buscar.LblApellido.Text = datos[0]["Apellido"].ToString();
                buscar.LblFechaI.Text = datos[0]["FechaI"].ToString();
                buscar.LblCargo.Text = datos[0]["Cargo"].ToString();
                buscar.LblLugar.Text = datos[0]["Provincia"].ToString();
                buscar.LblCiudad.Text = datos[0]["Ciudad"].ToString();
                buscar.LblEdad.Text = datos[0]["Edad"].ToString();
                buscar.ShowDialog();

            }
            else
            {
                MessageBox.Show("No se ha encontrado ningun empleado registrado con el número de cédula ingresado", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                TxtBxCedula.Text = "";
            }
        }

        private void TxtBxCedul_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                int lim = 10;
                int res;
                string Cedula = TxtBxCedula.Text;
                char[] num = Cedula.ToArray();

                if (num.Length == 10)
                {
                    ClCedula objVerificar = new ClCedula(num, lim);
                    res = objVerificar.Verificar();
                    if (res > 0)
                    {
                        BttBuscar.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Cédula Incorrecta");
                        TxtBxCedula.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Cedula con mayor a 10 dígitos, INCORRECTO");
                    TxtBxCedula.Text = "";
                }
            }
        }
    }
}
