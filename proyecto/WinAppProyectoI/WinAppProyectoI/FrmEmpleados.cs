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
    }
}
