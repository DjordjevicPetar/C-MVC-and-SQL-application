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
    public partial class Glumci : Form
    {
        public string connection_string = @"Data Source = DESKTOP-A5NTGOV\SQLEXPRESS; Database = DVD_Kolekcija; Integrated Security = true;";
        public Glumci()
        {
            InitializeComponent();
        }

        private void Glumci_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            Napuni();
        }

        public void Napuni()
        {
            listView1.Clear();
            listView1.Columns.Add("ID");
            listView1.Columns.Add("Ime");
            listView1.Columns.Add("Prezime");
            listView1.Columns.Add("Datum");
            listView1.Columns.Add("Mesto");
            using (SqlConnection con = new SqlConnection(connection_string))
            {
                SqlDataAdapter ada = new SqlDataAdapter("Select * From Glumac", con);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["GlumacID"].ToString());
                    listitem.SubItems.Add(dr["Ime"].ToString());
                    listitem.SubItems.Add(dr["Prezime"].ToString());
                    listitem.SubItems.Add(dr["DatumRodjenja"].ToString());
                    listitem.SubItems.Add(dr["MestoRodjenja"].ToString());
                    listView1.Items.Add(listitem);
                }
            }
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpisi_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection_string))
            {
                try
                {
                    SqlCommand com = new SqlCommand("Insert Into Glumac Values(@ID, @Ime, @Prezime, @Datum, @Mesto);",con);
                    com.Parameters.AddWithValue("@ID", Convert.ToInt32(InputSifra.Text));
                    com.Parameters.AddWithValue("@Ime", InputIme.Text);
                    com.Parameters.AddWithValue("@Prezime", InputPrezime.Text);
                    com.Parameters.AddWithValue("@Datum", InputDatum.Text);
                    com.Parameters.AddWithValue("@Mesto", InputMesto.Text);
                    con.Open();
                    com.ExecuteNonQuery();
                    Napuni();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection_string))
            {
                try
                {
                    SqlCommand com = new SqlCommand("Update Glumac Set GlumacID = @ID, Ime = @Ime," +
                        " Prezime = @Prezime, DatumRodjenja = @Datum, MestoRodjenja = @Mesto Where GlumacID = @ID;", con);
                    com.Parameters.AddWithValue("@ID", Convert.ToInt32(InputSifra.Text));
                    com.Parameters.AddWithValue("@Ime", InputIme.Text);
                    com.Parameters.AddWithValue("@Prezime", InputPrezime.Text);
                    com.Parameters.AddWithValue("@Datum", InputDatum.Text);
                    com.Parameters.AddWithValue("@Mesto", InputMesto.Text);
                    con.Open();
                    com.ExecuteNonQuery();
                    Napuni();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection_string))
            {
                try
                {
                    SqlCommand com = new SqlCommand("Delete From Glumac Where GlumacID = @ID;", con);
                    com.Parameters.AddWithValue("@ID", Convert.ToInt32(InputSifra.Text));
                    com.Parameters.AddWithValue("@Ime", InputIme.Text);
                    com.Parameters.AddWithValue("@Prezime", InputPrezime.Text);
                    com.Parameters.AddWithValue("@Datum", InputDatum.Text);
                    com.Parameters.AddWithValue("@Mesto", InputMesto.Text);
                    con.Open();
                    com.ExecuteNonQuery();
                    Napuni();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
