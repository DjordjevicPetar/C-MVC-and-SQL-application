using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace B5
{
    public partial class Spisak : Form
    {

        public string connection_string = @"Data Source = DESKTOP-A5NTGOV\SQLEXPRESS; Database = Fudbalski_Klub; Integrated Security = true;";

        public Spisak()
        {
            InitializeComponent();
        }

        private void Spisak_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fudbalski_KlubDataSet.Grad' table. You can move, or remove it, as needed.
            this.gradTableAdapter.Fill(this.fudbalski_KlubDataSet.Grad);

        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection_string))
            {
                SqlCommand com = new SqlCommand("Select Igrac.Ime, Igrac.Prezime, Klub.NazivKluba " +
                    "From Pozicija_Igraca Join(Igrac Join Klub On Igrac.KlubID = Klub.KlubID)" +
                    " On Pozicija_Igraca.PozicijaID = Igrac.IgracID " +
                    "Where Pozicija_Igraca.Naziv = @Poz and Klub.GradID = @Grad " +
                    "Order By Igrac.Ime, Igrac.Prezime Asc; ", con);
                com.Parameters.AddWithValue("@Poz", InputPoz.Text);
                com.Parameters.AddWithValue("@Grad", Convert.ToInt32(InputGrad.SelectedValue));
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                con.Open();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
