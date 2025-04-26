using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStoreManagement.Promoution
{
    internal class PromoutionManager
    {
        ConnectDatabase connectDb = new ConnectDatabase();
        internal void InsertPromotionType(string promotionTypeId, string promotionTypeName)
        {
            try
            {
                using (SqlConnection connection = connectDb.GetConnection())
                {
                    string query = @"
                INSERT INTO HINH_THUC_KHUYEN_MAI (
                    Loai_khuyen_mai, Ten_loai_khuyen_mai, Ma_nguoi_ban, username
                )
                VALUES (
                    @Loai_khuyen_mai, @Ten_loai_khuyen_mai, @Ma_nguoi_ban, @username
                )";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Loai_khuyen_mai", promotionTypeId);
                        command.Parameters.AddWithValue("@Ten_loai_khuyen_mai", promotionTypeName);
                        command.Parameters.AddWithValue("@Ma_nguoi_ban", Session.userId);
                        command.Parameters.AddWithValue("@username", Session.username);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm hình thức khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        internal void DeletePromotionType(string promotionTypeId)
        {
            try
            {
                using (SqlConnection connection = connectDb.GetConnection())
                {
                    string query = @"
                DELETE FROM HINH_THUC_KHUYEN_MAI 
                WHERE Loai_khuyen_mai = @Loai_khuyen_mai 
                AND Ma_nguoi_ban = @Ma_nguoi_ban";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Loai_khuyen_mai", promotionTypeId);
                        command.Parameters.AddWithValue("@Ma_nguoi_ban", Session.userId);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa hình thức khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy hình thức khuyến mãi để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
