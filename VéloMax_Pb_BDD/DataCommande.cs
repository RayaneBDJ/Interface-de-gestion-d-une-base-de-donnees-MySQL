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

    public partial class DataCommande : Form
    {
        MySqlConnection connexion;
        DataSet ds_commandes;
        DataSet ds_commandes_velos;
        DataSet ds_commandes_pieces;

        public DataCommande(MySqlConnection connection)
        {
            InitializeComponent();
            this.connexion = connection;
            this.ds_commandes = new DataSet();
            this.ds_commandes_pieces = new DataSet();
            this.ds_commandes_velos = new DataSet();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataCommande_Load(object sender, EventArgs e)
        {
            try
            {
                ds_commandes = Affichage_table(connexion, "Commande");
                ds_commandes_pieces = Affichage_table(connexion, "Contient_Piece");
                ds_commandes_velos = Affichage_table(connexion,"Contient_Velo");

                dataGridView1.DataSource = ds_commandes.Tables[0];
                dataGridView2.DataSource = ds_commandes_velos.Tables[0];
                dataGridView3.DataSource = ds_commandes_pieces.Tables[0];
               

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Buton_Retour_Click(object sender, EventArgs e)
        {
            GestionExterne gE = new GestionExterne(connexion);
            gE.Show();
            this.Close();
        }
    }
}
