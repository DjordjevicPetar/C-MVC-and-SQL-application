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
    public partial class Spisak : Form
    {
        public Spisak()
        {
            InitializeComponent();
        }

        private void Spisak_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'p_djordjevicE34DataSet2.Grad' table. You can move, or remove it, as needed.
            this.gradTableAdapter2.Fill(this.p_djordjevicE34DataSet2.Grad);
            // TODO: This line of code loads data into the 'p_djordjevicE34DataSet1.Grad' table. You can move, or remove it, as needed.
            this.gradTableAdapter1.Fill(this.p_djordjevicE34DataSet1.Grad);
            // TODO: This line of code loads data into the 'p_djordjevicE34DataSet.Grad' table. You can move, or remove it, as needed.
            this.gradTableAdapter.Fill(this.p_djordjevicE34DataSet.Grad);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
