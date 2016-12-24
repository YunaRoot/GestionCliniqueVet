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
    /// Représente la fenetre des dossiers medicaux des animaux de la clinique
    /// </summary>
    public partial class DossierMedical : Form
    {
        private Animal animalCourant;
        private Client clientCourant;

        /// <summary>
        /// Constructeur permettant a la fenetre de savoir sur quelle client et/ou animal elle travaille
        /// </summary>
        /// <param name="animal"></param>
        /// <param name="client"></param>
        public DossierMedical(Animal animal = null, Client client = null)
        {
            this.animalCourant = animal;
            this.clientCourant = client;
            InitializeComponent();
        }

        /// <summary>
        /// Recherche le premier dossier medical enregistré en fonction de la saisie utilisateur : 
        /// nom proprietaire, nom de l'animal ou tatouage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btRecherche_Click(object sender, EventArgs e)
        {
            try
            {
                ClientBLL bllClient = new ClientBLL();
                AnimalBLL bllAnimal = new AnimalBLL();
                if (!string.IsNullOrWhiteSpace(tbProprietaire.Text))
                {
                    clientCourant = bllClient.Get(this.tbProprietaire.Text);
                    animalCourant = bllAnimal.Get(clientCourant);
                    this.tbProprietaire.Text = clientCourant.NomClient + " " + clientCourant.PrenomClient;
                    this.tbNomAnimal.Text = animalCourant.NomAnimal;
                    this.tbTatouage.Text = animalCourant.Tatouage;
                    RemplissageRichTextBox();
                }
                else if (!string.IsNullOrWhiteSpace(tbNomAnimal.Text))
                {
                    animalCourant = bllAnimal.Get(tbNomAnimal.Text)[0];
                    clientCourant = bllClient.Get(animalCourant.CodeClient);
                    this.tbProprietaire.Text = clientCourant.NomClient + " " + clientCourant.PrenomClient;
                    this.tbNomAnimal.Text = animalCourant.NomAnimal;
                    this.tbTatouage.Text = animalCourant.Tatouage;
                    RemplissageRichTextBox();
                }
                else if (!string.IsNullOrWhiteSpace(tbTatouage.Text))
                {
                    animalCourant = bllAnimal.GetAnimalByTatoo(this.tbTatouage.Text);
                    clientCourant = bllClient.Get(animalCourant.CodeClient);
                    this.tbProprietaire.Text = clientCourant.NomClient + " " + clientCourant.PrenomClient;
                    this.tbNomAnimal.Text = animalCourant.NomAnimal;
                    this.tbTatouage.Text = animalCourant.Tatouage;
                    RemplissageRichTextBox();
                }
                else
                {
                    throw new ApplicationException("Champs saisis invalide");
                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Au chargement de la page, le commentaire du veto se remplie, ainsi que les textboxes
        /// sion a acceder a cet ecran depuis l'ecran des animaux 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DossierMedical_Load(object sender, EventArgs e)
        {
            RemplissageRichTextBox();
            this.tbNomAnimal.Text = animalCourant?.NomAnimal;
            this.tbTatouage.Text = animalCourant?.Tatouage;
            this.tbProprietaire.Text = clientCourant?.NomClient + " " + clientCourant?.PrenomClient;
        }

        /// <summary>
        /// Permet de valider en appuyant sur la touche entrée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbProprietaire_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.btRecherche_Click(sender, (EventArgs)e);
            }
        }

        /// <summary>
        /// Insere dant la RichTextBox le dossier medical de l'animal
        /// </summary>
        private void RemplissageRichTextBox()
        {
            this.rtbFicheMedical.Text = clientCourant?.ToString() + animalCourant?.ToString();
        }

        /// <summary>
        /// Permet de valider la recherche en appuyant sur Entrée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbNomAnimal_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                btRecherche_Click(sender, (EventArgs)e);
        }

        /// <summary>
        /// Permet de valider la recherche en appuyant sur Entrée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbTatouage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btRecherche_Click(sender, (EventArgs)e);
        }
    }
}
