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
    /// Logique applicative de Veterinaire
    /// </summary>
    public class VeterinaireBLL
    {
        private VeterinaireDAL instanceDAL = new VeterinaireDAL();

        #region Méthodes CRUD
        /// <summary>
        /// Appelle la méthode Create de la DAL qui insère un vétérinaire dans la bdd
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Create(Veterinaire item)
        {
            return instanceDAL.Create(item);
        }
        /// <summary>
        /// Appelle la méthode Delete de la DAL qui supprime un vétérinaire de la bdd
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Delete(Veterinaire item)
        {
            return instanceDAL.Delete(item);
        }
        /// <summary>
        /// Appelle la méthode Get de la DAL qui retourne la liste de tous les vétérinaires de la bdd
        /// </summary>
        /// <returns></returns>
        public List<Veterinaire> Get()
        {
            return instanceDAL.Get();
        }
        /// <summary>
        /// Appelle la méthode Get de la DAL qui retourne le vétérinaire dont le codeVeto est passé en paramètre
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Veterinaire Get(Guid id)
        {
            return instanceDAL.Get(id);
        }
        /// <summary>
        /// Appelle la méthode Get de la DAL qui retourne la liste des vétérinaire dont le nom contient la chaine
        /// de caractères passée en paramètre
        /// </summary>
        /// <param name="nom"></param>
        /// <returns></returns>
        public List<Veterinaire> Get(string nom)
        {
            return instanceDAL.Get(nom);
        }
        /// <summary>
        /// Appelle la méthode Update de la DAL
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Update(Veterinaire item)
        {
            return instanceDAL.Update(item);
        }
        #endregion
    }
}
