namespace BankReconciliations
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printBankRecWorksheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printBankRecProcessedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.archiveBankRecDataToSQLServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRevertFromArchive = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiArchivedTables = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.inputBankStatementDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiImportVFtoSQL = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToVFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableStatus = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCreditsVAL = new System.Windows.Forms.Label();
            this.lblDebitsVAL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCNVAL = new System.Windows.Forms.Label();
            this.lblDNVAL = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblOutstandingVAL = new System.Windows.Forms.Label();
            this.lblInTransitVAL = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblITVAL = new System.Windows.Forms.Label();
            this.lblOSVAL = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblClearedBalVAL = new System.Windows.Forms.Label();
            this.bankRecstmtsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.excaliburDataSet = new BankReconciliations.ExcaliburDataSet();
            this.lblDifferenceVAL = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tboxStatementBalance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpCutOffDate = new System.Windows.Forms.DateTimePicker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnParse = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBank = new System.Windows.Forms.TabPage();
            this.dgvBankRec = new System.Windows.Forms.DataGridView();
            this.BRID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BkAcct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cleared = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRecorded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bankRecBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dsBankRecords = new BankReconciliations.dsBankRecords();
            this.excaliburDataSet2 = new BankReconciliations.ExcaliburDataSet2();
            this.bankRec_stmtsTableAdapter = new BankReconciliations.ExcaliburDataSetTableAdapters.BankRec_stmtsTableAdapter();
            this.dsBankRecProcessed = new BankReconciliations.dsBankRecProcessed();
            this.bankRecBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bankRecTableAdapter1 = new BankReconciliations.dsBankRecProcessedTableAdapters.BankRecTableAdapter();
            this.bankRecTableAdapter2 = new BankReconciliations.dsBankRecordsTableAdapters.BankRecTableAdapter();
            this.bankRecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.excaliburDataSet1 = new BankReconciliations.ExcaliburDataSet1();
            this.bankRecTableAdapter = new BankReconciliations.ExcaliburDataSet1TableAdapters.BankRecTableAdapter();
            this.bankRecBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.lblCurrentlyViewing = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankRecstmtsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excaliburDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabBank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankRec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankRecBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBankRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excaliburDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBankRecProcessed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankRecBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankRecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excaliburDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankRecBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printBankRecWorksheetToolStripMenuItem,
            this.printBankRecProcessedToolStripMenuItem,
            this.toolStripSeparator1,
            this.archiveBankRecDataToSQLServerToolStripMenuItem,
            this.tsmiRevertFromArchive,
            this.toolStripSeparator2,
            this.inputBankStatementDataToolStripMenuItem,
            this.tsmiImportVFtoSQL,
            this.exportToVFToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // printBankRecWorksheetToolStripMenuItem
            // 
            this.printBankRecWorksheetToolStripMenuItem.Name = "printBankRecWorksheetToolStripMenuItem";
            this.printBankRecWorksheetToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.printBankRecWorksheetToolStripMenuItem.Text = "Print Bank Rec - Worksheet";
            this.printBankRecWorksheetToolStripMenuItem.Click += new System.EventHandler(this.printBankRecWorksheetToolStripMenuItem_Click);
            // 
            // printBankRecProcessedToolStripMenuItem
            // 
            this.printBankRecProcessedToolStripMenuItem.Name = "printBankRecProcessedToolStripMenuItem";
            this.printBankRecProcessedToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.printBankRecProcessedToolStripMenuItem.Text = "&Print Bank Rec - Processed";
            this.printBankRecProcessedToolStripMenuItem.Click += new System.EventHandler(this.printBankRecToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(259, 6);
            // 
            // archiveBankRecDataToSQLServerToolStripMenuItem
            // 
            this.archiveBankRecDataToSQLServerToolStripMenuItem.Name = "archiveBankRecDataToSQLServerToolStripMenuItem";
            this.archiveBankRecDataToSQLServerToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.archiveBankRecDataToSQLServerToolStripMenuItem.Text = "Archive BankRec Data to SQL Server";
            this.archiveBankRecDataToSQLServerToolStripMenuItem.Click += new System.EventHandler(this.archiveBankRecDataToSQLServerToolStripMenuItem_Click);
            // 
            // tsmiRevertFromArchive
            // 
            this.tsmiRevertFromArchive.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiArchivedTables});
            this.tsmiRevertFromArchive.Name = "tsmiRevertFromArchive";
            this.tsmiRevertFromArchive.Size = new System.Drawing.Size(262, 22);
            this.tsmiRevertFromArchive.Text = "Revert from Archive to Active Table";
            this.tsmiRevertFromArchive.Click += new System.EventHandler(this.tsmiRevertFromArchive_Click);
            // 
            // tsmiArchivedTables
            // 
            this.tsmiArchivedTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tsmiArchivedTables.Name = "tsmiArchivedTables";
            this.tsmiArchivedTables.Size = new System.Drawing.Size(121, 23);
            this.tsmiArchivedTables.SelectedIndexChanged += new System.EventHandler(this.tsmiArchivedTables_SelectedIndexChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(259, 6);
            // 
            // inputBankStatementDataToolStripMenuItem
            // 
            this.inputBankStatementDataToolStripMenuItem.Name = "inputBankStatementDataToolStripMenuItem";
            this.inputBankStatementDataToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.inputBankStatementDataToolStripMenuItem.Text = "Input/View Bank Statement Data";
            this.inputBankStatementDataToolStripMenuItem.Click += new System.EventHandler(this.inputBankStatementDataToolStripMenuItem_Click);
            // 
            // tsmiImportVFtoSQL
            // 
            this.tsmiImportVFtoSQL.Name = "tsmiImportVFtoSQL";
            this.tsmiImportVFtoSQL.Size = new System.Drawing.Size(262, 22);
            this.tsmiImportVFtoSQL.Text = "Import VF BankRec output to SQL";
            this.tsmiImportVFtoSQL.Click += new System.EventHandler(this.tsmiImportVFtoSQL_Click);
            // 
            // exportToVFToolStripMenuItem
            // 
            this.exportToVFToolStripMenuItem.Name = "exportToVFToolStripMenuItem";
            this.exportToVFToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.exportToVFToolStripMenuItem.Text = "&Export Balanced Worksheet To VF";
            this.exportToVFToolStripMenuItem.Click += new System.EventHandler(this.exportToVFToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(259, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tableStatus
            // 
            this.tableStatus.AutoSize = true;
            this.tableStatus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableStatus.BackColor = System.Drawing.Color.Black;
            this.tableStatus.ColumnCount = 10;
            this.tableStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.71503F));
            this.tableStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.28497F));
            this.tableStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.tableStatus.Controls.Add(this.label1, 0, 1);
            this.tableStatus.Controls.Add(this.label2, 0, 2);
            this.tableStatus.Controls.Add(this.lblCreditsVAL, 1, 1);
            this.tableStatus.Controls.Add(this.lblDebitsVAL, 1, 2);
            this.tableStatus.Controls.Add(this.label5, 2, 1);
            this.tableStatus.Controls.Add(this.label6, 2, 2);
            this.tableStatus.Controls.Add(this.lblCNVAL, 3, 1);
            this.tableStatus.Controls.Add(this.lblDNVAL, 3, 2);
            this.tableStatus.Controls.Add(this.label9, 4, 1);
            this.tableStatus.Controls.Add(this.label10, 4, 2);
            this.tableStatus.Controls.Add(this.lblOutstandingVAL, 5, 2);
            this.tableStatus.Controls.Add(this.lblInTransitVAL, 5, 1);
            this.tableStatus.Controls.Add(this.label13, 6, 1);
            this.tableStatus.Controls.Add(this.label14, 6, 2);
            this.tableStatus.Controls.Add(this.lblITVAL, 7, 1);
            this.tableStatus.Controls.Add(this.lblOSVAL, 7, 2);
            this.tableStatus.Controls.Add(this.label17, 8, 1);
            this.tableStatus.Controls.Add(this.label18, 8, 2);
            this.tableStatus.Controls.Add(this.lblClearedBalVAL, 9, 1);
            this.tableStatus.Controls.Add(this.lblDifferenceVAL, 9, 2);
            this.tableStatus.Controls.Add(this.label21, 8, 0);
            this.tableStatus.Controls.Add(this.tboxStatementBalance, 9, 0);
            this.tableStatus.Controls.Add(this.label3, 4, 0);
            this.tableStatus.Controls.Add(this.dtpCutOffDate, 5, 0);
            this.tableStatus.Controls.Add(this.progressBar1, 0, 0);
            this.tableStatus.Controls.Add(this.btnParse, 6, 0);
            this.tableStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableStatus.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableStatus.Location = new System.Drawing.Point(0, 430);
            this.tableStatus.Name = "tableStatus";
            this.tableStatus.RowCount = 3;
            this.tableStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableStatus.Size = new System.Drawing.Size(984, 82);
            this.tableStatus.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Credits";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(23, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Debits";
            // 
            // lblCreditsVAL
            // 
            this.lblCreditsVAL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCreditsVAL.AutoSize = true;
            this.lblCreditsVAL.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditsVAL.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblCreditsVAL.Location = new System.Drawing.Point(184, 36);
            this.lblCreditsVAL.Name = "lblCreditsVAL";
            this.lblCreditsVAL.Size = new System.Drawing.Size(42, 20);
            this.lblCreditsVAL.TabIndex = 1;
            this.lblCreditsVAL.Text = "0.00";
            // 
            // lblDebitsVAL
            // 
            this.lblDebitsVAL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDebitsVAL.AutoSize = true;
            this.lblDebitsVAL.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebitsVAL.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblDebitsVAL.Location = new System.Drawing.Point(184, 62);
            this.lblDebitsVAL.Name = "lblDebitsVAL";
            this.lblDebitsVAL.Size = new System.Drawing.Size(42, 20);
            this.lblDebitsVAL.TabIndex = 1;
            this.lblDebitsVAL.Text = "0.00";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(233, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "CN";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(232, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "DN";
            // 
            // lblCNVAL
            // 
            this.lblCNVAL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCNVAL.AutoSize = true;
            this.lblCNVAL.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNVAL.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblCNVAL.Location = new System.Drawing.Point(291, 36);
            this.lblCNVAL.Name = "lblCNVAL";
            this.lblCNVAL.Size = new System.Drawing.Size(18, 20);
            this.lblCNVAL.TabIndex = 1;
            this.lblCNVAL.Text = "0";
            // 
            // lblDNVAL
            // 
            this.lblDNVAL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDNVAL.AutoSize = true;
            this.lblDNVAL.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNVAL.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblDNVAL.Location = new System.Drawing.Point(291, 62);
            this.lblDNVAL.Name = "lblDNVAL";
            this.lblDNVAL.Size = new System.Drawing.Size(18, 20);
            this.lblDNVAL.TabIndex = 1;
            this.lblDNVAL.Text = "0";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(339, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "In Transit";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(318, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Outstanding";
            // 
            // lblOutstandingVAL
            // 
            this.lblOutstandingVAL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOutstandingVAL.AutoSize = true;
            this.lblOutstandingVAL.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutstandingVAL.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblOutstandingVAL.Location = new System.Drawing.Point(515, 62);
            this.lblOutstandingVAL.Name = "lblOutstandingVAL";
            this.lblOutstandingVAL.Size = new System.Drawing.Size(42, 20);
            this.lblOutstandingVAL.TabIndex = 1;
            this.lblOutstandingVAL.Text = "0.00";
            // 
            // lblInTransitVAL
            // 
            this.lblInTransitVAL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblInTransitVAL.AutoSize = true;
            this.lblInTransitVAL.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInTransitVAL.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblInTransitVAL.Location = new System.Drawing.Point(515, 36);
            this.lblInTransitVAL.Name = "lblInTransitVAL";
            this.lblInTransitVAL.Size = new System.Drawing.Size(42, 20);
            this.lblInTransitVAL.TabIndex = 1;
            this.lblInTransitVAL.Text = "0.00";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.SteelBlue;
            this.label13.Location = new System.Drawing.Point(570, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "IT";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.SteelBlue;
            this.label14.Location = new System.Drawing.Point(564, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "OS";
            // 
            // lblITVAL
            // 
            this.lblITVAL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblITVAL.AutoSize = true;
            this.lblITVAL.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblITVAL.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblITVAL.Location = new System.Drawing.Point(622, 36);
            this.lblITVAL.Name = "lblITVAL";
            this.lblITVAL.Size = new System.Drawing.Size(18, 20);
            this.lblITVAL.TabIndex = 1;
            this.lblITVAL.Text = "0";
            // 
            // lblOSVAL
            // 
            this.lblOSVAL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOSVAL.AutoSize = true;
            this.lblOSVAL.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOSVAL.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblOSVAL.Location = new System.Drawing.Point(622, 62);
            this.lblOSVAL.Name = "lblOSVAL";
            this.lblOSVAL.Size = new System.Drawing.Size(18, 20);
            this.lblOSVAL.TabIndex = 1;
            this.lblOSVAL.Text = "0";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.SteelBlue;
            this.label17.Location = new System.Drawing.Point(666, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(123, 20);
            this.label17.TabIndex = 1;
            this.label17.Text = "Cleared Balance";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.SteelBlue;
            this.label18.Location = new System.Drawing.Point(704, 62);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 20);
            this.label18.TabIndex = 1;
            this.label18.Text = "Difference";
            // 
            // lblClearedBalVAL
            // 
            this.lblClearedBalVAL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblClearedBalVAL.AutoSize = true;
            this.lblClearedBalVAL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankRecstmtsBindingSource, "clearedBalanceVF", true));
            this.lblClearedBalVAL.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClearedBalVAL.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblClearedBalVAL.Location = new System.Drawing.Point(939, 36);
            this.lblClearedBalVAL.Name = "lblClearedBalVAL";
            this.lblClearedBalVAL.Size = new System.Drawing.Size(42, 20);
            this.lblClearedBalVAL.TabIndex = 1;
            this.lblClearedBalVAL.Text = "0.00";
            // 
            // bankRecstmtsBindingSource
            // 
            this.bankRecstmtsBindingSource.DataMember = "BankRec_stmts";
            this.bankRecstmtsBindingSource.DataSource = this.excaliburDataSet;
            // 
            // excaliburDataSet
            // 
            this.excaliburDataSet.DataSetName = "ExcaliburDataSet";
            this.excaliburDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblDifferenceVAL
            // 
            this.lblDifferenceVAL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDifferenceVAL.AutoSize = true;
            this.lblDifferenceVAL.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifferenceVAL.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblDifferenceVAL.Location = new System.Drawing.Point(939, 62);
            this.lblDifferenceVAL.Name = "lblDifferenceVAL";
            this.lblDifferenceVAL.Size = new System.Drawing.Size(42, 20);
            this.lblDifferenceVAL.TabIndex = 1;
            this.lblDifferenceVAL.Text = "0.00";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.SteelBlue;
            this.label21.Location = new System.Drawing.Point(646, 5);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(143, 20);
            this.label21.TabIndex = 1;
            this.label21.Text = "Statement Balance";
            // 
            // tboxStatementBalance
            // 
            this.tboxStatementBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxStatementBalance.BackColor = System.Drawing.Color.DimGray;
            this.tboxStatementBalance.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankRecstmtsBindingSource, "statementBalance", true));
            this.tboxStatementBalance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxStatementBalance.ForeColor = System.Drawing.Color.SkyBlue;
            this.tboxStatementBalance.Location = new System.Drawing.Point(838, 3);
            this.tboxStatementBalance.Name = "tboxStatementBalance";
            this.tboxStatementBalance.Size = new System.Drawing.Size(143, 25);
            this.tboxStatementBalance.TabIndex = 2;
            this.tboxStatementBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxStatementBalance.WordWrap = false;
            this.tboxStatementBalance.TextChanged += new System.EventHandler(this.tboxStatementBalance_TextChanged);
            this.tboxStatementBalance.Leave += new System.EventHandler(this.tboxStatementBalance_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(344, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cut-Off:";
            // 
            // dtpCutOffDate
            // 
            this.dtpCutOffDate.CustomFormat = "";
            this.dtpCutOffDate.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtpCutOffDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCutOffDate.Location = new System.Drawing.Point(416, 3);
            this.dtpCutOffDate.Margin = new System.Windows.Forms.Padding(1, 3, 3, 1);
            this.dtpCutOffDate.Name = "dtpCutOffDate";
            this.dtpCutOffDate.Size = new System.Drawing.Size(104, 25);
            this.dtpCutOffDate.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.tableStatus.SetColumnSpan(this.progressBar1, 2);
            this.progressBar1.Location = new System.Drawing.Point(3, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(204, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Visible = false;
            // 
            // btnParse
            // 
            this.tableStatus.SetColumnSpan(this.btnParse, 2);
            this.btnParse.Location = new System.Drawing.Point(563, 3);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(58, 23);
            this.btnParse.TabIndex = 4;
            this.btnParse.Text = "Load";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBank);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 406);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabBank
            // 
            this.tabBank.Controls.Add(this.dgvBankRec);
            this.tabBank.Location = new System.Drawing.Point(4, 22);
            this.tabBank.Name = "tabBank";
            this.tabBank.Padding = new System.Windows.Forms.Padding(3);
            this.tabBank.Size = new System.Drawing.Size(976, 380);
            this.tabBank.TabIndex = 0;
            this.tabBank.Tag = "1112.03";
            this.tabBank.Text = "1112.03 - City Bank - Operating Account ";
            this.tabBank.UseVisualStyleBackColor = true;
            // 
            // dgvBankRec
            // 
            this.dgvBankRec.AllowUserToAddRows = false;
            this.dgvBankRec.AllowUserToDeleteRows = false;
            this.dgvBankRec.AllowUserToOrderColumns = true;
            this.dgvBankRec.AllowUserToResizeRows = false;
            this.dgvBankRec.AutoGenerateColumns = false;
            this.dgvBankRec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBankRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBankRec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BRID,
            this.BkAcct,
            this.JN,
            this.RefNum,
            this.RefDate,
            this.Cleared,
            this.Description,
            this.Amount,
            this.dateRecorded,
            this.processed});
            this.dgvBankRec.DataSource = this.bankRecBindingSource2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBankRec.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBankRec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBankRec.EnableHeadersVisualStyles = false;
            this.dgvBankRec.Location = new System.Drawing.Point(3, 3);
            this.dgvBankRec.MultiSelect = false;
            this.dgvBankRec.Name = "dgvBankRec";
            this.dgvBankRec.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBankRec.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBankRec.RowHeadersWidth = 71;
            this.dgvBankRec.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBankRec.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBankRec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBankRec.Size = new System.Drawing.Size(970, 374);
            this.dgvBankRec.TabIndex = 3;
            this.dgvBankRec.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBankRec_CellValueChanged);
            this.dgvBankRec.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvBankRec_CurrentCellDirtyStateChanged);
            this.dgvBankRec.Sorted += new System.EventHandler(this.dgvBankRec_Sorted);
            // 
            // BRID
            // 
            this.BRID.DataPropertyName = "BRID";
            this.BRID.HeaderText = "BRID";
            this.BRID.Name = "BRID";
            this.BRID.Visible = false;
            // 
            // BkAcct
            // 
            this.BkAcct.DataPropertyName = "BkAcct";
            this.BkAcct.HeaderText = "BkAcct";
            this.BkAcct.Name = "BkAcct";
            this.BkAcct.Visible = false;
            // 
            // JN
            // 
            this.JN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.JN.DataPropertyName = "JN";
            this.JN.HeaderText = "JN";
            this.JN.Name = "JN";
            this.JN.ReadOnly = true;
            this.JN.Width = 45;
            // 
            // RefNum
            // 
            this.RefNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RefNum.DataPropertyName = "RefNum";
            this.RefNum.HeaderText = "Ref#";
            this.RefNum.Name = "RefNum";
            this.RefNum.ReadOnly = true;
            this.RefNum.Width = 56;
            // 
            // RefDate
            // 
            this.RefDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RefDate.DataPropertyName = "RefDate";
            this.RefDate.HeaderText = "RefDate";
            this.RefDate.Name = "RefDate";
            this.RefDate.ReadOnly = true;
            this.RefDate.Width = 72;
            // 
            // Cleared
            // 
            this.Cleared.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cleared.DataPropertyName = "UIClr";
            this.Cleared.FalseValue = "False";
            this.Cleared.HeaderText = "C";
            this.Cleared.IndeterminateValue = "False";
            this.Cleared.Name = "Cleared";
            this.Cleared.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Cleared.TrueValue = "True";
            this.Cleared.Width = 39;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            this.Amount.DefaultCellStyle = dataGridViewCellStyle1;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.Width = 68;
            // 
            // dateRecorded
            // 
            this.dateRecorded.DataPropertyName = "dateRecorded";
            this.dateRecorded.HeaderText = "dateRecorded";
            this.dateRecorded.Name = "dateRecorded";
            this.dateRecorded.Visible = false;
            // 
            // processed
            // 
            this.processed.DataPropertyName = "Processed";
            this.processed.HeaderText = "Processed";
            this.processed.Name = "processed";
            this.processed.Visible = false;
            // 
            // bankRecBindingSource2
            // 
            this.bankRecBindingSource2.DataMember = "BankRec";
            this.bankRecBindingSource2.DataSource = this.dsBankRecords;
            // 
            // dsBankRecords
            // 
            this.dsBankRecords.DataSetName = "dsBankRecords";
            this.dsBankRecords.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // excaliburDataSet2
            // 
            this.excaliburDataSet2.DataSetName = "ExcaliburDataSet2";
            this.excaliburDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankRec_stmtsTableAdapter
            // 
            this.bankRec_stmtsTableAdapter.ClearBeforeFill = true;
            // 
            // dsBankRecProcessed
            // 
            this.dsBankRecProcessed.DataSetName = "dsBankRecProcessed";
            this.dsBankRecProcessed.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankRecBindingSource1
            // 
            this.bankRecBindingSource1.DataMember = "BankRec";
            this.bankRecBindingSource1.DataSource = this.dsBankRecProcessed;
            // 
            // bankRecTableAdapter1
            // 
            this.bankRecTableAdapter1.ClearBeforeFill = true;
            // 
            // bankRecTableAdapter2
            // 
            this.bankRecTableAdapter2.ClearBeforeFill = true;
            // 
            // bankRecBindingSource
            // 
            this.bankRecBindingSource.DataMember = "BankRec";
            this.bankRecBindingSource.DataSource = this.excaliburDataSet1;
            // 
            // excaliburDataSet1
            // 
            this.excaliburDataSet1.DataSetName = "ExcaliburDataSet1";
            this.excaliburDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankRecTableAdapter
            // 
            this.bankRecTableAdapter.ClearBeforeFill = true;
            // 
            // bankRecBindingSource3
            // 
            this.bankRecBindingSource3.DataMember = "BankRec";
            this.bankRecBindingSource3.DataSource = this.excaliburDataSet1;
            // 
            // lblCurrentlyViewing
            // 
            this.lblCurrentlyViewing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentlyViewing.AutoSize = true;
            this.lblCurrentlyViewing.Location = new System.Drawing.Point(532, 5);
            this.lblCurrentlyViewing.Name = "lblCurrentlyViewing";
            this.lblCurrentlyViewing.Size = new System.Drawing.Size(90, 13);
            this.lblCurrentlyViewing.TabIndex = 3;
            this.lblCurrentlyViewing.Text = "Currently viewing:";
            this.lblCurrentlyViewing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 512);
            this.Controls.Add(this.lblCurrentlyViewing);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tableStatus);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1000, 1280);
            this.MinimumSize = new System.Drawing.Size(1000, 550);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Reconciliations  - Build(03/09/19)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableStatus.ResumeLayout(false);
            this.tableStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankRecstmtsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excaliburDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabBank.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankRec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankRecBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBankRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excaliburDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBankRecProcessed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankRecBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankRecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excaliburDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankRecBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCreditsVAL;
        private System.Windows.Forms.Label lblDebitsVAL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCNVAL;
        private System.Windows.Forms.Label lblDNVAL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblOutstandingVAL;
        private System.Windows.Forms.Label lblInTransitVAL;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblITVAL;
        private System.Windows.Forms.Label lblOSVAL;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblClearedBalVAL;
        private System.Windows.Forms.Label lblDifferenceVAL;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printBankRecProcessedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBank;
        public System.Windows.Forms.DataGridView dgvBankRec;
        private System.Windows.Forms.TextBox tboxStatementBalance;
        private ExcaliburDataSet1 excaliburDataSet1;
        private System.Windows.Forms.BindingSource bankRecBindingSource;
        private ExcaliburDataSet1TableAdapters.BankRecTableAdapter bankRecTableAdapter;
        private ExcaliburDataSet excaliburDataSet;
        private System.Windows.Forms.BindingSource bankRecstmtsBindingSource;
        private ExcaliburDataSetTableAdapters.BankRec_stmtsTableAdapter bankRec_stmtsTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpCutOffDate;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem printBankRecWorksheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToVFToolStripMenuItem;
        private dsBankRecProcessed dsBankRecProcessed;
        private System.Windows.Forms.BindingSource bankRecBindingSource1;
        private dsBankRecProcessedTableAdapters.BankRecTableAdapter bankRecTableAdapter1;
        private dsBankRecords dsBankRecords;
        private System.Windows.Forms.BindingSource bankRecBindingSource2;
        private dsBankRecordsTableAdapters.BankRecTableAdapter bankRecTableAdapter2;
        private System.Windows.Forms.BindingSource bankRecBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn bkAcctDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn refNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn refDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clearedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRecordedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn processedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn uIClrDataGridViewCheckBoxColumn;
        private ExcaliburDataSet2 excaliburDataSet2;
        private System.Windows.Forms.ToolStripMenuItem archiveBankRecDataToSQLServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputBankStatementDataToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn BRID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BkAcct;
        private System.Windows.Forms.DataGridViewTextBoxColumn JN;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Cleared;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRecorded;
        private System.Windows.Forms.DataGridViewCheckBoxColumn processed;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiRevertFromArchive;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripComboBox tsmiArchivedTables;
        private System.Windows.Forms.ToolStripMenuItem tsmiImportVFtoSQL;
        private System.Windows.Forms.Label lblCurrentlyViewing;
    }
}

