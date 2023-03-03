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
    public partial class Approvisionnement : Form
    {
        MySqlConnection conn;
        DataSet ds_Stock_Pièces;
        DataSet ds_fournisseur;
        DataSet ds_pièces_av;
        DataSet ds_pièces_ap;
        List<string> myList;

        public Approvisionnement(MySqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            this.ds_fournisseur = new DataSet();
            this.ds_Stock_Pièces = new DataSet();
            this.ds_pièces_av = new DataSet();
            this.ds_pièces_ap = new DataSet();
            this.myList = new List<string>();

        }

        private void Approvisionnement_Load(object sender, EventArgs e)
        {
            try
            {
                Stockage(conn, "piece", ds_Stock_Pièces);
                dataGridView1.DataSource = ds_Stock_Pièces.Tables[0];

                ds_fournisseur = Affichage_table(conn, "fournisseur");
                dataGridView2.DataSource = ds_fournisseur.Tables[0];

                ds_pièces_av = Affichage_table(conn, "piece");
                      
                foreach (DataRow row in ds_pièces_av.Tables[0].Rows)
                {
                    myList.Add(row[0].ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.ToString());
            }




        }

        private void NumPiece_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) // STOCKS ACTUELS
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) // Fournisseur
        {
            try
            {
                int i = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView2.Rows[i];
                string numFS = selectedRow.Cells[0].Value.ToString();
                NumF.Text = numFS;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e) // STOCKS Après coup
        {

        }

        private void Validate_Button_Click(object sender, EventArgs e)
        {
            try
            {
                int cpt = 0; 
                bool in_while = true;
                while (in_while)
                {
                    foreach (string value in myList)
                    {
                        if (NumPiece.Text == value)
                        {
                            in_while = false;
                            Piece_update(conn, NumPiece.Text, "qté_pièce", Quantité.Text);
                            Piece_update(conn, NumPiece.Text, "description_", ComboBoxDesc.Text);
                        }
                        else if (NumPiece.Text != value)
                        {
                            cpt += 1;
                            MessageBox.Show(cpt.ToString() + " " + myList.Count.ToString());
                            
                            if (cpt == myList.Count)
                            {
                                Piece_creation(conn, NumPiece.Text, ComboBoxDesc.Text, DateTime.Parse("01/01/0001"), DateTime.Parse("01/01/0001"), Convert.ToInt32(Quantité.Text));
                                in_while = false;
                                MessageBox.Show("A Piece was created with the number : " + NumPiece.Text);
                            }
                        }
                    }
                }
                MessageBox.Show(NumF.Text);


                if (Delai.Text == "(Jours)")
                {
                    Approvisionner(conn, NumPiece.Text, NumF.Text, Convert.ToInt32(Quantité.Text), 0, Convert.ToInt32(PrixPièce.Text), NumPF.Text);
                }
                else
                {

                    Approvisionner(conn, NumPiece.Text, NumF.Text, Convert.ToInt32(Quantité.Text), Convert.ToInt32(Delai.Text), Convert.ToInt32(PrixPièce.Text), NumPF.Text);

                }


                Stockage(conn, "piece", ds_pièces_ap);
                dataGridView3.DataSource = ds_pièces_ap.Tables[0];

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message +"\n\n" + ex.ToString());
            }
        }

        private void Buton_Retour_Click(object sender, EventArgs e)
        {
            GestionInterne g = new GestionInterne(conn);
            g.Show();
            this.Close();
        }

        private void ComboBoxDesc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
