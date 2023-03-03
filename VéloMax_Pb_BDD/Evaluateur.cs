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

namespace VéloMax_Pb_BDD
{
    public partial class Evaluateur : Form
    {
        MySqlConnection connexion;
        int nbr_clients;
        int nbr_particuliers;
        int nbr_boutiques;
        DataSet ds_clients_commandes;
        DataSet ds_boutiques_commandes;
        public Evaluateur(MySqlConnection connexion)
        {
            InitializeComponent();
            this.connexion = connexion;
            this.ds_clients_commandes = new DataSet();
            this.ds_boutiques_commandes = new DataSet();
        }

        private void EvalNombreClient_Click(object sender, EventArgs e)
        {
            try
            {
                string requete_Particulier = "SELECT COUNT(*) FROM Particulier";
                string requete_Boutique = "SELECT COUNT(*) FROM Boutique";
                MySqlCommand requete_command_particulier = connexion.CreateCommand();
                MySqlCommand requete_command_boutique = connexion.CreateCommand();

                requete_command_boutique.CommandText = requete_Boutique;
                requete_command_particulier.CommandText = requete_Particulier;


                // this.nbr_clients = Convert.ToInt32(requete_command.ExecuteScalar());
                this.nbr_boutiques = Convert.ToInt32(requete_command_boutique.ExecuteScalar());
                this.nbr_particuliers = Convert.ToInt32(requete_command_particulier.ExecuteScalar());

                this.nbr_clients = nbr_boutiques + nbr_particuliers;
                NBR_Clients.Text = nbr_clients.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.ToString());
            }

        }

        private void Evaluateur_Load(object sender, EventArgs e)
        {

        }

        private void NBR_Clients_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Clients et commandes 
        {
            try
            {
                string requete_particulier = " SELECT P.nomP, COUNT(C.nomP) FROM Particulier P NATURAL JOIN Commande C";
                string requete_boutique = " SELECT B.nomB, COUNT(C.nomB) FROM Boutique B NATURAL JOIN Commande C ";

                MySqlCommand command_requeteP = connexion.CreateCommand();
                MySqlCommand command_requeteB = connexion.CreateCommand();

                command_requeteP.CommandText = requete_particulier;
                command_requeteB.CommandText = requete_boutique;


                MySqlDataAdapter datadapt_P = new MySqlDataAdapter(command_requeteP);
                datadapt_P.Fill(this.ds_clients_commandes);

                MySqlDataAdapter datadapt_B = new MySqlDataAdapter(command_requeteB);
                datadapt_B.Fill(this.ds_boutiques_commandes);

                ds_clients_commandes.Merge(ds_boutiques_commandes);

                dataGridView1.DataSource = ds_clients_commandes.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Buton_Retour_Click(object sender, EventArgs e)
        {
            Accueil ac = new Accueil(connexion);
            ac.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                DataSet ds1 = new DataSet();
                DataSet ds2 = new DataSet();   

                string stock_Piece = "SELECT description_,SUM(qté_pièce) " +
                                         "FROM Piece " +
                                         " GROUP BY description_ HAVING SUM(qté_pièce) < 3";
                string stock_Vélo = "SELECT nomV, COUNT(*) as Qté_Vélo FROM Velo GROUP BY nomV HAVING Qté_Vélo < 3";
   

                MySqlCommand stock_Piece_command = connexion.CreateCommand();
                MySqlCommand stock_Vélo_command = connexion.CreateCommand();

                stock_Piece_command.CommandText = stock_Piece;
                stock_Vélo_command.CommandText = stock_Vélo;


                MySqlDataAdapter datadapt_P = new MySqlDataAdapter(stock_Piece_command);
                datadapt_P.Fill(ds1);

                MySqlDataAdapter datadapt_B = new MySqlDataAdapter(stock_Vélo_command);
                datadapt_B.Fill(ds2);

               

                dataGridView2.DataSource = ds1.Tables[0];
                dataGridView3.DataSource = ds2.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
