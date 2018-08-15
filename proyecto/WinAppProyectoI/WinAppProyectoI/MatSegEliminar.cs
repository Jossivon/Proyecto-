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
    public partial class MatSegEliminar : Form
    {
        public MatSegEliminar()
        {
            InitializeComponent();
        }

        private void BttEliminar_Click(object sender, EventArgs e)
        {
            
            DialogResult opcion;
            opcion = MessageBox.Show("¿Esta seguro que desea eliminar?", "¡AVISO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (opcion == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void BttCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
