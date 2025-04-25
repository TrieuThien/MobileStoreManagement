using MobileStoreManagement.AccountDasboard;
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
    public partial class FormAccountDashboard : Form
    {
        public FormAccountDashboard()
        {
            InitializeComponent();
        }

        private void LoadUserControl(UserControl uc)
        {
            panelAcountDashboard.Controls.Clear();          // Xóa control cũ
            uc.Dock = DockStyle.Fill;            // Làm đầy panel

            uc.Width = this.ClientSize.Width;
            panelAcountDashboard.Controls.Add(uc);          // Thêm control mới
        }

        private void buttonPersonalInfor_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControlPersionalInfor());
        }

        private void buttonChangeLangua_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControlChangeLanguage());
        }

        private void FormAccountDashboard_Load(object sender, EventArgs e)
        {
            LoadUserControl(new UserControlPersionalInfor());

        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoginService.LogOut();
              
                if (this.Owner != null)
                {
                    this.Owner.Close(); 
                } 
                this.Close();
            }
        }
    }
}
