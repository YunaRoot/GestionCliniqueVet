using BLL;
using BO;
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
    /// <summary>
    /// Fenetre de la gestion des vétérinaires
    /// </summary>
    public partial class GestionVeterinaire : Form
    {
        private VeterinaireBLL bll = new VeterinaireBLL();

        /// <summary>
        /// Constructeur vide de la classe GestionVeterinaire
        /// </summary>
        public GestionVeterinaire()
        {
            InitializeComponent();
            this.dgVetos.AutoGenerateColumns = false;
        }

        /// <summary>
        /// Ajoute un vétérinaire a la base de données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAjouterVet_Click(object sender, EventArgs e)
        {
            EcranAjoutVet ecranAjout = new EcranAjoutVet();
            ecranAjout.ShowDialog();
            this.RefreshDgVeterinaire();
        }

        /// <summary>
        /// Archive un vétérinaire dans la base de données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSupprimerVet_Click(object sender, EventArgs e)
        {
            Veterinaire vet = (Veterinaire)this.dgVetos.CurrentRow.DataBoundItem; // bll.Get((Guid)this.dgVetos.CurrentRow.Cells["CodeVeto"].Value);
            vet.Archive = true;
            bll.Update(vet);
            this.RefreshDgVeterinaire();
        }

        /// <summary>
        /// Initialisations de la fenetre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GestionVeterinaire_Load(object sender, EventArgs e)
        {
            this.RefreshDgVeterinaire();
        }

        /// <summary>
        /// Fonction qui permet de rafraichir la grille de données de la fenetre
        /// </summary>
        private void RefreshDgVeterinaire()
        {
            this.dgVetos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgVetos.DataSource = bll.Get();
            this.dgVetos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// Permet de modifier le mot de passe de connexion d'un vétérinaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btReinitialiser_Click(object sender, EventArgs e)
        {
            try
            {
                EcranReinitialisationMdp ecran1 = new EcranReinitialisationMdp();
                ecran1.ShowDialog();
                string newPass = ecran1.Password;
                Veterinaire vet = (Veterinaire)this.dgVetos.CurrentRow.DataBoundItem;
                vet.MotPasse = newPass;
                bll.Update(vet);
                MessageBox.Show("Changement de mot de passe effectué avec succès");
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
