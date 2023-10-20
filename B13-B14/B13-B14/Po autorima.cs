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
    public partial class PoAutorima : Form
    {
        static string connection_string = @"Data Source=10.81.73.2, 49166;Initial Catalog=p_djordjevicE34;User ID=p_djordjevicE34;Password=p_djordjevicE34";
        public PoAutorima()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            chart.Series["BrojKnjiga"].Points.Clear();
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                foreach (string item in listaAutora.CheckedItems)
                {
                    SqlCommand command = new SqlCommand("Select Count(Ime) From Autor Join " +
                        "(Knjiga Join Autor_Izdanje On Knjiga.KnjigaID = Autor_Izdanje.KnjigaID) On Autor.AutorID = Autor_Izdanje.AutorID " +
                        "Where Ime = @Ime and Prezime = @Prezime", connection);
                    command.Parameters.AddWithValue("@Ime", item.Split(' ')[0]);
                    command.Parameters.AddWithValue("@Prezime", item.Split(' ')[1]);
                    connection.Open();
                    chart.Series["BrojKnjiga"].Points.AddXY(item, Convert.ToInt32(command.ExecuteScalar()));
                    connection.Close();
                }
            }
        }

        private void PoAutorima_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("Select Ime + ' ' + Prezime From Autor", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    listaAutora.Items.Add(row[0]);
                }
            }
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
