using MobileStoreManagement.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStoreManagement
{
    public partial class UserControlProductManagement : UserControl
    {
        ProductManager pdManagement = new ProductManager();
        public UserControlProductManagement()
        {
            InitializeComponent();
        }

        private void refeshData()
        {
            pdManagement.LoadBrandsToCheckedListBox(checkedLbBrandCategories);
            pdManagement.LoadCategoriesToCheckedListBox(checkedLbPdCategories);
        }

        private void ShowAllProducts()
        {
            // Load data from database
            DataTable dtProducts = pdManagement.GetAllProducts();

            foreach (DataRow row in dtProducts.Rows)
            {
                string maSanPham = row["Ma_san_pham"].ToString();
                string tenSanPham = row["Ten_san_pham"].ToString();
                decimal giaVon = row.Field<decimal>("Gia_von");
                decimal giaBan = row.Field<decimal>("Gia_ban");
                int tonKho = row.Field<int>("So_luong_ton_kho");
                int soLuongDatNCC = row.Field<int>("So_luong_dat_NCC");
                int soLuongKhachDat = row.Field<int>("Khach_dat");
                string tinhTrang = row["Tinh_trang_san_pham"].ToString();

                // Lấy hình ảnh từ byte[]
                Image hinhAnh;
                if (row["Hinh_anh_san_pham"] != DBNull.Value)
                {
                    try
                    {
                        byte[] imageBytes = (byte[])row["Hinh_anh_san_pham"];
                        hinhAnh = ImageHandle.ByteArrayToImage(imageBytes);
                    }
                    catch (ArgumentException ex)
                    {
                        hinhAnh = Properties.Resources.online_store;
                    }
                }
                else
                {
                    hinhAnh = Properties.Resources.online_store; // Sử dụng một ảnh mặc định
                }

                UserControlProductItems productItem = new UserControlProductItems(maSanPham, tenSanPham, tinhTrang, giaBan, giaVon, soLuongDatNCC, soLuongKhachDat, tonKho);
                productItem.setPicture(hinhAnh);
                flowLayoutPanelProductList.Controls.Add(productItem);
            }
        }
        private void UserControlProductManagement_Load(object sender, EventArgs e)
        {
            refeshData();

            UserControlProductItems header = new UserControlProductItems(isSetup: true);
            header.Dock = DockStyle.Top;
            flowLayoutPanelProductList.Controls.Add(header);

            ShowAllProducts();
        }

        private void LoadFilteredProductsToUI()
        {
            // Xóa hết các control cũ trong flowLayoutPanel
            flowLayoutPanelProductList.Controls.Clear();

            // Thêm lại header
            UserControlProductItems header = new UserControlProductItems(isSetup: true);
            header.Dock = DockStyle.Top;
            flowLayoutPanelProductList.Controls.Add(header);

            // Kiểm tra xem có ô nào được check không
            bool anyBrandChecked = checkedLbBrandCategories.CheckedItems.Count > 0;
            bool anyCategoryChecked = checkedLbPdCategories.CheckedItems.Count > 0;

            DataTable dtProducts;

            if (!anyBrandChecked && !anyCategoryChecked)
            {
                // Nếu không check gì -> Load toàn bộ sản phẩm
                dtProducts = pdManagement.GetAllProducts();
            }
            else
            {
                // Nếu có check -> Lọc theo check
                dtProducts = pdManagement.LoadFilteredProducts(checkedLbBrandCategories, checkedLbPdCategories);
            }

            // Load các sản phẩm lên giao diện
            foreach (DataRow row in dtProducts.Rows)
            {
                string maSanPham = row["Ma_san_pham"].ToString();
                string tenSanPham = row["Ten_san_pham"].ToString();
                decimal giaVon = row.Field<decimal>("Gia_von");
                decimal giaBan = row.Field<decimal>("Gia_ban");
                int tonKho = row.Field<int>("So_luong_ton_kho");
                int soLuongDatNCC = row.Field<int>("So_luong_dat_NCC");
                int soLuongKhachDat = row.Field<int>("Khach_dat");
                string tinhTrang = row["Tinh_trang_san_pham"].ToString();

                // Lấy hình ảnh
                Image hinhAnh;
                if (row["Hinh_anh_san_pham"] != DBNull.Value)
                {
                    try
                    {
                        byte[] imageBytes = (byte[])row["Hinh_anh_san_pham"];
                        hinhAnh = ImageHandle.ByteArrayToImage(imageBytes);
                    }
                    catch (ArgumentException ex)
                    {
                        hinhAnh = Properties.Resources.online_store;
                    }
                }
                else
                {
                    hinhAnh = Properties.Resources.online_store; // Sử dụng một ảnh mặc định
                }

                // Tạo UserControl sản phẩm
                UserControlProductItems productItem = new UserControlProductItems(maSanPham, tenSanPham, tinhTrang, giaBan, giaVon, soLuongDatNCC, soLuongKhachDat, tonKho);
                productItem.setPicture(hinhAnh);

                flowLayoutPanelProductList.Controls.Add(productItem);
            }
        }

        private void SearchProductsAndDisplay(string searchTerm)
        {
            // Xóa hết các control cũ trong flowLayoutPanel
            flowLayoutPanelProductList.Controls.Clear();

            // Thêm lại header
            UserControlProductItems header = new UserControlProductItems(isSetup: true);
            header.Dock = DockStyle.Top;
            flowLayoutPanelProductList.Controls.Add(header);

            // Lấy dữ liệu tìm kiếm từ database
            DataTable dtProducts = pdManagement.SearchProducts(searchTerm);

            // Kiểm tra nếu không có sản phẩm nào
            if (dtProducts.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sản phẩm nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Load các sản phẩm lên giao diện
            foreach (DataRow row in dtProducts.Rows)
            {
                string maSanPham = row["Ma_san_pham"].ToString();
                string tenSanPham = row["Ten_san_pham"].ToString();
                decimal giaVon = row.Field<decimal>("Gia_von");
                decimal giaBan = row.Field<decimal>("Gia_ban");
                int tonKho = row.Field<int>("So_luong_ton_kho");
                int soLuongDatNCC = row.Field<int>("So_luong_dat_NCC");
                int soLuongKhachDat = row.Field<int>("Khach_dat");
                string tinhTrang = row["Tinh_trang_san_pham"].ToString();

                // Lấy hình ảnh
                Image hinhAnh;
                if (row["Hinh_anh_san_pham"] != DBNull.Value)
                {
                    try
                    {
                        byte[] imageBytes = (byte[])row["Hinh_anh_san_pham"];
                        hinhAnh = ImageHandle.ByteArrayToImage(imageBytes);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine("Lỗi khi chuyển đổi hình ảnh: " + ex.Message);
                        hinhAnh = Properties.Resources.online_store; // Gán hình ảnh mặc định nếu có lỗi
                    }
                }
                else
                {
                    hinhAnh = Properties.Resources.online_store; // Gán hình ảnh mặc định khi không có hình ảnh
                }

                // Tạo UserControl sản phẩm
                UserControlProductItems productItem = new UserControlProductItems(maSanPham, tenSanPham, tinhTrang, giaBan, giaVon, soLuongDatNCC, soLuongKhachDat, tonKho);
                productItem.setPicture(hinhAnh);

                flowLayoutPanelProductList.Controls.Add(productItem);
            }
        }

        // Hàm xuất file excel
        private void SaveExcelFile()
        {
            // Tạo SaveFileDialog để chọn tên và vị trí lưu file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Chọn vị trí và tên tệp Excel";
            saveFileDialog.Filter = "Tệp Excel (*.xlsx)|*.xlsx"; // Chỉ cho phép chọn file Excel với định dạng .xlsx

            // Đặt thư mục mặc định
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); 

            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Lấy đường dẫn và tên file mà người dùng chọn
                    string filePath = saveFileDialog.FileName;

                    // Gọi hàm xuất sản phẩm ra Excel với đường dẫn đã chọn
                    
                    pdManagement.ExportProductsToExcel(filePath);

                    MessageBox.Show("Đã lưu file Excel thành công tại: " + filePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi lưu file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // Các hàm xử lý sự kiện
        private void buttonAddNewProduct_Click(object sender, EventArgs e)
        {
            FormProductDetails formProductDetails = new FormProductDetails();
            formProductDetails.ShowDialog();
            refeshData();

        }

        private void buttonAddNewManufacturer_Click(object sender, EventArgs e)
        {
            FormBrandCategory formBrandCategory = new FormBrandCategory();
            formBrandCategory.ShowDialog();
            refeshData();

        }

        private void labelSearch_Click(object sender, EventArgs e)
        {
            textBoxGetKeyWordSearch.Focus();
        }

        private void buttonAddNewProductCategory_Click(object sender, EventArgs e)
        {
           FormProductCategory formProductCategory = new FormProductCategory(); 
           formProductCategory.ShowDialog();
           refeshData();

        }

        private void checkedLbBrandCategory_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke(new Action(LoadFilteredProductsToUI));
        }

        private void checkedLbPdCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(LoadFilteredProductsToUI));
        }

        private void buttonSearchProduct_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxGetKeyWordSearch.Text.Trim(); // Lấy từ khóa tìm kiếm
            if (searchTerm.Length > 0 ) 
            { 
                SearchProductsAndDisplay(searchTerm);
            }
            else
            {
                ShowAllProducts();
            }
        }

        // Sự kiện nhấn vào nút xuất file
        private void buttonExportFile_Click(object sender, EventArgs e)
        {
            SaveExcelFile();
        }
    }
}
