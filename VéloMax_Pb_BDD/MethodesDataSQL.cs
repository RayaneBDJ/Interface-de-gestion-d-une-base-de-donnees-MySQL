using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace VéloMax_Pb_BDD
{
    internal class MethodesDataSQL
    {

        //                                Methodes globales à toutes les tables                 // 


        public static DataSet Affichage_table(MySqlConnection connection, string table) // Reflechir a ça 
        {
            DataSet data = new DataSet();

            if (table == "Contient_Piece" || table == "Contient_Velo")
            {
                MySqlCommand requete_contient = connection.CreateCommand(); // créer une commande qu'on peut remplir avec un string 
                string marequete_contient = "Select * From " + table + " as VP Natural Join Commande C";
                requete_contient.CommandText = marequete_contient; // bien tester la requete sur WORKBENCH au prealable 
                                                                   // DataSet // 

             
                MySqlDataAdapter datadapt = new MySqlDataAdapter(requete_contient);
                datadapt.Fill(data, table);
            }
            else
            {
                MySqlCommand requete = connection.CreateCommand(); // créer une commande qu'on peut remplir avec un string 
                string marequete = "Select * From " + table;
                requete.CommandText = marequete; // bien tester la requete sur WORKBENCH au prealable 
                                                 // DataSet // 

              
                MySqlDataAdapter datadapt = new MySqlDataAdapter(requete);
                datadapt.Fill(data, table);
            }

            


            return data;
        }
        public static int Count(MySqlConnection connection, string table)
        {

            int count = 0;

            string requete_count = "SELECT COUNT(*) FROM " + table;

            MySqlCommand count_command = connection.CreateCommand();
            count_command.CommandText = requete_count;

            MySqlDataReader count_reader = count_command.ExecuteReader();

            while (count_reader.Read())
            {
                count = Convert.ToInt32(count_reader.GetValue(0).ToString());
            }
            MessageBox.Show(count.ToString());

            count_reader.Close();


            return count;


        }











        //                                   Methodes Gestion Fournisseurs                                  //

        public static void Fournisseur_creation(MySqlConnection connection, string Siret, string nomF, string contact, string adresse, string ville, int libelle)  // insere un nouveau fournisseur 
        {
            string insert = "INSERT INTO Fournisseur Values(@Siret,@nomF,@contact,@adresse,@ville,@libelle)";

            MySqlCommand requete_insert_fournisseur = connection.CreateCommand();
            requete_insert_fournisseur.CommandText = insert;

            // Créer des parametres pour la commande sql, parametres qui feront office d'attributs dans la requete 

            requete_insert_fournisseur.Parameters.AddWithValue("@Siret", Siret);
            requete_insert_fournisseur.Parameters.AddWithValue("@nomF", nomF);
            requete_insert_fournisseur.Parameters.AddWithValue("@contact", contact);
            requete_insert_fournisseur.Parameters.AddWithValue("@adresse", adresse);
            requete_insert_fournisseur.Parameters.AddWithValue("@libelle", libelle);
            requete_insert_fournisseur.Parameters.AddWithValue("@ville", ville);

            requete_insert_fournisseur.ExecuteNonQuery();

        }
        public static void Fournisseur_Suppression(MySqlConnection connection, string Siret, string nomF, int libelle = 0) // delete un fournisseur
        {

            string delete = "Delete from Fournisseur where Siret = @siret or nomF = @nomF or libelle <= @libelle";

            // Créez l'objet Command. qui envoie une requete
            MySqlCommand requete_del_fournisseur = connection.CreateCommand();
            requete_del_fournisseur.CommandText = delete;


            // Parametres de la commande 

            requete_del_fournisseur.Parameters.AddWithValue("@siret", Siret);
            requete_del_fournisseur.Parameters.AddWithValue("@nomF", nomF);
            requete_del_fournisseur.Parameters.AddWithValue("@libelle", libelle);

            // Exécutez Command (Utilisez pour supprimer, insérer, mettre à jour) 
            requete_del_fournisseur.ExecuteNonQuery();


        }

        public static void Fournisseur_update(MySqlConnection connection, string numF, string nomParametre, string parametreValue)  // insere un nouveau Client 
        {


            string update = "UPDATE Fournisseur SET " + nomParametre + " = @parametreValue WHERE Siret = @numF ";

            MySqlCommand requete_update_fournisseur = connection.CreateCommand();
            requete_update_fournisseur.CommandText = update;

            // Créer des parametres pour la commande sql, parametres qui feront office d'attributs dans la requete 

            requete_update_fournisseur.Parameters.AddWithValue("@numF", numF);

            if (nomParametre == "libelle")
            {
                int parValue = Convert.ToInt32(parametreValue);
                requete_update_fournisseur.Parameters.AddWithValue("@parametreValue", parValue);
            }      
            else
            {
                requete_update_fournisseur.Parameters.AddWithValue("@parametreValue", parametreValue);

            }

            requete_update_fournisseur.ExecuteNonQuery();


        }













        //                                   Methodes Gestion des Clients                                //

        public static void Client_creation(MySqlConnection connection, string typeClient, string nom, string ville, string rue, string codeP, string province, string numTel, string courriel,DateTime adhesion,DateTime expiration,int numFidelio = 0, string prenom = "", string contact = "", int remise = 0)  // insere un nouveau Client 
        {

            if (typeClient == "Particulier")
            {

                string insert = "INSERT INTO Particulier Values(@nomP,@prenom,@ville,@rue,@codeP,@province,@numTel,@courriel,@numFidelio,@adhesion,@expiration)";

                MySqlCommand requete_insert_particulier = connection.CreateCommand();
                requete_insert_particulier.CommandText = insert;

                // Créer des parametres pour la commande sql, parametres qui feront office d'attributs dans la requete 

                requete_insert_particulier.Parameters.AddWithValue("@nomP", nom);
                requete_insert_particulier.Parameters.AddWithValue("@prenom", prenom);
                requete_insert_particulier.Parameters.AddWithValue("@ville", ville);
                requete_insert_particulier.Parameters.AddWithValue("@rue", rue);
                requete_insert_particulier.Parameters.AddWithValue("@codeP", codeP);
                requete_insert_particulier.Parameters.AddWithValue("@province", province);
                requete_insert_particulier.Parameters.AddWithValue("@numTel", numTel);
                requete_insert_particulier.Parameters.AddWithValue("@courriel", courriel);
                requete_insert_particulier.Parameters.AddWithValue("@numFidelio", numFidelio);
                requete_insert_particulier.Parameters.AddWithValue("@adhesion",adhesion);
                requete_insert_particulier.Parameters.AddWithValue("@expiration", expiration);

                requete_insert_particulier.ExecuteNonQuery();
            }
            else
            {
                string insert = "INSERT INTO Boutique Values(@nomP,@prenom,@ville,@rue,@codeP,@province,@numTel,@courriel,@nomContact,@remise)";

                MySqlCommand requete_insert_boutique = connection.CreateCommand();
                requete_insert_boutique.CommandText = insert;

                // Créer des parametres pour la commande sql, parametres qui feront office d'attributs dans la requete 

                requete_insert_boutique.Parameters.AddWithValue("@nomP", nom);
                requete_insert_boutique.Parameters.AddWithValue("@prenom", prenom);
                requete_insert_boutique.Parameters.AddWithValue("@ville", ville);
                requete_insert_boutique.Parameters.AddWithValue("@rue", rue);
                requete_insert_boutique.Parameters.AddWithValue("@codeP", codeP);
                requete_insert_boutique.Parameters.AddWithValue("@province", province);
                requete_insert_boutique.Parameters.AddWithValue("@numTel", numTel);
                requete_insert_boutique.Parameters.AddWithValue("@courriel", courriel);
                requete_insert_boutique.Parameters.AddWithValue("@nomContact", contact);
                requete_insert_boutique.Parameters.AddWithValue("@remise", remise);


                requete_insert_boutique.ExecuteNonQuery();


            }


        }
        public static void Client_Suppression(MySqlConnection connection, string typeClient, string nom, string prenom) // delete un fournisseur
        {

            if (typeClient == "Particulier")
            {
                string delete = "Delete from Particulier where nomP = @nomP and prenom = @prenom";

                // Créez l'objet Command. qui envoie une requete
                MySqlCommand requete_del_particulier = connection.CreateCommand();
                requete_del_particulier.CommandText = delete;


                // Parametres de la commande 

                requete_del_particulier.Parameters.AddWithValue("@nomP", nom);
                requete_del_particulier.Parameters.AddWithValue("@prenom", prenom);

                // Exécutez Command (Utilisez pour supprimer, insérer, mettre à jour) 
                requete_del_particulier.ExecuteNonQuery();
            }
            else
            {
                string delete = "Delete from Boutique where nomB = @nomB";

                // Créez l'objet Command. qui envoie une requete
                MySqlCommand requete_del_boutique = connection.CreateCommand();
                requete_del_boutique.CommandText = delete;


                // Parametres de la commande 

                requete_del_boutique.Parameters.AddWithValue("@nomB", nom);


                // Exécutez Command (Utilisez pour supprimer, insérer, mettre à jour) 
                requete_del_boutique.ExecuteNonQuery();
            }


        }
        public static void Client_update(MySqlConnection connection, string typeClient, string nom, string prenomP, string nomParametre, string parametreValue)  // insere un nouveau Client 
        {

            if (typeClient == "Particulier")
            {

                string insert = "UPDATE Particulier SET " + nomParametre + " = @parametreValue WHERE nomP = @nomP and prenom = @prenomP";

                MySqlCommand requete_insert_particulier = connection.CreateCommand();
                requete_insert_particulier.CommandText = insert;

                // Créer des parametres pour la commande sql, parametres qui feront office d'attributs dans la requete 

                requete_insert_particulier.Parameters.AddWithValue("@nomP", nom);
                requete_insert_particulier.Parameters.AddWithValue("@prenomP", prenomP);

                if (nomParametre == "numF")
                {
                    int parValue = Convert.ToInt32(parametreValue);
                    requete_insert_particulier.Parameters.AddWithValue("@parametreValue", parValue);
                }
                else
                {
                    requete_insert_particulier.Parameters.AddWithValue("@parametreValue", parametreValue);

                }

                requete_insert_particulier.ExecuteNonQuery();
            }
            else
            {
                string update = "UPDATE Boutique SET" + nomParametre + "= @parametreValue WHERE nomB = @nomB";

                MySqlCommand requete_insert_boutique = connection.CreateCommand();
                requete_insert_boutique.CommandText = update;

                // Créer des parametres pour la commande sql, parametres qui feront office d'attributs dans la requete 

                requete_insert_boutique.Parameters.AddWithValue("@nomP", nom);
                if (nomParametre == "remise")
                {
                    int parValue = Convert.ToInt32(parametreValue);
                    requete_insert_boutique.Parameters.AddWithValue("@parametreValue", parValue);
                }
                else
                {
                    requete_insert_boutique.Parameters.AddWithValue("@parametreValue", parametreValue);

                }

                requete_insert_boutique.ExecuteNonQuery();


            }

        }










        //                                   Methodes Gestion des Vélos                                //

        public static void Velo_creation(MySqlConnection connection, string nomV, string grandeur, int prix, string ligne_produit, DateTime date_debut, DateTime date_fin)
        {


            string insert = "INSERT INTO Velo Values(null,@nomV,@grandeur,@prix,@ligne_produit,@date_debut,@date_fin)";

            MySqlCommand requete_insert_velo = connection.CreateCommand();
            requete_insert_velo.CommandText = insert;

            // Créer des parametres pour la commande sql, parametres qui feront office d'attributs dans la requete 

            requete_insert_velo.Parameters.AddWithValue("@nomV", nomV);
            requete_insert_velo.Parameters.AddWithValue("@grandeur", grandeur);
            requete_insert_velo.Parameters.AddWithValue("@prix", prix);
            requete_insert_velo.Parameters.AddWithValue("@ligne_produit", ligne_produit);
            requete_insert_velo.Parameters.AddWithValue("@date_debut", date_debut);
            requete_insert_velo.Parameters.AddWithValue("@date_fin", date_fin);


            requete_insert_velo.ExecuteNonQuery();


        }
        public static void Velo_Suppression(MySqlConnection connection, int numV) // delete un fournisseur
        {

            string delete = "Delete from Velo where numV = @numV";

            // Créez l'objet Command. qui envoie une requete
            MySqlCommand requete_del_velo = connection.CreateCommand();
            requete_del_velo.CommandText = delete;


            // Parametres de la commande 

            requete_del_velo.Parameters.AddWithValue("@numV", numV);


            // Exécutez Command (Utilisez pour supprimer, insérer, mettre à jour) 
            requete_del_velo.ExecuteNonQuery();


        }
        public static void Velo_update(MySqlConnection connection, int numV, string nomParametre, string parametreValue)  // insere un nouveau Client 
        {


            string update = "UPDATE Velo SET " + nomParametre + " = @parametreValue WHERE numV = @numV ";

            MySqlCommand requete_insert_particulier = connection.CreateCommand();
            requete_insert_particulier.CommandText = update;

            // Créer des parametres pour la commande sql, parametres qui feront office d'attributs dans la requete 

            requete_insert_particulier.Parameters.AddWithValue("@numV", numV);

            if (nomParametre == "date_debut" || nomParametre == "date_fin")
            {
                DateTime parValue = DateTime.Parse(parametreValue);
                requete_insert_particulier.Parameters.AddWithValue("@parametreValue", parValue);
            }
            else if (nomParametre == "prix")
            {
                int parValue = Convert.ToInt32(parametreValue);
                requete_insert_particulier.Parameters.AddWithValue("@parametreValue", parValue);

            }
            else
            {
                requete_insert_particulier.Parameters.AddWithValue("@parametreValue", parametreValue);

            }

            requete_insert_particulier.ExecuteNonQuery();


        }

















        //                                   Methodes Gestion des Pièces       AJOUTER NOMF                         //
        public static void Piece_creation(MySqlConnection connection, string numP, string description_, DateTime date_debut, DateTime date_fin, int quantite)
        {
            int prix = 0;

            string insert = "INSERT INTO piece Values(@numP,@description_,@date_debut,@date_fin,@prix,@quantite)";

            MySqlCommand requete_insert_velo = connection.CreateCommand();
            requete_insert_velo.CommandText = insert;

            // Créer des parametres pour la commande sql, parametres qui feront office d'attributs dans la requete 

            requete_insert_velo.Parameters.AddWithValue("@numP", numP);
            requete_insert_velo.Parameters.AddWithValue("@description_", description_);
            requete_insert_velo.Parameters.AddWithValue("@date_debut", date_debut);
            requete_insert_velo.Parameters.AddWithValue("@date_fin", date_fin);
            requete_insert_velo.Parameters.AddWithValue("@quantite", quantite);
            
            switch (description_)
            {

                case "Cadre" :
                    prix = 20;
                    break;
                case "Guidon":
                    prix = 25;
                    break;
                case "Freins":
                    prix = 30;
                    break;
                case "Selle":
                    prix = 15;
                    break;
                case "Derailleur Avant":
                    prix = 40;
                    break;
                case "Derailleur Arrière":
                    prix = 40;
                    break;
                case "Roue avant":
                    prix = 60;
                    break;
                case "Roue arrière":
                    prix = 55;
                    break;
                case "Réflecteur":
                    prix = 25;
                    break;
                case "Pédalier":
                    prix = 20;
                    break;
                case "Ordinateur":
                    prix = 1000;
                    break;
                case "Panier":
                    prix = 10;
                    break;

            }
          
            requete_insert_velo.Parameters.AddWithValue("@prix", prix);


            requete_insert_velo.ExecuteNonQuery();

       

        }
        public static void Piece_Suppression(MySqlConnection connection, string numP) // delete un fournisseur
        {

            string delete = "Delete from piece where numP = @numP";

            // Créez l'objet Command. qui envoie une requete
            MySqlCommand requete_del_piece = connection.CreateCommand();
            requete_del_piece.CommandText = delete;


            // Parametres de la commande 

            requete_del_piece.Parameters.AddWithValue("@numP", numP);


            // Exécutez Command (Utilisez pour supprimer, insérer, mettre à jour) 
            requete_del_piece.ExecuteNonQuery();


        }
        public static void Piece_update(MySqlConnection connection, string numP, string nomParametre, string parametreValue)  // insere un nouveau Client 
        {


            string update = "UPDATE piece SET " + nomParametre + " = @parametreValue WHERE numP = @numP ";
            string qte_par = "SELECT qté_pièce FROM Piece WHERE numP = @numP";

            MySqlCommand requete_update_piece = connection.CreateCommand();
            requete_update_piece.CommandText = update;
            requete_update_piece.Parameters.AddWithValue("@numP", numP);

            MySqlCommand requete_qte = connection.CreateCommand();
            requete_qte.CommandText = qte_par;
            requete_qte.Parameters.AddWithValue("@numP", numP);

            MySqlDataReader exeRequete = requete_qte.ExecuteReader();

            // Créer des parametres pour la commande sql, parametres qui feront office d'attributs dans la requete 



            if (nomParametre == "date_debut" || nomParametre == "date_fin")
            {
                DateTime parValue = DateTime.Parse(parametreValue);
                requete_update_piece.Parameters.AddWithValue("@parametreValue", parValue);
            }
            else if (nomParametre == "qté_pièce")
            {
                while (exeRequete.Read())
                {
                    int parValue = Convert.ToInt32(parametreValue) + Convert.ToInt32(exeRequete.GetValue(0).ToString());
                    requete_update_piece.Parameters.AddWithValue("@parametreValue", parValue);
                }

            }

            else
            {
                requete_update_piece.Parameters.AddWithValue("@parametreValue", parametreValue);

            }

            exeRequete.Close();
            requete_update_piece.ExecuteNonQuery();

        }


















        //                                   Methodes Gestion des Pièces       AJOUTER NOMF                         //
        public static string Commande_creation(MySqlConnection connection, AjoutCommande c, List<int> Modèles_Vélos, List<string> Pièces, List<int> Quantite_Velos, List<int> Quantite_Pieces, DateTime date_commande, string adresse_livraison, string typeclient, string nomclient, string prenomP = "")
        {

            string numC = "";
            int cpt = 0; // compteur 
            bool existe = true;


            if (typeclient == "Particulier")
            {

                int delai_livraison = 10;


                try
                {
           
                    string insert_commande = "INSERT INTO Commande Values(null,@date_commande,@adresse_livraison, @date_livraison,null,@nomClient,@prenomClient)";
                    string particulier_province = "SELECT province FROM Particulier WHERE nomP = @numP and prenom = @prenomP";





                    MySqlCommand requete_part_province = connection.CreateCommand();
         
                    requete_part_province.CommandText = particulier_province;
               

                    requete_part_province.Parameters.AddWithValue("@numP", nomclient);
                    requete_part_province.Parameters.AddWithValue("@prenomP", prenomP);

                    string province_part = "";
                    bool existe2 = false;
                    DataSet client = new DataSet();
                    client = Affichage_table(connection, "Particulier");

                    foreach(DataRow dr in client.Tables[0].Rows)
                    {
                        if(dr[0].ToString() == nomclient && dr[1].ToString() == prenomP)
                        {
                            existe2 = true;
                        }

                    }

                    if (existe2)
                    {
                        MySqlDataReader exeRequete = requete_part_province.ExecuteReader();
            

                        exeRequete.Read();

                        province_part += exeRequete.GetValue(0).ToString();

                        exeRequete.Close();
                    }
                    else
                    {
                        MessageBox.Show("Votre nom et votre prenom n'apparaissent pas dans notre base de données");
                    }

               

                    if (province_part == "Ile de France" && (Quantite_Pieces.Count + Quantite_Velos.Count) <= 10)
                    {
                        delai_livraison = 7;// 7 jours 
                        DateTime date_livraison = date_commande.AddDays(delai_livraison);

                        MySqlCommand requete_insert_commande = connection.CreateCommand();
                        requete_insert_commande.CommandText = insert_commande;
                        requete_insert_commande.Parameters.AddWithValue("@date_commande", date_commande);
                        requete_insert_commande.Parameters.AddWithValue("@date_livraison", date_livraison);
                        requete_insert_commande.Parameters.AddWithValue("@nomclient", nomclient);
                        requete_insert_commande.Parameters.AddWithValue("@prenomClient", prenomP);
                        requete_insert_commande.Parameters.AddWithValue("@adresse_livraison", adresse_livraison);


                      
                        requete_insert_commande.ExecuteNonQuery();

               

                    }
                    else if (province_part == "Ile de France" && (Quantite_Pieces.Count + Quantite_Velos.Count) >= 10)
                    {
                        delai_livraison = 10;// 10 jours 
                        DateTime date_livraison = date_commande.AddDays(delai_livraison);

                        MySqlCommand requete_insert_commande = connection.CreateCommand();
                        requete_insert_commande.CommandText = insert_commande;
                        requete_insert_commande.Parameters.AddWithValue("@date_commande", date_commande);
                        requete_insert_commande.Parameters.AddWithValue("@date_livraison", date_livraison);
                        requete_insert_commande.Parameters.AddWithValue("@nomclient", nomclient);
                        requete_insert_commande.Parameters.AddWithValue("@prenomP", prenomP);


                        
                        requete_insert_commande.ExecuteNonQuery();
                     

                    }
                    else if (province_part != "Ile de France")
                    {
                        delai_livraison = 20;// 20 jours 
                        DateTime date_livraison = date_commande.AddDays(delai_livraison);

                        MySqlCommand requete_insert_commande = connection.CreateCommand();
                        requete_insert_commande.CommandText = insert_commande;
                        requete_insert_commande.Parameters.AddWithValue("@date_commande", date_commande);
                        requete_insert_commande.Parameters.AddWithValue("@date_livraison", date_livraison);
                        requete_insert_commande.Parameters.AddWithValue("@nomclient", nomclient);
                        requete_insert_commande.Parameters.AddWithValue("@prenomP", prenomP);


                      
                        requete_insert_commande.ExecuteNonQuery();
                     

                    }
          





                }
                catch (Exception ex)
                {
                    MessageBox.Show( "\n" + "Vous devez ajouter votre compte client" + "\n" + ex.Message);
                    AjoutClient aJ = new AjoutClient(connection);
                    existe = false;
                    aJ.Show();
                    c.Hide();


                }





                if (existe)
                {
                    string count_commandes = Count(connection, "Commande").ToString();

                    MessageBox.Show(count_commandes);

                    string last_command = "SELECT numC FROM Commande LIMIT " + count_commandes;
                    MySqlCommand requete_numC = connection.CreateCommand();
                    requete_numC.CommandText = last_command;
                    MySqlDataReader numC_read = requete_numC.ExecuteReader();

                    string numC_ = "";
                    int cpt2 = 0;


                    while (numC_read.Read())
                    {
                        cpt2++;
                        if (cpt2 == Convert.ToInt32(count_commandes))
                        {
                            numC_ = numC_read.GetValue(0).ToString();
                        }

                    }




                    numC = numC_; // numero de la commande qui vient d'être enregistré

                    MessageBox.Show(numC);

                    if (Modèles_Vélos != null)
                    {
                        foreach (int numvélo in Modèles_Vélos)
                        {

                            string insert_velo = "INSERT INTO Contient_Velo Values(@numC,@numV,@quantiteV)";

                            MySqlCommand requete_velo = connection.CreateCommand();
                            requete_velo.CommandText = insert_velo;

                            requete_velo.Parameters.AddWithValue("@numV", numvélo);
                            requete_velo.Parameters.AddWithValue("@numC", numC_);
                            requete_velo.Parameters.AddWithValue("@quantiteV", Quantite_Velos[cpt]);

                            numC_read.Close();
                            requete_velo.ExecuteNonQuery();

                            cpt++;

                        }
                    }
                    cpt = 0;
                    if (Pièces != null)
                    {
                        foreach (string numpiece in Pièces)
                        {

                            string insert_piece = "INSERT INTO Contient_Piece Values(@numC,@numP,@quantiteP)";

                            MySqlCommand requete_piece = connection.CreateCommand();
                            requete_piece.CommandText = insert_piece;

                            requete_piece.Parameters.AddWithValue("@numP", numpiece);
                            requete_piece.Parameters.AddWithValue("@numC", numC_);
                            requete_piece.Parameters.AddWithValue("@quantiteP", Quantite_Pieces[cpt]);

                            numC_read.Close();

                            requete_piece.ExecuteNonQuery();

                            cpt++;


                        }
                    }



                }
            }
            else // Boutique 
            {

                int delai_livraison = 10;


                try
                {
                    string insert_commande = "INSERT INTO Commande Values(null,@date_commande,@date_livraison,@nomClient,null,@prenomClient)";
                    string boutique_province = "SELECT province FROM Boutique WHERE nomB = @numB";





                    MySqlCommand requete_B_province = connection.CreateCommand();

                    requete_B_province.CommandText = boutique_province;


                    requete_B_province.Parameters.AddWithValue("@numB", nomclient);


                    string province_B = "";
                    bool existe2 = false;
                    DataSet client = new DataSet();
                    client = Affichage_table(connection, "Boutique");

                    foreach (DataRow dr in client.Tables[0].Rows)
                    {
                        if (dr[0].ToString() == nomclient && dr[1].ToString() == prenomP)
                        {
                            existe2 = true;
                        }

                    }

                    if (existe2)
                    {
                        MySqlDataReader exeRequete = requete_B_province.ExecuteReader();


                        exeRequete.Read();

                        province_B += exeRequete.GetValue(0).ToString();

                        exeRequete.Close();
                    }
                    else
                    {
                        MessageBox.Show("Votre nom en'apparaît pas dans notre base de données");
                    }



                    if (province_B== "Ile de France" && (Quantite_Pieces.Count + Quantite_Velos.Count) <= 10)
                    {
                        delai_livraison = 7;// 7 jours 
                        DateTime date_livraison = date_commande.AddDays(delai_livraison);

                        MySqlCommand requete_insert_commande = connection.CreateCommand();
                        requete_insert_commande.CommandText = insert_commande;
                        requete_insert_commande.Parameters.AddWithValue("@date_commande", date_commande);
                        requete_insert_commande.Parameters.AddWithValue("@date_livraison", date_livraison);
                        requete_insert_commande.Parameters.AddWithValue("@nomclient", nomclient);
                        requete_insert_commande.Parameters.AddWithValue("@prenomClient", prenomP);
                        requete_insert_commande.Parameters.AddWithValue("@adresse_livraison", adresse_livraison);



                        requete_insert_commande.ExecuteNonQuery();



                    }
                    else if (province_B == "Ile de France" && (Quantite_Pieces.Count + Quantite_Velos.Count) >= 10)
                    {
                        delai_livraison = 10;// 10 jours 
                        DateTime date_livraison = date_commande.AddDays(delai_livraison);

                        MySqlCommand requete_insert_commande = connection.CreateCommand();
                        requete_insert_commande.CommandText = insert_commande;
                        requete_insert_commande.Parameters.AddWithValue("@date_commande", date_commande);
                        requete_insert_commande.Parameters.AddWithValue("@date_livraison", date_livraison);
                        requete_insert_commande.Parameters.AddWithValue("@nomclient", nomclient);
                        requete_insert_commande.Parameters.AddWithValue("@prenomP", prenomP);



                        requete_insert_commande.ExecuteNonQuery();


                    }
                    else if (province_B != "Ile de France")
                    {
                        delai_livraison = 20;// 20 jours 
                        DateTime date_livraison = date_commande.AddDays(delai_livraison);

                        MySqlCommand requete_insert_commande = connection.CreateCommand();
                        requete_insert_commande.CommandText = insert_commande;
                        requete_insert_commande.Parameters.AddWithValue("@date_commande", date_commande);
                        requete_insert_commande.Parameters.AddWithValue("@date_livraison", date_livraison);
                        requete_insert_commande.Parameters.AddWithValue("@nomclient", nomclient);
                        requete_insert_commande.Parameters.AddWithValue("@prenomP", prenomP);



                        requete_insert_commande.ExecuteNonQuery();


                    }






                }
                catch (Exception ex)
                {
                    MessageBox.Show("\n" + "Vous devez ajouter votre compte client" + "\n" + ex.Message);
                    AjoutClient aJ = new AjoutClient(connection);
                    existe = false;
                    aJ.Show();
                    c.Hide();


                }





                if (existe)
                {
                    string count_commandes = Count(connection, "Commande").ToString();

                    MessageBox.Show(count_commandes);

                    string last_command = "SELECT numC FROM Commande LIMIT " + count_commandes;
                    MySqlCommand requete_numC = connection.CreateCommand();
                    requete_numC.CommandText = last_command;
                    MySqlDataReader numC_read = requete_numC.ExecuteReader();

                    string numC_ = "";
                    int cpt2 = 0;


                    while (numC_read.Read())
                    {
                        cpt2++;
                        if (cpt2 == Convert.ToInt32(count_commandes))
                        {
                            numC_ = numC_read.GetValue(0).ToString();
                        }

                    }




                    numC = numC_; // numero de la commande qui vient d'être enregistré

                    MessageBox.Show(numC);

                    if (Modèles_Vélos != null)
                    {
                        foreach (int numvélo in Modèles_Vélos)
                        {

                            string insert_velo = "INSERT INTO Contient_Velo Values(@numC,@numV,@quantiteV)";

                            MySqlCommand requete_velo = connection.CreateCommand();
                            requete_velo.CommandText = insert_velo;

                            requete_velo.Parameters.AddWithValue("@numV", numvélo);
                            requete_velo.Parameters.AddWithValue("@numC", numC_);
                            requete_velo.Parameters.AddWithValue("@quantiteV", Quantite_Velos[cpt]);

                            numC_read.Close();
                            requete_velo.ExecuteNonQuery();

                            cpt++;

                        }
                    }
                    cpt = 0;
                    if (Pièces != null)
                    {
                        foreach (string numpiece in Pièces)
                        {

                            string insert_piece = "INSERT INTO Contient_Piece Values(@numC,@numP,@quantiteP)";

                            MySqlCommand requete_piece = connection.CreateCommand();
                            requete_piece.CommandText = insert_piece;

                            requete_piece.Parameters.AddWithValue("@numP", numpiece);
                            requete_piece.Parameters.AddWithValue("@numC", numC_);
                            requete_piece.Parameters.AddWithValue("@quantiteP", Quantite_Pieces[cpt]);

                            numC_read.Close();

                            requete_piece.ExecuteNonQuery();

                            cpt++;


                        }
                    }

                }

                }
                return numC;

        }
        public static void Commande_Supression(MySqlConnection connection, string numC) // delete un fournisseur
        {

            string delete = "Delete from commande where numC = @numC";

            // Créez l'objet Command. qui envoie une requete
            MySqlCommand requete_del_commande = connection.CreateCommand();
            requete_del_commande.CommandText = delete;


            // Parametres de la commande 

            requete_del_commande.Parameters.AddWithValue("@numC", numC);


            // Exécutez Command (Utilisez pour supprimer, insérer, mettre à jour) 
            requete_del_commande.ExecuteNonQuery();


        }
        public static void Commande_update(MySqlConnection connection, string numC, string nomParametre, string parametreValue)  // insere un nouveau Client 
        {


            string update = "UPDATE piece SET " + nomParametre + " = @parametreValue WHERE numP = @numP ";
            string qte_par = "SELECT qté_pièce FROM Piece WHERE numP = @numP";

            MySqlCommand requete_update_piece = connection.CreateCommand();
            requete_update_piece.CommandText = update;
            requete_update_piece.Parameters.AddWithValue("@numP", numC);

            MySqlCommand requete_qte = connection.CreateCommand();
            requete_qte.CommandText = qte_par;
            requete_qte.Parameters.AddWithValue("@numP", numC);

            MySqlDataReader exeRequete = requete_qte.ExecuteReader();

            // Créer des parametres pour la commande sql, parametres qui feront office d'attributs dans la requete 



            if (nomParametre == "date_debut" || nomParametre == "date_fin")
            {
                DateTime parValue = DateTime.Parse(parametreValue);
                requete_update_piece.Parameters.AddWithValue("@parametreValue", parValue);
            }
            else if (nomParametre == "qté_pièce")
            {
                while (exeRequete.Read())
                {
                    int parValue = Convert.ToInt32(parametreValue) + Convert.ToInt32(exeRequete.GetValue(0).ToString());
                    requete_update_piece.Parameters.AddWithValue("@parametreValue", parValue);
                }

            }

            else
            {
                requete_update_piece.Parameters.AddWithValue("@parametreValue", parametreValue);

            }

            exeRequete.Close();
            requete_update_piece.ExecuteNonQuery();

        }






















        //                                   Methodes des Actions Internes                                //
        public static void Stockage(MySqlConnection connection,string typestock, DataSet dataSet)
        {

            if (typestock == "velo")
            {
                string stock_Vélo = "SELECT nomV, COUNT(*) FROM Velo GROUP BY nomV";
                //string stock_pièces = "SELECT numI FROM "

                MySqlCommand requete_insert_velo = connection.CreateCommand();
                requete_insert_velo.CommandText = stock_Vélo;
                //requete_insert_velo.CommandText = insert;

                // Créer des parametres pour la commande sql, parametres qui feront office d'attributs dans la requete 

                requete_insert_velo.ExecuteNonQuery();


                MySqlDataAdapter datadapt = new MySqlDataAdapter(requete_insert_velo);
                datadapt.Fill(dataSet);
            }
            else if (typestock == "piece")
            {
               
                    string stock_Piece = "SELECT description_,SUM(qté_pièce) " +
                                         "FROM Piece " +
                                         " GROUP BY description_";
                    //string stock_pièces = "SELECT numI FROM "

                    MySqlCommand requete_stock_piece = connection.CreateCommand();
                    requete_stock_piece.CommandText = stock_Piece;
                    //requete_insert_velo.CommandText = insert;

                    // Créer des parametres pour la commande sql, parametres qui feront office d'attributs dans la requete 

                    requete_stock_piece.ExecuteNonQuery();


                    MySqlDataAdapter datadapt = new MySqlDataAdapter(requete_stock_piece);
                    datadapt.Fill(dataSet);
            
            }
            else if( typestock == "fournisseur")
            {
                string stock_Piece = "SELECT A.numP,F.nomF,A.delai_fournisseur, A.quantite " +
                                     "FROM Approvisionne A NATURAL JOIN Fournisseur F " +
                                     " GROUP BY A.numP";
                //string stock_pièces = "SELECT numI FROM "

                MySqlCommand requete_stock_piece = connection.CreateCommand();
                requete_stock_piece.CommandText = stock_Piece;
                //requete_insert_velo.CommandText = insert;

                // Créer des parametres pour la commande sql, parametres qui feront office d'attributs dans la requete 

                requete_stock_piece.ExecuteNonQuery();


                MySqlDataAdapter datadapt = new MySqlDataAdapter(requete_stock_piece);
                datadapt.Fill(dataSet);


            }


        }
        public static void Approvisionner(MySqlConnection connection, string numP, string numF, int quantite, int delai ,int prixP = 0 , string numPF = "") // delete un fournisseur
        {

            string insert = "INSERT INTO Approvisionne Values(@numF,@numP,@delai,@prixP,@quantite,@numPF)";

            // Créez l'objet Command. qui envoie une requete
            MySqlCommand requete_approv = connection.CreateCommand();
            requete_approv.CommandText = insert;


            // Parametres de la commande 

            requete_approv.Parameters.AddWithValue("@numP", numP);
            requete_approv.Parameters.AddWithValue("@numF", numF);
            requete_approv.Parameters.AddWithValue("@delai", delai);
            requete_approv.Parameters.AddWithValue("@prixP", prixP);
            requete_approv.Parameters.AddWithValue("@quantite", quantite);
            requete_approv.Parameters.AddWithValue("@numPF", numPF);


            // Exécutez Command (Utilisez pour supprimer, insérer, mettre à jour) 
            requete_approv.ExecuteNonQuery();


        }

        public static DataSet HistoriqueApprovisionnement(MySqlConnection conn)
        {
            string hist = "SELECT A.numP,P.description_,F.nomF, A.quantite" +
                        " FROM Piece P, Approvisionne A, Fournisseur F" +
                        " WHERE A.numP = P.numP and A.numF = F.Siret";
            MySqlCommand requete_historique = conn.CreateCommand();
            requete_historique.CommandText = hist;  
       

            DataSet data = new DataSet();
            MySqlDataAdapter datadapt = new MySqlDataAdapter(requete_historique);
            datadapt.Fill(data);


            return data;
        }
        /*public static void Assemblage(MySqlConnection connection, string numP, string nomParametre, string parametreValue)  // insere un nouveau Client 
        {


            string update = "UPDATE piece SET " + nomParametre + " = @parametreValue WHERE numP = @numP ";

            MySqlCommand requete_update_piece = connection.CreateCommand();
            requete_update_piece.CommandText = update;

            // Créer des parametres pour la commande sql, parametres qui feront office d'attributs dans la requete 

            requete_update_piece.Parameters.AddWithValue("@numP", numP);

            if (nomParametre == "date_debut" || nomParametre == "date_fin")
            {
                DateTime parValue = DateTime.Parse(parametreValue);
                requete_update_piece.Parameters.AddWithValue("@parametreValue", parValue);
            }
            else
            {
                requete_update_piece.Parameters.AddWithValue("@parametreValue", parametreValue);

            }

            requete_update_piece.ExecuteNonQuery();

        }*/

















    }
}
