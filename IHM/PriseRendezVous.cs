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

    public partial class PriseRendezVous : Form
    {
        private ClientBLL BllInstanceClient;
        private Client clientCourant;
        private AnimalBLL BllInstanceAnimal;
        private Animal AnimalCourant;
        private Consultation consult;
        private VeterinaireBLL BllInstanceVeto;
        private List<string> HeureRendezVous;
        private List<string> MinutesRendezVous;
        private RendezVousBLL rendezVous;
        private Veterinaire vetoCourant;

        /// <summary>
        /// Constructeur vide
        /// </summary>
        public PriseRendezVous()
        {
            BllInstanceClient = new ClientBLL();
            BllInstanceAnimal = new AnimalBLL();
            clientCourant = new Client();
            AnimalCourant = new Animal();
            vetoCourant = new Veterinaire();
            consult = new Consultation();
            BllInstanceVeto = new VeterinaireBLL();
            rendezVous = new RendezVousBLL();
            InitializeComponent();
            this.HeureRendezVous = new List<string> { "9", "10", "11", "12", "14", "15", "16", "17" };
            this.MinutesRendezVous = new List<string> { "00", "15", "30", "45" };
            //créer un date time avec les string à l'insertion dans la BDD
        }

        private void PriseRendezVous_Load(object sender, EventArgs e)
        {
            this.comboBoxClient.Text = this.clientCourant.NomClient + " " + this.clientCourant.PrenomClient;
            this.comboBoxAnimal.Text = this.AnimalCourant.NomAnimal + " " + this.AnimalCourant.Race;
            this.comboBoxVeterinaire.DataSource = BllInstanceVeto.Get();
            this.comboBoxHeures.DataSource = this.HeureRendezVous;
            this.comboBoxMinutes.DataSource = this.MinutesRendezVous;
            dataGridViewPriseRendezVous.Columns[1].DefaultCellStyle.Format = "HH:mm";
            this.dataGridViewPriseRendezVous.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPriseRendezVous.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPriseRendezVous.DataSource = rendezVous.Get();
        }

        private void buttonAjouterClient_Click(object sender, EventArgs e)
        {
            PriseRendezVous rdv = new PriseRendezVous();
            GestionClients fenetreClient = new GestionClients(rdv);
            fenetreClient.ShowDialog();
            clientCourant = fenetreClient.ClientCourant;
            this.comboBoxClient.Text = this.clientCourant.NomClient + " " + this.clientCourant.PrenomClient;

            this.comboBoxAnimal.DataSource = BllInstanceAnimal.GetAnimauxByClient(clientCourant);

        }
        /// <summary>
        /// Ajouter un nouvel animal au client et donc afficher la fenètre gestion animal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //gerer un mode ecran pour griser le bouton ajouter animal si le client n'a pas été renseigné
        private void buttonAjouterAnimal_Click(object sender, EventArgs e)
        {
            GestionAnimaux fenetre = new GestionAnimaux(clientCourant);
            fenetre.ShowDialog();
            AnimalBLL instanceAnimalBll = new AnimalBLL();
            this.comboBoxAnimal.DataSource = instanceAnimalBll.GetAnimauxByClient(clientCourant);
        }

        //private void RefreshListeRendezVous()
        //{

        //}

        private void ChargerDataGridRendezVous()
        {
            //quand le rendez vous est enregistrer afficher dans le data grid, combox client = colonne client ...ETC.. 
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {

        }

    }
}
