using System;
using System.Windows.Forms;

namespace Banking
{
    public partial class PanelWithdraw : Form
    {
        private MasterForm master;

        internal PanelWithdraw(MasterForm master)
        {
            InitializeComponent();
            this.master = master;
            name.Text = master.getAccount().getCardHolder(1).getFullName();
            account_num.Text = master.getAccount().getAccountNumber().ToString();
            balance.Text = master.getAccount().getBalance().ToString("0.00");

            if (master.getAccount().getBalance() < 0)
            {
                next.Enabled = false;
            }
        }

        public Panel Panel { get { return panel1; } }

        private void next_Click(object sender, EventArgs e)
        {
            var total = decimal.Parse(amount_tb.Text);
            master.getMasterBank().getAccountServices().withdraw(master.getAccount(), total);
            master.updateView(0);
        }

        private void amount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var amount = decimal.Parse(amount_tb.Text);

                if (amount > master.getAccount().getBalance())
                {
                    label1.Visible = true;
                    next.Enabled = false;
                }
                if (amount <= master.getAccount().getBalance())
                {
                    label1.Visible = false;
                    next.Enabled = true;
                }
            } catch { }
        }
    }
}
