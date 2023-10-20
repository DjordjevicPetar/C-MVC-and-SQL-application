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

namespace B5
{
    public partial class btnUpis : Form
    {
        public int index = 0;
        public string connection_string = @"Data Source = DESKTOP-A5NTGOV\SQLEXPRESS; Database = Fudbalski_Klub; Integrated Security = true;";
        public btnUpis()
        {
            InitializeComponent();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Close();
        }

        public int BrojClanova()
        {
            using (SqlConnection con = new SqlConnection(connection_string))
            {
                SqlCommand com = new SqlCommand("Select Count(GradID) From Grad", con);
                con.Open();
                return Convert.ToInt32(com.ExecuteScalar());
            }
        }

        private void btnPrethodni_Click(object sender, EventArgs e)
        {
            index--;
            using (SqlConnection con = new SqlConnection(connection_string))
            {
                SqlCommand com = new SqlCommand("Select * From Grad;", con);
                con.Open();
                SqlDataReader reader = com.ExecuteReader();
                for (int i = 0; i < index; i++)
                {
                    reader.Read();
                }
                InputSifra.Text = reader[0].ToString();
                InputGrad.Text = reader[1].ToString();
                InputPoz.Text = reader[2].ToString();
                InputPos.Text = reader[3].ToString();
                InputStanovnika.Text = reader[4].ToString();
                if (index < 2)
                {
                    btnPrethodni.Enabled = false;
                }
                if (index < BrojClanova())
                {
                    btnSledeci.Enabled = true;
                }
            }
        }

        private void btnSledeci_Click(object sender, EventArgs e)
        {
            index++;
            using (SqlConnection con = new SqlConnection(connection_string))
            {
                SqlCommand com = new SqlCommand("Select * From Grad;", con);
                con.Open();
                SqlDataReader reader = com.ExecuteReader();
                for (int i = 0; i < index; i++)
                {
                    reader.Read();
                }
                InputSifra.Text = reader[0].ToString();
                InputGrad.Text = reader[1].ToString();
                InputPoz.Text = reader[2].ToString();
                InputPos.Text = reader[3].ToString();
                InputStanovnika.Text = reader[4].ToString();
                if (index > 1)
                {
                    btnPrethodni.Enabled = true;
                }
                if (index == BrojClanova())
                {
                    btnSledeci.Enabled = false;
                }
            }
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            index = 0;
            btnPrethodni.Enabled = false;
            btnSledeci.Enabled = true;
            InputSifra.Text = "";
            InputGrad.Text = "";
            InputPoz.Text = "";
            InputPos.Text = "";
            InputStanovnika.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection_string))
            {
                SqlCommand com = new SqlCommand("Insert Into Grad Values(@ID, @Naziv, @Poz, @Pos, @Stanovnika);", con);
                com.Parameters.AddWithValue("@ID", Convert.ToInt32(InputSifra.Text));
                com.Parameters.AddWithValue("@Naziv", InputGrad.Text);
                com.Parameters.AddWithValue("@Poz", Convert.ToInt16(InputPoz.Text));
                com.Parameters.AddWithValue("@Pos", Convert.ToInt32(InputPos.Text));
                com.Parameters.AddWithValue("@Stanovnika", Convert.ToInt32(InputStanovnika.Text));
                con.Open();
                com.ExecuteNonQuery();
            }
            index = 0;
            btnPrethodni.Enabled = false;
            btnSledeci.Enabled = true;
            InputSifra.Text = "";
            InputGrad.Text = "";
            InputPoz.Text = "";
            InputPos.Text = "";
            InputStanovnika.Text = "";
        }
    }
}
