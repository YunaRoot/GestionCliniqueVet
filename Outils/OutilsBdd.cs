using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outils
{
    public class OutilsBdd
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = ConfigurationManager.ConnectionStrings["CliniqueVeterinaire"].ToString();
            cnx.Open();
            return cnx;
        }
    }
}
