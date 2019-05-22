using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Banking
{
    public partial class Wizard : Form
    {
        private MasterForm masterForm;
        private List<Panel> panel;
        private PanelsNewHolder holder;
        private int rotation;

        private Account account;

        internal Wizard(MasterForm master)
        {
            InitializeComponent();
            this.masterForm = master;
            rotation = 0;
            panel = new List<Panel>();
            holder = new PanelsNewHolder();

            panel.Add(holder.Panel);
            panel.Add(holder.Panel3);
            panel.Add(holder.Panel4);
            panel.Add(holder.Panel5);

            foreach (Panel p in panel)
            {
                changer_pnl.Controls.Add(p);
                p.Location = changer_pnl.Location;
                p.Size = changer_pnl.Size;
            }
            show(rotation);
        }

        public Panel Panel { get { return panel2; } }

        public void show(int index)
        {
            panel2.BringToFront();
            switch (index)
            {
                case 0:
                    panel[3].BringToFront();
                    next.Text = "Begin";
                    back.Enabled = false;
                    break;
                case 1:
                    panel[0].BringToFront();
                    next.Text = "Next";
                    back.Enabled = false;
                    break;
                case 2:
                    panel[1].BringToFront();
                    back.Enabled = true;
                    next.Text = "Next";
                    break;
                case 3:
                    panel[2].BringToFront();
                    next.Text = "Finish";
                    break;
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (rotation < 4)
            {
                ++rotation;
                show(rotation);
            }
            if (rotation == 4)
            {
                holder.finishCreatingHolder();

                if (masterForm.getAccountType() == 1) // Checking Account
                {
                    account = new Checking();
                }
                if (masterForm.getAccountType() == 2) // Savings Account
                {
                   account = new Savings();
                }
                if (holder.getOverdraftProtectionSetting() == 1)
                {
                    account.setOverdraftProtection(true);
                }

                masterForm.getMasterBank().getBankServices().newAccount(holder.getHolder(), account);
                masterForm.setAccount(account);
                masterForm.updateView(3);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (rotation > 0)
            {
                --rotation;
                show(rotation);
            }
            else
            {
                back.Enabled = false;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            var confirm = new DialogConfirm();
            confirm.ShowDialog();

            if (confirm.DialogResult == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                masterForm.updateView(10);
            }
        }
    }
}
