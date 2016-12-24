namespace IHM
{
    partial class DossierMedical
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
            this.btRecherche = new System.Windows.Forms.Button();
            this.tbProprietaire = new System.Windows.Forms.TextBox();
            this.tbNomAnimal = new System.Windows.Forms.TextBox();
            this.tbTatouage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbFicheMedical = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btRecherche
            // 
            this.btRecherche.Location = new System.Drawing.Point(301, 26);
            this.btRecherche.Name = "btRecherche";
            this.btRecherche.Size = new System.Drawing.Size(118, 103);
            this.btRecherche.TabIndex = 0;
            this.btRecherche.Text = "Rechercher";
            this.btRecherche.UseVisualStyleBackColor = true;
            this.btRecherche.Click += new System.EventHandler(this.btRecherche_Click);
            // 
            // tbProprietaire
            // 
            this.tbProprietaire.Location = new System.Drawing.Point(101, 30);
            this.tbProprietaire.Name = "tbProprietaire";
            this.tbProprietaire.Size = new System.Drawing.Size(164, 20);
            this.tbProprietaire.TabIndex = 1;
            this.tbProprietaire.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbProprietaire_KeyUp);
            // 
            // tbNomAnimal
            // 
            this.tbNomAnimal.Location = new System.Drawing.Point(101, 68);
            this.tbNomAnimal.Name = "tbNomAnimal";
            this.tbNomAnimal.Size = new System.Drawing.Size(164, 20);
            this.tbNomAnimal.TabIndex = 2;
            this.tbNomAnimal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbNomAnimal_KeyUp);
            // 
            // tbTatouage
            // 
            this.tbTatouage.Location = new System.Drawing.Point(101, 103);
            this.tbTatouage.Name = "tbTatouage";
            this.tbTatouage.Size = new System.Drawing.Size(164, 20);
            this.tbTatouage.TabIndex = 3;
            this.tbTatouage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbTatouage_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Propriétaire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom de l\'animal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tatouage";
            // 
            // rtbFicheMedical
            // 
            this.rtbFicheMedical.Location = new System.Drawing.Point(17, 149);
            this.rtbFicheMedical.Name = "rtbFicheMedical";
            this.rtbFicheMedical.Size = new System.Drawing.Size(402, 310);
            this.rtbFicheMedical.TabIndex = 7;
            this.rtbFicheMedical.Text = "";
            // 
            // DossierMedical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 481);
            this.Controls.Add(this.rtbFicheMedical);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTatouage);
            this.Controls.Add(this.tbNomAnimal);
            this.Controls.Add(this.tbProprietaire);
            this.Controls.Add(this.btRecherche);
            this.Name = "DossierMedical";
            this.Text = "Dossier médical";
            this.Load += new System.EventHandler(this.DossierMedical_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRecherche;
        private System.Windows.Forms.TextBox tbProprietaire;
        private System.Windows.Forms.TextBox tbNomAnimal;
        private System.Windows.Forms.TextBox tbTatouage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbFicheMedical;
    }
}