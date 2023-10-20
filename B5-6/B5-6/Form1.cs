using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B5_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void krajRadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void unosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gradovi form = new Gradovi();
            form.Show();
        }

        private void spisakIgracaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Spisak form = new Spisak();
            form.Show();
        }
    }
}
