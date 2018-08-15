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
        int cant;
        double precio,preciot;
        string fecha;
        int cont,r,a;
        int agregar = 0;

        public OficinaIngresar()
        {
            InitializeComponent();
        }

        private void TxtBxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string Nombre = TxtBxNombre.Text;
                char[] num = Nombre.ToArray();
                r = 0;
                a = 0;
                for (int i = 0; i < num.Length; i++)
                {
                    if ((num[i] >= 65 && num[i] <= 90) || (num[i] >= 97 && num[i] <= 122) || num[i] == 127)
                    {
                        r++;
                    }
                    else
                    {
                        a++;
                    }
                }

                if (a > 0)
                {
                    MessageBox.Show("Ingrese solo letras");
                    TxtBxNombre.Text = "";
                }
                else
                {
                    Date.Focus();
                }
            }
        }


     

        private void TxtBxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                try
                {
                    precio = double.Parse(TxtBxPrecio.Text);
                    if (precio > 0 && precio<1000)
                    {
                        preciot = precio * cant;
                        LblPrecioT.Text = preciot.ToString();
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
                MessageBox.Show("No se ha registrado ningun nombre del material de seguridad ", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                TxtBxNombre.Focus();
                cont++;
            }
            
           
            if (TxtBxCantidad.Text == "")
            {
                MessageBox.Show("No se ha registrado ninguna cantidad", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                TxtBxCantidad.Focus();
                cont++;
            }
            if (TxtBxPrecio.Text == "")
            {
                MessageBox.Show("No se ha registrado ningun precio", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                TxtBxCantidad.Focus();
                cont++;
            }



           if (cont == 0)
            {
               
                matSeg1.ReadXml(Application.StartupPath + "\\ArchOficina.xml");
                object[] oficina = new object[8];

                oficina[0] = TxtBxNombre.Text;
                oficina[2] = Date.Text;
                oficina[4] = TxtBxCantidad.Text;
                oficina[5] = TxtBxPrecio.Text;
                oficina[7] = LblPrecioT.Text;


                LblTxtCodigo.Text = matSeg1.TblOficina.Rows.Count.ToString();
                agregar = int.Parse(LblTxtCodigo.Text);
                /*if (agregar == 99)
                {
                    MessageBox.Show("Ya no se podran ingresar mas datos o se ELIMINAR todos ", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                }

                */
                agregar++;

                LblTxtCodigo.Text = agregar.ToString();
                OficinaCodigo mostrarCodigo = new OficinaCodigo();
                mostrarCodigo.LblCodigo.Text = agregar.ToString();

                matSeg1.TblOficina.Rows.Add(oficina);
                matSeg1.WriteXml(Application.StartupPath + "\\ArchOficina.xml");
                this.Hide();
                mostrarCodigo.ShowDialog();
                if (mostrarCodigo.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Se ha guardado exitosamente", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                }


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
                    if (cant > 0 && cant<1000)
                    {
                        TxtBxPrecio.Focus();
                    }
                    else
                    {
                        MessageBox.Show("La cantidad debe ser mayor a 1 y menor a 1000", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            DateTime thisDay = DateTime.Today;
           
            Date.MaxDate = thisDay;
            TxtBxCantidad.Focus();
        }


    }
}
