using System;
using System.Windows.Forms;

namespace Banking
{
    public partial class PanelTransfer : Form
    {
        private readonly MasterForm master;
        private Account fromAccount;
        private Account toAccount;

        internal PanelTransfer(MasterForm master)
        {
            InitializeComponent();
            this.master = master;
        }

        internal Panel Panel { get { return panel1; } }

        internal void setupForm()
        {
            foreach (Account act in master.getHolder().getAccountList())
            {
                from_cb.Items.Add(act.getAccountNumber());
                to_cb.Items.Add(act.getAccountNumber());
            }
        }

        private void from_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            var search = new Search.SearchThroughAccount();
            search.ForExactAccountNumber(master.getMasterBank().getBankServices(), long.Parse(cb.SelectedItem.ToString()));
            var account = search.AccountSearchResults[0];

            if (cb == from_cb)
            {           
                from_bal.Text = account.getBalance().ToString();
                fromAccount = account;
                amount.Enabled = true;
            }
            if (cb == to_cb)
            {
                to_bal.Text = account.getBalance().ToString();
                toAccount = account;
            }
        }

        private void transfer_Click(object sender, EventArgs e)
        {
            if (amount.TextLength > 0)
            {
                master.getMasterBank().getAccountServices().transferFunds(fromAccount, toAccount, decimal.Parse(amount.Text));
                master.updateView(0);
            }
            else
            {
                MessageBox.Show("No amount entered.");
            }         
        }

        private void amount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var x = decimal.Parse(amount.Text);
                error_lbl.Visible = false;

                if (x > fromAccount.getBalance())
                {
                    transfer.Enabled = false;
                }
                if (x <= fromAccount.getBalance())
                {
                    transfer.Enabled = true;
                }
            }
            catch (FormatException)
            {
                error_lbl.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var confirm = new DialogConfirm();
            confirm.ShowDialog();

            if (confirm.DialogResult == DialogResult.Yes)
            {
                master.updateView(10);
            }
        }
    }
}
