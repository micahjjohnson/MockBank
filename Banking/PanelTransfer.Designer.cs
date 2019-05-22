namespace Banking
{
    partial class PanelTransfer
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
            this.from_bal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.to_bal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.transfer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.to_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.from_cb = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.error_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.error_lbl);
            this.panel1.Controls.Add(this.from_bal);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.to_bal);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.transfer);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.richTextBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.to_cb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.from_cb);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.amount);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 369);
            this.panel1.TabIndex = 0;
            // 
            // from_bal
            // 
            this.from_bal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_bal.Location = new System.Drawing.Point(270, 66);
            this.from_bal.Name = "from_bal";
            this.from_bal.Size = new System.Drawing.Size(57, 16);
            this.from_bal.TabIndex = 33;
            this.from_bal.Text = "0.00";
            this.from_bal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(249, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "$";
            // 
            // to_bal
            // 
            this.to_bal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_bal.Location = new System.Drawing.Point(270, 210);
            this.to_bal.Name = "to_bal";
            this.to_bal.Size = new System.Drawing.Size(57, 16);
            this.to_bal.TabIndex = 31;
            this.to_bal.Text = "0.00";
            this.to_bal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(249, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "$";
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(316, 338);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 26;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // transfer
            // 
            this.transfer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.transfer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.transfer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transfer.Location = new System.Drawing.Point(235, 338);
            this.transfer.Name = "transfer";
            this.transfer.Size = new System.Drawing.Size(75, 23);
            this.transfer.TabIndex = 25;
            this.transfer.Text = "Transfer";
            this.transfer.UseVisualStyleBackColor = true;
            this.transfer.Click += new System.EventHandler(this.transfer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "TRANSFER";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(106, 120);
            this.richTextBox2.MaxLength = 2000;
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(285, 65);
            this.richTextBox2.TabIndex = 23;
            this.richTextBox2.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Notes";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(106, 233);
            this.richTextBox1.MaxLength = 2000;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(285, 65);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "";
            // 
            // to_cb
            // 
            this.to_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.to_cb.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.to_cb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_cb.FormattingEnabled = true;
            this.to_cb.Location = new System.Drawing.Point(106, 202);
            this.to_cb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.to_cb.Name = "to_cb";
            this.to_cb.Size = new System.Drawing.Size(137, 24);
            this.to_cb.TabIndex = 20;
            this.to_cb.SelectedIndexChanged += new System.EventHandler(this.from_cb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Transfer To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Notes";
            // 
            // from_cb
            // 
            this.from_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.from_cb.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.from_cb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_cb.FormattingEnabled = true;
            this.from_cb.Location = new System.Drawing.Point(106, 58);
            this.from_cb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.from_cb.Name = "from_cb";
            this.from_cb.Size = new System.Drawing.Size(137, 24);
            this.from_cb.TabIndex = 16;
            this.from_cb.SelectedIndexChanged += new System.EventHandler(this.from_cb_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 16);
            this.label13.TabIndex = 15;
            this.label13.Text = "Transfer From";
            // 
            // amount
            // 
            this.amount.Enabled = false;
            this.amount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(106, 90);
            this.amount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.amount.MaxLength = 7;
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(137, 23);
            this.amount.TabIndex = 13;
            this.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.amount.TextChanged += new System.EventHandler(this.amount_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 16);
            this.label14.TabIndex = 14;
            this.label14.Text = "Amount";
            // 
            // error_lbl
            // 
            this.error_lbl.AutoSize = true;
            this.error_lbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_lbl.ForeColor = System.Drawing.Color.Red;
            this.error_lbl.Location = new System.Drawing.Point(249, 93);
            this.error_lbl.Name = "error_lbl";
            this.error_lbl.Size = new System.Drawing.Size(142, 16);
            this.error_lbl.TabIndex = 34;
            this.error_lbl.Text = "Please enter a number!";
            this.error_lbl.Visible = false;
            // 
            // PanelTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 385);
            this.Controls.Add(this.panel1);
            this.Name = "PanelTransfer";
            this.Text = "PanelTransfer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox from_cb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox to_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button transfer;
        private System.Windows.Forms.Label from_bal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label to_bal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label error_lbl;
    }
}