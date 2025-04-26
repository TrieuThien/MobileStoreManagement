using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;

namespace MobileStoreManagement.Product
{
    internal class ProductManager
    {
        ConnectDatabase connectDb = new ConnectDatabase();
        internal void LoadBrandsToCheckedListBox(CheckedListBox clbBrands)
        {
            SqlConnection conn = connectDb.GetConnection();
            connectDb.OpenSqlConnection(conn);
            string query = "SELECT Ma_thuong_hieu, Ten_thuong_hieu FROM THUONG_HIEU_SP WHERE Ma_nguoi_ban = @maNguoiBan";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@maNguoiBan", Session.userId);

            DataTable dt = new DataTable();

            try
            {
                adapter.Fill(dt); // Đổ dữ liệu từ DB vào DataTable

                clbBrands.Items.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    // Add item (có thể lưu tag là ID nếu cần dùng sau này)
                    clbBrands.Items.Add(new ListItem
                    {
                        Display = row["Ten_thuong_hieu"].ToString(),
                        Value = row["Ma_thuong_hieu"].ToString()
                    }, false);
                }
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
        internal void LoadCategoriesToCheckedListBox(CheckedListBox clbCategories)
        {
            SqlConnection conn = connectDb.GetConnection();
            connectDb.OpenSqlConnection(conn);
            string query = "SELECT Ma_danh_muc, Ten_danh_muc FROM DANH_MUC_SP WHERE Ma_nguoi_ban = @maNguoiBan";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@maNguoiBan", Session.userId);

            DataTable dt = new DataTable();

            try
            {
                adapter.Fill(dt); // Đổ dữ liệu từ DB vào DataTable

                clbCategories.Items.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    clbCategories.Items.Add(new ListItem
                    {
                        Display = row["Ten_danh_muc"].ToString(),
                        Value = row["Ma_danh_muc"].ToString()
                    }, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh mục: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        internal void LoadProductCategoriesToComboBox(ComboBox cbCategory)
        {
            SqlConnection conn = connectDb.GetConnection();
            connectDb.OpenSqlConnection(conn);

            string query = "SELECT Ma_danh_muc, Ten_danh_muc FROM DANH_MUC_SP WHERE Ma_nguoi_ban = @maNguoiBan";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@maNguoiBan", Session.userId);

            DataTable dt = new DataTable();

            try
            {
                adapter.Fill(dt);

                cbCategory.DataSource = dt;
                cbCategory.DisplayMember = "Ten_danh_muc"; // Hiển thị tên
                cbCategory.ValueMember = "Ma_danh_muc";    // Giá trị là mã
                cbCategory.SelectedIndex = -1; // Không chọn mặc định
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh mục sản phẩm: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        internal void LoadBrandsToComboBox(ComboBox cbBrand)
        {
            SqlConnection conn = connectDb.GetConnection();
            connectDb.OpenSqlConnection(conn);

            string query = "SELECT Ma_thuong_hieu, Ten_thuong_hieu FROM THUONG_HIEU_SP WHERE Ma_nguoi_ban = @maNguoiBan";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@maNguoiBan", Session.userId);

            DataTable dt = new DataTable();

            try
            {
                adapter.Fill(dt);

                cbBrand.DataSource = dt;
                cbBrand.DisplayMember = "Ten_thuong_hieu"; // Hiển thị tên
                cbBrand.ValueMember = "Ma_thuong_hieu";    // Giá trị là mã
                cbBrand.SelectedIndex = -1; // Không chọn mặc định
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
        internal void InsertProduct(string productId, string productName, string pdBrands, string pdCategories, decimal price, string productDes, string productStatus, string imagePath)
        {
            try
            {
                using (SqlConnection connection = connectDb.GetConnection())
                {
                    string query = @"
                        INSERT INTO San_pham (
                            Ma_san_pham, Ma_thuong_hieu, Ma_danh_muc, Hinh_anh_san_pham, Ten_san_pham, 
                            Gia_von, Gia_ban, So_luong_ton_kho, Thong_tin_mo_ta, Tinh_trang_san_pham, 
                            Khach_dat, So_luong_dat_NCC, Ma_nguoi_ban, username
                        )
                        VALUES (
                            @Ma_san_pham, @Ma_thuong_hieu, @Ma_danh_muc, @Hinh_anh_san_pham, @Ten_san_pham, 
                            @Gia_von, @Gia_ban, @So_luong_ton_kho, @Thong_tin_mo_ta, @Tinh_trang_san_pham, 
                            @Khach_dat, @So_luong_dat_NCC, @Ma_nguoi_ban, @username
                        )";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Map form fields to parameters
                        command.Parameters.AddWithValue("@Ma_san_pham", productId);
                        command.Parameters.AddWithValue("@Ma_thuong_hieu", pdBrands);
                        command.Parameters.AddWithValue("@Ma_danh_muc", pdCategories);

                        // Convert image to byte array
                        byte[] imageBytes = null;
                        if (!string.IsNullOrEmpty(imagePath))
                        {
                            var img = ImageHandle.GetImage(imagePath);
                            if (img != null)
                            {
                                imageBytes = ImageHandle.ImageToByteArray(img);
                            }
                        }
                        command.Parameters.AddWithValue("@Hinh_anh_san_pham", (object)imageBytes ?? DBNull.Value);

                        command.Parameters.AddWithValue("@Ten_san_pham", productName);
                        command.Parameters.AddWithValue("@Gia_von", 0); // Default value
                        command.Parameters.AddWithValue("@Gia_ban", price);
                        command.Parameters.AddWithValue("@So_luong_ton_kho", 0); // Default value
                        command.Parameters.AddWithValue("@Thong_tin_mo_ta", productDes);

                        // Map product status to 'M' (new) or 'C' (old)

                        command.Parameters.AddWithValue("@Tinh_trang_san_pham", productStatus);

                        command.Parameters.AddWithValue("@Khach_dat", 0); // Default value
                        command.Parameters.AddWithValue("@So_luong_dat_NCC", 0); // Default value
                        command.Parameters.AddWithValue("@Ma_nguoi_ban", Session.userId);
                        command.Parameters.AddWithValue("@username", Session.username);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Lỗi cơ sở dữ liệu: {ex.Message}", ex);
            }
            catch (IOException ex)
            {
                throw new Exception($"Lỗi khi đọc tệp hình ảnh: {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        internal DataTable GetAllProducts()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = connectDb.GetConnection())
                {
                    string query = @"
                SELECT 
                    Ma_san_pham,
                    Hinh_anh_san_pham,
                    Ten_san_pham,
                    Gia_von,
                    Gia_ban,
                    So_luong_ton_kho,
                    Thong_tin_mo_ta,
                    Tinh_trang_san_pham,
                    Khach_dat,
                    So_luong_dat_NCC,
                    Ma_nguoi_ban,
                    username
                FROM San_pham
                WHERE Ma_nguoi_ban = @maNguoiBan";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@maNguoiBan", Session.userId);

                    adapter.Fill(dt); // Đổ dữ liệu vào DataTable
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }
        internal DataTable LoadFilteredProducts(CheckedListBox checkedListBoxBrands, CheckedListBox checkedListBoxCategories)
        {
            // Lấy danh sách mã thương hiệu được check
            List<string> selectedBrandIds = new List<string>();
            foreach (var item in checkedListBoxBrands.CheckedItems)
            {
                if (item is ListItem listItem)
                {
                    selectedBrandIds.Add(listItem.Value);
                }
            }

            // Lấy danh sách mã danh mục được check
            List<string> selectedCategoryIds = new List<string>();
            foreach (var item in checkedListBoxCategories.CheckedItems)
            {
                if (item is ListItem listItem)
                {
                    selectedCategoryIds.Add(listItem.Value);
                }
            }

            DataTable dt = new DataTable();
            // Nếu không chọn gì thì không lọc (hoặc load hết)
            if (selectedBrandIds.Count == 0 && selectedCategoryIds.Count == 0)
            {
                // TODO: Load hết sản phẩm hoặc hiển thị thông báo
                return dt;
            }

            // Tạo câu lệnh SQL
            string query = "SELECT * FROM San_pham WHERE Ma_nguoi_ban = @maNguoiBan";

            if (selectedBrandIds.Count > 0)
            {
                string brandsCondition = string.Join(",", selectedBrandIds.Select(id => $"'{id}'"));
                query += $" AND Ma_thuong_hieu IN ({brandsCondition})";
            }

            if (selectedCategoryIds.Count > 0)
            {
                string categoriesCondition = string.Join(",", selectedCategoryIds.Select(id => $"'{id}'"));
                query += $" AND Ma_danh_muc IN ({categoriesCondition})";
            }

            // Lấy dữ liệu
            using (SqlConnection conn = connectDb.GetConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@maNguoiBan", Session.userId);


                adapter.Fill(dt);

                return dt;
            }
        }
        public DataTable SearchProducts(string searchTerm)
        {
            DataTable dt = new DataTable();

            // Tạo câu lệnh SQL với điều kiện tìm kiếm theo tên hoặc mã sản phẩm
            string query = @"
        SELECT * FROM San_pham 
        WHERE (Ma_san_pham LIKE @searchTerm OR Ten_san_pham LIKE @searchTerm)
        AND Ma_nguoi_ban = @maNguoiBan";

            using (SqlConnection conn = connectDb.GetConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                adapter.SelectCommand.Parameters.AddWithValue("@maNguoiBan", Session.userId);

                adapter.Fill(dt);
            }

            return dt;
        }
        public void ExportProductsToExcel(string filePath)
        {
            DataTable dtProducts = GetAllProducts();
            // Kiểm tra nếu DataTable không có dữ liệu
            if (dtProducts == null || dtProducts.Rows.Count == 0)
            {
                throw new Exception("Không có dữ liệu để xuất.");
            }

            // Tạo file Excel mới
            using (var package = new ExcelPackage())
            {
                // Tạo sheet mới
                var worksheet = package.Workbook.Worksheets.Add("Sản phẩm");

                // Ghi tiêu đề cột
                for (int i = 1; i <= dtProducts.Columns.Count; i++)
                {
                    worksheet.Cells[1, i].Value = dtProducts.Columns[i - 1].ColumnName;
                    worksheet.Cells[1, i].Style.Font.Bold = true;
                    worksheet.Cells[1, i].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    worksheet.Cells[1, i].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                }

                // Ghi dữ liệu vào các ô
                for (int i = 0; i < dtProducts.Rows.Count; i++)
                {
                    for (int j = 0; j < dtProducts.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dtProducts.Rows[i][j];
                    }
                }

                // Lưu file Excel
                FileInfo fi = new FileInfo(filePath);
                package.SaveAs(fi);
            }

            // Thông báo thành công
            MessageBox.Show("Đã xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
