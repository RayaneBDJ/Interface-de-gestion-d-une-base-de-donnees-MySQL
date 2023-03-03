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

   
    public partial class Stockage : Form
    {

        MySqlConnection connection;
        DataSet data_velos;
        DataSet data_piece;
        DataSet data_fourn;
        public Stockage(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            this.data_velos = new DataSet();
            this.data_piece = new DataSet();
            this.data_fourn = new DataSet(); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Stockage_Load(object sender, EventArgs e)
        {
            try
            {
                Stockage(connection,"velo",data_velos);
                dataGridView1.DataSource = data_velos.Tables[0];

                Stockage(connection, "piece", data_piece);
                dataGridView2.DataSource = data_piece.Tables[0];

                Stockage(connection, "fournisseur", data_fourn);
                dataGridView3.DataSource = data_fourn.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button_Retour_Click(object sender, EventArgs e)
        {
            GestionInterne gI = new GestionInterne(connection);
            gI.Show();
            this.Hide();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Produit_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rechercher_Click(object sender, EventArgs e)
        {
            bool choix = false;
            DataSet piece = Affichage_table(connection, "Piece");

            foreach (DataRow drRow in data_velos.Tables[0].Rows)
            {
                if (Produit.Text == drRow[0].ToString())
                {
                    MessageBox.Show("Le produit " + Produit.Text + "est un vélo se trouvant dans nos stocks");
                    choix = true;
                }

            }
            foreach (DataRow dRow in piece.Tables[0].Rows)
            {
                if (Produit.Text == dRow[0].ToString())
                {
                    MessageBox.Show("Le produit " + Produit.Text + " est une pièce se trouvant dans nos stocks");
                    choix = true;
                }
  
            }
            if(choix == false )
            {
                MessageBox.Show("Votre produit n'existe pas, veuillez passez une commande de la piece ou du velo auprès d'un fournisseur ");
                Approvisionnement aC = new Approvisionnement(connection);
                aC.Show();
                this.Hide();
            }

        }
    }
}
