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

namespace B13_B14
{
    public partial class Autori : Form
    {
        static string connection_string = @"Data Source=10.81.73.2, 49166;Initial Catalog=p_djordjevicE34;User ID=p_djordjevicE34;Password=p_djordjevicE34";
        public Autori()
        {
            InitializeComponent();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioBrisanje_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBrisanje.Checked == true)
            {
                InputSifra.Enabled = true;
                InputIme.Enabled = false;
                InputIme.Clear();
                InputPrezime.Enabled = false;
                InputPrezime.Clear();
                InputDatum.Enabled = false;
                InputDatum.Text = "";
                btnUpisi.Enabled = false;
                btnObrisi.Enabled = true;
            }
            else
            {
                InputSifra.Enabled = false;
                InputSifra.Clear();
                InputIme.Clear();
                InputPrezime.Clear();
                InputDatum.Text = "";
                InputIme.Enabled = true;
                InputPrezime.Enabled = true;
                InputDatum.Enabled = true;
                btnUpisi.Enabled = true;
                btnObrisi.Enabled = false;
            }
        }

        private void btnUpisi_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    SqlCommand command = new SqlCommand("Insert Into Autor (Ime, Prezime, DatumRodjenja) Values (@Ime, @Prezime, @Datum);", connection);
                    command.Parameters.AddWithValue("@Ime", InputIme.Text);
                    command.Parameters.AddWithValue("@Prezime", InputPrezime.Text);
                    command.Parameters.AddWithValue("@Datum", InputDatum.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Uspesno");
                    InputSifra.Clear();
                    InputIme.Clear();
                    InputPrezime.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Neuspesno!! " + ex.Message);
            }
        }

        private void InputSifra_TextChanged(object sender, EventArgs e)
        {
            if (InputSifra.Text == "")
            {
                InputIme.Clear();
                InputPrezime.Clear();
                return;
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    SqlCommand command = new SqlCommand("Select * From Autor Where AutorId = @Id", connection);
                    command.Parameters.AddWithValue("@Id", InputSifra.Text);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    InputIme.Text = reader[1].ToString();
                    InputPrezime.Text = reader[2].ToString();
                    InputDatum.Text = reader[3].ToString();
                }
            }
            catch (Exception)
            {
                InputIme.Clear();
                InputPrezime.Clear();
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    SqlCommand command = new SqlCommand("Delete From Autor Where AutorId = @Id", connection);
                    command.Parameters.AddWithValue("@Id", InputSifra.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Uspesno");
                    InputSifra.Clear();
                    InputIme.Clear();
                    InputPrezime.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Neuspesno!! " + ex.Message);
            }
        }
    }
}
