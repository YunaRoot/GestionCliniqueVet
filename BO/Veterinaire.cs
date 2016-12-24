using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// Représente un vétérinaire
    /// </summary>
    public class Veterinaire
    {
        #region champs
        private string nomVeto;
        private string motPasse;
        #endregion

        #region props
        /// <summary>
        /// identifiant unique du vétérinaire
        /// </summary>
        public Guid CodeVeto { get; set; }

        /// <summary>
        /// Booleen qui determine si le dossier est archivé (true si archivé)
        /// </summary>
        public bool Archive { get; set; }

        /// <summary>
        /// Nom du vétérinaire
        /// </summary>
        public string NomVeto
        {
            get { return nomVeto; }
            set { nomVeto = value.ToUpper(); }
        }

        /// <summary>
        /// Mot de passe du vétérinaire
        /// </summary>
        public string MotPasse
        {
            get { return motPasse; }
            set
            { motPasse = value; }
        }
        #endregion

        #region constructeur
        /// <summary>
        /// Constructeur vide du veterinaire
        /// </summary>
        public Veterinaire()
        {

        }

        /// <summary>
        /// Constructeur qui assigne uniquement l'id du vétérinaire (utile lors du Delete)
        /// </summary>
        /// <param name="id"></param>
        public Veterinaire(Guid id) : this ()
        {
            this.CodeVeto = id;
        }

        /// <summary>
        /// Constrcteur qui assigne tous les champs de la classe Veterinaire
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nomVeto"></param>
        /// <param name="motPasse"></param>
        /// <param name="archive"></param>
        public Veterinaire(Guid id, string nomVeto, string motPasse, bool archive = false) : this(id)
        {
            this.NomVeto = nomVeto;
            this.MotPasse = motPasse;
            this.Archive = archive;
        }
        #endregion

        #region Methodes
        public override string ToString()
        {
            return this.NomVeto;
        }
        #endregion
    }
}
