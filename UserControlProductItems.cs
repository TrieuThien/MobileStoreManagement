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
        string productId;
        string productName;
        decimal productPrice;
        decimal productCapitalPrice;
        int productQuantityOrderFromSupplier;
        int productQuantityOrderFromCustomer;
        int productQuantityRemaining;

        public UserControlProductItems(bool isSetup)
        {
            InitializeComponent();
            if (isSetup)
            {
                hideButtonUpdate();
                hideButtonDelete();   
            }
        }
        public UserControlProductItems(string productId, string productName, decimal productPrice, decimal productCapitalPrice, int productQuantityOrderFromSupplier, int productQuantityOrderFromCustomer, int productQuantityRemaining)
        {
            InitializeComponent();
            this.productId = productId;
            this.productName = productName;
            this.productPrice = productPrice;
            this.productCapitalPrice = productCapitalPrice;
            this.productQuantityOrderFromSupplier = productQuantityOrderFromSupplier;
            this.productQuantityOrderFromCustomer = productQuantityOrderFromCustomer;
            this.productQuantityRemaining = productQuantityRemaining;

            this.setProductName();
            this.setProductSellingPrice();
            this.setProductCapitalPrice();
            this.setQuantityOrderFromSupplier();
            this.setQuantityOrderFromCustomer();
            this.setQuantityRemaining();
        }

        private string getProductId()
        {
            return this.productId;
        }

        private string getProductName()
        {
            return this.productName;
        }

        private decimal getProductPrice()
        {
            return this.productPrice;
        }

        private decimal getProductCapitalPrice()
        {
            return this.productCapitalPrice;
        }

        private int getProductQuantityOrderFromSupplier()
        {
            return this.productQuantityOrderFromSupplier;
        }

        private int getProductQuantityOrderFromCustomer()
        {
            return this.productQuantityOrderFromCustomer;
        }

        private int getProductQuantityRemaining()
        {
            return this.productQuantityRemaining;
        }


        internal void setPicture(Image image)
        {
            pictureBoxProductImage.Image = image;
        }

        internal void setProductName()
        {
            labelProductName.Text = this.productName;
        }

        internal void setProductSellingPrice()
        {
            string res = string.Format("{0:#,##0} VND", this.productPrice);
            labelProductSellingPrice.Text = res;
        }

        internal void setProductCapitalPrice() 
        {
            string res = string.Format("{0:#,##0} VND", this.productCapitalPrice);
            labelProductCapitalPrice.Text = res;
         }

        internal void setQuantityOrderFromSupplier()
        {
            labelOrderFromSuplier.Text = this.productQuantityOrderFromSupplier.ToString();
        }

        internal void setQuantityOrderFromCustomer()
        {
            labelOrderFromCustomer.Text = this.productQuantityOrderFromCustomer.ToString();
        }

        internal void setQuantityRemaining()
        {
            labelRemaining.Text = this.productQuantityRemaining.ToString();
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
            FormProductDetails formProductDetails = new FormProductDetails(productId, productName, productPrice);
            
            formProductDetails.ShowDialog();
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            string message = "Mã sản phẩm: " + getProductId() + "\nTên sản phẩm: " + getProductName();
            MessageBox.Show(message, "Xác nhận xóa sản phẩm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }
    }
}
