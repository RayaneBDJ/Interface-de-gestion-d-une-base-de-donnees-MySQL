namespace VéloMax_Pb_BDD
{
    partial class MAJClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAJClient));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Button_ValiderSuppBoutique = new System.Windows.Forms.Button();
            this.Button_retour = new System.Windows.Forms.Button();
            this.DataParticulier_Av = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NomParticulier = new System.Windows.Forms.TextBox();
            this.NomBoutique = new System.Windows.Forms.TextBox();
            this.ParametreValueBoutique = new System.Windows.Forms.TextBox();
            this.DataParticulier_Ap = new System.Windows.Forms.DataGridView();
            this.DataBoutique_Av = new System.Windows.Forms.DataGridView();
            this.DataBoutique_Ap = new System.Windows.Forms.DataGridView();
            this.NomPart = new System.Windows.Forms.Label();
            this.PrenomParticulier = new System.Windows.Forms.Label();
            this.PrenomPart = new System.Windows.Forms.TextBox();
            this.ComBox_Particulier = new System.Windows.Forms.ComboBox();
            this.ParametreValuePart = new System.Windows.Forms.TextBox();
            this.ComBox_Boutique = new System.Windows.Forms.ComboBox();
            this.Button_ValiderMAJPart = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataParticulier_Av)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataParticulier_Ap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBoutique_Av)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBoutique_Ap)).BeginInit();
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
            this.label1.TabIndex = 2;
            this.label1.Text = "Particulier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(850, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Boutique";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ParametreValuePart);
            this.groupBox2.Controls.Add(this.ComBox_Particulier);
            this.groupBox2.Controls.Add(this.PrenomPart);
            this.groupBox2.Controls.Add(this.PrenomParticulier);
            this.groupBox2.Controls.Add(this.NomPart);
            this.groupBox2.Controls.Add(this.NomParticulier);
            this.groupBox2.Location = new System.Drawing.Point(50, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 205);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choisir la caractéristique à mettre à jour";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ComBox_Boutique);
            this.groupBox1.Controls.Add(this.ParametreValueBoutique);
            this.groupBox1.Controls.Add(this.NomBoutique);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(766, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 193);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choisir la caractéristique à mettre à jour";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(99, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "nom";
            // 
            // Button_ValiderSuppBoutique
            // 
            this.Button_ValiderSuppBoutique.BackColor = System.Drawing.Color.Lime;
            this.Button_ValiderSuppBoutique.Location = new System.Drawing.Point(1145, 59);
            this.Button_ValiderSuppBoutique.Name = "Button_ValiderSuppBoutique";
            this.Button_ValiderSuppBoutique.Size = new System.Drawing.Size(155, 43);
            this.Button_ValiderSuppBoutique.TabIndex = 31;
            this.Button_ValiderSuppBoutique.Text = "Valider la mise à jour de la boutique";
            this.Button_ValiderSuppBoutique.UseVisualStyleBackColor = false;
            this.Button_ValiderSuppBoutique.Click += new System.EventHandler(this.Button_ValiderSuppBoutique_Click);
            // 
            // Button_retour
            // 
            this.Button_retour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Button_retour.Location = new System.Drawing.Point(1259, 12);
            this.Button_retour.Name = "Button_retour";
            this.Button_retour.Size = new System.Drawing.Size(75, 23);
            this.Button_retour.TabIndex = 32;
            this.Button_retour.Text = "Retour";
            this.Button_retour.UseVisualStyleBackColor = false;
            this.Button_retour.Click += new System.EventHandler(this.Button_retour_Click);
            // 
            // DataParticulier_Av
            // 
            this.DataParticulier_Av.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataParticulier_Av.Location = new System.Drawing.Point(32, 326);
            this.DataParticulier_Av.Name = "DataParticulier_Av";
            this.DataParticulier_Av.RowHeadersWidth = 51;
            this.DataParticulier_Av.RowTemplate.Height = 24;
            this.DataParticulier_Av.Size = new System.Drawing.Size(550, 150);
            this.DataParticulier_Av.TabIndex = 33;
            this.DataParticulier_Av.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataParticulier_Av_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(152, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Selectionnez la ligne que vous voulez modifiez";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(205, 704);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "La DataSet après la mise à jour";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(607, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 29);
            this.label5.TabIndex = 39;
            this.label5.Text = "MAJ/Client";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(887, 490);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(283, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "Selectionnez la ligne que vous voulez modifiez";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(932, 704);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "La DataSet après la mise à jour";
            // 
            // NomParticulier
            // 
            this.NomParticulier.Location = new System.Drawing.Point(271, 34);
            this.NomParticulier.Name = "NomParticulier";
            this.NomParticulier.Size = new System.Drawing.Size(100, 22);
            this.NomParticulier.TabIndex = 53;
            this.NomParticulier.TextChanged += new System.EventHandler(this.NomParticulier_TextChanged);
            // 
            // NomBoutique
            // 
            this.NomBoutique.Location = new System.Drawing.Point(206, 37);
            this.NomBoutique.Name = "NomBoutique";
            this.NomBoutique.Size = new System.Drawing.Size(100, 22);
            this.NomBoutique.TabIndex = 62;
            // 
            // ParametreValueBoutique
            // 
            this.ParametreValueBoutique.Location = new System.Drawing.Point(206, 102);
            this.ParametreValueBoutique.Name = "ParametreValueBoutique";
            this.ParametreValueBoutique.Size = new System.Drawing.Size(100, 22);
            this.ParametreValueBoutique.TabIndex = 66;
            // 
            // DataParticulier_Ap
            // 
            this.DataParticulier_Ap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataParticulier_Ap.Location = new System.Drawing.Point(32, 540);
            this.DataParticulier_Ap.Name = "DataParticulier_Ap";
            this.DataParticulier_Ap.RowHeadersWidth = 51;
            this.DataParticulier_Ap.RowTemplate.Height = 24;
            this.DataParticulier_Ap.Size = new System.Drawing.Size(550, 150);
            this.DataParticulier_Ap.TabIndex = 42;
            this.DataParticulier_Ap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataParticulier_Ap_CellContentClick);
            // 
            // DataBoutique_Av
            // 
            this.DataBoutique_Av.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBoutique_Av.Location = new System.Drawing.Point(750, 326);
            this.DataBoutique_Av.Name = "DataBoutique_Av";
            this.DataBoutique_Av.RowHeadersWidth = 51;
            this.DataBoutique_Av.RowTemplate.Height = 24;
            this.DataBoutique_Av.Size = new System.Drawing.Size(550, 150);
            this.DataBoutique_Av.TabIndex = 43;
            this.DataBoutique_Av.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataBoutique_Av_CellContentClick);
            // 
            // DataBoutique_Ap
            // 
            this.DataBoutique_Ap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBoutique_Ap.Location = new System.Drawing.Point(750, 540);
            this.DataBoutique_Ap.Name = "DataBoutique_Ap";
            this.DataBoutique_Ap.RowHeadersWidth = 51;
            this.DataBoutique_Ap.RowTemplate.Height = 24;
            this.DataBoutique_Ap.Size = new System.Drawing.Size(550, 150);
            this.DataBoutique_Ap.TabIndex = 44;
            this.DataBoutique_Ap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataBoutique_Ap_CellContentClick);
            // 
            // NomPart
            // 
            this.NomPart.AutoSize = true;
            this.NomPart.BackColor = System.Drawing.Color.Silver;
            this.NomPart.Location = new System.Drawing.Point(205, 37);
            this.NomPart.Name = "NomPart";
            this.NomPart.Size = new System.Drawing.Size(33, 16);
            this.NomPart.TabIndex = 54;
            this.NomPart.Text = "nom";
            // 
            // PrenomParticulier
            // 
            this.PrenomParticulier.AutoSize = true;
            this.PrenomParticulier.BackColor = System.Drawing.Color.Silver;
            this.PrenomParticulier.Location = new System.Drawing.Point(185, 66);
            this.PrenomParticulier.Name = "PrenomParticulier";
            this.PrenomParticulier.Size = new System.Drawing.Size(53, 16);
            this.PrenomParticulier.TabIndex = 67;
            this.PrenomParticulier.Text = "prenom";
            // 
            // PrenomPart
            // 
            this.PrenomPart.Location = new System.Drawing.Point(271, 67);
            this.PrenomPart.Name = "PrenomPart";
            this.PrenomPart.Size = new System.Drawing.Size(100, 22);
            this.PrenomPart.TabIndex = 67;
            // 
            // ComBox_Particulier
            // 
            this.ComBox_Particulier.FormattingEnabled = true;
            this.ComBox_Particulier.Items.AddRange(new object[] {
            "ville",
            "rue",
            "codeP",
            "province",
            "numTel",
            "courriel",
            "numF"});
            this.ComBox_Particulier.Location = new System.Drawing.Point(117, 102);
            this.ComBox_Particulier.Name = "ComBox_Particulier";
            this.ComBox_Particulier.Size = new System.Drawing.Size(121, 24);
            this.ComBox_Particulier.TabIndex = 68;
            // 
            // ParametreValuePart
            // 
            this.ParametreValuePart.Location = new System.Drawing.Point(271, 104);
            this.ParametreValuePart.Name = "ParametreValuePart";
            this.ParametreValuePart.Size = new System.Drawing.Size(100, 22);
            this.ParametreValuePart.TabIndex = 69;
            this.ParametreValuePart.TextChanged += new System.EventHandler(this.ParametreValuePart_TextChanged);
            // 
            // ComBox_Boutique
            // 
            this.ComBox_Boutique.FormattingEnabled = true;
            this.ComBox_Boutique.Items.AddRange(new object[] {
            "ville",
            "rue",
            "codeP",
            "province",
            "numéro de téléphone",
            "courriel",
            "nomContact",
            "remise"});
            this.ComBox_Boutique.Location = new System.Drawing.Point(57, 100);
            this.ComBox_Boutique.Name = "ComBox_Boutique";
            this.ComBox_Boutique.Size = new System.Drawing.Size(121, 24);
            this.ComBox_Boutique.TabIndex = 70;
            this.ComBox_Boutique.SelectedIndexChanged += new System.EventHandler(this.ComBox_Boutique_SelectedIndexChanged);
            // 
            // Button_ValiderMAJPart
            // 
            this.Button_ValiderMAJPart.BackColor = System.Drawing.Color.Lime;
            this.Button_ValiderMAJPart.Location = new System.Drawing.Point(424, 50);
            this.Button_ValiderMAJPart.Name = "Button_ValiderMAJPart";
            this.Button_ValiderMAJPart.Size = new System.Drawing.Size(158, 43);
            this.Button_ValiderMAJPart.TabIndex = 45;
            this.Button_ValiderMAJPart.Text = "Valider la mise à jour du particulier";
            this.Button_ValiderMAJPart.UseVisualStyleBackColor = false;
            this.Button_ValiderMAJPart.Click += new System.EventHandler(this.Button_ValiderMAJPart_Click);
            // 
            // MAJClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 747);
            this.Controls.Add(this.Button_ValiderMAJPart);
            this.Controls.Add(this.DataBoutique_Ap);
            this.Controls.Add(this.DataBoutique_Av);
            this.Controls.Add(this.DataParticulier_Ap);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DataParticulier_Av);
            this.Controls.Add(this.Button_retour);
            this.Controls.Add(this.Button_ValiderSuppBoutique);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MAJClient";
            this.Text = "MAJClientcs";
            this.Load += new System.EventHandler(this.MAJClient_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataParticulier_Av)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataParticulier_Ap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBoutique_Av)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBoutique_Ap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Button_ValiderSuppBoutique;
        private System.Windows.Forms.Button Button_retour;
        private System.Windows.Forms.DataGridView DataParticulier_Av;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NomParticulier;
        private System.Windows.Forms.TextBox ParametreValueBoutique;
        private System.Windows.Forms.TextBox NomBoutique;
        private System.Windows.Forms.DataGridView DataParticulier_Ap;
        private System.Windows.Forms.DataGridView DataBoutique_Av;
        private System.Windows.Forms.DataGridView DataBoutique_Ap;
        private System.Windows.Forms.TextBox ParametreValuePart;
        private System.Windows.Forms.ComboBox ComBox_Particulier;
        private System.Windows.Forms.TextBox PrenomPart;
        private System.Windows.Forms.Label PrenomParticulier;
        private System.Windows.Forms.Label NomPart;
        private System.Windows.Forms.ComboBox ComBox_Boutique;
        private System.Windows.Forms.Button Button_ValiderMAJPart;
    }
}