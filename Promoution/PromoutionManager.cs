using System;
using System.Collections.Generic;
using System.Data;
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
        internal void InsertPromotion(string maKhuyenMai, string loaiKhuyenMai, string tenCTKM, string moTa,
                               DateTime thoiGianBatDau, DateTime thoiGianKetThuc,
                               decimal? dkapSoTien, int? dkapSoLuong, double? kmApDung,
                               int soLuongKM, bool trangThai)
        {
            try
            {
                using (SqlConnection connection = connectDb.GetConnection())
                {
                    string query = @"
                INSERT INTO CT_KHUYEN_MAI 
                (Ma_khuyen_mai, Loai_khuyen_mai, Ten_CTKM, Mo_ta, Thoi_gian_bat_dau, Thoi_gian_ket_thuc,
                 DKAP_So_tien, DKAP_So_luong, KM_ap_dung, So_luong_KM, Trang_thai, Ma_nguoi_ban, username)
                VALUES 
                (@Ma_khuyen_mai, @Loai_khuyen_mai, @Ten_CTKM, @Mo_ta, @Thoi_gian_bat_dau, @Thoi_gian_ket_thuc,
                 @DKAP_So_tien, @DKAP_So_luong, @KM_ap_dung, @So_luong_KM, @Trang_thai, @Ma_nguoi_ban, @username)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Ma_khuyen_mai", maKhuyenMai);
                        command.Parameters.AddWithValue("@Loai_khuyen_mai", loaiKhuyenMai);
                        command.Parameters.AddWithValue("@Ten_CTKM", tenCTKM);

                        if (!string.IsNullOrEmpty(moTa))
                            command.Parameters.AddWithValue("@Mo_ta", moTa);
                        else
                            command.Parameters.AddWithValue("@Mo_ta", DBNull.Value);

                        command.Parameters.AddWithValue("@Thoi_gian_bat_dau", thoiGianBatDau);
                        command.Parameters.AddWithValue("@Thoi_gian_ket_thuc", thoiGianKetThuc);

                        if (dkapSoTien.HasValue)
                            command.Parameters.AddWithValue("@DKAP_So_tien", dkapSoTien.Value);
                        else
                            command.Parameters.AddWithValue("@DKAP_So_tien", DBNull.Value);

                        if (dkapSoLuong.HasValue)
                            command.Parameters.AddWithValue("@DKAP_So_luong", dkapSoLuong.Value);
                        else
                            command.Parameters.AddWithValue("@DKAP_So_luong", DBNull.Value);

                        if (kmApDung.HasValue)
                            command.Parameters.AddWithValue("@KM_ap_dung", kmApDung.Value);
                        else
                            command.Parameters.AddWithValue("@KM_ap_dung", DBNull.Value);

                        command.Parameters.AddWithValue("@So_luong_KM", soLuongKM);
                        command.Parameters.AddWithValue("@Trang_thai", trangThai);
                        command.Parameters.AddWithValue("@Ma_nguoi_ban", Session.userId);
                        command.Parameters.AddWithValue("@username", Session.username);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm chương trình khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm chương trình khuyến mãi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi cơ sở dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void DeletePromotion(string maKhuyenMai)
        {
            try
            {
                using (SqlConnection connection = connectDb.GetConnection())
                {
                    string query = @"
                DELETE FROM CT_KHUYEN_MAI
                WHERE Ma_khuyen_mai = @Ma_khuyen_mai AND Ma_nguoi_ban = @Ma_nguoi_ban";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Ma_khuyen_mai", maKhuyenMai);
                        command.Parameters.AddWithValue("@Ma_nguoi_ban", Session.userId);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa chương trình khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy chương trình khuyến mãi để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi cơ sở dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        internal DataTable GetAllPromotions()
        {
            DataTable dtPromotions = new DataTable();
            try
            {
                using (SqlConnection connection = connectDb.GetConnection())
                {
                    string query = "SELECT * FROM CT_KHUYEN_MAI WHERE Ma_nguoi_ban = @MaNguoiBan";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaNguoiBan", Session.userId);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dtPromotions);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi khi truy vấn cơ sở dữ liệu: " + ex.Message, ex);
            }
            return dtPromotions;
        }
        internal DataTable GetPromotionDetailsWithType()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = connectDb.GetConnection())
                {
                    string query = @"
                SELECT 
                    ct.Ma_khuyen_mai,
                    ct.Loai_khuyen_mai,
                    ht.Ten_loai_khuyen_mai,
                    ct.Ten_CTKM,
                    ct.Mo_ta,
                    ct.Thoi_gian_bat_dau,
                    ct.Thoi_gian_ket_thuc,
                    ct.DKAP_So_tien,
                    ct.DKAP_So_luong,
                    ct.KM_ap_dung,
                    ct.So_luong_KM,
                    ct.Trang_thai,
                    ct.Ma_nguoi_ban,
                    ct.username
                FROM CT_KHUYEN_MAI ct
                INNER JOIN HINH_THUC_KHUYEN_MAI ht
                    ON ct.Loai_khuyen_mai = ht.Loai_khuyen_mai
                WHERE ct.Ma_nguoi_ban = @MaNguoiBan
            ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaNguoiBan", Session.userId);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi khi truy vấn dữ liệu: " + ex.Message, ex);
            }
            return dt;
        }

        internal void UpdatePromotionStatus(string maKhuyenMai, bool trangThaiMoi)
        {
            try
            {
                using (SqlConnection connection = connectDb.GetConnection())
                {
                    string query = @"
                UPDATE CT_KHUYEN_MAI
                SET Trang_thai = @TrangThaiMoi
                WHERE Ma_khuyen_mai = @MaKhuyenMai AND Ma_nguoi_ban = @MaNguoiBan
            ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TrangThaiMoi", trangThaiMoi);
                        command.Parameters.AddWithValue("@MaKhuyenMai", maKhuyenMai);
                        command.Parameters.AddWithValue("@MaNguoiBan", Session.userId);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật trạng thái thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy chương trình khuyến mãi để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi khi cập nhật trạng thái khuyến mãi: " + ex.Message, ex);
            }
        }
        internal DataTable SearchPromotion(string searchKeyword)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = connectDb.GetConnection())
                {
                    string query = @"
                SELECT CT.Ma_khuyen_mai, 
                       CT.Loai_khuyen_mai, 
                       CT.Ten_CTKM, 
                       CT.Mo_ta, 
                       CT.Thoi_gian_bat_dau, 
                       CT.Thoi_gian_ket_thuc, 
                       CT.Trang_thai, 
                       CT.Ma_nguoi_ban, 
                       CT.username,
                       HT.Ten_loai_khuyen_mai
                FROM CT_KHUYEN_MAI CT
                INNER JOIN HINH_THUC_KHUYEN_MAI HT ON CT.Loai_khuyen_mai = HT.Loai_khuyen_mai
                WHERE CT.Ma_nguoi_ban = @maNguoiBan
                  AND (CT.Ma_khuyen_mai LIKE @search OR CT.Ten_CTKM LIKE @search)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@maNguoiBan", Session.userId);
                        command.Parameters.AddWithValue("@search", "%" + searchKeyword.Trim() + "%");

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi khi tìm kiếm chương trình khuyến mãi: " + ex.Message, ex);
            }

            return dt;
        }
        internal DataTable FilterAndCombineData(CheckedListBox checkedListBoxStatus, CheckedListBox checkedListBoxEffect)
        {
            // Lấy các lựa chọn từ checkedListBoxStatus
            List<string> statusFilters = new List<string>();
            if (checkedListBoxStatus.CheckedItems.Contains("Tất cả"))
            {
                statusFilters.Add("Tất cả");
            }
            else
            {
                if (checkedListBoxStatus.CheckedItems.Contains("Kích hoạt"))
                {
                    statusFilters.Add("1"); // true
                }
                if (checkedListBoxStatus.CheckedItems.Contains("Chưa áp dụng"))
                {
                    statusFilters.Add("0"); // false
                }
            }

            // Lấy các lựa chọn từ checkedListBoxEffect
            List<string> effectFilters = new List<string>();
            if (checkedListBoxEffect.CheckedItems.Contains("Tất cả"))
            {
                effectFilters.Add("Tất cả");
            }
            else
            {
                if (checkedListBoxEffect.CheckedItems.Contains("Còn hiệu lực"))
                {
                    effectFilters.Add("Còn hiệu lực");
                }
                if (checkedListBoxEffect.CheckedItems.Contains("Hết hiệu lực"))
                {
                    effectFilters.Add("Hết hiệu lực");
                }
            }

            // Xây dựng câu truy vấn SQL
            string query = @"
        SELECT CT.Ma_khuyen_mai, 
               CT.Loai_khuyen_mai, 
               CT.Ten_CTKM, 
               CT.Mo_ta, 
               CT.Thoi_gian_bat_dau, 
               CT.Thoi_gian_ket_thuc, 
               CT.Trang_thai, 
               CT.Ma_nguoi_ban, 
               CT.username,
               HT.Ten_loai_khuyen_mai
        FROM CT_KHUYEN_MAI CT
        INNER JOIN HINH_THUC_KHUYEN_MAI HT ON CT.Loai_khuyen_mai = HT.Loai_khuyen_mai
        WHERE 1=1 AND CT.Ma_nguoi_ban = @maNguoiBan"; // luôn đúng để dễ thêm điều kiện

            // Lọc theo trạng thái
            if (statusFilters.Count > 0 && !statusFilters.Contains("Tất cả"))
            {
                query += " AND CT.Trang_thai IN (" + string.Join(",", statusFilters) + ")";
            }

            // Lọc theo hiệu lực
            if (effectFilters.Count > 0 && !effectFilters.Contains("Tất cả"))
            {
                query += " AND (";
                List<string> effectConditions = new List<string>();
                if (effectFilters.Contains("Còn hiệu lực"))
                {
                    effectConditions.Add("CT.Thoi_gian_ket_thuc >= GETDATE()");
                }
                if (effectFilters.Contains("Hết hiệu lực"))
                {
                    effectConditions.Add("CT.Thoi_gian_ket_thuc < GETDATE()");
                }
                query += string.Join(" OR ", effectConditions) + ")";
            }
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = connectDb.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@maNguoiBan", Session.userId);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }

                }

            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi khi truy vấn dữ liệu: " + ex.Message, ex);
            }

            return dt;
        }
    }
}
