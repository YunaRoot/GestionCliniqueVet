using Outils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Vaccin
    {
        #region Champs
        private string nomVaccin;

        #endregion

        #region Props
        /// <summary>
        /// Identifiant unique du vaccin
        /// </summary>
        public Guid CodeVaccin { get; set; }

        /// <summary>
        /// Nom du vaccin
        /// </summary>
        public string NomVaccin
        {
            get { return nomVaccin; }
            set { nomVaccin = OutilsString.FirstInUpper(value); }
        }

        /// <summary>
        /// Determine le nombre de vaccin restant
        /// </summary>
        public int QuantiteStock { get; set; }

        /// <summary>
        /// Determine la durée de validité du vaccin
        /// </summary>
        public int PeriodeValidite { get; set; }

        /// <summary>
        /// Determine si le dossier est archivé ou non
        /// </summary>
        public bool Archive { get; set; }
        #endregion

        #region Constructeurs
        /// <summary>
        /// Constructeur vide de la classe Vaccin
        /// </summary>
        public Vaccin()
        {

        }

        /// <summary>
        /// Constructeur assignant uniquement un Identifiant unique (utile pour le delete)
        /// </summary>
        /// <param name="id"></param>
        public Vaccin(Guid id) : this()
        {
            this.CodeVaccin = id;
        } 

        /// <summary>
        /// Constructeur assignant tous les champs et propriétés de la classe Vaccin
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nomVaccin"></param>
        /// <param name="qte"></param>
        /// <param name="validite"></param>
        /// <param name="archive"></param>
        public Vaccin(Guid id, string nomVaccin, int qte, int validite, bool archive = false) : this(id)
        {
            this.NomVaccin = nomVaccin;
            this.QuantiteStock = qte;
            this.PeriodeValidite = validite;
            this.Archive = archive;
        }
        #endregion

        #region Methodes

        public override string ToString()
        {
            return this.NomVaccin;
        }
        #endregion


    }
}
