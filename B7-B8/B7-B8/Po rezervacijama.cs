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

namespace B7_B8
{
    public partial class Po_rezervacijama : Form
    {
        static string connection_string = @"Data Source = 10.81.73.2, 49166;Initial Catalog = p_djordjevicE34; User ID = p_djordjevicE34; Password = p_djordjevicE34;";
        public Po_rezervacijama()
        {
            InitializeComponent();
        }

        private void Po_rezervacijama_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                SqlCommand command = new SqlCommand("Select Distinct Kategorija From Hotel Order By Kategorija Asc", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    InputKategorija.Items.Add(reader[0].ToString());
                }
            }
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                SqlCommand command = new SqlCommand("Select Distinct Drzava From Hotel Order By Drzava Asc", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    InputDrzava.Items.Add(reader[0].ToString());
                }
            }
        }
    
        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPronadji_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("Select Naziv, Count(Naziv) As 'Broj Aranzmana'" +
                    "From Hotel Join Rezervacija_Hotela On Hotel.HotelID = Rezervacija_Hotela.HotelID " +
                    "Where Drzava = @Drzava and Kategorija = @Kategorija and DatumRezervacije < @Do and DatumRezervacije > @Od " +
                    "Group By Naziv", connection);
                adapter.SelectCommand.Parameters.AddWithValue("@Drzava", InputDrzava.Text);
                adapter.SelectCommand.Parameters.AddWithValue("@Kategorija", InputKategorija.Text);
                adapter.SelectCommand.Parameters.AddWithValue("@Do", InputDo.SelectionStart.ToString());
                adapter.SelectCommand.Parameters.AddWithValue("@Od", InputOd.SelectionStart.ToString());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
