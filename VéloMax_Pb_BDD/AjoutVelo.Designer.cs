namespace VéloMax_Pb_BDD
{
    partial class AjoutVelo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutVelo));
            this.Button_ValiderAjoutParticulier = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.prixV = new System.Windows.Forms.TextBox();
            this.DateFinV = new System.Windows.Forms.TextBox();
            this.NomVélo = new System.Windows.Forms.TextBox();
            this.DateDébutV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NomV = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.ComboBoxGrandeur = new System.Windows.Forms.ComboBox();
            this.ComboBoxPoduit = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Button_Retour = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_ValiderAjoutParticulier
            // 
            this.Button_ValiderAjoutParticulier.BackColor = System.Drawing.Color.Lime;
            this.Button_ValiderAjoutParticulier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_ValiderAjoutParticulier.Location = new System.Drawing.Point(340, 450);
            this.Button_ValiderAjoutParticulier.Name = "Button_ValiderAjoutParticulier";
            this.Button_ValiderAjoutParticulier.Size = new System.Drawing.Size(123, 40);
            this.Button_ValiderAjoutParticulier.TabIndex = 6;
            this.Button_ValiderAjoutParticulier.Text = "Valider l\'ajout du vélo\r\n";
            this.Button_ValiderAjoutParticulier.UseVisualStyleBackColor = false;
            this.Button_ValiderAjoutParticulier.Click += new System.EventHandler(this.Button_ValiderAjoutParticulier_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ComboBoxPoduit);
            this.groupBox1.Controls.Add(this.ComboBoxGrandeur);
            this.groupBox1.Controls.Add(this.prixV);
            this.groupBox1.Controls.Add(this.DateFinV);
            this.groupBox1.Controls.Add(this.NomVélo);
            this.groupBox1.Controls.Add(this.DateDébutV);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.NomV);
            this.groupBox1.Location = new System.Drawing.Point(210, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 357);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caractéristiques à remplir";
            // 
            // prixV
            // 
            this.prixV.Location = new System.Drawing.Point(247, 163);
            this.prixV.Name = "prixV";
            this.prixV.Size = new System.Drawing.Size(100, 22);
            this.prixV.TabIndex = 19;
            // 
            // DateFinV
            // 
            this.DateFinV.Location = new System.Drawing.Point(247, 305);
            this.DateFinV.Name = "DateFinV";
            this.DateFinV.Size = new System.Drawing.Size(100, 22);
            this.DateFinV.TabIndex = 18;
            this.DateFinV.Text = "Month/Day/Year";
            // 
            // NomVélo
            // 
            this.NomVélo.Location = new System.Drawing.Point(247, 68);
            this.NomVélo.Name = "NomVélo";
            this.NomVélo.Size = new System.Drawing.Size(100, 22);
            this.NomVélo.TabIndex = 16;
            // 
            // DateDébutV
            // 
            this.DateDébutV.Location = new System.Drawing.Point(247, 262);
            this.DateDébutV.Name = "DateDébutV";
            this.DateDébutV.Size = new System.Drawing.Size(100, 22);
            this.DateDébutV.TabIndex = 15;
            this.DateDébutV.Text = "Month/Day/Year";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(37, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "date_fin";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(37, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "ligne_produit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(37, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "date_debut";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(39, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "grandeur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(37, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "prix";
            // 
            // NomV
            // 
            this.NomV.AutoSize = true;
            this.NomV.BackColor = System.Drawing.Color.Silver;
            this.NomV.Location = new System.Drawing.Point(39, 74);
            this.NomV.Name = "NomV";
            this.NomV.Size = new System.Drawing.Size(103, 16);
            this.NomV.TabIndex = 5;
            this.NomV.Text = "Nom du Modèle";
            this.NomV.Click += new System.EventHandler(this.label4_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(335, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 25);
            this.label20.TabIndex = 22;
            this.label20.Text = "Ajout/Velo";
            // 
            // ComboBoxGrandeur
            // 
            this.ComboBoxGrandeur.FormattingEnabled = true;
            this.ComboBoxGrandeur.Items.AddRange(new object[] {
            "Adultes",
            "Jeunes",
            "Hommes",
            "Dames",
            "Filles",
            "Garçons"});
            this.ComboBoxGrandeur.Location = new System.Drawing.Point(226, 113);
            this.ComboBoxGrandeur.Name = "ComboBoxGrandeur";
            this.ComboBoxGrandeur.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxGrandeur.TabIndex = 20;
            // 
            // ComboBoxPoduit
            // 
            this.ComboBoxPoduit.FormattingEnabled = true;
            this.ComboBoxPoduit.Items.AddRange(new object[] {
            "VTT",
            "Vélo de course",
            "Classique",
            "BMX"});
            this.ComboBoxPoduit.Location = new System.Drawing.Point(226, 208);
            this.ComboBoxPoduit.Name = "ComboBoxPoduit";
            this.ComboBoxPoduit.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxPoduit.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(603, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 23;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Button_Retour
            // 
            this.Button_Retour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Button_Retour.Location = new System.Drawing.Point(728, 485);
            this.Button_Retour.Name = "Button_Retour";
            this.Button_Retour.Size = new System.Drawing.Size(75, 23);
            this.Button_Retour.TabIndex = 24;
            this.Button_Retour.Text = "Retour";
            this.Button_Retour.UseVisualStyleBackColor = false;
            this.Button_Retour.Click += new System.EventHandler(this.Button_Retour_Click);
            // 
            // AjoutVelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(830, 520);
            this.Controls.Add(this.Button_Retour);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.Button_ValiderAjoutParticulier);
            this.Controls.Add(this.groupBox1);
            this.Name = "AjoutVelo";
            this.Text = "AjoutVelo";
            this.Load += new System.EventHandler(this.AjoutVelo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_ValiderAjoutParticulier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox prixV;
        private System.Windows.Forms.TextBox DateFinV;
        private System.Windows.Forms.TextBox NomVélo;
        private System.Windows.Forms.TextBox DateDébutV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label NomV;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox ComboBoxPoduit;
        private System.Windows.Forms.ComboBox ComboBoxGrandeur;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Button_Retour;
    }
}