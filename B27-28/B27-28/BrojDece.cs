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
    public partial class BrojDece : Form
    {
        public BrojDece()
        {
            InitializeComponent();
        }

        private void brnIzadji_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            string command_string = "Select Roditelj.Ime, Roditelj.Prezime, Roditelj.Adresa, Svojstvo_Roditelja.Svojstvo " +
                "From Svojstvo_Roditelja  Join(Roditelj Join " +
                "(Select Roditelj.RoditeljID, Count(Roditelj.RoditeljID) As 'Dece' " +
                "From(Roditelj Join Svojstvo_Roditelja On Roditelj.SvojstvoID = Svojstvo_Roditelja.SvojstvoID) Join " +
                "(Dete Join Pol On Dete.PolID = Pol.PolID) On Roditelj.RoditeljID = Dete.RoditeljID " +
                "Where " + UpitPol() + " and " + UpitSvojstvo() +
                " Group By Roditelj.RoditeljID) As BrojDece On Roditelj.RoditeljID = BrojDece.RoditeljID) " +
                "On Svojstvo_Roditelja.SvojstvoID = Roditelj.SvojstvoID " +
                "Where BrojDece.Dece = @BrojDece " +
                "Order By Ime, Prezime;";
            using (SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-A5NTGOV\SQLEXPRESS; Database = DnevniBoravakDece; Integrated Security = True"))
            {
                try
                {
                    SqlCommand com = new SqlCommand(command_string, con);
                    com.Parameters.AddWithValue("@BrojDece", InputBrDece.Value);
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

        public string UpitSvojstvo()
        {
            string upit = "(";
            if (SvojstvoMajka.Checked) upit += "Svojstvo_Roditelja.Svojstvo = 'Majka' or ";
            if (SvojstvoOtac.Checked) upit += "Svojstvo_Roditelja.Svojstvo = 'Otac' or ";
            if (SvojstvoStaratelj.Checked) upit += "Svojstvo_Roditelja.Svojstvo = 'Staratelj' or ";
            upit += "0 > 5)";
            return upit;
        }
    }
}
