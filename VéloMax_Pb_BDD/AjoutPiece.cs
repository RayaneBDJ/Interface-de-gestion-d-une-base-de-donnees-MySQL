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
    public partial class AjoutPiece : Form
    {
        MySqlConnection connexion;
        public AjoutPiece(MySqlConnection connexion)
        {
            InitializeComponent();
            this.connexion = connexion;
        }

        private void AjoutPiece_Load(object sender, EventArgs e)
        {

        }

        private void Button_ValiderAjoutPièce_Click(object sender, EventArgs e)
        {
            try
            {
                Piece_creation(connexion, NumPièce.Text, ComboBoxDesc.Text, DateTime.Parse(DateDébutP.Text), DateTime.Parse("01/01/0001"), Convert.ToInt32(quantité_pièce.Text));
                string numPieceAjouté = NumPièce.Text;
                NumPièce.Text = "";
                ComboBoxDesc.Text = "";
                MessageBox.Show("La pièce " + numPieceAjouté + " a été ajouté à la BDD");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.ToString());

            }
        }

        private void Button_Retour_Click(object sender, EventArgs e)
        {
            GestionInterne gI = new GestionInterne(connexion);
            gI.Show();
            this.Close();
        }

    }
}
