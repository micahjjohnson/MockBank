namespace Banking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.add_account_link = new System.Windows.Forms.LinkLabel();
            this.transfer_money_link = new System.Windows.Forms.LinkLabel();
            this.close_account_link = new System.Windows.Forms.LinkLabel();
            this.credit_account_link = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.withdraw_bt = new System.Windows.Forms.Button();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.date_lb = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.master_pnl = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankingSuiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.changer_pnl = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.master_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.add_account_link);
            this.panel1.Controls.Add(this.transfer_money_link);
            this.panel1.Controls.Add(this.close_account_link);
            this.panel1.Controls.Add(this.credit_account_link);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.withdraw_bt);
            this.panel1.Controls.Add(this.linkLabel6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.linkLabel7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.linkLabel3);
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.date_lb);
            this.panel1.Location = new System.Drawing.Point(12, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 629);
            this.panel1.TabIndex = 5;
            // 
            // add_account_link
            // 
            this.add_account_link.AutoSize = true;
            this.add_account_link.Enabled = false;
            this.add_account_link.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_account_link.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.add_account_link.Location = new System.Drawing.Point(13, 318);
            this.add_account_link.Name = "add_account_link";
            this.add_account_link.Size = new System.Drawing.Size(82, 16);
            this.add_account_link.TabIndex = 19;
            this.add_account_link.TabStop = true;
            this.add_account_link.Text = "New Account";
            // 
            // transfer_money_link
            // 
            this.transfer_money_link.AutoSize = true;
            this.transfer_money_link.Enabled = false;
            this.transfer_money_link.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transfer_money_link.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.transfer_money_link.Location = new System.Drawing.Point(13, 293);
            this.transfer_money_link.Name = "transfer_money_link";
            this.transfer_money_link.Size = new System.Drawing.Size(95, 16);
            this.transfer_money_link.TabIndex = 18;
            this.transfer_money_link.TabStop = true;
            this.transfer_money_link.Text = "Transfer Funds";
            this.transfer_money_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.transfer_money_link_LinkClicked);
            // 
            // close_account_link
            // 
            this.close_account_link.AutoSize = true;
            this.close_account_link.Enabled = false;
            this.close_account_link.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_account_link.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.close_account_link.Location = new System.Drawing.Point(12, 268);
            this.close_account_link.Name = "close_account_link";
            this.close_account_link.Size = new System.Drawing.Size(88, 16);
            this.close_account_link.TabIndex = 17;
            this.close_account_link.TabStop = true;
            this.close_account_link.Text = "Close Account";
            this.close_account_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.closeAccount_LinkClicked);
            // 
            // credit_account_link
            // 
            this.credit_account_link.AutoSize = true;
            this.credit_account_link.Enabled = false;
            this.credit_account_link.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credit_account_link.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.credit_account_link.Location = new System.Drawing.Point(12, 242);
            this.credit_account_link.Name = "credit_account_link";
            this.credit_account_link.Size = new System.Drawing.Size(91, 16);
            this.credit_account_link.TabIndex = 16;
            this.credit_account_link.TabStop = true;
            this.credit_account_link.Text = "Credit Account";
            this.credit_account_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.creditAccount_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Account Tools";
            // 
            // back
            // 
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.back.Location = new System.Drawing.Point(183, 11);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(40, 23);
            this.back.TabIndex = 2;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Visible = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // withdraw_bt
            // 
            this.withdraw_bt.AllowDrop = true;
            this.withdraw_bt.AutoSize = true;
            this.withdraw_bt.Enabled = false;
            this.withdraw_bt.Image = global::Banking.Properties.Resources.withdraw_bt3;
            this.withdraw_bt.Location = new System.Drawing.Point(-2, 539);
            this.withdraw_bt.Name = "withdraw_bt";
            this.withdraw_bt.Size = new System.Drawing.Size(227, 87);
            this.withdraw_bt.TabIndex = 14;
            this.withdraw_bt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.withdraw_bt.UseVisualStyleBackColor = false;
            this.withdraw_bt.Click += new System.EventHandler(this.withdraw_bt_Click);
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Enabled = false;
            this.linkLabel6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel6.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel6.Location = new System.Drawing.Point(12, 53);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(41, 16);
            this.linkLabel6.TabIndex = 9;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Home";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Image = global::Banking.Properties.Resources.deposit_bt3;
            this.button1.Location = new System.Drawing.Point(1, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 89);
            this.button1.TabIndex = 13;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.deposit_LinkClicked);
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel7.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel7.Location = new System.Drawing.Point(12, 383);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(149, 16);
            this.linkLabel7.TabIndex = 8;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "Manage Account Holders";
            this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.manage_all_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Other Tasks";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel3.Location = new System.Drawing.Point(12, 126);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(107, 16);
            this.linkLabel3.TabIndex = 4;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Advanced Search";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.search_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel2.Location = new System.Drawing.Point(12, 151);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(82, 16);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "New Account";
            this.linkLabel2.Click += new System.EventHandler(this.new_account_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Enabled = false;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(12, 177);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(77, 16);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Loan Center";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Common Tasks";
            // 
            // date_lb
            // 
            this.date_lb.AutoSize = true;
            this.date_lb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lb.Location = new System.Drawing.Point(12, 14);
            this.date_lb.Name = "date_lb";
            this.date_lb.Size = new System.Drawing.Size(38, 16);
            this.date_lb.TabIndex = 0;
            this.date_lb.Text = "date";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.master_pnl);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(248, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(875, 728);
            this.panel3.TabIndex = 6;
            // 
            // master_pnl
            // 
            this.master_pnl.AutoScroll = true;
            this.master_pnl.Controls.Add(this.pictureBox3);
            this.master_pnl.Controls.Add(this.changer_pnl);
            this.master_pnl.Controls.Add(this.label6);
            this.master_pnl.Location = new System.Drawing.Point(3, 89);
            this.master_pnl.Name = "master_pnl";
            this.master_pnl.Size = new System.Drawing.Size(865, 632);
            this.master_pnl.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(865, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.bankingSuiteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1131, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // bankingSuiteToolStripMenuItem
            // 
            this.bankingSuiteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem});
            this.bankingSuiteToolStripMenuItem.Name = "bankingSuiteToolStripMenuItem";
            this.bankingSuiteToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.bankingSuiteToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewHelpToolStripMenuItem.Image")));
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Banking.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(12, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1111, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // changer_pnl
            // 
            this.changer_pnl.AutoScroll = true;
            this.changer_pnl.Location = new System.Drawing.Point(3, 6);
            this.changer_pnl.Name = "changer_pnl";
            this.changer_pnl.Size = new System.Drawing.Size(859, 626);
            this.changer_pnl.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "Welcome";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Banking.Properties.Resources.coupon;
            this.pictureBox3.Location = new System.Drawing.Point(52, 90);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(724, 233);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 868);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1147, 907);
            this.MinimumSize = new System.Drawing.Size(1147, 907);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banking Suite";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.master_pnl.ResumeLayout(false);
            this.master_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label date_lb;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankingSuiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel master_pnl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button withdraw_bt;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.LinkLabel transfer_money_link;
        private System.Windows.Forms.LinkLabel close_account_link;
        private System.Windows.Forms.LinkLabel credit_account_link;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel add_account_link;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel changer_pnl;
        private System.Windows.Forms.Label label6;
    }
}

