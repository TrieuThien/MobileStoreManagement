using MobileStoreManagement.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStoreManagement
{
    public partial class FormProductDetails : Form
    {
        ProductManager pdManager = new ProductManager();
        string selectedImagePath = string.Empty;
        bool isUpdateProduct = false;

        
        public FormProductDetails()
        {
            InitializeComponent();
        }

        public FormProductDetails(bool isUpdate, string productId, string productName, decimal productPrice, string productDes)
        {
            InitializeComponent();
            isUpdateProduct = isUpdate;
            textBoxProductName.Text = productName;
            textBoxProductId.Text = productId;
            textBoxProductPrice.Text = productPrice.ToString();
            richTextBoxProductDescribe.Text = productDes;
            
        }

        private void buttonChangePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn một tập tin";
            openFileDialog.Filter = "Tệp hình ảnh (*.jpg;*.png;*jpeg)|*.jpg;*.png;*.jpeg";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Lấy đường dẫn tệp
                    selectedImagePath = openFileDialog.FileName;

                    // Hiển thị hình ảnh trong PictureBox
                    pictureBoxProductImage.Image = Image.FromFile(selectedImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải hình ảnh: {ex.Message}", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    selectedImagePath = string.Empty; // Đặt lại nếu có lỗi
                }
            }
        }
        public string getImagePath()
        {
            return selectedImagePath;
        }

        private void labelProductName_Click(object sender, EventArgs e)
        {
            textBoxProductName.Focus();
        }

        private void FormProductDetails_Load(object sender, EventArgs e)
        {
            pdManager.LoadBrandsToComboBox(comboBoxSelectBrand);
            pdManager.LoadProductCategoriesToComboBox(comboBoxSelectCategory);
        }

        private bool IsValidFilled(string productId)
        {
            
            if (!FormValidator.Is10Character(productId))
            {
                MessageBox.Show("Vui lòng nhập đúng 10 ký tự cho mã sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            if (comboBoxSelectCategory.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn danh mục sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (comboBoxSelectBrand.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn thương hiệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (comboBoxProductStatus.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tình trạng sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(getImagePath()))
            {
                MessageBox.Show("Vui lòng chọn hình ảnh sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void buttonSaveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string pdId = textBoxProductId.Text.Trim();
                string pdName = textBoxProductName.Text.Trim();
                string pdDes = richTextBoxProductDescribe.Text.Trim();

                if (!IsValidFilled(pdId))
                {
                    return;
                }

                string pdBrands = comboBoxSelectBrand.SelectedValue.ToString();
                string pdCategories = comboBoxSelectCategory.SelectedValue.ToString();
                string pdStatus = comboBoxProductStatus.SelectedItem.ToString() == "Sản phẩm mới" ? "M" : "C";
                decimal price;



                if (!decimal.TryParse(textBoxProductPrice.Text.Trim(), out price))
                {
                    MessageBox.Show("Vui lòng nhập giá bán hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (isUpdateProduct)
                {
                    pdManager.UpdateProduct(pdId, pdName, pdBrands, pdCategories, price, pdDes, pdStatus, getImagePath());
                }
                else
                {
                    pdManager.InsertProduct(pdId, pdName, pdBrands, pdCategories, price, pdDes, pdStatus, getImagePath());
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
