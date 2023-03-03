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
    public partial class GestionInterne : Form
    {
        MySqlConnection connexion;
        public GestionInterne(MySqlConnection connexion)
        {
            InitializeComponent();
            this.connexion = connexion;
        }

        private void Button_AjoutVelo_Click(object sender, EventArgs e)
        {
            AjoutVelo ajoutVelo = new AjoutVelo(connexion);
            ajoutVelo.Show();
            this.Close();
        }

        private void Button_SuppVelo_Click(object sender, EventArgs e)
        {
            SuppVelo aSuppVelo = new SuppVelo(connexion);
            aSuppVelo.Show();
            this.Close();
        }

        private void Button_MAJVelo_Click(object sender, EventArgs e)
        {
            MAJVelo majVel = new MAJVelo(connexion);
            majVel.Show();
            this.Close();
        }

        private void Button_DataSetVelo_Click(object sender, EventArgs e)
        {
            DataVelo aDataVelo = new DataVelo(connexion);
            aDataVelo.Show();
            this.Close();
        }

        private void Button_AjoutPiece_Click(object sender, EventArgs e)
        {
            AjoutPiece ajoutPiece = new AjoutPiece(connexion);
            ajoutPiece.Show();
            this.Close();
        }

        private void Button_SuppPiece_Click(object sender, EventArgs e)
        {
            SuppPiece suppPiece = new SuppPiece(connexion);
            suppPiece.Show();
            this.Close();
        }

        private void Button_MAJPiece_Click(object sender, EventArgs e)
        {
            MAJPiece majPiece = new MAJPiece(connexion);
            majPiece.Show();
            this.Close();
        }

        private void Button_DataSetPiece_Click(object sender, EventArgs e)
        {
            DataPiece dataPiece = new DataPiece(connexion); 
            dataPiece.Show();
            this.Close();
        }

        private void Button_Retour_Click(object sender, EventArgs e)
        {
            Accueil ac = new Accueil(connexion);
            ac.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Approvisionnement approvisionnement = new Approvisionnement(connexion); 
            approvisionnement.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Stockage stockage = new Stockage(connexion);
            stockage.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // Hist
        {
            HistoriqueAppFournisseur H = new HistoriqueAppFournisseur(connexion);
            H.Show();
            this.Hide();

        }

        private void GestionInterne_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e) // Module Statistiques
        {
            ModuleStatistiques moduleStatistiques = new ModuleStatistiques(connexion);  
            moduleStatistiques.Show();
            this.Hide() ;
        }
    }
}
