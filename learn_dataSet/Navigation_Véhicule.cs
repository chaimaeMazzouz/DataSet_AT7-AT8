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
    public partial class Navigation_Véhicule : Form
    {
        public Navigation_Véhicule()
        {
            InitializeComponent();
        }
        Global g1 = new Global();
        DataSet Ds_Vehicules = new DataSet();
        SqlDataAdapter Adp_Vehicules;
        int i;
        void remplir()
        {
            textImmatricule.Text = Ds_Vehicules.Tables["MesVehicules"].Rows[i].ItemArray[0].ToString();
            textMarque.Text = Ds_Vehicules.Tables["MesVehicules"].Rows[i].ItemArray[1].ToString();
            textType_Vehicule.Text = Ds_Vehicules.Tables["MesVehicules"].Rows[i].ItemArray[2].ToString();
            Dt_Mise_Service.Text = Ds_Vehicules.Tables["MesVehicules"].Rows[i].ItemArray[3].ToString();
        }

        private void Navigation_Véhicule_Load(object sender, EventArgs e)
        {
            i = 0;
            Adp_Vehicules = new SqlDataAdapter("", "");
            Adp_Vehicules.SelectCommand.CommandText = "SELECT * FROM Vehicule";
            Adp_Vehicules.SelectCommand.Connection = g1.voyage_connexion;
            Adp_Vehicules.Fill(Ds_Vehicules, "MesVehicules");
            nbreVehiculesLbl.Text = Ds_Vehicules.Tables["MesVehicules"].Rows.Count.ToString();
            remplir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = 0;
            remplir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i < Ds_Vehicules.Tables["MesVehicules"].Rows.Count - 1)
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
            i = Ds_Vehicules.Tables["MesVehicules"].Rows.Count - 1;
            remplir();
        }
    }
}
