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

namespace B35_B36
{
    public partial class Ulov : Form
    {
        static string connection_string = @"Data Source = 10.81.73.2, 49166;Initial Catalog = p_djordjevicE34;User ID = p_djordjevicE34;Password = p_djordjevicE34";
        static int max = 0;
        public Ulov()
        {
            InitializeComponent();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Ulov_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                SqlCommand command = new SqlCommand("Select Str(PecarosID) + '-' + Ime + ' ' + Prezime From Pecaros", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    InputPecaros.Items.Add(reader[0]);
                }
                reader.Close();
                SqlDataAdapter adapter = new SqlDataAdapter("Select VrstaID, Naziv From Vrsta_Ribe", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                InputVrsta.DataSource = dt;
                InputVrsta.ValueMember = "VrstaID";
                InputVrsta.DisplayMember = "Naziv";
                InputVrsta.Text = "Izaberite vrstu ribe:";
                command.CommandText = "Select Max(RbrUlova) From Ulov";
                max = Convert.ToInt32(command.ExecuteScalar());
                InputBrojUlova.Text = (max + 1).ToString();
            }
        }

        private void radioObrisi_CheckedChanged(object sender, EventArgs e)
        {
            if (radioObrisi.Checked)
            {
                InputBrojUlova.Text = max.ToString();
                InputVrsta.Text = "Izaberite vrstu ribe:";
                InputPecaros.Text = "";
                InputDatum.Clear();
                InputVreme.Clear();
            }
            else
            {
                InputBrojUlova.Text = (max + 1).ToString();
                InputVrsta.Text = "Izaberite vrstu ribe:";
                InputPecaros.Text = "";
                InputDatum.Clear();
                InputVreme.Clear();
            }
        }

        private void btnIzvrsi_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    SqlCommand command = new SqlCommand("", connection);
                    if (radioUpisi.Checked)
                    {
                        command.CommandText = "Insert Into Ulov Values (@Pecaros, @Rbr, @Datum, @Vreme, @Vrsta)";
                        command.Parameters.AddWithValue("@Pecaros", InputPecaros.Text.Split('-')[0]);
                        command.Parameters.AddWithValue("@Rbr", InputBrojUlova.Text);
                        command.Parameters.AddWithValue("@Datum", InputDatum.Text);
                        command.Parameters.AddWithValue("@Vreme", InputVreme.Text);
                        command.Parameters.AddWithValue("@Vrsta", InputVrsta.SelectedValue);
                        max += 1;
                        InputBrojUlova.Text = (max + 1).ToString();
                        InputVrsta.Text = "Izaberite vrstu ribe:";
                        InputPecaros.Text = "";
                        InputDatum.Clear();
                        InputVreme.Clear();
                    }
                    else
                    {
                        command.CommandText = "Delete From Ulov Where RbrUlova = @Rbr;";
                        command.Parameters.AddWithValue("@Rbr", InputBrojUlova.Text);
                        max -= 1;
                        InputBrojUlova.Text = max.ToString();
                        InputVrsta.Text = "Izaberite vrstu ribe:";
                        InputPecaros.Text = "";
                        InputDatum.Clear();
                        InputVreme.Clear();
                    }
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Uspesno");

                }
            }
            catch (Exception ex)
            {
                if (radioUpisi.Checked)
                {
                    max -= 1;
                }
                else
                {
                    max += 1;
                }
                MessageBox.Show("Error!! " + ex.Message);
            }
        }
    }
}
