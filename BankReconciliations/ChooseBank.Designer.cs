namespace BankReconciliations
{
    partial class ChooseBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseBank));
            this.btnCentennial = new System.Windows.Forms.Button();
            this.btnCityBank = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCentennial
            // 
            this.btnCentennial.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCentennial.Image = ((System.Drawing.Image)(resources.GetObject("btnCentennial.Image")));
            this.btnCentennial.Location = new System.Drawing.Point(10, 34);
            this.btnCentennial.Name = "btnCentennial";
            this.btnCentennial.Size = new System.Drawing.Size(109, 103);
            this.btnCentennial.TabIndex = 0;
            this.btnCentennial.Tag = "1112.02";
            this.btnCentennial.UseVisualStyleBackColor = true;
            this.btnCentennial.Click += new System.EventHandler(this.btnCentennial_Click);
            // 
            // btnCityBank
            // 
            this.btnCityBank.BackColor = System.Drawing.Color.White;
            this.btnCityBank.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCityBank.Image = ((System.Drawing.Image)(resources.GetObject("btnCityBank.Image")));
            this.btnCityBank.Location = new System.Drawing.Point(125, 34);
            this.btnCityBank.Name = "btnCityBank";
            this.btnCityBank.Size = new System.Drawing.Size(109, 103);
            this.btnCityBank.TabIndex = 1;
            this.btnCityBank.Tag = "1112.03";
            this.btnCityBank.UseVisualStyleBackColor = false;
            this.btnCityBank.Click += new System.EventHandler(this.btnCityBank_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose a Bank to Reconcile:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "1112.02";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "1112.03";
            // 
            // ChooseBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 162);
            this.ControlBox = false;
            this.Controls.Add(this.btnCityBank);
            this.Controls.Add(this.btnCentennial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseBank";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose a Bank";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCentennial;
        private System.Windows.Forms.Button btnCityBank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}