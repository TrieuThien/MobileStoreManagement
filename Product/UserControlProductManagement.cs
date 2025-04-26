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
            pdManagement.LoadBrandsToCheckedListBox(checkedLbBrandCategory);
            pdManagement.LoadCategoriesToCheckedListBox(checkedLbPdCategory);
        }
        private void UserControlProductManagement_Load(object sender, EventArgs e)
        {
            refeshData();

            UserControlProductItems header = new UserControlProductItems(isSetup: true);
            header.Dock = DockStyle.Top;
            flowLayoutPanelProductList.Controls.Add(header);

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
                string moTa = row["Thong_tin_mo_ta"].ToString();
                string tinhTrang = row["Tinh_trang_san_pham"].ToString();

                // Lấy hình ảnh từ byte[]
                Image hinhAnh = null;
                if (row["Hinh_anh_san_pham"] != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])row["Hinh_anh_san_pham"];
                    hinhAnh = ImageHandle.ByteArrayToImage(imageBytes);
                }

                UserControlProductItems productItem = new UserControlProductItems(maSanPham, tenSanPham, tinhTrang, giaBan, giaVon, soLuongDatNCC, soLuongKhachDat, tonKho);
                productItem.setPicture(hinhAnh);
                flowLayoutPanelProductList.Controls.Add(productItem);
            }
        }

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
    }
}
