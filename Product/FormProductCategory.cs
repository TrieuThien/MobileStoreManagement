using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStoreManagement.Product
{
    public partial class FormProductCategory : Form
    {
        ProductCategoryManager pdCategoryManagement = new ProductCategoryManager();
        public FormProductCategory()
        {
            InitializeComponent();
        }
        private bool IsValidFilled(string brandId, string brandName)
        {
            if (!FormValidator.IsAllTextBoxesFilled(this))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin các trường dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!FormValidator.Is10Character(brandId))
            {
                MessageBox.Show("Vui lòng nhập đúng 10 ký tự cho mã danh mục sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!FormValidator.IsMaxiMum20Character(brandName))
            {
                MessageBox.Show("Vui lòng chỉ nhập tối đa 20 ký tự cho tên danh mục sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string pdCategoryId = textBoxGetProductID.Text;
            string pdCategoryName = textBoxGetBrandName.Text;
            
            if (IsValidFilled(pdCategoryId, pdCategoryName)) 
            {
                pdCategoryManagement.AddNewPdCategory(pdCategoryId, pdCategoryName);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn cập nhật tên danh mục sản phẩm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string pdCategoryId = textBoxGetProductID.Text;
                string pdCategoryName = textBoxGetBrandName.Text;
                if (IsValidFilled(pdCategoryId, pdCategoryName))
                {
                    pdCategoryManagement.UpdateProductCategory(pdCategoryId, pdCategoryName);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa danh mục sản phẩm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string pdCategoryId = textBoxGetProductID.Text;
                string pdCategoryName = textBoxGetBrandName.Text;
                if (FormValidator.Is10Character(pdCategoryId))
                {
                    pdCategoryManagement.DeleteProductCategory(pdCategoryId);
                }
            }
        }
    }
}
