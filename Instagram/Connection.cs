using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPchat
{
    class Connection
    {
        private static string Stringconnection = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=INSTAGRAM;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(Stringconnection);
        }
    }
}

