using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

using MySql.Data.MySqlClient;
using static VéloMax_Pb_BDD.MethodesDataSQL;

namespace VéloMax_Pb_BDD
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MySqlConnection maconnection = null; // ouverture de la connexion avec mysql

            try
            {
                // indiquer les infos de la connexion
                string connexionInfo = "SERVER=localhost;PORT=3306;DATABASE=vélomax;UID=root;PASSWORD=RmBM6781002%%;convert zero datetime=True";

                // objet de la connexion
                maconnection = new MySqlConnection(connexionInfo);

                maconnection.Open();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Accueil(maconnection));

            }
            catch (MySqlException e)
            {
                Console.WriteLine("Erreur de connexion : " + e.ToString());
                return;
            }
            maconnection.Close();
        }

        public static DataSet Affichage_table(MySqlConnection connection, string table) // Reflechir a ça 
        {
            MySqlCommand requete = connection.CreateCommand(); // créer une commande qu'on peut remplir avec un string 
            string marequete = "Select * From " + table;
            requete.CommandText = marequete; // bien tester la requete sur WORKBENCH au prealable
                // Dans le cas d'un affichage Console

            /*while (exeRequete.Read())
            {
                //récupération du résultat ligne par ligne
                //Console.WriteLine("Il y a " + exeRequete.FieldCount + "colonnes");

                //pour chaque ligne 
                string ligne = "";

                for (int i = 0; i < exeRequete.FieldCount; i++)
                {

                    //construire la ligne dans une chaine de caratères
                    ligne = ligne + " \t" + exeRequete.GetValue(i).ToString();
                }
                tableau = tableau + "\n " + ligne;

            }

            Console.Write(tableau);*/
            // Ne pas oublier, pour se resservir de la même variable ;-)

            // DataSet // 

            DataSet data = new DataSet();
            MySqlDataAdapter datadapt = new MySqlDataAdapter(requete);
            datadapt.Fill(data);


            return data;
        }

    }
}
