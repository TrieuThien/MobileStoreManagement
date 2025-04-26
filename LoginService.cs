using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStoreManagement
{
    internal static class LoginService
    {
        internal static bool Authenticate(string username, string password)
        {
            ConnectDatabase connectDB = new ConnectDatabase();
            SqlConnection conn = connectDB.GetConnection();

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                string getAccountInfo = "Select count(*) from Admin where username = @username and password = @password";
                SqlCommand cmd = new SqlCommand(getAccountInfo, conn); 
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                int isExist = (int) cmd.ExecuteScalar();

                if (isExist > 0 )
                {
                    string getUserIDQuery = "Select Ma_nguoi_ban from Nguoi_ban where username = @username";
                    SqlCommand getUserIdCmd = new SqlCommand(getUserIDQuery, conn);
                    getUserIdCmd.Parameters.AddWithValue("@username", username);
                    int userId = (int) getUserIdCmd.ExecuteScalar();

                    Session.username = username;
                    Session.userId = userId;

                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        internal static void LogOut()
        {
            Session.username = "";
            Session.userId = 0;
            Session.authenticateStatus = false;
        }
    }
}
