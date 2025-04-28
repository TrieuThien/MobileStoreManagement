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

namespace MobileStoreManagement.Supplier
{
    internal class SupplierManager
    {
        ConnectDatabase connectDb = new ConnectDatabase();


        internal void LoadNhaCungCap(DataGridView dataGridView)
        {
            using (SqlConnection connection = connectDb.GetConnection())
            {
                connection.Open();
                string query = @"
            SELECT Ma_nha_cung_cap, Ten_nha_cung_cap, SDT, Email, Dia_chi
            FROM Nha_cung_cap
            WHERE Ma_nguoi_ban = @MaNguoiBan";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaNguoiBan", Session.userId);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Gán dữ liệu vào DataGridView
                        dataGridView.DataSource = dataTable;

                        // Tùy chỉnh hiển thị cột
                        dataGridView.Columns["Ma_nha_cung_cap"].HeaderText = "Mã NCC";
                        dataGridView.Columns["Ten_nha_cung_cap"].HeaderText = "Tên nhà cung cấp";
                        dataGridView.Columns["SDT"].HeaderText = "Số điện thoại";
                        dataGridView.Columns["Email"].HeaderText = "Email";
                        dataGridView.Columns["Dia_chi"].HeaderText = "Địa chỉ";

                        // Căn chỉnh cho đẹp
                        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
        }

        internal void InsertNhaCungCap(NhaCungCap nhaCungCap)
        {
            int maNguoiBan = Session.userId;
            string username = Session.username;

            using (SqlConnection connection = connectDb.GetConnection())
            {
                connection.Open();
                string query = @"
            INSERT INTO Nha_cung_cap
            (Ma_nha_cung_cap, Ten_nha_cung_cap, SDT, Email, Dia_chi, Ma_nguoi_ban, username)
            VALUES (@MaNCC, @TenNCC, @SDT, @Email, @DiaChi, @MaNguoiBan, @Username)";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MaNCC", nhaCungCap.MaNhaCungCap);
                    cmd.Parameters.AddWithValue("@TenNCC", nhaCungCap.TenNhaCungCap);
                    cmd.Parameters.AddWithValue("@SDT", nhaCungCap.SDT);
                    cmd.Parameters.AddWithValue("@Email", nhaCungCap.Email);
                    cmd.Parameters.AddWithValue("@DiaChi", nhaCungCap.DiaChi);
                    cmd.Parameters.AddWithValue("@MaNguoiBan", maNguoiBan);
                    cmd.Parameters.AddWithValue("@Username", username);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        internal void DeleteNhaCungCap(string maNhaCungCap)
        {
            int maNguoiBan = Session.userId; // Lấy mã người bán hiện tại từ phiên đăng nhập

            using (SqlConnection connection = connectDb.GetConnection())
            {
                connection.Open();

                string query = @"
            DELETE FROM Nha_cung_cap
            WHERE Ma_nha_cung_cap = @MaNhaCungCap AND Ma_nguoi_ban = @MaNguoiBan";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MaNhaCungCap", maNhaCungCap);
                    cmd.Parameters.AddWithValue("@MaNguoiBan", maNguoiBan);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("Không tìm thấy nhà cung cấp để xóa.");
                    }
                }
            }
        }
        internal void UpdateNhaCungCap(NhaCungCap nhaCungCap)
        {
            int maNguoiBan = Session.userId;

            using (SqlConnection connection = connectDb.GetConnection())
            {
                connection.Open();
                string query = @"
            UPDATE Nha_cung_cap
            SET Ten_nha_cung_cap = @TenNCC,
                SDT = @SDT,
                Email = @Email,
                Dia_chi = @DiaChi
            WHERE Ma_nha_cung_cap = @MaNCC AND Ma_nguoi_ban = @MaNguoiBan";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MaNCC", nhaCungCap.MaNhaCungCap);
                    cmd.Parameters.AddWithValue("@TenNCC", nhaCungCap.TenNhaCungCap);
                    cmd.Parameters.AddWithValue("@SDT", nhaCungCap.SDT);
                    cmd.Parameters.AddWithValue("@Email", nhaCungCap.Email);
                    cmd.Parameters.AddWithValue("@DiaChi", nhaCungCap.DiaChi);
                    cmd.Parameters.AddWithValue("@MaNguoiBan", maNguoiBan);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("Không tìm thấy nhà cung cấp để cập nhật hoặc bạn không có quyền sửa!");
                    }
                }
            }
        }
        internal DataTable SearchNhaCungCap(string maNCC, string tenNCC)
        {
            int maNguoiBan = Session.userId;

            using (SqlConnection connection = connectDb.GetConnection())
            {
                connection.Open();

                string query = @"
            SELECT Ma_nha_cung_cap, Ten_nha_cung_cap, SDT, Email, Dia_chi
            FROM Nha_cung_cap
            WHERE Ma_nguoi_ban = @MaNguoiBan
              AND (@MaNCC IS NULL OR Ma_nha_cung_cap LIKE @MaNCC)
              AND (@TenNCC IS NULL OR Ten_nha_cung_cap LIKE @TenNCC)";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MaNguoiBan", maNguoiBan);
                    cmd.Parameters.AddWithValue("@MaNCC", string.IsNullOrEmpty(maNCC) ? (object)DBNull.Value : "%" + maNCC + "%");
                    cmd.Parameters.AddWithValue("@TenNCC", string.IsNullOrEmpty(tenNCC) ? (object)DBNull.Value : "%" + tenNCC + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
            
        internal void ExportNhaCungCapFromDataGridView(DataGridView dgv)
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
                saveFileDialog.FileName = "DanhSachNhaCungCap.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var fileInfo = new FileInfo(saveFileDialog.FileName);

                        using (var package = new ExcelPackage(fileInfo))
                        {
                            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("NhaCungCap");

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
