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
    public partial class GestionAnimaux : Form
    {
        private AnimalBLL animalBll;
        private Animal animalCourrant;
        private Client clientCourant;
        private List<Char> sexeAnimal;

        /// <summary>
        /// Constuit la fenetre gestion annimaux avec les objets animal et client
        /// </summary>
        /// <param name="client"></param>
        /// <param name="animal"></param>
        public GestionAnimaux(Client client, Animal animal = null) : this()
        {
            this.animalCourrant = animal;
            this.clientCourant = client;
        }

        /// <summary>
        /// Constructeur privé
        /// </summary>
        public GestionAnimaux()
        {
            InitializeComponent();
            this.animalBll = new AnimalBLL();
            this.sexeAnimal = new List<char> { 'M', 'F', 'H' };
        }

        /// <summary>
        /// Affichage de la fenetre de base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GestionAnimaux_Load(object sender, EventArgs e)
        {
            RemplirChampsAnimal();
        }

        private void RemplirChampsAnimal()
        {
            this.textBoxClient.Text = this.clientCourant.NomClient + " " + this.clientCourant.PrenomClient;
            this.textBoxCode.Text = this.animalCourrant?.CodeAnimal.ToString();
            this.textBoxNom.Text = this.animalCourrant?.NomAnimal.ToString();
            this.textBoxCouleur.Text = this.animalCourrant?.Couleur?.ToString();
            this.textBoxTatouage.Text = this.animalCourrant?.Tatouage?.ToString();
            this.comboBoxEspece.Text = this.animalCourrant?.Espece?.ToString();
            this.comboBoxRace.Text = this.animalCourrant?.Race?.ToString();
            this.comboBoxSexe.DataSource = this.sexeAnimal;
        }

        /// <summary>
        /// Ouvre le dossier medical de l'animal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDossierMedical_Click(object sender, EventArgs e)
        {
            DossierMedical dossMed = new DossierMedical(animalCourrant, clientCourant);
            dossMed.Show();
        }

        /// <summary>
        /// appel des methodes de création et modification d'un animal avec le bouton validé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (animalCourrant == null)
            {
                creationAnimal();

                DialogResult result = MessageBox.Show("Création effectuée\n", "voulez vous ajouter un autre animal ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    NouvelleCreationAnimal();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                ModifierAnimal();
            }
        }

        /// <summary>
        /// Methode de modification d'un animal
        /// </summary>
        private void ModifierAnimal()
        {
            animalCourrant.NomAnimal = textBoxNom.Text;
            animalCourrant.Sexe = comboBoxSexe.Text[0];
            animalCourrant.Couleur = textBoxCouleur.Text;
            animalCourrant.Race = comboBoxRace.Text;
            animalCourrant.Espece = comboBoxEspece.Text;
            animalCourrant.Tatouage = textBoxTatouage.Text;
            animalCourrant.Antecedent = animalCourrant.Antecedent;
            animalCourrant.Archive = animalCourrant.Archive;

            animalBll.Update(animalCourrant);
        }

        /// <summary>
        /// methode pour remettre a zero les textbox et combobox
        /// </summary>
        private void NouvelleCreationAnimal()
        {
            textBoxNom.Text = null;
            comboBoxSexe.Text = null;
            textBoxCouleur.Text = null;
            comboBoxRace.Text = null;
            comboBoxEspece.Text = null;
            textBoxTatouage.Text = null;
            animalCourrant = null;
        }

        /// <summary>
        /// methode pour créer un animal
        /// </summary>
        private void creationAnimal()
        {
            Animal newAnimal = new Animal();
            newAnimal.CodeClient = clientCourant.CodeClient;

            newAnimal.NomAnimal = textBoxNom.Text;
            newAnimal.Sexe = comboBoxSexe.Text[0];
            newAnimal.Couleur = textBoxCouleur.Text;
            newAnimal.Race = comboBoxRace.Text;
            newAnimal.Espece = comboBoxEspece.Text;
            newAnimal.Tatouage = textBoxTatouage.Text;
            newAnimal.Antecedent = string.Empty;
            newAnimal.Archive = false;

            animalBll.Create(newAnimal);
        }

        /// <summary>
        /// Supprime un animal et renvoi a la fiche client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Supprimer ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                animalBll.Delete(animalCourrant);
                MessageBox.Show("Suppresion effectuée");
            }
        }
    }
}
