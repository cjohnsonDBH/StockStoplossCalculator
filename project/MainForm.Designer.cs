namespace project
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.darkLabel12 = new DarkUI.Controls.DarkLabel();
            this.darkLabel13 = new DarkUI.Controls.DarkLabel();
            this.lblClose = new System.Windows.Forms.Label();
            this.txt20Profit = new DarkUI.Controls.DarkTextBox();
            this.darkLabel11 = new DarkUI.Controls.DarkLabel();
            this.txt15Profit = new DarkUI.Controls.DarkTextBox();
            this.darkLabel14 = new DarkUI.Controls.DarkLabel();
            this.txt1pSL = new DarkUI.Controls.DarkTextBox();
            this.darkLabel15 = new DarkUI.Controls.DarkLabel();
            this.darkLabel16 = new DarkUI.Controls.DarkLabel();
            this.txtTotalTrade = new DarkUI.Controls.DarkTextBox();
            this.darkLabel17 = new DarkUI.Controls.DarkLabel();
            this.txtPriceShare = new DarkUI.Controls.DarkTextBox();
            this.darkLabel18 = new DarkUI.Controls.DarkLabel();
            this.txtShares = new DarkUI.Controls.DarkTextBox();
            this.darkLabel19 = new DarkUI.Controls.DarkLabel();
            this.darkLabel20 = new DarkUI.Controls.DarkLabel();
            this.txtPercentAccount = new DarkUI.Controls.DarkTextBox();
            this.darkLabel21 = new DarkUI.Controls.DarkLabel();
            this.txtAccountSize = new DarkUI.Controls.DarkTextBox();
            this.darkLabel22 = new DarkUI.Controls.DarkLabel();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // darkLabel12
            // 
            this.darkLabel12.AutoSize = true;
            this.darkLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel12.Location = new System.Drawing.Point(7, 28);
            this.darkLabel12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.darkLabel12.Name = "darkLabel12";
            this.darkLabel12.Size = new System.Drawing.Size(145, 13);
            this.darkLabel12.TabIndex = 25;
            this.darkLabel12.Text = "¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯";
            // 
            // darkLabel13
            // 
            this.darkLabel13.AutoSize = true;
            this.darkLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel13.Location = new System.Drawing.Point(7, 7);
            this.darkLabel13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.darkLabel13.Name = "darkLabel13";
            this.darkLabel13.Size = new System.Drawing.Size(83, 13);
            this.darkLabel13.TabIndex = 27;
            this.darkLabel13.Text = "Stoploss (1%)";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(129, 7);
            this.lblClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(15, 13);
            this.lblClose.TabIndex = 26;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // txt20Profit
            // 
            this.txt20Profit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt20Profit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt20Profit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt20Profit.Location = new System.Drawing.Point(81, 213);
            this.txt20Profit.Margin = new System.Windows.Forms.Padding(2);
            this.txt20Profit.Name = "txt20Profit";
            this.txt20Profit.Size = new System.Drawing.Size(64, 20);
            this.txt20Profit.TabIndex = 45;
            this.txt20Profit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt20Profit_KeyPress);
            // 
            // darkLabel11
            // 
            this.darkLabel11.AutoSize = true;
            this.darkLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.darkLabel11.Location = new System.Drawing.Point(28, 214);
            this.darkLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.darkLabel11.Name = "darkLabel11";
            this.darkLabel11.Size = new System.Drawing.Size(48, 13);
            this.darkLabel11.TabIndex = 44;
            this.darkLabel11.Text = "2% Profit";
            // 
            // txt15Profit
            // 
            this.txt15Profit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt15Profit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt15Profit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt15Profit.Location = new System.Drawing.Point(81, 190);
            this.txt15Profit.Margin = new System.Windows.Forms.Padding(2);
            this.txt15Profit.Name = "txt15Profit";
            this.txt15Profit.Size = new System.Drawing.Size(64, 20);
            this.txt15Profit.TabIndex = 43;
            this.txt15Profit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt15Profit_KeyPress);
            // 
            // darkLabel14
            // 
            this.darkLabel14.AutoSize = true;
            this.darkLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.darkLabel14.Location = new System.Drawing.Point(19, 192);
            this.darkLabel14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.darkLabel14.Name = "darkLabel14";
            this.darkLabel14.Size = new System.Drawing.Size(57, 13);
            this.darkLabel14.TabIndex = 42;
            this.darkLabel14.Text = "1.5% Profit";
            // 
            // txt1pSL
            // 
            this.txt1pSL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt1pSL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt1pSL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txt1pSL.Location = new System.Drawing.Point(81, 167);
            this.txt1pSL.Margin = new System.Windows.Forms.Padding(2);
            this.txt1pSL.Name = "txt1pSL";
            this.txt1pSL.Size = new System.Drawing.Size(64, 20);
            this.txt1pSL.TabIndex = 41;
            this.txt1pSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1pSL_KeyPress);
            // 
            // darkLabel15
            // 
            this.darkLabel15.AutoSize = true;
            this.darkLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.darkLabel15.Location = new System.Drawing.Point(37, 169);
            this.darkLabel15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.darkLabel15.Name = "darkLabel15";
            this.darkLabel15.Size = new System.Drawing.Size(42, 13);
            this.darkLabel15.TabIndex = 40;
            this.darkLabel15.Text = "1% S/L";
            // 
            // darkLabel16
            // 
            this.darkLabel16.AutoSize = true;
            this.darkLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel16.Location = new System.Drawing.Point(78, 160);
            this.darkLabel16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.darkLabel16.Name = "darkLabel16";
            this.darkLabel16.Size = new System.Drawing.Size(73, 13);
            this.darkLabel16.TabIndex = 39;
            this.darkLabel16.Text = "¯¯¯¯¯¯¯¯¯¯¯";
            // 
            // txtTotalTrade
            // 
            this.txtTotalTrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtTotalTrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalTrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtTotalTrade.Location = new System.Drawing.Point(81, 137);
            this.txtTotalTrade.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalTrade.Name = "txtTotalTrade";
            this.txtTotalTrade.Size = new System.Drawing.Size(64, 20);
            this.txtTotalTrade.TabIndex = 38;
            this.txtTotalTrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalTrade_KeyPress);
            // 
            // darkLabel17
            // 
            this.darkLabel17.AutoSize = true;
            this.darkLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel17.Location = new System.Drawing.Point(15, 139);
            this.darkLabel17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.darkLabel17.Name = "darkLabel17";
            this.darkLabel17.Size = new System.Drawing.Size(62, 13);
            this.darkLabel17.TabIndex = 37;
            this.darkLabel17.Text = "Total Trade";
            // 
            // txtPriceShare
            // 
            this.txtPriceShare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtPriceShare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPriceShare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtPriceShare.Location = new System.Drawing.Point(81, 115);
            this.txtPriceShare.Margin = new System.Windows.Forms.Padding(2);
            this.txtPriceShare.Name = "txtPriceShare";
            this.txtPriceShare.Size = new System.Drawing.Size(64, 20);
            this.txtPriceShare.TabIndex = 36;
            this.txtPriceShare.TextChanged += new System.EventHandler(this.txtPriceShare_TextChanged);
            this.txtPriceShare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceShare_KeyPress);
            // 
            // darkLabel18
            // 
            this.darkLabel18.AutoSize = true;
            this.darkLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel18.Location = new System.Drawing.Point(9, 116);
            this.darkLabel18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.darkLabel18.Name = "darkLabel18";
            this.darkLabel18.Size = new System.Drawing.Size(70, 13);
            this.darkLabel18.TabIndex = 35;
            this.darkLabel18.Text = "Price / Share";
            // 
            // txtShares
            // 
            this.txtShares.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtShares.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShares.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtShares.Location = new System.Drawing.Point(81, 92);
            this.txtShares.Margin = new System.Windows.Forms.Padding(2);
            this.txtShares.Name = "txtShares";
            this.txtShares.Size = new System.Drawing.Size(64, 20);
            this.txtShares.TabIndex = 34;
            this.txtShares.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShares_KeyPress);
            // 
            // darkLabel19
            // 
            this.darkLabel19.AutoSize = true;
            this.darkLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel19.Location = new System.Drawing.Point(37, 93);
            this.darkLabel19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.darkLabel19.Name = "darkLabel19";
            this.darkLabel19.Size = new System.Drawing.Size(40, 13);
            this.darkLabel19.TabIndex = 33;
            this.darkLabel19.Text = "Shares";
            // 
            // darkLabel20
            // 
            this.darkLabel20.AutoSize = true;
            this.darkLabel20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel20.Location = new System.Drawing.Point(77, 86);
            this.darkLabel20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.darkLabel20.Name = "darkLabel20";
            this.darkLabel20.Size = new System.Drawing.Size(73, 13);
            this.darkLabel20.TabIndex = 32;
            this.darkLabel20.Text = "¯¯¯¯¯¯¯¯¯¯¯";
            // 
            // txtPercentAccount
            // 
            this.txtPercentAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtPercentAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPercentAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtPercentAccount.Location = new System.Drawing.Point(81, 63);
            this.txtPercentAccount.Margin = new System.Windows.Forms.Padding(2);
            this.txtPercentAccount.Name = "txtPercentAccount";
            this.txtPercentAccount.Size = new System.Drawing.Size(64, 20);
            this.txtPercentAccount.TabIndex = 31;
            this.txtPercentAccount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPercentAccount_KeyPress);
            // 
            // darkLabel21
            // 
            this.darkLabel21.AutoSize = true;
            this.darkLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel21.Location = new System.Drawing.Point(7, 64);
            this.darkLabel21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.darkLabel21.Name = "darkLabel21";
            this.darkLabel21.Size = new System.Drawing.Size(70, 13);
            this.darkLabel21.TabIndex = 30;
            this.darkLabel21.Text = "1% (Account)";
            // 
            // txtAccountSize
            // 
            this.txtAccountSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtAccountSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccountSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtAccountSize.Location = new System.Drawing.Point(81, 40);
            this.txtAccountSize.Margin = new System.Windows.Forms.Padding(2);
            this.txtAccountSize.Name = "txtAccountSize";
            this.txtAccountSize.Size = new System.Drawing.Size(64, 20);
            this.txtAccountSize.TabIndex = 29;
            this.txtAccountSize.TextChanged += new System.EventHandler(this.txtAccountSize_TextChanged);
            this.txtAccountSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccountSize_KeyPress);
            // 
            // darkLabel22
            // 
            this.darkLabel22.AutoSize = true;
            this.darkLabel22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel22.Location = new System.Drawing.Point(9, 41);
            this.darkLabel22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.darkLabel22.Name = "darkLabel22";
            this.darkLabel22.Size = new System.Drawing.Size(70, 13);
            this.darkLabel22.TabIndex = 28;
            this.darkLabel22.Text = "Account Size";
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.White;
            this.lblMinimize.Location = new System.Drawing.Point(110, 7);
            this.lblMinimize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(14, 13);
            this.lblMinimize.TabIndex = 46;
            this.lblMinimize.Text = "_";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(155, 244);
            this.Controls.Add(this.lblMinimize);
            this.Controls.Add(this.txt20Profit);
            this.Controls.Add(this.darkLabel11);
            this.Controls.Add(this.txt15Profit);
            this.Controls.Add(this.darkLabel14);
            this.Controls.Add(this.txt1pSL);
            this.Controls.Add(this.darkLabel15);
            this.Controls.Add(this.darkLabel16);
            this.Controls.Add(this.txtTotalTrade);
            this.Controls.Add(this.darkLabel17);
            this.Controls.Add(this.txtPriceShare);
            this.Controls.Add(this.darkLabel18);
            this.Controls.Add(this.txtShares);
            this.Controls.Add(this.darkLabel19);
            this.Controls.Add(this.darkLabel20);
            this.Controls.Add(this.txtPercentAccount);
            this.Controls.Add(this.darkLabel21);
            this.Controls.Add(this.txtAccountSize);
            this.Controls.Add(this.darkLabel22);
            this.Controls.Add(this.darkLabel13);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.darkLabel12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Form1";
            this.DoubleClick += new System.EventHandler(this.MainForm_DoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DarkUI.Controls.DarkLabel darkLabel12;
        private DarkUI.Controls.DarkLabel darkLabel13;
        private System.Windows.Forms.Label lblClose;
        private DarkUI.Controls.DarkTextBox txt20Profit;
        private DarkUI.Controls.DarkLabel darkLabel11;
        private DarkUI.Controls.DarkTextBox txt15Profit;
        private DarkUI.Controls.DarkLabel darkLabel14;
        private DarkUI.Controls.DarkTextBox txt1pSL;
        private DarkUI.Controls.DarkLabel darkLabel15;
        private DarkUI.Controls.DarkLabel darkLabel16;
        private DarkUI.Controls.DarkTextBox txtTotalTrade;
        private DarkUI.Controls.DarkLabel darkLabel17;
        private DarkUI.Controls.DarkTextBox txtPriceShare;
        private DarkUI.Controls.DarkLabel darkLabel18;
        private DarkUI.Controls.DarkTextBox txtShares;
        private DarkUI.Controls.DarkLabel darkLabel19;
        private DarkUI.Controls.DarkLabel darkLabel20;
        private DarkUI.Controls.DarkTextBox txtPercentAccount;
        private DarkUI.Controls.DarkLabel darkLabel21;
        private DarkUI.Controls.DarkTextBox txtAccountSize;
        private DarkUI.Controls.DarkLabel darkLabel22;
        private System.Windows.Forms.Label lblMinimize;
    }
}

