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

namespace B3
{
    public partial class ZanroviGlumci : Form
    {
        public string connection_string = @"Data Source = DESKTOP-A5NTGOV\SQLEXPRESS; Database = DVD_Kolekcija; Integrated Security = true;";

        public ZanroviGlumci()
        {
            InitializeComponent();
        }

        private void ZanroviGlumci_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dVD_KolekcijaDataSet.Zanr' table. You can move, or remove it, as needed.
            this.zanrTableAdapter.Fill(this.dVD_KolekcijaDataSet.Zanr);

        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Clear();
            listView1.Columns.Add("Naziv");
            listView1.Columns.Add("Ime Lika");
            listView1.Columns.Add("Tip Uloge");
            using (SqlConnection con = new SqlConnection(connection_string))
            {
                SqlCommand com = new SqlCommand("Select Film.Naziv, Uloga.ImeLika, Tip_Uloge.Tip " +
                    "From Tip_Uloge Join(Glumac Join(Uloga Join Film On Uloga.FilmID = Film.FilmID) " +
                    "On Glumac.GlumacID = Uloga.GlumacID) On Tip_Uloge.TipUlogeID = Uloga.TipUlogeID " +
                    "Where Film.ZanrID = @ID and Glumac.Ime = @Ime and Glumac.Prezime = @Prezime " +
                    "Order By Film.Trajanje Desc; ", con);
                com.Parameters.AddWithValue("@ID", InputZanr.SelectedValue);
                com.Parameters.AddWithValue("@Ime", InputIme.Text);
                com.Parameters.AddWithValue("@Prezime", InputPrezime.Text);
                SqlDataAdapter ada = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["Naziv"].ToString());
                    listitem.SubItems.Add(dr["ImeLika"].ToString());
                    listitem.SubItems.Add(dr["Tip"].ToString());
                    listView1.Items.Add(listitem);
                }
            }
        }
    }
}
