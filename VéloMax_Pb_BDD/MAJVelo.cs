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
    public partial class MAJVelo : Form
    {
        MySqlConnection connexion;
        DataSet ds;
        public MAJVelo(MySqlConnection connexion)
        {
            InitializeComponent();
            this.connexion = connexion;
        }
        private void MAJVelo_Load(object sender, EventArgs e)
        {
            this.ds = Affichage_table(connexion, "Velo");
            DataVélo_Av.DataSource = ds.Tables[0];
            
        }
        private void Button_ValiderMAJ_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (ComboBox_Parametre.Text == "grandeur")
                {
                    Velo_update(connexion, Convert.ToInt32(NumeroVélo.Text),"grandeur", ComboBox_Grandeur.Text);
                    this.DataVélo_Ap.DataSource = Affichage_table(connexion, "Velo").Tables[0];
                }
                else if(ComboBox_Parametre.Text == "ligne_produit")
                {
                    Velo_update(connexion, Convert.ToInt32(NumeroVélo.Text), "ligne_produit", ComboBox_Produit.Text);
                    this.DataVélo_Ap.DataSource = Affichage_table(connexion, "Velo").Tables[0];
                }
               else
                {
                    Velo_update(connexion, Convert.ToInt32(NumeroVélo.Text), ComboBox_Parametre.Text, ParametreValue.Text);
                    this.DataVélo_Ap.DataSource = Affichage_table(connexion, "Velo").Tables[0];
                }
            

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

            NumeroVélo.Text = numVS;
            NomVélo.Text = selectedRow.Cells[1].Value.ToString();

        }

        private void DataVélo_Ap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ComboBox_Grandeur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Parametre.Text != "grandeur")
            {
                ComboBox_Grandeur.Enabled = false;
                ComboBox_Grandeur.Text = "inaccessible";
            }
        }

        private void ParametreValue_TextChanged(object sender, EventArgs e)
        {
            if (ComboBox_Parametre.Text == "grandeur" || ComboBox_Parametre.Text == "ligne_produit")
            {
                ParametreValue.Enabled = false;
                ParametreValue.Text = "innaccessible";
            }
        }

        private void ComboBox_Produit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Parametre.Text != "ligne_produit")
            {
                ComboBox_Produit.Enabled = false;
                ComboBox_Produit.Text = "innaccessible";
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NumeroVélo_TextChanged(object sender, EventArgs e)
        {
            Button_ValiderMAJ.Text += NumeroVélo.Text;
        }

        private void NomVélo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_ValiderSuppPart_Click(object sender, EventArgs e)
        {

        }

       
    }
}
