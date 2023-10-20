using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B3_B4
{
    public partial class Vrste_uloge_i_producenti : Form
    {
        static string connection_string = @"Data Source=DESKTOP-A5NTGOV\SQLEXPRESS;Initial Catalog=DVD_Kolekcija;Integrated Security=True";
        public Vrste_uloge_i_producenti()
        {
            InitializeComponent();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Vrste_uloge_i_producenti_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("Select * From Tip_Uloge Order By Tip Asc", connection);
                DataTable Uloge = new DataTable();
                adapter.Fill(Uloge);
                adapter.SelectCommand.CommandText = "Select * From Producent Order By Ime Asc";
                DataTable Producent = new DataTable();
                adapter.Fill(Producent);
                InputTipUloge.DataSource = Uloge;
                InputTipUloge.ValueMember = "TipUlogeID";
                InputTipUloge.DisplayMember = "Tip";
                InputProducent.DataSource = Producent;
                InputProducent.ValueMember = "ProducentID";
                InputProducent.DisplayMember = "Ime";
            }
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("Select Naziv, Zanr.NazivZanra, Glumac.Ime, Prezime " +
                    "From((Film Join Zanr On Film.ZanrID = Zanr.ZanrID) " +
                    "Join(Producirao Join Producent On Producent.ProducentID = Producirao.ProducentID) On Film.FilmID = Producirao.FilmID) " +
                    "Join(Uloga Join Glumac On Uloga.GlumacID = Glumac.GlumacID) On Film.FilmID = Uloga.FilmID " +
                    "Where TipUlogeID = @Uloga And Producent.ProducentID = @Producent Order By Film.Naziv Asc; ", connection);
                adapter.SelectCommand.Parameters.AddWithValue("@Uloga", (int)InputTipUloge.SelectedValue);
                adapter.SelectCommand.Parameters.AddWithValue("@Producent", (int)InputProducent.SelectedValue);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
