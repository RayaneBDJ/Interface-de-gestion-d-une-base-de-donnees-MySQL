DROP DATABASE IF EXISTS VéloMax;
CREATE DATABASE IF NOT EXISTS VéloMax;
use VéloMax;

set sql_safe_updates=0;

drop table IF EXISTS Velo;

 SELECT P.description_,F.nomF, SUM(qté_pièce) 
 FROM Piece P, Approvisionne A, Fournisseur F 
wHERE P.numP = A.numP and A.numF = F.SIret
GROUP BY P.description_;

##### VENTES #####

Create table if not exists Velo # un velo doit etre structuré par au moins une piece 
(	numV INTEGER NOT NULL AUTO_INCREMENT,
	Constraint numV_PK PRIMARY KEY(numV),
	nomV VARCHAR(40),
    grandeur ENUM("Adultes","Jeunes","Hommes","Dames","Filles","Garçons"),
    prix INTEGER,
    ligne_Produit ENUM("VTT","Vélo de Course","Classique","BMX"),
    date_debut datetime, # date d'introduction du modèle 
    date_fin datetime ); # date de discontinuation de la
    
desc Velo;


ALTER TABLE Velo Change numV numV INTEGER  AUTO_INCREMENT;

drop table if exists piece;
Create table if not exists piece # une piece peut faire partie de la structure de 0 à N vélo
(	numP VarChar(40)NOT NULL,
    description_ VARCHAR(40),
    #nomF VARCHAR(40),
    #Constraint nomF_piece_FK Foreign key(nomF) references Fournisseur(nomF) ON DELETE NO ACTION ON UPDATE NO ACTION, # si on efface le fournisseur, la piece existe toujours
    date_debut datetime, # date d'introduction a cette piece
    date_fin datetime,# discontinuation 
    prix_unité INTEGER,
    qté_pièce INTEGER,
    Constraint piece_PK PRIMARY KEY(numP)); 
    
ALTER TABLE Piece ADD prix_unité INTEGER;
ALTER TABLE piece ADD qté_pièce INTEGER;
desc piece;
    
drop table if exists Structure;
Create table if not exists Structure # fais l'association entre les tables Modele_Velo et Piece
( 	numV INTEGER,
	Constraint numV_FK_structure Foreign key(numV) references Velo(numV) ON DELETE CASCADE ON UPDATE NO ACTION,
    numP VARCHAR(40),
    CONSTRAINT numP_FK_structure FOREIGN KEY(numP) references Piece(numP) ON DELETE CASCADE ON UPDATE NO ACTION,
    qte_piece INTEGER,
    CONSTRAINT qte_piece_PK PRIMARY KEY(numV,numP));


# Pour avoir l'assemblage on fait un select group by 


drop table if exists Commande;
Create table if not exists Commande 
(	numC INTEGER NOT NULL AUTO_INCREMENT,
	date_commande datetime,
    adresse_livraison VARCHAR(40),
    date_livraison datetime,
    nomB VARCHAR(40),
    nomP VARCHAR(40),
    prenomP VARCHAR(40),
    CONSTRAINT nomP_FK_commande FOREIGN KEY(nomP,prenomP) references Particulier(nomP,prenom) ON DELETE NO ACTION ON UPDATE NO ACTION ,
    CONSTRAINT nomB_FK_commande FOREIGN KEY(nomB) references Boutique(nomB) ON DELETE NO ACTION ON UPDATE NO ACTION,
	CONSTRAINT numC_PK_commande PRIMARY KEY(numC));
    
    
    
ALTER TABLE Commande Change numC numC INTEGER NOT NULL AUTO_INCREMENT;
desc Commande;
    
drop table if exists Contient_Velo;
Create table if not exists Contient_Velo
(	numC INTEGER,
	CONSTRAINT numC_FK_contientP FOREIGN KEY(numC) references Commande(numC) ON DELETE CASCADE ON UPDATE NO ACTION,
    numV INTEGER,
	CONSTRAINT numV_FK_contientP FOREIGN KEY(numV) references Velo(numV) ON DELETE CASCADE ON UPDATE NO ACTION,
    qteV_commande INTEGER);

drop table if exists Contient_Piece;
Create table if not exists Contient_Piece
(	numC INTEGER,
	CONSTRAINT numC_FK_contientV FOREIGN KEY(numC) references Commande(numC) ON DELETE CASCADE ON UPDATE NO ACTION,
    numP_rechange Varchar(40),
	CONSTRAINT numP_FK_contientV FOREIGN KEY(numP_rechange) references Piece(numP) ON DELETE CASCADE ON UPDATE NO ACTION,
    qteP_commande INTEGER);
    

