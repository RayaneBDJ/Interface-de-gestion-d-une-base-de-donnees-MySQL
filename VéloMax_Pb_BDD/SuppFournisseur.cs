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
   
    public partial class SuppFournisseur : Form
    {
        MySqlConnection connexion = null;
        DataSet ds_av;
        DataSet ds_ap;

        public SuppFournisseur(MySqlConnection connexion)
        {
            InitializeComponent();
            this.connexion = connexion;
        }

        private void SuppFournisseur_Load(object sender, EventArgs e)
        {
            ds_av = Affichage_table(connexion, "Fournisseur");
            DataFournisseur_Av.DataSource = ds_av.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Fournisseur_Suppression(connexion, textBox1.Text, textBox2.Text,Convert.ToInt32(textBox3.Text));
            }
            catch
            {
                MessageBox.Show("Le Fournisseur que vous tentez de supprimer n'existe pas.");
            }

            ds_ap = Affichage_table(connexion, "Fournisseur");
            DataFournisseur_Ap.DataSource = ds_ap.Tables[0];

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataFournisseur_Av_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataFournisseur_Ap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
