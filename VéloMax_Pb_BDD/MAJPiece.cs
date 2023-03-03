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
    public partial class MAJPiece : Form
    {
        MySqlConnection connexion;
        DataSet ds;
        public MAJPiece(MySqlConnection connexion)
        {
            InitializeComponent();
            this.connexion = connexion;
        }

        private void Button_ValiderMAJ_Click(object sender, EventArgs e)
        {

            try
            {
                if (ComboBox_Parametre.Text == "description_")
                {
                    Piece_update(connexion, NumeroPiece.Text, "description_", ComboBox_Desc.Text);
                    this.DataPiece_Ap.DataSource = Affichage_table(connexion, "piece").Tables[0];
                }

                else
                {
                    Piece_update(connexion, NumeroPiece.Text, ComboBox_Parametre.Text, ParametreValue.Text);
                    this.DataPiece_Ap.DataSource = Affichage_table(connexion, "piece").Tables[0];
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.ToString());
            }
        }

        private void MAJPiece_Load(object sender, EventArgs e)
        {
            this.ds = Affichage_table(connexion, "Piece");
            DataPiece_Av.DataSource = ds.Tables[0];
        }

        private void DataPiece_Av_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataPiece_Ap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ComboBox_Desc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Parametre.Text != "description_")
            {
                ComboBox_Desc.Enabled = false;
                ComboBox_Desc.Text = "inaccessible";
            }
        }

        private void ParametreValue_TextChanged(object sender, EventArgs e)
        {
            if(ComboBox_Parametre.Text == "description_")
            {
                ParametreValue.Enabled = false;
                ParametreValue.Text = "inaccessible";
            }
        }

        private void Buton_Retour_Click(object sender, EventArgs e)
        {
            GestionInterne gI = new GestionInterne(connexion);
            gI.Show();
            this.Close();

        }
    }
}
