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
    public partial class Deca : Form
    {
        public int Index = 0;
        public Deca()
        {
            InitializeComponent();
        }

        private void Deca_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dnevniBoravakDeceDataSet.ComboBox' table. You can move, or remove it, as needed.
            this.comboBoxTableAdapter.Fill(this.dnevniBoravakDeceDataSet.ComboBox);

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

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            InputSifra.Text = (NajveciIndex() + 1).ToString();
            InputIme.Text = "";
            InputPrezime.Text = "";
            InputDatum.Text = "";
            InputRodID.Text = "";
            InputBeleske.Text = "";
            PolMuski.Checked = true;
            btnUpisi.Enabled = true;
        }

        public int NajveciIndex()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-A5NTGOV\SQLEXPRESS; Database = DnevniBoravakDece; Integrated Security = True"))
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("Select Max(Dete.DeteID) From Dete", con);
                    return Convert.ToInt32(com.ExecuteScalar());
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        private void btnUpisi_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-A5NTGOV\SQLEXPRESS; Database = DnevniBoravakDece; Integrated Security = True"))
                {
                    SqlCommand com = new SqlCommand("Insert into Dete(DeteID, PolID, Ime, Prezime, DatumRodjenja, Beleske, RoditeljID)" +
                        " Values (@DeteID, @PolID, @Ime, @Prezime, @DatumRodjenja, @Beleske, @RoditeljID)", con);
                    com.Parameters.AddWithValue("@DeteID", Convert.ToInt32(InputSifra.Text));
                    if (PolMuski.Checked) com.Parameters.AddWithValue("@PolID", 1);
                    else com.Parameters.AddWithValue("@PolID", 2);
                    com.Parameters.AddWithValue("@Ime", InputIme.Text);
                    com.Parameters.AddWithValue("@Prezime", InputPrezime.Text);
                    com.Parameters.AddWithValue("@DatumRodjenja", InputDatum.Text);
                    com.Parameters.AddWithValue("@Beleske", InputBeleske.Text);
                    com.Parameters.AddWithValue("@RoditeljID", InputRodID.SelectedValue);
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
            try
            {
                Index--;
                using (SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-A5NTGOV\SQLEXPRESS; Database = DnevniBoravakDece; Integrated Security = True"))
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("Select * From Dete where DeteID = @DeteID;", con);
                    com.Parameters.AddWithValue("@DeteID", Index);
                    using (SqlDataReader reader = com.ExecuteReader())
                    {
                        reader.Read();
                        InputSifra.Text = reader[0].ToString();
                        if (Convert.ToInt32(reader[1]) == 1) PolMuski.Checked = true;
                        if (Convert.ToInt32(reader[1]) == 2) PolZenski.Checked = true;
                        InputIme.Text = reader[2].ToString();
                        InputPrezime.Text = reader[3].ToString();
                        InputDatum.Text = reader[4].ToString();
                        InputBeleske.Text = reader[5].ToString();
                        InputRodID.Text = ComboValue(Convert.ToInt32(reader[6]));
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
                btnUpisi.Enabled = false;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        private void btnSledeci_Click(object sender, EventArgs e)
        {
            Index++;
            using (SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-A5NTGOV\SQLEXPRESS; Database = DnevniBoravakDece; Integrated Security = True"))
            {
                con.Open();
                SqlCommand com = new SqlCommand("Select * From Dete Where DeteID = @DeteID;", con);
                com.Parameters.AddWithValue("@DeteID", Index);
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    reader.Read();
                    InputSifra.Text = reader[0].ToString();
                    if (Convert.ToInt32(reader[1]) == 1) PolMuski.Checked = true;
                    if (Convert.ToInt32(reader[1]) == 2) PolZenski.Checked = true;
                    InputIme.Text = reader[2].ToString();
                    InputPrezime.Text = reader[3].ToString();
                    InputDatum.Text = reader[4].ToString();
                    InputBeleske.Text = reader[5].ToString();
                    InputRodID.Text = ComboValue(Convert.ToInt32(reader[6]));
                }
                if (Index > 1)
                {
                    btnPrethodni.Enabled = true;
                }
                if (Index == NajveciIndex())
                {
                    btnSledeci.Enabled = false;
                }
                btnUpisi.Enabled = false;
            }
        }

        public string ComboValue(int i)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-A5NTGOV\SQLEXPRESS; Database = DnevniBoravakDece; Integrated Security = True"))
            {
                SqlCommand com = new SqlCommand("Select ImePrezime From ComboBox Where RoditeljID = @ID", con);
                com.Parameters.AddWithValue("@ID", i);
                con.Open();
                return com.ExecuteScalar().ToString();
            }
        }
    }
}
