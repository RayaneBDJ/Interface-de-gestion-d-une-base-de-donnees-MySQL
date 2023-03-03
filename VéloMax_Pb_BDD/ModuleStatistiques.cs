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
    public partial class ModuleStatistiques : Form
    {
        MySqlConnection cn;
        public ModuleStatistiques(MySqlConnection cn)
        {
            InitializeComponent();
            this.cn = cn;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Liste des quantités vendus de chaque item 
        {
            try
            {
                DataSet ds1 = new DataSet();
                DataSet ds2 = new DataSet();

                string qte_vendus_pieces = "SELECT numP_rechange,SUM(qteP_commande) " +
                                     "FROM Contient_Piece " +
                                     "GROUP BY numP_rechange";

                string qte_vendus_velos = "SELECT CV.numV,SUM(qteV_commande) " +
                                     "FROM Contient_Velo CV " +
                                     "GROUP BY CV.numV ";

                MySqlCommand pieces_vendus = cn.CreateCommand();
                pieces_vendus.CommandText = qte_vendus_pieces;

                MySqlCommand velos_vendus = cn.CreateCommand();
                velos_vendus.CommandText = qte_vendus_velos;


               

                MySqlDataAdapter ds1_adapter = new MySqlDataAdapter(pieces_vendus);
                ds1_adapter.Fill(ds1);

                MySqlDataAdapter ds2_adapter = new MySqlDataAdapter(velos_vendus);
                ds2_adapter.Fill(ds2);

                dataGridView1.DataSource = ds1.Tables[0];
                dataGridView7.DataSource = ds2.Tables[0];


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.ToString());
            }
        }

        private void Button_Fidelio_Click(object sender, EventArgs e)
        {
            try
            {
                string qte_clients_1 = "SELECT numF,nomP,prenom" +
                                     " FROM Particulier" +
                                     " WHERE numF = 1 ";
                string qte_clients_2 = "SELECT numF,nomP,prenom" +
                                     " FROM Particulier" +
                                     " WHERE numF = 2 ";
                string qte_clients_3 = "SELECT numF,nomP,prenom" +
                                     " FROM Particulier" +
                                     " WHERE numF = 3 ";
                string qte_clients_4 = "SELECT numF,nomP,prenom" +
                                     " FROM Particulier" +
                                     " WHERE numF = 4 ";

                MySqlCommand fidelio_1 = cn.CreateCommand();
                fidelio_1.CommandText = qte_clients_1;

                MySqlCommand fidelio_2 = cn.CreateCommand();
                fidelio_2.CommandText = qte_clients_2;

                MySqlCommand fidelio_3 = cn.CreateCommand();
                fidelio_3.CommandText = qte_clients_3;

                MySqlCommand fidelio_4 = cn.CreateCommand();
                fidelio_4.CommandText = qte_clients_4;

                DataSet ds1 = new DataSet();
                DataSet ds2 = new DataSet();
                DataSet ds3 = new DataSet();
                DataSet ds4 = new DataSet();


                MySqlDataAdapter d1 = new MySqlDataAdapter(fidelio_1);
                MySqlDataAdapter d2 = new MySqlDataAdapter(fidelio_2);
                MySqlDataAdapter d3 = new MySqlDataAdapter(fidelio_3);  
                MySqlDataAdapter d4 = new MySqlDataAdapter(fidelio_4);

                d1.Fill(ds1);
                d2.Fill(ds2);
                d3.Fill(ds3);   
                d4.Fill(ds4);

                DataF1.DataSource = ds1.Tables[0];
                DataF2.DataSource = ds2.Tables[0];
                DataF3.DataSource = ds3.Tables[0];
                DataF4.DataSource = ds4.Tables[0];
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_BestClients_Click(object sender, EventArgs e)
        {
            try
            {
                string select_velos_clients = "SELECT C.nomP,SUM((V.prix*CV.qteV_commande)) AS Montant " +
                                               " FROM Velo V Natural Join(Contient_Velo CV Natural Join Commande C) " +
                                               " WHERE C.nomP IN(SELECT nomP FROM Commande NATURAL JOIN Contient_Velo) " +
                                               " ORDER BY Montant ";

                string select_pièces_clients = "SELECT C.nomP,SUM((P.prix_unité * CP.qteP_commande)) AS Montant " +
                                                "FROM Piece P Natural Join(Contient_Piece CP Natural Join Commande C) " +
                                                " WHERE C.nomP IN(SELECT nomP FROM Commande NATURAL JOIN Contient_Velo  ) " +
                                                "ORDER BY Montant";

                string select_clients = "SELECT V.nomP,V.montant,P.montant,SUM(V.montant + P.montant) AS Total " +
                                        "FROM (" + select_pièces_clients + ") AS P, (" + select_velos_clients + ") AS V ";
                                  


                DataSet dataSet = new DataSet();


                MySqlCommand command = cn.CreateCommand();
                command.CommandText = select_clients;

                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(command);
                mySqlDataAdapter.Fill(dataSet);

                dataGridView5.DataSource = dataSet.Tables[0];


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ModuleStatistiques_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DatExp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Expiration_Click(object sender, EventArgs e)
        {
            try
            {
                string requete_expiration = "SELECT nomP,prenom,numF,date_adhésion_F,date_expiration_F FROM Particulier ";

                DataSet ds = new DataSet();

                MySqlCommand exp_command = cn.CreateCommand();
                exp_command.CommandText = requete_expiration;

                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(exp_command);
                mySqlDataAdapter.Fill(ds);

                DatExp.DataSource = ds.Tables[0];


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
