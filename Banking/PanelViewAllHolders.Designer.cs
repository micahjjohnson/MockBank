namespace Banking
{
    partial class PanelViewAllHolders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelViewAllHolders));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "10005",
            "CLOSED",
            "Nathanial Robinson",
            "CHECKING",
            "$  600.58",
            "03/25/2017"}, -1);
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.accountNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberSinceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.earliestFirstToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oldestFirstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.acct_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.details = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.balance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.member_since = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 561);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.delete_toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(620, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountNumberToolStripMenuItem,
            this.nameToolStripMenuItem,
            this.detailToolStripMenuItem,
            this.memberSinceToolStripMenuItem});
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(77, 22);
            this.toolStripSplitButton1.Text = "Sort by...";
            this.toolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // accountNumberToolStripMenuItem
            // 
            this.accountNumberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendingToolStripMenuItem,
            this.descendingToolStripMenuItem});
            this.accountNumberToolStripMenuItem.Name = "accountNumberToolStripMenuItem";
            this.accountNumberToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.accountNumberToolStripMenuItem.Text = "Account Number";
            // 
            // ascendingToolStripMenuItem
            // 
            this.ascendingToolStripMenuItem.Name = "ascendingToolStripMenuItem";
            this.ascendingToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.ascendingToolStripMenuItem.Text = "Ascending";
            this.ascendingToolStripMenuItem.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
            // 
            // descendingToolStripMenuItem
            // 
            this.descendingToolStripMenuItem.Name = "descendingToolStripMenuItem";
            this.descendingToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.descendingToolStripMenuItem.Text = "Descending";
            this.descendingToolStripMenuItem.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.nameToolStripMenuItem.Text = "Name";
            this.nameToolStripMenuItem.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
            // 
            // detailToolStripMenuItem
            // 
            this.detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            this.detailToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.detailToolStripMenuItem.Text = "Detail";
            this.detailToolStripMenuItem.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
            // 
            // memberSinceToolStripMenuItem
            // 
            this.memberSinceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.earliestFirstToolStripMenuItem1,
            this.oldestFirstToolStripMenuItem});
            this.memberSinceToolStripMenuItem.Name = "memberSinceToolStripMenuItem";
            this.memberSinceToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.memberSinceToolStripMenuItem.Text = "Member Since";
            // 
            // earliestFirstToolStripMenuItem1
            // 
            this.earliestFirstToolStripMenuItem1.Name = "earliestFirstToolStripMenuItem1";
            this.earliestFirstToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.earliestFirstToolStripMenuItem1.Text = "Newest";
            this.earliestFirstToolStripMenuItem1.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
            // 
            // oldestFirstToolStripMenuItem
            // 
            this.oldestFirstToolStripMenuItem.Name = "oldestFirstToolStripMenuItem";
            this.oldestFirstToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.oldestFirstToolStripMenuItem.Text = "Oldest";
            this.oldestFirstToolStripMenuItem.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
            // 
            // delete_toolStripButton1
            // 
            this.delete_toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.delete_toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("delete_toolStripButton1.Image")));
            this.delete_toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delete_toolStripButton1.Name = "delete_toolStripButton1";
            this.delete_toolStripButton1.Size = new System.Drawing.Size(48, 22);
            this.delete_toolStripButton1.Text = "Delete";
            this.delete_toolStripButton1.Click += new System.EventHandler(this.delete_toolStripButton1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.acct_num,
            this.status,
            this.name,
            this.details,
            this.balance,
            this.member_since});
            this.listView1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(3, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(614, 524);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // acct_num
            // 
            this.acct_num.Text = "Acct Num.";
            this.acct_num.Width = 80;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 184;
            // 
            // details
            // 
            this.details.Text = "Details";
            this.details.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.details.Width = 80;
            // 
            // balance
            // 
            this.balance.Text = "Balance";
            this.balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.balance.Width = 85;
            // 
            // member_since
            // 
            this.member_since.Text = "Member Since";
            this.member_since.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.member_since.Width = 115;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.status.Width = 66;
            // 
            // PanelViewAllHolders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 575);
            this.Controls.Add(this.panel1);
            this.Name = "PanelViewAllHolders";
            this.Text = "PanelViewAllHolders";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader acct_num;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader details;
        private System.Windows.Forms.ColumnHeader balance;
        private System.Windows.Forms.ColumnHeader member_since;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem accountNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ascendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberSinceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem earliestFirstToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem oldestFirstToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton delete_toolStripButton1;
        private System.Windows.Forms.ColumnHeader status;
    }
}