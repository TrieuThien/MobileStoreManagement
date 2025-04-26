using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStoreManagement.AccountDasboard
{
    internal class AccountDashboard
    {
        internal string username;
        internal string userFullName;
        internal string phoneNumber;
        internal string email;
        internal string branch;
        ConnectDatabase connDb = new ConnectDatabase();

        internal AccountDashboard()
        {
            username = Session.username;
            InitPersionalInfo();
        }

        private void InitPersionalInfo()
        {
            SqlConnection conn = connDb.GetConnection();

            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }

            string getUserIDQuery = "Select * from Nguoi_ban where username = @username";
            using (SqlCommand getUserIdCmd = new SqlCommand(getUserIDQuery, conn))
            {
                getUserIdCmd.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = getUserIdCmd.ExecuteReader())
                {
                    if (reader.Read()) 
                    { 
                        userFullName = reader.GetString(2);
                        branch = reader.GetString(3);
                        email = reader.GetString(4);
                        phoneNumber = reader.GetString(5);
                    }
                }
            }
            conn.Close();
        }

        internal void UpdatePersionalInfo(string fullName, string storeName, string email, string phone)
        {
            SqlConnection conn = connDb.GetConnection();

            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }

                string query = @"UPDATE Nguoi_ban
                         SET Ten_nguoi_ban = @FullName,
                             Ten_cua_hang = @StoreName,
                             Email = @Email,
                             SDT = @Phone
                         WHERE username = @Username";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@StoreName", storeName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Username", username);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy người dùng để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
