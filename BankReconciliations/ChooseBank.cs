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
    public partial class ChooseBank : Form
    {
        public ChooseBank()
        {
            InitializeComponent();
        }
        public decimal bankAccount = 0.0M; 

        private void btnCentennial_Click(object sender, EventArgs e)
        {
            bankAccount = 1112.02M;
        }

        private void btnCityBank_Click(object sender, EventArgs e)
        {
            bankAccount = 1112.03M;
        }

    }
}
