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

namespace B9_B10
{
    public partial class Periodi : Form
    {
        static string connection_string = @"Data Source=10.81.73.2, 49166;Initial Catalog = p_djordjevicE34; User ID = p_djordjevicE34; Password = p_djordjevicE34";
        public Periodi()
        {
            InitializeComponent();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InputSifra_TextChanged(object sender, EventArgs e)
        {
            if (InputSifra.Text == "")
            {
                InputNaziv.Text = "";
                return;
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    SqlCommand command = new SqlCommand("Select Period From Period Where PeriodID = @Id", connection);
                    command.Parameters.AddWithValue("@Id", Convert.ToInt32(InputSifra.Text));
                    connection.Open();
                    InputNaziv.Text = command.ExecuteScalar().ToString();
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnUpisi_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    SqlCommand command = new SqlCommand("Insert Into Period Values (@Id, @Naziv)", connection);
                    command.Parameters.AddWithValue("@Id", Convert.ToInt32(InputSifra.Text));
                    command.Parameters.AddWithValue("@Naziv", InputNaziv.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Uspesno");
                    InputSifra.Clear();
                    InputNaziv.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!! " + ex.Message);
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    SqlCommand command = new SqlCommand("Update Period Set Period = @Naziv Where PeriodID = @Id", connection);
                    command.Parameters.AddWithValue("@Id", Convert.ToInt32(InputSifra.Text));
                    command.Parameters.AddWithValue("@Naziv", InputNaziv.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Uspesno");
                    InputSifra.Clear();
                    InputNaziv.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!! " + ex.Message);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    SqlCommand command = new SqlCommand("Delete From Period Where PeriodID = @Id", connection);
                    command.Parameters.AddWithValue("@Id", Convert.ToInt32(InputSifra.Text));
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Uspesno");
                    InputSifra.Clear();
                    InputNaziv.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!! " + ex.Message);
            }
        }
    }
}
