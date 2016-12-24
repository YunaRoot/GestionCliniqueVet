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
    /// Acces a la BDD pour l'objet Consultation
    /// </summary>
    public class ConsultationBLL
    {
        ConsultationDAL dal = new ConsultationDAL();

        /// <summary>
        /// Insert une consultation dans la BDD
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Create(Consultation item)
        {
            return dal.Create(item);
        }

        /// <summary>
        /// Retourne la consultation possedant l'identifiant envoyé en paramètre
        /// (identifiant : CodeConsultation)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Consultation Get(Guid id)
        {
            return dal.Get(id);
        }

        /// <summary>
        /// Modifie la BDD sur la ligne ayant le CodeConsultation de l'item envoyé en paramètre
        /// Assigne toutes les autres colonnes aux propriétés de l'item
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Update(Consultation item)
        {
            return dal.Update(item);
        }

        /// <summary>
        /// Supprime un element ayant le meme CodeConsultation que l'objet envoyé en paramètre
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Delete(Consultation item)
        {
            return dal.Delete(item);
        }
    }
}
