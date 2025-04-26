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
    public partial class FormBrandCategory : Form
    {
        BrandManager brandManagement = new BrandManager();
        string placeholderText = "Mã thương hiệu (bắt buộc 10 ký tự)";
        public FormBrandCategory()
        {
            InitializeComponent();
        }

        private void labelBrandId_Click(object sender, EventArgs e)
        {
            textBoxGetBrandId.Focus();
        }

        private void labelBrandName_Click(object sender, EventArgs e)
        {
            textBoxGetBrandName.Focus();
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
                MessageBox.Show("Vui lòng nhập đúng 10 ký tự cho mã thương hiệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!FormValidator.IsMaxiMum20Character(brandName))
            {
                MessageBox.Show("Vui lòng chỉ nhập tối đa 20 ký tự cho tên thương hiệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void buttonAddBrand_Click(object sender, EventArgs e)
        {
            string brandId = textBoxGetBrandId.Text;
            string brandName = textBoxGetBrandName.Text;

            
            if (IsValidFilled(brandId, brandName))
            {
                brandManagement.AddNewBrand(brandId, brandName);
            }
            
        }

        private void buttonEditBrand_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn cập nhật tên thương hiệu sản phẩm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string brandId = textBoxGetBrandId.Text;
                string brandName = textBoxGetBrandName.Text;

                if (IsValidFilled(brandId, brandName))
                {
                    brandManagement.UpdateBrand(brandId, brandName);
                }
            }
        }

        private void buttonDeleteBrand_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa thương hiệu sản phẩm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string brandId = textBoxGetBrandId.Text;
                if (FormValidator.Is10Character(brandId))
                {
                    brandManagement.DeleteBrand(brandId);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng 10 ký tự cho mã thương hiệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void FormBrandCategory_Load(object sender, EventArgs e)
        {
            textBoxGetBrandId.Text = placeholderText;
            textBoxGetBrandId.ForeColor = Color.Gray;
        }

        private void textBoxGetBrandId_Enter(object sender, EventArgs e)
        {
            if (textBoxGetBrandId.Text == placeholderText)
            {
                textBoxGetBrandId.Text = "";
                textBoxGetBrandId.ForeColor = Color.Black;
            }
        }

        private void textBoxGetBrandId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxGetBrandId.Text))
            {
                textBoxGetBrandId.Text = placeholderText;
                textBoxGetBrandId.ForeColor = Color.Gray;
            }
        }
    }
}
