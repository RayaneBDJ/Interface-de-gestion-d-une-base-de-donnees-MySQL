namespace VéloMax_Pb_BDD
{
    partial class DataClient
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DataParticulier = new System.Windows.Forms.GroupBox();
            this.DataBoutique = new System.Windows.Forms.GroupBox();
            this.Button_Retour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.DataParticulier.SuspendLayout();
            this.DataBoutique.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 42);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(881, 252);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(875, 259);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DataParticulier
            // 
            this.DataParticulier.Controls.Add(this.dataGridView1);
            this.DataParticulier.Location = new System.Drawing.Point(12, 12);
            this.DataParticulier.Name = "DataParticulier";
            this.DataParticulier.Size = new System.Drawing.Size(881, 300);
            this.DataParticulier.TabIndex = 3;
            this.DataParticulier.TabStop = false;
            this.DataParticulier.Text = "groupBox1";
            this.DataParticulier.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DataBoutique
            // 
            this.DataBoutique.Controls.Add(this.dataGridView2);
            this.DataBoutique.Location = new System.Drawing.Point(12, 318);
            this.DataBoutique.Name = "DataBoutique";
            this.DataBoutique.Size = new System.Drawing.Size(881, 300);
            this.DataBoutique.TabIndex = 4;
            this.DataBoutique.TabStop = false;
            this.DataBoutique.Text = "groupBox2";
            // 
            // Button_Retour
            // 
            this.Button_Retour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Button_Retour.Location = new System.Drawing.Point(844, 645);
            this.Button_Retour.Name = "Button_Retour";
            this.Button_Retour.Size = new System.Drawing.Size(75, 23);
            this.Button_Retour.TabIndex = 5;
            this.Button_Retour.Text = "Retour";
            this.Button_Retour.UseVisualStyleBackColor = false;
            this.Button_Retour.Click += new System.EventHandler(this.Button_Retour_Click);
            // 
            // DataClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 709);
            this.Controls.Add(this.Button_Retour);
            this.Controls.Add(this.DataBoutique);
            this.Controls.Add(this.DataParticulier);
            this.Name = "DataClient";
            this.Text = "DataClient";
            this.Load += new System.EventHandler(this.DataClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.DataParticulier.ResumeLayout(false);
            this.DataBoutique.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox DataParticulier;
        private System.Windows.Forms.GroupBox DataBoutique;
        private System.Windows.Forms.Button Button_Retour;
    }
}