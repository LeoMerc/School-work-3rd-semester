
namespace militar1
{
    partial class Form9
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
            this.SedeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MilitarDataSet = new militar1.MilitarDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SedeTableAdapter = new militar1.MilitarDataSetTableAdapters.SedeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SedeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MilitarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SedeBindingSource
            // 
            this.SedeBindingSource.DataMember = "Sede";
            this.SedeBindingSource.DataSource = this.MilitarDataSet;
            // 
            // MilitarDataSet
            // 
            this.MilitarDataSet.DataSetName = "MilitarDataSet";
            this.MilitarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SedeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "militar1.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // SedeTableAdapter
            // 
            this.SedeTableAdapter.ClearBeforeFill = true;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SedeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MilitarDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SedeBindingSource;
        private MilitarDataSet MilitarDataSet;
        private MilitarDataSetTableAdapters.SedeTableAdapter SedeTableAdapter;
    }
}