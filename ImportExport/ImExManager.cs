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

                    // 2. Insert từng dòng chi tiết + cập nhật tồn kho + cập nhật giá vốn nếu cần
                    foreach (var receipetDetails in receipetImportList)
                    {
                        // Insert vào Chi_tiet_phieu_nhap
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

                        // Lấy giá vốn hiện tại của sản phẩm
                        decimal giaVonHienTai = 0;
                        string selectGiaVon = @"
                    SELECT Gia_von 
                    FROM San_pham 
                    WHERE Ma_san_pham = @MaSanPham AND Ma_nguoi_ban = @MaNguoiBan";

                        using (SqlCommand cmd = new SqlCommand(selectGiaVon, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@MaSanPham", receipetDetails.ProductId);
                            cmd.Parameters.AddWithValue("@MaNguoiBan", maNguoiBan);
                            object result = cmd.ExecuteScalar();
                            if (result != null)
                            {
                                giaVonHienTai = Convert.ToDecimal(result);
                            }
                            else
                            {
                                throw new Exception($"Không tìm thấy sản phẩm {receipetDetails.ProductId} để kiểm tra giá vốn.");
                            }
                        }

                        // Nếu giá nhập vào lớn hơn giá vốn hiện tại -> cập nhật giá vốn
                        if (receipetDetails.ProductPrice > giaVonHienTai)
                        {
                            string updateGiaVon = @"
                        UPDATE San_pham
                        SET Gia_von = @GiaNhapVao
                        WHERE Ma_san_pham = @MaSanPham AND Ma_nguoi_ban = @MaNguoiBan";

                            using (SqlCommand cmd = new SqlCommand(updateGiaVon, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@GiaNhapVao", receipetDetails.ProductPrice);
                                cmd.Parameters.AddWithValue("@MaSanPham", receipetDetails.ProductId);
                                cmd.Parameters.AddWithValue("@MaNguoiBan", maNguoiBan);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        // Update So_luong_ton_kho của sản phẩm
                        string updateSoLuongTonKho = @"
                    UPDATE San_pham
                    SET So_luong_ton_kho = So_luong_ton_kho + @SoLuongNhap
                    WHERE Ma_san_pham = @MaSanPham AND Ma_nguoi_ban = @MaNguoiBan";

                        using (SqlCommand cmd = new SqlCommand(updateSoLuongTonKho, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@SoLuongNhap", receipetDetails.ProductQuantity);
                            cmd.Parameters.AddWithValue("@MaSanPham", receipetDetails.ProductId);
                            cmd.Parameters.AddWithValue("@MaNguoiBan", maNguoiBan);
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

        internal void InsertReceiptExport(string maPhieuXuat, DateTime ngayXuat, string ghiChu,
                                  decimal tongTienXuat, List<ReceiptExportDetails> receiptExportList)
        {
            int maNguoiBan = Session.userId;
            string username = Session.username;
            using (SqlConnection connection = connectDb.GetConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction(); // Bắt đầu giao dịch

                try
                {
                    // 1. Insert vào bảng Phieu_xuat_hang
                    string insertPhieuXuat = @"
                INSERT INTO Phieu_xuat_hang 
                (Ma_phieu_xuat, Ngay_xuat, Ghi_chu_phieu_xuat, Tong_tien_xuat, Ma_nguoi_ban, username) 
                VALUES (@MaPhieuXuat, @NgayXuat, @GhiChu, @TongTienXuat, @MaNguoiBan, @Username)";

                    using (SqlCommand cmd = new SqlCommand(insertPhieuXuat, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@MaPhieuXuat", maPhieuXuat);
                        cmd.Parameters.AddWithValue("@NgayXuat", ngayXuat);
                        cmd.Parameters.AddWithValue("@GhiChu", (object)ghiChu ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@TongTienXuat", tongTienXuat);
                        cmd.Parameters.AddWithValue("@MaNguoiBan", maNguoiBan);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.ExecuteNonQuery();
                    }

                    // 2. Insert từng dòng chi tiết + cập nhật tồn kho
                    foreach (var exportDetails in receiptExportList)
                    {
                        // 2.1 Kiểm tra tồn kho
                        string checkTonKho = @"
                    SELECT So_luong_ton_kho 
                    FROM San_pham 
                    WHERE Ma_san_pham = @MaSanPham AND Ma_nguoi_ban = @MaNguoiBan";

                        int soLuongTonKho = 0;
                        using (SqlCommand cmd = new SqlCommand(checkTonKho, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@MaSanPham", exportDetails.ProductId);
                            cmd.Parameters.AddWithValue("@MaNguoiBan", maNguoiBan);
                            object result = cmd.ExecuteScalar();
                            if (result != null)
                            {
                                soLuongTonKho = Convert.ToInt32(result);
                            }
                            else
                            {
                                throw new Exception($"Sản phẩm {exportDetails.ProductId} không tồn tại!");
                            }
                        }

                        if (soLuongTonKho < exportDetails.ProductQuantity)
                        {
                            throw new Exception($"Sản phẩm {exportDetails.ProductId} không đủ hàng trong kho! (Tồn kho: {soLuongTonKho}, Cần xuất: {exportDetails.ProductQuantity})");
                        }

                        // 2.2 Insert vào Chi_tiet_phieu_xuat
                        string insertChiTiet = @"
                    INSERT INTO Chi_tiet_phieu_xuat
                    (Ma_phieu_xuat, Ma_san_pham, So_luong, Gia_xuat)
                    VALUES (@MaPhieuXuat, @MaSanPham, @SoLuong, @GiaXuat)";

                        using (SqlCommand cmd = new SqlCommand(insertChiTiet, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@MaPhieuXuat", maPhieuXuat);
                            cmd.Parameters.AddWithValue("@MaSanPham", exportDetails.ProductId);
                            cmd.Parameters.AddWithValue("@SoLuong", exportDetails.ProductQuantity);
                            cmd.Parameters.AddWithValue("@GiaXuat", exportDetails.ProductPrice); // THÊM Giá xuất
                            cmd.ExecuteNonQuery();
                        }

                        // 2.3 Cập nhật tồn kho sản phẩm
                        string updateSoLuongTonKho = @"
                    UPDATE San_pham
                    SET So_luong_ton_kho = So_luong_ton_kho - @SoLuongXuat
                    WHERE Ma_san_pham = @MaSanPham AND Ma_nguoi_ban = @MaNguoiBan";

                        using (SqlCommand cmd = new SqlCommand(updateSoLuongTonKho, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@SoLuongXuat", exportDetails.ProductQuantity);
                            cmd.Parameters.AddWithValue("@MaSanPham", exportDetails.ProductId);
                            cmd.Parameters.AddWithValue("@MaNguoiBan", maNguoiBan);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit(); // Thành công thì commit
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); // Lỗi thì rollback
                    throw new Exception("Lỗi khi xuất phiếu hàng: " + ex.Message, ex);
                }
            }
        }
    }
}
