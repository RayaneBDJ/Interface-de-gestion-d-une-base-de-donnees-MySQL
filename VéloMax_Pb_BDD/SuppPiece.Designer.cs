namespace VéloMax_Pb_BDD
{
    partial class SuppPiece
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuppPiece));
            this.label5 = new System.Windows.Forms.Label();
            this.Button_ValiderSuppPiece = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Buton_Retour = new System.Windows.Forms.Button();
            this.DataPiece_Ap = new System.Windows.Forms.DataGridView();
            this.DataPiece_Av = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumPiece = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPiece_Ap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataPiece_Av)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 29);
            this.label5.TabIndex = 43;
            this.label5.Text = "Suppression/Piece";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Button_ValiderSuppPiece
            // 
            this.Button_ValiderSuppPiece.BackColor = System.Drawing.Color.Lime;
            this.Button_ValiderSuppPiece.Location = new System.Drawing.Point(199, 295);
            this.Button_ValiderSuppPiece.Name = "Button_ValiderSuppPiece";
            this.Button_ValiderSuppPiece.Size = new System.Drawing.Size(158, 43);
            this.Button_ValiderSuppPiece.TabIndex = 42;
            this.Button_ValiderSuppPiece.Text = "Valider la suppression de a pièce choisie \r\n\r\n";
            this.Button_ValiderSuppPiece.UseVisualStyleBackColor = false;
            this.Button_ValiderSuppPiece.Click += new System.EventHandler(this.Button_ValiderSuppPiece_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NumPiece);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(133, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 100);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Caractéristiques à remplir";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
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
            // Buton_Retour
            // 
            this.Buton_Retour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Buton_Retour.Location = new System.Drawing.Point(1232, 593);
            this.Buton_Retour.Name = "Buton_Retour";
            this.Buton_Retour.Size = new System.Drawing.Size(75, 23);
            this.Buton_Retour.TabIndex = 46;
            this.Buton_Retour.Text = "Retour";
            this.Buton_Retour.UseVisualStyleBackColor = false;
            this.Buton_Retour.Click += new System.EventHandler(this.Buton_Retour_Click);
            // 
            // DataPiece_Ap
            // 
            this.DataPiece_Ap.AllowUserToAddRows = false;
            this.DataPiece_Ap.AllowUserToDeleteRows = false;
            this.DataPiece_Ap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataPiece_Ap.Location = new System.Drawing.Point(676, 295);
            this.DataPiece_Ap.Name = "DataPiece_Ap";
            this.DataPiece_Ap.ReadOnly = true;
            this.DataPiece_Ap.RowHeadersWidth = 51;
            this.DataPiece_Ap.RowTemplate.Height = 24;
            this.DataPiece_Ap.Size = new System.Drawing.Size(550, 182);
            this.DataPiece_Ap.TabIndex = 50;
            this.DataPiece_Ap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataPiece_Ap_CellContentClick);
            // 
            // DataPiece_Av
            // 
            this.DataPiece_Av.AllowUserToAddRows = false;
            this.DataPiece_Av.AllowUserToDeleteRows = false;
            this.DataPiece_Av.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataPiece_Av.Location = new System.Drawing.Point(676, 37);
            this.DataPiece_Av.Name = "DataPiece_Av";
            this.DataPiece_Av.ReadOnly = true;
            this.DataPiece_Av.RowHeadersWidth = 51;
            this.DataPiece_Av.RowTemplate.Height = 24;
            this.DataPiece_Av.Size = new System.Drawing.Size(550, 183);
            this.DataPiece_Av.TabIndex = 49;
            this.DataPiece_Av.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataPiece_Av_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(851, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "La DataSet après la suppression ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(799, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Selectionnez la ligne que vous voulez supprimez";
            // 
            // NumPiece
            // 
            this.NumPiece.Location = new System.Drawing.Point(124, 43);
            this.NumPiece.Name = "NumPiece";
            this.NumPiece.Size = new System.Drawing.Size(100, 22);
            this.NumPiece.TabIndex = 22;
            // 
            // SuppPiece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 661);
            this.Controls.Add(this.DataPiece_Ap);
            this.Controls.Add(this.DataPiece_Av);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Buton_Retour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Button_ValiderSuppPiece);
            this.Controls.Add(this.groupBox2);
            this.Name = "SuppPiece";
            this.Text = "SuppPiece";
            this.Load += new System.EventHandler(this.SuppPiece_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPiece_Ap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataPiece_Av)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Button_ValiderSuppPiece;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Buton_Retour;
        private System.Windows.Forms.DataGridView DataPiece_Ap;
        private System.Windows.Forms.DataGridView DataPiece_Av;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumPiece;
    }
}