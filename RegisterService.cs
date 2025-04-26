using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStoreManagement
{
    internal static class RegisterService
    {
        
        internal static bool IsCreateAccountSuccess(string fullName, string email, string numberPhone, string username, string password)
        {
            ConnectDatabase connectDatabase = new ConnectDatabase();
            SqlConnection conn = connectDatabase.GetConnection();

            if (conn.State == System.Data.ConnectionState.Closed) 
            {
                conn.Open();
            }

            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    string queryCheckIsExistUsername = "SELECT COUNT(*) FROM Admin WHERE username = @username;";
                    SqlCommand cmd = new SqlCommand(queryCheckIsExistUsername, conn); 

                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@PhoneNumber", numberPhone);

                    int isExistUsername = (int) cmd.ExecuteScalar();
                    if (isExistUsername == 0)
                    {
                        // Thực hiện thêm mới record vào bảng Admin và Nguoi_ban
                        string queryInsertNewAccount = "Insert into Admin (username, password) values (@username, @password); " +
                            "Insert into Nguoi_ban (username, Ten_nguoi_ban, Ten_cua_hang, Email, SDT) values (@username, @FullName, ' ', @Email, @PhoneNumber);";
                        cmd.CommandText = queryInsertNewAccount;
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Lỗi: Không thể tạo mới tài khoản người dùng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lỗi: Tên người dùng đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Lỗi kết nối CSDL không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
