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
    public partial class EcranConsultation : Form
    {

        private bool nouvelleConsultation;
        private ClientBLL bllClient = new ClientBLL();
        private AnimalBLL bllAnimal = new AnimalBLL();
        private BaremeBLL bllBareme = new BaremeBLL();

        #region props
        /// <summary>
        /// Représente l'animal lié a la fenetre
        /// </summary>
        public Animal currentAnimal { get; set; }

        /// <summary>
        /// représente le vétérinaire lié a la fenetre
        /// </summary>
        public Veterinaire currentVet { get; set; }

        /// <summary>
        /// Représente la consultation active ce la fenetre
        /// </summary>
        public Consultation CurrentConsult { get; set; }
        #endregion

        /// <summary>
        /// Construit un objet EcranConsultation si l'animal possede deja une consultation
        /// </summary>
        /// <param name="animal"></param>
        public EcranConsultation(Consultation consultation) : this()
        {
            this.CurrentConsult = consultation;
            this.nouvelleConsultation = false;
        }

        /// <summary>
        /// Constructeur de la classe EcranConsultation, a utilsié si l'animal n'a aucune consultation deja créée
        /// </summary>
        /// <param name="animal"></param>
        public EcranConsultation(Animal animal) : this()
        {
            this.currentAnimal = animal;
            this.nouvelleConsultation = true;
        }

        /// <summary>
        /// Initialise les composants Winform de la fenetre
        /// </summary>
        private EcranConsultation()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Charge certains éléments au chargement de la page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Consultation_Load(object sender, EventArgs e)
        {
            RefreshTextBoxes();
            this.dtpDateConsultation.Value = this.CurrentConsult.Date;
            this.cbxType.DataSource = bllBareme.Get();
            
        }

        /// <summary>
        /// Assigne toutes les textboxes liés au Veterinaire courant et a l'Animal courant
        /// </summary>
        private void RefreshTextBoxes()
        {
            this.tbCodeAnimal.Text = CurrentConsult.AnimalConsulte.CodeAnimal.ToString();
            this.tbCouleurAnimal.Text = CurrentConsult.AnimalConsulte.Couleur;
            this.tbEspeceAnimal.Text = CurrentConsult.AnimalConsulte.Espece;
            this.tbNomAnimal.Text = CurrentConsult.AnimalConsulte.NomAnimal;
            this.tbRaceAnimal.Text = CurrentConsult.AnimalConsulte.Race;
            this.tbSexeAnimal.Text = CurrentConsult.AnimalConsulte.Sexe.ToString();
            this.tbTatouageAnimal.Text = CurrentConsult.AnimalConsulte.Tatouage;
            this.tbNomVeterinaire.Text = CurrentConsult.Veto.NomVeto;
            this.rtbCommentaire.Text = CurrentConsult.Commentaire;
        }

        /// <summary>
        /// Affiche le dossier medical de l'animal lié a la consultation active
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDossierMedical_Click(object sender, EventArgs e)
        {
            DossierMedical ecranDossiermedical;
            if (nouvelleConsultation)
            {
                ecranDossiermedical = new DossierMedical(this.currentAnimal);
            }
            else
            {
                ecranDossiermedical = new DossierMedical(CurrentConsult.AnimalConsulte);
                ecranDossiermedical.Show();
            }
        }
    }
}
