namespace IHM
{
    partial class PriseRendezVous
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
            this.groupBoxPour = new System.Windows.Forms.GroupBox();
            this.buttonAjouterAnimal = new System.Windows.Forms.Button();
            this.buttonAjouterClient = new System.Windows.Forms.Button();
            this.LabelAnimal = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.comboBoxAnimal = new System.Windows.Forms.ComboBox();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.groupBoxPar = new System.Windows.Forms.GroupBox();
            this.labelVeterinaire = new System.Windows.Forms.Label();
            this.comboBoxVeterinaire = new System.Windows.Forms.ComboBox();
            this.groupBoxQuand = new System.Windows.Forms.GroupBox();
            this.labelH = new System.Windows.Forms.Label();
            this.labelHeure = new System.Windows.Forms.Label();
            this.comboBoxMinutes = new System.Windows.Forms.ComboBox();
            this.comboBoxHeures = new System.Windows.Forms.ComboBox();
            this.labelUrgence = new System.Windows.Forms.Label();
            this.buttonUrgence = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.dataGridViewPriseRendezVous = new System.Windows.Forms.DataGridView();
            this.heureRdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomAnimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raceAnimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxPour.SuspendLayout();
            this.groupBoxPar.SuspendLayout();
            this.groupBoxQuand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPriseRendezVous)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPour
            // 
            this.groupBoxPour.Controls.Add(this.buttonAjouterAnimal);
            this.groupBoxPour.Controls.Add(this.buttonAjouterClient);
            this.groupBoxPour.Controls.Add(this.LabelAnimal);
            this.groupBoxPour.Controls.Add(this.labelClient);
            this.groupBoxPour.Controls.Add(this.comboBoxAnimal);
            this.groupBoxPour.Controls.Add(this.comboBoxClient);
            this.groupBoxPour.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPour.Name = "groupBoxPour";
            this.groupBoxPour.Size = new System.Drawing.Size(222, 153);
            this.groupBoxPour.TabIndex = 0;
            this.groupBoxPour.TabStop = false;
            this.groupBoxPour.Text = "Pour";
            // 
            // buttonAjouterAnimal
            // 
            this.buttonAjouterAnimal.Location = new System.Drawing.Point(193, 84);
            this.buttonAjouterAnimal.Name = "buttonAjouterAnimal";
            this.buttonAjouterAnimal.Size = new System.Drawing.Size(23, 21);
            this.buttonAjouterAnimal.TabIndex = 7;
            this.buttonAjouterAnimal.Text = "buttonAjouterAnimal";
            this.buttonAjouterAnimal.UseVisualStyleBackColor = true;
            this.buttonAjouterAnimal.Click += new System.EventHandler(this.buttonAjouterAnimal_Click);
            // 
            // buttonAjouterClient
            // 
            this.buttonAjouterClient.Location = new System.Drawing.Point(193, 39);
            this.buttonAjouterClient.Name = "buttonAjouterClient";
            this.buttonAjouterClient.Size = new System.Drawing.Size(23, 21);
            this.buttonAjouterClient.TabIndex = 6;
            this.buttonAjouterClient.Text = "buttonAjouterClient";
            this.buttonAjouterClient.UseVisualStyleBackColor = true;
            this.buttonAjouterClient.Click += new System.EventHandler(this.buttonAjouterClient_Click);
            // 
            // LabelAnimal
            // 
            this.LabelAnimal.AutoSize = true;
            this.LabelAnimal.Location = new System.Drawing.Point(7, 67);
            this.LabelAnimal.Name = "LabelAnimal";
            this.LabelAnimal.Size = new System.Drawing.Size(38, 13);
            this.LabelAnimal.TabIndex = 3;
            this.LabelAnimal.Text = "Animal";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(7, 20);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(33, 13);
            this.labelClient.TabIndex = 2;
            this.labelClient.Text = "Client";
            // 
            // comboBoxAnimal
            // 
            this.comboBoxAnimal.FormattingEnabled = true;
            this.comboBoxAnimal.Location = new System.Drawing.Point(7, 85);
            this.comboBoxAnimal.Name = "comboBoxAnimal";
            this.comboBoxAnimal.Size = new System.Drawing.Size(180, 21);
            this.comboBoxAnimal.TabIndex = 1;
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(7, 39);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(180, 21);
            this.comboBoxClient.TabIndex = 0;
            // 
            // groupBoxPar
            // 
            this.groupBoxPar.Controls.Add(this.labelVeterinaire);
            this.groupBoxPar.Controls.Add(this.comboBoxVeterinaire);
            this.groupBoxPar.Location = new System.Drawing.Point(240, 12);
            this.groupBoxPar.Name = "groupBoxPar";
            this.groupBoxPar.Size = new System.Drawing.Size(222, 153);
            this.groupBoxPar.TabIndex = 1;
            this.groupBoxPar.TabStop = false;
            this.groupBoxPar.Text = "Par";
            // 
            // labelVeterinaire
            // 
            this.labelVeterinaire.AutoSize = true;
            this.labelVeterinaire.Location = new System.Drawing.Point(33, 24);
            this.labelVeterinaire.Name = "labelVeterinaire";
            this.labelVeterinaire.Size = new System.Drawing.Size(57, 13);
            this.labelVeterinaire.TabIndex = 1;
            this.labelVeterinaire.Text = "Vétérinaire";
            // 
            // comboBoxVeterinaire
            // 
            this.comboBoxVeterinaire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVeterinaire.FormattingEnabled = true;
            this.comboBoxVeterinaire.Location = new System.Drawing.Point(36, 40);
            this.comboBoxVeterinaire.Name = "comboBoxVeterinaire";
            this.comboBoxVeterinaire.Size = new System.Drawing.Size(154, 21);
            this.comboBoxVeterinaire.TabIndex = 0;
            // 
            // groupBoxQuand
            // 
            this.groupBoxQuand.Controls.Add(this.labelH);
            this.groupBoxQuand.Controls.Add(this.labelHeure);
            this.groupBoxQuand.Controls.Add(this.comboBoxMinutes);
            this.groupBoxQuand.Controls.Add(this.comboBoxHeures);
            this.groupBoxQuand.Controls.Add(this.labelUrgence);
            this.groupBoxQuand.Controls.Add(this.buttonUrgence);
            this.groupBoxQuand.Controls.Add(this.labelDate);
            this.groupBoxQuand.Controls.Add(this.dateTimePicker1);
            this.groupBoxQuand.Location = new System.Drawing.Point(468, 12);
            this.groupBoxQuand.Name = "groupBoxQuand";
            this.groupBoxQuand.Size = new System.Drawing.Size(222, 153);
            this.groupBoxQuand.TabIndex = 1;
            this.groupBoxQuand.TabStop = false;
            this.groupBoxQuand.Text = "Quand";
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Location = new System.Drawing.Point(73, 113);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(13, 13);
            this.labelH.TabIndex = 7;
            this.labelH.Text = "h";
            // 
            // labelHeure
            // 
            this.labelHeure.AutoSize = true;
            this.labelHeure.Location = new System.Drawing.Point(16, 94);
            this.labelHeure.Name = "labelHeure";
            this.labelHeure.Size = new System.Drawing.Size(36, 13);
            this.labelHeure.TabIndex = 6;
            this.labelHeure.Text = "Heure";
            // 
            // comboBoxMinutes
            // 
            this.comboBoxMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMinutes.FormattingEnabled = true;
            this.comboBoxMinutes.Location = new System.Drawing.Point(92, 110);
            this.comboBoxMinutes.Name = "comboBoxMinutes";
            this.comboBoxMinutes.Size = new System.Drawing.Size(43, 21);
            this.comboBoxMinutes.TabIndex = 5;
            // 
            // comboBoxHeures
            // 
            this.comboBoxHeures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHeures.FormattingEnabled = true;
            this.comboBoxHeures.Location = new System.Drawing.Point(16, 110);
            this.comboBoxHeures.Name = "comboBoxHeures";
            this.comboBoxHeures.Size = new System.Drawing.Size(51, 21);
            this.comboBoxHeures.TabIndex = 4;
            // 
            // labelUrgence
            // 
            this.labelUrgence.AutoSize = true;
            this.labelUrgence.Location = new System.Drawing.Point(167, 134);
            this.labelUrgence.Name = "labelUrgence";
            this.labelUrgence.Size = new System.Drawing.Size(48, 13);
            this.labelUrgence.TabIndex = 3;
            this.labelUrgence.Text = "Urgence";
            // 
            // buttonUrgence
            // 
            this.buttonUrgence.Location = new System.Drawing.Point(167, 85);
            this.buttonUrgence.Name = "buttonUrgence";
            this.buttonUrgence.Size = new System.Drawing.Size(49, 46);
            this.buttonUrgence.TabIndex = 2;
            this.buttonUrgence.Text = "ButtonUrgence";
            this.buttonUrgence.UseVisualStyleBackColor = true;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(13, 25);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(30, 13);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(614, 407);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 3;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(527, 407);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 4;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(435, 407);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(75, 23);
            this.buttonSupprimer.TabIndex = 5;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPriseRendezVous
            // 
            this.dataGridViewPriseRendezVous.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPriseRendezVous.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heureRdv,
            this.nomClient,
            this.nomAnimal,
            this.raceAnimal});
            this.dataGridViewPriseRendezVous.Location = new System.Drawing.Point(19, 171);
            this.dataGridViewPriseRendezVous.Name = "dataGridViewPriseRendezVous";
            this.dataGridViewPriseRendezVous.RowHeadersVisible = false;
            this.dataGridViewPriseRendezVous.Size = new System.Drawing.Size(664, 230);
            this.dataGridViewPriseRendezVous.TabIndex = 6;
            // 
            // heureRdv
            // 
            this.heureRdv.HeaderText = "Heure";
            this.heureRdv.Name = "heureRdv";
            this.heureRdv.Width = 75;
            // 
            // nomClient
            // 
            this.nomClient.HeaderText = "Nom du Client";
            this.nomClient.Name = "nomClient";
            this.nomClient.Width = 280;
            // 
            // nomAnimal
            // 
            this.nomAnimal.HeaderText = "Animal";
            this.nomAnimal.Name = "nomAnimal";
            this.nomAnimal.Width = 200;
            // 
            // raceAnimal
            // 
            this.raceAnimal.HeaderText = "Race";
            this.raceAnimal.Name = "raceAnimal";
            // 
            // PriseRendezVous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 442);
            this.Controls.Add(this.dataGridViewPriseRendezVous);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.groupBoxQuand);
            this.Controls.Add(this.groupBoxPar);
            this.Controls.Add(this.groupBoxPour);
            this.Name = "PriseRendezVous";
            this.Text = "PriseRendezVous";
            this.Load += new System.EventHandler(this.PriseRendezVous_Load);
            this.groupBoxPour.ResumeLayout(false);
            this.groupBoxPour.PerformLayout();
            this.groupBoxPar.ResumeLayout(false);
            this.groupBoxPar.PerformLayout();
            this.groupBoxQuand.ResumeLayout(false);
            this.groupBoxQuand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPriseRendezVous)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPour;
        private System.Windows.Forms.GroupBox groupBoxPar;
        private System.Windows.Forms.GroupBox groupBoxQuand;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.Label labelHeure;
        private System.Windows.Forms.ComboBox comboBoxMinutes;
        private System.Windows.Forms.ComboBox comboBoxHeures;
        private System.Windows.Forms.Label labelUrgence;
        private System.Windows.Forms.Button buttonUrgence;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonAjouterAnimal;
        private System.Windows.Forms.Button buttonAjouterClient;
        private System.Windows.Forms.Label LabelAnimal;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.ComboBox comboBoxAnimal;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Label labelVeterinaire;
        private System.Windows.Forms.ComboBox comboBoxVeterinaire;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.DataGridView dataGridViewPriseRendezVous;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureRdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomAnimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn raceAnimal;
    }
}