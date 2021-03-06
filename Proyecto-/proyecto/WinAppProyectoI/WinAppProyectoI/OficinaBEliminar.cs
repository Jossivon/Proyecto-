﻿using System;
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
    public partial class OficinaBEliminar : Form
    {
        int codigo;

        public OficinaBEliminar()
        {
            InitializeComponent();
        }

        private void BttBuscar_Click(object sender, EventArgs e)
        {
            matSeg1.TblOficina.ReadXml(Application.StartupPath + "\\ArchOficina.xml");

            System.Data.DataRow[] matu;

            matu = matSeg1.TblOficina.Select("Codigo='" + TxtBxCodigo.Text + "'");

            if (matu.Length > 0)
            {
                this.Hide();
                OficinaEliminar objEliminar = new OficinaEliminar();
                objEliminar.LblNombre.Text = matu[0]["Nombre"].ToString();
                objEliminar.LblCodigo.Text = matu[0]["Codigo"].ToString();
                objEliminar.LblFechaI.Text = matu[0]["FechaI"].ToString();
                objEliminar.LblFechaS.Text = matu[0]["FechaS"].ToString();
                objEliminar.LblNombreR.Text = matu[0]["NombreR"].ToString();
                objEliminar.LblCantidad.Text = matu[0]["Cantidad"].ToString();
                objEliminar.LblPrecioU.Text = matu[0]["Precio"].ToString();

                if (objEliminar.ShowDialog() == DialogResult.OK)
                {
                    matu[0].Delete();
                    matSeg1.TblOficina.WriteXml(Application.StartupPath + "\\ArchOficina.xml");
                }
                else
                    MessageBox.Show("No se ha eliminado el material de seguridad", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se han encontrado datos registrados con ese codigo", "AVISO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }

        }

        private void TxtBxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                try
                {
                    codigo = int.Parse(TxtBxCodigo.Text);
                    if (codigo > 0)
                    {
                        BttBuscar.Focus();
                    }
                    else
                    {
                        MessageBox.Show("El código debe ser mayor a cero", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                        TxtBxCodigo.Text = "";
                    }
                }
                catch
                {
                    MessageBox.Show("No se ha encontrado ningun material de oficina", "¡AVISO!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    TxtBxCodigo.Text = "";
                }

            }
        }
    }
}
