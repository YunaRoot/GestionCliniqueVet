namespace IHM
{
    partial class GestionClients
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
            this.buttonAjouterClient = new System.Windows.Forms.Button();
            this.buttonSupprimerClient = new System.Windows.Forms.Button();
            this.buttonRechercherClient = new System.Windows.Forms.Button();
            this.buttonPremierClient = new System.Windows.Forms.Button();
            this.buttonDernierClient = new System.Windows.Forms.Button();
            this.buttonClientPrecedent = new System.Windows.Forms.Button();
            this.buttonClientSuivant = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxAdresse1 = new System.Windows.Forms.TextBox();
            this.textBoxAdresse2 = new System.Windows.Forms.TextBox();
            this.textBoxCodePostal = new System.Windows.Forms.TextBox();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.comboBoxAssurance = new System.Windows.Forms.ComboBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxRemarques = new System.Windows.Forms.TextBox();
            this.dGViewAnimaux = new System.Windows.Forms.DataGridView();
            this.tatouage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomAnimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexeAnimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.couleurAnimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raceAnimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especeAnimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAjoutAnimal = new System.Windows.Forms.Button();
            this.buttonSuppAnimal = new System.Windows.Forms.Button();
            this.buttonEditAnimal = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.textBoxRecherche = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewAnimaux)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAjouterClient
            // 
            this.buttonAjouterClient.Location = new System.Drawing.Point(26, 19);
            this.buttonAjouterClient.Name = "buttonAjouterClient";
            this.buttonAjouterClient.Size = new System.Drawing.Size(72, 61);
            this.buttonAjouterClient.TabIndex = 0;
            this.buttonAjouterClient.Text = "Ajouter";
            this.buttonAjouterClient.UseVisualStyleBackColor = true;
            this.buttonAjouterClient.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonSupprimerClient
            // 
            this.buttonSupprimerClient.Location = new System.Drawing.Point(104, 18);
            this.buttonSupprimerClient.Name = "buttonSupprimerClient";
            this.buttonSupprimerClient.Size = new System.Drawing.Size(73, 62);
            this.buttonSupprimerClient.TabIndex = 1;
            this.buttonSupprimerClient.Text = "Supprimer";
            this.buttonSupprimerClient.UseVisualStyleBackColor = true;
            this.buttonSupprimerClient.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonRechercherClient
            // 
            this.buttonRechercherClient.Location = new System.Drawing.Point(183, 19);
            this.buttonRechercherClient.Name = "buttonRechercherClient";
            this.buttonRechercherClient.Size = new System.Drawing.Size(73, 61);
            this.buttonRechercherClient.TabIndex = 2;
            this.buttonRechercherClient.Text = "Rechercher";
            this.buttonRechercherClient.UseVisualStyleBackColor = true;
            this.buttonRechercherClient.Click += new System.EventHandler(this.buttonRechercher_Click);
            // 
            // buttonPremierClient
            // 
            this.buttonPremierClient.Location = new System.Drawing.Point(403, 18);
            this.buttonPremierClient.Name = "buttonPremierClient";
            this.buttonPremierClient.Size = new System.Drawing.Size(73, 60);
            this.buttonPremierClient.TabIndex = 3;
            this.buttonPremierClient.Text = "Premier";
            this.buttonPremierClient.UseVisualStyleBackColor = true;
            this.buttonPremierClient.Click += new System.EventHandler(this.buttonPremier_Click);
            // 
            // buttonDernierClient
            // 
            this.buttonDernierClient.Location = new System.Drawing.Point(640, 17);
            this.buttonDernierClient.Name = "buttonDernierClient";
            this.buttonDernierClient.Size = new System.Drawing.Size(73, 61);
            this.buttonDernierClient.TabIndex = 4;
            this.buttonDernierClient.Text = "Dernier";
            this.buttonDernierClient.UseVisualStyleBackColor = true;
            this.buttonDernierClient.Click += new System.EventHandler(this.buttonDernierClient_Click);
            // 
            // buttonClientPrecedent
            // 
            this.buttonClientPrecedent.Location = new System.Drawing.Point(482, 17);
            this.buttonClientPrecedent.Name = "buttonClientPrecedent";
            this.buttonClientPrecedent.Size = new System.Drawing.Size(73, 61);
            this.buttonClientPrecedent.TabIndex = 5;
            this.buttonClientPrecedent.Text = "Précédent";
            this.buttonClientPrecedent.UseVisualStyleBackColor = true;
            this.buttonClientPrecedent.Click += new System.EventHandler(this.buttonClientPrecedent_Click);
            // 
            // buttonClientSuivant
            // 
            this.buttonClientSuivant.Location = new System.Drawing.Point(561, 17);
            this.buttonClientSuivant.Name = "buttonClientSuivant";
            this.buttonClientSuivant.Size = new System.Drawing.Size(73, 61);
            this.buttonClientSuivant.TabIndex = 6;
            this.buttonClientSuivant.Text = "Suivant";
            this.buttonClientSuivant.UseVisualStyleBackColor = true;
            this.buttonClientSuivant.Click += new System.EventHandler(this.buttonClientSuivant_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prénom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Code postal :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Adresse :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ville :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Assurance :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "E-Mail :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(471, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tél :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Remarques :";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(104, 121);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(609, 20);
            this.textBoxNom.TabIndex = 16;
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged);
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(104, 148);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(609, 20);
            this.textBoxPrenom.TabIndex = 19;
            this.textBoxPrenom.TextChanged += new System.EventHandler(this.textBoxPrenom_TextChanged);
            // 
            // textBoxAdresse1
            // 
            this.textBoxAdresse1.Location = new System.Drawing.Point(104, 174);
            this.textBoxAdresse1.Name = "textBoxAdresse1";
            this.textBoxAdresse1.Size = new System.Drawing.Size(609, 20);
            this.textBoxAdresse1.TabIndex = 20;
            this.textBoxAdresse1.TextChanged += new System.EventHandler(this.textBoxAdresse1_TextChanged);
            // 
            // textBoxAdresse2
            // 
            this.textBoxAdresse2.Location = new System.Drawing.Point(104, 200);
            this.textBoxAdresse2.Name = "textBoxAdresse2";
            this.textBoxAdresse2.Size = new System.Drawing.Size(609, 20);
            this.textBoxAdresse2.TabIndex = 21;
            this.textBoxAdresse2.TextChanged += new System.EventHandler(this.textBoxAdresse2_TextChanged);
            // 
            // textBoxCodePostal
            // 
            this.textBoxCodePostal.Location = new System.Drawing.Point(104, 226);
            this.textBoxCodePostal.Name = "textBoxCodePostal";
            this.textBoxCodePostal.Size = new System.Drawing.Size(140, 20);
            this.textBoxCodePostal.TabIndex = 22;
            this.textBoxCodePostal.TextChanged += new System.EventHandler(this.textBoxCodePostal_TextChanged);
            // 
            // textBoxVille
            // 
            this.textBoxVille.Location = new System.Drawing.Point(288, 226);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(423, 20);
            this.textBoxVille.TabIndex = 23;
            this.textBoxVille.TextChanged += new System.EventHandler(this.textBoxVille_TextChanged);
            // 
            // comboBoxAssurance
            // 
            this.comboBoxAssurance.FormattingEnabled = true;
            this.comboBoxAssurance.Location = new System.Drawing.Point(104, 252);
            this.comboBoxAssurance.Name = "comboBoxAssurance";
            this.comboBoxAssurance.Size = new System.Drawing.Size(607, 21);
            this.comboBoxAssurance.TabIndex = 24;
            this.comboBoxAssurance.SelectedIndexChanged += new System.EventHandler(this.comboBoxAssurance_SelectedIndexChanged);
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(104, 279);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(361, 20);
            this.textBoxMail.TabIndex = 25;
            this.textBoxMail.TextChanged += new System.EventHandler(this.textBoxMail_TextChanged);
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(505, 279);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(206, 20);
            this.textBoxTel.TabIndex = 26;
            this.textBoxTel.TextChanged += new System.EventHandler(this.textBoxTel_TextChanged);
            // 
            // textBoxRemarques
            // 
            this.textBoxRemarques.Location = new System.Drawing.Point(104, 305);
            this.textBoxRemarques.Multiline = true;
            this.textBoxRemarques.Name = "textBoxRemarques";
            this.textBoxRemarques.Size = new System.Drawing.Size(607, 48);
            this.textBoxRemarques.TabIndex = 27;
            this.textBoxRemarques.TextChanged += new System.EventHandler(this.textBoxRemarques_TextChanged);
            // 
            // dGViewAnimaux
            // 
            this.dGViewAnimaux.AllowUserToAddRows = false;
            this.dGViewAnimaux.AllowUserToDeleteRows = false;
            this.dGViewAnimaux.AllowUserToResizeColumns = false;
            this.dGViewAnimaux.AllowUserToResizeRows = false;
            this.dGViewAnimaux.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGViewAnimaux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGViewAnimaux.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tatouage,
            this.nomAnimal,
            this.sexeAnimal,
            this.couleurAnimal,
            this.raceAnimal,
            this.especeAnimal});
            this.dGViewAnimaux.Location = new System.Drawing.Point(32, 374);
            this.dGViewAnimaux.MultiSelect = false;
            this.dGViewAnimaux.Name = "dGViewAnimaux";
            this.dGViewAnimaux.ReadOnly = true;
            this.dGViewAnimaux.RowHeadersVisible = false;
            this.dGViewAnimaux.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGViewAnimaux.Size = new System.Drawing.Size(681, 153);
            this.dGViewAnimaux.TabIndex = 28;
            // 
            // tatouage
            // 
            this.tatouage.DataPropertyName = "Tatouage";
            this.tatouage.HeaderText = "Tatouage";
            this.tatouage.MaxInputLength = 10;
            this.tatouage.Name = "tatouage";
            this.tatouage.ReadOnly = true;
            // 
            // nomAnimal
            // 
            this.nomAnimal.DataPropertyName = "NomAnimal";
            this.nomAnimal.HeaderText = "Nom";
            this.nomAnimal.MaxInputLength = 30;
            this.nomAnimal.Name = "nomAnimal";
            this.nomAnimal.ReadOnly = true;
            // 
            // sexeAnimal
            // 
            this.sexeAnimal.DataPropertyName = "Sexe";
            this.sexeAnimal.HeaderText = "Sexe";
            this.sexeAnimal.MaxInputLength = 1;
            this.sexeAnimal.Name = "sexeAnimal";
            this.sexeAnimal.ReadOnly = true;
            // 
            // couleurAnimal
            // 
            this.couleurAnimal.DataPropertyName = "Couleur";
            this.couleurAnimal.HeaderText = "Couleur";
            this.couleurAnimal.MaxInputLength = 20;
            this.couleurAnimal.Name = "couleurAnimal";
            this.couleurAnimal.ReadOnly = true;
            // 
            // raceAnimal
            // 
            this.raceAnimal.DataPropertyName = "Race";
            this.raceAnimal.HeaderText = "Race";
            this.raceAnimal.MaxInputLength = 20;
            this.raceAnimal.Name = "raceAnimal";
            this.raceAnimal.ReadOnly = true;
            // 
            // especeAnimal
            // 
            this.especeAnimal.DataPropertyName = "Espece";
            this.especeAnimal.HeaderText = "Espèce";
            this.especeAnimal.MaxInputLength = 20;
            this.especeAnimal.Name = "especeAnimal";
            this.especeAnimal.ReadOnly = true;
            // 
            // buttonAjoutAnimal
            // 
            this.buttonAjoutAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjoutAnimal.Location = new System.Drawing.Point(727, 374);
            this.buttonAjoutAnimal.Name = "buttonAjoutAnimal";
            this.buttonAjoutAnimal.Size = new System.Drawing.Size(56, 47);
            this.buttonAjoutAnimal.TabIndex = 29;
            this.buttonAjoutAnimal.Text = "Ajouter";
            this.buttonAjoutAnimal.UseVisualStyleBackColor = true;
            this.buttonAjoutAnimal.Click += new System.EventHandler(this.buttonAjoutAnimal_Click);
            // 
            // buttonSuppAnimal
            // 
            this.buttonSuppAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuppAnimal.Location = new System.Drawing.Point(727, 427);
            this.buttonSuppAnimal.Name = "buttonSuppAnimal";
            this.buttonSuppAnimal.Size = new System.Drawing.Size(56, 47);
            this.buttonSuppAnimal.TabIndex = 30;
            this.buttonSuppAnimal.Text = "Supprimer";
            this.buttonSuppAnimal.UseVisualStyleBackColor = true;
            this.buttonSuppAnimal.Click += new System.EventHandler(this.buttonSuppAnimal_Click);
            // 
            // buttonEditAnimal
            // 
            this.buttonEditAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditAnimal.Location = new System.Drawing.Point(727, 480);
            this.buttonEditAnimal.Name = "buttonEditAnimal";
            this.buttonEditAnimal.Size = new System.Drawing.Size(56, 47);
            this.buttonEditAnimal.TabIndex = 31;
            this.buttonEditAnimal.Text = "Editer";
            this.buttonEditAnimal.UseVisualStyleBackColor = true;
            this.buttonEditAnimal.Click += new System.EventHandler(this.buttonEditAnimal_Click);
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(555, 543);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 32;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(636, 543);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 33;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // textBoxRecherche
            // 
            this.textBoxRecherche.Location = new System.Drawing.Point(262, 38);
            this.textBoxRecherche.MaxLength = 20;
            this.textBoxRecherche.MinimumSize = new System.Drawing.Size(4, 30);
            this.textBoxRecherche.Name = "textBoxRecherche";
            this.textBoxRecherche.Size = new System.Drawing.Size(100, 20);
            this.textBoxRecherche.TabIndex = 34;
            this.textBoxRecherche.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxRecherche_KeyUp);
            // 
            // GestionClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 601);
            this.Controls.Add(this.textBoxRecherche);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.buttonEditAnimal);
            this.Controls.Add(this.buttonSuppAnimal);
            this.Controls.Add(this.buttonAjoutAnimal);
            this.Controls.Add(this.dGViewAnimaux);
            this.Controls.Add(this.textBoxRemarques);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.comboBoxAssurance);
            this.Controls.Add(this.textBoxVille);
            this.Controls.Add(this.textBoxCodePostal);
            this.Controls.Add(this.textBoxAdresse2);
            this.Controls.Add(this.textBoxAdresse1);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClientSuivant);
            this.Controls.Add(this.buttonClientPrecedent);
            this.Controls.Add(this.buttonDernierClient);
            this.Controls.Add(this.buttonPremierClient);
            this.Controls.Add(this.buttonRechercherClient);
            this.Controls.Add(this.buttonSupprimerClient);
            this.Controls.Add(this.buttonAjouterClient);
            this.Name = "GestionClients";
            this.Text = "GestionClients";
            this.Load += new System.EventHandler(this.GestionClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGViewAnimaux)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAjouterClient;
        private System.Windows.Forms.Button buttonSupprimerClient;
        private System.Windows.Forms.Button buttonRechercherClient;
        private System.Windows.Forms.Button buttonPremierClient;
        private System.Windows.Forms.Button buttonDernierClient;
        private System.Windows.Forms.Button buttonClientPrecedent;
        private System.Windows.Forms.Button buttonClientSuivant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxAdresse1;
        private System.Windows.Forms.TextBox textBoxAdresse2;
        private System.Windows.Forms.TextBox textBoxCodePostal;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.ComboBox comboBoxAssurance;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxRemarques;
        private System.Windows.Forms.DataGridView dGViewAnimaux;
        private System.Windows.Forms.Button buttonAjoutAnimal;
        private System.Windows.Forms.Button buttonSuppAnimal;
        private System.Windows.Forms.Button buttonEditAnimal;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.TextBox textBoxRecherche;
        private System.Windows.Forms.DataGridViewTextBoxColumn tatouage;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomAnimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexeAnimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn couleurAnimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn raceAnimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn especeAnimal;
    }
}