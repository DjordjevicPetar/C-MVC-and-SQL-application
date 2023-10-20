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
using System.Data;

namespace B19_20 {
    public partial class PoProizvodjacu : Form {
        public PoProizvodjacu() {
            InitializeComponent();
        }

        private void PoProizvodjacu_Load(object sender, EventArgs e) {
            checkedListBox1.DisplayMember = "Text";
            checkedListBox1.ValueMember = "Value";
            using (SqlConnection con = new SqlConnection(@"Data Source=10.81.73.2,49166;Initial Catalog=p_djordjevicE34;User ID=p_djordjevicE34;Password = p_djordjevicE34")) {
                SqlCommand com = new SqlCommand("Select * From Proizvodjac;", con);
                con.Open();
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read()) {
                    checkedListBox1.Items.Insert(0, new { Text = reader.GetString(1), Value = reader.GetInt32(0).ToString() });
                }
            }
        }

        private void btnIzadji_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnPrikazi_Click(object sender, EventArgs e) {
            using (SqlConnection con = new SqlConnection(@"Data Source=10.81.73.2,49166;Initial Catalog=p_djordjevicE34;User ID=p_djordjevicE34;Password = p_djordjevicE34")) {
                try {
                    SqlCommand com = new SqlCommand("Select Distinct ProizvodjacBolest.Naziv As 'X', COUNT(BNaziv) As 'Y' " +
                    "From (Select Distinct Naziv, Bolest.Naziv As 'BNaziv' " +
                    "From Proizvodjac Join (Lek Join (Lek_Bolest Join Bolest On Lek_Bolest.BolestID = Bolest.BolestID) " +
                    "On Lek.LekID = Lek_Bolest.LekID) On Proizvodjac.ProizvodjacID = Lek.ProizvodjacID) As ProizvodjacBolest " +
                    "Where ProizvodjacBolest.Naziv = @P1 or ProizvodjacBolest.Naziv = @P2 or ProizvodjacBolest.Naziv = @P3 " +
                    "Group By ProizvodjacBolest.Naziv;", con);
                    com.Parameters.AddWithValue("@P1", checkedListBox1.CheckedItems[0].ToString());
                    com.Parameters.AddWithValue("@P2", checkedListBox1.CheckedItems[1].ToString());
                    com.Parameters.AddWithValue("@P3", checkedListBox1.CheckedItems[2].ToString());
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.Series["ProizvodnjaLekova"].XValueMember = "X";
                    chart1.Series["ProizvodnjaLekova"].XValueMember = "Y";
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
