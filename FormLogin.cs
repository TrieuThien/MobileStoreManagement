using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStoreManagement
{
    public partial class FormLogin : Form
    {
        internal string userName { get; private set; }
        internal string password { get; private set; }
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string userName = textBoxGetUserName.Text;
            string password = textBoxGetPassword.Text;

            bool isValidUserName = !string.IsNullOrEmpty(userName);
            bool isValidPassword = !string.IsNullOrEmpty(password);

            if (isValidUserName && isValidPassword)
            {
                if (LoginService.Authenticate(userName, password))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else if (!isValidUserName)
            {
                MessageBox.Show("Vui lòng nhập tên người dùng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!isValidPassword)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.ShowDialog();
        }
    }
}
