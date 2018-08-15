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
    public partial class MatSegIngresar : Form
    {
        int agregar;
        string cd;
        int cont = 0;
        int cant,r,a;
        string fecha,estado;
        double precio,pr;
        int mostrar;


        public MatSegIngresar()
        {
            InitializeComponent();
        }

        private void BttGuardar_Click(object sender, EventArgs e)
        {
            cont = 0;


            if (CmBxEstado.Text== "")
            {
                MessageBox.Show("No se ha registrado ningun dato en estado ", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                //TxtBxCodigo.Focus();
                cont++;
            }
            if (TxtBxNombre.Text == "")
            {
                MessageBox.Show("No se ha registrado ningun nombre del material de seguridad ", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                TxtBxNombre.Focus();
                cont++;
            }
            
            if (CmbBxMarca.Text == "")
            {
                MessageBox.Show("No se ha registrado ninguna marca del material", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                TxtBxNombre.Focus();
                cont++;
            } 
            if (TxtBxModelo.Text == "")
            {
                MessageBox.Show("No se ha registrado ninguna marca del modelo", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                TxtBxNombre.Focus();
                cont++;
            }
            
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
               
                matSeg1.ReadXml(Application.StartupPath + "\\ArchMatSeg.xml");
                object[] matseg = new object[11];
                object[] td = new object[3];

                matseg[0] = TxtBxNombre.Text;
                matseg[2] = CmbBxMarca.Text;
                matseg[3] = TxtBxModelo.Text;
                matseg[4] = Date.Text;
                matseg[7] = TxtBxCantidad.Text;
                matseg[8] = TxtBxPrecio.Text;
                matseg[9] = CmBxEstado.Text;
                matseg[10] = cant * precio;
    
                

                System.Data.DataRow[] nombre;
                System.Data.DataRow[] marca;
                System.Data.DataRow[] modelo;
                nombre = matSeg1.TblMatSeg.Select("NombreMat='" + TxtBxNombre.Text + "'");
                marca = matSeg1.TblMatSeg.Select("Marca='" + CmbBxMarca.Text + "'");
                modelo = matSeg1.TblMatSeg.Select("Modelo='" + TxtBxModelo.Text + "'");
                if (nombre.Length > 0 && marca.Length>0 && modelo.Length>0)
                {
                    MessageBox.Show("El Material de seguridad ya existe solo se puede modificar", "ALERTA", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    LblTxtCodigo.Text = matSeg1.TblMatSeg.Rows.Count.ToString();
                    mostrar = matSeg1.TblMatSeg.Rows.Count;
                    agregar = int.Parse(LblTxtCodigo.Text);
                    agregar++;
                    LblTxtCodigo.Text = agregar.ToString();
                    MatSegCodigo mostrarCodigo = new MatSegCodigo();
                    mostrarCodigo.LblCodigo.Text = agregar.ToString();
                    matSeg1.TblMatSeg.Rows.Add(matseg);
                    matSeg1.WriteXml(Application.StartupPath + "\\ArchMatSeg.xml");
                    this.Hide();
                    mostrarCodigo.ShowDialog();
                    if (mostrarCodigo.DialogResult == DialogResult.OK)
                    {
                        MessageBox.Show("Se ha guardado exitosamente", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    }
                }
                


            }
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
                    CmbBxMarca.Focus();
                }
            }
        }

       
    

        private void TxtBxModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                if (TxtBxModelo.Text == "")
                {
                    MessageBox.Show("Datos ingresado vacio, ingrese un nombre del material de seguridad");
                    TxtBxModelo.Text = "";
                }
                else
                {

                    Date.Focus();
                }

            }
        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            Date.MaxDate = thisDay;
            CmBxEstado.Focus();
        }

        private void TxtBxNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                if (TxtBxModelo.Text == "")
                {
                    MessageBox.Show("Datos ingresado vacio, ingrese un nombre del material de seguridad");
                    TxtBxModelo.Text = "";
                }
                else
                {

                    Date.Focus();
                }
                TxtBxCantidad.Focus();
            }
        }

        private void TxtBxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                try
                {
                    cant = int.Parse(TxtBxCantidad.Text);
                    if (cant > 0 && cant<10000)
                    {
                        TxtBxPrecio.Focus();
                    }
                    else
                    {
                        MessageBox.Show("La cantidad debe ser mayor a 1 y menor a 100", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TxtBxCantidad.Text = "";
                    }
                }
                catch
                {
                    MessageBox.Show("La cantidad debe ser un valor númerico y positivo", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtBxCantidad.Text = "";
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
                    if (precio > 0 && precio <1000)
                    {
                        pr = cant * precio;
                        LblPrecioT.Text = pr.ToString();
                        BttGuardar.Focus();
                    }
                    else
                    {
                        MessageBox.Show("El precio debe ser un valor mayor a 1 y menor a 1000", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TxtBxPrecio.Text = "";
                    }

                }
                catch
                {
                    MessageBox.Show("El precio debe ser un valor númerico y positivo", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtBxPrecio.Text = "";
                }
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmbBxMarca_ValueMemberChanged(object sender, EventArgs e)
        {
            try
            {
                estado = CmBxEstado.SelectedItem.ToString();
                if (estado == "")
                {
                    MessageBox.Show("No se ha seleccionado ningun dato", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CmBxEstado.Focus();
                }
                else
                    TxtBxCantidad.Focus();

            }
            catch
            {
                MessageBox.Show("Valores mal ingresados, seleccione los valores en la flecha", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CmBxEstado.Text = "";
            }
        }

        private void CmBxEstado_ValueMemberChanged(object sender, EventArgs e)
        {
            try
            {
                estado = CmBxEstado.SelectedItem.ToString();
                if (estado == "")
                {
                    MessageBox.Show("No se ha seleccionado ningun dato", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CmBxEstado.Focus();
                }
                else
                    TxtBxCantidad.Focus();

            }
            catch
            {
                MessageBox.Show("Valores mal ingresados, seleccione los valores en la flecha", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CmBxEstado.Text = "";
            }
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

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

       



    }
}
