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
    public partial class SuppPiece : Form
    {
        MySqlConnection connexion;
        DataSet ds;
        public SuppPiece(MySqlConnection connexion)
        {
            InitializeComponent();
            this.connexion = connexion;
        }
        private void SuppPiece_Load(object sender, EventArgs e)
        {
            this.ds = Affichage_table(connexion, "Piece");
            DataPiece_Av.DataSource = ds.Tables[0];

        }
        private void DataPiece_Av_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow selectedRow = DataPiece_Av.Rows[i];
            string numPS = selectedRow.Cells[0].Value.ToString();

            NumPiece.Text = numPS;

        }
        private void Button_ValiderSuppPiece_Click(object sender, EventArgs e)
        {
            try
            {
                Piece_Suppression(connexion, NumPiece.Text);
                this.DataPiece_Ap.DataSource = Affichage_table(connexion, "piece").Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.ToString());

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void DataPiece_Ap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Buton_Retour_Click(object sender, EventArgs e)
        {
            GestionInterne gI = new GestionInterne(connexion);
            gI.Show();
            this.Close();
        }
    }
}
