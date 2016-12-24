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
    /// Lie l'IHM et la dal Baremes
    /// </summary>
    public class BaremeBLL
    {
        private BaremeDAL dalBareme = new BaremeDAL();

        /// <summary>
        /// Insert un bareme dans la BDD
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Create(Baremes item)
        {
            return dalBareme.Create(item);
        }

        /// <summary>
        /// Recupere un bareme en fonction de son identifiant unique
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Baremes Get(Guid id)
        {
            return dalBareme.Get(id);
        }

        /// <summary>
        /// Met a jour un bareme de la BDD
        /// Utilise l'id unique de l'item evoyé en paramètre et modifie l'integralites des autres propriétés
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Update(Baremes item)
        {
            return dalBareme.Update(item);
        }

        /// <summary>
        /// Supprime le bareme de la BDD qui possede le meme ID unique que le parametre 'item'
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Delete(Baremes item)
        {
            return dalBareme.Delete(item);
        }

        /// <summary>
        /// Recupere l'ensemble des Baremes de la BDD sous forme de liste
        /// </summary>
        /// <returns></returns>
        public List<Baremes> Get()
        {
            return this.dalBareme.Get();
        }

        /// <summary>
        /// Retourne l'ensemble des Libelle des actes en fonctions du TypeActe selectionner 
        /// (a utiliser uniquement pour l'affichage)
        /// </summary>
        /// <param name="typeActe"></param>
        /// <returns></returns>
        public List<string> GetLibelleByType(string typeActe)
        {
            List<string> liste = new List<string>();
            foreach (Baremes item in dalBareme.Get())
            {
                if(item.TypeActe == typeActe)
                {
                    liste.Add(item.Libelle);
                }
            }
            return liste;
        }
    }
}
