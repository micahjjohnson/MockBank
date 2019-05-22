namespace Banking
{
    partial class PanelSwipe
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
            this.swipe_form = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.swipe_pnl = new System.Windows.Forms.Panel();
            this.progress_pnl = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.swipe_pnl.SuspendLayout();
            this.progress_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // swipe_form
            // 
            this.swipe_form.AutoSize = true;
            this.swipe_form.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.swipe_form.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swipe_form.Location = new System.Drawing.Point(3, 3);
            this.swipe_form.Name = "swipe_form";
            this.swipe_form.Size = new System.Drawing.Size(121, 76);
            this.swipe_form.TabIndex = 0;
            this.swipe_form.Text = "Swipe";
            this.swipe_form.UseVisualStyleBackColor = true;
            this.swipe_form.Click += new System.EventHandler(this.swipe_form_Click);
            // 
            // swipe_pnl
            // 
            this.swipe_pnl.Controls.Add(this.swipe_form);
            this.swipe_pnl.Controls.Add(this.progress_pnl);
            this.swipe_pnl.Location = new System.Drawing.Point(12, 12);
            this.swipe_pnl.Name = "swipe_pnl";
            this.swipe_pnl.Size = new System.Drawing.Size(367, 86);
            this.swipe_pnl.TabIndex = 9;
            // 
            // progress_pnl
            // 
            this.progress_pnl.Controls.Add(this.progressBar1);
            this.progress_pnl.Controls.Add(this.label1);
            this.progress_pnl.Location = new System.Drawing.Point(143, 3);
            this.progress_pnl.Name = "progress_pnl";
            this.progress_pnl.Size = new System.Drawing.Size(218, 46);
            this.progress_pnl.TabIndex = 3;
            this.progress_pnl.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(210, 23);
            this.progressBar1.Step = 5;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Waiting for response";
            // 
            // FormCustomerEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 137);
            this.Controls.Add(this.swipe_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCustomerEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Customer Entry Method";
            this.swipe_pnl.ResumeLayout(false);
            this.swipe_pnl.PerformLayout();
            this.progress_pnl.ResumeLayout(false);
            this.progress_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button swipe_form;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel progress_pnl;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel swipe_pnl;
    }
}