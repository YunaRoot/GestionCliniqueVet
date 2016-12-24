namespace IHM
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.menuStripHaut = new System.Windows.Forms.MenuStrip();
            this.secrétariatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vétérinaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramétrageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priseDeRendezvousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dossierClientsAnimauxCtrlAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relancesCtrlRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miseÀJourDuStockDeVaccinsCtrlMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaCtrlEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dossiersMédicauxCtrlMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vétérinairesCtrlTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.misdeÀJourDuBarêmeDeTarificationCtrlBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonRdv = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonClientAnimal = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRelances = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAgenda = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDossMedical = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.menuStripHaut.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripHaut
            // 
            this.menuStripHaut.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secrétariatToolStripMenuItem,
            this.vétérinaireToolStripMenuItem,
            this.paramétrageToolStripMenuItem});
            this.menuStripHaut.Location = new System.Drawing.Point(0, 0);
            this.menuStripHaut.Name = "menuStripHaut";
            this.menuStripHaut.Size = new System.Drawing.Size(887, 24);
            this.menuStripHaut.TabIndex = 0;
            this.menuStripHaut.Text = "menuStripHaut";
            // 
            // secrétariatToolStripMenuItem
            // 
            this.secrétariatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.priseDeRendezvousToolStripMenuItem,
            this.dossierClientsAnimauxCtrlAToolStripMenuItem,
            this.relancesCtrlRToolStripMenuItem,
            this.miseÀJourDuStockDeVaccinsCtrlMToolStripMenuItem});
            this.secrétariatToolStripMenuItem.Name = "secrétariatToolStripMenuItem";
            this.secrétariatToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.secrétariatToolStripMenuItem.Text = "Secrétariat";
            // 
            // vétérinaireToolStripMenuItem
            // 
            this.vétérinaireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendaCtrlEToolStripMenuItem,
            this.dossiersMédicauxCtrlMToolStripMenuItem});
            this.vétérinaireToolStripMenuItem.Name = "vétérinaireToolStripMenuItem";
            this.vétérinaireToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.vétérinaireToolStripMenuItem.Text = "Vétérinaire";
            // 
            // paramétrageToolStripMenuItem
            // 
            this.paramétrageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vétérinairesCtrlTToolStripMenuItem,
            this.misdeÀJourDuBarêmeDeTarificationCtrlBToolStripMenuItem});
            this.paramétrageToolStripMenuItem.Name = "paramétrageToolStripMenuItem";
            this.paramétrageToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.paramétrageToolStripMenuItem.Text = "Paramétrage";
            // 
            // priseDeRendezvousToolStripMenuItem
            // 
            this.priseDeRendezvousToolStripMenuItem.Name = "priseDeRendezvousToolStripMenuItem";
            this.priseDeRendezvousToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.priseDeRendezvousToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.priseDeRendezvousToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.priseDeRendezvousToolStripMenuItem.Text = "Prise de rendez-vous";
            this.priseDeRendezvousToolStripMenuItem.Click += new System.EventHandler(this.priseDeRendezvousToolStripMenuItem_Click);
            // 
            // dossierClientsAnimauxCtrlAToolStripMenuItem
            // 
            this.dossierClientsAnimauxCtrlAToolStripMenuItem.Name = "dossierClientsAnimauxCtrlAToolStripMenuItem";
            this.dossierClientsAnimauxCtrlAToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.dossierClientsAnimauxCtrlAToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.dossierClientsAnimauxCtrlAToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.dossierClientsAnimauxCtrlAToolStripMenuItem.Text = "Dossier Clients/Animaux";
            this.dossierClientsAnimauxCtrlAToolStripMenuItem.Click += new System.EventHandler(this.dossierClientsAnimauxCtrlAToolStripMenuItem_Click);
            // 
            // relancesCtrlRToolStripMenuItem
            // 
            this.relancesCtrlRToolStripMenuItem.Name = "relancesCtrlRToolStripMenuItem";
            this.relancesCtrlRToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.relancesCtrlRToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.relancesCtrlRToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.relancesCtrlRToolStripMenuItem.Text = "Relances";
            this.relancesCtrlRToolStripMenuItem.Click += new System.EventHandler(this.relancesCtrlRToolStripMenuItem_Click);
            // 
            // miseÀJourDuStockDeVaccinsCtrlMToolStripMenuItem
            // 
            this.miseÀJourDuStockDeVaccinsCtrlMToolStripMenuItem.Name = "miseÀJourDuStockDeVaccinsCtrlMToolStripMenuItem";
            this.miseÀJourDuStockDeVaccinsCtrlMToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.miseÀJourDuStockDeVaccinsCtrlMToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.miseÀJourDuStockDeVaccinsCtrlMToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.miseÀJourDuStockDeVaccinsCtrlMToolStripMenuItem.Text = "Mise à jour du stock de vaccins";
            this.miseÀJourDuStockDeVaccinsCtrlMToolStripMenuItem.Click += new System.EventHandler(this.miseÀJourDuStockDeVaccinsCtrlMToolStripMenuItem_Click);
            // 
            // agendaCtrlEToolStripMenuItem
            // 
            this.agendaCtrlEToolStripMenuItem.Name = "agendaCtrlEToolStripMenuItem";
            this.agendaCtrlEToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.agendaCtrlEToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.agendaCtrlEToolStripMenuItem.Text = "Agenda";
            this.agendaCtrlEToolStripMenuItem.Click += new System.EventHandler(this.agendaCtrlEToolStripMenuItem_Click);
            // 
            // dossiersMédicauxCtrlMToolStripMenuItem
            // 
            this.dossiersMédicauxCtrlMToolStripMenuItem.Name = "dossiersMédicauxCtrlMToolStripMenuItem";
            this.dossiersMédicauxCtrlMToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.dossiersMédicauxCtrlMToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.dossiersMédicauxCtrlMToolStripMenuItem.Text = "Dossiers Médicaux";
            this.dossiersMédicauxCtrlMToolStripMenuItem.Click += new System.EventHandler(this.dossiersMédicauxCtrlMToolStripMenuItem_Click);
            // 
            // vétérinairesCtrlTToolStripMenuItem
            // 
            this.vétérinairesCtrlTToolStripMenuItem.Name = "vétérinairesCtrlTToolStripMenuItem";
            this.vétérinairesCtrlTToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.vétérinairesCtrlTToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.vétérinairesCtrlTToolStripMenuItem.Text = "Vétérinaires";
            this.vétérinairesCtrlTToolStripMenuItem.Click += new System.EventHandler(this.vétérinairesCtrlTToolStripMenuItem_Click);
            // 
            // misdeÀJourDuBarêmeDeTarificationCtrlBToolStripMenuItem
            // 
            this.misdeÀJourDuBarêmeDeTarificationCtrlBToolStripMenuItem.Name = "misdeÀJourDuBarêmeDeTarificationCtrlBToolStripMenuItem";
            this.misdeÀJourDuBarêmeDeTarificationCtrlBToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.misdeÀJourDuBarêmeDeTarificationCtrlBToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.misdeÀJourDuBarêmeDeTarificationCtrlBToolStripMenuItem.Text = "Misde à jour du barême de tarification";
            this.misdeÀJourDuBarêmeDeTarificationCtrlBToolStripMenuItem.Click += new System.EventHandler(this.misdeÀJourDuBarêmeDeTarificationCtrlBToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonRdv,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripButtonClientAnimal,
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.toolStripButtonRelances,
            this.toolStripLabel3,
            this.toolStripSeparator3,
            this.toolStripButtonAgenda,
            this.toolStripLabel4,
            this.toolStripSeparator4,
            this.toolStripButtonDossMedical,
            this.toolStripLabel5});
            this.toolStrip.Location = new System.Drawing.Point(796, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(91, 545);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripButtonRdv
            // 
            this.toolStripButtonRdv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRdv.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRdv.Image")));
            this.toolStripButtonRdv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRdv.Name = "toolStripButtonRdv";
            this.toolStripButtonRdv.Size = new System.Drawing.Size(88, 20);
            this.toolStripButtonRdv.Text = "Rendez-vous";
            this.toolStripButtonRdv.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolStripButtonRdv.Click += new System.EventHandler(this.toolStripButtonRdv_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(88, 15);
            this.toolStripLabel1.Text = "Rendez-vous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(88, 6);
            // 
            // toolStripButtonClientAnimal
            // 
            this.toolStripButtonClientAnimal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClientAnimal.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClientAnimal.Image")));
            this.toolStripButtonClientAnimal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClientAnimal.Name = "toolStripButtonClientAnimal";
            this.toolStripButtonClientAnimal.Size = new System.Drawing.Size(88, 20);
            this.toolStripButtonClientAnimal.Text = "Client / Animal";
            this.toolStripButtonClientAnimal.Click += new System.EventHandler(this.toolStripButtonClientAnimal_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(88, 15);
            this.toolStripLabel2.Text = "Client / Animal";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(88, 6);
            // 
            // toolStripButtonRelances
            // 
            this.toolStripButtonRelances.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRelances.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRelances.Image")));
            this.toolStripButtonRelances.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRelances.Name = "toolStripButtonRelances";
            this.toolStripButtonRelances.Size = new System.Drawing.Size(88, 20);
            this.toolStripButtonRelances.Text = "toolStripButtonRelances";
            this.toolStripButtonRelances.Click += new System.EventHandler(this.toolStripButtonRelances_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(88, 15);
            this.toolStripLabel3.Text = "Relances";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(88, 6);
            // 
            // toolStripButtonAgenda
            // 
            this.toolStripButtonAgenda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAgenda.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAgenda.Image")));
            this.toolStripButtonAgenda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAgenda.Name = "toolStripButtonAgenda";
            this.toolStripButtonAgenda.Size = new System.Drawing.Size(88, 20);
            this.toolStripButtonAgenda.Text = "toolStripButtonAgenda";
            this.toolStripButtonAgenda.Click += new System.EventHandler(this.toolStripButtonAgenda_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(88, 15);
            this.toolStripLabel4.Text = "Agenda";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(88, 6);
            // 
            // toolStripButtonDossMedical
            // 
            this.toolStripButtonDossMedical.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDossMedical.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDossMedical.Image")));
            this.toolStripButtonDossMedical.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDossMedical.Name = "toolStripButtonDossMedical";
            this.toolStripButtonDossMedical.Size = new System.Drawing.Size(88, 20);
            this.toolStripButtonDossMedical.Text = "toolStripButtonDossMedical";
            this.toolStripButtonDossMedical.Click += new System.EventHandler(this.toolStripButtonDossMedical_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(88, 15);
            this.toolStripLabel5.Text = "Dossier médical";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 569);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStripHaut);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripHaut;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuPrincipal";
            this.Text = "Clinique Vétérinaire";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripHaut.ResumeLayout(false);
            this.menuStripHaut.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripHaut;
        private System.Windows.Forms.ToolStripMenuItem secrétariatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priseDeRendezvousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vétérinaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramétrageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dossierClientsAnimauxCtrlAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relancesCtrlRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miseÀJourDuStockDeVaccinsCtrlMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaCtrlEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dossiersMédicauxCtrlMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vétérinairesCtrlTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem misdeÀJourDuBarêmeDeTarificationCtrlBToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonRdv;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonClientAnimal;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonRelances;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonAgenda;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonDossMedical;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
    }
}

