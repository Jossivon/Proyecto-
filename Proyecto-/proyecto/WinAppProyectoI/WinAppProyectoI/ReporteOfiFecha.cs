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
    public partial class ReporteOfiFecha : Form
    {
        public ReporteOfiFecha()
        {
            InitializeComponent();
        }

        private void ReporteOfiFecha_Load(object sender, EventArgs e)
        {
            MatSeg.TblOficina.ReadXml(Application.StartupPath + "\\ArchOficina.xml");
            this.reportViewer1.RefreshReport();
        }
    }
}
