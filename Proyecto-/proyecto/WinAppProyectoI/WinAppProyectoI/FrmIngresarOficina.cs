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
    public partial class FrmIngresarOficina : Form
    {
        int cant,codigo;
        double precio;
        string fecha,fechas;


        public FrmIngresarOficina()
        {
            InitializeComponent();
        }

        private void TxtBxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (Char)Keys.Enter);
            {
                if (TxtBxNombre.Text == "")
                {
                    MessageBox.Show("Datos ingresado vacio, ingrese un nombre del material de oficina");
                    TxtBxNombre.Text = "";
                }
                else
                {
                    TxtBxCodigo.Focus();
                }
            }
        }

        private void TxtBxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    try
                    {
                        codigo = int.Parse(TxtBxCodigo.Text);
                        if (codigo > 0)
                        {
                            Date.Focus();
                        }
                        else
                        {
                            MessageBox.Show("El código debe ser un valor positivo", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            TxtBxCodigo.Text = "";
                        }
                    }
                    catch
                    {
                        MessageBox.Show("El código ingresado debe ser númerico", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TxtBxCodigo.Text = "";
                    }
                }
            }
        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {
            DateS.MinDate = Date.Value;
            DateS.Focus();
        }

        private void Date2_ValueChanged(object sender, EventArgs e)
        {
            fechas = DateS.Text;
            TxtBxNombreUsuario.Focus();
        }

        private void TxtBxNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    TxtBxCantidad.Focus();
                }
        }

        private void TxtBxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                try
                {
                    precio = double.Parse(TxtBxPrecio.Text);
                    if (precio > 0)
                    {
                        BttGuardar.Focus();
                    }
                    else
                    {
                        MessageBox.Show("El precio debe ser un valor positivo", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TxtBxPrecio.Text = "";
                    }

                }
                catch
                {
                    MessageBox.Show("El precio debe ser un valor númerico", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtBxPrecio.Text = "";
                }
            }
        }

        private void BttGuardar_Click(object sender, EventArgs e)
        {
           
            matSeg1.ReadXml(Application.StartupPath + "\\ArchOficina.xml");
            object[] matseg = new object[8];

            matseg[0] = TxtBxNombre.Text;
            matseg[1] = codigo;
            matseg[2] = Date.Text;
            matseg[3] = DateS.Text;
            matseg[4] = TxtBxCantidad.Text;
            matseg[5] = TxtBxPrecio.Text;
            matseg[6] = TxtBxNombreUsuario.Text;
            matseg[7] = cant * precio;


            System.Data.DataRow[] Datos;

            Datos = matSeg1.TblOficina.Select("Codigo='" + TxtBxCodigo.Text + "'");

            if (Datos.Length > 0)
            {
                MessageBox.Show("El material de seguridad ya esta registrado");
                this.Close();

            }
            else
            {
                matSeg1.TblOficina.Rows.Add(matseg);
                matSeg1.WriteXml(Application.StartupPath + "\\ArchOficina.xml");
                MessageBox.Show("Se ha guardado exitosamente", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void TxtBxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                try
                {
                    cant = int.Parse(TxtBxCantidad.Text);
                    if (cant > 0)
                    {
                        TxtBxPrecio.Focus();
                    }
                    else
                    {
                        MessageBox.Show("La cantidad debe ser mayor a 1", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TxtBxCantidad.Text = "";
                    }
                }
                catch
                {
                    MessageBox.Show("La cantidad debe ser un valor númerico", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtBxCantidad.Text = "";
                }

            }
        }

        private void Date_ValueChanged_1(object sender, EventArgs e)
        {
            fecha = Date.Text;
            DateS.MinDate = Date.Value;
            DateS.Focus();
        }


    }
}
