namespace VéloMax_Pb_BDD
{
    partial class SuppVelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuppVelo));
            this.Button_ValiderSuppPart = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NumeroVélo = new System.Windows.Forms.TextBox();
            this.NomVélo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DataVélo_Av = new System.Windows.Forms.DataGridView();
            this.DataVélo_Ap = new System.Windows.Forms.DataGridView();
            this.Buton_Retour = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataVélo_Av)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataVélo_Ap)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_ValiderSuppPart
            // 
            this.Button_ValiderSuppPart.BackColor = System.Drawing.Color.Lime;
            this.Button_ValiderSuppPart.Location = new System.Drawing.Point(211, 287);
            this.Button_ValiderSuppPart.Name = "Button_ValiderSuppPart";
            this.Button_ValiderSuppPart.Size = new System.Drawing.Size(158, 43);
            this.Button_ValiderSuppPart.TabIndex = 35;
            this.Button_ValiderSuppPart.Text = "Valider la suppression du vélo\r\n";
            this.Button_ValiderSuppPart.UseVisualStyleBackColor = false;
            this.Button_ValiderSuppPart.Click += new System.EventHandler(this.Button_ValiderSuppPart_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(870, 498);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "La DataSet après la suppression ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(834, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Selectionnez la ligne que vous voulez supprimez";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NumeroVélo);
            this.groupBox2.Controls.Add(this.NomVélo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(145, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 100);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Caractéristiques à remplir";
            // 
            // NumeroVélo
            // 
            this.NumeroVélo.Location = new System.Drawing.Point(124, 40);
            this.NumeroVélo.Name = "NumeroVélo";
            this.NumeroVélo.Size = new System.Drawing.Size(100, 22);
            this.NumeroVélo.TabIndex = 21;
            // 
            // NomVélo
            // 
            this.NomVélo.Location = new System.Drawing.Point(124, 67);
            this.NomVélo.Name = "NomVélo";
            this.NomVélo.Size = new System.Drawing.Size(100, 22);
            this.NomVélo.TabIndex = 20;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 29);
            this.label5.TabIndex = 36;
            this.label5.Text = "Suppression/Velo";
            // 
            // DataVélo_Av
            // 
            this.DataVélo_Av.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataVélo_Av.Location = new System.Drawing.Point(695, 29);
            this.DataVélo_Av.Name = "DataVélo_Av";
            this.DataVélo_Av.RowHeadersWidth = 51;
            this.DataVélo_Av.RowTemplate.Height = 24;
            this.DataVélo_Av.Size = new System.Drawing.Size(550, 183);
            this.DataVélo_Av.TabIndex = 37;
            this.DataVélo_Av.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataVélo_Av_CellContentClick);
            // 
            // DataVélo_Ap
            // 
            this.DataVélo_Ap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataVélo_Ap.Location = new System.Drawing.Point(695, 287);
            this.DataVélo_Ap.Name = "DataVélo_Ap";
            this.DataVélo_Ap.RowHeadersWidth = 51;
            this.DataVélo_Ap.RowTemplate.Height = 24;
            this.DataVélo_Ap.Size = new System.Drawing.Size(550, 182);
            this.DataVélo_Ap.TabIndex = 38;
            this.DataVélo_Ap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataVélo_Ap_CellContentClick);
            // 
            // Buton_Retour
            // 
            this.Buton_Retour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Buton_Retour.Location = new System.Drawing.Point(1246, 581);
            this.Buton_Retour.Name = "Buton_Retour";
            this.Buton_Retour.Size = new System.Drawing.Size(75, 23);
            this.Buton_Retour.TabIndex = 39;
            this.Buton_Retour.Text = "Retour";
            this.Buton_Retour.UseVisualStyleBackColor = false;
            this.Buton_Retour.Click += new System.EventHandler(this.Buton_Retour_Click);
            // 
            // SuppVelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1346, 627);
            this.Controls.Add(this.Buton_Retour);
            this.Controls.Add(this.DataVélo_Ap);
            this.Controls.Add(this.DataVélo_Av);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Button_ValiderSuppPart);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Name = "SuppVelo";
            this.Text = "SuppVelo";
            this.Load += new System.EventHandler(this.SuppVelo_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataVélo_Av)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataVélo_Ap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_ValiderSuppPart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox NumeroVélo;
        private System.Windows.Forms.TextBox NomVélo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DataVélo_Av;
        private System.Windows.Forms.DataGridView DataVélo_Ap;
        private System.Windows.Forms.Button Buton_Retour;
    }
}