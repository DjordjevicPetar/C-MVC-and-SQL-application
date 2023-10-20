using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B35_B36
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pecarosiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pecarosi form = new Pecarosi();
            form.Show();
        }

        private void ulovToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ulov form = new Ulov();
            form.Show();
        }

        private void ulovPecarosaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ulov_Pecarosa form = new Ulov_Pecarosa();
            form.Show();
        }

        private void pretragaOpisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pretraga_Opisa form = new Pretraga_Opisa();
            form.Show();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
