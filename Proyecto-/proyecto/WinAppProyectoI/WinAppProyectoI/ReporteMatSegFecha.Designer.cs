﻿namespace WinAppProyectoI
{
    partial class ReporteMatSegFecha
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MatSeg = new WinAppProyectoI.MatSeg();
            this.TblMatSegBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MatSeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblMatSegBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TblMatSegBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WinAppProyectoI.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(753, 392);
            this.reportViewer1.TabIndex = 0;
            // 
            // MatSeg
            // 
            this.MatSeg.DataSetName = "MatSeg";
            this.MatSeg.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TblMatSegBindingSource
            // 
            this.TblMatSegBindingSource.DataMember = "TblMatSeg";
            this.TblMatSegBindingSource.DataSource = this.MatSeg;
            // 
            // ReporteMatSegFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 404);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteMatSegFecha";
            this.Text = "ReporteMatSegFecha";
            this.Load += new System.EventHandler(this.ReporteMatSegFecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MatSeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblMatSegBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TblMatSegBindingSource;
        private MatSeg MatSeg;
    }
}