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
    /// <summary>
    /// Lien entre le programme et la bdd pour les baremes de facturation de la clinique
    /// </summary>
    public class BaremeDAL : ICrud<Baremes>
    {
        private const string COL_CODEGROUPEMENT = "CodeGroupement";
        private const string COL_DATEVIGUEUR = "DateVigueur";
        private const string COL_TYPEACTE = "TypeActe";
        private const string COL_LIBELLE = "Libelle";
        private const string COL_TARIFFIXE = "TarifFixe";
        private const string COL_TARIFMINI = "TarifMini";
        private const string COL_TARIFMAXI = "TarifMaxi";
        private const string COL_CODEVACCIN = "CodeVaccin";
        private const string COL_ARCHIVE = "Archive";

        /// <summary>
        /// Insert un bareme dans la BDD
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Create(Baremes item)
        {
            bool result = false;

            try
            {
                using (SqlConnection cnx = OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandType = System.Data.CommandType.Text;
                    rqt.CommandText = "INSERT INTO Baremes VALUES (@Codegroupement, @DateVigueur, @TypeActe, @Libelle"+
                                      ",@TarifFixe, @TarifMini, @TarifMaxi, @CodeVaccin, @Archive;";

                    rqt.Parameters.AddWithValue("@CodeGroupement", item.CodeGroupement);
                    rqt.Parameters.AddWithValue("@DateVigueur", item.DateVigueur);
                    rqt.Parameters.AddWithValue("@TypeActe", item.TypeActe);
                    rqt.Parameters.AddWithValue("@Libelle", item.Libelle);
                    rqt.Parameters.AddWithValue("@TarifFixe", item.TarifFixe);
                    rqt.Parameters.AddWithValue("@TarifMini", item.TarifMini);
                    rqt.Parameters.AddWithValue("@TarifMaxi", item.TarifMaxi);
                    rqt.Parameters.AddWithValue("@CodeVaccin", item.CodeVaccin);
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
        /// Recupere un bareme en fonction de l'identifiant dans la BDD
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Baremes Get(Guid id)
        {
            Baremes bareme = null;

            try
            {
                using (SqlConnection cnx = OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandType = System.Data.CommandType.Text;
                    rqt.CommandText = "SELECT * FROM Baremes WHERE CodGroupement = @CodeGroupement;";
                    rqt.Parameters.AddWithValue("CodeGroupement", id);
                    SqlDataReader dr = rqt.ExecuteReader();

                    if (dr.Read())
                    {
                        bareme = ItemBuilder(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            return bareme;

        }

        /// <summary>
        /// Recupere l'ensemble des baremes disponibles
        /// </summary>
        /// <returns></returns>
        public List<Baremes> Get()
        {
            List<Baremes> liste = new List<Baremes>();

            try
            {
                using (SqlConnection cnx = OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandType = System.Data.CommandType.Text;
                    rqt.CommandText = "SELECT * FROM Baremes WHERE Archive = 0;";
                    SqlDataReader dr = rqt.ExecuteReader();

                    while (dr.Read())
                    {
                        liste.Add(ItemBuilder(dr));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            return liste;
        }

        /// <summary>
        /// Modifie un bareme dans la BDD
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Update(Baremes item)
        {
            bool result = false;
            try
            {
                using (SqlConnection cnx = OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandType = System.Data.CommandType.Text;
                    rqt.CommandText = "UPDATE Baremes SET TypeActe = @TypeActe, Libelle = @Libelle, TarifFixe = @TarifFixe"+
                                      ", TarifMini = @TarifMini, TarifMaxi = @TarifMaxi, CodeVaccin = @CodeVaccin, Archive = @Archive"+
                                      " WHERE CodeGroupement = @Codegroupement AND DateVigueur = @DateVigueur;";

                    rqt.Parameters.AddWithValue("@TypeActe", item.TypeActe);
                    rqt.Parameters.AddWithValue("@Libelle", item.Libelle);
                    rqt.Parameters.AddWithValue("@TarifFixe", item.TarifFixe);
                    rqt.Parameters.AddWithValue("@TarifMini", item.TarifMini);
                    rqt.Parameters.AddWithValue("@TarifMaxi", item.TarifMaxi);
                    rqt.Parameters.AddWithValue("@CodeVaccin", item.CodeVaccin);
                    rqt.Parameters.AddWithValue("@Archive", item.Archive);
                    rqt.Parameters.AddWithValue("@Codegroupement", item.CodeGroupement);
                    rqt.Parameters.AddWithValue("@DateVigueur", item.DateVigueur);

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
        /// Supprime un bareme de la BDD
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Delete(Baremes item)
        {
            bool result = false;
            try
            {
                using (SqlConnection cnx = OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandType = System.Data.CommandType.Text;
                    rqt.CommandText = "DELETE Baremes WHERE CodeGroupement = @CodeGroupement AND DateVigueur = @DateVigueur";

                    rqt.Parameters.AddWithValue("@Codegroupement", item.CodeGroupement);
                    rqt.Parameters.AddWithValue("@DateVigueur", item.DateVigueur);

                    result = (rqt.ExecuteNonQuery() > 0);
                }

            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            return result;
        }

        private Baremes ItemBuilder(SqlDataReader dr)
        {
            Baremes bareme = new Baremes();

            bareme.Archive = dr.GetBoolean(dr.GetOrdinal(COL_ARCHIVE));
            bareme.CodeGroupement = dr.GetString(dr.GetOrdinal(COL_CODEGROUPEMENT));
            bareme.DateVigueur = dr.GetString(dr.GetOrdinal(COL_DATEVIGUEUR));
            bareme.TypeActe = dr.GetString(dr.GetOrdinal(COL_TYPEACTE));
            //PROBLEME ICI, JUSTE EN DESSOUS
            //PROBLEME ICI, JUSTE EN DESSOUS
            //PROBLEME ICI, JUSTE EN DESSOUS
            //PROBLEME ICI, JUSTE EN DESSOUS
            if (!dr.IsDBNull(dr.GetOrdinal(COL_TARIFFIXE)))
                bareme.TarifFixe = dr.GetDouble(dr.GetOrdinal(COL_TARIFFIXE));
            else
                bareme.TarifFixe = 0;
            //
            //
            //
            //

            if (!dr.IsDBNull(dr.GetOrdinal(COL_LIBELLE)))
                bareme.Libelle = dr.GetString(dr.GetOrdinal(COL_LIBELLE));
            else
                bareme.Libelle = string.Empty;

            if (!dr.IsDBNull(dr.GetOrdinal(COL_TARIFMAXI)))
                bareme.TarifMaxi = dr.GetDouble(dr.GetOrdinal(COL_TARIFMAXI));
            else
                bareme.TarifMaxi = 0;

            if (!dr.IsDBNull(dr.GetOrdinal(COL_TARIFMINI)))
                bareme.TarifMini = dr.GetDouble(dr.GetOrdinal(COL_TARIFMINI));
            else
                bareme.TarifMini = 0;

            if (dr.IsDBNull(dr.GetOrdinal(COL_CODEVACCIN)))
                bareme.CodeVaccin = dr.GetGuid(dr.GetOrdinal(COL_CODEVACCIN));
            else
                bareme.CodeVaccin = Guid.Empty;

            return bareme;
        }
    }
}
