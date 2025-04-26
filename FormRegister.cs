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

        private bool IsAllTextBoxesFilled(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return false;
                }
                else if (ctrl.HasChildren)
                {
                    if (!IsAllTextBoxesFilled(ctrl))
                        return false;
                }
            }
            return true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (!IsAllTextBoxesFilled(this)) 
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

                if (pass.Equals(confirmPass))
                {
                    RegisterService signUpService = new RegisterService();
                    signUpService.createAccount(fullName, email, phoneNumber, userName, pass);
                    MessageBox.Show("Tạo tài khoản thành công. Vui lòng đăng nhập lại để sử dụng ứng dụng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu xác nhận không trùng khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxGetPasswordConfirm.Focus();
                }
            }
        }
    }
}
