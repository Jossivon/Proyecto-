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
    public partial class OficinaIngresar : Form
    {
        int cant,codigo;
        double precio;
        string fecha,fechas;
        int cont;
        

        public OficinaIngresar()
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
                    Date.Focus();
                }
            }
        }

        

        private void Date_ValueChanged(object sender, EventArgs e)
        {

            TxtBxCantidad.Focus();
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
            cont = 0;


            if (TxtBxNombre.Text == "")
            {
                MessageBox.Show("No se ha registrado ningun nombre del material de seguridad ", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                TxtBxNombre.Focus();
                cont++;
            }
            
            /*if (TxtBxCodigo.Text == "")
            {
                MessageBox.Show("No se ha registrado ningun codigo", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                TxtBxCodigo.Focus();
                cont++;
            }*/
            if (TxtBxCantidad.Text == "")
            {
                MessageBox.Show("No se ha registrado ninguna cantidad", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                TxtBxCantidad.Focus();
                cont++;
            }
            if (TxtBxPrecio.Text == "")
            {
                MessageBox.Show("No se ha registrado ningun precio", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                TxtBxCantidad.Focus();
                cont++;
            }



           if (cont == 0)
            {
                matSeg1.ReadXml(Application.StartupPath + "\\ArchOficina.xml");
                object[] matseg = new object[8];

                matseg[0] = TxtBxNombre.Text;
                matseg[1] = codigo;
                matseg[2] = Date.Text;
                matseg[4] = TxtBxCantidad.Text;
                matseg[5] = TxtBxPrecio.Text;
                matseg[7] = cant * precio;




            }


        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Mazimizar.Visible = true;
        }

        private void Mazimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Mazimizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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
            BttGuardar.Focus();
        }


    }
}
