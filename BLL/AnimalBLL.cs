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
    /// Acces a la BDD pour l'objet Animal
    /// </summary>
    public class AnimalBLL
    {
        private AnimalDAL instanceDAL = new AnimalDAL();

        #region Méthodes CRUD
        /// <summary>
        /// Appelle la méthode Create de la DAL qui insère un Animal dans la bdd
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Create(Animal item)
        {
            return instanceDAL.Create(item);
        }
        /// <summary>
        /// Appelle la méthode Delete de la DAL qui supprime un Animal de la bdd
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Delete(Animal item)
        {
            return instanceDAL.Delete(item);
        }
        /// <summary>
        /// Appelle la méthode Get de la DAL qui retourne la liste de tous les Animaux de la bdd
        /// </summary>
        /// <returns></returns>
        public List<Animal> Get()
        {
            return null;
        }
        /// <summary>
        /// Appelle la méthode Get de la DAL qui retourne l'Animal dont le codeVeto est passé en paramètre
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Animal Get(Guid id)
        {
            return instanceDAL.Get(id);
        }
        /// <summary>
        /// Appelle la méthode Get de la DAL qui retourne la liste des Animaux dont le nom contient la chaine
        /// de caractères passée en paramètre
        /// </summary>
        /// <param name="nom"></param>
        /// <returns></returns>
        public List<Animal> Get(string nom)
        {
            return instanceDAL.GetListByName(nom);
        }
        /// <summary>
        /// Retourne le premier résultat de la recherche d'animal par tatouage(partiel ou nom)
        /// </summary>
        /// <param name="tatouage"></param>
        /// <returns></returns>
        public Animal GetAnimalByTatoo(string tatouage)
        {
            return instanceDAL.GetAnimalByTatoo(tatouage);
        }
        /// <summary>
        /// Retourne le premier animal enregistré du client envoyé en paramètre
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public Animal Get(Client c)
        {
            return instanceDAL.Get(c);
        }
        /// <summary>
        /// Appelle la méthode GetAnimauxByClient de la DAL qui retourne la liste des animaux du client 
        /// passé en paramètre
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public List<Animal> GetAnimauxByClient(Client client)
        {
            return instanceDAL.GetAnimauxByClient(client);
        }
        /// <summary>
        /// Appelle la méthode Update de la DAL
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Update(Animal item)
        {
            return instanceDAL.Update(item);
        }
        #endregion
    }
}
