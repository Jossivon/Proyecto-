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
    public partial class UniformesIngresar : Form
    {

        int agregar;
        string cd;
        int cont = 0;
        int cant;
        int d;
        int c;
        string fecha,estado;
        double precio, pr;

        private void TxtBxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string Nombre = TxtBxNombre.Text;
                char[] num = Nombre.ToArray();
                d = 0;
                c = 0;
                for (int i = 0; i < num.Length; i++)
                {
                    if ((num[i] >= 65 && num[i] <= 90) || (num[i] >= 97 && num[i] <= 122) || num[i] == 127)
                    {
                       d++;
                    }
                    else
                    {
                        c++;
                    }
                }

                if (c > 0)
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

        private void TxtBxCantidad_TextChanged(object sender, EventArgs e)
        {

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

        private void Date_ValueChanged(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            Date.MaxDate = thisDay;
            TxtBxCantidad.Focus();
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
                        pr = cant * precio;
                        LblPrecioT.Text = pr.ToString();
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

        private void CbxTalla_ValueMemberChanged(object sender, EventArgs e)
        {
            try
            {
                estado = CbxTalla.SelectedItem.ToString();
                if (estado == "")
                {
                    MessageBox.Show("No se ha seleccionado ningun dato", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CbxTalla.Focus();
                }
                else
                    CmBxEstado.Focus();

            }
            catch
            {
                MessageBox.Show("Valores mal ingresados, seleccione los valores en la flecha", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CbxTalla.Text = "";
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

        private void TxtBxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void CbxTalla_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        bool r;


        public UniformesIngresar()
        {
            InitializeComponent();
        }

        private void BttGuardar_Click(object sender, EventArgs e)
        {
            cont = 0;


            if (CmBxEstado.Text == "")
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
                //matSeg1.WriteXml(Application.StartupPath + "\\ArchUniformes.xml");
                matSeg1.ReadXml(Application.StartupPath + "\\ArchUniformes.xml");
                object[] matseg = new object[10];

                matseg[0] = TxtBxNombre.Text;
                matseg[2] = TxtBxPrecio.Text;
                matseg[3] = TxtBxCantidad.Text;
                matseg[4] = CbxTalla.Text;
                matseg[5] = CmBxEstado.Text;
                matseg[7] = Date.Text;
                matseg[9] = LblPrecioT.Text;

                System.Data.DataRow[] talla;
                System.Data.DataRow[] nombre;

                talla = matSeg1.TblUniformes.Select("Talla='" + CbxTalla.Text + "'");
                nombre = matSeg1.TblUniformes.Select("Nombre='" + TxtBxNombre.Text + "'");

                if (talla.Length > 0 && nombre.Length > 0)
                {
                    MessageBox.Show("El Uniforme ya existe solo se puede modificar", "ALERTA", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    LblCodigo.Text = matSeg1.TblUniformes.Rows.Count.ToString();
                    agregar = int.Parse(LblCodigo.Text);
                    agregar++;
                    LblCodigo.Text = agregar.ToString();
                    UniformesCodigo mostrarCodigo = new UniformesCodigo();
                    mostrarCodigo.LblCodigo.Text = agregar.ToString();
                    matSeg1.TblUniformes.Rows.Add(matseg);
                    matSeg1.WriteXml(Application.StartupPath + "\\ArchUniformes.xml");
                    this.Hide();
                    mostrarCodigo.ShowDialog();
                    if (mostrarCodigo.DialogResult == DialogResult.OK)
                    {

                        MessageBox.Show("Se ha guardado exitosamente", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    }
                }
                

            }
        }
    }
}
