using MobileStoreManagement.ImportExport;
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
    public partial class UserControlImportExportManagementcs : UserControl
    {
        public UserControlImportExportManagementcs()
        {
            InitializeComponent();
        }

        private void LoadUserControl(UserControl uc)
        {
            panelFunctions.Controls.Clear();
            uc.Width = this.ClientSize.Width;
            uc.Dock = DockStyle.Fill;
            panelFunctions.Controls.Add(uc);
        }

        private void buttonImportProduct_Click(object sender, EventArgs e)
        {
            UserControlImportExportProduct layout = new UserControlImportExportProduct();
            layout.SetLabelFunctionName("Nhập hàng");
            LoadUserControl(new UserControlImportExportProduct());

        }

        private void buttonExportProduct_Click(object sender, EventArgs e)
        {
            UserControlImportExportProduct layout = new UserControlImportExportProduct();
            layout.SetLabelFunctionName("Xuất kho");
            LoadUserControl(layout);
        }
    }
}
