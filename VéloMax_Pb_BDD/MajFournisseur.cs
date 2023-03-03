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
    public partial class MajFournisseur : Form
    {

        MySqlConnection connection;
        public MajFournisseur(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;

        }

        private void MajFournisseur_Load(object sender, EventArgs e)
        {
            DataP_Av.DataSource = Affichage_table(connection,"Fournisseur").Tables[0];
        }

        private void DataP_Av_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow selectedRow = DataP_Av.Rows[i];
            string numFS = selectedRow.Cells[0].Value.ToString();

            NumeroFournisseur.Text = numFS;
            
        }

        private void ComboBox_Parametre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button_ValiderMAJ_Click(object sender, EventArgs e)
        {
            try
            {
                Fournisseur_update(connection, NumeroFournisseur.Text, ComboBox_Parametre.Text, ParametreValue.Text);
                Data_Ap.DataSource = Affichage_table(connection, "fournisseur").Tables[0];


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.ToString());
            }
        }
    }
}
