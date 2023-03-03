namespace VéloMax_Pb_BDD
{
    partial class Fidelio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBox_Fidelio = new System.Windows.Forms.ComboBox();
            this.TypeFidelio = new System.Windows.Forms.TextBox();
            this.DureeFidelio = new System.Windows.Forms.TextBox();
            this.CoutFidelio = new System.Windows.Forms.TextBox();
            this.RabaisFidelio = new System.Windows.Forms.TextBox();
            this.Button_ValiderProgramme = new System.Windows.Forms.Button();
            this.Button_Retour = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(52, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(52, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "numéro du Programme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(52, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "durée";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(52, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "coût";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Location = new System.Drawing.Point(49, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "rabais";
            // 
            // ComboBox_Fidelio
            // 
            this.ComboBox_Fidelio.FormattingEnabled = true;
            this.ComboBox_Fidelio.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.ComboBox_Fidelio.Location = new System.Drawing.Point(263, 63);
            this.ComboBox_Fidelio.Name = "ComboBox_Fidelio";
            this.ComboBox_Fidelio.Size = new System.Drawing.Size(121, 24);
            this.ComboBox_Fidelio.TabIndex = 7;
            this.ComboBox_Fidelio.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Fidelio_SelectedIndexChanged);
            // 
            // TypeFidelio
            // 
            this.TypeFidelio.Location = new System.Drawing.Point(263, 102);
            this.TypeFidelio.Name = "TypeFidelio";
            this.TypeFidelio.Size = new System.Drawing.Size(100, 22);
            this.TypeFidelio.TabIndex = 8;
            // 
            // DureeFidelio
            // 
            this.DureeFidelio.Location = new System.Drawing.Point(263, 145);
            this.DureeFidelio.Name = "DureeFidelio";
            this.DureeFidelio.Size = new System.Drawing.Size(100, 22);
            this.DureeFidelio.TabIndex = 9;
            // 
            // CoutFidelio
            // 
            this.CoutFidelio.Location = new System.Drawing.Point(263, 186);
            this.CoutFidelio.Name = "CoutFidelio";
            this.CoutFidelio.Size = new System.Drawing.Size(100, 22);
            this.CoutFidelio.TabIndex = 10;
            // 
            // RabaisFidelio
            // 
            this.RabaisFidelio.Location = new System.Drawing.Point(263, 222);
            this.RabaisFidelio.Name = "RabaisFidelio";
            this.RabaisFidelio.Size = new System.Drawing.Size(100, 22);
            this.RabaisFidelio.TabIndex = 11;
            // 
            // Button_ValiderProgramme
            // 
            this.Button_ValiderProgramme.BackColor = System.Drawing.Color.Lime;
            this.Button_ValiderProgramme.Location = new System.Drawing.Point(669, 397);
            this.Button_ValiderProgramme.Name = "Button_ValiderProgramme";
            this.Button_ValiderProgramme.Size = new System.Drawing.Size(75, 23);
            this.Button_ValiderProgramme.TabIndex = 12;
            this.Button_ValiderProgramme.Text = "Valider";
            this.Button_ValiderProgramme.UseVisualStyleBackColor = false;
            this.Button_ValiderProgramme.Click += new System.EventHandler(this.Button_ValiderProgramme_Click);
            // 
            // Button_Retour
            // 
            this.Button_Retour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Button_Retour.Location = new System.Drawing.Point(802, 397);
            this.Button_Retour.Name = "Button_Retour";
            this.Button_Retour.Size = new System.Drawing.Size(75, 23);
            this.Button_Retour.TabIndex = 13;
            this.Button_Retour.Text = "Retour";
            this.Button_Retour.UseVisualStyleBackColor = false;
            this.Button_Retour.Click += new System.EventHandler(this.Button_Retour_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(125, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Programme Fidelio";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(428, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(428, 253);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(567, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Programmes disponibles";
            // 
            // Fidelio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 432);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Button_Retour);
            this.Controls.Add(this.Button_ValiderProgramme);
            this.Controls.Add(this.RabaisFidelio);
            this.Controls.Add(this.CoutFidelio);
            this.Controls.Add(this.DureeFidelio);
            this.Controls.Add(this.TypeFidelio);
            this.Controls.Add(this.ComboBox_Fidelio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Fidelio";
            this.Text = "Fideliocs";
            this.Load += new System.EventHandler(this.Fidelio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboBox_Fidelio;
        private System.Windows.Forms.TextBox TypeFidelio;
        private System.Windows.Forms.TextBox DureeFidelio;
        private System.Windows.Forms.TextBox CoutFidelio;
        private System.Windows.Forms.TextBox RabaisFidelio;
        private System.Windows.Forms.Button Button_ValiderProgramme;
        private System.Windows.Forms.Button Button_Retour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
    }
}