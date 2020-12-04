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
    public partial class Voyage_par_Vehicule : Form
    {
        Global g1;
        DataSet Ds_Voyages;
        SqlDataAdapter Adp_Voyages;
        public Voyage_par_Vehicule()
        {
            InitializeComponent();
            g1 = new Global();
            Adp_Voyages = new SqlDataAdapter("", g1.voyage_connexion);
            Ds_Voyages = new DataSet();
        }

        private void Voyage_par_Vehicule_Load(object sender, EventArgs e)
        {
            Adp_Voyages.SelectCommand.CommandText = "SELECT Immatricule,(Marque+' '+Immatricule) as MarqueVehicule from Vehicule";
            Ds_Voyages.Clear();
            Adp_Voyages.Fill(Ds_Voyages, "MesVehicules");

            string Stcom = "select ID_voyage ,date_voyage,voyage.Immatricule as ID " +
            "from Voyage join Vehicule on Voyage.Immatricule = Vehicule.Immatricule";
            Adp_Voyages.SelectCommand.CommandText = Stcom;
            Adp_Voyages.Fill(Ds_Voyages, "MesVoyages");

            comboBox1.DisplayMember = "MarqueVehicule";
            comboBox1.ValueMember = "Immatricule";
            comboBox1.DataSource = Ds_Voyages.Tables["MesVehicules"];
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
