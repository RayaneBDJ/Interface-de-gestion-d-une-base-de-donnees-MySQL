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
    public partial class Fidelio : Form
    {
        int numF;
        DataSet ds;
        string type;
        int cout;
        int duree;
        int rabais;

        bool box_checked;

        MySqlConnection connexion;
        public Fidelio(MySqlConnection maconnexion)
        {
            InitializeComponent();
            connexion = maconnexion;
            ds = Affichage_table(maconnexion, "Fidelio");
            this.box_checked = true;
        }

        public int NumF
        { get { return numF; } }

        public bool BoxChecked
        { get { return box_checked; } }

        private void Fidelio_Load(object sender, EventArgs e)
        {
            
            this.dataGridView1.DataSource = ds.Tables[0];


        }

        private void ComboBox_Fidelio_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Button_ValiderProgramme_Click(object sender, EventArgs e)
        {
            this.numF = Convert.ToInt32(ComboBox_Fidelio.Text);
            AjoutClient aC = new AjoutClient(connexion, numF);
            aC.Show();
            this.Close();
        }

        private void Button_Retour_Click(object sender, EventArgs e)
        {
            AjoutClient aC = new AjoutClient(connexion);
            aC.Show();
            this.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[i];
            string numFS = selectedRow.Cells[0].Value.ToString();
            this.numF = Convert.ToInt32(numF);
            this.type = selectedRow.Cells[1].Value.ToString();
            this.cout = Convert.ToInt32(selectedRow.Cells[2].Value.ToString());
            this.duree = Convert.ToInt32(selectedRow.Cells[3].Value.ToString());
            this.rabais = Convert.ToInt32(selectedRow.Cells[4].Value.ToString());

            TypeFidelio.Text = type;
            CoutFidelio.Text = cout.ToString();
            DureeFidelio.Text = duree.ToString();
            RabaisFidelio.Text = rabais.ToString();

        }
    }
}
