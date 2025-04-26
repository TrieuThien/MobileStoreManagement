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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (!FormValidator.IsAllTextBoxesFilled(this)) 
            { 
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin các trường.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string fullName = textBoxGetFullName.Text;
                string email = textBoxGetEmail.Text;
                string phoneNumber = textBoxGetNumberPhone.Text;
                string userName = textBoxGetUserName.Text;
                string pass = textBoxGetPassword.Text;
                string confirmPass = textBoxGetPasswordConfirm.Text;

                if (!FormValidator.IsValidPhoneNumber(phoneNumber))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxGetNumberPhone.Focus();
                }
                else if (!FormValidator.IsValidEmail(email)) {
                    MessageBox.Show("Vui lòng nhập đúng định dạng email.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxGetEmail.Focus();
                }
                else if (!pass.Equals(confirmPass))
                {
                    MessageBox.Show("Mật khẩu xác nhận không trùng khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxGetPasswordConfirm.Focus();
                }
                else
                {
                    // Nếu tạo tài khoản thành công thì đóng form
                    if (RegisterService.IsCreateAccountSuccess(fullName, email, phoneNumber, userName, pass))
                    {
                        MessageBox.Show("Tạo tài khoản thành công. Vui lòng đăng nhập lại ứng dụng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                        this.Close();
                    }
                }
            }
        }
    }
}
