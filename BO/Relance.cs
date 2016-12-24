using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// Représente un objet Relance
    /// </summary>
    public class Relance
    {
        /// <summary>
        /// Représente le client concerné par la relance courante
        /// </summary>
        public Client client { get; set; }
        /// <summary>
        /// Représente l'animal concerné par la relance courante
        /// </summary>
        public Animal animal { get; set; }
        /// <summary>
        /// Représente la date de fin de validité du vaccin
        /// </summary>
        public DateTime dateFinValidite { get; set; }
    }
}
