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

    public partial class AjoutFournisseur : Form
    {
        MySqlConnection maconnexion = null;


        public AjoutFournisseur(MySqlConnection connexion)
        {
            this.maconnexion = connexion;

            InitializeComponent();
            //string connexionInfo = "SERVER=localhost;PORT=3306;DATABASE=vélomax;UID=root;PASSWORD=RmBM6781002%%;convert zero datetime=True";
            //this.maconnexion = new MySqlConnection(connexionInfo);
          
           

        }
        private void button1_Click(object sender, EventArgs e) // Valider l'insertion
        {

            try
            {

               Fournisseur_creation(maconnexion, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,Ville.Text, Convert.ToInt32(comboBox1.Text));
               MessageBox.Show("Le fournisseur \"" + textBox2.Text + "\" a été ajouté à la BDD");


            }
            catch(Exception ex)
            {
                MessageBox.Show("Ce fournisseur n'est pas valide\n\n"+ ex.Message);
            }

           
        }

        private void AjoutFournisseur_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) // Siret
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e) // Adresse
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) // nomF
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) // Contact
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e) // Libelle 
        {

        }

    

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Button_Retour_Click(object sender, EventArgs e)
        {
            GestionExterne gE = new GestionExterne(maconnexion);
            gE.Show();
            this.Close();
        }
    }
}

