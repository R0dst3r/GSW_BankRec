using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

using System.IO;
using Microsoft.Reporting.WinForms;

namespace BankReconciliations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public decimal clearedBalance = 0.00M;
        public decimal statementBalance = 0.00M;
        public decimal difference = 0.00M;
        public decimal outstanding = 0.00M;
        public decimal intransit = 0.00M;
        public decimal debits = 0.00M;
        public decimal credits = 0.00M;
        public decimal amt = 0.00M;
        public int osCounter= 0;
        public int itCounter = 0;
        public int cnCounter = 0;
        public int dnCounter = 0;
        public Boolean firstRun = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dtBanks = new DataTable();
        }

        private void ClearDashboard()
        {
            // Cleans all values, counters 
            cnCounter = 0;
            dnCounter = 0;
            debits = 0.00M;
            credits = 0.00M;

            outstanding = 0.00M;
            osCounter = 0;
            intransit = 0.00M;
            itCounter = 0;
        }


        private void CalcCredsDebts()
        {
            ClearDashboard();

            progressBar1.BackColor = Color.Black;
            progressBar1.ForeColor = Color.SteelBlue;
            progressBar1.Maximum = dgvBankRec.RowCount;
            progressBar1.Minimum = 0;
            progressBar1.Visible = true;

            if (firstRun == true)
            {
                // Set Cleared Balance to EndMonth of the month of CutOff Date
                clearedBalance = (Decimal)bankRec_stmtsTableAdapter.GetClearedBalanceVF(dtpCutOffDate.Value.ToShortDateString());        // Will have to get from export of PASBR
            }

            for (int x = 0; x < dgvBankRec.RowCount; x++)
            {
               amt = (Decimal)dgvBankRec.Rows[x].Cells["Amount"].Value;
                dgvBankRec.Rows[x].HeaderCell.Value = String.Format("{0}", x+1);


                if (amt < 0)
                {
                    //debits += amt;
                    //dnCounter++;
                    dgvBankRec.Rows[x].DefaultCellStyle.ForeColor = Color.Red;                
                }
                else
                {
                    //credits += amt;
                    //cnCounter++;
                    dgvBankRec.Rows[x].DefaultCellStyle.ForeColor = Color.Green;
                }

                if (dgvBankRec.Rows[x].Cells["Description"].Value.ToString().IndexOf("VOIDED") > -1)
                {
                    dgvBankRec.Rows[x].DefaultCellStyle.ForeColor = Color.Gray;
                    dgvBankRec.Rows[x].DefaultCellStyle.BackColor = Color.Black;
                }

                // ---- Calculating CHECKS ----
                if (dgvBankRec.Rows[x].Cells["JN"].Value.ToString() == "CD")
                {
                    // If cleared, add amount to debits and add to debits counter
                    if ((Boolean)dgvBankRec.Rows[x].Cells["Cleared"].Value == true)
                    {
                        debits += amt;
                        dnCounter++;
                    }
                    else
                    {
                        // Add to outstanding balance, subtract from cleared balance
                        osCounter++;
                        outstanding += amt;
                        clearedBalance -= amt;
                    }
                }

                // ---- Calculating DEPOSITS ----
                if (dgvBankRec.Rows[x].Cells["JN"].Value.ToString() == "CR")
                {
                    // If cleared, add amount to credits and add to credits counter
                    if ((Boolean)dgvBankRec.Rows[x].Cells["Cleared"].Value == true)
                    {
                        credits += amt;
                        cnCounter++;
                    }
                    else
                    {
                        // Add to in-transit, subtract from cleared balance
                        itCounter++;
                        intransit += amt;
                        clearedBalance -= amt;
                    }
                }

                // Set difference = statement balance - cleared balance
                difference = statementBalance - clearedBalance;

                UpdateLabels();
                progressBar1.PerformStep();
            }
            progressBar1.Visible = false;
        }

        private void UpdateLabels()
        {
                // Update all the labels
                lblClearedBalVAL.Text = String.Format("{0:C2}", clearedBalance);
                lblDifferenceVAL.Text = String.Format("{0:C2}", difference);

                lblDebitsVAL.Text = String.Format("{0:C2}",debits);
                lblDNVAL.Text = dnCounter.ToString();
                lblCreditsVAL.Text = String.Format("{0:C2}", credits);
                lblCNVAL.Text = cnCounter.ToString();
                lblOutstandingVAL.Text = String.Format("{0:C2}", outstanding);
                lblOSVAL.Text = osCounter.ToString();
                lblInTransitVAL.Text = String.Format("{0:C2}", intransit);
                lblITVAL.Text = itCounter.ToString();
        }


        private void TallyReconciled(int selectedR)
        {
            // Take modified row and adjust calculations accordingly
            amt = (Decimal)dgvBankRec.Rows[selectedR].Cells["Amount"].Value;

            // ---- Calculating CHECKS ----
            if (dgvBankRec.Rows[selectedR].Cells["JN"].Value.ToString() == "CD")
            {
                // If cleared, add amount to debits and add to debits counter
                if ((Boolean)dgvBankRec.Rows[selectedR].Cells["Cleared"].Value == true)
                {
                    debits += amt;
                    dnCounter++;

                    osCounter--;
                    outstanding -= amt;
                    clearedBalance += amt;
                }
                else
                {
                    debits -= amt;
                    dnCounter--;


                    // Add to outstanding balance, subtract from cleared balance
                    osCounter++;
                    outstanding += amt;
                    clearedBalance -= amt;
                }
            }

            // ---- Calculating DEPOSITS ----
            if (dgvBankRec.Rows[selectedR].Cells["JN"].Value.ToString() == "CR")
            {

                if ((Boolean)dgvBankRec.Rows[selectedR].Cells["Cleared"].Value == true)
                {
                    credits += amt;
                    cnCounter++;

                    itCounter--;
                    intransit -= amt;
                    clearedBalance += amt;
                }
                else
                {
                    credits -= amt;
                    cnCounter--;

                    itCounter++;
                    intransit += amt;
                    clearedBalance -= amt;
                }
            }

            // Set difference = statement balance - cleared balance
            difference = statementBalance - clearedBalance;

            UpdateLabels();
        }


        private void dgvBankRec_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (firstRun == false)
            {
                try
                {
                    Boolean state = (Boolean)dgvBankRec.SelectedRows[0].Cells["Cleared"].Value;
                    Guid ID = (Guid)dgvBankRec.SelectedRows[0].Cells["BRID"].Value;
                    bankRecTableAdapter.UpdateProcessed(state, ID);
                    TallyReconciled(dgvBankRec.SelectedRows[0].Index);
                }
                catch { }
            }
        }

        private void dgvBankRec_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvBankRec.IsCurrentCellDirty)
            {
                dgvBankRec.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void tboxStatementBalance_TextChanged(object sender, EventArgs e)
        {
            try
            {
                statementBalance = Decimal.Parse(tboxStatementBalance.Text);
                UpdateDifference();
            }
            catch
            {
                MessageBox.Show("There was a problem.");
            }
        }

        private void UpdateDifference()
        {
            difference = statementBalance + clearedBalance;
            lblDifferenceVAL.Text = String.Format("{0:C2}", difference);
        }


        private void dgvBankRec_Sorted(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            firstRun = true;
            CalcCredsDebts();
            firstRun = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
           // MessageBox.Show(dgvBankRec.RowHeadersWidth.ToString());
        }


        private void btnParse_Click(object sender, EventArgs e)
        {
            string cutOffDate =  dtpCutOffDate.Value.ToShortDateString();
            this.bankRec_stmtsTableAdapter.Fill(this.excaliburDataSet.BankRec_stmts, cutOffDate);
            difference = Decimal.Parse(tboxStatementBalance.Text);
            //bankRecTableAdapter.Fill(excaliburDataSet1.BankRec, cutOffDate);
            dsBankRecords.EnforceConstraints = false;
            this.bankRecTableAdapter2.Fill(this.dsBankRecords.BankRec, cutOffDate);

           CalcCredsDebts();

            firstRun = false;
        }

        private void printBankRecWorksheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Worksheet worksheet = new Worksheet();
            ReportParameter p = new ReportParameter("CutOffDate", String.Format("{0:MM/dd/yyyy}",dtpCutOffDate.Value));
            //SetParameters(new ReportParameter[] { p });
            worksheet.cutOffDate = String.Format("{0:MM/dd/yy}",dtpCutOffDate.Value);
            worksheet.Show();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch tabControl1.SelectedTab
        }

        private void exportToVFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bankRecTableAdapter1.Fill(dsBankRecProcessed.BankRec);
            StreamWriter sw = new StreamWriter(@"\\10.0.0.51\edrive\vf\d8a\imp_br.d8a");

            for (int x = 0; x < dsBankRecProcessed.BankRec.Rows.Count; x++)
            {
                sw.WriteLine(dsBankRecProcessed.BankRec.Rows[x][0].ToString().Trim());
            }
            sw.Close();
            MessageBox.Show("File written for import!");

        }

        private void printBankRecToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
