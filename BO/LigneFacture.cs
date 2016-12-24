using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// Représente une ligne d'une facture
    /// </summary>
    public class LigneFacture
    {
        #region Attributs
        private Guid numFacture;
        private long numLigne;
        private string codeGroupement;
        private double prix;
        private bool archive;
        #endregion

        #region Propriétés
        /// <summary>
        /// Numéro unique de la facture
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
        /// Numéro de la ligne dans la facture
        /// </summary>
        public long NumLigne
        {
            get
            {
                return this.numLigne;
            }
            set
            {
                this.numLigne = value;
            }
        }
        /// <summary>
        /// Code du groupement en 3 caractères
        /// </summary>
        public string CodeGroupement
        {
            get
            {
                return this.codeGroupement;
            }
            set
            {
                this.codeGroupement = value.ToUpper();
            }
        }
        /// <summary>
        /// Prix de la ligne de la facture
        /// </summary>
        public double Prix
        {
            get
            {
                return this.prix;
            }
            set
            {
                this.prix = value;
            }
        }
        /// <summary>
        /// Détermine l'état de la ligne de la facture : 0 => en cours, 1 => archivé
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
        #endregion

        #region Constructeurs
        /// <summary>
        /// Constructeur vide
        /// </summary>
        public LigneFacture()
        {

        }

        /// <summary>
        /// Constructeur qui assigne toutes ses valeurs à LigneFacture
        /// </summary>
        /// <param name="numLigne"></param>
        /// <param name="codeGroupement"></param>
        /// <param name="prix"></param>
        /// <param name="archive"></param>
        public LigneFacture(long numLigne, string codeGroupement, double prix, bool archive) : this()
        {
            this.NumLigne = numLigne;
            this.CodeGroupement = codeGroupement;
            this.Prix = prix;
            this.Archive = archive;
        }
        #endregion

        #region Méthodes publiques
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}
