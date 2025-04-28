using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStoreManagement.ImportExport
{
    internal class ImExManager
    {
        ConnectDatabase connectDb = new ConnectDatabase();
        internal void LoadSupplierToComboBox(ComboBox comboBox) 
        {
            SqlConnection conn = connectDb.GetConnection();
            connectDb.OpenSqlConnection(conn);

            string query = "SELECT Ma_nha_cung_cap, Ten_nha_cung_cap FROM Nha_cung_cap WHERE Ma_nguoi_ban = @maNguoiBan";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@maNguoiBan", Session.userId);

            DataTable dt = new DataTable();

            try
            {
                adapter.Fill(dt);

                comboBox.DataSource = dt;
                comboBox.DisplayMember = "Ten_nha_cung_cap"; // Hiển thị tên
                comboBox.ValueMember = "Ma_nha_cung_cap";    // Giá trị là mã
                comboBox.SelectedIndex = -1; // Không chọn mặc định

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thương hiệu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        internal void InsertReceiptImport(string maPhieuNhap, string maNhaCungCap, DateTime ngayNhap,
                                  decimal tongTienNhap, decimal? giamGia, string ghiChu,
                                  List<ReceiptImportDetails> receipetImportList)
        {
            int maNguoiBan = Session.userId;
            string username = Session.username;
            using (SqlConnection connection = connectDb.GetConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction(); // Bắt đầu giao dịch

                try
                {
                    // 1. Insert vào bảng Phieu_nhap_hang_
                    string insertPhieuNhap = @"
                INSERT INTO Phieu_nhap_hang_ 
                (Ma_phieu_nhap, Ma_nha_cung_cap, Ngay_nhap, Tong_tien_nhap, Giam_gia, Ghi_chu_phieu_nhap, Ma_nguoi_ban, username) 
                VALUES (@MaPhieuNhap, @MaNhaCungCap, @NgayNhap, @TongTienNhap, @GiamGia, @GhiChu, @MaNguoiBan, @Username)";

                    using (SqlCommand cmd = new SqlCommand(insertPhieuNhap, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@MaPhieuNhap", maPhieuNhap);
                        cmd.Parameters.AddWithValue("@MaNhaCungCap", maNhaCungCap);
                        cmd.Parameters.AddWithValue("@NgayNhap", ngayNhap);
                        cmd.Parameters.AddWithValue("@TongTienNhap", tongTienNhap);
                        cmd.Parameters.AddWithValue("@GiamGia", (object)giamGia ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@GhiChu", (object)ghiChu ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@MaNguoiBan", maNguoiBan);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.ExecuteNonQuery();
                    }

                    // 2. Insert từng dòng chi tiết
                    foreach (var receipetDetails in receipetImportList)
                    {
                        string insertChiTiet = @"
                    INSERT INTO Chi_tiet_phieu_nhap 
                    (Ma_phieu_nhap, Ma_san_pham, So_luong_nhap, Gia_nhap_vao) 
                    VALUES (@MaPhieuNhap, @MaSanPham, @SoLuongNhap, @GiaNhapVao)";

                        using (SqlCommand cmd = new SqlCommand(insertChiTiet, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@MaPhieuNhap", maPhieuNhap);
                            cmd.Parameters.AddWithValue("@MaSanPham", receipetDetails.ProductId);
                            cmd.Parameters.AddWithValue("@SoLuongNhap", receipetDetails.ProductQuantity);
                            cmd.Parameters.AddWithValue("@GiaNhapVao", receipetDetails.ProductPrice);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit(); // Thành công thì commit
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); // Lỗi thì rollback
                    throw new Exception("Lỗi khi thêm phiếu nhập hàng: " + ex.Message, ex);
                }
            }
        }

    }
}
