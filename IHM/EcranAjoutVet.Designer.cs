namespace IHM
{
    partial class EcranAjoutVet
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
            this.tbNomVet = new System.Windows.Forms.TextBox();
            this.tbMotPasse = new System.Windows.Forms.TextBox();
            this.btValiderVet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNomVet
            // 
            this.tbNomVet.Location = new System.Drawing.Point(39, 65);
            this.tbNomVet.MaxLength = 30;
            this.tbNomVet.Name = "tbNomVet";
            this.tbNomVet.Size = new System.Drawing.Size(212, 20);
            this.tbNomVet.TabIndex = 0;
            // 
            // tbMotPasse
            // 
            this.tbMotPasse.Location = new System.Drawing.Point(39, 151);
            this.tbMotPasse.Name = "tbMotPasse";
            this.tbMotPasse.PasswordChar = '*';
            this.tbMotPasse.Size = new System.Drawing.Size(212, 20);
            this.tbMotPasse.TabIndex = 1;
            // 
            // btValiderVet
            // 
            this.btValiderVet.Location = new System.Drawing.Point(67, 213);
            this.btValiderVet.Name = "btValiderVet";
            this.btValiderVet.Size = new System.Drawing.Size(147, 28);
            this.btValiderVet.TabIndex = 2;
            this.btValiderVet.Text = "Valider";
            this.btValiderVet.UseVisualStyleBackColor = true;
            this.btValiderVet.Click += new System.EventHandler(this.btValiderVet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom du veterinaire :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mot de passe : ";
            // 
            // EcranAjoutVet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 283);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btValiderVet);
            this.Controls.Add(this.tbMotPasse);
            this.Controls.Add(this.tbNomVet);
            this.Name = "EcranAjoutVet";
            this.Text = "Nouveau Veterinaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNomVet;
        private System.Windows.Forms.TextBox tbMotPasse;
        private System.Windows.Forms.Button btValiderVet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}