namespace VéloMax_Pb_BDD
{
    partial class MajFournisseur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MajFournisseur));
            this.Data_Ap = new System.Windows.Forms.DataGridView();
            this.DataP_Av = new System.Windows.Forms.DataGridView();
            this.Button_ValiderMAJ = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ParametreValue = new System.Windows.Forms.TextBox();
            this.ComboBox_Parametre = new System.Windows.Forms.ComboBox();
            this.NumeroFournisseur = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Ap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataP_Av)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Data_Ap
            // 
            this.Data_Ap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_Ap.Location = new System.Drawing.Point(590, 315);
            this.Data_Ap.Name = "Data_Ap";
            this.Data_Ap.RowHeadersWidth = 51;
            this.Data_Ap.RowTemplate.Height = 24;
            this.Data_Ap.Size = new System.Drawing.Size(550, 182);
            this.Data_Ap.TabIndex = 62;
            // 
            // DataP_Av
            // 
            this.DataP_Av.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataP_Av.Location = new System.Drawing.Point(590, 47);
            this.DataP_Av.Name = "DataP_Av";
            this.DataP_Av.RowHeadersWidth = 51;
            this.DataP_Av.RowTemplate.Height = 24;
            this.DataP_Av.Size = new System.Drawing.Size(550, 182);
            this.DataP_Av.TabIndex = 61;
            this.DataP_Av.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataP_Av_CellContentClick);
            // 
            // Button_ValiderMAJ
            // 
            this.Button_ValiderMAJ.BackColor = System.Drawing.Color.Lime;
            this.Button_ValiderMAJ.Location = new System.Drawing.Point(106, 471);
            this.Button_ValiderMAJ.Name = "Button_ValiderMAJ";
            this.Button_ValiderMAJ.Size = new System.Drawing.Size(158, 43);
            this.Button_ValiderMAJ.TabIndex = 60;
            this.Button_ValiderMAJ.Text = "Valider la mise à jour du fournisseur\r\n\r\n\r\n";
            this.Button_ValiderMAJ.UseVisualStyleBackColor = false;
            this.Button_ValiderMAJ.Click += new System.EventHandler(this.Button_ValiderMAJ_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 29);
            this.label5.TabIndex = 59;
            this.label5.Text = "MAJFournisseur";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(765, 516);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 16);
            this.label8.TabIndex = 58;
            this.label8.Text = "La DataSet après la mise à jour\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(699, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 16);
            this.label3.TabIndex = 57;
            this.label3.Text = "(Cliquez) Selectionnez la ligne que vous voulez mettre à jour";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.ComboBox_Parametre);
            this.groupBox2.Controls.Add(this.NumeroFournisseur);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(40, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 306);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Caractéristiques à remplir";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ParametreValue);
            this.groupBox1.Location = new System.Drawing.Point(147, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 126);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choisis";
            // 
            // ParametreValue
            // 
            this.ParametreValue.Location = new System.Drawing.Point(21, 54);
            this.ParametreValue.Name = "ParametreValue";
            this.ParametreValue.Size = new System.Drawing.Size(100, 22);
            this.ParametreValue.TabIndex = 51;
            // 
            // ComboBox_Parametre
            // 
            this.ComboBox_Parametre.FormattingEnabled = true;
            this.ComboBox_Parametre.Items.AddRange(new object[] {
            "nomF",
            "contact",
            "adresse",
            "ville",
            "libelle"});
            this.ComboBox_Parametre.Location = new System.Drawing.Point(0, 169);
            this.ComboBox_Parametre.Name = "ComboBox_Parametre";
            this.ComboBox_Parametre.Size = new System.Drawing.Size(121, 24);
            this.ComboBox_Parametre.TabIndex = 46;
            this.ComboBox_Parametre.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Parametre_SelectedIndexChanged);
            // 
            // NumeroFournisseur
            // 
            this.NumeroFournisseur.Location = new System.Drawing.Point(124, 40);
            this.NumeroFournisseur.Name = "NumeroFournisseur";
            this.NumeroFournisseur.Size = new System.Drawing.Size(100, 22);
            this.NumeroFournisseur.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(37, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "numF";
            // 
            // MajFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1276, 629);
            this.Controls.Add(this.Data_Ap);
            this.Controls.Add(this.DataP_Av);
            this.Controls.Add(this.Button_ValiderMAJ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Name = "MajFournisseur";
            this.Text = "MajFournisseur";
            this.Load += new System.EventHandler(this.MajFournisseur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_Ap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataP_Av)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Data_Ap;
        private System.Windows.Forms.DataGridView DataP_Av;
        private System.Windows.Forms.Button Button_ValiderMAJ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ParametreValue;
        private System.Windows.Forms.ComboBox ComboBox_Parametre;
        private System.Windows.Forms.TextBox NumeroFournisseur;
        private System.Windows.Forms.Label label11;
    }
}