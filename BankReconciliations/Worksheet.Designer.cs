namespace BankReconciliations
{
    partial class Worksheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Worksheet));
            this.BankRecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBankRecords = new BankReconciliations.dsBankRecords();
            this.rvWorksheet = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BankRecTableAdapter = new BankReconciliations.dsBankRecordsTableAdapters.BankRecTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BankRecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBankRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // BankRecBindingSource
            // 
            this.BankRecBindingSource.DataMember = "BankRec";
            this.BankRecBindingSource.DataSource = this.dsBankRecords;
            // 
            // dsBankRecords
            // 
            this.dsBankRecords.DataSetName = "dsBankRecords";
            this.dsBankRecords.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvWorksheet
            // 
            this.rvWorksheet.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsWorksheet";
            reportDataSource1.Value = this.BankRecBindingSource;
            this.rvWorksheet.LocalReport.DataSources.Add(reportDataSource1);
            this.rvWorksheet.LocalReport.ReportEmbeddedResource = "BankReconciliations.Worksheet.rdlc";
            this.rvWorksheet.Location = new System.Drawing.Point(0, 0);
            this.rvWorksheet.Name = "rvWorksheet";
            this.rvWorksheet.Size = new System.Drawing.Size(741, 556);
            this.rvWorksheet.TabIndex = 0;
            // 
            // BankRecTableAdapter
            // 
            this.BankRecTableAdapter.ClearBeforeFill = true;
            // 
            // Worksheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 556);
            this.Controls.Add(this.rvWorksheet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Worksheet";
            this.Text = "Worksheet";
            this.Load += new System.EventHandler(this.Worksheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BankRecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBankRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvWorksheet;
        private System.Windows.Forms.BindingSource BankRecBindingSource;
        private dsBankRecords dsBankRecords;
        private dsBankRecordsTableAdapters.BankRecTableAdapter BankRecTableAdapter;
    }
}