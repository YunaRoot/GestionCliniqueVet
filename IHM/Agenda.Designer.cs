namespace IHM
{
    partial class Agenda
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
            this.dataGridViewAgenda = new System.Windows.Forms.DataGridView();
            this.buttonDossierMedical = new System.Windows.Forms.Button();
            this.groupBoxAgenda = new System.Windows.Forms.GroupBox();
            this.comboBoxVeto = new System.Windows.Forms.ComboBox();
            this.labelVeterinaire = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.heureRdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomAnimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raceAnimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgenda)).BeginInit();
            this.groupBoxAgenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewAgenda
            // 
            this.dataGridViewAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heureRdv,
            this.nomClient,
            this.nomAnimal,
            this.raceAnimal});
            this.dataGridViewAgenda.Location = new System.Drawing.Point(13, 99);
            this.dataGridViewAgenda.Name = "dataGridViewAgenda";
            this.dataGridViewAgenda.Size = new System.Drawing.Size(626, 338);
            this.dataGridViewAgenda.TabIndex = 0;
            // 
            // buttonDossierMedical
            // 
            this.buttonDossierMedical.Location = new System.Drawing.Point(548, 443);
            this.buttonDossierMedical.Name = "buttonDossierMedical";
            this.buttonDossierMedical.Size = new System.Drawing.Size(91, 67);
            this.buttonDossierMedical.TabIndex = 1;
            this.buttonDossierMedical.Text = "Dossier médical";
            this.buttonDossierMedical.UseVisualStyleBackColor = true;
            this.buttonDossierMedical.Click += new System.EventHandler(this.buttonDossierMedicale_Click);
            // 
            // groupBoxAgenda
            // 
            this.groupBoxAgenda.Controls.Add(this.comboBoxVeto);
            this.groupBoxAgenda.Controls.Add(this.labelVeterinaire);
            this.groupBoxAgenda.Controls.Add(this.labelDate);
            this.groupBoxAgenda.Controls.Add(this.dateTimePicker);
            this.groupBoxAgenda.Location = new System.Drawing.Point(13, 12);
            this.groupBoxAgenda.Name = "groupBoxAgenda";
            this.groupBoxAgenda.Size = new System.Drawing.Size(626, 81);
            this.groupBoxAgenda.TabIndex = 2;
            this.groupBoxAgenda.TabStop = false;
            this.groupBoxAgenda.Text = "De";
            // 
            // comboBoxVeto
            // 
            this.comboBoxVeto.FormattingEnabled = true;
            this.comboBoxVeto.Location = new System.Drawing.Point(87, 39);
            this.comboBoxVeto.Name = "comboBoxVeto";
            this.comboBoxVeto.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVeto.TabIndex = 3;
            // 
            // labelVeterinaire
            // 
            this.labelVeterinaire.AutoSize = true;
            this.labelVeterinaire.Location = new System.Drawing.Point(24, 42);
            this.labelVeterinaire.Name = "labelVeterinaire";
            this.labelVeterinaire.Size = new System.Drawing.Size(57, 13);
            this.labelVeterinaire.TabIndex = 2;
            this.labelVeterinaire.Text = "Vétérinaire";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(275, 42);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(30, 13);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Date";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(311, 40);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(178, 20);
            this.dateTimePicker.TabIndex = 0;
            // 
            // heureRdv
            // 
            this.heureRdv.HeaderText = "Heure";
            this.heureRdv.Name = "heureRdv";
            // 
            // nomClient
            // 
            this.nomClient.HeaderText = "Nom du Client";
            this.nomClient.Name = "nomClient";
            // 
            // nomAnimal
            // 
            this.nomAnimal.HeaderText = "Animal";
            this.nomAnimal.Name = "nomAnimal";
            // 
            // raceAnimal
            // 
            this.raceAnimal.HeaderText = "Race";
            this.raceAnimal.Name = "raceAnimal";
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 522);
            this.Controls.Add(this.groupBoxAgenda);
            this.Controls.Add(this.buttonDossierMedical);
            this.Controls.Add(this.dataGridViewAgenda);
            this.Name = "Agenda";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Agenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgenda)).EndInit();
            this.groupBoxAgenda.ResumeLayout(false);
            this.groupBoxAgenda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAgenda;
        private System.Windows.Forms.Button buttonDossierMedical;
        private System.Windows.Forms.GroupBox groupBoxAgenda;
        private System.Windows.Forms.ComboBox comboBoxVeto;
        private System.Windows.Forms.Label labelVeterinaire;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureRdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomAnimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn raceAnimal;
    }
}