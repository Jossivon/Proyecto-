namespace WinAppProyectoI
{
    partial class EmpListaR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MatSeg = new WinAppProyectoI.MatSeg();
            this.TblEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matSeg1 = new WinAppProyectoI.MatSeg();
            ((System.ComponentModel.ISupportInitialize)(this.MatSeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblEmpleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matSeg1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.TblEmpleadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WinAppProyectoI.EmpLista.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // MatSeg
            // 
            this.MatSeg.DataSetName = "MatSeg";
            this.MatSeg.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TblEmpleadosBindingSource
            // 
            this.TblEmpleadosBindingSource.DataMember = "TblEmpleados";
            this.TblEmpleadosBindingSource.DataSource = this.MatSeg;
            // 
            // matSeg1
            // 
            this.matSeg1.DataSetName = "MatSeg";
            this.matSeg1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EmpListaR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "EmpListaR";
            this.Text = "EmpListaR";
            this.Load += new System.EventHandler(this.EmpListaR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MatSeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblEmpleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matSeg1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TblEmpleadosBindingSource;
        private MatSeg MatSeg;
        private MatSeg matSeg1;
    }
}