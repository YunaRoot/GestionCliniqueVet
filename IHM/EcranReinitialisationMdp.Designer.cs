namespace IHM
{
    partial class EcranReinitialisationMdp
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
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.btValider = new System.Windows.Forms.Button();
            this.tbCheckPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNewPass
            // 
            this.tbNewPass.Location = new System.Drawing.Point(40, 58);
            this.tbNewPass.MaxLength = 30;
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.PasswordChar = '*';
            this.tbNewPass.Size = new System.Drawing.Size(236, 20);
            this.tbNewPass.TabIndex = 0;
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(40, 190);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(236, 42);
            this.btValider.TabIndex = 3;
            this.btValider.Text = "Valider le changement de mot de passe";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbCheckPass
            // 
            this.tbCheckPass.Location = new System.Drawing.Point(40, 126);
            this.tbCheckPass.MaxLength = 30;
            this.tbCheckPass.Name = "tbCheckPass";
            this.tbCheckPass.PasswordChar = '*';
            this.tbCheckPass.Size = new System.Drawing.Size(236, 20);
            this.tbCheckPass.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Saisissez le nouveau mot de passe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Saisissez à nouveau le nouveau mot de passe";
            // 
            // EcranReinitialisationMdp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 323);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCheckPass);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.tbNewPass);
            this.Name = "EcranReinitialisationMdp";
            this.Text = "EcranReinitialisationMdp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.TextBox tbCheckPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}