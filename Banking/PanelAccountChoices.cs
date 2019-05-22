using System;
using System.Windows.Forms;

namespace Banking
{
    public partial class PanelAccountChoices : Form
    {
        private MasterForm masterForm; 

        internal PanelAccountChoices(MasterForm master)
        {
            InitializeComponent();
            this.masterForm = master;
        }

        public Panel Panel { get { return panel1; } }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;

            if (b == button1)
            {
                masterForm.setAccountType(2);
            }

            if (b == button8)
            {
                masterForm.setAccountType(1);
            }

            masterForm.updateView(2);
        }
    }
}
