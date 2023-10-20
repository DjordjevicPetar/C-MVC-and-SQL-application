using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B9_B10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void krajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tipAntikvitetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tip_antikviteta form = new Tip_antikviteta();
            form.Show();
        }

        private void lokalitetiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Periodi form = new Periodi();
            form.Show();
        }

        private void poArheologuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Po_arheologu form = new Po_arheologu();
            form.Show();
        }

        private void poTipuAntikvitetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Po_tipu_antikviteta form = new Po_tipu_antikviteta();
            form.Show();
        }
    }
}
