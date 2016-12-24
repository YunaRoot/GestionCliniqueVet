using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// Représente une consultation
    /// </summary>
    public class Consultation
    {
        #region prop
        /// <summary>
        /// Identifiant unique de la classe Consultation
        /// </summary>
        public Guid CodeConsultation { get; set; }

        /// <summary>
        /// Date de la consultation
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Veterinaire ayant effectué la consultation
        /// </summary>
        public Veterinaire Veto { get; set; }
        
        /// <summary>
        /// Animal examiné pendant la consultation
        /// </summary>
        public Animal AnimalConsulte { get; set; }

        /// <summary>
        /// Commentaire du vétérinaire concernant la consultation
        /// </summary>
        public string Commentaire { get; set; }

        /// <summary>
        /// Facture de la consultation
        /// </summary>
        public Facture facture { get; set; }

        /// <summary>
        /// Determine si la consultation est archivé ou non
        /// </summary>
        public bool Archive { get; set; }

        /// <summary>
        /// Etat de la consultation : En cours de saisie, saisie terminé, facture générée
        /// </summary>
        public EEtatConsultation Etat { get; set; }
        #endregion

        #region constructeurs
        /// <summary>
        /// Constructeur vide
        /// </summary>
        public Consultation()
        {

        }

        /// <summary>
        /// Constructeur assignant uniquement un CodeConsultation (utile pour le delete)
        /// </summary>
        /// <param name="id"></param>
        public Consultation(Guid id)
        {
            this.CodeConsultation = id;
        }
        #endregion
        
        #region methodes
        public override string ToString()
        {
            return string.Format("Etat : {0} \n{1} \n{2} \n{3}",
                                this.Etat.ToString(), this.Veto.ToString(), this.AnimalConsulte.ToString(), this.facture.ToString());
        }
        #endregion

    }
}
