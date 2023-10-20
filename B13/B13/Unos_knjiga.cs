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

namespace B13
{
    public partial class Unos_knjiga : Form
    {
        public Unos_knjiga()
        {
            InitializeComponent();
        }

        private void Unos_knjiga_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kolekcija_KnjigaDataSet.Kategorija' table. You can move, or remove it, as needed.
            this.kategorijaTableAdapter2.Fill(this.kolekcija_KnjigaDataSet.Kategorija);

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            InputNaziv.Enabled = false;
            InputBS.Enabled = false;
            InputKat.Enabled = false;
            InputKom.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            InputNaziv.Enabled = true;
            InputBS.Enabled = true;
            InputKat.Enabled = true;
            InputKom.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-A5NTGOV\\SQLEXPRESS;Initial Catalog=Kolekcija Knjiga;Integrated Security = True;");
                con.Open();
                SqlCommand com = new SqlCommand("Insert Into Knjiga(KnjigaID, Naziv, BrojStrana, KategorijaID, Komentar) Values (@Sifra, @Naziv, @BS, @Kat, @Kom);", con);
                com.Parameters.AddWithValue("@Sifra", Convert.ToInt32(InputSifra.Text));
                com.Parameters.AddWithValue("@Naziv", InputNaziv.Text);
                com.Parameters.AddWithValue("@BS", Convert.ToInt32(InputBS.Text));
                com.Parameters.AddWithValue("@Kat", Convert.ToInt32(InputKat.SelectedValue));
                com.Parameters.AddWithValue("@Kom", InputKom.Text);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Uspesno");
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-A5NTGOV\\SQLEXPRESS;Initial Catalog=Kolekcija Knjiga;Integrated Security = True;");
                con.Open();
                SqlCommand com = new SqlCommand("Delete From Knjiga Where KnjigaID = @Sifra;", con);
                com.Parameters.AddWithValue("@Sifra", Convert.ToInt32(InputSifra.Text));
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Uspesno");
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        private void InputSifra_TextChanged(object sender, EventArgs e)
        {
            InputNaziv.Text = "";
            InputBS.Text = "";
            InputKat.Text = "";
            InputKom.Text = "";
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-A5NTGOV\\SQLEXPRESS;Initial Catalog=Kolekcija Knjiga;Integrated Security = True;");
                con.Open();
                SqlCommand com = new SqlCommand("Select * From Knjiga Where KnjigaID = @Sifra;", con);
                com.Parameters.AddWithValue("@Sifra", Convert.ToInt32(InputSifra.Text));
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                InputNaziv.Text = dr.GetValue(1).ToString();
                InputBS.Text = dr.GetValue(2).ToString();
                InputKat.Text = dr.GetValue(3).ToString();
                InputKom.Text = dr.GetValue(4).ToString();
                con.Close();
            }
            catch
            {

            }
        }
    }
}
