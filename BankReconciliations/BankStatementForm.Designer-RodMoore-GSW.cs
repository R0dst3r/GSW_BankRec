namespace BankReconciliations
{
    partial class BankStatementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankStatementForm));
            this.tboxPrevBal = new System.Windows.Forms.TextBox();
            this.tboxCreditsAmount = new System.Windows.Forms.TextBox();
            this.tboxDebitsAmount = new System.Windows.Forms.TextBox();
            this.tboxEndingBalance = new System.Windows.Forms.TextBox();
            this.tboxAverageLedger = new System.Windows.Forms.TextBox();
            this.tboxAverageCollected = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxCreditsCount = new System.Windows.Forms.TextBox();
            this.tboxDebitsCount = new System.Windows.Forms.TextBox();
            this.bankRecstmtsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBankStatements = new BankReconciliations.dsBankStatements();
            this.bankRec_stmtsTableAdapter = new BankReconciliations.dsBankStatementsTableAdapters.BankRec_stmtsTableAdapter();
            this.tboxClearedBalanceVF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tboxEndofMonthDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bankRecstmtsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBankStatements)).BeginInit();
            this.SuspendLayout();
            // 
            // tboxPrevBal
            // 
            this.tboxPrevBal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankRecstmtsBindingSource, "previousBalance", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.tboxPrevBal.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPrevBal.Location = new System.Drawing.Point(169, 7);
            this.tboxPrevBal.Name = "tboxPrevBal";
            this.tboxPrevBal.Size = new System.Drawing.Size(215, 25);
            this.tboxPrevBal.TabIndex = 1;
            this.tboxPrevBal.WordWrap = false;
            // 
            // tboxCreditsAmount
            // 
            this.tboxCreditsAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankRecstmtsBindingSource, "creditsBalance", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.tboxCreditsAmount.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCreditsAmount.Location = new System.Drawing.Point(213, 38);
            this.tboxCreditsAmount.Name = "tboxCreditsAmount";
            this.tboxCreditsAmount.Size = new System.Drawing.Size(171, 25);
            this.tboxCreditsAmount.TabIndex = 3;
            this.tboxCreditsAmount.WordWrap = false;
            // 
            // tboxDebitsAmount
            // 
            this.tboxDebitsAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankRecstmtsBindingSource, "debitsBalance", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.tboxDebitsAmount.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxDebitsAmount.Location = new System.Drawing.Point(213, 69);
            this.tboxDebitsAmount.Name = "tboxDebitsAmount";
            this.tboxDebitsAmount.Size = new System.Drawing.Size(171, 25);
            this.tboxDebitsAmount.TabIndex = 5;
            this.tboxDebitsAmount.WordWrap = false;
            // 
            // tboxEndingBalance
            // 
            this.tboxEndingBalance.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankRecstmtsBindingSource, "statementBalance", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.tboxEndingBalance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxEndingBalance.Location = new System.Drawing.Point(169, 100);
            this.tboxEndingBalance.Name = "tboxEndingBalance";
            this.tboxEndingBalance.Size = new System.Drawing.Size(215, 25);
            this.tboxEndingBalance.TabIndex = 6;
            this.tboxEndingBalance.WordWrap = false;
            // 
            // tboxAverageLedger
            // 
            this.tboxAverageLedger.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankRecstmtsBindingSource, "averageLedger", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.tboxAverageLedger.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxAverageLedger.Location = new System.Drawing.Point(169, 131);
            this.tboxAverageLedger.Name = "tboxAverageLedger";
            this.tboxAverageLedger.Size = new System.Drawing.Size(215, 25);
            this.tboxAverageLedger.TabIndex = 7;
            this.tboxAverageLedger.WordWrap = false;
            // 
            // tboxAverageCollected
            // 
            this.tboxAverageCollected.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankRecstmtsBindingSource, "averageCollected", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.tboxAverageCollected.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxAverageCollected.Location = new System.Drawing.Point(169, 162);
            this.tboxAverageCollected.Name = "tboxAverageCollected";
            this.tboxAverageCollected.Size = new System.Drawing.Size(215, 25);
            this.tboxAverageCollected.TabIndex = 8;
            this.tboxAverageCollected.WordWrap = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSubmit.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(228, 263);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 27);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(309, 263);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 27);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Previous Balance:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Deposits/Credits:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Checks/Debits:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ending Balance:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Average Ledger:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Average Collected:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxCreditsCount
            // 
            this.tboxCreditsCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankRecstmtsBindingSource, "creditsCount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.tboxCreditsCount.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCreditsCount.Location = new System.Drawing.Point(169, 38);
            this.tboxCreditsCount.Name = "tboxCreditsCount";
            this.tboxCreditsCount.Size = new System.Drawing.Size(36, 25);
            this.tboxCreditsCount.TabIndex = 2;
            this.tboxCreditsCount.WordWrap = false;
            // 
            // tboxDebitsCount
            // 
            this.tboxDebitsCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankRecstmtsBindingSource, "debitsCount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.tboxDebitsCount.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxDebitsCount.Location = new System.Drawing.Point(169, 69);
            this.tboxDebitsCount.Name = "tboxDebitsCount";
            this.tboxDebitsCount.Size = new System.Drawing.Size(36, 25);
            this.tboxDebitsCount.TabIndex = 4;
            this.tboxDebitsCount.WordWrap = false;
            // 
            // bankRecstmtsBindingSource
            // 
            this.bankRecstmtsBindingSource.DataMember = "BankRec_stmts";
            this.bankRecstmtsBindingSource.DataSource = this.dsBankStatements;
            // 
            // dsBankStatements
            // 
            this.dsBankStatements.DataSetName = "dsBankStatements";
            this.dsBankStatements.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankRec_stmtsTableAdapter
            // 
            this.bankRec_stmtsTableAdapter.ClearBeforeFill = true;
            // 
            // tboxClearedBalanceVF
            // 
            this.tboxClearedBalanceVF.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxClearedBalanceVF.Location = new System.Drawing.Point(169, 193);
            this.tboxClearedBalanceVF.Name = "tboxClearedBalanceVF";
            this.tboxClearedBalanceVF.Size = new System.Drawing.Size(215, 25);
            this.tboxClearedBalanceVF.TabIndex = 9;
            this.tboxClearedBalanceVF.WordWrap = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Cleared Balance (VF):";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "End of Month Date:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxEndofMonthDate
            // 
            this.tboxEndofMonthDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankRecstmtsBindingSource, "eomDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.tboxEndofMonthDate.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxEndofMonthDate.Location = new System.Drawing.Point(169, 224);
            this.tboxEndofMonthDate.Name = "tboxEndofMonthDate";
            this.tboxEndofMonthDate.Size = new System.Drawing.Size(215, 25);
            this.tboxEndofMonthDate.TabIndex = 10;
            this.tboxEndofMonthDate.WordWrap = false;
            // 
            // BankStatementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 301);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tboxDebitsCount);
            this.Controls.Add(this.tboxCreditsCount);
            this.Controls.Add(this.tboxEndofMonthDate);
            this.Controls.Add(this.tboxClearedBalanceVF);
            this.Controls.Add(this.tboxAverageCollected);
            this.Controls.Add(this.tboxAverageLedger);
            this.Controls.Add(this.tboxEndingBalance);
            this.Controls.Add(this.tboxDebitsAmount);
            this.Controls.Add(this.tboxCreditsAmount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tboxPrevBal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BankStatementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Statement Form";
            this.Load += new System.EventHandler(this.BankStatementForm_Load);
            this.Shown += new System.EventHandler(this.BankStatementForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bankRecstmtsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBankStatements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxPrevBal;
        private System.Windows.Forms.TextBox tboxCreditsAmount;
        private System.Windows.Forms.TextBox tboxDebitsAmount;
        private System.Windows.Forms.TextBox tboxEndingBalance;
        private System.Windows.Forms.TextBox tboxAverageLedger;
        private System.Windows.Forms.TextBox tboxAverageCollected;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxCreditsCount;
        private System.Windows.Forms.TextBox tboxDebitsCount;
        private dsBankStatements dsBankStatements;
        private System.Windows.Forms.BindingSource bankRecstmtsBindingSource;
        private dsBankStatementsTableAdapters.BankRec_stmtsTableAdapter bankRec_stmtsTableAdapter;
        private System.Windows.Forms.TextBox tboxClearedBalanceVF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tboxEndofMonthDate;

    }
}