namespace VéloMax_Pb_BDD
{
    partial class Approvisionnement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Approvisionnement));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.NumPF = new System.Windows.Forms.TextBox();
            this.Quantité = new System.Windows.Forms.TextBox();
            this.PrixPièce = new System.Windows.Forms.TextBox();
            this.Delai = new System.Windows.Forms.TextBox();
            this.NumF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumPiece = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Validate_Button = new System.Windows.Forms.Button();
            this.Buton_Retour = new System.Windows.Forms.Button();
            this.ComboBoxDesc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(58, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stocks Actuels";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(431, 206);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(668, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 227);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fournisseurs Actuels";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(16, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(478, 194);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dataGridView3);
            this.groupBox3.Location = new System.Drawing.Point(226, 455);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(707, 208);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stocks après Approvisionnements ";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(-12, 52);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(701, 129);
            this.dataGridView3.TabIndex = 4;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.ComboBoxDesc);
            this.groupBox4.Controls.Add(this.NumPF);
            this.groupBox4.Controls.Add(this.Quantité);
            this.groupBox4.Controls.Add(this.PrixPièce);
            this.groupBox4.Controls.Add(this.Delai);
            this.groupBox4.Controls.Add(this.NumF);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.NumPiece);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(226, 251);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(707, 178);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Caractéristiques à remplir";
            // 
            // NumPF
            // 
            this.NumPF.Location = new System.Drawing.Point(601, 34);
            this.NumPF.Name = "NumPF";
            this.NumPF.Size = new System.Drawing.Size(100, 22);
            this.NumPF.TabIndex = 8;
            // 
            // Quantité
            // 
            this.Quantité.Location = new System.Drawing.Point(309, 140);
            this.Quantité.Name = "Quantité";
            this.Quantité.Size = new System.Drawing.Size(100, 22);
            this.Quantité.TabIndex = 7;
            // 
            // PrixPièce
            // 
            this.PrixPièce.Location = new System.Drawing.Point(601, 70);
            this.PrixPièce.Name = "PrixPièce";
            this.PrixPièce.Size = new System.Drawing.Size(100, 22);
            this.PrixPièce.TabIndex = 4;
            this.PrixPièce.Text = "0";
            // 
            // Delai
            // 
            this.Delai.Location = new System.Drawing.Point(601, 101);
            this.Delai.Name = "Delai";
            this.Delai.Size = new System.Drawing.Size(100, 22);
            this.Delai.TabIndex = 5;
            this.Delai.Text = "(Jours)";
            // 
            // NumF
            // 
            this.NumF.Location = new System.Drawing.Point(188, 67);
            this.NumF.Name = "NumF";
            this.NumF.Size = new System.Drawing.Size(100, 22);
            this.NumF.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RosyBrown;
            this.label6.Location = new System.Drawing.Point(155, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantité à Ajouter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(446, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Délai du fournisseur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(472, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prix de le pièce";
            // 
            // NumPiece
            // 
            this.NumPiece.Location = new System.Drawing.Point(188, 34);
            this.NumPiece.Name = "NumPiece";
            this.NumPiece.Size = new System.Drawing.Size(100, 22);
            this.NumPiece.TabIndex = 3;
            this.NumPiece.TextChanged += new System.EventHandler(this.NumPiece_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(294, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numéro Pièce sur le catalogue du fournisseur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(41, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Siret du fournisseur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro de la pièce";
            // 
            // Validate_Button
            // 
            this.Validate_Button.BackColor = System.Drawing.Color.Lime;
            this.Validate_Button.Location = new System.Drawing.Point(546, 426);
            this.Validate_Button.Name = "Validate_Button";
            this.Validate_Button.Size = new System.Drawing.Size(75, 23);
            this.Validate_Button.TabIndex = 3;
            this.Validate_Button.Text = "Valider";
            this.Validate_Button.UseVisualStyleBackColor = false;
            this.Validate_Button.Click += new System.EventHandler(this.Validate_Button_Click);
            // 
            // Buton_Retour
            // 
            this.Buton_Retour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Buton_Retour.Location = new System.Drawing.Point(1170, 689);
            this.Buton_Retour.Name = "Buton_Retour";
            this.Buton_Retour.Size = new System.Drawing.Size(75, 23);
            this.Buton_Retour.TabIndex = 47;
            this.Buton_Retour.Text = "Retour";
            this.Buton_Retour.UseVisualStyleBackColor = false;
            this.Buton_Retour.Click += new System.EventHandler(this.Buton_Retour_Click);
            // 
            // ComboBoxDesc
            // 
            this.ComboBoxDesc.FormattingEnabled = true;
            this.ComboBoxDesc.Items.AddRange(new object[] {
            "Cadre",
            "Guidon",
            "Freins",
            "Selle",
            "Derailleur Avant",
            "Derailleur Arrière",
            "Roue avant",
            "Roue arrière",
            "Réflecteur",
            "Pédalier",
            "Ordinateur",
            "Panier"});
            this.ComboBoxDesc.Location = new System.Drawing.Point(188, 101);
            this.ComboBoxDesc.Name = "ComboBoxDesc";
            this.ComboBoxDesc.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxDesc.TabIndex = 21;
            this.ComboBoxDesc.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDesc_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(6, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Description de la pièce";
            // 
            // Approvisionnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1266, 724);
            this.Controls.Add(this.Buton_Retour);
            this.Controls.Add(this.Validate_Button);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Approvisionnement";
            this.Text = "Approvisionnement";
            this.Load += new System.EventHandler(this.Approvisionnement_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox NumPF;
        private System.Windows.Forms.TextBox Quantité;
        private System.Windows.Forms.TextBox PrixPièce;
        private System.Windows.Forms.TextBox Delai;
        private System.Windows.Forms.TextBox NumF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NumPiece;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button Validate_Button;
        private System.Windows.Forms.Button Buton_Retour;
        private System.Windows.Forms.ComboBox ComboBoxDesc;
        private System.Windows.Forms.Label label7;
    }
}