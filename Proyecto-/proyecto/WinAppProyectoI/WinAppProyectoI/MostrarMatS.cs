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
    public partial class MostrarMatS : Form
    {
        public MostrarMatS()
        {
            InitializeComponent();
        }

        private void BttGuardar_Click(object sender, EventArgs e)
        {
            BttGuardar.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
