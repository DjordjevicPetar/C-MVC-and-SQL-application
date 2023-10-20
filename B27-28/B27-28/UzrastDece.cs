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

namespace B27_28
{
    public partial class UzrastDece : Form
    {
        public UzrastDece()
        {
            InitializeComponent();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            string command_string = "Select Dete.Ime, Dete.Prezime, Dete.DatumRodjenja, Pol.Pol " +
                "From(Dete Join Pol On Dete.PolID = Pol.PolID) Join(Select DateDiff(YY, Dete.DatumRodjenja, GETDATE()) - CASE " +
                "WHEN(MONTH(Dete.DatumRodjenja) > MONTH(GETDATE())) OR (MONTH(Dete.DatumRodjenja) = MONTH(GETDATE()) AND DAY(Dete.DatumRodjenja) > DAY(GETDATE())) " +
                "THEN 1 ELSE 0 END As 'Uzrast', DeteID From Dete) As Uzrast On Dete.DeteID = Uzrast.DeteID " +
                "Where " + UpitPol() + " and Uzrast.Uzrast = @Uzrast;";
            using (SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-A5NTGOV\SQLEXPRESS; Database = DnevniBoravakDece; Integrated Security = True"))
            {
                try
                {
                    SqlCommand com = new SqlCommand(command_string, con);
                    com.Parameters.AddWithValue("@Uzrast", InputUzrast.Value);
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public string UpitPol()
        {
            string upit = "(";
            if (SvojstvoMuski.Checked) upit += "Pol.Pol = 'Muski' or ";
            if (SvojstvoZenski.Checked) upit += "Pol.Pol = 'Zenski' or ";
            upit += "0 > 5)";
            return upit;
        }
    }
}
