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
            UserControlImportExportProduct layout = new UserControlImportExportProduct(isImport: true);
            LoadUserControl(layout);

        }

        private void buttonExportProduct_Click(object sender, EventArgs e)
        {
            UserControlImportExportProduct layout = new UserControlImportExportProduct(isImport: false);
       
            LoadUserControl(layout);

            // Kiểm tra label để phân biệt chức năng
        }

        private void buttonDeliveryNote_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControlDeliveryInvoice());
        }

        private void buttonOrderSuplier_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControlOrderSupplier());
        }

        private void UserControlImportExportManagementcs_Load(object sender, EventArgs e)
        {
            LoadUserControl(new UserControlImportExportProduct(isImport: true));
        }

        private void buttonPaying_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng sẽ sớm được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonGetOldProduct_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng sẽ sớm được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
