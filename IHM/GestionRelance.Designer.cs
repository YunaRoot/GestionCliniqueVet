namespace IHM
{
    partial class GestionRelances
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
            this.dataGridViewRelances = new System.Windows.Forms.DataGridView();
            this.client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateValidite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelances)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relances";
            // 
            // dataGridViewRelances
            // 
            this.dataGridViewRelances.AllowUserToAddRows = false;
            this.dataGridViewRelances.AllowUserToDeleteRows = false;
            this.dataGridViewRelances.AllowUserToResizeColumns = false;
            this.dataGridViewRelances.AllowUserToResizeRows = false;
            this.dataGridViewRelances.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRelances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRelances.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.client,
            this.animal,
            this.dateValidite});
            this.dataGridViewRelances.Location = new System.Drawing.Point(13, 47);
            this.dataGridViewRelances.MultiSelect = false;
            this.dataGridViewRelances.Name = "dataGridViewRelances";
            this.dataGridViewRelances.RowHeadersVisible = false;
            this.dataGridViewRelances.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRelances.Size = new System.Drawing.Size(463, 313);
            this.dataGridViewRelances.TabIndex = 1;
            // 
            // client
            // 
            this.client.DataPropertyName = "client";
            this.client.HeaderText = "Client";
            this.client.Name = "client";
            // 
            // animal
            // 
            this.animal.DataPropertyName = "animal";
            this.animal.HeaderText = "Animal";
            this.animal.Name = "animal";
            // 
            // dateValidite
            // 
            this.dateValidite.DataPropertyName = "dateFinValidite";
            this.dateValidite.HeaderText = "Fin de validité";
            this.dateValidite.Name = "dateValidite";
            // 
            // GestionRelances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 384);
            this.Controls.Add(this.dataGridViewRelances);
            this.Controls.Add(this.label1);
            this.Name = "GestionRelances";
            this.Text = "Relances";
            this.Load += new System.EventHandler(this.GestionRelances_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelances)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewRelances;
        private System.Windows.Forms.DataGridViewTextBoxColumn client;
        private System.Windows.Forms.DataGridViewTextBoxColumn animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateValidite;
    }
}