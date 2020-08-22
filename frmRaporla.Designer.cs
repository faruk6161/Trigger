namespace Trigger
{
    partial class frmRaporla
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
            this.satisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TriggerOrnek2DataSet = new Trigger.TriggerOrnek2DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.satisTableAdapter = new Trigger.TriggerOrnek2DataSetTableAdapters.satisTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.satisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TriggerOrnek2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // satisBindingSource
            // 
            this.satisBindingSource.DataMember = "satis";
            this.satisBindingSource.DataSource = this.TriggerOrnek2DataSet;
            // 
            // TriggerOrnek2DataSet
            // 
            this.TriggerOrnek2DataSet.DataSetName = "TriggerOrnek2DataSet";
            this.TriggerOrnek2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.satisBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Trigger.SatisRaporla.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(540, 445);
            this.reportViewer1.TabIndex = 0;
            // 
            // satisTableAdapter
            // 
            this.satisTableAdapter.ClearBeforeFill = true;
            // 
            // frmRaporla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 445);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRaporla";
            this.Text = "frmRaporla";
            this.Load += new System.EventHandler(this.frmRaporla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.satisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TriggerOrnek2DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource satisBindingSource;
        private TriggerOrnek2DataSet TriggerOrnek2DataSet;
        private TriggerOrnek2DataSetTableAdapters.satisTableAdapter satisTableAdapter;
    }
}