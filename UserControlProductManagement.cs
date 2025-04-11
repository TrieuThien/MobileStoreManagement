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
            
            ProductItemsPrimary.hideButtonUpdate();
            ProductItemsPrimary.hideButtonDelete();


            // Load data from database
            // Below is example data
            userControlProductItems2.Dock = DockStyle.Top;
            userControlProductItems2.setPicture(ImageHandle.getImage("E:\\Learning\\University\\Practice\\Windows_form\\MobileStoreManagement\\Resources\\ip16pm.png"));
            userControlProductItems2.setProductName("Iphone 16 ProMax");
            userControlProductItems2.setProductSellingPrice(30000000);
            userControlProductItems2.setProductCapitalPrice(28000000);
            userControlProductItems2.setQuantityOrderFromSupplier(0);
            userControlProductItems2.setQuantityOrderFromCustomer(10);
            userControlProductItems2.setQuantityRemaining(20);
        }

    }
}
