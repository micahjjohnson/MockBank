using System;
using System.Windows.Forms;

namespace Banking
{
    public partial class PanelFeeViewer : Form
    {
        private MasterForm master;
        private int count;

        internal PanelFeeViewer(MasterForm master)
        {
            InitializeComponent();
            this.master = master;
            name.Text = master.getAccount().getCardHolder(1).getFullName();
            account_num.Text = master.getAccount().getAccountNumber().ToString();
        }

        internal Panel Panel { get { return panel1; } }

        internal void setupForm()
        {
            fee_options.Items.Clear();
            foreach (Activity a in master.getAccount().getActivity())
            {
                if (a.Type == Type.FEE)
                {
                    if (!a.getAdjustedValue())
                    {
                        fee_options.Items.Add(a.data());
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fee_options.SelectedItem != null)
            {
                var search = new Search.SearchForActivity();
                search.ForDataString(master.getAccount(), fee_options.SelectedItem.ToString());
                var activity = search.ActivitySearchResults[0];
                var dialog = new DialogCreditConfirm(activity.data());
                dialog.ShowDialog();

                if (dialog.DialogResult == DialogResult.OK)
                {
                    ++count;
                    credit_count.Text = count.ToString();
                    activity.adjustActivity(true);

                    master.getMasterBank().getAccountServices().creditAccount(master.getAccount(), activity.Amount);
                    setupForm();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            master.updateView(0);
        }
    }
}
