﻿using System;
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
    public partial class MatSegCodigo : Form
    {
        public MatSegCodigo()
        {
            InitializeComponent();
        }

        private void BttAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; 
        }

        private void LblTxtTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
