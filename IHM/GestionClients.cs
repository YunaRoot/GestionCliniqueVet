using BLL;
using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHM
{
    public partial class GestionClients : Form
    {
        #region Attributs
        private ClientBLL BllInstance = new ClientBLL();
        private Client clientCourant = new Client();
        private bool boutonRechercheEnfonce = false;
        private int position = 1;
        private EnumModeEcran modeEcran = EnumModeEcran.neutre;
        private PriseRendezVous rdvAgenda = null;
        #endregion

        #region Propriétés
        /// <summary>
        /// Position du client courant dans la liste de clients
        /// </summary>
        public int Position
        {
            get
            {
                return position;
            }
            set
            {
                if (value < 1)
                {
                    value = 1;
                }
                if (value > ObtenirNombreClients())
                {
                    value = ObtenirNombreClients();
                }
                position = value;
            }
        }
        /// <summary>
        /// Retourne le client courant
        /// </summary>
        public Client ClientCourant
        {
            get
            {
                return clientCourant;
            }
        }
        /// <summary>
        /// Mode de l'écran courant
        /// </summary>
        public EnumModeEcran ModeEcran
        {
            get
            {
                return this.modeEcran;
            }
            set
            {
                this.modeEcran = value;
                buttonAnnuler.Visible = (((EnumModeEcran)buttonAnnuler.Tag & modeEcran) == modeEcran);
                buttonValider.Visible = (((EnumModeEcran)buttonValider.Tag & modeEcran) == modeEcran);

                textBoxRecherche.Enabled = (((EnumModeEcran)textBoxRecherche.Tag & modeEcran) == modeEcran);
                buttonRechercherClient.Enabled = (((EnumModeEcran)buttonRechercherClient.Tag & modeEcran) == modeEcran);
                buttonPremierClient.Enabled = (((EnumModeEcran)buttonPremierClient.Tag & modeEcran) == modeEcran);
                buttonClientPrecedent.Enabled = (((EnumModeEcran)buttonClientPrecedent.Tag & modeEcran) == modeEcran);
                buttonClientSuivant.Enabled = (((EnumModeEcran)buttonClientSuivant.Tag & modeEcran) == modeEcran);
                buttonDernierClient.Enabled = (((EnumModeEcran)buttonDernierClient.Tag & modeEcran) == modeEcran);
                buttonAjoutAnimal.Visible = (((EnumModeEcran)buttonAjoutAnimal.Tag & modeEcran) == modeEcran);
                buttonEditAnimal.Visible = (((EnumModeEcran)buttonEditAnimal.Tag & modeEcran) == modeEcran);
                buttonSuppAnimal.Visible = (((EnumModeEcran)buttonSuppAnimal.Tag & modeEcran) == modeEcran);
            }
        }
        #endregion

        #region Constructeur
        //################################################################################
        //################################################################################
        //                        A REVOIR (priseRDV)
        //################################################################################
        public GestionClients()
        {
            InitializeComponent();
            buttonAnnuler.Tag = EnumModeEcran.ajout | EnumModeEcran.modification;
            buttonValider.Tag = EnumModeEcran.ajout | EnumModeEcran.modification | EnumModeEcran.priseRdv;
            textBoxRecherche.Tag = EnumModeEcran.recherche;
            buttonRechercherClient.Tag = EnumModeEcran.neutre | EnumModeEcran.recherche | EnumModeEcran.priseRdv;
            buttonPremierClient.Tag = EnumModeEcran.neutre | EnumModeEcran.recherche | EnumModeEcran.priseRdv;
            buttonClientPrecedent.Tag = EnumModeEcran.neutre | EnumModeEcran.recherche | EnumModeEcran.priseRdv;
            buttonClientSuivant.Tag = EnumModeEcran.neutre | EnumModeEcran.recherche | EnumModeEcran.priseRdv;
            buttonDernierClient.Tag = EnumModeEcran.neutre | EnumModeEcran.recherche | EnumModeEcran.priseRdv;
            buttonAjoutAnimal.Tag = EnumModeEcran.neutre | EnumModeEcran.recherche | EnumModeEcran.priseRdv;
            buttonSuppAnimal.Tag = EnumModeEcran.neutre | EnumModeEcran.recherche | EnumModeEcran.priseRdv;
            buttonEditAnimal.Tag = EnumModeEcran.neutre | EnumModeEcran.recherche | EnumModeEcran.priseRdv;
        }

        public GestionClients(PriseRendezVous rdv) : this()
        {
            rdvAgenda = rdv;
        }
        #endregion

        #region Evénements
        /// <summary> 
        /// Instanciation du client courant et remplissage des champs de la fenêtre au chargement de la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GestionClients_Load(object sender, EventArgs e)
        {
            clientCourant = BllInstance.Get(string.Empty);
            RemplirChampsClient();
            if (rdvAgenda != null)
            {
                ModeEcran = EnumModeEcran.priseRdv;
            }
        }

        /// <summary>
        /// Vide tous les champs de la fenêtre au clic sur le bouton Ajouter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            ViderChampsClient();
            ModeEcran = EnumModeEcran.ajout;
        }
        /// <summary>
        /// Gère la validation : de l'ajout si le mode d'écran est ajout, de la modification si le mode d'écran
        /// est modification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonValider_Click(object sender, EventArgs e)
        {
            try
            {
                CreerObjetClient();
                if (ModeEcran == EnumModeEcran.ajout)
                {
                    BllInstance.Create(clientCourant);
                    clientCourant = BllInstance.Get(clientCourant.NomClient);
                    position = BllInstance.GetPositionClient(clientCourant.NomClient, clientCourant.PrenomClient);
                }
                else if (ModeEcran == EnumModeEcran.modification)
                {
                    BllInstance.Update(clientCourant);
                }
                else if (ModeEcran == EnumModeEcran.priseRdv)
                {
                    this.Close();
                }
                RemplirChampsClient();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ModeEcran = EnumModeEcran.neutre;
        }

        /// <summary>
        /// Supprime le client courant de la bdd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                CreerObjetClient();
                DialogResult dr = MessageBox.Show("Supprimer ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    BllInstance.Delete(clientCourant);
                    clientCourant = BllInstance.Get("");
                    position = 1;
                    RemplirChampsClient();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ModeEcran = EnumModeEcran.neutre;
        }

        /// <summary>
        /// Active ou désactive la recherche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                if (boutonRechercheEnfonce)
                {
                    clientCourant = BllInstance.Get(clientCourant.CodeClient);
                    boutonRechercheEnfonce = false;
                    textBoxRecherche.Text = string.Empty;
                    ModeEcran = EnumModeEcran.neutre;
                }
                else
                {
                    clientCourant = BllInstance.Get(textBoxRecherche.Text);
                    boutonRechercheEnfonce = true;
                    ModeEcran = EnumModeEcran.recherche;
                }
                RemplirChampsClient();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Met à jour le client courant en fonction des caractères entrés dans la textboxRecherche.
        /// Affiche les informations du premier client par ordre alphabétique de son nom.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxRecherche_KeyUp(object sender, KeyEventArgs e)
        {
            if (boutonRechercheEnfonce)
            {
                clientCourant = BllInstance.Get(textBoxRecherche.Text);
                RemplirChampsClient();
            }
        }

        /// <summary>
        /// Evenement qui affiche la fiche du premier client de la bdd si le bouton Rechercher n'est pas enfoncé,
        /// du premier client de tous les clients dont le nom comprend la chaine de caractère affichée dans la 
        /// textboxRecherche si le bouton Rechercher est enfoncé.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPremier_Click(object sender, EventArgs e)
        {
            position = 1;
            if (boutonRechercheEnfonce)
            {
                clientCourant = BllInstance.Get(textBoxRecherche.Text);
            }
            else
            {
                clientCourant = BllInstance.Get(string.Empty);
            }
            RemplirChampsClient();
            if (ModeEcran != EnumModeEcran.recherche && ModeEcran != EnumModeEcran.priseRdv)
            {
                ModeEcran = EnumModeEcran.neutre;
            }
            VerifierPosition();
        }
        /// <summary>
        /// Evenement qui affiche la fiche du client précédant le client courant dans la bdd si le bouton Rechercher 
        /// n'est pas enfoncé, du client précédant le client courant et dont le nom comprend la chaine de caractère 
        /// affichée dans la textboxRecherche si le bouton Rechercher est enfoncé.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClientPrecedent_Click(object sender, EventArgs e)
        {
            int nbClients = ObtenirNombreClients();
            --Position;

            if (boutonRechercheEnfonce)
            {
                clientCourant = BllInstance.Get(textBoxRecherche.Text, Position);
            }
            else
            {
                clientCourant = BllInstance.Get(string.Empty, Position);
            }
            RemplirChampsClient();
            if (ModeEcran != EnumModeEcran.recherche && ModeEcran != EnumModeEcran.priseRdv)
            {
                ModeEcran = EnumModeEcran.neutre;
            }
            VerifierPosition();
        }
        /// <summary>
        /// Evenement qui affiche la fiche du client suivant le client courant dans la bdd si le bouton Rechercher 
        /// n'est pas enfoncé, du client suivant le client courant et dont le nom comprend la chaine de caractère 
        /// affichée dans la textboxRecherche si le bouton Rechercher est enfoncé.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClientSuivant_Click(object sender, EventArgs e)
        {
            int nbClients = ObtenirNombreClients();
            ++Position;

            if (boutonRechercheEnfonce)
            {
                clientCourant = BllInstance.Get(textBoxRecherche.Text, Position);
            }
            else
            {
                clientCourant = BllInstance.Get(string.Empty, Position);
            }
            RemplirChampsClient();
            if (ModeEcran != EnumModeEcran.recherche && ModeEcran != EnumModeEcran.priseRdv)
            {
                ModeEcran = EnumModeEcran.neutre;
            }
            VerifierPosition();
        }
        /// <summary>
        /// Evenement qui affiche la fiche du dernier client de la bdd si le bouton Rechercher n'est pas enfoncé,
        /// du dernier client de tous les clients dont le nom comprend la chaine de caractère affichée dans la 
        /// textboxRecherche si le bouton Rechercher est enfoncé.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDernierClient_Click(object sender, EventArgs e)
        {
            position = ObtenirNombreClients();
            if (boutonRechercheEnfonce)
            {
                clientCourant = BllInstance.Get(textBoxRecherche.Text, position);
            }
            else
            {
                clientCourant = BllInstance.Get(string.Empty, position);
            }
            RemplirChampsClient();
            if (ModeEcran != EnumModeEcran.recherche && ModeEcran != EnumModeEcran.priseRdv)
            {
                ModeEcran = EnumModeEcran.neutre;
            }
            VerifierPosition();
        }
        /// <summary>
        /// Ouvre une fenetre GestionAnimaux et lui donne en paramètre le client courant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAjoutAnimal_Click(object sender, EventArgs e)
        {
            GestionAnimaux fenetre = new GestionAnimaux(clientCourant);
            fenetre.ShowDialog();
            ChargerDataGridAnimaux();
        }
        /// <summary>
        /// Archive l'animal sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSuppAnimal_Click(object sender, EventArgs e)
        {
            Animal animalCourant = (Animal)this.dGViewAnimaux.CurrentRow.DataBoundItem;
            AnimalBLL instanceAnimalBll = new AnimalBLL();
            animalCourant.Archive = true;
            instanceAnimalBll.Update(animalCourant);
            ChargerDataGridAnimaux();
        }
        /// <summary>
        /// Ouvre une fenetre GestionAnimaux et lui donne en paramètre le client
        /// courant et l'animal courant (celui en cours de sélection)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditAnimal_Click(object sender, EventArgs e)
        {
            Animal animalCourant = (Animal)this.dGViewAnimaux.CurrentRow.DataBoundItem;
            GestionAnimaux fenetre = new GestionAnimaux(clientCourant, animalCourant);
            fenetre.ShowDialog();
            ChargerDataGridAnimaux();
        }
        /// <summary>
        /// Remplit les champs avec les informations du client courant et passe en mode d'écran neutre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            RemplirChampsClient();
            ModeEcran = EnumModeEcran.neutre;
        }
        /// <summary>
        /// Appelle la fonction ChangerModeVersModification() quand le texte de textBoxNom est modifié
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            ChangerModeVersModification();
        }
        /// <summary>
        /// Appelle la fonction ChangerModeVersModification() quand le texte de textBoxPrenom est modifié
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxPrenom_TextChanged(object sender, EventArgs e)
        {
            ChangerModeVersModification();
        }
        /// <summary>
        /// Appelle la fonction ChangerModeVersModification() quand le texte de textBoxAdresse1 est modifié
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxAdresse1_TextChanged(object sender, EventArgs e)
        {
            ChangerModeVersModification();
        }
        /// <summary>
        /// Appelle la fonction ChangerModeVersModification() quand le texte de textBoxAdresse2 est modifié
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxAdresse2_TextChanged(object sender, EventArgs e)
        {
            ChangerModeVersModification();
        }
        /// <summary>
        /// Appelle la fonction ChangerModeVersModification() quand le texte de textBoxCodePostal est modifié
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxCodePostal_TextChanged(object sender, EventArgs e)
        {
            ChangerModeVersModification();
        }
        /// <summary>
        /// Appelle la fonction ChangerModeVersModification() quand le texte de textBoxVille est modifié
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxVille_TextChanged(object sender, EventArgs e)
        {
            ChangerModeVersModification();
        }
        /// <summary>
        /// Appelle la fonction ChangerModeVersModification() quand le texte de comboBoxAssurance est modifié
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxAssurance_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangerModeVersModification();
        }
        /// <summary>
        /// Appelle la fonction ChangerModeVersModification() quand le texte de textBoxMail est modifié
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxMail_TextChanged(object sender, EventArgs e)
        {
            ChangerModeVersModification();
        }
        /// <summary>
        /// Appelle la fonction ChangerModeVersModification() quand le texte de textBoxTel est modifié
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxTel_TextChanged(object sender, EventArgs e)
        {
            ChangerModeVersModification();
        }
        /// <summary>
        /// Appelle la fonction ChangerModeVersModification() quand le texte de textBoxRemarques est modifié
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxRemarques_TextChanged(object sender, EventArgs e)
        {
            ChangerModeVersModification();
        }
        #endregion

        #region Méthodes
        /// <summary>
        /// Grise le bouton Premier client quand la position 1 est atteinte,
        /// grise le bouton Dernier client quand la position du dernier client est atteinte
        /// </summary>
        private void VerifierPosition()
        {
            if (position <= 1)
            {
                buttonDernierClient.Enabled = true;
                buttonPremierClient.Enabled = false;
            }
            else if (position >= ObtenirNombreClients())
            {
                buttonDernierClient.Enabled = false;
                buttonPremierClient.Enabled = true;
            }
            else
            {
                buttonDernierClient.Enabled = true;
                buttonPremierClient.Enabled = true;
            }
        }
        /// <summary>
        /// Affiche les animaux du client courant dans dGViewAnimaux
        /// </summary>
        private void ChargerDataGridAnimaux()
        {
            AnimalBLL instanceAnimalBll = new AnimalBLL();
            this.dGViewAnimaux.AutoGenerateColumns = false;
            this.dGViewAnimaux.DataSource = instanceAnimalBll.GetAnimauxByClient(clientCourant);
            this.dGViewAnimaux.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// Retourne le nombre de clients total si le bouton Rechercher n'est pas enfoncé,
        /// le nombre de clients dont le nom comprend la chaine de caractères présente dans la textboxRecherche si
        /// le bouton Rechercher est enfoncé.
        /// </summary>
        /// <returns></returns>
        private int ObtenirNombreClients()
        {
            int nbClients = boutonRechercheEnfonce ? BllInstance.GetNbClients(textBoxRecherche.Text) : BllInstance.GetNbClients();
            return nbClients;
        }
        /// <summary>
        /// Remplit l'écran de gestion des clients avec les caractéristiques de l'objet clientCourant
        /// </summary>
        private void RemplirChampsClient()
        {
            textBoxNom.Text = clientCourant.NomClient;
            textBoxPrenom.Text = clientCourant.PrenomClient;
            textBoxAdresse1.Text = clientCourant.Adresse1;
            textBoxAdresse2.Text = clientCourant.Adresse2;
            textBoxCodePostal.Text = clientCourant.CodePostal;
            textBoxVille.Text = clientCourant.Ville;
            comboBoxAssurance.Text = clientCourant.Assurance;
            textBoxMail.Text = clientCourant.Email;
            textBoxTel.Text = clientCourant.NumTel;
            textBoxRemarques.Text = clientCourant.Remarque;

            ChargerDataGridAnimaux();
        }

        /// <summary>
        /// Vide toutes les informations affichées
        /// </summary>
        private void ViderChampsClient()
        {
            textBoxNom.Text = string.Empty;
            textBoxPrenom.Text = string.Empty;
            textBoxAdresse1.Text = string.Empty;
            textBoxAdresse2.Text = string.Empty;
            textBoxCodePostal.Text = string.Empty;
            textBoxVille.Text = string.Empty;
            comboBoxAssurance.Text = string.Empty;
            textBoxMail.Text = string.Empty;
            textBoxTel.Text = string.Empty;
            textBoxRemarques.Text = string.Empty;
        }
        /// <summary>
        /// Crée un objet Client à part des informations affichées
        /// </summary>
        private void CreerObjetClient()
        {
            clientCourant.NomClient = textBoxNom.Text;
            clientCourant.PrenomClient = textBoxPrenom.Text;
            clientCourant.Adresse1 = textBoxAdresse1.Text;
            clientCourant.Adresse2 = textBoxAdresse2.Text;
            clientCourant.CodePostal = textBoxCodePostal.Text;
            clientCourant.Ville = textBoxVille.Text;
            clientCourant.Assurance = comboBoxAssurance.Text;
            clientCourant.NumTel = textBoxTel.Text;
            clientCourant.Email = textBoxMail.Text;
            clientCourant.Remarque = textBoxRemarques.Text;
        }
        /// <summary>
        /// Lorsqu'un champ texte est modifié, le mode d'écran passe en mode modification
        /// (seulement si le mode courant est neutre)
        /// </summary>
        private void ChangerModeVersModification()
        {
            if (ModeEcran == EnumModeEcran.neutre)
            {
                ModeEcran = EnumModeEcran.modification;
            }
        }

        #endregion
    }
}
