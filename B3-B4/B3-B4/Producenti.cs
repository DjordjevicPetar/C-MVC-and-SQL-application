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
    public partial class Producenti : Form
    {
        static string connection_string = @"Data Source=DESKTOP-A5NTGOV\SQLEXPRESS;Initial Catalog=DVD_Kolekcija;Integrated Security=True";
        public Producenti()
        {
            InitializeComponent();
        }

        private void Producenti_Load(object sender, EventArgs e)
        {
            Napuni();
        }

        private void Napuni()
        {
            listaProducenata.Items.Clear();
            listaProducenata.Columns.Add("Sifra");
            listaProducenata.Columns.Add("Ime");
            listaProducenata.Columns.Add("E-mail");
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("Select * From Producent", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    item.SubItems.Add(row[1].ToString());
                    item.SubItems.Add(row[2].ToString());
                    listaProducenata.Items.Add(item);
                }
            }
        }

        private void Ocisti()
        {
            InputSifra.Text = "";
            InputIme.Text = "";
            InputMail.Text = "";
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpisi_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                SqlCommand command = new SqlCommand("Insert Into Producent " +
                    "Values (@Sifra, @Ime, @Mail)", connection);
                command.Parameters.AddWithValue("@Sifra", Convert.ToInt32(InputSifra.Text));
                command.Parameters.AddWithValue("@Ime", InputIme.Text);
                command.Parameters.AddWithValue("@Mail", InputMail.Text);
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
                    MessageBox.Show("Neuspesno!!! " +  ex.Message);
                }
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                SqlCommand command = new SqlCommand("Delete Producent Where ProducentId = @Sifra", connection);
                command.Parameters.AddWithValue("@Sifra", Convert.ToInt32(InputSifra.Text));
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
                    MessageBox.Show("Neuspesno!!! " + ex.Message);
                }
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                SqlCommand command = new SqlCommand("Update Producent " +
                    "Set Ime = @Ime, EMail = @Mail Where ProducentId = @Sifra", connection);
                command.Parameters.AddWithValue("@Sifra", Convert.ToInt32(InputSifra.Text));
                command.Parameters.AddWithValue("@Ime", InputIme.Text);
                command.Parameters.AddWithValue("@Mail", InputMail.Text);
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
                    MessageBox.Show("Neuspesno!!! " + ex.Message);
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
                SqlCommand command = new SqlCommand("Select * From Producent Where ProducentId = @Sifra", connection);
                command.Parameters.AddWithValue("@Sifra", Convert.ToInt32(InputSifra.Text));
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    InputIme.Text = reader[1].ToString();
                    InputMail.Text = reader[2].ToString();
                }
            }
        }
    }
}
