using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using System.IO;
using Microsoft.Reporting.WinForms;
using System.Diagnostics;
using System.Configuration;

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
        public SqlConnection cnGSW = new SqlConnection(Properties.Settings.Default.ExcaliburConnectionString);
        public SqlConnection cnArchives = new SqlConnection(Properties.Settings.Default.ArchivesConnectionString);
        public decimal bankAccount = 0.0M;
        public string bank = "";
        public string cutOffDate = "";



        private void Form1_Load(object sender, EventArgs e)
        {
            /* Don't need this now, only one bank to work with. Code will still work if another bank is added in the future */
            //ChooseBank cb = new ChooseBank(); 
            //if (cb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    bankAccount = cb.bankAccount;
            //    switch (bankAccount.ToString())
            //    {
            //        case "1112.02":
            //            {
            //                tabBank.Tag = "1112.02";
            //                tabBank.Text = "1112.02 - Centennial Bank - Operating Account";
            //                bank = "Centennial Bank";
            //                break;
            //            }
            //        case  "1112.03":
            //            {
            //                tabBank.Tag = "1112.03";
            //                tabBank.Text = "1112.03 - CityBank - Operating Account";
            //                bank = "CityBank";
            //                break;
            //            }

            ////    }
            //}

            // Forced to Centennial Bank
            tabBank.Tag = "1112.02";
            tabBank.Text = "1112.02 - Centennial Bank - Operating Account";
            bank = "Centennial Bank";

            DataTable dtBanks = new DataTable();

            tsmiArchivedTables.Items.AddRange(GetArchiveTableListing());
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
            progressBar1.Value = 0;
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
                var test = bankRec_stmtsTableAdapter.GetClearedBalanceVF(1112.02m, dtpCutOffDate.Value.ToShortDateString());
                clearedBalance = test != null ? (decimal)test : 0.00m;        // Will have to get from export of PASBR
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

                if (dgvBankRec.Rows[x].Cells["JN"].Value.ToString() == "JE")
                {
                    dgvBankRec.Rows[x].DefaultCellStyle.ForeColor = Color.SteelBlue;
                    dgvBankRec.Rows[x].DefaultCellStyle.BackColor = Color.LightSteelBlue;

                    //if ((Boolean)dgvBankRec.Rows[x].Cells["Cleared"].Value == true)
                    //{
                    //    if (amt < 0)
                    //    {
                    //        credits -= amt;
                    //        cnCounter--;

                    //        itCounter++;
                    //        intransit += amt;
                    //        clearedBalance -= amt;
 
                    //    }
                    //    else
                    //    {
                    //        debits -= amt;
                    //        dnCounter--;

                    //        osCounter++;
                    //        outstanding += amt;
                    //        clearedBalance -= amt;
                    //    }
                    //}
                    //else
                    //{
                    //    if (amt < 0)
                    //    {
                    //        credits += amt;
                    //        cnCounter++;

                    //        itCounter--;
                    //        intransit -= amt;
                    //        clearedBalance += amt;
                    //    }
                    //    else
                    //    {
                    //        debits += amt;
                    //        dnCounter++;

                    //        osCounter--;
                    //        outstanding -= amt;
                    //        clearedBalance += amt;
                    //    }

                    //}
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
                UpdateDifference();
                UpdateStatementBalance();
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
            switch (dgvBankRec.Rows[selectedR].Cells["JN"].Value.ToString())
            {

                case "CD":
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
                        break;
                    }

                case "CR":
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
                        break;
                    }

                //case "JE":
                //    {
                //        if ((Boolean)dgvBankRec.Rows[selectedR].Cells["Cleared"].Value == true)
                //        {
                //            if (amt < 0)
                //            {
                //                credits += amt;
                //                cnCounter++;

                //                itCounter--;
                //                intransit -= amt;
                //                clearedBalance += amt;
                //            }
                //            else
                //            {
                //                debits += amt;
                //                dnCounter++;

                //                osCounter--;
                //                outstanding -= amt;
                //                clearedBalance += amt;
                //            }
                //        }
                //        else
                //        {
                //            if (amt < 0)
                //            {
                //                credits -= amt;
                //                cnCounter--;

                //                itCounter++;
                //                intransit += amt;
                //                clearedBalance -= amt;
                //            }
                //            else
                //            {
                //                debits -= amt;
                //                dnCounter--;

                //                osCounter++;
                //                outstanding += amt;
                //                clearedBalance -= amt;
                //            }
                //        }
                //        break;
                //    }
            }


            // Set difference = statement balance - cleared balance
            UpdateStatementBalance();
            UpdateDifference();
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

        }

        private void tboxStatementBalance_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tboxStatementBalance.Text))
            {
                try
                {
                    UpdateStatementBalance();
                    UpdateDifference();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was a problem: " + ex.Message);
                }
            }

        }

        private void UpdateStatementBalance()
        {
            statementBalance = !String.IsNullOrEmpty(tboxStatementBalance.Text) ? Decimal.Parse(tboxStatementBalance.Text.Replace("$", String.Empty)) : 0.00m;
            tboxStatementBalance.Text = String.Format("{0:$###,##0.00}", statementBalance);
        }


        private void UpdateDifference()
        {
            difference = statementBalance - clearedBalance;
            lblDifferenceVAL.Text = String.Format("{0:$#,##0.00}", difference);
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
            LoadData();
        }

        private void LoadData()
        {
            cutOffDate = dtpCutOffDate.Value.ToShortDateString();
            this.bankRec_stmtsTableAdapter.Fill(this.excaliburDataSet.BankRec_stmts, 1112.02m, cutOffDate);

            if (excaliburDataSet.Tables[0].Rows.Count > 0)
            {
                difference = !String.IsNullOrEmpty(tboxStatementBalance.Text) ? Decimal.Parse(tboxStatementBalance.Text.Replace("$", String.Empty)) : 0.00m;
                dsBankRecords.EnforceConstraints = false;
                this.bankRecTableAdapter2.Fill(this.dsBankRecords.BankRec, cutOffDate, 1112.02m);

                CalcCredsDebts();
                UpdateStatementBalance();
                firstRun = false;
            }
            else
            {
                MessageBox.Show("It appears the data was not put in the database for the statement information. Please check!");
                PrepBankStatementForm();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch tabControl1.SelectedTab
        }

        private void exportToVFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will export ALL cleared items from ALL banks to import into Versaform. Press OK to continue.","Please Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.OK)
            {
                dsBankRecProcessed.Clear();
                dsBankRecProcessed.EnforceConstraints = false;
                bankRecTableAdapter1.Fill(dsBankRecProcessed.BankRec);
                StreamWriter sw = new StreamWriter($@"{Program.pathRoot}\versaform\vf\d8a\imp_br.d8a");

                for (int x = 0; x < dsBankRecProcessed.BankRec.Rows.Count; x++)
                {
                    sw.WriteLine(dsBankRecProcessed.BankRec.Rows[x][0].ToString().Trim());
                }
                sw.Close();
                MessageBox.Show("File written for import!");
            }
        }


        private Object[] GetArchiveTableListing()
        {
            List<string> archiveListings = new List<string>();
            cnArchives.Open();

            SqlCommand cmd = new SqlCommand("[dbo].[ListBankRecArchives]", cnArchives);
            cmd.CommandType = CommandType.StoredProcedure;
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string archiveDate = reader.GetString(0);
                    archiveListings.Add(archiveDate);
                }
            }

            cnArchives.Close();
            return archiveListings.Cast<object>().ToArray();  
        }

        private void printBankRecWorksheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Worksheet worksheet = new Worksheet();
            ReportParameter p = new ReportParameter("CutOffDate", String.Format("{0:MM/dd/yyyy}", dtpCutOffDate.Value));

            worksheet.BankAccount = bankAccount;
            worksheet.CutOffDate = String.Format("{0:MM/dd/yy}", dtpCutOffDate.Value);
            worksheet.Show();
        }

        private void printBankRecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BankRecProcessed brp = new BankRecProcessed();
            brp.Bank = bank;
            brp.CutOffDate = String.Format("{0:MM/dd/yyyy}", dtpCutOffDate.Value);
            brp.Credits = String.Format("{0:C2}", lblCreditsVAL.Text);
            brp.Debits = String.Format("{0:C2}", lblDebitsVAL.Text);
            brp.InTransit = String.Format("{0:C2}", lblInTransitVAL.Text);
            brp.Outstanding = String.Format("{0:C2}", lblOutstandingVAL.Text);
            brp.StatementBalance = String.Format("{0:C2}", Decimal.Parse(tboxStatementBalance.Text.Replace("$", String.Empty)));
            brp.ClearedBalance = String.Format("{0:C2}", lblClearedBalVAL.Text);
            brp.Difference = String.Format("{0:C2}", lblDifferenceVAL.Text);
            brp.BankAccount = bankAccount;
            brp.Show();
        }

        private void archiveBankRecDataToSQLServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             *  Clear the datagridview 
             *  EXEC the sproc for pushing the current bankrec table to Archives with proper timestamp in table name
             */
            if (MessageBox.Show("Are you sure you're ready to archive the BankRec table?", "Please Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                SqlCommand command = new SqlCommand("BankRecArchive", cnGSW);
                command.CommandType = CommandType.StoredProcedure;
                string tableName = "BankRec (" + dtpCutOffDate.Value.ToShortDateString().Replace(@"/", ".") + ")";
                SqlParameter archiveTable = command.Parameters.AddWithValue("@archTable", tableName);
                archiveTable.DbType = DbType.String;
                cnGSW.Open();
                int updateSuccess = command.ExecuteNonQuery(); 
                MessageBox.Show(String.Format("BankRec Table Archived to: {0}", tableName));
                ResetValues();
                cnGSW.Close();
            }
        }

        private void ResetValues()
        {
            lblClearedBalVAL.Text = "";
            lblDifferenceVAL.Text = "";
            lblDebitsVAL.Text = "";
            lblDNVAL.Text = "";
            lblCreditsVAL.Text = "";
            lblCNVAL.Text = "";
            lblOutstandingVAL.Text = "";
            lblOSVAL.Text = "";
            lblInTransitVAL.Text = "";
            lblITVAL.Text = "";
            dnCounter = 0;
            itCounter = 0;
        }

        private void inputBankStatementDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrepBankStatementForm();
        }

        private void PrepBankStatementForm()
        {
            BankStatementForm bsf = new BankStatementForm();
            bsf.cutOffDate = dtpCutOffDate.Value.ToShortDateString();
            bsf.bankAcct = 1112.02m;
            bsf.bankInfo = bank;
            bsf.tboxEndofMonthDate.Text = dtpCutOffDate.Text;

            if (bsf.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Bank Statement Data Added.");
            }

        }

        private void tsmiRevertFromArchive_Click(object sender, EventArgs e)
        {

        }

        private void tsmiImportVFtoSQL_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are you sure you are ready to import data into SQL for processing?

