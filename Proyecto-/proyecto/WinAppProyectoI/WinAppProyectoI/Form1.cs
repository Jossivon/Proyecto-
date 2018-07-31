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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BttMatSeg_Click(object sender, EventArgs e)
        {
            FrmMatSeg MatSeg = new FrmMatSeg();
            MatSeg.ShowDialog();
        }

        private void BttUniformes_Click(object sender, EventArgs e)
        {
            FrmUniforme Uniformes = new FrmUniforme();
            Uniformes.ShowDialog();
        }

        private void BttUtil_Click(object sender, EventArgs e)
        {
            FrmUtil oficina = new FrmUtil();
            oficina.ShowDialog();

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            if (PnlIzq.Width == 305)
                PnlIzq.Width = 60;
            else
                PnlIzq.Width = 305;
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
