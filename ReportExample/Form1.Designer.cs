namespace ReportExample
{
    partial class Form1
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
            this.CDDataSet = new ReportExample.CDDataSet();
            this.NASLOVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NASLOVTableAdapter = new ReportExample.CDDataSetTableAdapters.NASLOVTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NASLOVBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.NASLOVBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportExample.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(810, 244);
            this.reportViewer1.TabIndex = 0;
            // 
            // CDDataSet
            // 
            this.CDDataSet.DataSetName = "CDDataSet";
            this.CDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NASLOVBindingSource
            // 
            this.NASLOVBindingSource.DataMember = "NASLOV";
            this.NASLOVBindingSource.DataSource = this.CDDataSet;
            // 
            // NASLOVTableAdapter
            // 
            this.NASLOVTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 244);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NASLOVBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource NASLOVBindingSource;
        private CDDataSet CDDataSet;
        private CDDataSetTableAdapters.NASLOVTableAdapter NASLOVTableAdapter;
    }
}

