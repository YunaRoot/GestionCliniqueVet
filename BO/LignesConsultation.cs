using Outils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// Represente les commentaires d'une consultation
    /// </summary>
    public class LignesConsultation
    {
        #region Champs
        private string codeGroupement;
        private string dateVigueur;
        #endregion

        #region Props
        /// <summary>
        /// Identifiant unique de la classe
        /// </summary>
        public Guid CodeConsultation { get; set; }

        /// <summary>
        /// Nombre de lignes du texte lié a la consultation
        /// </summary>
        public long NumLigne { get; set; }
        
        /// <summary>
        /// Prix de facturation 
        /// </summary>
        public double Prix { get; set; }

        /// <summary>
        /// Booleen determinanat si le rappel a été envoyé
        /// </summary>
        public bool RappelEnvoye { get; set; }

        /// <summary>
        /// Booleen determinant si le dossier est archivé
        /// </summary>
        public bool Archive { get; set; }

        /// <summary>
        /// Code lié au bareme
        /// </summary>
        public string CodeGroupement
        {
            get { return codeGroupement; }
            set
            {
                if(value.Length!=3)
                {
                    throw new ApplicationException("Taille du code groupement invalide");
                }
                codeGroupement = value;
            }
        }

        /// <summary>
        /// Date liée au bareme
        /// </summary>
        public string DateVigueur
        {
            get { return dateVigueur; }
            set
            {
                OutilsString.VerifDateString(value);
                dateVigueur = value;
            }
        }
        #endregion

        #region constructeurs
        /// <summary>
        /// Constructeur vide de la classe LignesConsultation
        /// </summary>
        public LignesConsultation()
        {

        }

        /// <summary>
        /// Constructeur assignant uniquement le CodeConsultation (utile pour le delete)
        /// </summary>
        /// <param name="id"></param>
        public LignesConsultation(Guid id) : this()
        {
            this.CodeConsultation = id;
        }
        #endregion

        #region methodes
        public override string ToString()
        {
            return string.Format("Code Consultation : {0}\nNumLigne : {0}\nPrix : {0}\nRappele Envoye : {0}\n"+
                                "Archive : {0}\nCodeGroupement : {0}\nDate en vigueur : {0}\n",
                                this.CodeConsultation, this.NumLigne, this.Prix, this.RappelEnvoye,
                                this.Archive, this.CodeGroupement, this.DateVigueur);
        }
        #endregion
    }
}
