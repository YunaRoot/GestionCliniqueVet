using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RelancesBLL
    {
        private RelancesDAL instanceRelancesDal = new RelancesDAL();
        /// <summary>
        /// Retourne la méthode Get de la DAL qui retourne le client, l'animal et la date de fin de validité du vaccin 
        /// pour tous les animaux qui ont un vaccin qui expire dans 15 jours ou moins
        /// </summary>
        /// <returns></returns>
        public List<Relance> Get()
        {
            return instanceRelancesDal.Get();
        }
    }
}
