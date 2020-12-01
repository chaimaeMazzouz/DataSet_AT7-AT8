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
    public partial class Navigation_Voyages : Form
    {
        public Navigation_Voyages()
        {
            InitializeComponent();
        }
        Global g1 = new Global();
        DataSet Ds_Voyages = new DataSet();
        SqlDataAdapter Adp_Voyages;
        int i;
        void remplir()
        {
            textID_Voyage.Text = Ds_Voyages.Tables["MesVoyages"].Rows[i].ItemArray[0].ToString();
            Date_VoyagePicker.Text = Ds_Voyages.Tables["MesVoyages"].Rows[i].ItemArray[1].ToString();
            textVille_Depart.Text = Ds_Voyages.Tables["MesVoyages"].Rows[i].ItemArray[2].ToString();
            textVille_Arrive.Text = Ds_Voyages.Tables["MesVoyages"].Rows[i].ItemArray[3].ToString();
        }

        private void Navigation_Voyages_Load(object sender, EventArgs e)
        {
            i = 0;
            Adp_Voyages = new SqlDataAdapter("", "");
            Adp_Voyages.SelectCommand.CommandText = "SELECT * FROM Voyage";
            Adp_Voyages.SelectCommand.Connection = g1.voyage_connexion;
            Adp_Voyages.Fill(Ds_Voyages, "MesVoyages");
            nbreVoyagesLbl.Text = Ds_Voyages.Tables["MesVoyages"].Rows.Count.ToString();
            remplir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = 0;
            remplir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i < Ds_Voyages.Tables["MesVoyages"].Rows.Count - 1)
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
            i = Ds_Voyages.Tables["MesVoyages"].Rows.Count - 1;
            remplir();
        }
    }
}
