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
    public class RendezVousDAL
    {
        private const string READ_RENDEZVOUS = "lecture_Rendez_Vous";

        private const string COL_CODECLIENT = "CodeClient";
        private const string COL_NOM = "NomClient";
        private const string COL_PRENOM = "PrenomClient";

        private const string COL_CODEANIMAL = "CodeAnimal";
        private const string COL_NOMANIMAL = "NomAnimal";
        private const string COL_RACE = "Race";

        private const string COL_CODE_VETO = "CodeVeto";
        private const string COL_NOM_VETO = "NomVeto";




        public RendezVous Get(Guid idVeto)
        {
            RendezVous rendezVous = new RendezVous();
            try
            {
                using (SqlConnection cnx = OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandType = System.Data.CommandType.StoredProcedure;
                    rqt.CommandText = READ_RENDEZVOUS;
                    rqt.Parameters.AddWithValue("@codeVeto", idVeto);

                    SqlDataReader dr = rqt.ExecuteReader();

                    if (dr.Read())
                    {
                        rendezVous = ItemBuilder(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            return rendezVous;
        }

        private RendezVous ItemBuilder(SqlDataReader dr)
        {
            Client client = new Client();
            client.NomClient = dr.GetString(dr.GetOrdinal(COL_NOM));
            client.CodeClient = dr.GetGuid(dr.GetOrdinal(COL_CODECLIENT));
            client.PrenomClient = dr.GetString(dr.GetOrdinal(COL_PRENOM));

            Veterinaire veterinaire = new Veterinaire();
            veterinaire.CodeVeto = dr.GetGuid(dr.GetOrdinal(COL_CODE_VETO));
            veterinaire.NomVeto = dr.GetString(dr.GetOrdinal(COL_NOM_VETO));

            Animal animal = new Animal();
            animal.NomAnimal = dr.GetString(dr.GetOrdinal(COL_NOMANIMAL));
            animal.Race = dr.GetString(dr.GetOrdinal(COL_RACE));

            return new RendezVous(veterinaire, client, animal);
        }

    }
}
