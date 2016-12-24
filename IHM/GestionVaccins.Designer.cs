namespace IHM
{
    partial class GestionVaccins
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
            this.dataGridViewVaccins = new System.Windows.Forms.DataGridView();
            this.NomVaccin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantiteStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodeValidite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDownAjout = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownSupp = new System.Windows.Forms.NumericUpDown();
            this.comboBoxNomVaccin = new System.Windows.Forms.ComboBox();
            this.buttonValider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVaccins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAjout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSupp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock des vaccins :";
            // 
            // dataGridViewVaccins
            // 
            this.dataGridViewVaccins.AllowUserToAddRows = false;
            this.dataGridViewVaccins.AllowUserToDeleteRows = false;
            this.dataGridViewVaccins.AllowUserToResizeColumns = false;
            this.dataGridViewVaccins.AllowUserToResizeRows = false;
            this.dataGridViewVaccins.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVaccins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVaccins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomVaccin,
            this.QuantiteStock,
            this.PeriodeValidite});
            this.dataGridViewVaccins.Location = new System.Drawing.Point(12, 118);
            this.dataGridViewVaccins.MultiSelect = false;
            this.dataGridViewVaccins.Name = "dataGridViewVaccins";
            this.dataGridViewVaccins.RowHeadersVisible = false;
            this.dataGridViewVaccins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVaccins.Size = new System.Drawing.Size(555, 267);
            this.dataGridViewVaccins.TabIndex = 1;
            // 
            // NomVaccin
            // 
            this.NomVaccin.DataPropertyName = "NomVaccin";
            this.NomVaccin.HeaderText = "Nom";
            this.NomVaccin.Name = "NomVaccin";
            // 
            // QuantiteStock
            // 
            this.QuantiteStock.DataPropertyName = "QuantiteStock";
            this.QuantiteStock.HeaderText = "Quantité";
            this.QuantiteStock.Name = "QuantiteStock";
            // 
            // PeriodeValidite
            // 
            this.PeriodeValidite.DataPropertyName = "PeriodeValidite";
            this.PeriodeValidite.HeaderText = "Validité (en mois)";
            this.PeriodeValidite.Name = "PeriodeValidite";
            // 
            // numericUpDownAjout
            // 
            this.numericUpDownAjout.Location = new System.Drawing.Point(92, 45);
            this.numericUpDownAjout.Name = "numericUpDownAjout";
            this.numericUpDownAjout.Size = new System.Drawing.Size(84, 20);
            this.numericUpDownAjout.TabIndex = 2;
            this.numericUpDownAjout.ValueChanged += new System.EventHandler(this.numericUpDownAjout_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ajouter :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Supprimer :";
            // 
            // numericUpDownSupp
            // 
            this.numericUpDownSupp.Location = new System.Drawing.Point(92, 79);
            this.numericUpDownSupp.Name = "numericUpDownSupp";
            this.numericUpDownSupp.Size = new System.Drawing.Size(84, 20);
            this.numericUpDownSupp.TabIndex = 5;
            this.numericUpDownSupp.ValueChanged += new System.EventHandler(this.numericUpDownSupp_ValueChanged);
            // 
            // comboBoxNomVaccin
            // 
            this.comboBoxNomVaccin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNomVaccin.FormattingEnabled = true;
            this.comboBoxNomVaccin.Location = new System.Drawing.Point(254, 45);
            this.comboBoxNomVaccin.MaxDropDownItems = 50;
            this.comboBoxNomVaccin.Name = "comboBoxNomVaccin";
            this.comboBoxNomVaccin.Size = new System.Drawing.Size(192, 21);
            this.comboBoxNomVaccin.TabIndex = 6;
            this.comboBoxNomVaccin.TabStop = false;
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(371, 76);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 7;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // GestionVaccins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 397);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.comboBoxNomVaccin);
            this.Controls.Add(this.numericUpDownSupp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownAjout);
            this.Controls.Add(this.dataGridViewVaccins);
            this.Controls.Add(this.label1);
            this.Name = "GestionVaccins";
            this.Text = "Vaccins";
            this.Load += new System.EventHandler(this.GestionVaccins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVaccins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAjout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSupp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewVaccins;
        private System.Windows.Forms.NumericUpDown numericUpDownAjout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownSupp;
        private System.Windows.Forms.ComboBox comboBoxNomVaccin;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomVaccin;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantiteStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodeValidite;
    }
}