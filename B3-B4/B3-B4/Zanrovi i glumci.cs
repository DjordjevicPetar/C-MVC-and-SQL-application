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

namespace B3_B4
{
    public partial class Zanrovi_i_glumci : Form
    {
        static string connection_string = @"Data Source=DESKTOP-A5NTGOV\SQLEXPRESS;Initial Catalog=DVD_Kolekcija;Integrated Security=True";
        public Zanrovi_i_glumci()
        {
            InitializeComponent();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("Select Naziv, ImeLika, Tip " +
                    "From Film Join((Uloga Join Glumac On Uloga.GlumacID = Glumac.GlumacID) " +
                    "Join Tip_Uloge On Uloga.TipUlogeID = Tip_Uloge.TipUlogeID) On Film.FilmID = Uloga.FilmID " +
                    "Where ZanrID = @Zanr And Ime = @Ime And Prezime = @Prezime Order By Trajanje Desc; ", connection);
                adapter.SelectCommand.Parameters.AddWithValue("@Zanr", Convert.ToInt32(InputZanr.SelectedValue.ToString()));
                adapter.SelectCommand.Parameters.AddWithValue("@Ime", InputIme.Text);
                adapter.SelectCommand.Parameters.AddWithValue("@Prezime", InputPrezime.Text);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void Zanrovi_i_glumci_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("Select ZanrID, NazivZanra From Zanr Order By NazivZanra Asc", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                InputZanr.DataSource = dt;
                InputZanr.ValueMember = "ZanrID";
                InputZanr.DisplayMember = "NazivZanra";
            }
        }
    }
}
