using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStoreManagement.AccountDasboard
{
    public partial class UserControlPersionalInfor : UserControl
    {
        
        public UserControlPersionalInfor()
        {
            InitializeComponent();
            setInfo();
        }

        private void setInfo()
        {
            AccountDashboard accountInfo = new AccountDashboard();
            textBoxFullName.Text = accountInfo.userFullName;
            textBoxUserName.Text = accountInfo.username;
            textBoxStoreName.Text = accountInfo.branch;
            textBoxEmail.Text = accountInfo.email;
            textBoxPhoneNumber.Text = accountInfo.phoneNumber;
        }

        private void buttonCacelEdit_Click(object sender, EventArgs e)
        {
            setInfo();
        }

        private void buttonSavePersionalInfor_Click(object sender, EventArgs e)
        {

            string userFullName = textBoxFullName.Text;
            string userEmail = textBoxEmail.Text;
            string userPhoneNumber = textBoxPhoneNumber.Text;
            string storeName = textBoxStoreName.Text;
            if (!FormValidator.IsAllTextBoxesFilled(this))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin các trường.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!FormValidator.IsValidEmail(userEmail))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEmail.Focus();
            }
            else if (!FormValidator.IsValidPhoneNumber(userPhoneNumber))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPhoneNumber.Focus();
            }
            else
            {
                AccountDashboard accountInfo = new AccountDashboard();
                accountInfo.UpdatePersionalInfo(userFullName, storeName, userEmail, userPhoneNumber);
            }
        }
    }
}
