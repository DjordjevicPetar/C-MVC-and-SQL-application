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

namespace B9_B10
{
    public partial class Po_tipu_antikviteta : Form
    {
        static string connection_string = @"Data Source=10.81.73.2, 49166;Initial Catalog = p_djordjevicE34; User ID = p_djordjevicE34; Password = p_djordjevicE34";
        public Po_tipu_antikviteta()
        {
            InitializeComponent();
        }

        private void Po_tipu_antikviteta_Load(object sender, EventArgs e)
        {

        }

        private void CrtajOkvir()
        {
            Graphics graphic = pictureBox1.CreateGraphics();
            int x = pictureBox1.Width;
            int y = pictureBox1.Height;
            Pen plava = new Pen(Color.Blue, 5);
            Pen plava1 = new Pen(Color.Blue, 15 / 2);
            Pen plava2 = new Pen(Color.Blue, 7 / 2);
            graphic.DrawLine(plava, 0, 0, 0, y);
            graphic.DrawLine(plava, 0, 0, x, 0);
            graphic.DrawLine(plava1, 0, y, x, y);
            graphic.DrawLine(plava1, x, 0, x, y);
            graphic.DrawLine(plava2, x / 2, 0, x / 2, y);
            graphic.DrawLine(plava2, 0, y / 2, x, y / 2);
        }
        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("Select Naziv, KoordinateSirina As 'Sirina', KoordinateDuzina As 'Duzina' " +
                    "From Lokalitet Join (Antikvitet Join Tip_Antikviteta On Antikvitet.TipAntikvitetaID = Tip_Antikviteta.TipAntikvitetaID) " +
                    "On Lokalitet.LokalitetID = Antikvitet.LokalitetID Where Tip = @Tip;", connection);
                adapter.SelectCommand.Parameters.AddWithValue("@Tip", InputTip.Text);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                ListaLokaliteta.DataSource = dt;
            }
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNacrtaj_Click(object sender, EventArgs e)
        {
            Graphics graphic = pictureBox1.CreateGraphics();
            graphic.Clear(pictureBox1.BackColor);
            float x = pictureBox1.Width;
            float y = pictureBox1.Height;
            Pen plava = new Pen(Color.Blue, 5);
            Pen plava1 = new Pen(Color.Blue, 15 / 2);
            Pen plava2 = new Pen(Color.Blue, 7 / 2);
            Brush crvena = Brushes.Red;
            graphic.DrawLine(plava, 0, 0, 0, y);
            graphic.DrawLine(plava, 0, 0, x, 0);
            graphic.DrawLine(plava1, 0, y, x, y);
            graphic.DrawLine(plava1, x, 0, x, y);
            graphic.DrawLine(plava2, x / 2, 0, x / 2, y);
            graphic.DrawLine(plava2, 0, y / 2, x, y / 2);
            string duzina = ListaLokaliteta.SelectedRows[0].Cells[2].Value.ToString();
            string x_linija = duzina.Split(' ')[1];
            float x_vrednost = Convert.ToSingle(duzina.Split(' ')[0]);
            string sirina = ListaLokaliteta.SelectedRows[0].Cells[1].Value.ToString();
            string y_linija = sirina.Split(' ')[1];
            float y_vrednost = Convert.ToSingle(sirina.Split(' ')[0]);
            //MessageBox.Show((x / 360 * (Convert.ToInt32(duzina.Split(' ')[0]))).ToString());
            int X = (int)(x / 2 + ((x_linija == "zapadno") ? -x / 360 * x_vrednost : x / 360 * x_vrednost));
            Point A = new Point((int)(x / 2 + ((x_linija == "zapadno")? - x / 360 * x_vrednost : x / 360 * x_vrednost)),
                (int)(y / 2 + ((y_linija == "severno") ? - y / 180 * y_vrednost : + y / 180 * y_vrednost)));
            graphic.FillEllipse(crvena,A.X - 1/100,A.Y - 1/100, 5, 5);
        }
    }
}
