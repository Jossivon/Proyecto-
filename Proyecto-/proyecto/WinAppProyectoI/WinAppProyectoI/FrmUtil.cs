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
    public partial class FrmUtil : Form
    {
        public FrmUtil()
        {
            InitializeComponent();
        }

        private void BttIngresar_Click(object sender, EventArgs e)
        {
            OficinaIngresar oficina = new OficinaIngresar();
            oficina.ShowDialog();
        }

        private void BttBuscar_Click(object sender, EventArgs e)
        {
            OficinaBuscar buscar = new OficinaBuscar();
            buscar.ShowDialog();
        }

        private void BttModificar_Click(object sender, EventArgs e)
        {
            OficinaBModificar modificar = new OficinaBModificar();
            modificar.ShowDialog();
        }

        private void BttEliminar_Click(object sender, EventArgs e)
        {
            OficinaBEliminar eliminar = new OficinaBEliminar();
            eliminar.ShowDialog();
        }

        private void BttSalida_Click(object sender, EventArgs e)
        {
            OficinaBSalida salida = new OficinaBSalida();
            salida.ShowDialog();
        }
    }
}
