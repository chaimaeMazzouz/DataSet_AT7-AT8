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
    public partial class Navigation_Chauffeur : Form
    {
        Global g1 = new Global();
        DataSet Ds_Chauffeurs = new DataSet();
        SqlDataAdapter Adp_Chauffeurs;
        int i;
        void remplir()
        {
            textId.Text = Ds_Chauffeurs.Tables["MesChauffeurs"].Rows[i].ItemArray[0].ToString();
            textNom.Text = Ds_Chauffeurs.Tables["MesChauffeurs"].Rows[i].ItemArray[1].ToString();
            textPrenom.Text = Ds_Chauffeurs.Tables["MesChauffeurs"].Rows[i].ItemArray[2].ToString();
            dateTimePicker1.Text = Ds_Chauffeurs.Tables["MesChauffeurs"].Rows[i].ItemArray[4].ToString();
            textSalaire.Text = Ds_Chauffeurs.Tables["MesChauffeurs"].Rows[i].ItemArray[5].ToString();
        }
        public Navigation_Chauffeur()
        {
            InitializeComponent();
        }

        private void Navigation_Chauffeur_Load(object sender, EventArgs e)
        {
            i = 0;
            Adp_Chauffeurs = new SqlDataAdapter("", "");
            Adp_Chauffeurs.SelectCommand.CommandText = "SELECT * FROM chauffeur";
            Adp_Chauffeurs.SelectCommand.Connection = g1.voyage_connexion;
            Adp_Chauffeurs.Fill(Ds_Chauffeurs, "MesChauffeurs");
            nbreChauffeurLbl.Text = Ds_Chauffeurs.Tables["MesChauffeurs"].Rows.Count.ToString();
            remplir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = 0;
            remplir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i < Ds_Chauffeurs.Tables["MesChauffeurs"].Rows.Count - 1)
            {
                i++;
                remplir();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                remplir();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            i = Ds_Chauffeurs.Tables["MesChauffeurs"].Rows.Count - 1;
            remplir();
        }
    }
}
