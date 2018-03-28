using System;
using System.Windows.Forms;
using System.IO;

namespace BankReconciliations
{
    public partial class BankStatementForm : Form
    {
        public BankStatementForm()
        {
            InitializeComponent();
        }

        public string bankInfo = "";
        public decimal bankAcct = 0.00M;
        public string cutOffDate = "";

        private void BankStatementForm_Shown(object sender, EventArgs e)
        {
            tboxPrevBal.Focus();

            if (bankAcct == 1112.02M)
            {
                tboxAverageCollected.Enabled = false;
                tboxAverageLedger.Enabled = false;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            decimal averageLedger = 0.00M;
            decimal averageCollected = 0.00M;
            if (tboxAverageLedger.Text != "")
            {
                averageLedger = Decimal.Parse(tboxAverageLedger.Text.Replace('$',' ').TrimStart(' '));
            }

            if (tboxAverageCollected.Text != "")
            {
                averageCollected = Decimal.Parse(tboxAverageCollected.Text.Replace('$', ' ').TrimStart(' '));
            }

            this.bankRec_stmtsTableAdapter.DeleteQuery(tboxEndofMonthDate.Text);

            decimal endingBalance_SQL = Decimal.Parse(tboxEndingBalance.Text.Replace("$", "").Replace(",", ""));

            decimal clearedBalance_SQL = 0.00M;
            if (tboxClearedBalanceVF.Text.Contains("("))
            {
                clearedBalance_SQL *= -1;
            }
            else
            {
                clearedBalance_SQL = Decimal.Parse(tboxClearedBalanceVF.Text.Replace("$", "").Replace(",", "").Replace("(", "").Replace(")", ""));
            }

            decimal prevBalance_SQL = Decimal.Parse(tboxPrevBal.Text.Replace("$", "").Replace(",", ""));
            int creditsCount_SQL = int.Parse(tboxCreditsCount.Text);
            decimal creditsAmount_SQL = Decimal.Parse(tboxCreditsAmount.Text.Replace("$", "").Replace(",", ""));
            int debitsCount_SQL = int.Parse(tboxDebitsCount.Text);
            decimal debitsAmount_SQL = Decimal.Parse(tboxDebitsAmount.Text.Replace("$", "").Replace(",", ""));

            int SQLResult = this.bankRec_stmtsTableAdapter.InsertQuery(
                bankAcct, 
                endingBalance_SQL,
                bankInfo + " - Operating Account", 
                clearedBalance_SQL,
                tboxEndofMonthDate.Text,
                prevBalance_SQL,                
                creditsCount_SQL, 
                creditsAmount_SQL, 
                debitsCount_SQL, 
                debitsAmount_SQL, 
                averageLedger, 
                averageCollected);

            if (SQLResult == 1)
            {
                MessageBox.Show("Bank Statement Data Entered Successfully.");
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void BankStatementForm_Load(object sender, EventArgs e)
        {
            dsBankStatements.EnforceConstraints = false;
            if (cutOffDate == "") { cutOffDate = DateTime.Now.ToShortDateString(); }
            this.bankRec_stmtsTableAdapter.FillByLastFigures(this.dsBankStatements.BankRec_stmts,cutOffDate,bankAcct);
            try
            {
                bankAcct = Decimal.Parse(dsBankStatements.BankRec_stmts.acctIDColumn.Table.Rows[0]["acctID"].ToString());
            }
            catch
            {
                MessageBox.Show("There was no data to load - please provide on the next pop-up.");
                tboxEndofMonthDate.Text = cutOffDate;
                tboxPrevBal.Text = String.Format("{0:$#,##0.00}", bankRec_stmtsTableAdapter.getPrevBalance());
                decimal endMonthVF = 0.00M;
                StreamReader sr = new StreamReader(@"\\diskstation\versaform\SQL\BankRec\ENDMONTH.TXT");
                endMonthVF = Decimal.Parse(sr.ReadLine());
                tboxClearedBalanceVF.Text = String.Format("{0:$#,##0.00}", endMonthVF);
                tboxCreditsCount.Focus();
                //DialogResult = DialogResult.Abort;
            }

        }

        private void btnLoadStatement_Click(object sender, EventArgs e)
        {
            // Load the open file dialog box for the correct bank to load the scanned PDF
            OpenFileDialog ofdLoadStatement = new OpenFileDialog();
            string bankFolder = "";
            if (bankAcct == 1112.02M) { bankFolder = "Centennial Bank"; }
            ofdLoadStatement.InitialDirectory = @"\\diskstation\accounting\Financial Statements\" + bankFolder + @"\";
            if (ofdLoadStatement.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.Diagnostics.Process.Start(ofdLoadStatement.FileName.ToString());
            }
            this.DialogResult = System.Windows.Forms.DialogResult.None;
        }

        private string FormatCurrency(string tbox)
        {
           return String.Format("{0:$#,##0.00}", Decimal.Parse(tbox.Replace("$", "").Replace(",", "")));
        }


        private void CurrencyAmount_Validated(Object sender, EventArgs e)
        {
            TextBox tboxME = sender as TextBox;
            if (tboxME.Text.Length > 0)
            {
                tboxME.Text = FormatCurrency(tboxME.Text);
            }
        }
    }
}
