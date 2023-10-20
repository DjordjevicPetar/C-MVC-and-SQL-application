using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B27_28
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

        private void roditeljiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Roditelji form = new Roditelji();
            form.Show();
        }

        private void decaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deca form = new Deca();
            form.Show();
        }

        private void brojDeceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrojDece form = new BrojDece();
            form.Show();
        }

        private void uzrastDeceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UzrastDece form = new UzrastDece();
            form.Show();
        }
    }
}
