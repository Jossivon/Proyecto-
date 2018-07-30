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
            UniformeIngresar ingresar = new UniformeIngresar();
            ingresar.ShowDialog();
        }

        private void BttBuscar_Click(object sender, EventArgs e)
        {
            BuscarUni buscar = new BuscarUni();
            buscar.ShowDialog();
        }

        private void BttModificar_Click(object sender, EventArgs e)
        {
            BuscarUnifM modificar = new BuscarUnifM();
            modificar.ShowDialog();
        }

        private void BttEliminar_Click(object sender, EventArgs e)
        {
            BuscarEUNI eliminar = new BuscarEUNI();
            eliminar.ShowDialog();
        }
    }
}
