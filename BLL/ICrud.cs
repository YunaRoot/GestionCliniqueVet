using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    /// <summary>
    /// interface CRUD de la BLL
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICrud <T>
    {
        /// <summary>
        /// ICrud : Insert
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        bool Create(T item);

        /// <summary>
        /// ICrud : Read. Retourne un objet possedant l'identifiant envoyé en paramètre.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T Get(Guid id);

        /// <summary>
        /// ICrud : update
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        bool Update(T item);

        /// <summary>
        /// ICrud : Delete
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        bool Delete(T item);
        // L'objet envoyé en paramètre possède uniquement un ID, le reste des propriétés
        // sont null (constructeurs a créer pour le delete)
    }
}
