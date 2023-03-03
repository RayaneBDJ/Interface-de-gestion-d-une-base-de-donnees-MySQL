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
    public partial class SuppVelo : Form
    {

        MySqlConnection connexion;
        DataSet ds;
        public SuppVelo(MySqlConnection connexion)
        {
            InitializeComponent();
            this.connexion = connexion;
        }

        private void SuppVelo_Load(object sender, EventArgs e)
        {

            this.ds = Affichage_table(connexion, "Velo");
            DataVélo_Av.DataSource = ds.Tables[0];
      
        }

        private void Button_ValiderSuppPart_Click(object sender, EventArgs e)
        {
            try
            {
                Velo_Suppression(connexion, Convert.ToInt32(NumeroVélo.Text));
                this.DataVélo_Ap.DataSource = Affichage_table(connexion, "Velo").Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.ToString());

            }

        }

        private void DataVélo_Av_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow selectedRow = DataVélo_Av.Rows[i];
            string numVS = selectedRow.Cells[0].Value.ToString();
            string nomVS = selectedRow.Cells[1].Value.ToString();

            NumeroVélo.Text = numVS;
            NomVélo.Text = nomVS;
        }

        private void DataVélo_Ap_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
