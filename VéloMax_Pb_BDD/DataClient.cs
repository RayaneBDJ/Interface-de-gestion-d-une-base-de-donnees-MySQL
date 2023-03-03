using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using static VéloMax_Pb_BDD.MethodesDataSQL;

namespace VéloMax_Pb_BDD
{
    public partial class DataClient : Form
    {
        MySqlConnection connexion;
        DataSet ds;
        public DataClient(MySqlConnection maconnexion)
        {
            InitializeComponent();
            this.connexion = maconnexion;
            this.ds = new DataSet();
        }
        private void DataClient_Load(object sender, EventArgs e)
        {
            ds = Affichage_table(connexion, "Particulier");
            this.dataGridView1.DataSource = ds.Tables[0];

            ds = Affichage_table(connexion, "Boutique");
            this.dataGridView2.DataSource = ds.Tables[0];
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button_Retour_Click(object sender, EventArgs e)
        {
            GestionExterne gE = new GestionExterne(connexion);
            gE.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
