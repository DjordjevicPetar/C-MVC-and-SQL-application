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
    public partial class Roditelji : Form
    {
        public int Index = 0;
        public Roditelji()
        {
            InitializeComponent();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNacrtaj_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen Crvena = new Pen(Color.Red, 2);
            Pen Zelena = new Pen(Color.Green, 2);
            Pen Plava = new Pen(Color.Blue, 2);


            int x = pictureBox1.Width;
            int y = pictureBox1.Height;


            g.DrawRectangle(Zelena, x / 4, y / 3, y / 3, y / 3);
            g.DrawEllipse(Plava, x / 4, 0, y / 3, y / 3);
            Point A, B, C, D, E, F, G, H;
            A = new Point(x / 4, y / 3);
            B = new Point(0, 6 * y / 10);
            C = new Point(x / 3, 2 * y / 3);
            D = new Point(x / 3, y);
            E = new Point(29 * x / 45, 2 * y / 3);
            F = new Point(29 * x / 45, y);
            G = new Point(x / 4 + y / 3, y / 3);
            H = new Point(x, 0);

            g.DrawLine(Crvena, A, B);
            g.DrawLine(Crvena, C, D);
            g.DrawLine(Crvena, E, F);
            g.DrawLine(Crvena, G, H);

            btnNacrtaj.Enabled = false;
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            InputSifra.Text = (NajveciIndex() + 1).ToString();
            InputIme.Text = "";
            InputAdresa.Text = "";
            InputPrezime.Text = "";
            InputFiksni.Text = "";
            InputMobilni.Text = "";
            SvojstvoOtac.Checked = true;
            btnUnesi.Enabled = true;
        }

        public int NajveciIndex()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-A5NTGOV\SQLEXPRESS; Database = DnevniBoravakDece; Integrated Security = True"))
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("Select Max(Roditelj.RoditeljID) From Roditelj", con);
                    return Convert.ToInt32(com.ExecuteScalar());
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-A5NTGOV\SQLEXPRESS; Database = DnevniBoravakDece; Integrated Security = True"))
                {
                    SqlCommand com = new SqlCommand("Insert Into Roditelj " +
                        "(RoditeljID, SvojstvoID, Ime, Prezime, Adresa, FiksniTelefon, MobilniTelefon) Values " +
                        "(@RoditeljID, @SvojstvoID, @Ime, @Prezime, @Adresa, @FiksniTelefon, @MobilniTelefon)", con);

                    com.Parameters.AddWithValue("@RoditeljID", Convert.ToInt32(InputSifra.Text));
                    if (SvojstvoOtac.Checked) com.Parameters.AddWithValue("@SvojstvoID", 1);
                    else if (SvojstvoOtac.Checked) com.Parameters.AddWithValue("@SvojstvoID", 2);
                    else com.Parameters.AddWithValue("@SvojstvoID", 3);
                    com.Parameters.AddWithValue("@Ime", InputIme.Text);
                    com.Parameters.AddWithValue("@Prezime", InputPrezime.Text);
                    com.Parameters.AddWithValue("@Adresa", InputAdresa.Text);
                    com.Parameters.AddWithValue("@FiksniTelefon", InputFiksni.Text);
                    com.Parameters.AddWithValue("@MobilniTelefon", InputMobilni.Text);
                    try
                    {
                        con.Open();
                        com.ExecuteNonQuery();
                        MessageBox.Show("Uspesan upis.");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrethodni_Click(object sender, EventArgs e)
        {
            Index--;
            using (SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-A5NTGOV\SQLEXPRESS; Database = DnevniBoravakDece; Integrated Security = True"))
            {
                con.Open();
                SqlCommand com = new SqlCommand("Select * From Roditelj where RoditeljID = @RoditeljID;", con);
                com.Parameters.AddWithValue("@RoditeljID", Index);
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    reader.Read();
                    InputSifra.Text = reader[0].ToString();
                    if (Convert.ToInt32(reader[1]) == 1)
                    {
                        SvojstvoOtac.Checked = true;
                        SvojstvoMajka.Checked = false;
                        SvojstvoStaratelj.Checked = false;
                    }
                    if (Convert.ToInt32(reader[1]) == 2)
                    {
                        SvojstvoOtac.Checked = false;
                        SvojstvoMajka.Checked = true;
                        SvojstvoStaratelj.Checked = false;
                    }
                    if (Convert.ToInt32(reader[1]) == 3)
                    {
                        SvojstvoOtac.Checked = false;
                        SvojstvoMajka.Checked = false;
                        SvojstvoStaratelj.Checked = true;
                    }
                    InputIme.Text = reader[2].ToString();
                    InputPrezime.Text = reader[3].ToString();
                    InputAdresa.Text = reader[4].ToString();
                    InputFiksni.Text = reader[5].ToString();
                    InputMobilni.Text = reader[6].ToString();
                }
            }
            if (Index <= 1)
            {
                btnPrethodni.Enabled = false;
            }
            if (Index < NajveciIndex())
            {
                btnSledeci.Enabled = true;
            }
            btnUnesi.Enabled = false;
        }

        private void btnSledeci_Click(object sender, EventArgs e)
        {
            Index++;
            using (SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-A5NTGOV\SQLEXPRESS; Database = DnevniBoravakDece; Integrated Security = True"))
            {
                con.Open();
                SqlCommand com = new SqlCommand("Select * From Roditelj Where RoditeljID = @RoditeljID;", con);
                com.Parameters.AddWithValue("@RoditeljID", Index);
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    reader.Read();
                    InputSifra.Text = reader[0].ToString();
                    if (Convert.ToInt32(reader[1]) == 1)
                    {
                        SvojstvoOtac.Checked = true;
                        SvojstvoMajka.Checked = false;
                        SvojstvoStaratelj.Checked = false;
                    }
                    if (Convert.ToInt32(reader[1]) == 2)
                    {
                        SvojstvoOtac.Checked = false;
                        SvojstvoMajka.Checked = true;
                        SvojstvoStaratelj.Checked = false;
                    }
                    if (Convert.ToInt32(reader[1]) == 3)
                    {
                        SvojstvoOtac.Checked = false;
                        SvojstvoMajka.Checked = false;
                        SvojstvoStaratelj.Checked = true;
                    }
                    InputIme.Text = reader[2].ToString();
                    InputPrezime.Text = reader[3].ToString();
                    InputAdresa.Text = reader[4].ToString();
                    InputFiksni.Text = reader[5].ToString();
                    InputMobilni.Text = reader[6].ToString();
                }
                if (Index > 1)
                {
                    btnPrethodni.Enabled = true;
                }
                if (Index == NajveciIndex())
                {
                    btnSledeci.Enabled = false;
                }
                btnUnesi.Enabled = false;
            }
        }
    }
}
