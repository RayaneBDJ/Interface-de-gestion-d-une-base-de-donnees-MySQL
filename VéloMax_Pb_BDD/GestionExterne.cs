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
    public partial class GestionExterne : Form
    {
        MySqlConnection connection = null;

        public GestionExterne(MySqlConnection maconnection)
        {
            this.connection = maconnection;
                
            InitializeComponent();
        }
        private void GestionExterne_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e) // Gestion des Clients
        {

        }

        private void button1_Click(object sender, EventArgs e)  // Gestion des fournisseurs 
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) // box des options 
        {

        }

        private void Button_AjoutFournisseur_Click(object sender, EventArgs e)
        {
            AjoutFournisseur aF = new AjoutFournisseur(connection);
            aF.Show();
            this.Close();
        }

        private void Button_DataSetFournisseur_Click(object sender, EventArgs e)
        {
            DataFournisseur dF = new DataFournisseur(connection);
            dF.Show();
            this.Close();
        }
 
        private void Button_AjoutClient_Click(object sender, EventArgs e)
        {
            AjoutClient aC = new AjoutClient(connection);
            aC.Show();
            this.Close();
        }

        private void Button_SupprimerClient_Click(object sender, EventArgs e)
        {
            SuppClient supC = new SuppClient(connection); 
            supC.Show();
            this.Close();

        }

        private void Button_MAJClient_Click(object sender, EventArgs e)
        {
            MAJClient majC = new MAJClient(connection);
            majC.Show();
            this.Close();

        }

        private void Button_DataSetClient_Click(object sender, EventArgs e)
        {
            DataClient dataClient = new DataClient(connection);
            dataClient.Show();
            this.Close();

        }

        private void Button_AjoutCommande_Click(object sender, EventArgs e)
        {
            AjoutCommande commande = new AjoutCommande(connection);
            commande.Show();
            this.Close();


        }

        private void Button_SuppCommande_Click(object sender, EventArgs e)
        {
            SuppCommande supC = new SuppCommande(connection);
            supC.Show();
            this.Close();

        }

        private void Button_MAJCommande_Click(object sender, EventArgs e)
        {
            MAJCommande majC = new MAJCommande();
            majC.Show();
            this.Close();

        }

        private void Button_DataSetCommande_Click(object sender, EventArgs e)
        {
            DataCommande dataCommande = new DataCommande(connection);
            dataCommande.Show();
            this.Close();

        }

        private void Button_MAJFournisseur_Click(object sender, EventArgs e)
        {
            MajFournisseur majFournisseur = new MajFournisseur(connection);
            majFournisseur.Show();
            this.Close();

        }
        private void button4_Click(object sender, EventArgs e) // Supp Fournisseur
        {
            SuppFournisseur suppFournisseur = new SuppFournisseur(connection);
            suppFournisseur.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e) // Gestion des commandes
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

      

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void Buton_Retour_Click(object sender, EventArgs e)
        {
            Accueil ac = new Accueil(connection);
            ac.Show();
            this.Hide();
        }
    }
}
