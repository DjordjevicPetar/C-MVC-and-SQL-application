using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B19_20 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void lekBolestToolStripMenuItem_Click(object sender, EventArgs e) {
            Lek_Bolest form = new Lek_Bolest();
            form.Show();
        }

        private void poProizvodjacuToolStripMenuItem_Click(object sender, EventArgs e) {
            PoProizvodjacu form = new PoProizvodjacu();
            form.Show();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
