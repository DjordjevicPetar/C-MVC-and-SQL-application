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

namespace B5_6
{
    public partial class Gradovi : Form
    {
        public Gradovi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(InputSifra.Text))
            {
                using (SqlConnection con = new SqlConnection(@"Data Source = 10.81.73.2,49166;Initial Catalog = p_djordjevicE34;User id = p_djordjevicE34;Password = p_djordjevicE34;"))
                {
                    SqlCommand com = new SqlCommand("Select * From Grad Order By GradID ASC", con);
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    dr.Read();
                    InputSifra.Text = dr.GetInt32(0).ToString();
                    InputGrad.Text = dr.GetString(1);
                    InputPozivni.Text = dr.GetInt16(2).ToString();
                    InputPostanski.Text = dr.GetInt32(3).ToString();
                    InputStanovnika.Text = dr.GetInt64(4).ToString();
                }
            }
            else
            {
                MessageBox.Show("Sifra vec ima vrednost");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(InputSifra.Text))
            {
                using (SqlConnection con = new SqlConnection(@"Data Source = 10.81.73.2,49166;Initial Catalog = p_djordjevicE34;User id = p_djordjevicE34;Password = p_djordjevicE34;"))
                {
                    SqlCommand com = new SqlCommand("Select * From Grad Order By GradID DESC", con);
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    dr.Read();
                    InputSifra.Text = dr.GetInt32(0).ToString();
                    InputGrad.Text = dr.GetString(1);
                    InputPozivni.Text = dr.GetInt16(2).ToString();
                    InputPostanski.Text = dr.GetInt32(3).ToString();
                    InputStanovnika.Text = dr.GetInt64(4).ToString();
                }
            }
            else
            {
                MessageBox.Show("Sifra vec ima vrednost");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InputSifra.Text = "";
            InputGrad.Text = "";
            InputPozivni.Text = "";
            InputPostanski.Text = "";
            InputStanovnika.Text = "";
            InputSifra.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source = 10.81.73.2,49166;Initial Catalog = p_djordjevicE34;User id = p_djordjevicE34;Password = p_djordjevicE34;"))
            {
                SqlCommand com = new SqlCommand("Insert Into Grad (GradID, Grad, PozivniBroj, PostanskiBroj, BrojStanovnika) Values (@ID, @Naziv, @Pozivni, @Postanski, @Stanovnika)", con);
                try
                {
                    com.Parameters.AddWithValue("@ID", Convert.ToInt32(InputSifra.Text));
                    com.Parameters.AddWithValue("@Naziv", InputGrad.Text);
                    com.Parameters.AddWithValue("@Pozivni", Convert.ToInt16(InputPozivni.Text));
                    com.Parameters.AddWithValue("@Postanski", Convert.ToInt32(InputPostanski.Text));
                    com.Parameters.AddWithValue("@Stanovnika", Convert.ToInt64(InputStanovnika.Text));
                    con.Open();
                    com.ExecuteNonQuery();
                    MessageBox.Show("Uspesaj.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);   
                }
            }
        }
    }
}
