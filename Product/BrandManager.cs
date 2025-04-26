using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStoreManagement.Product
{
    internal class BrandManager
    {
        ConnectDatabase connectDb = new ConnectDatabase();

      
        private bool IsExistBrand(string brandId, SqlConnection conn)
        {
            connectDb.OpenSqlConnection(conn);

            string queryGetBrand = "Select count(*) from THUONG_HIEU_SP where Ma_thuong_hieu = @ma_thuong_hieu and Ma_nguoi_ban = @maNguoiBan";
            SqlCommand cmd = new SqlCommand(queryGetBrand, conn);
            cmd.Parameters.AddWithValue("@ma_thuong_hieu", brandId);
            cmd.Parameters.AddWithValue("@maNguoiBan", Session.userId);

            return ((int)cmd.ExecuteScalar() > 0);
        }
        internal void AddNewBrand(string brandId, string brandName)
        {
            SqlConnection conn = connectDb.GetConnection();
            connectDb.OpenSqlConnection(conn);

            try
            {
                if (this.IsExistBrand(brandId, conn))
                {
                    MessageBox.Show("Thương hiệu đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }                
                else
                {
                    string queryInsertBrand = "Insert into THUONG_HIEU_SP (Ma_thuong_hieu, Ten_thuong_hieu, Ma_nguoi_ban, username) values (@ma_thuong_hieu, @ten_thuong_hieu, @maNguoiBan, @tenNguoiDung);";
                    SqlCommand cmd = new SqlCommand(queryInsertBrand, conn);

                    cmd.Parameters.AddWithValue("@ma_thuong_hieu", brandId);
                    cmd.Parameters.AddWithValue("@ten_thuong_hieu", brandName);
                    cmd.Parameters.AddWithValue("@maNguoiBan", Session.userId);
                    cmd.Parameters.AddWithValue("@tenNguoiDung", Session.username);

                    int rowsAffect = (int)cmd.ExecuteNonQuery();

                    if (rowsAffect == 1)
                    {
                        MessageBox.Show("Thêm thương hiệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        internal void UpdateBrand(string brandId, string brandName)
        {
            SqlConnection conn = connectDb.GetConnection();
            connectDb.OpenSqlConnection(conn);

            try
            {
                if (this.IsExistBrand(brandId, conn))
                {
                    string query = "Update THUONG_HIEU_SP set Ten_thuong_hieu = @ten_thuong_hieu where Ma_thuong_hieu = @ma_thuong_hieu and Ma_nguoi_ban = @maNguoiBan;";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ma_thuong_hieu", brandId);
                    cmd.Parameters.AddWithValue("@ten_thuong_hieu", brandName);
                    cmd.Parameters.AddWithValue("@maNguoiBan", Session.userId);

                    int rowsAffect = (int)cmd.ExecuteNonQuery();

                    if (rowsAffect == 1)
                    {
                        MessageBox.Show("Cập nhật thương hiệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thương hiệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        internal void DeleteBrand(string brandId)
        {
            SqlConnection conn = connectDb.GetConnection();
            connectDb.OpenSqlConnection(conn);

            try
            {
                if (this.IsExistBrand(brandId, conn))
                {
                    string query = "Delete from THUONG_HIEU_SP where Ma_thuong_hieu = @ma_thuong_hieu and Ma_nguoi_ban = @maNguoiBan;";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ma_thuong_hieu", brandId);
                    cmd.Parameters.AddWithValue("@maNguoiBan", Session.userId);

                    int rowsAffect = (int)cmd.ExecuteNonQuery();

                    if (rowsAffect == 1)
                    {
                        MessageBox.Show("Xóa thương hiệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thương hiệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
