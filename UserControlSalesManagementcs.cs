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
    public partial class UserControlSalesManagementcs : UserControl
    {
        public UserControlSalesManagementcs()
        {
            InitializeComponent();
        }
        private void LoadUserControl(UserControl uc)
        {
            UserControlSalesManagementOrder.Controls.Clear();          // Xóa control cũ
            uc.Dock = DockStyle.Top;            // Làm đầy panel

            uc.Width = this.ClientSize.Width;
            UserControlSalesManagementOrder.Controls.Add(uc);          // Thêm control mới
        }

        private void buttonToSalesManagementOrder_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControlSalesManagementOrder());
        }
    }
}
