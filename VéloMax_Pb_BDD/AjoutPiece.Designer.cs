namespace VéloMax_Pb_BDD
{
    partial class AjoutPiece
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
            this.Button_Retour = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.Button_ValiderAjoutPièce = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.quantité_pièce = new System.Windows.Forms.TextBox();
            this.ComboBoxDesc = new System.Windows.Forms.ComboBox();
            this.DateFinP = new System.Windows.Forms.TextBox();
            this.NumPièce = new System.Windows.Forms.TextBox();
            this.DateDébutP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NomV = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_Retour
            // 
            this.Button_Retour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Button_Retour.Location = new System.Drawing.Point(656, 482);
            this.Button_Retour.Name = "Button_Retour";
            this.Button_Retour.Size = new System.Drawing.Size(75, 23);
            this.Button_Retour.TabIndex = 29;
            this.Button_Retour.Text = "Retour";
            this.Button_Retour.UseVisualStyleBackColor = false;
            this.Button_Retour.Click += new System.EventHandler(this.Button_Retour_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(531, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(263, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(123, 25);
            this.label20.TabIndex = 27;
            this.label20.Text = "Ajout/Piece";
            // 
            // Button_ValiderAjoutPièce
            // 
            this.Button_ValiderAjoutPièce.BackColor = System.Drawing.Color.Lime;
            this.Button_ValiderAjoutPièce.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_ValiderAjoutPièce.Location = new System.Drawing.Point(263, 371);
            this.Button_ValiderAjoutPièce.Name = "Button_ValiderAjoutPièce";
            this.Button_ValiderAjoutPièce.Size = new System.Drawing.Size(123, 40);
            this.Button_ValiderAjoutPièce.TabIndex = 26;
            this.Button_ValiderAjoutPièce.Text = "Valider l\'ajout de la pièce\r\n";
            this.Button_ValiderAjoutPièce.UseVisualStyleBackColor = false;
            this.Button_ValiderAjoutPièce.Click += new System.EventHandler(this.Button_ValiderAjoutPièce_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.quantité_pièce);
            this.groupBox1.Controls.Add(this.ComboBoxDesc);
            this.groupBox1.Controls.Add(this.DateFinP);
            this.groupBox1.Controls.Add(this.NumPièce);
            this.groupBox1.Controls.Add(this.DateDébutP);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.NomV);
            this.groupBox1.Location = new System.Drawing.Point(138, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 300);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caractéristiques à remplir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(39, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Quantité";
            // 
            // quantité_pièce
            // 
            this.quantité_pièce.Location = new System.Drawing.Point(247, 258);
            this.quantité_pièce.Name = "quantité_pièce";
            this.quantité_pièce.Size = new System.Drawing.Size(100, 22);
            this.quantité_pièce.TabIndex = 31;
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
            this.ComboBoxDesc.Location = new System.Drawing.Point(226, 113);
            this.ComboBoxDesc.Name = "ComboBoxDesc";
            this.ComboBoxDesc.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxDesc.TabIndex = 20;
            // 
            // DateFinP
            // 
            this.DateFinP.Location = new System.Drawing.Point(247, 212);
            this.DateFinP.Name = "DateFinP";
            this.DateFinP.Size = new System.Drawing.Size(100, 22);
            this.DateFinP.TabIndex = 18;
            this.DateFinP.Text = "month/day/year";
            // 
            // NumPièce
            // 
            this.NumPièce.Location = new System.Drawing.Point(247, 68);
            this.NumPièce.Name = "NumPièce";
            this.NumPièce.Size = new System.Drawing.Size(100, 22);
            this.NumPièce.TabIndex = 16;
            // 
            // DateDébutP
            // 
            this.DateDébutP.Location = new System.Drawing.Point(247, 163);
            this.DateDébutP.Name = "DateDébutP";
            this.DateDébutP.Size = new System.Drawing.Size(100, 22);
            this.DateDébutP.TabIndex = 15;
            this.DateDébutP.Text = "month/day/year";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(39, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "date_fin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(39, 163);
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
            this.label7.Size = new System.Drawing.Size(145, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Description de la pièce";
            // 
            // NomV
            // 
            this.NomV.AutoSize = true;
            this.NomV.BackColor = System.Drawing.Color.Silver;
            this.NomV.Location = new System.Drawing.Point(39, 74);
            this.NomV.Name = "NomV";
            this.NomV.Size = new System.Drawing.Size(125, 16);
            this.NomV.TabIndex = 5;
            this.NomV.Text = "Numero de la pièce";
            // 
            // AjoutPiece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 535);
            this.Controls.Add(this.Button_Retour);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.Button_ValiderAjoutPièce);
            this.Controls.Add(this.groupBox1);
            this.Name = "AjoutPiece";
            this.Text = "AjoutPiece";
            this.Load += new System.EventHandler(this.AjoutPiece_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Retour;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button Button_ValiderAjoutPièce;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ComboBoxDesc;
        private System.Windows.Forms.TextBox DateFinP;
        private System.Windows.Forms.TextBox NumPièce;
        private System.Windows.Forms.TextBox DateDébutP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label NomV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantité_pièce;
    }
}