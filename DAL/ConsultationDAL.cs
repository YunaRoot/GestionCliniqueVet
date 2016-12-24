using BO;
using Outils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConsultationDAL : ICrud<Consultation>
    {
        private const string COL_CODECONSULTATION = "CodeConsultation";
        private const string COL_DATECONSULTATION = "DateConsultation";
        private const string COL_CODEVETO = "CodeVeto";
        private const string COL_CODEANIMAL = "CodeAnimal";
        private const string COL_COMMENTAIRE = "Commentaire";
        private const string COL_ETAT = "Etat";
        private const string COL_NUMFACTURE = "NumFacture";
        private const string COL_ARCHIVE = "Archive";

        AnimalDAL dalAnimal = new AnimalDAL();
        VeterinaireDAL dalVeto = new VeterinaireDAL();
        FactureDAL dalFacture = new FactureDAL();

        /// <summary>
        /// Insert une consultation dans la BDD
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Create(Consultation item)
        {
            bool result = false;
            try
            {
                using (SqlConnection cnx = OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandType = System.Data.CommandType.Text;
                    rqt.CommandText = "INSERT INTO Consultations VALUES (NEWID(), @DateConsultation, @CodeVeto"
                                      +", @CodeAnimal, @Commentaire, @Etat, @NumFacture, @Archive);";
                    rqt.Parameters.AddWithValue("@DateConsultation", item.Date);
                    rqt.Parameters.AddWithValue("@CodeVeto", item.Veto.CodeVeto);
                    rqt.Parameters.AddWithValue("@CodeAnimal", item.AnimalConsulte.CodeAnimal);
                    rqt.Parameters.AddWithValue("@Commentaire", item.Commentaire);
                    rqt.Parameters.AddWithValue("@Etat", byte.Parse(item.Etat.ToString()));
                    rqt.Parameters.AddWithValue("@NumFacture", item.facture.NumFacture);
                    rqt.Parameters.AddWithValue("@Archive", item.Archive);

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
        /// Retourne la consultation possedant l'identifiant envoyé en paramètre
        /// (identifiant : CodeConsultation)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Consultation Get(Guid id)
        {
            Consultation consultation = null;
            try
            {
                using (SqlConnection cnx = OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandType = System.Data.CommandType.Text;
                    rqt.CommandText = "SELECT * FROM Consultations c WHERE c.CodeConsultation = @CodeConsultation;" ;
                    rqt.Parameters.AddWithValue("CodeConsultation", id);
                    SqlDataReader dr = rqt.ExecuteReader();

                    if (dr.Read())
                    {
                        consultation = ItemBuilder(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            return consultation;
        }

        /// <summary>
        /// Modifie la BDD sur la ligne ayant le CodeConsultation de l'item envoyé en paramètre
        /// Assigne toutes les autres colonnes aux propriétés de l'item
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Update(Consultation item)
        {
            bool result = false;
            try
            {
                using (SqlConnection cnx = OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandType = System.Data.CommandType.Text;
                    rqt.CommandText = "UPDATE Consultations SET DateConsultation = @DateConsultation, CodeVeto = @CodeVeto" +
                                        ", CodeAnimal = @CodeAnimal, Commentaire = @Commentaire, Etat = @Etat, NumFacture = @NumFacture" +
                                        ",Archive = @Archive WHERE CodeConsultation = @CodeConsultation;";

                    rqt.Parameters.AddWithValue("@CodeConsultation", item.CodeConsultation);
                    rqt.Parameters.AddWithValue("@DateConsultation", item.Date);
                    rqt.Parameters.AddWithValue("@CodeVeto", item.Veto.CodeVeto);
                    rqt.Parameters.AddWithValue("@CodeAnimal", item.AnimalConsulte.CodeAnimal);
                    rqt.Parameters.AddWithValue("@Commentaire", item.Commentaire);
                    rqt.Parameters.AddWithValue("@Etat", byte.Parse(item.Etat.ToString()));
                    rqt.Parameters.AddWithValue("@NumFacture", item.facture.NumFacture);
                    rqt.Parameters.AddWithValue("@Archive", item.Archive);

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
        /// Supprime un element ayant le meme CodeConsultation que l'objet envoyé en paramètre
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Delete(Consultation item)
        {
            bool result = false;
            try
            {
                using (SqlConnection cnx = OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandType = System.Data.CommandType.Text;
                    rqt.CommandText = "DELETE Consultations WHERE CodeConsultation = @CodeConsultation;";
                    rqt.Parameters.AddWithValue("@CodeConsultation", item.CodeConsultation);

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
        /// Creer un objet Consultation avec les éléments de la ligne en cours de la DATAREADER envoyé en paramètre
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        private Consultation ItemBuilder(SqlDataReader dr)
        {
            Consultation consultation = new Consultation();
                
            consultation.CodeConsultation = dr.GetGuid(dr.GetOrdinal(COL_CODEANIMAL));
            consultation.AnimalConsulte = dalAnimal.Get(dr.GetGuid(dr.GetOrdinal(COL_CODEANIMAL)));
            consultation.Archive = dr.GetBoolean(dr.GetOrdinal(COL_ARCHIVE));
            consultation.Commentaire = dr.GetString(dr.GetOrdinal(COL_COMMENTAIRE));
            consultation.Date = dr.GetDateTime(dr.GetOrdinal(COL_DATECONSULTATION));
            consultation.Etat = (EEtatConsultation)dr.GetInt16(dr.GetOrdinal(COL_ETAT));
            consultation.facture = dalFacture.Get(dr.GetGuid(dr.GetOrdinal(COL_NUMFACTURE)));
            consultation.Veto = dalVeto.Get(dr.GetGuid(dr.GetOrdinal(COL_CODEVETO)));

            return consultation;
        }

    }
}
