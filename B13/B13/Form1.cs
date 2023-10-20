using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void krajRadaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void knjigeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unos_knjiga form = new Unos_knjiga();
            form.Show();
        }

        private void poKategorijamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Po_kategorijama form = new Po_kategorijama();
            form.Show();
        }
    }
}
