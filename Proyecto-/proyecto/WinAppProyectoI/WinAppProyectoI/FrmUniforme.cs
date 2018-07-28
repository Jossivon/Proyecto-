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
            FrmIngresarOficina objIngresar = new FrmIngresarOficina();
            objIngresar.ShowDialog();
        }

        private void BttBuscar_Click(object sender, EventArgs e)
        {
            BuscarUt objBuscar = new BuscarUt();
            objBuscar.ShowDialog();
        }

        private void BttModificar_Click(object sender, EventArgs e)
        {
            BuscarModU objModificar = new BuscarModU();
            objModificar.ShowDialog();
        }

        private void BttEliminar_Click(object sender, EventArgs e)
        {
            BuscarEUT objEliminar = new BuscarEUT();
            objEliminar.ShowDialog();

        }
    }
}
