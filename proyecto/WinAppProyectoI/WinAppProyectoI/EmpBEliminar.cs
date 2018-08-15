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
    public partial class EmpBEliminar : Form
    {
        public EmpBEliminar()
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

            matSeg1.ReadXml(Application.StartupPath + "\\ArchMatSeg.xml");
            System.Data.DataRow[] ms;
            matSeg1.ReadXml(Application.StartupPath + "\\ArchOficina.xml");
            System.Data.DataRow[] of;
            matSeg1.ReadXml(Application.StartupPath + "\\ArchUniformes.xml");
            System.Data.DataRow[] uni;

            of = matSeg1.TblOficina.Select("NombreR='" + TxtBxCedula.Text + "'");
            uni = matSeg1.TblUniformes.Select("NombreR='" + TxtBxCedula.Text + "'");
            ms = matSeg1.TblMatSeg.Select("Cedula='" + TxtBxCedula.Text + "'");
            

            datos = matSeg1.TblEmpleados.Select("Cedula='" + TxtBxCedula.Text + "'");
            EmpEliminar buscar = new EmpEliminar();

            if (datos.Length > 0)
            {
                buscar.LblNombre.Text = datos[0]["Nombre"].ToString();
                buscar.LblCedula.Text = datos[0]["Cedula"].ToString();
                buscar.LblApellido.Text = datos[0]["Apellido"].ToString();
                buscar.LblFechaI.Text = datos[0]["FechaI"].ToString();
                buscar.LblCargo.Text = datos[0]["Cargo"].ToString();
                buscar.LblLugar.Text = datos[0]["Provincia"].ToString();
                buscar.LblCiudad.Text = datos[0]["Ciudad"].ToString();
                buscar.LblEdad.Text = datos[0]["Edad"].ToString();
                if (buscar.ShowDialog() == DialogResult.OK)
                {
                    datos[0].Delete();
                    matSeg1.TblEmpleados.WriteXml(Application.StartupPath + "\\ArchEmpleados.xml");
                    MessageBox.Show( "Se ha eliminado el empleado", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    TxtBxCedula.Text = "";

                    
                        if (ms.Length>0)
                        {
                            ms[0]["Cedula"] = "";
                            ms[0].AcceptChanges();
                            matSeg1.TblMatSeg.WriteXml(Application.StartupPath + "\\ArchMatSeg.xml");
                        }

                        if (uni.Length > 0)
                    {
                        uni[0]["Cedula"] = "";
                        uni[0].AcceptChanges();
                        matSeg1.TblUniformes.WriteXml(Application.StartupPath + "\\ArchUniformes.xml");
                    }

                        if (of.Length > 0)
                    {
                        of[0]["Cedula"] = "";
                        of[0].AcceptChanges();
                        matSeg1.TblOficina.WriteXml(Application.StartupPath + "\\ArchOficina.xml");
                    }
                    
                   
                }
                else
                {
                    MessageBox.Show("No se ha eliminado el material de seguridad", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    TxtBxCedula.Text = "";
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
