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
            this.bankRecstmtsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBankStatements = new BankReconciliations.dsBankStatements();
            this.tboxCreditsAmount = new System.Windows.Forms.TextBox();
            this.tboxDebitsAmount = new System.Windows.Forms.TextBox();
            this.tboxEndingBalance = new System.Windows.Forms.TextBox();
            this.tboxAverageLedger = new System.Windows.Forms.TextBox();
            this.tboxAverageCollected = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPreviousBalance = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblDebits = new System.Windows.Forms.Label();
            this.lblEndingBalance = new System.Windows.Forms.Label();
            this.lblAverageLedger = new System.Windows.Forms.Label();
            this.lblAverageCollected = new System.Windows.Forms.Label();
            this.tboxCreditsCount = new System.Windows.Forms.TextBox();
            this.tboxDebitsCount = new System.Windows.Forms.TextBox();
            this.tboxClearedBalanceVF = new System.Windows.Forms.TextBox();
            this.lblClearedBalance = new System.Windows.Forms.Label();
            this.lblEoMDate = new System.Windows.Forms.Label();
            this.tboxEndofMonthDate = new System.Windows.Forms.TextBox();
            this.bankRec_stmtsTableAdapter = new BankReconciliations.dsBankStatementsTableAdapters.BankRec_stmtsTableAdapter();
            this.btnLoadStatement = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bankRecstmtsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBankStatements)).BeginInit();
            this.SuspendLayout();
            // 
            // tboxPrevBal
            // 
            this.tboxPrevBal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankRecstmtsBindingSource, "previousBalance", true));
            this.tboxPrevBal.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPrevBal.Location = new System.Drawing.Point(193, 7);
            this.tboxPrevBal.Name = "tboxPrevBal";
            this.tboxPrevBal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tboxPrevBal.Size = new System.Drawing.Size(210, 25);
            this.tboxPrevBal.TabIndex = 1;
            this.tboxPrevBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxPrevBal.WordWrap = false;
            this.tboxPrevBal.Validated += new System.EventHandler(this.CurrencyAmount_Validated);
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
            // tboxCreditsAmount
            // 
            this.tboxCreditsAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankRecstmtsBindingSource, "creditsBalance", true));
            this.tboxCreditsAmount.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCreditsAmount.Location = new System.Drawing.Point(250, 38);
            this.tboxCreditsAmount.Name = "tboxCreditsAmount";
            this.tboxCreditsAmount.Size = new System.Drawing.Size(153, 25);
            this.tboxCreditsAmount.TabIndex = 3;
            this.tboxCreditsAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxCreditsAmount.WordWrap = false;
            this.tboxCreditsAmount.Validated += new System.EventHandler(CurrencyAmount_Validated);
            // 
            // tboxDebitsAmount
            // 
            this.tboxDebitsAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankRecstmtsBindingSource, "debitsBalance", true));
            this.tboxDebitsAmount.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxDebitsAmount.Location = new System.Drawing.Point(250, 69);
            this.tboxDebitsAmount.Name = "tboxDebitsAmount";
            this.tboxDebitsAmount.Size = new System.Drawing.Size(153, 25);
            this.tboxDebitsAmount.TabIndex = 5;
            this.tboxDebitsAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxDebitsAmount.WordWrap = false;
            this.tboxDebitsAmount.Validated += new System.EventHandler(CurrencyAmount_Validated);
            // 
            // tboxEndingBalance
            // 
            this.tboxEndingBalance.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankRecstmtsBindingSource, "statementBalance", true));
            this.tboxEndingBalance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxEndingBalance.Location = new System.Drawing.Point(193, 100);
            this.tboxEndingBalance.Name = "tboxEndingBalance";
            this.tboxEndingBalance.Size = new System.Drawing.Size(210, 25);
            this.tboxEndingBalance.TabIndex = 6;
            this.tboxEndingBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxEndingBalance.WordWrap = false;
            this.tboxEndingBalance.Validated += new System.EventHandler(this.CurrencyAmount_Validated);
            // 
            // tboxAverageLedger
            // 
            this.tboxAverageLedger.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankRecstmtsBindingSource, "averageLedger", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.tboxAverageLedger.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxAverageLedger.Location = new System.Drawing.Point(193, 131);
            this.tboxAverageLedger.Name = "tboxAverageLedger";
            this.tboxAverageLedger.Size = new System.Drawing.Size(210, 25);
            this.tboxAverageLedger.TabIndex = 7;
            this.tboxAverageLedger.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxAverageLedger.WordWrap = false;
            this.tboxAverageLedger.Validated += new System.EventHandler(this.CurrencyAmount_Validated);
            // 
            // tboxAverageCollected
            // 
            this.tboxAverageCollected.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankRecstmtsBindingSource, "averageCollected", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.tboxAverageCollected.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxAverageCollected.Location = new System.Drawing.Point(193, 162);
            this.tboxAverageCollected.Name = "tboxAverageCollected";
            this.tboxAverageCollected.Size = new System.Drawing.Size(210, 25);
            this.tboxAverageCollected.TabIndex = 8;
            this.tboxAverageCollected.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxAverageCollected.WordWrap = false;
            this.tboxAverageCollected.Validated += new System.EventHandler(this.CurrencyAmount_Validated);
            // 
            // btnSubmit
            // 
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSubmit.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(253, 255);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(72, 27);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(331, 255);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 27);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblPreviousBalance
            // 
            this.lblPreviousBalance.AutoSize = true;
            this.lblPreviousBalance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviousBalance.Location = new System.Drawing.Point(48, 9);
            this.lblPreviousBalance.Name = "lblPreviousBalance";
            this.lblPreviousBalance.Size = new System.Drawing.Size(135, 20);
            this.lblPreviousBalance.TabIndex = 20;
            this.lblPreviousBalance.Text = "Previous Balance:";
            this.lblPreviousBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredits.Location = new System.Drawing.Point(55, 39);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(128, 20);
            this.lblCredits.TabIndex = 21;
            this.lblCredits.Text = "Deposits/Credits:";
            this.lblCredits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDebits
            // 
            this.lblDebits.AutoSize = true;
            this.lblDebits.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebits.Location = new System.Drawing.Point(69, 71);
            this.lblDebits.Name = "lblDebits";
            this.lblDebits.Size = new System.Drawing.Size(114, 20);
            this.lblDebits.TabIndex = 22;
            this.lblDebits.Text = "Checks/Debits:";
            this.lblDebits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEndingBalance
            // 
            this.lblEndingBalance.AutoSize = true;
            this.lblEndingBalance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndingBalance.Location = new System.Drawing.Point(60, 102);
            this.lblEndingBalance.Name = "lblEndingBalance";
            this.lblEndingBalance.Size = new System.Drawing.Size(123, 20);
            this.lblEndingBalance.TabIndex = 23;
            this.lblEndingBalance.Text = "Ending Balance:";
            this.lblEndingBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAverageLedger
            // 
            this.lblAverageLedger.AutoSize = true;
            this.lblAverageLedger.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageLedger.Location = new System.Drawing.Point(55, 133);
            this.lblAverageLedger.Name = "lblAverageLedger";
            this.lblAverageLedger.Size = new System.Drawing.Size(128, 20);
            this.lblAverageLedger.TabIndex = 24;
            this.lblAverageLedger.Text = "Average Ledger:";
            this.lblAverageLedger.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAverageCollected
            // 
            this.lblAverageCollected.AutoSize = true;
            this.lblAverageCollected.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageCollected.Location = new System.Drawing.Point(38, 163);
            this.lblAverageCollected.Name = "lblAverageCollected";
            this.lblAverageCollected.Size = new System.Drawing.Size(145, 20);
            this.lblAverageCollected.TabIndex = 25;
            this.lblAverageCollected.Text = "Average Collected:";
            this.lblAverageCollected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxCreditsCount
            // 
            this.tboxCreditsCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankRecstmtsBindingSource, "creditsCount", true));
            this.tboxCreditsCount.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCreditsCount.Location = new System.Drawing.Point(193, 38);
            this.tboxCreditsCount.Name = "tboxCreditsCount";
            this.tboxCreditsCount.Size = new System.Drawing.Size(53, 25);
            this.tboxCreditsCount.TabIndex = 2;
            this.tboxCreditsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxCreditsCount.WordWrap = false;
            // 
            // tboxDebitsCount
            // 
            this.tboxDebitsCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankRecstmtsBindingSource, "debitsCount", true));
            this.tboxDebitsCount.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxDebitsCount.Location = new System.Drawing.Point(193, 69);
            this.tboxDebitsCount.Name = "tboxDebitsCount";
            this.tboxDebitsCount.Size = new System.Drawing.Size(53, 25);
            this.tboxDebitsCount.TabIndex = 4;
            this.tboxDebitsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxDebitsCount.WordWrap = false;
            // 
            // tboxClearedBalanceVF
            // 
            this.tboxClearedBalanceVF.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankRecstmtsBindingSource, "clearedBalanceVF", true));
            this.tboxClearedBalanceVF.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxClearedBalanceVF.Location = new System.Drawing.Point(193, 193);
            this.tboxClearedBalanceVF.Name = "tboxClearedBalanceVF";
            this.tboxClearedBalanceVF.Size = new System.Drawing.Size(210, 25);
            this.tboxClearedBalanceVF.TabIndex = 9;
            this.tboxClearedBalanceVF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.tboxClearedBalanceVF, resources.GetString("tboxClearedBalanceVF.ToolTip"));
            this.tboxClearedBalanceVF.WordWrap = false;
            this.tboxClearedBalanceVF.Validated += new System.EventHandler(this.CurrencyAmount_Validated);
            // 
            // lblClearedBalance
            // 
            this.lblClearedBalance.AutoSize = true;
            this.lblClearedBalance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClearedBalance.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblClearedBalance.Location = new System.Drawing.Point(19, 194);
            this.lblClearedBalance.Name = "lblClearedBalance";
            this.lblClearedBalance.Size = new System.Drawing.Size(164, 20);
            this.lblClearedBalance.TabIndex = 26;
            this.lblClearedBalance.Text = "Cleared Balance (VF):";
            this.lblClearedBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.lblClearedBalance, resources.GetString("lblClearedBalance.ToolTip"));
            // 
            // lblEoMDate
            // 
            this.lblEoMDate.AutoSize = true;
            this.lblEoMDate.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEoMDate.Location = new System.Drawing.Point(35, 225);
            this.lblEoMDate.Name = "lblEoMDate";
            this.lblEoMDate.Size = new System.Drawing.Size(148, 20);
            this.lblEoMDate.TabIndex = 27;
            this.lblEoMDate.Text = "End of Month Date:";
            this.lblEoMDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxEndofMonthDate
            // 
            this.tboxEndofMonthDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankRecstmtsBindingSource, "eomDate", true));
            this.tboxEndofMonthDate.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxEndofMonthDate.Location = new System.Drawing.Point(193, 224);
            this.tboxEndofMonthDate.Name = "tboxEndofMonthDate";
            this.tboxEndofMonthDate.Size = new System.Drawing.Size(210, 25);
            this.tboxEndofMonthDate.TabIndex = 10;
            this.tboxEndofMonthDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxEndofMonthDate.WordWrap = false;
            // 
            // bankRec_stmtsTableAdapter
            // 
            this.bankRec_stmtsTableAdapter.ClearBeforeFill = true;
            // 
            // btnLoadStatement
            // 
            this.btnLoadStatement.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLoadStatement.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLoadStatement.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadStatement.Location = new System.Drawing.Point(12, 255);
            this.btnLoadStatement.Name = "btnLoadStatement";
            this.btnLoadStatement.Size = new System.Drawing.Size(232, 27);
            this.btnLoadStatement.TabIndex = 11;
            this.btnLoadStatement.Text = "Load PDF of Statement for Review";
            this.btnLoadStatement.UseVisualStyleBackColor = false;
            this.btnLoadStatement.Click += new System.EventHandler(this.btnLoadStatement_Click);
            // 
            // BankStatementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 289);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLoadStatement);
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
            this.Controls.Add(this.lblEoMDate);
            this.Controls.Add(this.tboxPrevBal);
            this.Controls.Add(this.lblClearedBalance);
            this.Controls.Add(this.lblAverageCollected);
            this.Controls.Add(this.lblAverageLedger);
            this.Controls.Add(this.lblEndingBalance);
            this.Controls.Add(this.lblDebits);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.lblPreviousBalance);
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
        private System.Windows.Forms.Label lblPreviousBalance;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label lblDebits;
        private System.Windows.Forms.Label lblEndingBalance;
        private System.Windows.Forms.Label lblAverageLedger;
        private System.Windows.Forms.Label lblAverageCollected;
        private System.Windows.Forms.TextBox tboxCreditsCount;
        private System.Windows.Forms.TextBox tboxDebitsCount;
        private dsBankStatements dsBankStatements;
        private System.Windows.Forms.BindingSource bankRecstmtsBindingSource;
        private dsBankStatementsTableAdapters.BankRec_stmtsTableAdapter bankRec_stmtsTableAdapter;
        private System.Windows.Forms.TextBox tboxClearedBalanceVF;
        private System.Windows.Forms.Label lblClearedBalance;
        private System.Windows.Forms.Label lblEoMDate;
        protected internal System.Windows.Forms.TextBox tboxEndofMonthDate;
        private System.Windows.Forms.Button btnLoadStatement;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}