namespace Banking
{
    partial class PanelWithdraw
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.amount_tb = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.account_num = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.amount_tb);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.label45);
            this.panel1.Controls.Add(this.account_num);
            this.panel1.Controls.Add(this.label46);
            this.panel1.Controls.Add(this.label47);
            this.panel1.Controls.Add(this.balance);
            this.panel1.Controls.Add(this.next);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 245);
            this.panel1.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(327, 153);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(272, 21);
            this.label1.TabIndex = 69;
            this.label1.Text = "Insufficient Funds. Please enter other amount.";
            this.label1.Visible = false;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(84, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Amount";
            // 
            // amount_tb
            // 
            this.amount_tb.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_tb.Location = new System.Drawing.Point(167, 149);
            this.amount_tb.Name = "amount_tb";
            this.amount_tb.Size = new System.Drawing.Size(154, 30);
            this.amount_tb.TabIndex = 0;
            this.amount_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.amount_tb.TextChanged += new System.EventHandler(this.amount_TextChanged);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(8, 13);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(239, 24);
            this.name.TabIndex = 67;
            this.name.Text = "First Last";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(9, 55);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(71, 16);
            this.label45.TabIndex = 61;
            this.label45.Text = "Account #:";
            // 
            // account_num
            // 
            this.account_num.AutoSize = true;
            this.account_num.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account_num.Location = new System.Drawing.Point(86, 55);
            this.account_num.Name = "account_num";
            this.account_num.Size = new System.Drawing.Size(84, 16);
            this.account_num.TabIndex = 62;
            this.account_num.Text = "XXXXXX0000";
            // 
            // label46
            // 
            this.label46.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(8, 71);
            this.label46.Name = "label46";
            this.label46.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label46.Size = new System.Drawing.Size(173, 26);
            this.label46.TabIndex = 64;
            this.label46.Text = "Checking Account";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(8, 92);
            this.label47.Name = "label47";
            this.label47.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label47.Size = new System.Drawing.Size(68, 21);
            this.label47.TabIndex = 65;
            this.label47.Text = "Balance: $";
            // 
            // balance
            // 
            this.balance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.Location = new System.Drawing.Point(82, 92);
            this.balance.Name = "balance";
            this.balance.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.balance.Size = new System.Drawing.Size(99, 21);
            this.balance.TabIndex = 66;
            this.balance.Text = "0.00";
            this.balance.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // next
            // 
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.next.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(300, 210);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 60;
            this.next.Text = "Withdraw";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(143, 155);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 19);
            this.label16.TabIndex = 22;
            this.label16.Text = "$";
            // 
            // PanelWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 265);
            this.Controls.Add(this.panel1);
            this.Name = "PanelWithdraw";
            this.Text = "PanelWithdraw";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox amount_tb;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label account_num;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
    }
}