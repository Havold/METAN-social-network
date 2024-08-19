using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Threading;

namespace TCPchat
{
    class Modify
    {
        public Modify() { }
        SqlCommand SqlCommand;
        SqlDataReader sqlDataReader;
        public List<Taikhoan> Taikhoans(String query)
        {
            List<Taikhoan> Taikhoans = new List<Taikhoan>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand = new SqlCommand(query, sqlConnection);
                sqlDataReader = SqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Taikhoans.Add(new Taikhoan(
                        sqlDataReader.GetString(0),
                        sqlDataReader.GetString(1),
                        sqlDataReader.GetDateTime(2),
                        sqlDataReader.GetString(3),
                        sqlDataReader.GetString(4),
                        sqlDataReader.GetString(5),
                        sqlDataReader.GetString(6),
                        sqlDataReader.GetString(7),
                        sqlDataReader.GetInt32(8),
                        sqlDataReader.GetInt32(9),
                        sqlDataReader.GetInt32(10),
                        sqlDataReader.GetString(11)
                        ));
                }
                sqlConnection.Close();
            }
            return Taikhoans;
        }
        
        public List<Messed> Messeds(String query)
        {
            List<Messed> Messeds = new List<Messed>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand = new SqlCommand(query, sqlConnection);
                sqlDataReader = SqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Messeds.Add(new Messed(
                        sqlDataReader.GetString(0),
                        sqlDataReader.GetString(1)
                        ));
                }
                sqlConnection.Close();
            }
            return Messeds;
        }
        public void command(string query)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand = new SqlCommand(query, sqlConnection);
                SqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        public int Get_valid(string query)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand = new SqlCommand(query, sqlConnection);
                int x = (int)SqlCommand.ExecuteScalar();
                sqlConnection.Close();
                return x;
            }
        }
    }
}
