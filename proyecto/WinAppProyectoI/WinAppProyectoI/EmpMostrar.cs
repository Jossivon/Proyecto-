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
    public partial class EmpMostrar : Form
    {
        public EmpMostrar()
        {
            InitializeComponent();
        }

        private void BttAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
