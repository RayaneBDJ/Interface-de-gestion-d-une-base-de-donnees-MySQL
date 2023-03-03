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
    public partial class SuppClient : Form
    {
        MySqlConnection connexion;
        DataSet ds_Particulier;
        DataSet ds_Boutique;
        string nomP;
        string prenomP;
        string nomB;

        public SuppClient(MySqlConnection maconnexion)
        {
            InitializeComponent();

            this.connexion = maconnexion;
            

        }

        private void SuppClient_Load(object sender, EventArgs e)
        {
            ds_Particulier = Affichage_table(connexion, "Particulier");
            ds_Boutique = Affichage_table(connexion, "Boutique");
            DataParticulier_Av.DataSource = ds_Particulier.Tables[0];
            DataBoutique_Av.DataSource = ds_Boutique.Tables[0];
        }

        private void DataParticulier_Av_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow selectedRow = DataParticulier_Av.Rows[i];
            string nomPS = selectedRow.Cells[0].Value.ToString();
            string prenomPS = selectedRow.Cells[1].Value.ToString();

            this.prenomP = prenomPS;
            this.nomP = nomPS;

            NomParticulier.Text = nomP;
            PrenomParticulier.Text = prenomP;
           
        }

        private void DataParticulier_Ap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataBoutique_Av_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow selectedRow = DataBoutique_Av.Rows[i];
            string nomBS = selectedRow.Cells[0].Value.ToString();

            this.nomB = nomBS;

            NomBoutique.Text = nomP;
  
        }

        private void DataBoutique_Ap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button_retour_Click(object sender, EventArgs e)
        {
            GestionExterne gE = new GestionExterne(connexion);
            gE.Show();
            this.Close();
        }

        private void NomParticulier_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrenomParticulier_TextChanged(object sender, EventArgs e)
        {

        }

        private void NomBoutique_TextChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Button_ValiderSuppPart_Click(object sender, EventArgs e)
        {
            string typeClient = "Particulier";

            try
            {
                Client_Suppression(connexion, typeClient, nomP, prenomP);
                this.DataParticulier_Ap.DataSource = Affichage_table(connexion, "Particulier").Tables[0];
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.ToString());

            }

            
            
        }

        private void Button_ValiderSuppBoutique_Click(object sender, EventArgs e)
        {
            string typeClient = "Boutique";

            try
            {
                Client_Suppression(connexion, typeClient, nomB, prenomP);
                this.DataBoutique_Ap.DataSource = Affichage_table(connexion, "Boutique").Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.ToString());

            }
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
     

    }
}