desc Contient_Piece;

SELECT * FROM Commande;
Select * from particulier;


###### Clients #####

drop table Particulier;
create table if not exists Particulier 
( nomP VARCHAR(40) NOT NULL,
  prenom VARCHAR(40) NOT NULL,
  ville VARCHAR(40),
  rue VARCHAR(40),
  codeP CHAR(5),
  province VARCHAR(40),
  numTel CHAR(10),
  courriel VARCHAR(40),
  numF INTEGER,
  date_adhésion_F Datetime,
  date_expiration_F DateTime,
  CONSTRAINT numF_FK FOREIGN KEY(numF) references Fidelio(numF) ON DELETE CASCADE ON UPDATE NO ACTION,
  PRIMARY KEY(nomP,prenom));
  
  
ALTER TABLE Particulier ADD date_adhésion_F Datetime;
ALTER TABLE Particulier ADD date_expiration_F Datetime;


  desc Particulier;
  
  UPDATE Particulier set numF = 2 WHERE nomP = "Lagrange";
  SELECT * FROM particulier;

INSERT INTO Particulier Values("B","Rayane","Paris","4 allee","75100","Charlebourg","062789098","rayane@gmail.com",1);

create table if not exists Fidelio 
(  numF INTEGER CONSTRAINT numF_max CHECK(numF <= 4) default 0,
   typeF VARCHAR(40),
   Cout INTEGER,
   Duree INTEGER CONSTRAINT duree_max CHECK(Duree <= 3),
   rabais INTEGER,
   PRIMARY KEY(numF));
   
   
create table if not exists Boutique
( nomB VARCHAR(40) NOT NULL PRIMARY KEY,
  ville VARCHAR(40),
  rue VARCHAR(40),
  CodeP CHAR(5),
  province VARCHAR(40),
  numTel CHAR(10),
  courriel VARCHAR(40),
  nomContact VARCHAR(40),
  remise INTEGER unique);
  
  
SELECT C.nomP,C.prenomP, SUM(CV.qteV_commande),SUM(CP.qteP_commande)
FROM Commande C, Contient_Velo CV, Contient_Piece CP
WHERE C.numC = CP.numC ;

desc Particulier;
desc commande;






##### FOURNISSEUR #####

drop table if exists Approvisionne;
Create Table if not exists Approvisionne   								# ASSOCIATION #
(	numF Varchar(40) NOT NULL, # numero du produit qu'on lui attribue 
	CONSTRAINT numF_FK_Fournisseur FOREIGN KEY(numF) references Fournisseur(Siret), # plus de fournisseur, plus d'approvisionnement
    numP varchar(40) NOT NULL,
    CONSTRAINT numP_FK_Piece FOREIGN KEY(numP) references Piece(numP) ON DELETE CASCADE ON UPDATE NO ACTION, # si on efface la piece, que se passe t-il ? 
    delai_fournisseur INTEGER, # délai de livraison du fournisseur
    prixP INTEGER,
    quantite INTEGER,
    numPF VARCHAR(40), # numero du produit dans le catalogue du fournisseur
    CONSTRAINT numP_numF_PK_Approvisionne PRIMARY KEY(numPF)); # les  derniers éléments dépendent de la primary key

desc Approvisionne;
SELECT * FROM Approvisionne;
ALTER TABLE Approvisionne ADD quantite INTEGER;
ALTER TABLE Approvisionne CHANGE numPF numPF Varchar(40);
    
drop table if exists fournisseur;
Create Table if not exists Fournisseur
(	Siret VARCHAR(40) NOT NULL unique,
	nomF VARCHAR(40),
    contact VARCHAR(40),
    adresse VARCHAR(40),
    ville VARCHAR(40),
    libelle ENUM('1','2','3','4'),
    CONSTRAINT Fournisseur_PK PRIMARY KEY(Siret) );
    
ALTER TABLE Fournisseur Change nomF nomF VARCHAR(40);
    
desc fournisseur;

ALTER TABLE Fournisseur CHANGE Siret Siret Varchar(40) not null unique;

ALTER TABLE Fournisseur DROP adresse;
ALTER TABLE Fournisseur ADD adresse VARCHAR(40) ;
ALTER TABLE Fournisseur ADD ville VARCHAR(40);

desc Fournisseur;
desc Piece;
SELECT * FROM Fournisseur;






###### 	CLIENT ######
    

Select * From Particulier;
    
    
INSERT INTO fournisseur Values(	"200 021 624 00057",	"Velib"	, "0176491234",	"3 rue","Paris", 3);
    


