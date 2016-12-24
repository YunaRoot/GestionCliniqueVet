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
    /// Logique applicative de Client
    /// </summary>
    public class ClientBLL
    {
        private ClientDAL instanceDal = new ClientDAL();
        #region Constructeur
        /// <summary>
        /// Constructeur vide
        /// </summary>
        public ClientBLL()
        {

        }
        #endregion

        #region Méthodes du CRUD
        /// <summary>
        /// Appelle la methode Create de la DAL
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Create(Client item)
        {
            return instanceDal.Create(item);
        }
        /// <summary>
        /// Appelle la methode Get par id de la DAL
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Client Get(Guid id)
        {
            return instanceDal.Get(id);
        }
        /// <summary>
        /// Appelle la methode Get par nom de la DAL
        /// </summary>
        /// <param name="nom"></param>
        /// <returns></returns>
        public Client Get(string nom, int position = 1)
        {
            return instanceDal.Get(nom, position);
        }

        /// <summary>
        /// Appele de la methode Get(liste) par nom de la DAL
        /// </summary>
        /// <param name="nom"></param>
        /// <returns></returns>
        public List<Client> GetList(string nom)
        {
            return instanceDal.GetList(nom);
        }

        /// <summary>
        /// Appelle la methode Update de la DAL
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Update(Client item)
        {
            return instanceDal.Update(item);
        }
        /// <summary>
        /// Appelle la methode Delete de la DAL
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Delete(Client item)
        {
            return instanceDal.Delete(item);
        }
        /// <summary>
        /// Appelle la méthode GetNbClients de la DAL
        /// </summary>
        /// <returns></returns>
        public int GetNbClients()
        {
            return instanceDal.GetNbClients();
        }
        /// <summary>
        /// Appelle la méthode GetNbClients prenant une chaine de caractères en paramètre de la DAL
        /// </summary>
        /// <param name="nom"></param>
        /// <returns></returns>
        public int GetNbClients(string nom)
        {
            return instanceDal.GetNbClients(nom);
        }
        /// <summary>
        /// Appelle la méthode GetPositionClient en fonction d'une chaine de caractères passé en paramètre
        /// </summary>
        /// <param name="nom"></param>
        /// <returns></returns>
        public int GetPositionClient(string nom, string prenom = "")
        {
            return instanceDal.GetPositionClient(nom, prenom);
        }
        #endregion
    }
}
