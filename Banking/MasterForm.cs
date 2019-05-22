namespace Banking
{
    internal class MasterForm
    {
        private MasterBank masterBank;
        private Holder holder;
        private Account account;
        private Form1 mainForm;
        private int view;
        private int acct_type;

        internal MasterForm(MasterBank master)
        {
            masterBank = master;
            mainForm = new Form1(this);
        }

        internal void setAccountType(int x)
        {
            acct_type = x;
        }

        internal int getAccountType()
        {
            return acct_type;
        }

        internal MasterBank getMasterBank()
        {
            return masterBank;
        }

        internal Form1 getMainForm()
        {
            return mainForm;
        }

        internal Account getAccount()
        {
            return account;
        }

        internal Holder getHolder()
        {
            return holder;
        }

        internal void updateView(int v)
        {
            view = v;
            setView();
        }

        private void setView()
        {
            if (view == 0) // success page
            {
                var success = new PanelSuccess(this);
                mainForm.showBackButton(false);
                mainForm.enableServiceButtons(false);
                mainForm.appendToPanel(success.Panel, @"default.png");
            }
            if (view == 1)   // account holder view
            {
                if (account.isClosed())
                {
                    mainForm.enableServiceButtons(false);
                }
                else
                {
                    mainForm.enableServiceButtons(true);
                }
                mainForm.showBackButton(false);
                PanelHolderDetails fh = new PanelHolderDetails(this);
                fh.setupForm(account);
                mainForm.appendToPanel(fh.Panel, @"newholder.png");
            }
            if (view == 2)   // new account holder view
            {
                var wizard = new Wizard(this);
                mainForm.enableServiceButtons(false);
                mainForm.appendToPanel(wizard.Panel, @"default.png");
            }
            if (view == 3) // deposit view
            {
                var deposit = new PanelDeposit(this); ;
                mainForm.appendToPanel(deposit.Panel, @"deposit.png");
            }
            if (view == 4) // fee view
            {
                var creditPanel = new PanelFeeViewer(this);
                creditPanel.setupForm();
                mainForm.enableServiceButtons(false);
                mainForm.appendToPanel(creditPanel.Panel, @"default.png");
            }
            if (view == 5) // transfer funds view
            {
                var transfer = new PanelTransfer(this);
                transfer.setupForm();
                mainForm.enableServiceButtons(false);
                mainForm.appendToPanel(transfer.Panel, @"default.png");
            }
            if (view == 10) // home page
            {
                mainForm.showHome();
            }
        }

        internal void setHolder(Holder h)
        {
            holder = h;
            account = h.getAccountList()[0];
        }

        internal void setAccount(Account a)
        {
            account = a;
            holder = a.getCardHolder(1);
        }

        internal int getView()
        {
            return view;
        }
    }
}
