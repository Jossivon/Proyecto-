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
    public partial class FrmMatSeg : Form
    {
        public FrmMatSeg()
        {
            InitializeComponent();
        }

        private void BttIngresar_Click(object sender, EventArgs e)
        {
            MatSegIngresar matSeguridad = new MatSegIngresar();
            matSeguridad.ShowDialog();
        }

        private void BttBuscar_Click(object sender, EventArgs e)
        {
            MatSegBuscar buscar = new MatSegBuscar();
            buscar.ShowDialog();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            if (PnlIzq.Width == 250)
                PnlIzq.Width = 70;
            else
                PnlIzq.Width = 250;
        }

        private void Mazimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Mazimizar.Visible = false;
            Restaurar.Visible = true;
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

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BttModificar_Click(object sender, EventArgs e)
        {
            MatSegBEliminar objEliminar = new MatSegBEliminar();
            objEliminar.ShowDialog();
        }

        private void BttModificar_Click_1(object sender, EventArgs e)
        {
            MatSegBModificar objModificar = new MatSegBModificar();
            objModificar.ShowDialog();
        }

        private void BttReporte1_Click(object sender, EventArgs e)
        {
            MatSegSalida salida = new MatSegSalida();
            salida.ShowDialog();
        }

        private void BttResporte2_Click(object sender, EventArgs e)
        {
            ReporteMatSegF reporte = new ReporteMatSegF();
            reporte.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReporteMatSegCantidad cantida = new ReporteMatSegCantidad();
            cantida.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReporteMatSegFecha fecha = new ReporteMatSegFecha();
            fecha.ShowDialog();
        }
    }
}
