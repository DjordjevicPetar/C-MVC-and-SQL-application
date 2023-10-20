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
    public partial class Glumci : Form
    {
        static string connection_string = @"Data Source=DESKTOP-A5NTGOV\SQLEXPRESS;Initial Catalog=DVD_Kolekcija;Integrated Security=True";
        public Glumci()
        {
            InitializeComponent();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Glumci_Load(object sender, EventArgs e)
        {
            Napuni();
        }

        private void Napuni()
        {
            /*Obavezno staviti ListView-ev View kao Details u Properties.*/
            lista_glumaca.Clear();
            lista_glumaca.Columns.Add("Sifra");
            lista_glumaca.Columns.Add("Ime");
            lista_glumaca.Columns.Add("Prezime");
            lista_glumaca.Columns.Add("Datum rodjenja");
            lista_glumaca.Columns.Add("Mesto rodjenja");
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("Select * From Glumac", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    try
                    {
                        ListViewItem viewItem = new ListViewItem(row[0].ToString());
                        viewItem.SubItems.Add(row[1].ToString());
                        viewItem.SubItems.Add(row[2].ToString());
                        viewItem.SubItems.Add(row[3].ToString());
                        viewItem.SubItems.Add(row[4].ToString());
                        lista_glumaca.Items.Add(viewItem);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
        }

        private void btnUpisi_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                SqlCommand command = new SqlCommand("Insert Into Glumac " +
                    "Values (@Id, @Ime, @Prezime, @Datum, @Mesto)", connection);
                command.Parameters.AddWithValue("@Id", Convert.ToInt32(InputSifra.Text));
                command.Parameters.AddWithValue("@Ime", InputIme.Text);
                command.Parameters.AddWithValue("@Prezime", InputPrezime.Text);
                command.Parameters.AddWithValue("@Datum", InputDatum.Text);
                command.Parameters.AddWithValue("@Mesto", InputMesto.Text);
                connection.Open();
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Uspesno");
                    Napuni();
                    Ocisti();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Neuspesno!!!\n" + ex.Message);
                }
            }
        }

        private void InputSifra_TextChanged(object sender, EventArgs e)
        {
            if (InputSifra.Text == "")
            {
                Ocisti();
                return;
            }
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                SqlCommand command = new SqlCommand("Select * From Glumac Where GlumacID = @Id", connection);
                command.Parameters.AddWithValue("@Id", Convert.ToInt32(InputSifra.Text));
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    reader.Read();
                    InputIme.Text = reader[1].ToString();
                    InputPrezime.Text = reader[2].ToString();
                    InputDatum.Text = reader[3].ToString();
                    InputMesto.Text = reader[4].ToString();
                }
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                SqlCommand command = new SqlCommand("Delete From Glumac Where GlumacID = @Id;", connection);
                command.Parameters.AddWithValue("@Id", Convert.ToInt32(InputSifra.Text));
                connection.Open();
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Uspesno");
                    Napuni();
                    Ocisti();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Neuspesno!!!\n" + ex.Message);
                }
            }
        }

        private void BtnIzmeni_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                SqlCommand command = new SqlCommand("Update Glumac Set Ime = @Ime, " +
                    "Prezime = @Prezime, DatumRodjenja = @Datum, MestoRodjenja = @Mesto " +
                    "Where GlumacID = @Id", connection);
                command.Parameters.AddWithValue("@Id", Convert.ToInt32(InputSifra.Text));
                command.Parameters.AddWithValue("@Ime", InputIme.Text);
                command.Parameters.AddWithValue("@Prezime", InputPrezime.Text);
                command.Parameters.AddWithValue("@Datum", InputDatum.Text);
                command.Parameters.AddWithValue("@Mesto", InputMesto.Text);
                connection.Open();
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Uspesno");
                    Napuni();
                    Ocisti();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Neuspesno!!!\n" + ex.Message);
                }
            }
        }

        private void Ocisti()
        {
            InputSifra.Text = "";
            InputIme.Text = "";
            InputPrezime.Text = "";
            InputDatum.Text = "";
            InputMesto.Text = "";
        }
    }
}
