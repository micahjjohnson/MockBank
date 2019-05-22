using System;
using System.Drawing;
using System.Windows.Forms;

namespace Banking
{
    public partial class PanelSearch : Form
    {
        private MasterForm masterForm;

        internal PanelSearch(MasterForm master)
        {
            InitializeComponent();
            this.masterForm = master;

            var swipe = new PanelSwipe();
            swipe.SwipePanel.Location = new Point(6, 116);
            panel1.Controls.Add(swipe.SwipePanel);
        }

        internal Panel Panel { get { return panel1; } }

        private bool atLeastOneFieldIsFilled()
        {
            return acct_num.Text.Length > 0 || name.Text.Length > 0 ||
                textBox7.Text.Length > 0;
        }

        private void clearFields()
        {
            acct_num.Clear();
            name.Clear();
            textBox7.Clear();
        }

        private void clear_text_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;

            if (b == clear_all)
            {
                clearFields();
            }
            if (b == button2) { acct_num.Clear(); }
            if (b == button3) { name.Clear(); }
            if (b == button6) { textBox7.Clear(); }
        }

        private void search_proceed_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            listBox2.Items.Clear();

            if (atLeastOneFieldIsFilled())
            {
                var search = new Search.SearchThroughAccount();
                search.ForAccountNumber(masterForm.getMasterBank().getBankServices(), long.Parse(acct_num.Text));

                if (search.accountIsFound())
                {
                    foreach (Account a in search.AccountSearchResults)
                    {
                        listBox2.Items.Add(a.data());
                    }
                }
                else
                {
                    listBox2.Items.Add("No results found.");
                }
            }
        }

        private void search_results_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var search = new Search.SearchThroughAccount();
                search.ForDataString(masterForm.getMasterBank().getBankServices(), listBox2.SelectedItem.ToString());
                var account = search.AccountSearchResults[0];
                masterForm.setAccount(account);
                masterForm.updateView(1);
                listBox2.Items.Clear();
            }
            catch { }
        }
    }
}
