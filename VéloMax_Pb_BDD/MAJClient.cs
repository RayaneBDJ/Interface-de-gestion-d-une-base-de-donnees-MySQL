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
    public partial class MAJClient : Form
    {
        MySqlConnection connection;
        DataSet ds_Particulier;
        DataSet ds_Boutique;
 
        public MAJClient(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void MAJClient_Load(object sender, EventArgs e)
        {
            ds_Particulier = Affichage_table(connection, "Particulier");
            ds_Boutique = Affichage_table(connection, "Boutique");
            DataParticulier_Av.DataSource = ds_Particulier.Tables[0];
            DataBoutique_Av.DataSource = ds_Boutique.Tables[0];

        }

        private void Button_ValiderSuppBoutique_Click(object sender, EventArgs e)
        {
            string typeClient = "Boutique";

            try
            {
                Client_update(connection, typeClient, NomBoutique.Text, "", ComBox_Boutique.Text, ParametreValueBoutique.Text);
                this.DataBoutique_Ap.DataSource = Affichage_table(connection, "Boutique").Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.ToString());

            }
        
        }

        private void Button_ValiderMAJPart_Click(object sender, EventArgs e)
        {
            string typeClient = "Particulier";

            try
            {
                Client_update(connection, typeClient, NomParticulier.Text, PrenomPart.Text, ComBox_Particulier.Text, ParametreValuePart.Text);
                this.DataParticulier_Ap.DataSource = Affichage_table(connection, "Particulier").Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.ToString());

            }
        }
    
        private void DataParticulier_Av_CellContentClick(object sender, DataGridViewCellEventArgs e) // Data 
        {
            int i = e.RowIndex;
            DataGridViewRow selectedRow = DataParticulier_Av.Rows[i];
            string nomPS = selectedRow.Cells[0].Value.ToString();
            string prenomPS = selectedRow.Cells[1].Value.ToString();

            NomParticulier.Text = nomPS;
            PrenomPart.Text = prenomPS;
        }

        private void DataBoutique_Av_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow selectedRow = DataBoutique_Av.Rows[i];
            string nomBS = selectedRow.Cells[0].Value.ToString();

            NomBoutique.Text = nomBS;

        }

        private void DataParticulier_Ap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataBoutique_Ap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void NomParticulier_TextChanged(object sender, EventArgs e)
        {

        }

        private void ParametreValuePart_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComBox_Boutique_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button_retour_Click(object sender, EventArgs e)
        {
            GestionExterne gE = new GestionExterne(connection);
            gE.Show();
            this.Close();
        }

    }
}
