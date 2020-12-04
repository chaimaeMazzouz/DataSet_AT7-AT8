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
    public partial class Chauffeurs_par_Vehicule : Form
    {
        Global g1;
        DataSet Ds_Chauffeurs;
        SqlDataAdapter Adp_Chauffeurs;
        public Chauffeurs_par_Vehicule()
        {
            InitializeComponent();
            g1 = new Global();
            Adp_Chauffeurs = new SqlDataAdapter("", g1.voyage_connexion);
            Ds_Chauffeurs = new DataSet();
        }

        private void Chauffeurs_par_Vehicule_Load(object sender, EventArgs e)
        {
            Adp_Chauffeurs.SelectCommand.CommandText = "SELECT Immatricule,(Marque+' '+Immatricule) as MarqueVehicule from Vehicule";
            Ds_Chauffeurs.Clear();
            Adp_Chauffeurs.Fill(Ds_Chauffeurs, "MesVehicules");

            string Stcom = "select chauffeur.ID_chauffeur,Nom, Prenom ,Date_Voyage,Voyage.Immatricule as Matricule " +
"           from Voyage join chauffeur on Voyage.ID_chauffeur = chauffeur.ID_chauffeur";
            Adp_Chauffeurs.SelectCommand.CommandText = Stcom;
            Adp_Chauffeurs.Fill(Ds_Chauffeurs, "MesChauffeurs");

            comboBox1.DisplayMember = "MarqueVehicule";
            comboBox1.ValueMember = "Immatricule";
            comboBox1.DataSource = Ds_Chauffeurs.Tables["MesVehicules"];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView Vue_voyage = Ds_Chauffeurs.Tables["MesChauffeurs"].DefaultView;
            try
            {

                Vue_voyage.RowFilter = "Matricule= '" + comboBox1.SelectedValue + "'";
                Vue_voyage.Sort = "Date_Voyage ASC";

                dataGridView1.DataSource = Ds_Chauffeurs.Tables["MesChauffeurs"];
                dataGridView1.Columns["Matricule"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
