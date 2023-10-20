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

namespace B13
{
    public partial class Po_kategorijama : Form
    {
        public Po_kategorijama()
        {
            InitializeComponent();
        }

        private void Po_kategorijama_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = DESKTOP-A5NTGOV\\SQLEXPRESS; Initial Catalog = Kolekcija Knjiga; Integrated Security = True; ");
            con.Open();
            SqlCommand cmd = new SqlCommand("select KategorijaID, Naziv from Kategorija", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            checkedListBox1.DataSource = ds.Tables[0];
            checkedListBox1.DisplayMember = "Naziv";
            checkedListBox1.ValueMember = "KategorijaID";
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                DataRowView castedItem = itemChecked as DataRowView;
                string Naziv = castedItem["Naziv"].ToString();
                int KategorijaID = Convert.ToInt32(castedItem["KategorijaID"]);
                SqlConnection con = new SqlConnection("Data Source = DESKTOP-A5NTGOV\\SQLEXPRESS; Initial Catalog = Kolekcija Knjiga; Integrated Security = True; ");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Count(KategorijaID) From Knjiga Where KategorijaID = @ID;", con);
                cmd.Parameters.AddWithValue("@ID", KategorijaID);
                chart1.Series["Broj knjiga"].Points.AddXY(Naziv, Convert.ToInt32(cmd.ExecuteScalar()));
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
