using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void glumciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Glumci form = new Glumci();
            form.Show();
        }

        private void poZanrovimaIGlumcimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZanroviGlumci form = new ZanroviGlumci();
            form.Show();
        }
    }
}
