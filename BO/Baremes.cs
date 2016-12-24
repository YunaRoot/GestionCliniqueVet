using Outils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// Représente les barèmes
    /// </summary>
    public class Baremes
    {
        #region Champs
        private string libelle;
        private double tarifFixe;
        private double tarifMini;
        private double tarifMaxi;
        #endregion

        #region props
        /// <summary>
        /// Code par barème
        /// </summary>
        public string CodeGroupement { get; set; }

        /// <summary>
        /// Date au moment de la consultation et/ou acte
        /// </summary>
        public string DateVigueur { get; set; }

        public string TypeActe { get; set; }

        /// <summary>
        /// Libellé de la consultation et/ou acte
        /// </summary>
        public string Libelle
        {
            get { return libelle; }
            set { libelle = OutilsString.FirstInUpper(Libelle); }
        }

        /// <summary>
        /// Tarif fice de la consultation et/ou acte
        /// </summary>
        public double TarifFixe
        {
            get { return tarifFixe; }
            set { tarifFixe = TarifFixe; }
        }

        /// <summary>
        /// tarif minimum de la consultation et/ou acte
        /// </summary>
        public double TarifMini
        {
            get { return tarifMini; }
            set { tarifMini = TarifMini; }
        }

        /// <summary>
        /// tarif maximum de la consultation et/ou acte
        /// </summary>
        public double TarifMaxi
        {
            get { return tarifMaxi; }
            set { tarifMaxi = TarifMaxi; }
        }

        /// <summary>
        /// Identifiant unique du vaccin
        /// </summary>
        public Guid CodeVaccin { get; set; }

        public bool Archive { get; set; }
        #endregion

        #region Constructeurs
        /// <summary>
        /// Constructeur vide de la classe barèmes
        /// </summary>
        public Baremes()
        {

        }

        public Baremes(string id) : this()
        {
            this.CodeGroupement = id;
        }
        /// <summary>
        /// Constructeur assignant tous les champs et propirétés a la classe barèmes
        /// </summary>
        /// <param name="codeGroupement"></param>
        /// <param name="dateVigeur"></param>
        /// <param name="typeActe"></param>
        /// <param name="libelle"></param>
        /// <param name="tarifFixe"></param>
        /// <param name="tarifMini"></param>
        /// <param name="tarifMaxi"></param>
        /// <param name="codeVaccin"></param>
        /// <param name="archive"></param>
        public Baremes(string codeGroupement, string dateVigeur, string typeActe, string libelle, double tarifFixe, double tarifMini, double tarifMaxi, Guid codeVaccin, bool archive)
        {
            this.CodeGroupement = codeGroupement;
            this.DateVigueur = dateVigeur;
            this.TypeActe = typeActe;
            this.Libelle = libelle;
            this.TarifFixe = tarifFixe;
            this.TarifMini = tarifMini;
            this.TarifMaxi = tarifMaxi;
            this.CodeVaccin = codeVaccin;
            this.Archive = archive;
        }

        #endregion

        #region Méthodes
        public override string ToString()
        {
            return this.TypeActe;
        }

        #endregion
    }
}
