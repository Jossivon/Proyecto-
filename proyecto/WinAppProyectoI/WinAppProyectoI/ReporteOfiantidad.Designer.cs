namespace WinAppProyectoI
{
    partial class ReporteOfiantidad
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TblOficinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MatSeg = new WinAppProyectoI.MatSeg();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.TblOficinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatSeg)).BeginInit();
            this.SuspendLayout();
            // 
            // TblOficinaBindingSource
            // 
            this.TblOficinaBindingSource.DataMember = "TblOficina";
            this.TblOficinaBindingSource.DataSource = this.MatSeg;
            // 
            // MatSeg
            // 
            this.MatSeg.DataSetName = "MatSeg";
            this.MatSeg.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TblOficinaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WinAppProyectoI.OEstado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReporteOfiantidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteOfiantidad";
            this.Text = "ReporteOfiantidad";
            this.Load += new System.EventHandler(this.ReporteOfiantidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TblOficinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatSeg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TblOficinaBindingSource;
        private MatSeg MatSeg;
    }
}