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
    public partial class SuppCommande : Form
    {
        MySqlConnection connexion;
        DataSet ds;
        public SuppCommande(MySqlConnection connexion)
        {
            InitializeComponent();
            this.connexion = connexion;
        }
        private void DataCommand_Av_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow selectedRow = DataCommand_Av.Rows[i];
            string numPS = selectedRow.Cells[0].Value.ToString();

            NumCommande.Text = numPS;

        }
        private void Button_ValiderSuppComm_Click(object sender, EventArgs e)
        {
            try
            {
                Commande_Supression(connexion, NumCommande.Text);
                this.DataComm_Ap.DataSource = Affichage_table(connexion, "commande").Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.ToString());

            }
        }

        private void DataComm_Ap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NumCommande_TextChanged(object sender, EventArgs e)
        {

        }


        private void Buton_Retour_Click_1(object sender, EventArgs e)
        {
            GestionExterne gI = new GestionExterne(connexion);
            gI.Show();
            this.Close();
        }

        private void SuppCommande_Load_1(object sender, EventArgs e)
        {
            this.ds = Affichage_table(connexion, "Commande");
            DataCommand_Av.DataSource = ds.Tables[0];
        }
    }
}
