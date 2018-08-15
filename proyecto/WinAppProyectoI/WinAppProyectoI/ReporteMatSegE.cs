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
    public partial class ReporteMatSegE : Form
    {
        public ReporteMatSegE()
        {
            InitializeComponent();
        }

        private void ReporteMatSegF_Load(object sender, EventArgs e)
        {
            MatSeg.TblMatSeg.ReadXml(Application.StartupPath + "\\ArchMatSeg.xml");
            this.reportViewer1.RefreshReport();
        }
    }
}
