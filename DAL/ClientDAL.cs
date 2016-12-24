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
    /// Represente la DAL du client
    /// </summary>
    public class ClientDAL : ICrud<Client>
    {

        private const String CREATE = "ajout_client";
        private const String READ_BY_ID = "lecture_client_id";
        private const string READ_BY_NAME = "lecture_clients_nom";
        private const string READ_POSITION = "lecture_position_client";
        private const String UPDATE = "modification_client";
        private const String DELETE = "suppression_client";
        private const string COUNT = "lecture_nb_clients";
        private const string COUNT_BY_NAME = "lecture_nb_clients_nom";
        private const string READ_BY_NAME_LISTE = "lecture_clients_nom_liste";

        public const String COL_CODECLIENT = "CodeClient";
        public const String COL_NOM = "NomClient";
        public const String COL_PRENOM = "PrenomClient";
        public const String COL_ADD = "Adresse1"; //add = adresse
        public const String COL_ADD2 = "Adresse2";
        public const String COL_CP = "CodePostal"; //cp = code postal
        public const String COL_VILLE = "Ville";
        public const String COL_TEL = "NumTel";
        public const String COL_ASS = "Assurance"; //ass = assurance
        public const String COL_MAIL = "Email";
        public const String COL_REMARQUE = "Remarque";
        public const String COL_ARCH = "Archive";

        /// <summary>
        /// Créer un client
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Create(Client item)
        {
            bool result = false;

            try
            {
                using (SqlConnection cnx = OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandType = System.Data.CommandType.StoredProcedure;
                    rqt.CommandText = CREATE;

                    rqt.Parameters.AddWithValue("@nom", item.NomClient);
                    rqt.Parameters.AddWithValue("@prenom", item.PrenomClient);
                    rqt.Parameters.AddWithValue("@add", item.Adresse1); //add = adresse
                    rqt.Parameters.AddWithValue("@add2", item.Adresse2);
                    rqt.Parameters.AddWithValue("@cp", item.CodePostal); //cp = code postal
                    rqt.Parameters.AddWithValue("@ville", item.Ville);
                    rqt.Parameters.AddWithValue("@tel", item.NumTel);
                    rqt.Parameters.AddWithValue("@ass", item.Assurance); //ass = assurance
                    rqt.Parameters.AddWithValue("@mail", item.Email);
                    rqt.Parameters.AddWithValue("@rmq", item.Remarque);//rmq = remarque
                    rqt.Parameters.AddWithValue("@arch", item.Archive);

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
        /// Accede a la fiche d'un client
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Client Get(Guid id)
        {
            Client client = null;

            try
            {
                using (SqlConnection cnx = OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandType = System.Data.CommandType.StoredProcedure;
                    rqt.CommandText = "lecture_client_id";
                    rqt.Parameters.AddWithValue("CodeClient", id);
                    SqlDataReader dr = rqt.ExecuteReader();

                    if (dr.Read())
                    {
                        client = ItemBuilder(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            return client;
        }
        /// <summary>
        /// Retourne le client dont le nom comprend la chaine de caractères entrée en paramètre
        /// à la position entrée en paramètre (1 par défaut)
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public Client Get(string nom, int position = 1)
        {
            Client client = new Client();
            try
            {
                using (SqlConnection cnx = OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandType = System.Data.CommandType.StoredProcedure;
                    rqt.CommandText = READ_BY_NAME;
                    rqt.Parameters.AddWithValue("@position", position);
                    rqt.Parameters.AddWithValue("@nomClient", nom);
                    SqlDataReader dr = rqt.ExecuteReader();
                    if (dr.Read())
                    {
                        client = ItemBuilder(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            return client;
        }

        /// <summary>
        /// Retourne une liste de client
        /// </summary>
        /// <param name="nom"></param>
        /// <returns></returns>
        public List<Client> GetList(string nom)
        {
            List<Client> liste = new List<Client>();
            try
            {
                using (SqlConnection cnx = OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandType = System.Data.CommandType.StoredProcedure;
                    rqt.CommandText = READ_BY_NAME_LISTE;
                    rqt.Parameters.AddWithValue("@nomClient", nom);
                    SqlDataReader dr = rqt.ExecuteReader();
                    while (dr.Read())
                    {
                        Client client = ItemBuilder(dr);
                        liste.Add(client);
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
        /// Modifier un client
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Update(Client item)
        {
            bool result = false;

            try
            {
                using (SqlConnection cnx = OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandType = System.Data.CommandType.StoredProcedure;
                    rqt.CommandText = UPDATE;

                    rqt.Parameters.AddWithValue("@codeClient", item.CodeClient);
                    rqt.Parameters.AddWithValue("@nomClient", item.NomClient);
                    rqt.Parameters.AddWithValue("@prenomClient", item.PrenomClient);
                    rqt.Parameters.AddWithValue("@adresse1", item.Adresse1); //add = adresse
                    rqt.Parameters.AddWithValue("@adresse2", item.Adresse2);
                    rqt.Parameters.AddWithValue("@codePostal", item.CodePostal); //cp = code postal
                    rqt.Parameters.AddWithValue("@ville", item.Ville);
                    rqt.Parameters.AddWithValue("@numTel", item.NumTel);
                    rqt.Parameters.AddWithValue("@assurance", item.Assurance); //ass = assurance
                    rqt.Parameters.AddWithValue("@email", item.Email);
                    rqt.Parameters.AddWithValue("@remarque", item.Remarque);//rmq = remarque
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

        /// <summary>
        /// Supprime un client
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Delete(Client item)
        {
            bool result = false;
            try
            {
                using (SqlConnection cnx = OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandType = System.Data.CommandType.StoredProcedure;
                    rqt.CommandText = DELETE;

                    rqt.Parameters.AddWithValue("@codeclient", item.CodeClient);

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
        /// Retourne le nombre total de clients enregistrés dans la bdd
        /// </summary>
        /// <returns></returns>
        public int GetNbClients()
        {
            int nbClients = 0;
            try
            {
                using (SqlConnection cnx = OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandType = System.Data.CommandType.StoredProcedure;
                    rqt.CommandText = COUNT;
                    SqlDataReader dr = rqt.ExecuteReader();
                    if (dr.Read())
                    {
                        nbClients = dr.GetInt32(0);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            return nbClients;
        }

        /// <summary>
        /// Retourne le nombre de clients dont le nom correspond à la chaine de caractères passée en paramètre
        /// </summary>
        /// <param name="nom"></param>
        /// <returns></returns>
        public int GetNbClients(string nom)
        {
            int nbClients = 0;
            try
            {
                using (SqlConnection cnx = OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandType = System.Data.CommandType.StoredProcedure;
                    rqt.CommandText = COUNT_BY_NAME;
                    rqt.Parameters.AddWithValue("@nomClient", nom);
                    SqlDataReader dr = rqt.ExecuteReader();
                    if (dr.Read())
                    {
                        nbClients = dr.GetInt32(0);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            return nbClients;
        }
        /// <summary>
        /// Retourne la position 
        /// </summary>
        /// <param name="nom"></param>
        /// <returns></returns>
        public int GetPositionClient(string nom, string prenom = "")
        {
            int position = 0;
            try
            {
                using (SqlConnection cnx = OutilsBdd.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandType = System.Data.CommandType.StoredProcedure;
                    rqt.CommandText = READ_POSITION;
                    rqt.Parameters.AddWithValue("@nomClient", nom);
                    rqt.Parameters.AddWithValue("@prenomClient", prenom);
                    SqlDataReader dr = rqt.ExecuteReader();
                    if (dr.Read())
                    {
                        position = dr.GetInt32(dr.GetOrdinal("position"));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            return position;
        }

        /// <summary>
        /// Construit un objet Client
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        public Client ItemBuilder(SqlDataReader dr)
        {
            Client client = new Client();

            client.CodeClient = dr.GetGuid(dr.GetOrdinal(COL_CODECLIENT));
            client.NomClient = dr.GetString(dr.GetOrdinal(COL_NOM));
            client.PrenomClient = dr.GetString(dr.GetOrdinal(COL_PRENOM));
            client.Adresse1 = dr.GetString(dr.GetOrdinal(COL_ADD));
            client.Adresse2 = dr.GetString(dr.GetOrdinal(COL_ADD2));
            client.CodePostal = dr.GetString(dr.GetOrdinal(COL_CP));
            client.Ville = dr.GetString(dr.GetOrdinal(COL_VILLE));
            client.NumTel = dr.GetString(dr.GetOrdinal(COL_TEL));
            client.Assurance = dr.GetString(dr.GetOrdinal(COL_ASS));
            client.Email = dr.GetString(dr.GetOrdinal(COL_MAIL));
            client.Remarque = dr.GetString(dr.GetOrdinal(COL_REMARQUE));
            //client.Archive = dr.GetBoolean(dr.GetOrdinal(COL_ARCH)); Ramener l'état d'archivage


            return client;
        }

    }
}
