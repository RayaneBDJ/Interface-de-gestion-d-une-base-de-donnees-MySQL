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
    public partial class DataFournisseur : Form
    {
        MySqlConnection conn;
        DataSet ds;
        public DataFournisseur(MySqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            this.ds = new DataSet();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Buton_Retour_Click(object sender, EventArgs e)
        {
            GestionExterne gE = new GestionExterne(conn);
            gE.Show();
            this.Close();
        }

        private void DataFournisseur_Load(object sender, EventArgs e)
        {
            try
            {
                ds = Affichage_table(conn, "Fournisseur");
         

                dataGridView1.DataSource = ds.Tables[0];


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
