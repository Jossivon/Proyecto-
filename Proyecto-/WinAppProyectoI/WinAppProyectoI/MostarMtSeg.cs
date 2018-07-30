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
    public partial class MostarMtSeg : Form
    {
        public MostarMtSeg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            matSeg.Clear();
            matSeg.TblMatSeg.ReadXml(Application.StartupPath + "\\ArchMatSeg.xml");
        }
    }
}
