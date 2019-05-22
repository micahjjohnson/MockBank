﻿using System;
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
    public partial class PanelSuccess : Form
    {
        private MasterForm master;

        internal PanelSuccess(MasterForm masterForm)
        {
            InitializeComponent();
            master = masterForm;
        }

        public Panel Panel { get { return panel1; } }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            master.updateView(10);
        }
    }
}
