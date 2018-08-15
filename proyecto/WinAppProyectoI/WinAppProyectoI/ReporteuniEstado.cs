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
    public partial class ReporteuniEstado : Form
    {
        public ReporteuniEstado()
        {
            InitializeComponent();
        }

        private void ReporteuniEstado_Load(object sender, EventArgs e)
        {
            MatSeg.TblUniformes.ReadXml(Application.StartupPath + "\\ArchUniformes.xml");
            this.reportViewer1.RefreshReport();
        }
    }
}
