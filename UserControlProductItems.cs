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
    public partial class UserControlProductItems : UserControl
    {
        public UserControlProductItems()
        {
            InitializeComponent();
        }

        internal void setPicture(Image image)
        {
            pictureBoxProductImage.Image = image;
        }

        internal void setProductName(string name)
        {
            labelProductName.Text = name;
        }

        internal void setProductSellingPrice(decimal price)
        {
            string res = string.Format("{0:#,##0} VND", price);
            labelProductSellingPrice.Text = res;
        }

        internal void setProductCapitalPrice(decimal price) 
        {
            string res = string.Format("{0:#,##0} VND", price);
            labelProductCapitalPrice.Text = res;
         }

        internal void setQuantityOrderFromSupplier(int quantity)
        {
            labelOrderFromSuplier.Text = quantity.ToString();
        }

        internal void setQuantityOrderFromCustomer(int quantity)
        {
            labelOrderFromCustomer.Text = quantity.ToString();
        }

        internal void setQuantityRemaining(int quantity)
        {
            labelRemaining.Text = quantity.ToString();
        }

        internal void hideButtonUpdate()
        {
            buttonUpdateProduct.Hide();
        }

        internal void hideButtonDelete()
        {
            buttonDeleteProduct.Hide();
        }

        private void buttonUpdateProduct_Click(object sender, EventArgs e)
        {
            FormProductDetails formPproductDetails = new FormProductDetails();
            formPproductDetails.ShowDialog();
        }
    }
}
