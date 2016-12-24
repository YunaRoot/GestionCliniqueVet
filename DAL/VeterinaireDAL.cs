using BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// Gère la persistance des vétérinaires
    /// </summary>
    public class VeterinaireDAL : ICrud<Veterinaire>
    {
        private const string INSERT = "ajout_veterinaire";
        private const string GET = "lecture_veterinaires";
        private const string GET_BY_ID = "lecture_veterinaire_id";
        private const string GET_BY_NAME = "lecture_veterinaires_nom";
        private const string UPDATE = "modification_veterinaire";
        private const string DELETE = "suppression_veterinaire";

        private const string COL_CODE_VETO = "CodeVeto";
        private const string COL_NOM_VETO = "NomVeto";
        private const string COL_MOT_PASSE = "MotPasse";
        private const string COL_ARCHIVE = "Archive";

        #region Méthodes CRUD
        /// <summary>
        /// Enregistre dans la Bdd l'objet vétérinaire passé en paramètre
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Retourne true si l'insertion a réussi, false si elle a échoué</returns>
        public bool Create(Veterinaire item)
        {
            bool result = false;
            try
            {
                using (SqlConnection cnx = Outils.OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandText = INSERT;
                    rqt.CommandType = System.Data.CommandType.StoredProcedure;
                    rqt.Parameters.AddWithValue("@nomveto", item.NomVeto);
                    rqt.Parameters.AddWithValue("@motpasse", item.MotPasse);
                    int archive = VerifierArchive(item);
                    rqt.Parameters.AddWithValue("@archive", archive);
                    result = (rqt.ExecuteNonQuery() > 0);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Supprime de la Bdd l'objet vétérinaire passé en paramètre
        /// </summary>
        /// <param name="item"></param>
        /// <returns>True si réussite, false si échec</returns>
        public bool Delete(Veterinaire item)
        {
            bool result = false;
            try
            {
                using (SqlConnection cnx = Outils.OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandText = DELETE;
                    rqt.CommandType = System.Data.CommandType.StoredProcedure;
                    rqt.Parameters.AddWithValue("@codeveto", item.CodeVeto);
                    result = (rqt.ExecuteNonQuery() > 0);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Retourne la liste de tous les vétérinaires de la bdd
        /// </summary>
        /// <returns></returns>
        public List<Veterinaire> Get()
        {
            List<Veterinaire> listeVeterinaires = new List<Veterinaire>();
            try
            {
                using (SqlConnection cnx = Outils.OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandText = GET;
                    rqt.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader dr = rqt.ExecuteReader();
                    while (dr.Read())
                    {
                        Veterinaire veterinaire = ItemBuilder(dr);
                        listeVeterinaires.Add(veterinaire);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            return listeVeterinaires;
        }
        /// <summary>
        /// Récupère dans la Bdd l'objet vétérinaire dont le codeVeto est passé en paramètre
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Veterinaire Get(Guid id)
        {
            Veterinaire veterinaire = new Veterinaire();
            try
            {
                using (SqlConnection cnx = Outils.OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandText = GET_BY_ID;
                    rqt.CommandType = System.Data.CommandType.StoredProcedure;
                    rqt.Parameters.AddWithValue("@codeVeto", id);
                    SqlDataReader dr = rqt.ExecuteReader();
                    if (dr.Read())
                    {
                        veterinaire = ItemBuilder(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }

            return veterinaire;
        }
        /// <summary>
        /// Récupère dans la bdd la liste des vétérinaires dont le nom contient la chaine de caractères 
        /// passée en paramètre
        /// </summary>
        /// <param name="nom"></param>
        /// <returns></returns>
        public List<Veterinaire> Get(string nom)
        {
            List<Veterinaire> listeVeterinaires = new List<Veterinaire>();
            try
            {
                using (SqlConnection cnx = Outils.OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandType = System.Data.CommandType.StoredProcedure;
                    rqt.CommandText = GET_BY_NAME;
                    rqt.Parameters.AddWithValue("@nomVeto", nom);
                    SqlDataReader dr = rqt.ExecuteReader();
                    while (dr.Read())
                    {
                        Veterinaire veterinaire = ItemBuilder(dr);
                        listeVeterinaires.Add(veterinaire);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            return listeVeterinaires;
        }
        /// <summary>
        /// Met à jour l'objet vétérinaire passé en paramètre
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Update(Veterinaire item)
        {
            bool result = false;
            try
            {
                using (SqlConnection cnx = Outils.OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandText = UPDATE;
                    rqt.CommandType = System.Data.CommandType.StoredProcedure;
                    rqt.Parameters.AddWithValue("@codeVeto", item.CodeVeto);
                    rqt.Parameters.AddWithValue("@nomVeto", item.NomVeto);
                    rqt.Parameters.AddWithValue("@motPasse", item.MotPasse);
                    rqt.Parameters.AddWithValue("@archive", item.Archive);
                    result = (rqt.ExecuteNonQuery() > 0);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }

            return result;
        }
        #endregion

        #region Méthodes privées
        /// <summary>
        /// Vérifie le satut du vétérinaire entré en paramètre vis-à-vis de l'archivage
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Retourne 1 si archivé, 0 si non archivé</returns>
        private int VerifierArchive(Veterinaire item)
        {
            if (item.Archive)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Construit un objet Veterinaire à partir d'un enregistrement
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        private Veterinaire ItemBuilder(SqlDataReader dr)
        {
            Veterinaire veterinaire = new Veterinaire();
            veterinaire.CodeVeto = dr.GetGuid(dr.GetOrdinal(COL_CODE_VETO));
            veterinaire.NomVeto = dr.GetString(dr.GetOrdinal(COL_NOM_VETO));
            veterinaire.MotPasse = dr.GetString(dr.GetOrdinal(COL_MOT_PASSE));
            veterinaire.Archive = dr.GetBoolean(dr.GetOrdinal(COL_ARCHIVE));
            
            return veterinaire;
        }
        #endregion
    }
}
