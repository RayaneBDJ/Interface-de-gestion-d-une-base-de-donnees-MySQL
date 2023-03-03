namespace VéloMax_Pb_BDD
{
    partial class SuppCommande
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
            this.DataComm_Ap = new System.Windows.Forms.DataGridView();
            this.DataCommand_Av = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Buton_Retour = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Button_ValiderSuppComm = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NumCommande = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataComm_Ap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataCommand_Av)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataComm_Ap
            // 
            this.DataComm_Ap.AllowUserToAddRows = false;
            this.DataComm_Ap.AllowUserToDeleteRows = false;
            this.DataComm_Ap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataComm_Ap.Location = new System.Drawing.Point(579, 277);
            this.DataComm_Ap.Name = "DataComm_Ap";
            this.DataComm_Ap.ReadOnly = true;
            this.DataComm_Ap.RowHeadersWidth = 51;
            this.DataComm_Ap.RowTemplate.Height = 24;
            this.DataComm_Ap.Size = new System.Drawing.Size(550, 182);
            this.DataComm_Ap.TabIndex = 58;
            this.DataComm_Ap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataComm_Ap_CellContentClick);
            // 
            // DataCommand_Av
            // 
            this.DataCommand_Av.AllowUserToAddRows = false;
            this.DataCommand_Av.AllowUserToDeleteRows = false;
            this.DataCommand_Av.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataCommand_Av.Location = new System.Drawing.Point(579, 19);
            this.DataCommand_Av.Name = "DataCommand_Av";
            this.DataCommand_Av.ReadOnly = true;
            this.DataCommand_Av.RowHeadersWidth = 51;
            this.DataCommand_Av.RowTemplate.Height = 24;
            this.DataCommand_Av.Size = new System.Drawing.Size(550, 183);
            this.DataCommand_Av.TabIndex = 57;
            this.DataCommand_Av.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataCommand_Av_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(754, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 16);
            this.label1.TabIndex = 56;
            this.label1.Text = "La DataSet après la suppression ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(702, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "Selectionnez la ligne que vous voulez supprimez";
            // 
            // Buton_Retour
            // 
            this.Buton_Retour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Buton_Retour.Location = new System.Drawing.Point(1135, 575);
            this.Buton_Retour.Name = "Buton_Retour";
            this.Buton_Retour.Size = new System.Drawing.Size(75, 23);
            this.Buton_Retour.TabIndex = 54;
            this.Buton_Retour.Text = "Retour";
            this.Buton_Retour.UseVisualStyleBackColor = false;
            this.Buton_Retour.Click += new System.EventHandler(this.Buton_Retour_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(301, 29);
            this.label5.TabIndex = 53;
            this.label5.Text = "Suppression/Commande";
            // 
            // Button_ValiderSuppComm
            // 
            this.Button_ValiderSuppComm.BackColor = System.Drawing.Color.Lime;
            this.Button_ValiderSuppComm.Location = new System.Drawing.Point(102, 277);
            this.Button_ValiderSuppComm.Name = "Button_ValiderSuppComm";
            this.Button_ValiderSuppComm.Size = new System.Drawing.Size(158, 43);
            this.Button_ValiderSuppComm.TabIndex = 52;
            this.Button_ValiderSuppComm.Text = "Valider la suppression de la commande\r\n\r\n";
            this.Button_ValiderSuppComm.UseVisualStyleBackColor = false;
            this.Button_ValiderSuppComm.Click += new System.EventHandler(this.Button_ValiderSuppComm_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NumCommande);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(36, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 100);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Caractéristiques à remplir";
            // 
            // NumCommande
            // 
            this.NumCommande.Location = new System.Drawing.Point(124, 43);
            this.NumCommande.Name = "NumCommande";
            this.NumCommande.Size = new System.Drawing.Size(100, 22);
            this.NumCommande.TabIndex = 22;
            this.NumCommande.TextChanged += new System.EventHandler(this.NumCommande_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(37, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "numC";
            // 
            // SuppCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 616);
            this.Controls.Add(this.DataComm_Ap);
            this.Controls.Add(this.DataCommand_Av);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Buton_Retour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Button_ValiderSuppComm);
            this.Controls.Add(this.groupBox2);
            this.Name = "SuppCommande";
            this.Text = "SuppCommandecs";
            this.Load += new System.EventHandler(this.SuppCommande_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DataComm_Ap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataCommand_Av)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataComm_Ap;
        private System.Windows.Forms.DataGridView DataCommand_Av;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Buton_Retour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Button_ValiderSuppComm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox NumCommande;
        private System.Windows.Forms.Label label11;
    }
}