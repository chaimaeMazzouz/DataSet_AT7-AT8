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
    public partial class Recherche_Voyages : Form
    {
        Global g1 ;
        DataSet Ds_Voyages ;
        SqlDataAdapter Adp_Voyages ;
        public Recherche_Voyages()
        {
            InitializeComponent();
            g1 = new Global();
            Adp_Voyages = new SqlDataAdapter("",g1.voyage_connexion);
            Ds_Voyages = new DataSet();
        }
       

        private void Recherche_Voyages_Load(object sender, EventArgs e)
        {
            Adp_Voyages.SelectCommand.CommandText = "SELECT ID_chauffeur,(Nom+' '+Prenom) as Nom from chauffeur";
            Ds_Voyages.Clear();
            Adp_Voyages.Fill(Ds_Voyages,"MesChauffeurs");

            string Stcom = "select ID_voyage ,date_voyage,voyage.ID_chauffeur as ID "+
"from Voyage join chauffeur on Voyage.ID_chauffeur = chauffeur.ID_chauffeur";
            Adp_Voyages.SelectCommand.CommandText = Stcom;
            Adp_Voyages.Fill(Ds_Voyages, "MesVoyages");

            comboBox1.DisplayMember = "Nom";
            comboBox1.ValueMember = "ID_chauffeur";
            comboBox1.DataSource = Ds_Voyages.Tables["MesChauffeurs"];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView Vue_voyage = Ds_Voyages.Tables["MesVoyages"].DefaultView;
            try
            {
                
                Vue_voyage.RowFilter = "ID= '" + comboBox1.SelectedValue + "'";
                Vue_voyage.Sort = "Date_Voyage ASC";

                dataGridView1.DataSource = Ds_Voyages.Tables["MesVoyages"];
                dataGridView1.Columns["ID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
