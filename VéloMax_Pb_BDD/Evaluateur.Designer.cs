namespace VéloMax_Pb_BDD
{
    partial class Evaluateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Evaluateur));
            this.EvalNombreClient = new System.Windows.Forms.Button();
            this.NBR_Clients = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.label20 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Buton_Retour = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // EvalNombreClient
            // 
            this.EvalNombreClient.Location = new System.Drawing.Point(47, 93);
            this.EvalNombreClient.Name = "EvalNombreClient";
            this.EvalNombreClient.Size = new System.Drawing.Size(216, 44);
            this.EvalNombreClient.TabIndex = 0;
            this.EvalNombreClient.Text = "Evaluer le nombre de clients";
            this.EvalNombreClient.UseVisualStyleBackColor = true;
            this.EvalNombreClient.Click += new System.EventHandler(this.EvalNombreClient_Click);
            // 
            // NBR_Clients
            // 
            this.NBR_Clients.Enabled = false;
            this.NBR_Clients.Location = new System.Drawing.Point(370, 104);
            this.NBR_Clients.Name = "NBR_Clients";
            this.NBR_Clients.Size = new System.Drawing.Size(100, 22);
            this.NBR_Clients.TabIndex = 1;
            this.NBR_Clients.TextChanged += new System.EventHandler(this.NBR_Clients_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 146);
            this.button1.TabIndex = 2;
            this.button1.Text = "Faire Apparaître la liste des cliets avec le cumul de toutes leurs commandes ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(302, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(468, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(594, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(115, 25);
            this.label20.TabIndex = 22;
            this.label20.Text = "Evaluateur";
            // 
            // Buton_Retour
            // 
            this.Buton_Retour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Buton_Retour.Location = new System.Drawing.Point(1259, 538);
            this.Buton_Retour.Name = "Buton_Retour";
            this.Buton_Retour.Size = new System.Drawing.Size(75, 23);
            this.Buton_Retour.TabIndex = 40;
            this.Buton_Retour.Text = "Retour";
            this.Buton_Retour.UseVisualStyleBackColor = false;
            this.Buton_Retour.Click += new System.EventHandler(this.Buton_Retour_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 146);
            this.button2.TabIndex = 41;
            this.button2.Text = "Liste des produits dont la quantité est inférieure ou égale à 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(302, 376);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(220, 146);
            this.dataGridView2.TabIndex = 42;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(52, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Cliquer sur les boutons ci-dessous";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(550, 376);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(220, 146);
            this.dataGridView3.TabIndex = 44;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // Evaluateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 674);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Buton_Retour);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NBR_Clients);
            this.Controls.Add(this.EvalNombreClient);
            this.Name = "Evaluateur";
            this.Text = "Evaluateur";
            this.Load += new System.EventHandler(this.Evaluateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EvalNombreClient;
        private System.Windows.Forms.TextBox NBR_Clients;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.Label label20;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Buton_Retour;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}