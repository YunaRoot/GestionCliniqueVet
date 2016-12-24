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
    /// Représente la DAL de Relance
    /// </summary>
    public class RelancesDAL
    {
        private const string GET = "SELECT * FROM Consultations C " +
            "JOIN LignesConsultations LC ON LC.CodeConsultation = C.CodeConsultation " +
            "JOIN Baremes B ON B.CodeGroupement = LC.CodeGroupement AND B.DateVigueur = LC.DateVigueur " +
            "JOIN Vaccins V ON V.CodeVaccin = B.CodeVaccin " +
            "JOIN Animaux A ON A.CodeAnimal = C.CodeAnimal " +
            "JOIN Clients CL ON CL.CodeClient = A.CodeClient " +
            "WHERE B.TypeActe LIKE 'VACC' AND LC.RappelEnvoye = 0;";
        private const int DELAI_POUR_RELANCE = 15;
        private ClientDAL instanceClientDAL = new ClientDAL();
        private AnimalDAL instanceAnimalDAL = new AnimalDAL();

        /// <summary>
        /// Retourne le client, l'animal et la date de fin de validité du vaccin pour tous les animaux qui ont un
        /// vaccin qui expire dans 15 jours ou moins
        /// </summary>
        /// <returns></returns>
        public List<Relance> Get()
        {
            List<Relance> listeRelances = new List<Relance>();
            try
            {
                using (SqlConnection cnx = Outils.OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandText = GET;
                    SqlDataReader dr = rqt.ExecuteReader();
                    while (dr.Read())
                    {
                        DateTime dateConsultation = dr.GetDateTime(dr.GetOrdinal("DateConsultation"));
                        int perdiodeValidite = dr.GetInt32(dr.GetOrdinal("PeriodeValidite"));
                        DateTime dateFinValidite = dateConsultation.AddMonths(perdiodeValidite);
                        TimeSpan ts = dateFinValidite - DateTime.Now;
                        int tsEnJours = ts.Days;
                        if (tsEnJours <= DELAI_POUR_RELANCE)
                        {
                            Client client = instanceClientDAL.Get(dr.GetGuid(dr.GetOrdinal("CodeClient")));
                            Animal animal = instanceAnimalDAL.Get(dr.GetGuid(dr.GetOrdinal("CodeAnimal")));
                            Relance relance = new Relance();
                            relance.client = client;
                            relance.animal = animal;
                            relance.dateFinValidite = dateFinValidite;
                            listeRelances.Add(relance);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            return listeRelances;
        }
    }
}
