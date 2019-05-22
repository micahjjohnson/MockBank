using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking
{
    internal partial class PanelSwipe : Form
    {
        private MasterForm master;

        public Panel SwipePanel { get { return swipe_pnl; } }

        public PanelSwipe(MasterForm master)
        {
            InitializeComponent();
            this.master = master;
        }

        public PanelSwipe()
        {
            InitializeComponent();
        }

        private async void swipe_form_Click(object sender, EventArgs e)
        {
            progress_pnl.Visible = true;
            var card_reader = new FormCardReader();

            await Task.Run(() =>
            {
                card_reader.ShowDialog();
            });

            swipe_form.Enabled = true;
            if (card_reader.DialogResult == DialogResult.Cancel)
            {
                card_reader.Close();
            }
            if (card_reader.DialogResult == DialogResult.OK)
            {
                //MessageBox.Show(card_reader.enteredText());
                /*var account_verify = new CardReaderAccountVerification(bankServices.CardCollection);

                if (account_verify.validate(card_reader.enteredText()))
                {
                    openDepositForm(account_verify.getAccount());
                }
                else
                {
                    MessageBox.Show("Error. Please try again.");
                }
            }*/
            }
        }
    }
}
