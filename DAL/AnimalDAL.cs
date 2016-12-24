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
    /// DAL de l'animal
    /// </summary>
    public class AnimalDAL : ICrud<Animal>
    {
        private const String CREATE = "ajout_animal";
        private const String READ_BY_ID = "lecture_animal_id";
        private const String READ_BY_NOM = "lecture_animal_nom";
        private const String READ_BY_LIST = "lecture_animal_liste";
        private const String READ_BY_PROPRIETAIRE = "lecture_animal_client";
        private const String UPDATE = "modification_animal";
        private const String DELETE = "suppression_animal";
        private const string READ_LIST_BY_CLIENT = "SELECT * FROM Animaux a JOIN Clients c ON "+
                            "a.CodeClient = c.CodeClient WHERE c.CodeClient = @codeClient AND a.Archive =0;";

        private const String COL_CODEANIMAL = "CodeAnimal";
        private const String COL_NOMANIMAL = "NomAnimal";
        private const String COL_SEXE = "Sexe";
        private const String COL_COULEUR = "Couleur";
        private const String COL_RACE = "Race";
        private const String COL_ESPECE = "Espece";
        private const String COL_CODECLIENT = "CodeClient";
        private const String COL_TATOUAGE = "Tatouage";
        private const String COL_ANTECEDENTS = "Antecedents";
        private const String COL_ARCHIVE = "Archive";


        /// <summary>
        /// Créer un animal
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Create(Animal item)
        {
            bool result = false;

            try
            {
                using (SqlConnection cnx = OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandType = System.Data.CommandType.StoredProcedure;
                    rqt.CommandText = CREATE;

                    rqt.Parameters.AddWithValue("@NomAnimal", item.NomAnimal);
                    rqt.Parameters.AddWithValue("@Sexe", item.Sexe);
                    rqt.Parameters.AddWithValue("@Couleur", item.Couleur);
                    rqt.Parameters.AddWithValue("@Race", item.Race);
                    rqt.Parameters.AddWithValue("@Espece", item.Espece);
                    rqt.Parameters.AddWithValue("@CodeClient", item.CodeClient);
                    rqt.Parameters.AddWithValue("@Tatouage", item.Tatouage);
                    //rqt.Parameters.AddWithValue("@Antecedents", item.Antecedent);
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
        /// Afficher l'animal
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Animal Get(Guid id)
        {
            Animal animal = null;

            try
            {
                using (SqlConnection cnx = OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandType = System.Data.CommandType.StoredProcedure;
                    rqt.CommandText = "lecture_animal_id";
                    rqt.Parameters.AddWithValue("CodeAnimal", id);
                    SqlDataReader dr = rqt.ExecuteReader();

                    if (dr.Read())
                    {
                        animal = ItemBuilder(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            return animal;

        }

        /// <summary>
        /// Retourne le premier élément de la liste des animaux ayant un nom commençant comme le paramètre
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="type">indique si le parametre est le nom, le tataouge, l'espece ou la race</param>
        /// <returns></returns>
        public Animal Get(string nom)
        {
            Animal animal = null;
            try
            {
                using (SqlConnection cnx = OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandType = System.Data.CommandType.StoredProcedure;
                    rqt.CommandText = "lecture_animal_nom";
                    rqt.Parameters.AddWithValue("@NomAnimal", nom);
                    SqlDataReader dr = rqt.ExecuteReader();

                    if (dr.Read())
                    {
                        animal = ItemBuilder(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            return animal;
        }

        /// <summary>
        /// Retourune le premier animal enregistré du client specifié
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public Animal Get(Client c)
        {
            Animal animal = null;
            try
            {
                using (SqlConnection cnx = OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandType = System.Data.CommandType.StoredProcedure;
                    rqt.CommandText = READ_BY_PROPRIETAIRE;
                    rqt.Parameters.AddWithValue("@CodeClient", c.CodeClient);
                    SqlDataReader dr = rqt.ExecuteReader();

                    if (dr.Read())
                    {
                        animal = ItemBuilder(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            return animal;
        }

        /// <summary>
        /// Retourne le premier resultat de la recher d'animaux par tatouage
        /// </summary>
        /// <param name="tatouage"></param>
        /// <returns></returns>
        public Animal GetAnimalByTatoo(string tatouage)
        {
            Animal animal = null;

            try
            {
                using (SqlConnection cnx = OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandType = System.Data.CommandType.Text;
                    rqt.CommandText = "SELECT TOP 1 * FROM Animaux a WHERE a.Tatouage LIKE '" +tatouage + "%';";
                    SqlDataReader dr = rqt.ExecuteReader();

                    if (dr.Read())
                    {
                        animal = ItemBuilder(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            return animal;
        }

        // ################################ Méthode à vérifier ###################################################
        /// <summary>
        /// Retourne l'ensemble des animaux d'un meme propriétaire
        /// </summary>
        /// <returns></returns>
        public List<Animal> GetListByName(string nom)
        {
            List<Animal> liste = new List<Animal>();

            try
            {
                using (SqlConnection cnx = OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandType = System.Data.CommandType.Text;
                    rqt.CommandText = "SELECT * FROM Animaux a  WHERE a.NomAnimal LIKE '%" + nom + "%';";
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
        /// Retourne la liste des animaux du client passé en paramètre
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public List<Animal> GetAnimauxByClient(Client client)
        {
            List<Animal> listeAnimaux = new List<Animal>();
            try
            {
                using (SqlConnection cnx = OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandText = READ_LIST_BY_CLIENT;
                    rqt.Parameters.AddWithValue("@codeClient", client.CodeClient);
                    SqlDataReader dr = rqt.ExecuteReader();
                    while (dr.Read())
                    {
                        Animal animal = ItemBuilder(dr);
                        listeAnimaux.Add(animal);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            return listeAnimaux;
        }

        /// <summary>
        /// Modifie un animal
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Update(Animal item)
        {
            bool result = false;

            try
            {
                using (SqlConnection cnx = OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandType = System.Data.CommandType.StoredProcedure;
                    rqt.CommandText = UPDATE;

                    rqt.Parameters.AddWithValue("@CodeAnimal", item.CodeAnimal);
                    rqt.Parameters.AddWithValue("@NomAnimal", item.NomAnimal);
                    rqt.Parameters.AddWithValue("@Sexe", item.Sexe);
                    rqt.Parameters.AddWithValue("@Couleur", item.Couleur);
                    rqt.Parameters.AddWithValue("@Race", item.Race);
                    rqt.Parameters.AddWithValue("@Espece", item.Espece);
                    rqt.Parameters.AddWithValue("@CodeClient", item.CodeClient);
                    rqt.Parameters.AddWithValue("@Tatouage", item.Tatouage);
                    if (item.Antecedent == null)
                        rqt.Parameters.AddWithValue("@Antecedents", string.Empty);
                    else
                        rqt.Parameters.AddWithValue("@Antecedents", item.Antecedent);
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
        /// Supprime un animal
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Delete(Animal item)
        {
            bool result = false;

            try
            {
                using (SqlConnection cnx = OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandType = System.Data.CommandType.StoredProcedure;
                    rqt.CommandText = DELETE;

                    rqt.Parameters.AddWithValue("@NomAnimal", item.NomAnimal);
                    rqt.Parameters.AddWithValue("@Sexe", item.Sexe);
                    rqt.Parameters.AddWithValue("@Couleur", item.Couleur);
                    rqt.Parameters.AddWithValue("@Race", item.Race);
                    rqt.Parameters.AddWithValue("@Espece", item.Espece);
                    rqt.Parameters.AddWithValue("@CodeClient", item.CodeClient);
                    rqt.Parameters.AddWithValue("@Tatouage", item.Tatouage);
                    rqt.Parameters.AddWithValue("@Antecedents", item.Antecedent);
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

        private Animal ItemBuilder(SqlDataReader dr)
        {
            Animal animal = new Animal();

            animal.CodeAnimal = dr.GetGuid(dr.GetOrdinal(COL_CODEANIMAL));
            animal.NomAnimal = dr.GetString(dr.GetOrdinal(COL_NOMANIMAL));
            //animal.Sexe = dr.GetChar(dr.GetOrdinal(COL_SEXE));
            animal.CodeClient = dr.GetGuid(dr.GetOrdinal(COL_CODECLIENT));
            animal.Archive = dr.GetBoolean(dr.GetOrdinal(COL_ARCHIVE));

            if (!dr.IsDBNull(dr.GetOrdinal(COL_COULEUR)))
                animal.Couleur = dr.GetString(dr.GetOrdinal(COL_COULEUR));

            if (!dr.IsDBNull(dr.GetOrdinal(COL_RACE)))
                animal.Race = dr.GetString(dr.GetOrdinal(COL_RACE));

            if (!dr.IsDBNull(dr.GetOrdinal(COL_ESPECE)))
                animal.Espece = dr.GetString(dr.GetOrdinal(COL_ESPECE));

            if (!dr.IsDBNull(dr.GetOrdinal(COL_TATOUAGE)))
                animal.Tatouage = dr.GetString(dr.GetOrdinal(COL_TATOUAGE));

            if (!dr.IsDBNull(dr.GetOrdinal(COL_ANTECEDENTS)))
                animal.Antecedent = dr.GetString(dr.GetOrdinal(COL_ANTECEDENTS));


            return animal;
        }
    }
}
