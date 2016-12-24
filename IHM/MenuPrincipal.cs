using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHM
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void priseDeRendezvousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PriseRendezVous rdv = new PriseRendezVous();
            rdv.MdiParent = this;
            rdv.Show();
        }

        private void dossierClientsAnimauxCtrlAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionClients ecranClients = new GestionClients();
            ecranClients.MdiParent = this;
            ecranClients.Show();
        }

        private void relancesCtrlRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionRelances ecranRelances = new GestionRelances();
            ecranRelances.MdiParent = this;
            ecranRelances.Show();
        }

        private void miseÀJourDuStockDeVaccinsCtrlMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionVaccins ecranVaccins = new GestionVaccins();
            ecranVaccins.MdiParent = this;
            ecranVaccins.Show();
        }

        private void agendaCtrlEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda();
            agenda.MdiParent = this;
            agenda.Show();
        }

        private void dossiersMédicauxCtrlMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DossierMedical dossier = new DossierMedical();
            dossier.MdiParent = this;
            dossier.Show();
        }

        private void vétérinairesCtrlTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionVeterinaire ecranVetos = new GestionVeterinaire();
            ecranVetos.MdiParent = this;
            ecranVetos.Show();
        }

        private void misdeÀJourDuBarêmeDeTarificationCtrlBToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonRdv_Click(object sender, EventArgs e)
        {
            PriseRendezVous rdv = new PriseRendezVous();
            rdv.MdiParent = this;
            rdv.Show();
        }

        private void toolStripButtonClientAnimal_Click(object sender, EventArgs e)
        {
            GestionClients ecranClients = new GestionClients();
            ecranClients.MdiParent = this;
            ecranClients.Show();
        }

        private void toolStripButtonRelances_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonAgenda_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda();
            agenda.MdiParent = this;
            agenda.Show();
        }

        private void toolStripButtonDossMedical_Click(object sender, EventArgs e)
        {
            DossierMedical dossier = new DossierMedical();
            dossier.MdiParent = this;
            dossier.Show();
        }
    }
}
