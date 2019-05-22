using System;
using System.Windows.Forms;

namespace Banking
{
    public partial class PanelDeposit : Form
    {
        private MasterForm master;
        private decimal total;

        internal PanelDeposit(MasterForm master)
        {
            InitializeComponent();
            label1.TextChanged += text_changed;
            this.master = master;
            name.Text = master.getAccount().getCardHolder(1).getFullName();
            account_num.Text = master.getAccount().getAccountNumber().ToString();
            balance.Text = master.getAccount().getBalance().ToString("0.00");
        }

        public Panel Panel { get { return panel1; } }

        private decimal parseTextBox(TextBox t)
        {
            try { return decimal.Parse(t.Text); }
            catch { return 0; }
        }

        private void calculate()
        {
            decimal one = parseTextBox(textBox1) * 1;
            decimal two = parseTextBox(textBox2) * 2;
            decimal five = parseTextBox(textBox3) * 5;
            decimal ten = parseTextBox(textBox4) * 10;
            decimal twenty = parseTextBox(textBox5) * 20;
            decimal fifty = parseTextBox(textBox6) * 50;
            decimal hundred = parseTextBox(textBox7) * 100;
            decimal oneC = parseTextBox(textBox9) * .01m;
            decimal fiveC = parseTextBox(textBox10) * .05m; ;
            decimal tenC = parseTextBox(textBox11) * .1m;
            decimal quarter = parseTextBox(textBox12) * .25m;
            decimal halfDollar = parseTextBox(textBox13) * .5m;
            decimal oneDollarC = parseTextBox(textBox14) * 1;
            total = one + two + five + ten + twenty + fifty + hundred + fiveC + tenC + quarter + halfDollar + oneDollarC;

            label1.Text = one.ToString();
            label2.Text = two.ToString();
            label3.Text = five.ToString();
            label4.Text = ten.ToString();
            label5.Text = twenty.ToString();
            label6.Text = fifty.ToString();
            label7.Text = one.ToString();
            label41.Text = oneC.ToString();
            label44.Text = fiveC.ToString();
            label43.Text = tenC.ToString();
            label42.Text = quarter.ToString();
            label40.Text = halfDollar.ToString();
            label39.Text = oneDollarC.ToString();
            label8.Text = total.ToString();
        }

        private void text_changed(object sender, EventArgs e)
        {
            calculate();
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (total != 0)
            {
                master.getMasterBank().getAccountServices().deposit(master.getAccount(), total, 1);
                master.updateView(0);
            }
        }
    }
}
