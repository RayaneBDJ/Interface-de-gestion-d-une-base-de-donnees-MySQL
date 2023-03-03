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
    public partial class DataPiece : Form
    {


        MySqlConnection connexion;
        DataSet ds;
        public DataPiece(MySqlConnection connexion)
        {
            InitializeComponent();
            this.connexion = connexion;
        }
        private void DataPiece_Load(object sender, EventArgs e)
        {
            this.ds = Affichage_table(connexion, "Piece");
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
