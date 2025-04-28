using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Drawing;


namespace MobileStoreManagement.Customers
{
    internal class CustomersManager
    {
        ConnectDatabase connectDb = new ConnectDatabase();

        internal void LoadKhachHang(DataGridView dataGridView)
        {
            using (SqlConnection connection = connectDb.GetConnection())
            {
                connection.Open();

                // Cập nhật câu truy vấn để lấy tất cả khách hàng
                string query = @"
        SELECT Ma_khach_hang, Ten_khach_hang, SDT, Email, Dia_chi
        FROM khach_hang";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("Không có khách hàng nào trong cơ sở dữ liệu.");
                            return;
                        }

                        // Gán dữ liệu vào DataGridView
                        dataGridView.DataSource = dataTable;

                        // Tùy chỉnh hiển thị cột
                        dataGridView.Columns["Ma_khach_hang"].HeaderText = "Mã KH";
                        dataGridView.Columns["Ten_khach_hang"].HeaderText = "Tên khách hàng";
                        dataGridView.Columns["SDT"].HeaderText = "Số điện thoại";
                        dataGridView.Columns["Email"].HeaderText = "Email";
                        dataGridView.Columns["Dia_chi"].HeaderText = "Địa chỉ";

                        // Căn chỉnh cho đẹp
                        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
        }




        internal void InsertKhachHang(KhachHang KhachHang)
        {
            int maNguoiBan = Session.userId;
            string username = Session.username;

            using (SqlConnection connection = connectDb.GetConnection())
            {
                connection.Open();
                string query = @"
            INSERT INTO Khach_hang
            (Ma_khach_hang, Ten_khach_hang, SDT, Email, Dia_chi,  Ma_nguoi_ban, username)
            VALUES (@MaKH, @TenKH, @SDT, @Email, @DiaChi, @MaNguoiBan, @Username)";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MaKH", KhachHang.MaKhachHang);
                    cmd.Parameters.AddWithValue("@TenKH", KhachHang.TenKhachHang);
                    cmd.Parameters.AddWithValue("@SDT", KhachHang.SDT);
                    cmd.Parameters.AddWithValue("@Email", KhachHang.Email);
                    cmd.Parameters.AddWithValue("@DiaChi", KhachHang.DiaChi);
                    
                  
                    cmd.Parameters.AddWithValue("@MaNguoiBan", maNguoiBan);
                    cmd.Parameters.AddWithValue("@Username", username);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        internal void DeleteKhachHang(string maKhachHang)
        {
            int maNguoiBan = Session.userId; // Lấy mã người bán hiện tại từ phiên đăng nhập

            using (SqlConnection connection = connectDb.GetConnection())
            {
                connection.Open();

                string query = @"
            DELETE FROM Khach_hang
            WHERE Ma_khach_hang= @MaKhachHang AND Ma_nguoi_ban = @MaNguoiBan";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                    cmd.Parameters.AddWithValue("@MaNguoiBan", maNguoiBan);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("Không tìm thấy khách hàng để xóa.");
                    }
                }
            }
        }

        internal void UpdateKhachHang(KhachHang KhachHang)
        {
            int maNguoiBan = Session.userId;

            using (SqlConnection connection = connectDb.GetConnection())
            {
                connection.Open();
                string query = @"
            UPDATE Khach_hang
            SET Ten_khach_hang = @TenKH,
                SDT = @SDT,
                Email = @Email,
                Dia_chi = @DiaChi,
                
            WHERE Ma_khach_hang = @MaKH AND Ma_nguoi_ban = @MaNguoiBan";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MaKH", KhachHang.MaKhachHang);
                    cmd.Parameters.AddWithValue("@TenKH", KhachHang.TenKhachHang);
                    cmd.Parameters.AddWithValue("@SDT", KhachHang.SDT);
                    cmd.Parameters.AddWithValue("@Email", KhachHang.Email);
                    cmd.Parameters.AddWithValue("@DiaChi", KhachHang.DiaChi);
                   
                    cmd.Parameters.AddWithValue("@MaNguoiBan", maNguoiBan);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("Không tìm thấy khách hàng để cập nhật hoặc bạn không có quyền sửa!");
                    }
                }
            }
        }

        internal DataTable SearchKhachHang(string maKH, string tenKH)
        {
            int maNguoiBan = Session.userId;

            using (SqlConnection connection = connectDb.GetConnection())
            {
                connection.Open();

                string query = @"
            SELECT Ma_khach_hang, Ten_khach_hang, SDT, Email, Dia_chi
            FROM Khach_hang
            WHERE Ma_nguoi_ban = @MaNguoiBan
              AND (@MaKH IS NULL OR Ma_khach_hang LIKE @MaKH)
              AND (@TenKH IS NULL OR Ten_khach_hang LIKE @TenKH)";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MaNguoiBan", maNguoiBan);
                    cmd.Parameters.AddWithValue("@MaKH", string.IsNullOrEmpty(maKH) ? (object)DBNull.Value : "%" + maKH + "%");
                    cmd.Parameters.AddWithValue("@TenKH", string.IsNullOrEmpty(tenKH) ? (object)DBNull.Value : "%" + tenKH + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        internal void ExportKhachHangFromDataGridView(DataGridView dgv)
        {
            ExcelPackage.License.SetNonCommercialPersonal("LAMTRIEUTHIEN");

            if (dgv == null || dgv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Chọn nơi lưu file Excel";
                saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                saveFileDialog.FileName = "DanhSachKhachHang.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var fileInfo = new FileInfo(saveFileDialog.FileName);

                        using (var package = new ExcelPackage(fileInfo))
                        {
                            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("KhachHang");

                            // Đổ dữ liệu cột tiêu đề
                            for (int col = 0; col < dgv.Columns.Count; col++)
                            {
                                worksheet.Cells[1, col + 1].Value = dgv.Columns[col].HeaderText;
                                worksheet.Cells[1, col + 1].Style.Font.Bold = true;
                                worksheet.Cells[1, col + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                                worksheet.Cells[1, col + 1].Style.Fill.BackgroundColor.SetColor(Color.LightGray);
                                worksheet.Cells[1, col + 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            }

                            // Đổ dữ liệu các dòng
                            int rowIndex = 2; // bắt đầu từ dòng thứ 2
                            foreach (DataGridViewRow row in dgv.Rows)
                            {
                                if (!row.IsNewRow) // bỏ qua dòng mới để thêm
                                {
                                    for (int col = 0; col < dgv.Columns.Count; col++)
                                    {
                                        worksheet.Cells[rowIndex, col + 1].Value = row.Cells[col].Value;
                                    }
                                    rowIndex++;
                                }
                            }

                            // Auto-fit các cột
                            worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                            package.Save();
                        }

                        MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi khi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
