namespace IHM
{
    partial class GestionVeterinaire
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btAjouterVet = new System.Windows.Forms.Button();
            this.btSupprimerVet = new System.Windows.Forms.Button();
            this.btReinitialiser = new System.Windows.Forms.Button();
            this.dgVetos = new System.Windows.Forms.DataGridView();
            this.NomVet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVetos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btReinitialiser);
            this.groupBox1.Controls.Add(this.btSupprimerVet);
            this.groupBox1.Controls.Add(this.btAjouterVet);
            this.groupBox1.Location = new System.Drawing.Point(34, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btAjouterVet
            // 
            this.btAjouterVet.Location = new System.Drawing.Point(25, 19);
            this.btAjouterVet.Name = "btAjouterVet";
            this.btAjouterVet.Size = new System.Drawing.Size(83, 71);
            this.btAjouterVet.TabIndex = 0;
            this.btAjouterVet.Text = "Ajouter";
            this.btAjouterVet.UseVisualStyleBackColor = true;
            this.btAjouterVet.Click += new System.EventHandler(this.btAjouterVet_Click);
            // 
            // btSupprimerVet
            // 
            this.btSupprimerVet.Location = new System.Drawing.Point(133, 19);
            this.btSupprimerVet.Name = "btSupprimerVet";
            this.btSupprimerVet.Size = new System.Drawing.Size(83, 71);
            this.btSupprimerVet.TabIndex = 1;
            this.btSupprimerVet.Text = "Supprimer";
            this.btSupprimerVet.UseVisualStyleBackColor = true;
            this.btSupprimerVet.Click += new System.EventHandler(this.btSupprimerVet_Click);
            // 
            // btReinitialiser
            // 
            this.btReinitialiser.Location = new System.Drawing.Point(241, 19);
            this.btReinitialiser.Name = "btReinitialiser";
            this.btReinitialiser.Size = new System.Drawing.Size(83, 71);
            this.btReinitialiser.TabIndex = 2;
            this.btReinitialiser.Text = "Modifier mot de passe";
            this.btReinitialiser.UseVisualStyleBackColor = true;
            this.btReinitialiser.Click += new System.EventHandler(this.btReinitialiser_Click);
            // 
            // dgVetos
            // 
            this.dgVetos.AllowUserToAddRows = false;
            this.dgVetos.AllowUserToDeleteRows = false;
            this.dgVetos.AllowUserToResizeColumns = false;
            this.dgVetos.AllowUserToResizeRows = false;
            this.dgVetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVetos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomVet});
            this.dgVetos.Location = new System.Drawing.Point(38, 168);
            this.dgVetos.Name = "dgVetos";
            this.dgVetos.ReadOnly = true;
            this.dgVetos.RowHeadersVisible = false;
            this.dgVetos.Size = new System.Drawing.Size(565, 270);
            this.dgVetos.TabIndex = 1;
            // 
            // NomVet
            // 
            this.NomVet.DataPropertyName = "NomVeto";
            this.NomVet.HeaderText = "Nom Prenom";
            this.NomVet.Name = "NomVet";
            this.NomVet.ReadOnly = true;
            // 
            // GestionVeterinaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 462);
            this.Controls.Add(this.dgVetos);
            this.Controls.Add(this.groupBox1);
            this.Name = "GestionVeterinaire";
            this.Text = "GestionVeterinaire";
            this.Load += new System.EventHandler(this.GestionVeterinaire_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVetos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btReinitialiser;
        private System.Windows.Forms.Button btSupprimerVet;
        private System.Windows.Forms.Button btAjouterVet;
        private System.Windows.Forms.DataGridView dgVetos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomVet;
    }
}