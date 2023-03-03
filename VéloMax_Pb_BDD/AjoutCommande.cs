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
    public partial class AjoutCommande : Form
    {
        MySqlConnection connexion;
        DataSet pièces;
        DataSet Vélos;
        DataSet pièces_recommandées;
        DataSet Ta_commande_velos;
        DataSet Ta_commande_pieces;

        public AjoutCommande(MySqlConnection connexion)
        {
            InitializeComponent();
            this.connexion = connexion;
            this.pièces = new DataSet();
            this.Vélos = new DataSet();
            this.pièces_recommandées = new DataSet();
            this.Ta_commande_velos = new DataSet();
            this.Ta_commande_pieces = new DataSet();
        }

        private void Button_ValiderAjoutPièce_Click(object sender, EventArgs e)
        {
            List<string> Modèles_Vélos = new List<string>();
            List<string> Modèles_Pièces = new List<string>();
            List<string> Quantite_Velos = new List<string>();
            List<string> Quantite_Pieces = new List<string>();
            List<int> QuantiteV = new List<int>() ;      // Quantite_Velos.Count
            List<int> QuantiteP = new List<int>();       // Quantite_Pieces.Count
            List<int> NumVelos = new List<int>();     // Modèles_Vélos.Count

            bool possible = true;

            int numC = 0;

            try
            {
                if (Velos.Text == "Sép par un \";\"" && Quantite_V.Text == "Sép par un \";\"")
                {
                    Modèles_Vélos = null;
                    Modèles_Pièces = Pieces.Text.Split(';').ToList();
                    Quantite_Velos = null;
                    Quantite_Pieces = Quantite_P.Text.Split(';').ToList();
                    foreach (string value in Quantite_Pieces)
                    {
                        QuantiteP.Add(Convert.ToInt32(value));
                        MessageBox.Show(value);

                    }

                }
                if (Pieces.Text == "Sép par un \";\"" && Quantite_P.Text == "Sép par un \";\"")
                {
                    Modèles_Vélos = Velos.Text.Split(';').ToList();
                    //Modèles_Pièces = null;
                    Quantite_Velos = Quantite_V.Text.Split(';').ToList();
                    //Quantite_Pieces = null;
                    foreach (string value in Modèles_Vélos)
                    {
                        NumVelos.Add(Convert.ToInt32(value));

                    }
                    foreach (string value in Quantite_Velos)
                    {
                        QuantiteV.Add(Convert.ToInt32(value));
             
                    }
                }
                else if (Velos.Text != "Sép par un \";\"" && Quantite_V.Text != "Sép par un \";\"" && Pieces.Text != "Sép par un \";\"" && Quantite_P.Text != "Sép par un \";\"")
                {
                    Modèles_Vélos = Velos.Text.Split(';').ToList();
                    Modèles_Pièces = Pieces.Text.Split(';').ToList();
                    Quantite_Velos = Quantite_V.Text.Split(';').ToList();
                    Quantite_Pieces = Quantite_P.Text.Split(';').ToList();
                    foreach (string value in Modèles_Vélos)
                    {
                        //MessageBox.Show(value);
                        NumVelos.Add(Convert.ToInt32(value));
                       
                    }
                    foreach (string value in Quantite_Velos)
                    {
                        QuantiteV.Add(Convert.ToInt32(value));
                    
                    }
                    foreach (string value in Quantite_Pieces)
                    {
                        QuantiteP.Add(Convert.ToInt32(value));
                     
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Vous avez mal rempli les cases \n" + ex.Message +"\n"+ ex.ToString());
            }

       
            if (ComboBoxClient.Text == "nom du particulier")
            {
                try
                {
                    string numCommandeAjouté = Commande_creation(connexion, this, NumVelos, Modèles_Pièces, QuantiteV, QuantiteP, DateTime.Parse(DateCommande.Text),Adresse.Text, "Particulier", NomClient.Text, PrenomParticulier.Text);
                    if (numCommandeAjouté != "")
                    {
                        MessageBox.Show("La commande " + numCommandeAjouté + " a été ajouté à la BDD");
                        numC = Convert.ToInt32(numCommandeAjouté);
                    }
                    else
                    {
                        possible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\n" + ex.ToString());
                }
            }
            else
            {
                try
                {
                    
                    string numCommandeAjouté = Commande_creation(connexion, this, NumVelos, Modèles_Pièces, QuantiteV, QuantiteP, DateTime.Parse(DateCommande.Text),Adresse.Text, "Boutique", NomClient.Text);
                    if (numCommandeAjouté != "")
                    {
                        MessageBox.Show("La commande " + numCommandeAjouté + " a été ajouté à la BDD");
                        numC = Convert.ToInt32(numCommandeAjouté);
                    }
                    else
                    {
                        possible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\n" + ex.ToString());
                    
                }

            }

            if (possible)
            {
                // La commande du client apparaît 

                try
                {
                    string requete_tacommande_velos = "SELECT C.numC,numV,CV.qteV_commande FROM Commande C Natural Join Contient_Velo CV WHERE numC = " + numC;
                    string requete_tacommande_pieces = "SELECT C.numC,numP,CP.qteP_commande FROM Commande C Natural Join Contient_Piece CP WHERE numC = " + numC;

                    MySqlCommand tacommand_command_pieces = connexion.CreateCommand();
                    tacommand_command_pieces.CommandText = requete_tacommande_velos;

                    MySqlDataAdapter mySqlDataAdapter1 = new MySqlDataAdapter(tacommand_command_pieces);
                    mySqlDataAdapter1.Fill(Ta_commande_pieces);


                    DataPiècesRecommandées.DataSource = Ta_commande_pieces.Tables[0];



                    MySqlCommand tacommande_command = connexion.CreateCommand();
                    tacommande_command.CommandText = requete_tacommande_velos;

                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(tacommande_command);
                    mySqlDataAdapter.Fill(Ta_commande_velos);

                    DataCommande.DataSource = Ta_commande_velos.Tables[0];
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\n" + ex.ToString());
                }

                // Les pièces recommendées apparaissent
            }




        }

        private void AjoutCommande_Load(object sender, EventArgs e)
        {
            pièces = Affichage_table(connexion, "Piece");
            DataPièce.DataSource = pièces.Tables[0];

            Vélos = Affichage_table(connexion, "Velo");
            DataVelos.DataSource = Vélos.Tables[0];

            DateCommande.Text = DateTime.Now.ToString("MM/dd/yyyy");

         

        }

        private void Button_Retour_Click(object sender, EventArgs e)
        {
            GestionExterne gE = new GestionExterne(connexion);
            gE.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrenomParticulier_TextChanged(object sender, EventArgs e)
        {
            if (ComboBoxClient.Text == "nom du particulier")
            {
                PrenomParticulier.Enabled = true;
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Quantite_TextChanged(object sender, EventArgs e)
        {

        }

        private void Velos_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataCommande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataPièce_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataVelos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DateCommande_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void DataPiècesRecommandées_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
