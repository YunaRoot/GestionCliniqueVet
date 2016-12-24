using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// Représente une facture
    /// </summary>
    public class Facture
    {
        #region Attributs
        private Guid numFacture;
        private DateTime dateFacture;
        private Client client;
        private double totalFacture;
        private bool archive;
        private int etat;
        private DateTime rappelEnvoye;
        #endregion

        #region Propriétés
        /// <summary>
        /// Identifiant unique de la facture
        /// </summary>
        public Guid NumFacture
        {
            get
            {
                return this.numFacture;
            }
            set
            {
                this.numFacture = value;
            }
        }
        /// <summary>
        /// Date d'émission de la facture
        /// </summary>
        public DateTime DateFacture
        {
            get
            {
                return this.dateFacture;
            }
            set
            {
                this.dateFacture = value;
            }
        }
        /// <summary>
        /// Client associé à la facture
        /// </summary>
        public Client Client
        {
            get
            {
                return this.client;
            }
            set
            {
                this.client = value;
            }
        }
        /// <summary>
        /// Montant total de la facture
        /// </summary>
        public double TotalFacture
        {
            get
            {
                return this.totalFacture;
            }
            set
            {
                this.totalFacture = value;
            }
        }
        /// <summary>
        /// Etat d'archivage : true => archivé, false => en cours
        /// </summary>
        public bool Archive
        {
            get
            {
                return this.archive;
            }
            set
            {
                this.archive = value;
            }
        }
        /// <summary>
        /// Etat de la facture
        /// </summary>
        public int Etat
        {
            get
            {
                return this.etat;
            }
            set
            {
                this.etat = value;
            }
        }
        /// <summary>
        /// Date de l'envoi du rappel
        /// </summary>
        public DateTime RappelEnvoye
        {
            get
            {
                return this.rappelEnvoye;
            }
            set
            {
                this.rappelEnvoye = value;
            }
        }
        #endregion

        #region Constructeurs
        /// <summary>
        /// Constructeur vide
        /// </summary>
        public Facture()
        {

        }
        /// <summary>
        /// Constructeur prenant en paramètre tous les attributs (hors numFacture géré par la bdd)
        /// </summary>
        /// <param name="dateFacture"></param>
        /// <param name="client"></param>
        /// <param name="totalFacture"></param>
        /// <param name="archive"></param>
        /// <param name="etat"></param>
        /// <param name="rappelEnvoye"></param>
        public Facture(DateTime dateFacture, Client client, double totalFacture, bool archive, int etat, 
            DateTime rappelEnvoye) : this()
        {
            this.DateFacture = dateFacture;
            this.Client = client;
            this.TotalFacture = totalFacture;
            this.Archive = archive;
            this.Etat = etat;
            this.RappelEnvoye = rappelEnvoye;
        }
        #endregion

        #region Méthodes publiques
        public override string ToString()
        {
            return string.Format("Facture n°{0} du {1}\r\nClient : {2}, montant : {3} euros\r\nArchive : {4}, état : {5}",
                this.NumFacture, this.DateFacture, this.Client.ToString(), this.TotalFacture, this.Archive, this.Etat);
        }
        #endregion
    }
}
