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

namespace B35_B36
{
    public partial class Pretraga_Opisa : Form
    {
        static string connection_string = @"Data Source = 10.81.73.2, 49166;Initial Catalog = p_djordjevicE34;User ID = p_djordjevicE34;Password = p_djordjevicE34";
        public Pretraga_Opisa()
        {
            InitializeComponent();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                string trazen_opis = InputOpis.Text;
                SqlDataAdapter adapter = new SqlDataAdapter("Select * From Vrsta_Ribe Where ", connection);
                DataTable dt = new DataTable();
                if (boxRazlikovanje.Checked)
                {
                    if (boxCeleReci.Checked)
                    {
                        adapter.SelectCommand.CommandText += "Opis Like '% " + trazen_opis + " %' COLLATE SQL_Latin1_General_CP1_CS_AS or " +
                            "Opis Like '" + trazen_opis + " %' COLLATE SQL_Latin1_General_CP1_CS_AS or " +
                            "Opis Like '% " + trazen_opis + "' COLLATE SQL_Latin1_General_CP1_CS_AS or " +
                            "Opis Like '" + trazen_opis + "' COLLATE SQL_Latin1_General_CP1_CS_AS or " +
                            "Opis Like '%," + trazen_opis + " %' COLLATE SQL_Latin1_General_CP1_CS_AS or " +
                            "Opis Like '% " + trazen_opis + ",%' COLLATE SQL_Latin1_General_CP1_CS_AS";
                    }
                    else
                    {
                        adapter.SelectCommand.CommandText += "Opis Like '%" + trazen_opis + "%' COLLATE SQL_Latin1_General_CP1_CS_AS";
                    }
                }
                else
                {
                    if (boxCeleReci.Checked)
                    {
                        adapter.SelectCommand.CommandText += "Lower(Opis) Like '% " + trazen_opis.ToLower() + " %' or " +
                            "Lower(Opis) Like '" + trazen_opis.ToLower() + " %' or " +
                            "Lower(Opis) Like '% " + trazen_opis.ToLower() + "' or " +
                            "Lower(Opis) Like '" + trazen_opis.ToLower() + "' or " +
                            "Lower(Opis) Like '%," + trazen_opis.ToLower() + " %' or " +
                            "Lower(Opis) Like '% " + trazen_opis.ToLower() + ",%'" ;
                    }
                    else
                    {
                        adapter.SelectCommand.CommandText += "Lower(Opis) Like '%" + trazen_opis.ToLower() + "%'";
                    }
                }
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        }
    }
}
