using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MobileStoreManagement
{
    internal class ConnectDatabase
    {

        private readonly string connectionString;

        internal ConnectDatabase()
        {
            connectionString = "Data Source=localhost;Initial Catalog=MobileManager;Integrated Security=True";
            
        }

        internal SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString); ;
        }

        internal bool IsConnected(SqlConnection conn)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                return conn.State == ConnectionState.Open;
            }
            catch
            {
                return false;
            }
        }
        internal void CloseConnection(SqlConnection conn)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        internal void OpenSqlConnection(SqlConnection conn)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }
    }
}
