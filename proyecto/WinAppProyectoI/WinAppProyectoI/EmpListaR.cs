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
    public partial class EmpListaR : Form
    {
        public EmpListaR()
        {
            InitializeComponent();
        }

        private void EmpListaR_Load(object sender, EventArgs e)
        {
            MatSeg.TblEmpleados.ReadXml(Application.StartupPath + "\\ArchEmpleados.xml");
            this.reportViewer1.RefreshReport();
        }
    }
}
