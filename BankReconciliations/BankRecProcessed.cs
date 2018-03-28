using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace BankReconciliations
{
    public partial class BankRecProcessed : Form
    {
        public BankRecProcessed()
        {
            InitializeComponent();
        }

        private String cutOffDate;
        private String credits;
        private String debits;
        private String intransit;
        private String outstanding;
        private String statementbalance;
        private String clearedbalance;
        private String difference;
        private Decimal bankAccount;
        private String bank;

        public String Bank
        {
            get
            {
                return bank;
            }

            set
            {
                bank = value;
            }
        }


        public Decimal BankAccount
        {
            get
            {
                return bankAccount;
            }

            set
            {
                bankAccount = value;
            }

        }

        public String CutOffDate
        {
            get
            {
                return cutOffDate;
            }

            set
            {
                cutOffDate = value;
            }
        }

        public String Credits
        {
            get
            {
                return credits;
            }

            set
            {
                credits = value;
            }
        }

        public String Debits
        {
            get
            {
                return debits;
            }

            set
            {
                debits = value;
            }
        }

        public String InTransit
        {
            get
            {
                return intransit;
            }

            set
            {
                intransit = value;
            }
        }

        public String Outstanding
        {
            get
            {
                return outstanding;
            }

            set
            {
                outstanding = value;
            }
        }

        public String StatementBalance
        {
            get
            {
                return statementbalance;
            }

            set
            {
                statementbalance = value;
            }
        }

        public String ClearedBalance
        {
            get
            {
                return clearedbalance;
            }

            set
            {
                clearedbalance = value;
            }
        }

        public String Difference
        {
            get
            {
                return difference;
            }

            set
            {
                difference = value;
            }
        }

        private void BankRecProcessed_Load(object sender, EventArgs e)
        {
            this.BankRecTableAdapter.Fill(this.dsBankRecords.BankRec, cutOffDate, bankAccount);

            ReportParameter pBank = new ReportParameter("Bank", bank);
            rvBankRecProcessed.LocalReport.SetParameters(new ReportParameter[] { pBank });

            ReportParameter pCutOffDate = new ReportParameter("CutOffDate", cutOffDate);
            rvBankRecProcessed.LocalReport.SetParameters(new ReportParameter[] { pCutOffDate });

            ReportParameter pCredits = new ReportParameter("Credits", credits);
            rvBankRecProcessed.LocalReport.SetParameters(new ReportParameter[] { pCredits });

            ReportParameter pDebits = new ReportParameter("Debits", debits);
            rvBankRecProcessed.LocalReport.SetParameters(new ReportParameter[] { pDebits });
            
            ReportParameter pInTransit = new ReportParameter("InTransit", intransit);
            rvBankRecProcessed.LocalReport.SetParameters(new ReportParameter[] { pInTransit });

            ReportParameter pOutstanding = new ReportParameter("Outstanding", outstanding);
            rvBankRecProcessed.LocalReport.SetParameters(new ReportParameter[] { pOutstanding });

            ReportParameter pStatementBalance = new ReportParameter("StatementBalance", statementbalance);
            rvBankRecProcessed.LocalReport.SetParameters(new ReportParameter[] { pStatementBalance });

            ReportParameter pClearedBalance = new ReportParameter("ClearedBalance", clearedbalance);
            rvBankRecProcessed.LocalReport.SetParameters(new ReportParameter[] { pClearedBalance });

            ReportParameter pDifference = new ReportParameter("Difference", difference);
            rvBankRecProcessed.LocalReport.SetParameters(new ReportParameter[] { pDifference });

            this.rvBankRecProcessed.RefreshReport();
        }
    }
}