This WILL completely replace any data already in the database.","Please Verify!",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                FileInfo fi = new FileInfo($@"{Program.pathRoot}\Versaform\SQL\BankRec\bankrec.sql");
                if (fi.Exists)
                {
                    MessageBox.Show("Data file found. Ready for processing...");
                    StreamReader fs = new StreamReader(fi.FullName);
                    StringBuilder errMsgs = new StringBuilder();
                    errMsgs.AppendLine("The following records have formatting errors:");
                    int errCount = 0;
                    int count = 0;
                    cnGSW.Open();
                    string cmdText = "DELETE FROM [dbo].[bankrec]";
                    using (SqlCommand cmd = new SqlCommand(cmdText, cnGSW))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    while (!fs.EndOfStream)
                    {
                        string line = fs.ReadLine();
                        if (!String.IsNullOrEmpty(line) && line.Length > 1)
                        {
                            string[] pt = line.Split('|');
                            string parsed = $"('{pt[1]}','{pt[2]}','{pt[3]}','{pt[4]}',{pt[5]},'{pt[6].Replace("'", "")}',{pt[7]},'{DateTime.Now.ToString("MM/dd/yyyy HH:mm")}',0,0)";
                             cmdText = $@"
                                INSERT INTO [dbo].[BankRec]
                                        ([BkAcct]
                                        ,[JN]
                                        ,[RefNum]
                                        ,[RefDate]
                                        ,[Cleared]
                                        ,[Description]
                                        ,[Amount]
                                        ,[dateRecorded]
                                        ,[Processed]
                                        ,[UIClr])
                                    VALUES
                                {parsed}";

                            try
                            {
                                using (SqlCommand cmd = new SqlCommand(cmdText, cnGSW))
                                {
                                    cmd.ExecuteNonQuery();
                                    count++;
                                }
                            }
                            catch
                            {
                                errMsgs.AppendLine(line);
                                errCount++;
                            }

                        }
                    }
                    fs.Close();
                    cnGSW.Close();

                    MessageBox.Show($"Data file ({count} lines) imported successfully.");

                    if (errCount > 0)
                    {
                        MessageBox.Show(errMsgs.ToString());
                    }

                    LoadData();
                }
                else
                {
                    MessageBox.Show("The data file from Versaform does not appear to exist for importing. Please check and run again.");
                }
            }
        }

        private void tsmiArchivedTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            actionsToolStripMenuItem.DropDown.Close();
            if (MessageBox.Show($"You have selected to view archive {tsmiArchivedTables.Text} - is this correct?", "Please Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lblCurrentlyViewing.Text = $"Currently Viewing: {tsmiArchivedTables.Text}";

                // Load data from selected archive
                cnGSW.Open();
                string archiveTable = $"BankRec ({tsmiArchivedTables.Text.TrimStart('0').Replace("/", ".")})";
                bankRecTableAdapter.FillBankRecArchives(excaliburDataSet1.BankRec, archiveTable);
                cnGSW.Close();

                dtpCutOffDate.Value = DateTime.Parse(tsmiArchivedTables.Text.Replace("BankRec (", "").Replace(".", "/").Replace(")",""));
                firstRun = true;
                btnParse.PerformClick();
            }
        }
    }
}
