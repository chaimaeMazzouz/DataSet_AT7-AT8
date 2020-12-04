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
    public partial class Recherche_Vehicules : Form
    {
        Global g1;
        DataSet Ds_Vehicules;
        SqlDataAdapter Adp_Vehicules;
        public Recherche_Vehicules()
        {
            InitializeComponent();
            g1 = new Global();
            Adp_Vehicules = new SqlDataAdapter("", g1.voyage_connexion);
            Ds_Vehicules = new DataSet();
        }

        private void Recherche_Vehicules_Load(object sender, EventArgs e)
        {
            Adp_Vehicules.SelectCommand.CommandText = "SELECT ID_chauffeur,(Nom+' '+Prenom) as Nom from chauffeur";
            Ds_Vehicules.Clear();
            Adp_Vehicules.Fill(Ds_Vehicules, "MesChauffeurs");

            string Stcom = "select Vehicule.Immatricule,Marque, ID_Voyage,Date_Voyage,Voyage.ID_chauffeur as ID "+
"           from Voyage join Vehicule on Voyage.Immatricule = Vehicule.Immatricule";
            Adp_Vehicules.SelectCommand.CommandText = Stcom;
            Adp_Vehicules.Fill(Ds_Vehicules, "MesVehicules");

            comboBox1.DisplayMember = "Nom";
            comboBox1.ValueMember = "ID_chauffeur";
            comboBox1.DataSource = Ds_Vehicules.Tables["MesChauffeurs"];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView Vue_voyage = Ds_Vehicules.Tables["MesVehicules"].DefaultView;
            try
            {

                Vue_voyage.RowFilter = "ID= '" + comboBox1.SelectedValue + "'";
                Vue_voyage.Sort = "Date_Voyage ASC";

                dataGridView1.DataSource = Ds_Vehicules.Tables["MesVehicules"];
                dataGridView1.Columns["ID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
