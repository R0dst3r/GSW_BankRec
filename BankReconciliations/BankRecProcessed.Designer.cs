namespace BankReconciliations
{
    partial class BankRecProcessed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankRecProcessed));
            this.dsBankRecords = new BankReconciliations.dsBankRecords();
            this.BankRecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BankRecTableAdapter = new BankReconciliations.dsBankRecordsTableAdapters.BankRecTableAdapter();
            this.rvBankRecProcessed = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dsBankRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankRecBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dsBankRecords
            // 
            this.dsBankRecords.DataSetName = "dsBankRecords";
            this.dsBankRecords.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BankRecBindingSource
            // 
            this.BankRecBindingSource.DataMember = "BankRec";
            this.BankRecBindingSource.DataSource = this.dsBankRecords;
            // 
            // BankRecTableAdapter
            // 
            this.BankRecTableAdapter.ClearBeforeFill = true;
            // 
            // rvBankRecProcessed
            // 
            this.rvBankRecProcessed.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsProcessed";
            reportDataSource1.Value = this.BankRecBindingSource;
            this.rvBankRecProcessed.LocalReport.DataSources.Add(reportDataSource1);
            this.rvBankRecProcessed.LocalReport.ReportEmbeddedResource = "BankReconciliations.report-BankRecProcessed.rdlc";
            this.rvBankRecProcessed.Location = new System.Drawing.Point(0, 0);
            this.rvBankRecProcessed.Name = "rvBankRecProcessed";
            this.rvBankRecProcessed.Size = new System.Drawing.Size(705, 511);
            this.rvBankRecProcessed.TabIndex = 0;
            // 
            // BankRecProcessed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 511);
            this.Controls.Add(this.rvBankRecProcessed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BankRecProcessed";
            this.Text = "Bank Reconciliation - Processed";
            this.Load += new System.EventHandler(this.BankRecProcessed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBankRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankRecBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource BankRecBindingSource;
        private dsBankRecords dsBankRecords;
        private dsBankRecordsTableAdapters.BankRecTableAdapter BankRecTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer rvBankRecProcessed;
    }
}