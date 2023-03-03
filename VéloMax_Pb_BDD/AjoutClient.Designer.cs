namespace VéloMax_Pb_BDD
{
    partial class AjoutClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutClient));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.codePParticulier = new System.Windows.Forms.TextBox();
            this.courrielParticulier = new System.Windows.Forms.TextBox();
            this.provinceParticulier = new System.Windows.Forms.TextBox();
            this.prenomParticulier = new System.Windows.Forms.TextBox();
            this.numeroParticulier = new System.Windows.Forms.TextBox();
            this.villeParticulier = new System.Windows.Forms.TextBox();
            this.rueParticulier = new System.Windows.Forms.TextBox();
            this.nomParticulier = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RemiseBoutiqueT = new System.Windows.Forms.TextBox();
            this.RemiseBoutique = new System.Windows.Forms.Label();
            this.courrB = new System.Windows.Forms.TextBox();
            this.contactB = new System.Windows.Forms.TextBox();
            this.villeB = new System.Windows.Forms.TextBox();
            this.rueB = new System.Windows.Forms.TextBox();
            this.codePB = new System.Windows.Forms.TextBox();
            this.provinceB = new System.Windows.Forms.TextBox();
            this.numeB = new System.Windows.Forms.TextBox();
            this.NomB = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Button_ValiderAjoutParticulier = new System.Windows.Forms.Button();
            this.Button_ValiderAjoutBoutique = new System.Windows.Forms.Button();
            this.Button_retour = new System.Windows.Forms.Button();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Particulier";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(550, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Boutique";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.codePParticulier);
            this.groupBox1.Controls.Add(this.courrielParticulier);
            this.groupBox1.Controls.Add(this.provinceParticulier);
            this.groupBox1.Controls.Add(this.prenomParticulier);
            this.groupBox1.Controls.Add(this.numeroParticulier);
            this.groupBox1.Controls.Add(this.villeParticulier);
            this.groupBox1.Controls.Add(this.rueParticulier);
            this.groupBox1.Controls.Add(this.nomParticulier);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(60, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 357);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caractéristiques à remplir";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(247, 36);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(112, 20);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "adhère-t-il ?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Silver;
            this.label19.Location = new System.Drawing.Point(37, 40);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(122, 16);
            this.label19.TabIndex = 20;
            this.label19.Text = "Programme Fidelio";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // codePParticulier
            // 
            this.codePParticulier.Location = new System.Drawing.Point(247, 178);
            this.codePParticulier.Name = "codePParticulier";
            this.codePParticulier.Size = new System.Drawing.Size(100, 22);
            this.codePParticulier.TabIndex = 19;
            this.codePParticulier.TextChanged += new System.EventHandler(this.codePParticulier_TextChanged);
            // 
            // courrielParticulier
            // 
            this.courrielParticulier.Location = new System.Drawing.Point(247, 282);
            this.courrielParticulier.Name = "courrielParticulier";
            this.courrielParticulier.Size = new System.Drawing.Size(100, 22);
            this.courrielParticulier.TabIndex = 18;
            // 
            // provinceParticulier
            // 
            this.provinceParticulier.Location = new System.Drawing.Point(247, 212);
            this.provinceParticulier.Name = "provinceParticulier";
            this.provinceParticulier.Size = new System.Drawing.Size(100, 22);
            this.provinceParticulier.TabIndex = 17;
            // 
            // prenomParticulier
            // 
            this.prenomParticulier.Location = new System.Drawing.Point(247, 107);
            this.prenomParticulier.Name = "prenomParticulier";
            this.prenomParticulier.Size = new System.Drawing.Size(100, 22);
            this.prenomParticulier.TabIndex = 16;
            this.prenomParticulier.TextChanged += new System.EventHandler(this.prenomParticulier_TextChanged);
            // 
            // numeroParticulier
            // 
            this.numeroParticulier.Location = new System.Drawing.Point(247, 248);
            this.numeroParticulier.Name = "numeroParticulier";
            this.numeroParticulier.Size = new System.Drawing.Size(100, 22);
            this.numeroParticulier.TabIndex = 15;
            // 
            // villeParticulier
            // 
            this.villeParticulier.Location = new System.Drawing.Point(247, 319);
            this.villeParticulier.Name = "villeParticulier";
            this.villeParticulier.Size = new System.Drawing.Size(100, 22);
            this.villeParticulier.TabIndex = 14;
            this.villeParticulier.TextChanged += new System.EventHandler(this.villeParticulier_TextChanged);
            // 
            // rueParticulier
            // 
            this.rueParticulier.Location = new System.Drawing.Point(247, 146);
            this.rueParticulier.Name = "rueParticulier";
            this.rueParticulier.Size = new System.Drawing.Size(100, 22);
            this.rueParticulier.TabIndex = 13;
            this.rueParticulier.TextChanged += new System.EventHandler(this.rueParticulier_TextChanged);
            // 
            // nomParticulier
            // 
            this.nomParticulier.Location = new System.Drawing.Point(247, 76);
            this.nomParticulier.Name = "nomParticulier";
            this.nomParticulier.Size = new System.Drawing.Size(100, 22);
            this.nomParticulier.TabIndex = 12;
            this.nomParticulier.TextChanged += new System.EventHandler(this.nomParticulier_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(39, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "courriel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(37, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "province";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(37, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "numero de téléphone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(37, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "rue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(41, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "ville";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(39, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "code Postal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(37, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(39, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "nom";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RemiseBoutiqueT);
            this.groupBox2.Controls.Add(this.RemiseBoutique);
            this.groupBox2.Controls.Add(this.courrB);
            this.groupBox2.Controls.Add(this.contactB);
            this.groupBox2.Controls.Add(this.villeB);
            this.groupBox2.Controls.Add(this.rueB);
            this.groupBox2.Controls.Add(this.codePB);
            this.groupBox2.Controls.Add(this.provinceB);
            this.groupBox2.Controls.Add(this.numeB);
            this.groupBox2.Controls.Add(this.NomB);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(525, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 357);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Caractéristiques à remplir";
            // 
            // RemiseBoutiqueT
            // 
            this.RemiseBoutiqueT.Location = new System.Drawing.Point(257, 313);
            this.RemiseBoutiqueT.Name = "RemiseBoutiqueT";
            this.RemiseBoutiqueT.Size = new System.Drawing.Size(100, 22);
            this.RemiseBoutiqueT.TabIndex = 35;
            // 
            // RemiseBoutique
            // 
            this.RemiseBoutique.AutoSize = true;
            this.RemiseBoutique.BackColor = System.Drawing.Color.Silver;
            this.RemiseBoutique.Location = new System.Drawing.Point(39, 316);
            this.RemiseBoutique.Name = "RemiseBoutique";
            this.RemiseBoutique.Size = new System.Drawing.Size(54, 16);
            this.RemiseBoutique.TabIndex = 8;
            this.RemiseBoutique.Text = "Remise";
            // 
            // courrB
            // 
            this.courrB.Location = new System.Drawing.Point(257, 251);
            this.courrB.Name = "courrB";
            this.courrB.Size = new System.Drawing.Size(100, 22);
            this.courrB.TabIndex = 34;
            // 
            // contactB
            // 
            this.contactB.Location = new System.Drawing.Point(257, 279);
            this.contactB.Name = "contactB";
            this.contactB.Size = new System.Drawing.Size(100, 22);
            this.contactB.TabIndex = 33;
            // 
            // villeB
            // 
            this.villeB.Location = new System.Drawing.Point(257, 79);
            this.villeB.Name = "villeB";
            this.villeB.Size = new System.Drawing.Size(100, 22);
            this.villeB.TabIndex = 32;
            // 
            // rueB
            // 
            this.rueB.Location = new System.Drawing.Point(257, 113);
            this.rueB.Name = "rueB";
            this.rueB.Size = new System.Drawing.Size(100, 22);
            this.rueB.TabIndex = 31;
            // 
            // codePB
            // 
            this.codePB.Location = new System.Drawing.Point(257, 146);
            this.codePB.Name = "codePB";
            this.codePB.Size = new System.Drawing.Size(100, 22);
            this.codePB.TabIndex = 30;
            // 
            // provinceB
            // 
            this.provinceB.Location = new System.Drawing.Point(257, 184);
            this.provinceB.Name = "provinceB";
            this.provinceB.Size = new System.Drawing.Size(100, 22);
            this.provinceB.TabIndex = 29;
            // 
            // numeB
            // 
            this.numeB.Location = new System.Drawing.Point(257, 216);
            this.numeB.Name = "numeB";
            this.numeB.Size = new System.Drawing.Size(100, 22);
            this.numeB.TabIndex = 28;
            // 
            // NomB
            // 
            this.NomB.Location = new System.Drawing.Point(257, 46);
            this.NomB.Name = "NomB";
            this.NomB.Size = new System.Drawing.Size(100, 22);
            this.NomB.TabIndex = 20;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Silver;
            this.label18.Location = new System.Drawing.Point(37, 251);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 16);
            this.label18.TabIndex = 27;
            this.label18.Text = "courriel";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Silver;
            this.label17.Location = new System.Drawing.Point(37, 282);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(191, 16);
            this.label17.TabIndex = 26;
            this.label17.Text = "nom de la personne de contact";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Silver;
            this.label16.Location = new System.Drawing.Point(37, 181);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 16);
            this.label16.TabIndex = 25;
            this.label16.Text = "province";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Silver;
            this.label15.Location = new System.Drawing.Point(37, 216);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 16);
            this.label15.TabIndex = 24;
            this.label15.Text = "numéro de téléphone";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Silver;
            this.label14.Location = new System.Drawing.Point(37, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 16);
            this.label14.TabIndex = 23;
            this.label14.Text = "rue";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Silver;
            this.label13.Location = new System.Drawing.Point(37, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "codeP";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(37, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "ville";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(37, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "nom";
            // 
            // Button_ValiderAjoutParticulier
            // 
            this.Button_ValiderAjoutParticulier.BackColor = System.Drawing.Color.Lime;
            this.Button_ValiderAjoutParticulier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_ValiderAjoutParticulier.Location = new System.Drawing.Point(196, 463);
            this.Button_ValiderAjoutParticulier.Name = "Button_ValiderAjoutParticulier";
            this.Button_ValiderAjoutParticulier.Size = new System.Drawing.Size(123, 40);
            this.Button_ValiderAjoutParticulier.TabIndex = 4;
            this.Button_ValiderAjoutParticulier.Text = "Valider l\'ajout du particulier";
            this.Button_ValiderAjoutParticulier.UseVisualStyleBackColor = false;
            this.Button_ValiderAjoutParticulier.Click += new System.EventHandler(this.Button_ValiderAjoutParticulier_Click);
            // 
            // Button_ValiderAjoutBoutique
            // 
            this.Button_ValiderAjoutBoutique.BackColor = System.Drawing.Color.Lime;
            this.Button_ValiderAjoutBoutique.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_ValiderAjoutBoutique.Location = new System.Drawing.Point(671, 463);
            this.Button_ValiderAjoutBoutique.Name = "Button_ValiderAjoutBoutique";
            this.Button_ValiderAjoutBoutique.Size = new System.Drawing.Size(123, 40);
            this.Button_ValiderAjoutBoutique.TabIndex = 6;
            this.Button_ValiderAjoutBoutique.Text = "Valider l\'ajout de la boutique ";
            this.Button_ValiderAjoutBoutique.UseVisualStyleBackColor = false;
            this.Button_ValiderAjoutBoutique.Click += new System.EventHandler(this.Button_ValiderAjoutBoutique_Click);
            // 
            // Button_retour
            // 
            this.Button_retour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Button_retour.Cursor = System.Windows.Forms.Cursors.Default;
            this.Button_retour.Location = new System.Drawing.Point(834, 12);
            this.Button_retour.Name = "Button_retour";
            this.Button_retour.Size = new System.Drawing.Size(75, 23);
            this.Button_retour.TabIndex = 7;
            this.Button_retour.Text = "Retour";
            this.Button_retour.UseVisualStyleBackColor = false;
            this.Button_retour.Click += new System.EventHandler(this.Button_retour_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(408, 12);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(125, 25);
            this.label20.TabIndex = 21;
            this.label20.Text = "Ajout/Client";
            // 
            // AjoutClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(991, 543);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.Button_retour);
            this.Controls.Add(this.Button_ValiderAjoutBoutique);
            this.Controls.Add(this.Button_ValiderAjoutParticulier);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AjoutClient";
            this.RightToLeftLayout = true;
            this.Text = "AjoutClient";
            this.Load += new System.EventHandler(this.AjoutClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox codePParticulier;
        private System.Windows.Forms.TextBox courrielParticulier;
        private System.Windows.Forms.TextBox provinceParticulier;
        private System.Windows.Forms.TextBox prenomParticulier;
        private System.Windows.Forms.TextBox numeroParticulier;
        private System.Windows.Forms.TextBox villeParticulier;
        private System.Windows.Forms.TextBox rueParticulier;
        private System.Windows.Forms.TextBox nomParticulier;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox courrB;
        private System.Windows.Forms.TextBox contactB;
        private System.Windows.Forms.TextBox villeB;
        private System.Windows.Forms.TextBox rueB;
        private System.Windows.Forms.TextBox codePB;
        private System.Windows.Forms.TextBox provinceB;
        private System.Windows.Forms.TextBox numeB;
        private System.Windows.Forms.TextBox NomB;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Button_ValiderAjoutParticulier;
        private System.Windows.Forms.Button Button_ValiderAjoutBoutique;
        private System.Windows.Forms.Button Button_retour;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox RemiseBoutiqueT;
        private System.Windows.Forms.Label RemiseBoutique;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.Label label20;
    }
}