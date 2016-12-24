using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class RendezVous
    {

        #region Props
        /// <summary>
        /// Identifiant du veterinaire
        /// </summary>
        public Veterinaire veto { get; set; }

        /// <summary>
        /// Identifiant du client
        /// </summary>
        public Client client { get; set; }

        /// <summary>
        /// Identifiant de l'animal
        /// </summary>
        public Animal animal { get; set; }
        #endregion

        #region constructeurs

        public RendezVous()
        {

        }
        public RendezVous(Veterinaire veterinaire, Client client, Animal animal)
        {
            this.veto = veterinaire;
            this.animal = animal;
            this.client = client;
        }


        #endregion

        #region Méthodes
        public override string ToString()
        {
            return string.Format("{0}\n{1}\n{2}", this.veto.ToString(), this.client.ToString(), this.animal.ToString());
        }

        #endregion
    }
}
