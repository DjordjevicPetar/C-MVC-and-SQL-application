﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void prijavaPasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrijavaPasa form = new PrijavaPasa();
            form.Show();
        }
    }
}
