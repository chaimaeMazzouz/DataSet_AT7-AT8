using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learn_dataSet
{
    public partial class Recherche_Billets : Form
    {
        Global g1;
        DataSet Ds_Billets;
        SqlDataAdapter Adp_Billets;
        public Recherche_Billets()
        {
            InitializeComponent();
            g1 = new Global();
            Adp_Billets = new SqlDataAdapter("", g1.voyage_connexion);
            Ds_Billets = new DataSet();
        }

        private void Recherche_Billets_Load(object sender, EventArgs e)
        {
            Adp_Billets.SelectCommand.CommandText = "SELECT ID_Voyage,(Ville_Depart+' '+Ville_Arrive) as Direction from Voyage";
            Ds_Billets.Clear();
            Adp_Billets.Fill(Ds_Billets, "MesVoyages");

            string Stcom = "select N_Billet ,date_voyage, billet.ID_Voyage as ID " +
            "from billet join Voyage on billet.ID_Voyage = Voyage.ID_Voyage";
            Adp_Billets.SelectCommand.CommandText = Stcom;
            Adp_Billets.Fill(Ds_Billets, "MesBillets");

            comboBox1.DisplayMember = "Direction";
            comboBox1.ValueMember = "ID_Voyage";
            comboBox1.DataSource = Ds_Billets.Tables["MesVoyages"];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView Vue_voyage = Ds_Billets.Tables["MesBillets"].DefaultView;
            try
            {

                Vue_voyage.RowFilter = "ID= '" + comboBox1.SelectedValue + "'";
                Vue_voyage.Sort = "Date_Voyage ASC";

                dataGridView1.DataSource = Ds_Billets.Tables["MesBillets"];
                dataGridView1.Columns["ID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
