namespace IHM
{
    partial class GestionAnimaux
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionAnimaux));
            this.buttonDossierMedical = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.labelDossierMedical = new System.Windows.Forms.Label();
            this.labelValider = new System.Windows.Forms.Label();
            this.labelSupprimer = new System.Windows.Forms.Label();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.groupBoxClient = new System.Windows.Forms.GroupBox();
            this.textBoxClient = new System.Windows.Forms.TextBox();
            this.labelCode = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelCouleur = new System.Windows.Forms.Label();
            this.labelEspece = new System.Windows.Forms.Label();
            this.labelTatouage = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxCouleur = new System.Windows.Forms.TextBox();
            this.textBoxTatouage = new System.Windows.Forms.TextBox();
            this.comboBoxEspece = new System.Windows.Forms.ComboBox();
            this.comboBoxRace = new System.Windows.Forms.ComboBox();
            this.comboBoxSexe = new System.Windows.Forms.ComboBox();
            this.labelRace = new System.Windows.Forms.Label();
            this.groupBoxMenu.SuspendLayout();
            this.groupBoxClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDossierMedical
            // 
            this.buttonDossierMedical.Image = ((System.Drawing.Image)(resources.GetObject("buttonDossierMedical.Image")));
            this.buttonDossierMedical.Location = new System.Drawing.Point(32, 19);
            this.buttonDossierMedical.Name = "buttonDossierMedical";
            this.buttonDossierMedical.Size = new System.Drawing.Size(59, 63);
            this.buttonDossierMedical.TabIndex = 0;
            this.buttonDossierMedical.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDossierMedical.UseVisualStyleBackColor = true;
            this.buttonDossierMedical.Click += new System.EventHandler(this.buttonDossierMedical_Click);
            // 
            // buttonValider
            // 
            this.buttonValider.BackColor = System.Drawing.Color.Transparent;
            this.buttonValider.ForeColor = System.Drawing.Color.Transparent;
            //*********************************************************************
            //*********************************************************************
            //                   IMAGES RESSOURCES
            //*********************************************************************
            //*********************************************************************
            //this.buttonValider.Image = global::IHM.Properties.Resources.valider;
            this.buttonValider.Location = new System.Drawing.Point(296, 19);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(60, 63);
            this.buttonValider.TabIndex = 1;
            this.buttonValider.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonValider.UseVisualStyleBackColor = false;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonSupprimer
            // 
            //*********************************************************************
            //*********************************************************************
            //                   IMAGES RESSOURCES
            //*********************************************************************
            //*********************************************************************
            //this.buttonSupprimer.Image = global::IHM.Properties.Resources.supprimer;
            this.buttonSupprimer.Location = new System.Drawing.Point(397, 19);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(59, 63);
            this.buttonSupprimer.TabIndex = 2;
            this.buttonSupprimer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // labelDossierMedical
            // 
            this.labelDossierMedical.AutoSize = true;
            this.labelDossierMedical.Location = new System.Drawing.Point(29, 85);
            this.labelDossierMedical.Name = "labelDossierMedical";
            this.labelDossierMedical.Size = new System.Drawing.Size(82, 13);
            this.labelDossierMedical.TabIndex = 3;
            this.labelDossierMedical.Text = "Dossier Médical";
            // 
            // labelValider
            // 
            this.labelValider.AutoSize = true;
            this.labelValider.Location = new System.Drawing.Point(293, 85);
            this.labelValider.Name = "labelValider";
            this.labelValider.Size = new System.Drawing.Size(39, 13);
            this.labelValider.TabIndex = 4;
            this.labelValider.Text = "Valider";
            // 
            // labelSupprimer
            // 
            this.labelSupprimer.AutoSize = true;
            this.labelSupprimer.Location = new System.Drawing.Point(402, 85);
            this.labelSupprimer.Name = "labelSupprimer";
            this.labelSupprimer.Size = new System.Drawing.Size(54, 13);
            this.labelSupprimer.TabIndex = 5;
            this.labelSupprimer.Text = "Supprimer";
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.buttonDossierMedical);
            this.groupBoxMenu.Controls.Add(this.labelSupprimer);
            this.groupBoxMenu.Controls.Add(this.labelDossierMedical);
            this.groupBoxMenu.Controls.Add(this.buttonSupprimer);
            this.groupBoxMenu.Controls.Add(this.labelValider);
            this.groupBoxMenu.Controls.Add(this.buttonValider);
            this.groupBoxMenu.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(477, 112);
            this.groupBoxMenu.TabIndex = 6;
            this.groupBoxMenu.TabStop = false;
            // 
            // groupBoxClient
            // 
            this.groupBoxClient.Controls.Add(this.textBoxClient);
            this.groupBoxClient.Location = new System.Drawing.Point(12, 141);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Size = new System.Drawing.Size(477, 53);
            this.groupBoxClient.TabIndex = 7;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "Client :";
            // 
            // textBoxClient
            // 
            this.textBoxClient.Location = new System.Drawing.Point(7, 20);
            this.textBoxClient.Name = "textBoxClient";
            this.textBoxClient.ReadOnly = true;
            this.textBoxClient.Size = new System.Drawing.Size(464, 20);
            this.textBoxClient.TabIndex = 0;
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(26, 233);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(32, 13);
            this.labelCode.TabIndex = 8;
            this.labelCode.Text = "Code";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(26, 291);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 9;
            this.labelNom.Text = "Nom";
            // 
            // labelCouleur
            // 
            this.labelCouleur.AutoSize = true;
            this.labelCouleur.Location = new System.Drawing.Point(26, 335);
            this.labelCouleur.Name = "labelCouleur";
            this.labelCouleur.Size = new System.Drawing.Size(43, 13);
            this.labelCouleur.TabIndex = 10;
            this.labelCouleur.Text = "Couleur";
            // 
            // labelEspece
            // 
            this.labelEspece.AutoSize = true;
            this.labelEspece.Location = new System.Drawing.Point(29, 396);
            this.labelEspece.Name = "labelEspece";
            this.labelEspece.Size = new System.Drawing.Size(43, 13);
            this.labelEspece.TabIndex = 11;
            this.labelEspece.Text = "Espèce";
            // 
            // labelTatouage
            // 
            this.labelTatouage.AutoSize = true;
            this.labelTatouage.Location = new System.Drawing.Point(32, 445);
            this.labelTatouage.Name = "labelTatouage";
            this.labelTatouage.Size = new System.Drawing.Size(53, 13);
            this.labelTatouage.TabIndex = 12;
            this.labelTatouage.Text = "Tatouage";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(116, 233);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.ReadOnly = true;
            this.textBoxCode.Size = new System.Drawing.Size(213, 20);
            this.textBoxCode.TabIndex = 13;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(116, 291);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(213, 20);
            this.textBoxNom.TabIndex = 14;
            // 
            // textBoxCouleur
            // 
            this.textBoxCouleur.Location = new System.Drawing.Point(116, 335);
            this.textBoxCouleur.Name = "textBoxCouleur";
            this.textBoxCouleur.Size = new System.Drawing.Size(213, 20);
            this.textBoxCouleur.TabIndex = 15;
            // 
            // textBoxTatouage
            // 
            this.textBoxTatouage.Location = new System.Drawing.Point(116, 442);
            this.textBoxTatouage.Name = "textBoxTatouage";
            this.textBoxTatouage.Size = new System.Drawing.Size(213, 20);
            this.textBoxTatouage.TabIndex = 16;
            // 
            // comboBoxEspece
            // 
            this.comboBoxEspece.FormattingEnabled = true;
            this.comboBoxEspece.Location = new System.Drawing.Point(116, 396);
            this.comboBoxEspece.Name = "comboBoxEspece";
            this.comboBoxEspece.Size = new System.Drawing.Size(76, 21);
            this.comboBoxEspece.TabIndex = 17;
            // 
            // comboBoxRace
            // 
            this.comboBoxRace.FormattingEnabled = true;
            this.comboBoxRace.Location = new System.Drawing.Point(308, 396);
            this.comboBoxRace.Name = "comboBoxRace";
            this.comboBoxRace.Size = new System.Drawing.Size(75, 21);
            this.comboBoxRace.TabIndex = 18;
            // 
            // comboBoxSexe
            // 
            this.comboBoxSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSexe.FormattingEnabled = true;
            this.comboBoxSexe.Location = new System.Drawing.Point(356, 291);
            this.comboBoxSexe.Name = "comboBoxSexe";
            this.comboBoxSexe.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSexe.TabIndex = 19;
            // 
            // labelRace
            // 
            this.labelRace.AutoSize = true;
            this.labelRace.Location = new System.Drawing.Point(257, 396);
            this.labelRace.Name = "labelRace";
            this.labelRace.Size = new System.Drawing.Size(33, 13);
            this.labelRace.TabIndex = 21;
            this.labelRace.Text = "Race";
            // 
            // GestionAnimaux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 493);
            this.Controls.Add(this.labelRace);
            this.Controls.Add(this.comboBoxSexe);
            this.Controls.Add(this.comboBoxRace);
            this.Controls.Add(this.comboBoxEspece);
            this.Controls.Add(this.textBoxTatouage);
            this.Controls.Add(this.textBoxCouleur);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.labelTatouage);
            this.Controls.Add(this.labelEspece);
            this.Controls.Add(this.labelCouleur);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.groupBoxClient);
            this.Controls.Add(this.groupBoxMenu);
            this.Name = "GestionAnimaux";
            this.Text = "Animaux";
            this.Load += new System.EventHandler(this.GestionAnimaux_Load);
            this.groupBoxMenu.ResumeLayout(false);
            this.groupBoxMenu.PerformLayout();
            this.groupBoxClient.ResumeLayout(false);
            this.groupBoxClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Label labelDossierMedical;
        private System.Windows.Forms.Label labelValider;
        private System.Windows.Forms.Label labelSupprimer;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.GroupBox groupBoxClient;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelCouleur;
        private System.Windows.Forms.Label labelEspece;
        private System.Windows.Forms.Label labelTatouage;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxCouleur;
        private System.Windows.Forms.TextBox textBoxTatouage;
        private System.Windows.Forms.ComboBox comboBoxEspece;
        private System.Windows.Forms.ComboBox comboBoxRace;
        private System.Windows.Forms.ComboBox comboBoxSexe;
        private System.Windows.Forms.Label labelRace;
        private System.Windows.Forms.TextBox textBoxClient;
        private System.Windows.Forms.Button buttonDossierMedical;
        private System.Windows.Forms.Button buttonValider;
    }
}