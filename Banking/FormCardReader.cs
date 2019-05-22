using System;
using System.Windows.Forms;

namespace Banking
{
    public partial class FormCardReader : Form
    {
        public FormCardReader()
        {
            InitializeComponent();
        }

        public string enteredText() { return display.Text; }

        private void enableNumberPanel()
        {
            one.Enabled = true;
            two.Enabled = true;
            three.Enabled = true;
            four.Enabled = true;
            five.Enabled = true;
            six.Enabled = true;
            seven.Enabled = true;
            eight.Enabled = true;
            nine.Enabled = true;
            zero.Enabled = true;
            clear.Enabled = true;
            back.Enabled = true;
            submit.Enabled = true;
        }

        private void one_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;

            if (display.Text.Length <= 10)
            {
                if (b == one) { display.AppendText("1"); }
                if (b == two) { display.AppendText("2"); }
                if (b == three) { display.AppendText("3"); }
                if (b == four) { display.AppendText("4"); }
                if (b == five) { display.AppendText("5"); }
                if (b == six) { display.AppendText("6"); }
                if (b == seven) { display.AppendText("7"); }
                if (b == eight) { display.AppendText("8"); }
                if (b == nine) { display.AppendText("9"); }
                if (b == zero) { display.AppendText("0"); }
            }
            if (b == clear) { display.Clear(); }
            if (b == back)
            {
                try
                {
                    display.Text = display.Text.Remove(display.Text.Length - 1, 1);
                }
                catch { }
            }
            if (b == submit)
            {
                if (display.Text.Length != 0)
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void swiper_Click(object sender, EventArgs e)
        {
            enableNumberPanel();
            label.Text = "ENTER PIN";
        }
    }
}
