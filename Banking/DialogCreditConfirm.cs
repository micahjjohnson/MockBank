using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking
{
    public partial class DialogCreditConfirm : Form
    {
        public DialogCreditConfirm(string text)
        {
            InitializeComponent();
            label2.Text = text;
        }
    }
}
