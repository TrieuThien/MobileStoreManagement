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
    public partial class UserControlProductManagement : UserControl
    {
        public UserControlProductManagement()
        {
            InitializeComponent();
        }

        private void UserControlProductManagement_Load(object sender, EventArgs e)
        {

            UserControlProductItems header = new UserControlProductItems(isSetup: true);
            header.Dock = DockStyle.Top;
            flowLayoutPanelProductList.Controls.Add(header);

            // Load data from database
            // Below is example data

            UserControlProductItems productItem = new UserControlProductItems("SP01", "Iphone 16 ProMax", 30000000, 28000000, 0, 10, 20);
            productItem.setPicture(ImageHandle.getImage("E:\\Learning\\University\\Practice\\Windows_form\\MobileStoreManagement\\Resources\\ip16pm.png"));
            flowLayoutPanelProductList.Controls.Add(productItem);
        }

        private void buttonAddNewProduct_Click(object sender, EventArgs e)
        {
            FormProductDetails formProductDetails = new FormProductDetails();
            formProductDetails.ShowDialog();
        }

        private void buttonAddNewManufacturer_Click(object sender, EventArgs e)
        {
            FormBrandCategory formBrandCategory = new FormBrandCategory();
            formBrandCategory.ShowDialog();
        }

        private void labelSearch_Click(object sender, EventArgs e)
        {
            textBoxGetKeyWordSearch.Focus();
        }
    }
}
