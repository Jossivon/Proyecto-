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
    public partial class FrmUniforme : Form
    {
        public FrmUniforme()
        {
            InitializeComponent();
        }

        private void BttIngresar_Click(object sender, EventArgs e)
        {
            UniformesIngresar ingresar = new UniformesIngresar();
            ingresar.ShowDialog();
        }

        private void BttBuscar_Click(object sender, EventArgs e)
        {
            UniformeBBuscar buscar = new UniformeBBuscar();
            buscar.ShowDialog();
        }

        private void BttModificar_Click(object sender, EventArgs e)
        {
            UniformesBModificar modificar = new UniformesBModificar();
            modificar.ShowDialog();
        }

        private void BttEliminar_Click(object sender, EventArgs e)
        {
            UniformesBEliminar eliminar = new UniformesBEliminar();
            eliminar.ShowDialog();

        }

        private void BttReporte1_Click(object sender, EventArgs e)
        {
            UniformesBSalida salida = new UniformesBSalida();
            salida.ShowDialog();
        }

        private void BttResporte2_Click(object sender, EventArgs e)
        {
            ReporteeUniFecha fecha = new ReporteeUniFecha();
            fecha.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReporteUniCantdad cantidad = new ReporteUniCantdad();
            cantidad.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReporteuniEstado estado = new ReporteuniEstado();
            estado.ShowDialog();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 250)
                panel1.Width = 70;
            else
                panel1.Width = 250;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MostrarUniformes mostrar = new MostrarUniformes();
            mostrar.ShowDialog();
        }
    }
}
