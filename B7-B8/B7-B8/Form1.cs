using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B7_B8
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

        private void destinacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Destinacija form = new Destinacija();
            form.Show();
        }

        private void klijentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Klijenti form = new Klijenti();
            form.Show();
        }

        private void poAranzmanimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Po_aranzmanima form = new Po_aranzmanima();
            form.Show();
        }

        private void poRezervaijamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Po_rezervacijama form = new Po_rezervacijama();
            form.Show();
        }
    }
}
