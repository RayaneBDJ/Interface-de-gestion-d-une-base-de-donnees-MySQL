namespace VéloMax_Pb_BDD
{
    partial class MAJVelo
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
            this.DataVélo_Ap = new System.Windows.Forms.DataGridView();
            this.DataVélo_Av = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NumeroVélo = new System.Windows.Forms.TextBox();
            this.NomVélo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ComboBox_Parametre = new System.Windows.Forms.ComboBox();
            this.ComboBox_Produit = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComboBox_Grandeur = new System.Windows.Forms.ComboBox();
            this.ParametreValue = new System.Windows.Forms.TextBox();
            this.Button_ValiderMAJ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataVélo_Ap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataVélo_Av)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataVélo_Ap
            // 
            this.DataVélo_Ap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataVélo_Ap.Location = new System.Drawing.Point(654, 315);
            this.DataVélo_Ap.Name = "DataVélo_Ap";
            this.DataVélo_Ap.RowHeadersWidth = 51;
            this.DataVélo_Ap.RowTemplate.Height = 24;
            this.DataVélo_Ap.Size = new System.Drawing.Size(550, 182);
            this.DataVélo_Ap.TabIndex = 45;
            this.DataVélo_Ap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataVélo_Ap_CellContentClick);
            // 
            // DataVélo_Av
            // 
            this.DataVélo_Av.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataVélo_Av.Location = new System.Drawing.Point(654, 57);
            this.DataVélo_Av.Name = "DataVélo_Av";
            this.DataVélo_Av.RowHeadersWidth = 51;
            this.DataVélo_Av.RowTemplate.Height = 24;
            this.DataVélo_Av.Size = new System.Drawing.Size(550, 183);
            this.DataVélo_Av.TabIndex = 44;
            this.DataVélo_Av.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataVélo_Av_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(130, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 29);
            this.label5.TabIndex = 43;
            this.label5.Text = "MAJ/Velo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(829, 526);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 16);
            this.label8.TabIndex = 41;
            this.label8.Text = "La DataSet après la mise à jour\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(793, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Selectionnez la ligne que vous voulez mettre à jour";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.ComboBox_Parametre);
            this.groupBox2.Controls.Add(this.NumeroVélo);
            this.groupBox2.Controls.Add(this.NomVélo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(104, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 306);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Caractéristiques à remplir";
            // 
            // NumeroVélo
            // 
            this.NumeroVélo.Location = new System.Drawing.Point(124, 40);
            this.NumeroVélo.Name = "NumeroVélo";
            this.NumeroVélo.Size = new System.Drawing.Size(100, 22);
            this.NumeroVélo.TabIndex = 21;
            this.NumeroVélo.TextChanged += new System.EventHandler(this.NumeroVélo_TextChanged);
            // 
            // NomVélo
            // 
            this.NomVélo.Location = new System.Drawing.Point(124, 67);
            this.NomVélo.Name = "NomVélo";
            this.NomVélo.Size = new System.Drawing.Size(100, 22);
            this.NomVélo.TabIndex = 20;
            this.NomVélo.TextChanged += new System.EventHandler(this.NomVélo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(37, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "nomV";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(37, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "numV";
            // 
            // ComboBox_Parametre
            // 
            this.ComboBox_Parametre.FormattingEnabled = true;
            this.ComboBox_Parametre.Items.AddRange(new object[] {
            "grandeur",
            "prix",
            "ligne_produit",
            "date_debut",
            "date_fin"});
            this.ComboBox_Parametre.Location = new System.Drawing.Point(0, 183);
            this.ComboBox_Parametre.Name = "ComboBox_Parametre";
            this.ComboBox_Parametre.Size = new System.Drawing.Size(121, 24);
            this.ComboBox_Parametre.TabIndex = 46;
            // 
            // ComboBox_Produit
            // 
            this.ComboBox_Produit.FormattingEnabled = true;
            this.ComboBox_Produit.Items.AddRange(new object[] {
            "VTT",
            "Vélo de course",
            "Classique",
            "BMX"});
            this.ComboBox_Produit.Location = new System.Drawing.Point(19, 79);
            this.ComboBox_Produit.Name = "ComboBox_Produit";
            this.ComboBox_Produit.Size = new System.Drawing.Size(121, 24);
            this.ComboBox_Produit.TabIndex = 47;
            this.ComboBox_Produit.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Produit_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ParametreValue);
            this.groupBox1.Controls.Add(this.ComboBox_Grandeur);
            this.groupBox1.Controls.Add(this.ComboBox_Produit);
            this.groupBox1.Location = new System.Drawing.Point(147, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 126);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choisis";
            // 
            // ComboBox_Grandeur
            // 
            this.ComboBox_Grandeur.FormattingEnabled = true;
            this.ComboBox_Grandeur.Items.AddRange(new object[] {
            "Adultes",
            "Jeunes",
            "Hommes",
            "Dames",
            "Filles",
            "Garçons"});
            this.ComboBox_Grandeur.Location = new System.Drawing.Point(19, 21);
            this.ComboBox_Grandeur.Name = "ComboBox_Grandeur";
            this.ComboBox_Grandeur.Size = new System.Drawing.Size(121, 24);
            this.ComboBox_Grandeur.TabIndex = 50;
            this.ComboBox_Grandeur.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Grandeur_SelectedIndexChanged);
            // 
            // ParametreValue
            // 
            this.ParametreValue.Location = new System.Drawing.Point(19, 51);
            this.ParametreValue.Name = "ParametreValue";
            this.ParametreValue.Size = new System.Drawing.Size(100, 22);
            this.ParametreValue.TabIndex = 51;
            this.ParametreValue.TextChanged += new System.EventHandler(this.ParametreValue_TextChanged);
            // 
            // Button_ValiderMAJ
            // 
            this.Button_ValiderMAJ.BackColor = System.Drawing.Color.Lime;
            this.Button_ValiderMAJ.Location = new System.Drawing.Point(170, 481);
            this.Button_ValiderMAJ.Name = "Button_ValiderMAJ";
            this.Button_ValiderMAJ.Size = new System.Drawing.Size(158, 43);
            this.Button_ValiderMAJ.TabIndex = 46;
            this.Button_ValiderMAJ.Text = "Valider la mise à jour du vélo\r\n\r\n";
            this.Button_ValiderMAJ.UseVisualStyleBackColor = false;
            this.Button_ValiderMAJ.Click += new System.EventHandler(this.Button_ValiderMAJ_Click);
            // 
            // MAJVelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 598);
            this.Controls.Add(this.Button_ValiderMAJ);
            this.Controls.Add(this.DataVélo_Ap);
            this.Controls.Add(this.DataVélo_Av);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Name = "MAJVelo";
            this.Text = "MAJVelo";
            this.Load += new System.EventHandler(this.MAJVelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataVélo_Ap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataVélo_Av)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataVélo_Ap;
        private System.Windows.Forms.DataGridView DataVélo_Av;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox ComboBox_Produit;
        private System.Windows.Forms.ComboBox ComboBox_Parametre;
        private System.Windows.Forms.TextBox NumeroVélo;
        private System.Windows.Forms.TextBox NomVélo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ParametreValue;
        private System.Windows.Forms.ComboBox ComboBox_Grandeur;
        private System.Windows.Forms.Button Button_ValiderMAJ;
    }
}