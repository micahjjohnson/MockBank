using System;
using System.Drawing;
using System.Windows.Forms;

namespace Banking
{
    public partial class PanelsNewHolder : Form
    {
        private Holder holder;
        private int ov_protec;

        public PanelsNewHolder()
        {
            InitializeComponent();
        }

        public Panel Panel { get { return panel1; } }
        public Panel Panel3 { get { return panel5; } }
        public Panel Panel4 { get { return panel6; } }
        public Panel Panel5 { get { return panel9; } }

        internal Holder getHolder()
        {
            return holder;
        }

        internal int getOverdraftProtectionSetting()
        {
            return ov_protec;
        }

        internal void finishCreatingHolder()
        {
            holder = new Holder();
            holder.setPersonDetails(first.Text, last.Text, phone.Text, email.Text);
            holder.setAddress(line1.Text, line2.Text, city.Text, state.SelectedItem.ToString(), zip.Text);
            //holder.getAddress().extraDetails(county.Text, country.SelectedItem.ToString());

            if (cardRequest.Checked)
            {
                //acct.addCard(bankResources.nextCard());
            }

            if (ov_no_rb.Checked) { ov_protec = 0; }
            if (ov_yes_rb.Checked) { ov_protec = 1; }
        }

        private void more_on_overdraft_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var dia = new DialogOverdraftProtection();
            dia.Location = new Point(447, 37);
            dia.ShowDialog();
        }
    }
}
