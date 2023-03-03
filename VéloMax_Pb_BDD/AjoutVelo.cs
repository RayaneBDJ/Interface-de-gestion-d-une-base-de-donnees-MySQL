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
    public partial class AjoutVelo : Form
    {
        MySqlConnection connection;
        public AjoutVelo(MySqlConnection connexion)
        {
            InitializeComponent();
            this.connection = connexion;   
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void provinceParticulier_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Button_ValiderAjoutParticulier_Click(object sender, EventArgs e)
        {
            try
            {
                Velo_creation(connection, NomVélo.Text, ComboBoxGrandeur.Text, Convert.ToInt32(prixV.Text), ComboBoxPoduit.Text, DateTime.Parse(DateDébutV.Text), DateTime.Parse("01/01/0001"));
                MessageBox.Show("Le vélo " + NomV.Text + "a été ajouté à la BDD");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.ToString());

            }
        }

        private void Button_Retour_Click(object sender, EventArgs e)
        {
            GestionInterne gI = new GestionInterne(connection);
            gI.Show();
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AjoutVelo_Load(object sender, EventArgs e)
        {

        }
    }
}
