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
    public partial class SumaryWindow : Form
    {
        public SumaryWindow()
        {
            InitializeComponent();
            labelShowUserName.Text = Session.username;
        }

        private void SumaryWindow_Resize(object sender, EventArgs e)
        {
            // set width of flowLayout equal window
            flowLayoutPanelHeader.Width = this.ClientSize.Width;

            int widthOfValiableControls = pictureBoxLogo.Width + pictureBoxLogo.Margin.Horizontal + labelApplicationName.Width + labelApplicationName.Margin.Horizontal + flowLayoutPanelSystem.Margin.Horizontal;
            //MessageBox.Show(widthOfValiableControls.ToString());
            flowLayoutPanelSystem.Width = this.ClientSize.Width - widthOfValiableControls;

            flowLayoutPanelFunctions.Width = this.ClientSize.Width;

            if (this.ClientSize.Width < 1320)
            {
                flowLayoutPanelFunctions.Height = 136;
                panelMain.Location = new Point(panelMain.Location.X, 204);
            }
            else
            {
                flowLayoutPanelFunctions.Height = 68;
            }
        }

  

        private void labelForSuport_Click(object sender, EventArgs e)
        {
            buttonToSuportWindow.PerformClick();
        }

        private void labelForSetting_Click(object sender, EventArgs e)
        {
            buttonToSettingWindow.PerformClick();
        }

        private void labelShowUserName_Click(object sender, EventArgs e)
        {
            buttonToAccountWindow.PerformClick();
        }

        private void LoadUserControl(UserControl uc)
        {
            panelMain.Controls.Clear();          // Xóa control cũ
            uc.Dock = DockStyle.Top;            // Làm đầy panel
            
            uc.Width = this.ClientSize.Width;
            panelMain.Controls.Add(uc);          // Thêm control mới
        }
        private void buttonToSumarylWindow_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControlSumary());
        }

        private void SumaryWindow_Load(object sender, EventArgs e)
        {
            LoadUserControl(new UserControlSumary());
        }

        private void buttonToCustomerManagementWindow_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControlCustomerManagement());
        }

        private void buttonToBillManagementWindow_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControlInvoiceManagement());
        }

        private void buttonToSellManagementWindow_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControlSalesManagementcs());
        }

        private void buttonToProductManagementWindow_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControlProductManagement());
        }

        private void buttonToImportExportManagementWindow_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControlImportExportManagementcs());
        }

        private void buttonToSupplierManagementWindow_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControlSupplierManagement());
        }

        private void buttonToPromotionManagementWindow_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControlPromoutionManagement());
        }

        private void buttonToReportWindow_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControlReport());
        }

        private void buttonToAccountWindow_Click(object sender, EventArgs e)
        {
            FormAccountDashboard formAccountDashboard = new FormAccountDashboard();
            formAccountDashboard.Owner = this;
            formAccountDashboard.ShowDialog();
        }
    }
}