###### SELECT #######

Select * FROM Velo;
SELECT * FROM Piece;
SELECT * FROM Structure;
SELECT * FROM Commande;
SELECT * FROM Contient_Velo;
SELECT * FROM Contient_Piece;
SELECT * FROM Fournisseur;
SELECT * FROM Approvisionne;
SELECT * FROM Particulier;

INSERT INTO Commande Values(null,0000-00,"4 allee",0000-00,null,"Badji","Rayane");


###### ENREGISTREMENTS ######

INSERT INTO Velo Values(1,"Kassis","Adultes",300,"VTT", 0000-00, 0000-00);
INSERT INTO Velo Values(2,"Kayard","Adultes",320,"BMX", 0000-00, 0000-00);
INSERT INTO Velo Values(3,"Car","Garçons",120,"Classique", 0000-00, 0000-00);

INSERT INTO Piece Values("C32","Cadre",0000-00, 0000-00, 32);
INSERT INTO Piece Values("C34","Grandes roues",0000-00, 0000-00,42);
INSERT INTO Piece Values("R45","Roue avant",0000-00, 0000-00,12);

INSERT INTO Structure Values(1,"C32",2);
INSERT INTO Structure Values(1,"C34",2);
INSERT INTO Structure Values(1,"R45",2);
INSERT INTO Structure Values(3,1,2);
INSERT INTO Structure Values(3,2,30);
INSERT INTO Structure Values(3,4,4);
    
INSERT INTO Fournisseur Values();


INSERT INTO Fidelio Values (1,"Fidélio",15,1,5);
INSERT INTO Fidelio Values (2,"Fidélio Or",25,2,8);
INSERT INTO Fidelio Values (3,"Fidélio Platine",60,2,10);
INSERT INTO Fidelio Values (4,"Fidélio Max",100,3,12);


INSERT INTO Velo Values(101, "Kilimandjaro","Adultes", 569, "VTT",0000-00,0000-00);
INSERT INTO Velo Values(102, "NorthPole", "Adultes", 329 ,"VTT",0000-00,0000-00);
INSERT INTO Velo Values(103," MontBlanc" ,"Jeunes", 399 , "VTT",0000-00,0000-00);
INSERT INTO Velo Values(104 ,"Hooligan" ,"Jeunes", 199 , "VTT",0000-00,0000-00);
INSERT INTO Velo Values(105, "Orléans", "Hommes", 229 , "Vélo de course",0000-00,0000-00);
INSERT INTO Velo Values(106 ,"Orléans", "Dames" ,229 , "Vélo de course",0000-00,0000-00);
INSERT INTO Velo Values(107 ,"BlueJay", "Hommes" ,349 , "Vélo de course",0000-00,0000-00);
INSERT INTO Velo Values(108 ,"BlueJay" ,"Dames", 349, "Vélo de course",0000-00,0000-00);
INSERT INTO Velo Values(109 ,"Trail Explorer" ,"Filles", 129 , "Classique",0000-00,0000-00);
INSERT INTO Velo Values(110 ,"Trail Explorer", "Garçons" ,129 , "Classique",0000-00,0000-00);
INSERT INTO Velo Values(Null,"Ex","Filles",12,"Classique",0000-00,0000-00);



INSERT INTO Commande Values("101",0000-00,"4 allee Botticelli",0000-00,"Lagrange",null);
INSERT INTO Commande Values("101",0000-00,"4 allee Botticelli",0000-00,"Lagrange",null);
INSERT INTO Commande Values("102",0000-00,"4 allee Botticelli",0000-00,null,"Velib");




INSERT INTO Approvisionne (numF,numP,numPF) Values ("200 021 624 00057","G01","P9A");
INSERT INTO Approvisionne (numF,numP,numPF) Values ("200 021 624 00057","G01","G56");



SELECT C.nomP,SUM((V.prix*CV.qteV_commande)) AS Montant
FROM Velo V Natural Join ( Contient_Velo CV Natural Join Commande C)
WHERE C.nomP IN (SELECT nomP FROM Commande NATURAL JOIN Contient_Velo  )
ORDER BY Montant ;

SELECT C.nomP,SUM((P.prix_unité*CP.qteP_commande)) AS Montant
FROM Piece P  Natural Join ( Contient_Piece CP Natural Join Commande C)
WHERE C.nomP IN (SELECT nomP FROM Commande NATURAL JOIN Contient_Velo  )
ORDER BY Montant ;

SELECT *,C.nomP
FROM Contient_Velo NATURAL JOIN Commande C;
    
    
    