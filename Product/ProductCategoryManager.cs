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
    internal class ProductCategoryManager
    {
        ConnectDatabase connectDb = new ConnectDatabase();

        
        private bool IsExistPdCategory(string productCategoryId, SqlConnection conn)
        {
            connectDb.OpenSqlConnection(conn);

            string query = "Select count(*) from DANH_MUC_SP where Ma_danh_muc = @MaDanhMuc and Ma_nguoi_ban = @maNguoiBan";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaDanhMuc", productCategoryId);
            cmd.Parameters.AddWithValue("@maNguoiBan", Session.userId);


            return ((int)cmd.ExecuteScalar() > 0);
        }
        internal void AddNewPdCategory(string productCategoryId, string productCategoryName)
        {
            SqlConnection conn = connectDb.GetConnection();
            connectDb.OpenSqlConnection(conn);

            try
            {
                if (this.IsExistPdCategory(productCategoryId, conn))
                {
                    MessageBox.Show("Danh mục sản phẩm đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string query = "Insert into DANH_MUC_SP (Ma_danh_muc, Ten_danh_muc, Ma_nguoi_ban, username) values (@MaDanhMuc, @TenDanhMuc, @maNguoiBan, @tenNguoiDung);";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@MaDanhMuc", productCategoryId);
                    cmd.Parameters.AddWithValue("@TenDanhMuc", productCategoryName); 
                    cmd.Parameters.AddWithValue("@maNguoiBan", Session.userId);
                    cmd.Parameters.AddWithValue("@tenNguoiDung", Session.username);

                    int rowsAffect = (int)cmd.ExecuteNonQuery();

                    if (rowsAffect == 1)
                    {
                        MessageBox.Show("Thêm danh mục sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        internal void UpdateProductCategory(string productCategoryId, string productCategoryName)
        {
            SqlConnection conn = connectDb.GetConnection();
            connectDb.OpenSqlConnection(conn);

            try
            {
                if (this.IsExistPdCategory(productCategoryId, conn))
                {
                    string query = "Update DANH_MUC_SP set Ten_danh_muc = @TenDanhMuc where Ma_danh_muc = @MaDanhMuc and Ma_nguoi_ban = @maNguoiBan;";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaDanhMuc", productCategoryId);
                    cmd.Parameters.AddWithValue("@TenDanhMuc", productCategoryName);
                    cmd.Parameters.AddWithValue("@maNguoiBan", Session.userId);

                    int rowsAffect = (int)cmd.ExecuteNonQuery();

                    if (rowsAffect == 1)
                    {
                        MessageBox.Show("Cập nhật danh mục thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy danh mục sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        internal void DeleteProductCategory(string productCategoryId)
        {
            SqlConnection conn = connectDb.GetConnection();
            connectDb.OpenSqlConnection(conn);

            try
            {
                if (this.IsExistPdCategory(productCategoryId, conn))
                {
                    string query = "Delete from DANH_MUC_SP where Ma_danh_muc = @MaDanhMuc and Ma_nguoi_ban = @maNguoiBan;";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaDanhMuc", productCategoryId);
                    cmd.Parameters.AddWithValue("@maNguoiBan", Session.userId);

                    int rowsAffect = (int)cmd.ExecuteNonQuery();

                    if (rowsAffect == 1)
                    {
                        MessageBox.Show("Xóa danh mục sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy danh mục sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
