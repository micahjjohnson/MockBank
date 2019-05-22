using System;
using System.Drawing;
using System.Windows.Forms;

namespace Banking
{
    internal partial class Form1 : Form
    {
        private readonly MasterForm masterForm;
        private readonly string directory = @"C:\Bank\data\images\";

        public Form1(MasterForm master)
        {
            InitializeComponent();
            this.FormClosing += closingEvent;
            this.masterForm = master;
            date_lb.Text = DateTime.Now.ToLongDateString();
            changer_pnl.Location = new Point(1, 3);

            showHome();
        }

        private void closingEvent(object sender, FormClosingEventArgs e)
        {
            masterForm.getMasterBank().saveProgram();
        }

        internal void showBackButton(bool x)
        {
            back.Visible = x;
        }

        internal void enableServiceButtons(bool x)
        {
            if (x)
            {
                credit_account_link.Enabled = true;
                close_account_link.Enabled = true;
                button1.Enabled = true;
                add_account_link.Enabled = true;
                withdraw_bt.Enabled = true;
                if (masterForm.getHolder().getAccountList().Count > 1)
                {
                    transfer_money_link.Enabled = true;
                }
            }
            else
            {
                credit_account_link.Enabled = false;
                close_account_link.Enabled = false;
                add_account_link.Enabled = false;
                transfer_money_link.Enabled = false;
                button1.Enabled = false;
                withdraw_bt.Enabled = false;
            }
        }

        internal void showHome()
        {
            pictureBox1.Image = Image.FromFile(directory + @"default.png");
            changer_pnl.Visible = false;
        }

        public void appendToPanel(Panel x, string path)
        {
            pictureBox1.Image = Image.FromFile(directory + path);
            changer_pnl.Visible = true;
            changer_pnl.Controls.Clear();
            changer_pnl.Controls.Add(x);
            changer_pnl.BringToFront();
        }

        private void back_Click(object sender, EventArgs e)
        {
            masterForm.updateView(1);
        }

        private void creditAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            masterForm.updateView(4);
        }

        private void closeAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var confirm = new DialogConfirm();
            confirm.setDialogText("Are you sure you want to close this account? This action cannot be undone.");
            confirm.ShowDialog();

            if (confirm.DialogResult == DialogResult.Yes)
            {
                masterForm.getMasterBank().getBankServices().closeAccount(masterForm.getAccount());
                masterForm.updateView(0);
            }
        }

        private void transfer_money_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            masterForm.updateView(5);
        }
        
        private void search_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var search = new PanelSearch(masterForm);
            appendToPanel(search.Panel, @"search3.png");
        }

        private void new_account_Click(object sender, EventArgs e)
        {
            var acctForm = new PanelAccountChoices(masterForm);
            appendToPanel(acctForm.Panel, @"enroll.png");
        }

        private void deposit_LinkClicked(object sender, EventArgs e)
        {
            showBackButton(true);
            masterForm.updateView(3);
        }

        private void withdraw_bt_Click(object sender, EventArgs e)
        {
            showBackButton(true);
            var withdraw = new PanelWithdraw(masterForm);
            appendToPanel(withdraw.Panel, @"withdraw.png");
        }    

        private void manage_all_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var view = new PanelViewAllHolders(masterForm);
            appendToPanel(view.Panel, @"default.png");
        }
    }
}