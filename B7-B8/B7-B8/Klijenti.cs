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
    public partial class Klijenti : Form
    {
        static string connection_string = @"Data Source = 10.81.73.2, 49166;Initial Catalog = p_djordjevicE34; User ID = p_djordjevicE34; Password = p_djordjevicE34;";
        static int index = 1;
        static int max;
        public Klijenti()
        {
            InitializeComponent();
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            InputSifra.Text = "";
            InputIme.Text = "";
            InputPrezime.Text = "";
            InputAdresa.Text = "";
            InputGrad.Text = "";
            InputTelefon.Text = "";
            InputSifra.Focus();
            index = 0;
        }

        private void btnUpisi_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    SqlCommand com = new SqlCommand("Insert Into Klijent (Ime, Prezime, Adresa, Grad, BrojTelefona) " +
                        "Values (@Ime, @Prezime, @Adresa, @Grad, @Telefon)", connection);
                    com.Parameters.AddWithValue("@Ime", InputIme.Text);
                    com.Parameters.AddWithValue("@Prezime", InputPrezime.Text);
                    com.Parameters.AddWithValue("@Adresa", InputAdresa.Text);
                    com.Parameters.AddWithValue("@Grad", InputGrad.Text);
                    com.Parameters.AddWithValue("@Telefon", InputTelefon.Text);
                    connection.Open();
                    com.ExecuteNonQuery();
                    max++;
                    index = 1;
                    IzBaze();
                    MessageBox.Show("Uspesno");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!! " + ex.Message);
            }
        }

        private void btnSledeci_Click(object sender, EventArgs e)
        {
            if (index == 0)
            {
                index = max;
            }
            index++;
            if (index == max + 1)
            {
                index--;
            }
            IzBaze();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrethodni_Click(object sender, EventArgs e)
        {
            index--;
            if (index == 0 || index == -1)
            {
                index = 1;
            }
            IzBaze();
        }

        private void Klijenti_Load(object sender, EventArgs e)
        {
            IzBaze();
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("Select * From Klijent", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                max = dt.Rows.Count;
            }
        }

        private void IzBaze()
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("Select * From Klijent", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                InputSifra.Text = dt.Rows[index - 1][0].ToString();
                InputIme.Text = dt.Rows[index - 1][1].ToString();
                InputPrezime.Text = dt.Rows[index - 1][2].ToString();
                InputAdresa.Text = dt.Rows[index - 1][3].ToString();
                InputGrad.Text = dt.Rows[index - 1][4].ToString();
                InputTelefon.Text = dt.Rows[index - 1][5].ToString();
            }
        }
    }
}
