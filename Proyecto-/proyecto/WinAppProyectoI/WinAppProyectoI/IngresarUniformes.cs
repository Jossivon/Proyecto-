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
    public partial class IngresarUniformes : Form
    {
        int codigo;
        double precio;
        int cant;
        string estado,fecha,fechas;
        public IngresarUniformes()
        {
            InitializeComponent();
        }

        private void IngresarUniformes_Load(object sender, EventArgs e)
        {

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
                            txtbQuienRecibe.Focus();
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

        private void txtbQuienRecibe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter) ;
            {

                if (txtbQuienRecibe.Text == "")
                {
                    MessageBox.Show("Datos ingresado vacio, ingrese un nombre del material de seguridad");
                    txtbQuienRecibe.Text = "";
                }
                else
                {
                    txtbPrecioUnitario.Focus();
                }
            }
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
            if (e.KeyChar == (Char)Keys.Enter) ;
            {

                if (txtbNombre.Text == "")
                {
                    MessageBox.Show("Datos ingresado vacio, ingrese un nombre del material de seguridad");
                    txtbNombre.Text = "";
                }
                else
                {
                    date.Focus();
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

        private void dates_ValueChanged(object sender, EventArgs e)
        {
            fechas = dates.Text;
            btnGuardar.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //matSeg1.TblUniformes.WriteXml(Application.StartupPath + "\\ArchUniformes.xml");

            matSeg1.ReadXml(Application.StartupPath + "\\ArchUniformes.xml");

            object[] vector = new object[10];
            vector[0] = txtbNombre.Text;
            vector[1] = TxtBxCodigo.Text;
            vector[2] = txtbPrecioUnitario.Text;
            vector[3] = txtbCantidad.Text;
            vector[4] = CbxTalla.Text;
            vector[5] = CbxEstado.Text;
            vector[6] = txtbQuienRecibe.Text;
            vector[7] = date.Text;
            vector[8] = dates.Text;
            vector[9] = (cant * precio).ToString();

            System.Data.DataRow[] Datos;

            Datos = matSeg1.TblMatSeg.Select("Codigo='" + TxtBxCodigo.Text + "'");

            if (Datos.Length > 0)
            {
                MessageBox.Show("El material de seguridad ya esta registrado");
                this.Close();

            }
            else
            {
                matSeg1.TblMatSeg.Rows.Add(vector);
                matSeg1.WriteXml(Application.StartupPath + "\\ArchMatSeg.xml");
                MessageBox.Show("Se ha guardado exitosamente", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
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
                    CbxEstado.Focus();
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
            dates.MinDate = date.Value;
            dates.Focus();
        }


    }
}
