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
    public partial class EmpBModificar : Form
    {
        public EmpBModificar()
        {
            InitializeComponent();
        }

        private void TxtBxCedula_KeyPress(object sender, KeyPressEventArgs e)
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
                        TxtBxCedula.ReadOnly = true;
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

        private void BttBuscar_Click(object sender, EventArgs e)
        {
            matSeg1.ReadXml(Application.StartupPath + "\\ArchEmpleados.xml");
            

            System.Data.DataRow[] datos;

            datos = matSeg1.TblEmpleados.Select("Cedula='" + TxtBxCedula.Text + "'");
            
            EmpModificar buscar = new EmpModificar();

            if (datos.Length > 0)
            {
                this.Hide();
                buscar.TxtBxNombre.Text = datos[0]["Nombre"].ToString();
                buscar.TxtBxCedula.Text = datos[0]["Cedula"].ToString();
                buscar.TxtBxApellido.Text = datos[0]["Apellido"].ToString();
                buscar.Date.Text = datos[0]["FechaI"].ToString();
                buscar.CmBxCargo.Text = datos[0]["Cargo"].ToString();
                buscar.CmBxpProvincia.Text = datos[0]["Provincia"].ToString();
                buscar.TxtBxCiudad.Text = datos[0]["Ciudad"].ToString();
                buscar.TxtBxEdad.Text = datos[0]["Edad"].ToString();
                buscar.ShowDialog();

                if (buscar.ShowDialog() == DialogResult.OK)
                {
                    datos[0]["Nombre"] =buscar.TxtBxNombre.Text;
                    datos[0]["Apellido"] = buscar.TxtBxApellido.Text;
                    datos[0]["Cedula"] = buscar.TxtBxCedula.Text;
                    datos[0]["FechaI"] = buscar.Date.Text;
                    datos[0]["Cargo"] = buscar.CmBxCargo.Text;
                    datos[0]["Provincia"] = buscar.CmBxpProvincia.Text;
                    datos[0]["Ciudad"] = buscar.TxtBxCiudad.Text;
                    datos[0]["Edad"] =buscar.TxtBxEdad.Text;
                    datos[0].AcceptChanges();
                    matSeg1.TblEmpleados.WriteXml(Application.StartupPath + "\\ArchEmpleados.xml");
                }
                else
                {
                    MessageBox.Show("No se ha modificado ningún material de seguridad", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("No se ha encontrado ningun empleado registrado con el número de cédula ingresado", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                TxtBxCedula.Text = "";
            }
        }
    }
}
