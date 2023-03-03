namespace VéloMax_Pb_BDD
{
    partial class AjoutCommande
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutCommande));
            this.Button_Retour = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.Button_ValiderAjoutCommande = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Adresse = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Velos = new System.Windows.Forms.TextBox();
            this.Quantite_P = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Quantite_V = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PrenomParticulier = new System.Windows.Forms.TextBox();
            this.Pieces = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NomClient = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBoxClient = new System.Windows.Forms.ComboBox();
            this.DateCommande = new System.Windows.Forms.TextBox();
            this.NumCommande = new System.Windows.Forms.TextBox();
            this.DateLivraison = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NomV = new System.Windows.Forms.Label();
            this.DataVelos = new System.Windows.Forms.DataGridView();
            this.DataPièce = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataPiècesRecommandées = new System.Windows.Forms.DataGridView();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.DataCommande = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataVelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataPièce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataPiècesRecommandées)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataCommande)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Retour
            // 
            this.Button_Retour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Button_Retour.Location = new System.Drawing.Point(1196, 593);
            this.Button_Retour.Name = "Button_Retour";
            this.Button_Retour.Size = new System.Drawing.Size(75, 23);
            this.Button_Retour.TabIndex = 34;
            this.Button_Retour.Text = "Retour";
            this.Button_Retour.UseVisualStyleBackColor = false;
            this.Button_Retour.Click += new System.EventHandler(this.Button_Retour_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(497, -23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(264, 38);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(179, 25);
            this.label20.TabIndex = 32;
            this.label20.Text = "Ajout/Commande";
            // 
            // Button_ValiderAjoutCommande
            // 
            this.Button_ValiderAjoutCommande.BackColor = System.Drawing.Color.Lime;
            this.Button_ValiderAjoutCommande.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_ValiderAjoutCommande.Location = new System.Drawing.Point(32, 576);
            this.Button_ValiderAjoutCommande.Name = "Button_ValiderAjoutCommande";
            this.Button_ValiderAjoutCommande.Size = new System.Drawing.Size(184, 50);
            this.Button_ValiderAjoutCommande.TabIndex = 31;
            this.Button_ValiderAjoutCommande.Text = "Valider l\'ajout de la commande\r\n\r\n";
            this.Button_ValiderAjoutCommande.UseVisualStyleBackColor = false;
            this.Button_ValiderAjoutCommande.Click += new System.EventHandler(this.Button_ValiderAjoutPièce_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Adresse);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Velos);
            this.groupBox1.Controls.Add(this.Quantite_P);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Quantite_V);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.PrenomParticulier);
            this.groupBox1.Controls.Add(this.Pieces);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.NomClient);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ComboBoxClient);
            this.groupBox1.Controls.Add(this.DateCommande);
            this.groupBox1.Controls.Add(this.NumCommande);
            this.groupBox1.Controls.Add(this.DateLivraison);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.NomV);
            this.groupBox1.Location = new System.Drawing.Point(121, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 415);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caractéristiques à remplir";
            // 
            // Adresse
            // 
            this.Adresse.Location = new System.Drawing.Point(295, 181);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(100, 22);
            this.Adresse.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(39, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 16);
            this.label10.TabIndex = 42;
            this.label10.Text = "adresse_livraison";
            // 
            // Velos
            // 
            this.Velos.Location = new System.Drawing.Point(295, 38);
            this.Velos.Name = "Velos";
            this.Velos.Size = new System.Drawing.Size(100, 22);
            this.Velos.TabIndex = 41;
            this.Velos.Text = "Sép par un \";\"";
            this.Velos.TextChanged += new System.EventHandler(this.Velos_TextChanged);
            // 
            // Quantite_P
            // 
            this.Quantite_P.Location = new System.Drawing.Point(295, 367);
            this.Quantite_P.Name = "Quantite_P";
            this.Quantite_P.Size = new System.Drawing.Size(100, 22);
            this.Quantite_P.TabIndex = 40;
            this.Quantite_P.Text = "Sép par un \";\"";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(27, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 16);
            this.label9.TabIndex = 39;
            this.label9.Text = "Quantite de chaque pièce choisi\r\n";
            // 
            // Quantite_V
            // 
            this.Quantite_V.Location = new System.Drawing.Point(295, 328);
            this.Quantite_V.Name = "Quantite_V";
            this.Quantite_V.Size = new System.Drawing.Size(100, 22);
            this.Quantite_V.TabIndex = 38;
            this.Quantite_V.Text = "Sép par un \";\"";
            this.Quantite_V.TextChanged += new System.EventHandler(this.Quantite_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(27, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Quantite de chaque vélo choisi\r\n";
            // 
            // PrenomParticulier
            // 
            this.PrenomParticulier.Location = new System.Drawing.Point(295, 291);
            this.PrenomParticulier.Name = "PrenomParticulier";
            this.PrenomParticulier.Size = new System.Drawing.Size(100, 22);
            this.PrenomParticulier.TabIndex = 36;
            this.PrenomParticulier.Text = "(Prenom)";
            this.PrenomParticulier.TextChanged += new System.EventHandler(this.PrenomParticulier_TextChanged);
            // 
            // Pieces
            // 
            this.Pieces.Location = new System.Drawing.Point(295, 74);
            this.Pieces.Name = "Pieces";
            this.Pieces.Size = new System.Drawing.Size(100, 22);
            this.Pieces.TabIndex = 34;
            this.Pieces.Text = "Sép par un \";\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(6, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Liste des nums des pièces de rechanges";
            // 
            // NomClient
            // 
            this.NomClient.Location = new System.Drawing.Point(295, 251);
            this.NomClient.Name = "NomClient";
            this.NomClient.Size = new System.Drawing.Size(100, 22);
            this.NomClient.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(6, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Liste des num des modèles de Vélo";
            // 
            // ComboBoxClient
            // 
            this.ComboBoxClient.BackColor = System.Drawing.Color.Silver;
            this.ComboBoxClient.FormattingEnabled = true;
            this.ComboBoxClient.Items.AddRange(new object[] {
            "nom du particulier",
            "nom de la boutique"});
            this.ComboBoxClient.Location = new System.Drawing.Point(27, 251);
            this.ComboBoxClient.Name = "ComboBoxClient";
            this.ComboBoxClient.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxClient.TabIndex = 20;
            // 
            // DateCommande
            // 
            this.DateCommande.Location = new System.Drawing.Point(295, 144);
            this.DateCommande.Name = "DateCommande";
            this.DateCommande.Size = new System.Drawing.Size(100, 22);
            this.DateCommande.TabIndex = 18;
            this.DateCommande.Text = "month/day/year";
            this.DateCommande.TextChanged += new System.EventHandler(this.DateCommande_TextChanged);
            // 
            // NumCommande
            // 
            this.NumCommande.Enabled = false;
            this.NumCommande.Location = new System.Drawing.Point(295, 111);
            this.NumCommande.Name = "NumCommande";
            this.NumCommande.Size = new System.Drawing.Size(100, 22);
            this.NumCommande.TabIndex = 16;
            this.NumCommande.Text = "Automatique";
            // 
            // DateLivraison
            // 
            this.DateLivraison.Enabled = false;
            this.DateLivraison.Location = new System.Drawing.Point(295, 213);
            this.DateLivraison.Name = "DateLivraison";
            this.DateLivraison.Size = new System.Drawing.Size(100, 22);
            this.DateLivraison.TabIndex = 15;
            this.DateLivraison.Text = "Automatique";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(39, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "date_livraison";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(39, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "date_commande";
            // 
            // NomV
            // 
            this.NomV.AutoSize = true;
            this.NomV.BackColor = System.Drawing.Color.Silver;
            this.NomV.Location = new System.Drawing.Point(24, 111);
            this.NomV.Name = "NomV";
            this.NomV.Size = new System.Drawing.Size(159, 16);
            this.NomV.TabIndex = 5;
            this.NomV.Text = "Numero de la commande\r\n";
            // 
            // DataVelos
            // 
            this.DataVelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataVelos.Location = new System.Drawing.Point(680, 43);
            this.DataVelos.Name = "DataVelos";
            this.DataVelos.RowHeadersWidth = 51;
            this.DataVelos.RowTemplate.Height = 24;
            this.DataVelos.Size = new System.Drawing.Size(250, 250);
            this.DataVelos.TabIndex = 35;
            this.DataVelos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataVelos_CellContentClick);
            // 
            // DataPièce
            // 
            this.DataPièce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataPièce.Location = new System.Drawing.Point(1010, 39);
            this.DataPièce.Name = "DataPièce";
            this.DataPièce.RowHeadersWidth = 51;
            this.DataPièce.RowTemplate.Height = 24;
            this.DataPièce.Size = new System.Drawing.Size(250, 250);
            this.DataPièce.TabIndex = 36;
            this.DataPièce.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataPièce_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(677, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Liste des modèles de vélos disponibles";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(1007, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Liste des pièces de rechanges disponibles ";
            // 
            // DataPiècesRecommandées
            // 
            this.DataPiècesRecommandées.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataPiècesRecommandées.Location = new System.Drawing.Point(724, 369);
            this.DataPiècesRecommandées.Name = "DataPiècesRecommandées";
            this.DataPiècesRecommandées.RowHeadersWidth = 51;
            this.DataPiècesRecommandées.RowTemplate.Height = 24;
            this.DataPiècesRecommandées.Size = new System.Drawing.Size(224, 98);
            this.DataPiècesRecommandées.TabIndex = 39;
            this.DataPiècesRecommandées.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataPiècesRecommandées_CellContentClick);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // DataCommande
            // 
            this.DataCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataCommande.Location = new System.Drawing.Point(989, 369);
            this.DataCommande.Name = "DataCommande";
            this.DataCommande.RowHeadersWidth = 51;
            this.DataCommande.RowTemplate.Height = 24;
            this.DataCommande.Size = new System.Drawing.Size(224, 98);
            this.DataCommande.TabIndex = 41;
            this.DataCommande.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataCommande_CellContentClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label11.Location = new System.Drawing.Point(923, 493);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 16);
            this.label11.TabIndex = 42;
            this.label11.Text = "Votre Commande";
            // 
            // AjoutCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1314, 638);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DataCommande);
            this.Controls.Add(this.DataPiècesRecommandées);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataPièce);
            this.Controls.Add(this.DataVelos);
            this.Controls.Add(this.Button_Retour);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.Button_ValiderAjoutCommande);
            this.Controls.Add(this.groupBox1);
            this.Name = "AjoutCommande";
            this.Text = "AjoutCommande";
            this.Load += new System.EventHandler(this.AjoutCommande_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataVelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataPièce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataPiècesRecommandées)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataCommande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Retour;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button Button_ValiderAjoutCommande;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NomClient;
        private System.Windows.Forms.ComboBox ComboBoxClient;
        private System.Windows.Forms.TextBox DateCommande;
        private System.Windows.Forms.TextBox NumCommande;
        private System.Windows.Forms.TextBox DateLivraison;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label NomV;
        private System.Windows.Forms.DataGridView DataVelos;
        private System.Windows.Forms.DataGridView DataPièce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DataPiècesRecommandées;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.TextBox Pieces;
        private System.Windows.Forms.TextBox PrenomParticulier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Quantite_V;
        private System.Windows.Forms.TextBox Quantite_P;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView DataCommande;
        private System.Windows.Forms.TextBox Velos;
        private System.Windows.Forms.TextBox Adresse;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}