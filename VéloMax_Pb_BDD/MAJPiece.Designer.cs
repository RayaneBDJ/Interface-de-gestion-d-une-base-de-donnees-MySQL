namespace VéloMax_Pb_BDD
{
    partial class MAJPiece
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAJPiece));
            this.Button_ValiderMAJ = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ParametreValue = new System.Windows.Forms.TextBox();
            this.ComboBox_Desc = new System.Windows.Forms.ComboBox();
            this.ComboBox_Parametre = new System.Windows.Forms.ComboBox();
            this.NumeroPiece = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DataPiece_Av = new System.Windows.Forms.DataGridView();
            this.DataPiece_Ap = new System.Windows.Forms.DataGridView();
            this.Buton_Retour = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPiece_Av)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataPiece_Ap)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_ValiderMAJ
            // 
            this.Button_ValiderMAJ.BackColor = System.Drawing.Color.Lime;
            this.Button_ValiderMAJ.Location = new System.Drawing.Point(119, 464);
            this.Button_ValiderMAJ.Name = "Button_ValiderMAJ";
            this.Button_ValiderMAJ.Size = new System.Drawing.Size(158, 43);
            this.Button_ValiderMAJ.TabIndex = 53;
            this.Button_ValiderMAJ.Text = "Valider la mise à jour du piece\r\n\r\n\r\n";
            this.Button_ValiderMAJ.UseVisualStyleBackColor = false;
            this.Button_ValiderMAJ.Click += new System.EventHandler(this.Button_ValiderMAJ_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 29);
            this.label5.TabIndex = 50;
            this.label5.Text = "MAJ/Piece";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(778, 509);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 16);
            this.label8.TabIndex = 49;
            this.label8.Text = "La DataSet après la mise à jour\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(742, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 16);
            this.label3.TabIndex = 48;
            this.label3.Text = "Selectionnez la ligne que vous voulez mettre à jour";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.ComboBox_Parametre);
            this.groupBox2.Controls.Add(this.NumeroPiece);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(53, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 306);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Caractéristiques à remplir";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ParametreValue);
            this.groupBox1.Controls.Add(this.ComboBox_Desc);
            this.groupBox1.Location = new System.Drawing.Point(147, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 126);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choisis";
            // 
            // ParametreValue
            // 
            this.ParametreValue.Location = new System.Drawing.Point(19, 77);
            this.ParametreValue.Name = "ParametreValue";
            this.ParametreValue.Size = new System.Drawing.Size(100, 22);
            this.ParametreValue.TabIndex = 51;
            this.ParametreValue.TextChanged += new System.EventHandler(this.ParametreValue_TextChanged);
            // 
            // ComboBox_Desc
            // 
            this.ComboBox_Desc.FormattingEnabled = true;
            this.ComboBox_Desc.Items.AddRange(new object[] {
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
            this.ComboBox_Desc.Location = new System.Drawing.Point(19, 30);
            this.ComboBox_Desc.Name = "ComboBox_Desc";
            this.ComboBox_Desc.Size = new System.Drawing.Size(121, 24);
            this.ComboBox_Desc.TabIndex = 50;
            this.ComboBox_Desc.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Desc_SelectedIndexChanged);
            // 
            // ComboBox_Parametre
            // 
            this.ComboBox_Parametre.FormattingEnabled = true;
            this.ComboBox_Parametre.Items.AddRange(new object[] {
            "description_",
            "date_debut",
            "date_fin"});
            this.ComboBox_Parametre.Location = new System.Drawing.Point(0, 169);
            this.ComboBox_Parametre.Name = "ComboBox_Parametre";
            this.ComboBox_Parametre.Size = new System.Drawing.Size(121, 24);
            this.ComboBox_Parametre.TabIndex = 46;
            // 
            // NumeroPiece
            // 
            this.NumeroPiece.Location = new System.Drawing.Point(124, 40);
            this.NumeroPiece.Name = "NumeroPiece";
            this.NumeroPiece.Size = new System.Drawing.Size(100, 22);
            this.NumeroPiece.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(37, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "numP";
            // 
            // DataPiece_Av
            // 
            this.DataPiece_Av.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataPiece_Av.Location = new System.Drawing.Point(603, 40);
            this.DataPiece_Av.Name = "DataPiece_Av";
            this.DataPiece_Av.RowHeadersWidth = 51;
            this.DataPiece_Av.RowTemplate.Height = 24;
            this.DataPiece_Av.Size = new System.Drawing.Size(550, 182);
            this.DataPiece_Av.TabIndex = 54;
            this.DataPiece_Av.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataPiece_Av_CellContentClick);
            // 
            // DataPiece_Ap
            // 
            this.DataPiece_Ap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataPiece_Ap.Location = new System.Drawing.Point(603, 308);
            this.DataPiece_Ap.Name = "DataPiece_Ap";
            this.DataPiece_Ap.RowHeadersWidth = 51;
            this.DataPiece_Ap.RowTemplate.Height = 24;
            this.DataPiece_Ap.Size = new System.Drawing.Size(550, 182);
            this.DataPiece_Ap.TabIndex = 55;
            this.DataPiece_Ap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataPiece_Ap_CellContentClick);
            // 
            // Buton_Retour
            // 
            this.Buton_Retour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Buton_Retour.Location = new System.Drawing.Point(1108, 556);
            this.Buton_Retour.Name = "Buton_Retour";
            this.Buton_Retour.Size = new System.Drawing.Size(75, 23);
            this.Buton_Retour.TabIndex = 56;
            this.Buton_Retour.Text = "Retour";
            this.Buton_Retour.UseVisualStyleBackColor = false;
            this.Buton_Retour.Click += new System.EventHandler(this.Buton_Retour_Click);
            // 
            // MAJPiece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1209, 602);
            this.Controls.Add(this.Buton_Retour);
            this.Controls.Add(this.DataPiece_Ap);
            this.Controls.Add(this.DataPiece_Av);
            this.Controls.Add(this.Button_ValiderMAJ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Name = "MAJPiece";
            this.Text = "MAJPiececs";
            this.Load += new System.EventHandler(this.MAJPiece_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPiece_Av)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataPiece_Ap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_ValiderMAJ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ParametreValue;
        private System.Windows.Forms.ComboBox ComboBox_Desc;
        private System.Windows.Forms.ComboBox ComboBox_Parametre;
        private System.Windows.Forms.TextBox NumeroPiece;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DataPiece_Av;
        private System.Windows.Forms.DataGridView DataPiece_Ap;
        private System.Windows.Forms.Button Buton_Retour;
    }
}