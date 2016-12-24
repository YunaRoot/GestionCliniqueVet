using Outils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// Représente un client
    /// </summary>
    public class Client
    {
        #region Champs
        private string nomClient;
        private string prenomClient;
        private string adresse1;
        private string adresse2;
        private string codePostal;
        private string ville;
        private string numTel;
        private string assurance;
        private string email;
        #endregion

        #region Props
        /// <summary>
        /// Identifiant unique du client
        /// </summary>
        public Guid CodeClient { get; set; }

        /// <summary>
        /// Remarque du client
        /// </summary>
        public string Remarque { get; set; }

        /// <summary>
        /// Determine si le client est archivé ou non
        /// </summary>
        public bool Archive { get; set; }

        /// <summary>
        /// Nom du client (enregistré en majuscule)
        /// </summary>
        public string NomClient
        {
            get { return nomClient; }
            set { nomClient = value.ToUpper(); }
        }

        /// <summary>
        /// Prenom du client (enregistré en FirstInUpper)
        /// </summary>
        public string PrenomClient
        {
            get { return prenomClient; }
            set { prenomClient = OutilsString.FirstInUpper(value); }
        }

        /// <summary>
        /// Premiere partie de l'adresse du client
        /// </summary>
        public string Adresse1
        {
            get { return adresse1; }
            set { adresse1 = OutilsString.FirstInUpper(value); }
        }

        /// <summary>
        /// Precision sur l'adresse (batiment, etage ...)
        /// </summary>
        public string Adresse2
        {
            get { return adresse2; }
            set { adresse2 = value; }
        }

        /// <summary>
        /// Code postal du client 
        /// </summary>
        public string CodePostal
        {
            get { return codePostal; }
            set
            {
                //OutilsString.VerifCodePostal(value);
                codePostal = value;
            }
        }

        /// <summary>
        /// Ville du client
        /// </summary>
        public string Ville
        {
            get { return ville; }
            set { ville = value.ToUpper(); }
        }

        /// <summary>
        /// Numéro de téléphone du client
        /// </summary>
        public string NumTel
        {
            get { return numTel; }
            set
            {
                //string valueFormate = OutilsString.FormatageNumTel(value);
                //OutilsString.VerifNumTel(valueFormate);
                numTel = value;
            }
        }

        /// <summary>
        /// Nom de l'assurance du client
        /// </summary>
        public string Assurance
        {
            get { return assurance; }
            set { assurance = value.ToUpper(); }
        }

        /// <summary>
        /// Adresse electronique du client
        /// </summary>
        public string Email
        {
            get { return email; }
            set { email = value.ToLower(); }
        }
        #endregion

        #region Constructeurs
        /// <summary>
        /// Constructeur vide de la classe Client
        /// </summary>
        public Client()
        {
            //this.CodeClient = Guid.NewGuid();
        }

        /// <summary>
        /// Constructeur qui assigne uniquement l'identifiant (utile pour la methode Delete du CRUD)
        /// </summary>
        /// <param name="id"></param>
        public Client(Guid id)
        {
            this.CodeClient = id;
        }

        /// <summary>
        /// Constructeur assignant tous les champs de la classe Client
        /// </summary>
        /// <param name="nomClient"></param>
        /// <param name="prenomClient"></param>
        /// <param name="adresse1"></param>
        /// <param name="adresse2"></param>
        /// <param name="codePostal"></param>
        /// <param name="ville"></param>
        /// <param name="numTel"></param>
        /// <param name="assurance"></param>
        /// <param name="email"></param>
        public Client(string nomClient, string prenomClient, string adresse1, string adresse2, string codePostal
                        , string ville, string numTel, string assurance, string email, string remarque = null
                        , bool archive = false) : this()
        {
            this.NomClient = nomClient;
            this.PrenomClient = prenomClient;
            this.Adresse1 = adresse1;
            this.Adresse2 = adresse2;
            this.CodePostal = codePostal;
            this.Ville = ville;
            this.NumTel = numTel;
            this.Assurance = assurance;
            this.Email = email;
            this.Remarque = remarque;
            this.Archive = archive;
        }
        #endregion

        #region Methodes
        public override string ToString()
        {
            return this.NomClient + " " + this.PrenomClient;
        }
        #endregion


    }
}
