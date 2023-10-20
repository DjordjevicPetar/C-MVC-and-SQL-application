using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B13_B14
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

        private void knjigeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Knjige form = new Knjige();
            form.Show();
        }

        private void autoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Autori form = new Autori();
            form.Show();
        }

        private void poKategorijamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Po_kategorijama form = new Po_kategorijama();
            form.Show();
        }

        private void poAutorimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PoAutorima form = new PoAutorima();
            form.Show();
        }
    }
}
