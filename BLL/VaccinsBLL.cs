using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    /// <summary>
    /// Représente la BLL de Vaccin
    /// </summary>
    public class VaccinsBLL
    {
        private VaccinsDAL instanceVaccinsDal = new VaccinsDAL();

        /// <summary>
        /// Appelle la méthode Get() de la DAL qui retourne la liste des vaccins présents dans la bdd et non archivés
        /// </summary>
        /// <returns></returns>
        public List<Vaccin> Get()
        {
            return instanceVaccinsDal.Get();
        }
        /// <summary>
        /// Appelle la méthode UpdateQuantite(Vaccin vaccin) de la DAL qui modifie la quantité en stock du vaccin passé en paramètre
        /// </summary>
        /// <param name="vaccin"></param>
        /// <returns></returns>
        public bool UpdateQuantite(Vaccin vaccin)
        {
            return instanceVaccinsDal.UpdateQuantite(vaccin);
        }
    }
}
