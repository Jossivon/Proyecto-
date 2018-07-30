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
    public partial class UniformeIngresar : Form
    {
        int codigo,agregar;
        double precio;
        int cant;
        int cont = 0;
        string estado,fecha,fechas;
        public UniformeIngresar()
        {
            InitializeComponent();
        }

        private void IngresarUniformes_Load(object sender, EventArgs e)
        {

        }

       

        

        private void txtbPrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                try
                {
                    precio = double.Parse(txtbPrecioUnitario.Text);
                    if (precio > 0)
                    {
                        txtbCantidad.Focus();
                    }
                    else
                    {
                        MessageBox.Show("El precio debe ser un valor positivo", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtbPrecioUnitario.Text = "";
                    }

                }
                catch
                {
                    MessageBox.Show("El precio debe ser un valor númerico", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbPrecioUnitario.Text = "";
                }
            }
        }

        private void txtbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                try
                {
                    cant = int.Parse(txtbCantidad.Text);
                    if (cant > 0)
                    {
                        CbxTalla.Focus();
                    }
                    else
                    {
                        MessageBox.Show("La cantidad debe ser mayor a 1", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtbCantidad.Text = "";
                    }
                }
                catch
                {
                    MessageBox.Show("La cantidad debe ser un valor númerico", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbCantidad.Text = "";
                }

            }
        }

        private void txtbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {

                if (txtbNombre.Text == "")
                {
                    MessageBox.Show("Datos ingresado vacio, ingrese un nombre del material de seguridad");
                    txtbNombre.Text = "";
                }
                else
                {
                    txtbPrecioUnitario.Focus();
                }
            }
        }

        private void CbxTalla_Validated(object sender, EventArgs e)
        {
            try
            {
                estado = CbxTalla.SelectedItem.ToString();
                if (estado == "")
                {
                    MessageBox.Show("No se ha seleccionado ningun dato", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   CbxEstado.Focus();
                }
                else
                    CbxTalla.Focus();
            }
            catch
            {
                MessageBox.Show("Valores mal ingresados, seleccione los valores en la flecha", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CbxTalla.Text = "";
            }
        }

        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cont = 0;
            if (txtbNombre.Text == "")
            {
                MessageBox.Show("El campo de Nombre del Uniformes esta vacio", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                txtbNombre.Focus();
                cont++;

            }

            if (txtbPrecioUnitario.Text == "")
            {
                MessageBox.Show("El campo de Precio Unitario esta vacio", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                txtbPrecioUnitario.Focus();
                cont++;
            }

            if (txtbCantidad.Text == "")
            {
                MessageBox.Show("El campo de Cantidad esta vacio", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                txtbPrecioUnitario.Focus();
                cont++;
            }

            if (CbxEstado.Text == "")
            {
                MessageBox.Show("El campo de Estado esta vacio", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                CbxEstado.Focus();
                cont++;
            }

            if (CbxTalla.Text == "")
            {
                MessageBox.Show("El campo de Talla esta vacio", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                CbxTalla.Focus();
                cont++;
            }


            if (cont == 0)
            {
                matSeg1.ReadXml(Application.StartupPath + "\\ArchUniformes.xml");
                object[] vector = new object[10];

                vector[0] = txtbNombre.Text;
                vector[2] = txtbPrecioUnitario.Text;
                vector[3] = txtbCantidad.Text;
                vector[4] = CbxTalla.Text;
                vector[5] = CbxEstado.Text;
                vector[7] = date.Text;
                vector[9] = (cant * precio).ToString();

                LblCod.Text = matSeg1.TblUniformes.Rows.Count.ToString();
                agregar = int.Parse(LblCod.Text);
                agregar++;
                LblCod.Text = agregar.ToString();
                UniformeCodigo mostrarCodigo = new UniformeCodigo();
                mostrarCodigo.LblCodigo.Text = agregar.ToString();
                matSeg1.TblUniformes.Rows.Add(vector);
                matSeg1.WriteXml(Application.StartupPath + "\\ArchUniformes.xml");
                this.Hide();
                mostrarCodigo.ShowDialog();
                if (mostrarCodigo.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Se ha guardado exitosamente", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                }

                /* if (Datos.Length > 0)
                 {
                     MessageBox.Show("El material de seguridad ya esta registrado");
                     this.Close();

                 }
                 else
                 {
                     matSeg1.TblUniformes.Rows.Add(vector);
                     matSeg1.WriteXml(Application.StartupPath + "\\ArchUniformes.xml");
                     MessageBox.Show("Se ha guardado exitosamente", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                     this.DialogResult = System.Windows.Forms.DialogResult.OK;
                     this.Close();
                 }*/
            }

        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Mazimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Mazimizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Mazimizar.Visible = true;
        }


        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbxEstado_Validated(object sender, EventArgs e)
        {
            try
            {
                estado = CbxEstado.SelectedItem.ToString();
                if (estado == "")
                {
                    MessageBox.Show("No se ha seleccionado ningun dato", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbNombre.Focus();
                }
                else
                    CbxTalla.Focus();
            }
            catch
            {
                MessageBox.Show("Valores mal ingresados, seleccione los valores en la flecha", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CbxEstado.Text = "";
            }
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
            fecha = date.Text;
            CbxEstado.Focus();
        }


    }
}
