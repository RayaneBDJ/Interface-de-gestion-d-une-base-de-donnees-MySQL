namespace VéloMax_Pb_BDD
{
    partial class SuppClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuppClient));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NomParticulier = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DataParticulier_Av = new System.Windows.Forms.DataGridView();
            this.DataBoutique_Av = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NomBoutique = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DataParticulier_Ap = new System.Windows.Forms.DataGridView();
            this.DataBoutique_Ap = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PrenomParticulier = new System.Windows.Forms.TextBox();
            this.Button_retour = new System.Windows.Forms.Button();
            this.Button_ValiderSuppPart = new System.Windows.Forms.Button();
            this.Button_ValiderSuppBoutique = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataParticulier_Av)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBoutique_Av)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataParticulier_Ap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBoutique_Ap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
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
            this.label1.TabIndex = 1;
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
            this.label2.TabIndex = 2;
            this.label2.Text = "Boutique";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(37, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "prénom";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PrenomParticulier);
            this.groupBox2.Controls.Add(this.NomParticulier);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(50, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Caractéristiques à remplir";
            // 
            // NomParticulier
            // 
            this.NomParticulier.Location = new System.Drawing.Point(124, 43);
            this.NomParticulier.Name = "NomParticulier";
            this.NomParticulier.Size = new System.Drawing.Size(100, 22);
            this.NomParticulier.TabIndex = 20;
            this.NomParticulier.TextChanged += new System.EventHandler(this.NomParticulier_TextChanged);
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
            // DataParticulier_Av
            // 
            this.DataParticulier_Av.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataParticulier_Av.Location = new System.Drawing.Point(12, 231);
            this.DataParticulier_Av.Name = "DataParticulier_Av";
            this.DataParticulier_Av.RowHeadersWidth = 51;
            this.DataParticulier_Av.RowTemplate.Height = 24;
            this.DataParticulier_Av.Size = new System.Drawing.Size(550, 150);
            this.DataParticulier_Av.TabIndex = 8;
            this.DataParticulier_Av.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataParticulier_Av_CellContentClick);
            // 
            // DataBoutique_Av
            // 
            this.DataBoutique_Av.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBoutique_Av.Location = new System.Drawing.Point(753, 230);
            this.DataBoutique_Av.Name = "DataBoutique_Av";
            this.DataBoutique_Av.RowHeadersWidth = 51;
            this.DataBoutique_Av.RowTemplate.Height = 24;
            this.DataBoutique_Av.Size = new System.Drawing.Size(550, 150);
            this.DataBoutique_Av.TabIndex = 9;
            this.DataBoutique_Av.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataBoutique_Av_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NomBoutique);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(793, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 100);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caractéristiques à remplir";
            // 
            // NomBoutique
            // 
            this.NomBoutique.Location = new System.Drawing.Point(124, 43);
            this.NomBoutique.Name = "NomBoutique";
            this.NomBoutique.Size = new System.Drawing.Size(100, 22);
            this.NomBoutique.TabIndex = 20;
            this.NomBoutique.TextChanged += new System.EventHandler(this.NomBoutique_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(37, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "nom";
            // 
            // DataParticulier_Ap
            // 
            this.DataParticulier_Ap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataParticulier_Ap.Location = new System.Drawing.Point(12, 448);
            this.DataParticulier_Ap.Name = "DataParticulier_Ap";
            this.DataParticulier_Ap.RowHeadersWidth = 51;
            this.DataParticulier_Ap.RowTemplate.Height = 24;
            this.DataParticulier_Ap.Size = new System.Drawing.Size(550, 150);
            this.DataParticulier_Ap.TabIndex = 22;
            this.DataParticulier_Ap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataParticulier_Ap_CellContentClick);
            // 
            // DataBoutique_Ap
            // 
            this.DataBoutique_Ap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBoutique_Ap.Location = new System.Drawing.Point(753, 448);
            this.DataBoutique_Ap.Name = "DataBoutique_Ap";
            this.DataBoutique_Ap.RowHeadersWidth = 51;
            this.DataBoutique_Ap.RowTemplate.Height = 24;
            this.DataBoutique_Ap.Size = new System.Drawing.Size(550, 150);
            this.DataBoutique_Ap.TabIndex = 23;
            this.DataBoutique_Ap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataBoutique_Ap_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(144, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Selectionnez la ligne que vous voulez supprimez";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(893, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(295, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Selectionnez la ligne que vous voulez supprimez";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(185, 601);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "La DataSet après la suppression ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(931, 601);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(206, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "La DataSet après la suppression ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // PrenomParticulier
            // 
            this.PrenomParticulier.Location = new System.Drawing.Point(124, 72);
            this.PrenomParticulier.Name = "PrenomParticulier";
            this.PrenomParticulier.Size = new System.Drawing.Size(100, 22);
            this.PrenomParticulier.TabIndex = 21;
            this.PrenomParticulier.TextChanged += new System.EventHandler(this.PrenomParticulier_TextChanged);
            // 
            // Button_retour
            // 
            this.Button_retour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Button_retour.Location = new System.Drawing.Point(1249, 40);
            this.Button_retour.Name = "Button_retour";
            this.Button_retour.Size = new System.Drawing.Size(75, 23);
            this.Button_retour.TabIndex = 28;
            this.Button_retour.Text = "Retour";
            this.Button_retour.UseVisualStyleBackColor = false;
            this.Button_retour.Click += new System.EventHandler(this.Button_retour_Click);
            // 
            // Button_ValiderSuppPart
            // 
            this.Button_ValiderSuppPart.BackColor = System.Drawing.Color.Lime;
            this.Button_ValiderSuppPart.Location = new System.Drawing.Point(364, 145);
            this.Button_ValiderSuppPart.Name = "Button_ValiderSuppPart";
            this.Button_ValiderSuppPart.Size = new System.Drawing.Size(158, 43);
            this.Button_ValiderSuppPart.TabIndex = 29;
            this.Button_ValiderSuppPart.Text = "Valider la suppression du particulier";
            this.Button_ValiderSuppPart.UseVisualStyleBackColor = false;
            this.Button_ValiderSuppPart.Click += new System.EventHandler(this.Button_ValiderSuppPart_Click);
            // 
            // Button_ValiderSuppBoutique
            // 
            this.Button_ValiderSuppBoutique.BackColor = System.Drawing.Color.Lime;
            this.Button_ValiderSuppBoutique.Location = new System.Drawing.Point(1104, 145);
            this.Button_ValiderSuppBoutique.Name = "Button_ValiderSuppBoutique";
            this.Button_ValiderSuppBoutique.Size = new System.Drawing.Size(155, 43);
            this.Button_ValiderSuppBoutique.TabIndex = 30;
            this.Button_ValiderSuppBoutique.Text = "Valider la suppression de la boutique";
            this.Button_ValiderSuppBoutique.UseVisualStyleBackColor = false;
            this.Button_ValiderSuppBoutique.Click += new System.EventHandler(this.Button_ValiderSuppBoutique_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(519, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 29);
            this.label5.TabIndex = 31;
            this.label5.Text = "Suppression/Client";
            // 
            // SuppClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1363, 736);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Button_ValiderSuppBoutique);
            this.Controls.Add(this.Button_ValiderSuppPart);
            this.Controls.Add(this.Button_retour);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DataBoutique_Ap);
            this.Controls.Add(this.DataParticulier_Ap);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DataBoutique_Av);
            this.Controls.Add(this.DataParticulier_Av);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SuppClient";
            this.Text = "SuppClient";
            this.Load += new System.EventHandler(this.SuppClient_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataParticulier_Av)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBoutique_Av)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataParticulier_Ap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBoutique_Ap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox NomParticulier;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DataParticulier_Av;
        private System.Windows.Forms.DataGridView DataBoutique_Av;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NomBoutique;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DataParticulier_Ap;
        private System.Windows.Forms.DataGridView DataBoutique_Ap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PrenomParticulier;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button Button_retour;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Button_ValiderSuppBoutique;
        private System.Windows.Forms.Button Button_ValiderSuppPart;
        private System.Windows.Forms.Label label5;
    }
}