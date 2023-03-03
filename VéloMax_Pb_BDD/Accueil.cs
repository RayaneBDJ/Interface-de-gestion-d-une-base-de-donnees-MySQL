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
    public partial class Accueil : Form
    {

        MySqlConnection connexion = null;
        public Accueil(MySqlConnection maconnexion)
        {
            InitializeComponent();
            this.connexion = maconnexion;
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)  // Gestion Externe 
        {
            GestionExterne g = new GestionExterne(connexion);
            g.Show();

        }
        private void button2_Click(object sender, EventArgs e) // Gestion Interne 
        {
            GestionInterne gI = new GestionInterne(connexion);
            gI.Show();
     
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) // Quitter La connexion et la page accueil
        {
            this.Close();
            connexion.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Evaluateur eval = new Evaluateur(connexion);
            eval.Show();

        }
    }
}
