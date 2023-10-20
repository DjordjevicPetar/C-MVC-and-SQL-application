using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B3_B4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void glumciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Glumci form = new Glumci();
            form.Show();
        }

        private void producentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producenti form = new Producenti();
            form.Show();
        }

        private void poZanrovimaIGlumcimaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Zanrovi_i_glumci form = new Zanrovi_i_glumci();
            form.Show();
        }

        private void poTipuUlogeIProducentuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vrste_uloge_i_producenti form = new Vrste_uloge_i_producenti();
            form.Show();
        }
    }
}
