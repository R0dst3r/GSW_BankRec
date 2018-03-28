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
    public partial class Worksheet : Form
    {
        public Worksheet()
        {
            InitializeComponent();
        }

        private String cutOffDate;

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

        private Decimal bankAccount;

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






        private void Worksheet_Load(object sender, EventArgs e)
        {

            ReportParameter pCutOffDate = new ReportParameter("CutOffDate", cutOffDate);
            rvWorksheet.LocalReport.SetParameters(new ReportParameter[] { pCutOffDate });

            // TODO: This line of code loads data into the 'dsBankRecords.BankRec' table. You can move, or remove it, as needed.
            this.BankRecTableAdapter.Fill(this.dsBankRecords.BankRec, cutOffDate, bankAccount);
            this.rvWorksheet.RefreshReport();
        }
    }
}
