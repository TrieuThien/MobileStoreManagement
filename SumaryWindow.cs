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
        }

        private void SumaryWindow_Resize(object sender, EventArgs e)
        {
            // set width of flowLayout equal window
            flowLayoutPanelHeader.Width = this.ClientSize.Width;

            int widthOfValiableControls = pictureBoxLogo.Width + pictureBoxLogo.Margin.Horizontal + labelApplicationName.Width + labelApplicationName.Margin.Horizontal + flowLayoutPanelSystem.Margin.Horizontal;
            //MessageBox.Show(widthOfValiableControls.ToString());
            flowLayoutPanelSystem.Width = this.ClientSize.Width - widthOfValiableControls;

            flowLayoutPanelFunctions.Width = this.ClientSize.Width;
            groupBoxSalesResult.Width = this.ClientSize.Width;
            groupBoxRevenueChart.Width = this.ClientSize.Width; 
            groupBoxBestSellingProduct.Width = this.ClientSize.Width;   
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
    }
}
