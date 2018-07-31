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
    }
}
