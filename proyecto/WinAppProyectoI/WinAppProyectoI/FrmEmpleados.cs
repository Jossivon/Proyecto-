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
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void BttIngresar_Click(object sender, EventArgs e)
        {
            EmpIngresar ingresar = new EmpIngresar();
            ingresar.ShowDialog();
        }

        private void BttBuscar_Click(object sender, EventArgs e)
        {
            EmpBuscar buscar = new EmpBuscar();
            buscar.ShowDialog();

        }

        private void BttModificar_Click(object sender, EventArgs e)
        {
            EmpBModificar modificar = new EmpBModificar();
            modificar.ShowDialog();
        }

        private void BttEliminar_Click(object sender, EventArgs e)
        {
            EmpBEliminar eliminar = new EmpBEliminar();
            eliminar.ShowDialog();
        }

        private void BttResporte2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            EmpListaR lista = new EmpListaR();
            lista.ShowDialog();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            if (PnlIzq.Width == 250)
                PnlIzq.Width = 70;
            else
                PnlIzq.Width = 250;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Mazimizar.Visible = true;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mazimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Mazimizar.Visible = false;
            Restaurar.Visible = true;
        }
    }
}
