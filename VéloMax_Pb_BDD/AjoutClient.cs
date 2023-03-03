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
    public partial class AjoutClient : Form
    {

        MySqlConnection connexion;
        int numero_fidelio;
        public AjoutClient(MySqlConnection maconnexion, int numero_fidelio = 0)
        {
            InitializeComponent();

            this.connexion = maconnexion;
            this.numero_fidelio = numero_fidelio;
            if (this.numero_fidelio > 0) 
            {
                checkBox1.CheckState = CheckState.Checked;
            }
            else
            {
                checkBox1.CheckState = CheckState.Unchecked;
            }
        }
        private void AjoutClient_Load(object sender, EventArgs e)
        {
           
     
        }
        private void Button_ValiderAjoutParticulier_Click(object sender, EventArgs e)
        {
            string typeClient = "Particulier";

            try
            {
                DateTime expiration = DateTime.Now;
                DateTime exp = new DateTime();
                DateTime adhesion = Convert.ToDateTime(DateTime.Now.ToString("MM/dd/yyyy"));
                if (numero_fidelio == 0)
                {
                    exp = expiration.AddYears(numero_fidelio);
                }
                else if(numero_fidelio == 1)
                {
                    exp = expiration.AddYears(1);

                }
                else if(numero_fidelio == 4)
                {
                    exp = expiration.AddYears(3);
                }
                else if (numero_fidelio == 2 || numero_fidelio == 3)
                {
                    exp =expiration.AddYears(2);
                    MessageBox.Show(expiration.ToString());
                }
                Client_creation(connexion, typeClient, nomParticulier.Text,villeParticulier.Text,rueParticulier.Text,codePParticulier.Text, provinceParticulier.Text,numeroParticulier.Text,courrielParticulier.Text, adhesion,exp, numero_fidelio, prenomParticulier.Text);
                string nomParticulierAjouté = nomParticulier.Text;
                string prenomParticulierAjouté = prenomParticulier.Text;
                nomParticulier.Text = "";
                prenomParticulier.Text = "";
                MessageBox.Show("L'individu " + nomParticulierAjouté + " " + prenomParticulierAjouté + " a été ajouté à la BDD");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.ToString());
                
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e) // Vérifie si le programme fidelio a été pris ou pas
        {

            if (checkBox1.Checked)
            {
                try
                {
                    Fidelio fidelio = new Fidelio(connexion);
                    fidelio.Show();// Do something when CheckBox is checked
                    this.Hide();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\n" + ex.ToString());
                }
           
            }

        }

        private void Button_ValiderAjoutBoutique_Click(object sender, EventArgs e)
        {
            string typeClient = "Boutique";

            try
            {


                Client_creation(connexion, typeClient, NomB.Text, villeB.Text, rueB.Text, codePB.Text, provinceB.Text, numeB.Text, courrB.Text, DateTime.Now, DateTime.Now, 0, "",contactB.Text,Convert.ToInt32(RemiseBoutiqueT.Text));            
                MessageBox.Show("La Boutique " + NomB.Text + " a été ajouté à la BDD");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.ToString());
                MessageBox.Show("Vous avez mal remplies les cases");

            }



        }

        private void Button_retour_Click(object sender, EventArgs e)
        {

        }
        private void nomParticulier_TextChanged(object sender, EventArgs e)
        {

        }

        private void prenomParticulier_TextChanged(object sender, EventArgs e)
        {

        }

        private void villeParticulier_TextChanged(object sender, EventArgs e)
        {

        }

        private void rueParticulier_TextChanged(object sender, EventArgs e)
        {

        }

        private void codePParticulier_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
