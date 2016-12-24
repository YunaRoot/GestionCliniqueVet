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
    /// Représente la DAL de Vaccin
    /// </summary>
    public class VaccinsDAL
    {
        private const string GET = "SELECT * FROM Vaccins";
        private const string UPDATE_QUANTITE = "UPDATE Vaccins SET QuantiteStock = @quantiteStock WHERE CodeVaccin = @codeVaccin AND Archive = 0";
        /// <summary>
        /// Retourne la liste des vaccins présents dans la bdd et non archivés
        /// </summary>
        /// <returns></returns>
        public List<Vaccin> Get()
        {
            List<Vaccin> listeVaccins = new List<Vaccin>();
            try
            {
                using (SqlConnection cnx = Outils.OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandText = GET;
                    SqlDataReader dr = rqt.ExecuteReader();
                    while (dr.Read())
                    {
                        Vaccin vaccin = new Vaccin();
                        vaccin.CodeVaccin = dr.GetGuid(dr.GetOrdinal("CodeVaccin"));
                        vaccin.NomVaccin = dr.GetString(dr.GetOrdinal("NomVaccin"));
                        vaccin.PeriodeValidite = dr.GetInt32(dr.GetOrdinal("PeriodeValidite"));
                        vaccin.QuantiteStock = dr.GetInt32(dr.GetOrdinal("QuantiteStock"));
                        vaccin.Archive = dr.GetBoolean(dr.GetOrdinal("Archive"));
                        listeVaccins.Add(vaccin);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            return listeVaccins;
        }
        /// <summary>
        /// Modifie la quantité en stock du vaccin passé en paramètre
        /// </summary>
        /// <param name="vaccin"></param>
        /// <returns></returns>
        public bool UpdateQuantite(Vaccin vaccin)
        {
            bool retour = false;
            try
            {
                using (SqlConnection cnx = Outils.OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandText = UPDATE_QUANTITE;
                    rqt.Parameters.AddWithValue("@quantiteStock", vaccin.QuantiteStock);
                    rqt.Parameters.AddWithValue("@codeVaccin", vaccin.CodeVaccin);
                    retour = (rqt.ExecuteNonQuery() > 0);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            return retour;
        }
    }
}
