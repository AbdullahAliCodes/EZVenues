namespace Assignment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.chkLoyaltyCard = new System.Windows.Forms.CheckBox();
            this.boxStatus = new System.Windows.Forms.GroupBox();
            this.rdbVIP = new System.Windows.Forms.RadioButton();
            this.rdbRetail = new System.Windows.Forms.RadioButton();
            this.rdbRegular = new System.Windows.Forms.RadioButton();
            this.boxTotals = new System.Windows.Forms.GroupBox();
            this.lblPoints = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.boxSummary = new System.Windows.Forms.GroupBox();
            this.lblAccmCustomersWPoints = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAccmCustomers = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAccmTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.boxStatus.SuspendLayout();
            this.boxTotals.SuspendLayout();
            this.boxSummary.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CC\'s CRAZY CLOTHING";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Phone Number";
            // 
            // mtxtPhoneNumber
            // 
            this.mtxtPhoneNumber.Location = new System.Drawing.Point(156, 62);
            this.mtxtPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtxtPhoneNumber.Mask = "000-000-0000";
            this.mtxtPhoneNumber.Name = "mtxtPhoneNumber";
            this.mtxtPhoneNumber.Size = new System.Drawing.Size(80, 20);
            this.mtxtPhoneNumber.TabIndex = 2;
            this.toolTip1.SetToolTip(this.mtxtPhoneNumber, "Please enter a valid cell phone number");
            this.mtxtPhoneNumber.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtPhoneNumber_MaskInputRejected);
            // 
            // chkLoyaltyCard
            // 
            this.chkLoyaltyCard.AutoSize = true;
            this.chkLoyaltyCard.Location = new System.Drawing.Point(20, 96);
            this.chkLoyaltyCard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkLoyaltyCard.Name = "chkLoyaltyCard";
            this.chkLoyaltyCard.Size = new System.Drawing.Size(90, 17);
            this.chkLoyaltyCard.TabIndex = 3;
            this.chkLoyaltyCard.Text = "Loyalty Card?";
            this.toolTip1.SetToolTip(this.chkLoyaltyCard, "Select if you have a Loyalty Card");
            this.chkLoyaltyCard.UseVisualStyleBackColor = true;
            // 
            // boxStatus
            // 
            this.boxStatus.Controls.Add(this.rdbVIP);
            this.boxStatus.Controls.Add(this.rdbRetail);
            this.boxStatus.Controls.Add(this.rdbRegular);
            this.boxStatus.Location = new System.Drawing.Point(338, 62);
            this.boxStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxStatus.Name = "boxStatus";
            this.boxStatus.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxStatus.Size = new System.Drawing.Size(208, 80);
            this.boxStatus.TabIndex = 4;
            this.boxStatus.TabStop = false;
            this.boxStatus.Text = "Status";
            this.toolTip1.SetToolTip(this.boxStatus, "Select your Customer Status");
            // 
            // rdbVIP
            // 
            this.rdbVIP.AutoSize = true;
            this.rdbVIP.Location = new System.Drawing.Point(4, 60);
            this.rdbVIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbVIP.Name = "rdbVIP";
            this.rdbVIP.Size = new System.Drawing.Size(42, 17);
            this.rdbVIP.TabIndex = 2;
            this.rdbVIP.Text = "VIP";
            this.rdbVIP.UseVisualStyleBackColor = true;
            // 
            // rdbRetail
            // 
            this.rdbRetail.AutoSize = true;
            this.rdbRetail.Location = new System.Drawing.Point(4, 37);
            this.rdbRetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbRetail.Name = "rdbRetail";
            this.rdbRetail.Size = new System.Drawing.Size(52, 17);
            this.rdbRetail.TabIndex = 1;
            this.rdbRetail.Text = "Retail";
            this.rdbRetail.UseVisualStyleBackColor = true;
            // 
            // rdbRegular
            // 
            this.rdbRegular.AutoSize = true;
            this.rdbRegular.Checked = true;
            this.rdbRegular.Location = new System.Drawing.Point(4, 17);
            this.rdbRegular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbRegular.Name = "rdbRegular";
            this.rdbRegular.Size = new System.Drawing.Size(62, 17);
            this.rdbRegular.TabIndex = 0;
            this.rdbRegular.TabStop = true;
            this.rdbRegular.Text = "Regular";
            this.rdbRegular.UseVisualStyleBackColor = true;
            // 
            // boxTotals
            // 
            this.boxTotals.Controls.Add(this.lblPoints);
            this.boxTotals.Controls.Add(this.label6);
            this.boxTotals.Controls.Add(this.lblTotal);
            this.boxTotals.Controls.Add(this.label5);
            this.boxTotals.Controls.Add(this.lblVAT);
            this.boxTotals.Controls.Add(this.label4);
            this.boxTotals.Controls.Add(this.lblDiscount);
            this.boxTotals.Controls.Add(this.label3);
            this.boxTotals.Location = new System.Drawing.Point(20, 148);
            this.boxTotals.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxTotals.Name = "boxTotals";
            this.boxTotals.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxTotals.Size = new System.Drawing.Size(211, 144);
            this.boxTotals.TabIndex = 5;
            this.boxTotals.TabStop = false;
            this.boxTotals.Text = "Totals";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(115, 108);
            this.lblPoints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(13, 13);
            this.lblPoints.TabIndex = 7;
            this.lblPoints.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Points";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(115, 82);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(28, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Final Total";
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Location = new System.Drawing.Point(115, 53);
            this.lblVAT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(28, 13);
            this.lblVAT.TabIndex = 4;
            this.lblVAT.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "VAT Amount";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(115, 28);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(28, 13);
            this.lblDiscount.TabIndex = 3;
            this.lblDiscount.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Discount Amount";
            // 
            // boxSummary
            // 
            this.boxSummary.Controls.Add(this.lblAccmCustomersWPoints);
            this.boxSummary.Controls.Add(this.label9);
            this.boxSummary.Controls.Add(this.lblAccmCustomers);
            this.boxSummary.Controls.Add(this.label8);
            this.boxSummary.Controls.Add(this.lblAccmTotal);
            this.boxSummary.Controls.Add(this.label7);
            this.boxSummary.Location = new System.Drawing.Point(271, 148);
            this.boxSummary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxSummary.Name = "boxSummary";
            this.boxSummary.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxSummary.Size = new System.Drawing.Size(411, 144);
            this.boxSummary.TabIndex = 6;
            this.boxSummary.TabStop = false;
            this.boxSummary.Text = "Summary";
            // 
            // lblAccmCustomersWPoints
            // 
            this.lblAccmCustomersWPoints.AutoSize = true;
            this.lblAccmCustomersWPoints.Location = new System.Drawing.Point(349, 99);
            this.lblAccmCustomersWPoints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccmCustomersWPoints.Name = "lblAccmCustomersWPoints";
            this.lblAccmCustomersWPoints.Size = new System.Drawing.Size(13, 13);
            this.lblAccmCustomersWPoints.TabIndex = 5;
            this.lblAccmCustomersWPoints.Text = "0";
            this.lblAccmCustomersWPoints.Click += new System.EventHandler(this.lblAccmCustomersWPoints_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 98);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(301, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Accumulated Number of Customers with points greater than 20";
            // 
            // lblAccmCustomers
            // 
            this.lblAccmCustomers.AutoSize = true;
            this.lblAccmCustomers.Location = new System.Drawing.Point(349, 72);
            this.lblAccmCustomers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccmCustomers.Name = "lblAccmCustomers";
            this.lblAccmCustomers.Size = new System.Drawing.Size(13, 13);
            this.lblAccmCustomers.TabIndex = 3;
            this.lblAccmCustomers.Text = "0";
            this.lblAccmCustomers.Click += new System.EventHandler(this.lblAccmCustomers_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 72);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Accumulated Number of Customers";
            // 
            // lblAccmTotal
            // 
            this.lblAccmTotal.AutoSize = true;
            this.lblAccmTotal.Location = new System.Drawing.Point(333, 43);
            this.lblAccmTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccmTotal.Name = "lblAccmTotal";
            this.lblAccmTotal.Size = new System.Drawing.Size(28, 13);
            this.lblAccmTotal.TabIndex = 1;
            this.lblAccmTotal.Text = "0.00";
            this.lblAccmTotal.Click += new System.EventHandler(this.lblAccmTotal_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Accumulated Final Total";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.processToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(693, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.processToolStripMenuItem.Text = "Process";
            this.processToolStripMenuItem.Click += new System.EventHandler(this.processToolStripMenuItem_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 350);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.boxSummary);
            this.Controls.Add(this.boxTotals);
            this.Controls.Add(this.boxStatus);
            this.Controls.Add(this.chkLoyaltyCard);
            this.Controls.Add(this.mtxtPhoneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.boxStatus.ResumeLayout(false);
            this.boxStatus.PerformLayout();
            this.boxTotals.ResumeLayout(false);
            this.boxTotals.PerformLayout();
            this.boxSummary.ResumeLayout(false);
            this.boxSummary.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxtPhoneNumber;
        private System.Windows.Forms.CheckBox chkLoyaltyCard;
        private System.Windows.Forms.GroupBox boxStatus;
        private System.Windows.Forms.RadioButton rdbVIP;
        private System.Windows.Forms.RadioButton rdbRetail;
        private System.Windows.Forms.RadioButton rdbRegular;
        private System.Windows.Forms.GroupBox boxTotals;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox boxSummary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAccmTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAccmCustomersWPoints;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAccmCustomers;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

