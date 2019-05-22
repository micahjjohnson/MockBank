using System.Windows.Forms;

namespace Banking
{
    public partial class PanelHolderDetails : Form
    {
        private MasterForm masterForm;
        private Account account;

        internal PanelHolderDetails(MasterForm master)
        {
            InitializeComponent();
            masterForm = master;
            adjustColumnWidths();
        }

        public Panel Panel { get { return panel1; } }

        internal void setupForm(Account a)
        {
            masterForm.setHolder(a.getCardHolder(1));
            this.account = masterForm.getHolder().getAccountList()[0];

            name.Text = masterForm.getHolder().getFullName();
            addy.Text = masterForm.getHolder().getAddress().Label();
            foreach (Account act in masterForm.getHolder().getAccountList())
            {
                accounts_box.Items.Add(act.getAccountNumber());
            }
            updateAccountInformation();
        }

        internal void changeAccount(Account a)
        {
            this.account = a;
        }

        private void updateAccountInformation()
        {
            masterForm.setAccount(account);
            listView1.Items.Clear();
            reveal.Enabled = true;
            decimal trx = 0;
            decimal dep = 0;
            decimal with = 0;
            decimal fees = 0;
            decimal pay = 0;
            decimal credit = 0;

            foreach (Activity act in account.getActivity())
            {
                listView1.Items.Add(new ListViewItem(new string[5] { act.Date.ToShortDateString(),
                    act.Description, act.Type.ToString(), act.Amount.ToString("0.00"), act.BalanceNow.ToString("0.00") }));
                if (act.Type == Type.TRANSACTION) { trx += act.Amount; }
                if (act.Type == Type.DEPOSIT) { dep += act.Amount; }
                if (act.Type == Type.WITHDRAWAL) { with += act.Amount; }
                if (act.Type == Type.FEE) { fees += act.Amount; }
                if (act.Type == Type.PAYMENT) { pay += act.Amount; }
                if (act.Type == Type.CREDIT) { credit += act.Amount; }
            }

            label3.Text = account.getAccountType().ToString();      
            account_num.Text = "XXXXXX" + account.getAccountNumber().ToString().Substring(masterForm.getHolder().getAccountList()[0].getAccountNumber().ToString().Length - 4);
            decimal total = trx + dep - with - fees + pay + credit;
            balance.Text = account.getBalance().ToString("0.00");
            openDate.Text = account.getOpenDate().ToShortDateString();
            trxs.Text = decimal.Round(trx, 2).ToString("0.00");
            depos.Text = decimal.Round(dep, 2).ToString("0.00");
            withdraw.Text = decimal.Round(with, 2).ToString("0.00");
            fee.Text = decimal.Round(fees, 2).ToString("0.00");
            payments.Text = decimal.Round(pay, 2).ToString("0.00");
            total_lbl.Text = decimal.Round(total, 2).ToString("0.00");
            if (account.isClosed())
            {
                closeDate.Text =account.getCloseDate().ToShortDateString();
                closed_notifyer.Visible = true;
            }
        }

        private void adjustColumnWidths()
        {
            listView1.Columns[0].Width = 90;
            listView1.Columns[1].Width = 257;
            listView1.Columns[2].Width = 121;
            listView1.Columns[3].Width = 106;
            listView1.Columns[4].Width = 111;
        }

        private void reveal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            account_num.Text = account.getAccountNumber().ToString();
            reveal.Enabled = false;
        }

        private void edit_address_Clicks(object sender, System.EventArgs e)
        {
            Button b = sender as Button;

            if (b == edit_address_bt)
            {
                edit_address_bt.Enabled = false;
                save_address_bt.Visible = true;
                cancel.Visible = true;
                address_pnl.Visible = true;
                address_pnl.BringToFront();

                line1_tb.Text = masterForm.getAccount().getCardHolder(1).getAddress().getLineOne();
                line2_tb.Text = masterForm.getAccount().getCardHolder(1).getAddress().getLineTwo();
                city_tb.Text = masterForm.getAccount().getCardHolder(1).getAddress().getCity();
                zip_tb.Text = masterForm.getAccount().getCardHolder(1).getAddress().getZip();
            }
            if (b == save_address_bt)
            {
                edit_address_bt.Enabled = true;
                save_address_bt.Visible = false;
                cancel.Visible = false;
                address_pnl.Visible = false;

                masterForm.getAccount().getCardHolder(1).setAddress(line1_tb.Text, line2_tb.Text, city_tb.Text, masterForm.getAccount().getCardHolder(1).getAddress().getState(), zip_tb.Text);
                addy.Text = masterForm.getAccount().getCardHolder(1).getAddress().Label();
            }
            if (b == cancel)
            {
                edit_address_bt.Enabled = true;
                save_address_bt.Visible = false;
                cancel.Visible = false;
                address_pnl.Visible = false;
            }
        }

        private void accounts_box_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            //MessageBox.Show(accounts_box.SelectedItem.ToString());
            var search = new Search.SearchThroughAccount();
            search.ForExactAccountNumber(masterForm.getMasterBank().getBankServices(), long.Parse(accounts_box.SelectedItem.ToString()));

            account = search.AccountSearchResults[0];
            updateAccountInformation();
        }
    }
}
