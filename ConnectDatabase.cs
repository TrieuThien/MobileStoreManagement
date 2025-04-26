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
        private string connectionString = "Data Source=localhost;Initial Catalog=MobileManager;Integrated Security=True";
        private SqlConnection conn;

        internal ConnectDatabase()
        {
            conn = new SqlConnection(connectionString);
        }

        internal SqlConnection GetConnection()
        {
            return conn;
        }

        internal bool IsConnected()
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
        internal void CloseConnection()
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
