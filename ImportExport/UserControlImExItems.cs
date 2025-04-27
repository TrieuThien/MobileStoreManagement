using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStoreManagement.ImportExport
{
    internal partial class UserControlImExItems : UserControl
    {
        internal string productItemId;
        internal string productItemName;
        internal int productQuantity;
        internal decimal productPrice;
        internal decimal totalPriceItem = 0;

        public event EventHandler textBoxCapitalPriceLeaveEvent;
        public event EventHandler removeItemEvent;
        public UserControlImExItems(string productId, string productName, int quantity)
        {
            InitializeComponent();
            this.productItemId = productId;
            this.productItemName = productName;
            this.productQuantity = quantity;

            labelProductId.Text = productId;
            labelProductName.Text = productName;
            textBoxQuantity.Text = quantity.ToString();
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this); // Xóa chính nó khỏi danh sách control của cha
            this.Dispose(); // Giải phóng tài nguyên nếu cần
            removeItemEvent?.Invoke(this, e);
        }

        private void textBoxCapitalPrice_Leave(object sender, EventArgs e)
        {
            int quantity;
            decimal price;

            int.TryParse(textBoxQuantity.Text, out quantity);
            if (!decimal.TryParse(textBoxPrice.Text, out price))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPrice.Focus();
                return;
            }
            this.productPrice = price;
            decimal totalPrice = price * quantity;
            this.totalPriceItem = totalPrice;
            textBoxTotalPrice.Text =  string.Format("{0:#,##0} VND", totalPrice);

            textBoxCapitalPriceLeaveEvent?.Invoke(this, e);
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            // Bỏ đăng ký sự kiện tạm thời để không bị lặp khi format
            textBoxPrice.TextChanged -= textBoxPrice_TextChanged;

            string text = textBoxPrice.Text.Replace(",", "").Trim(); // Xóa dấu phẩy cũ

            if (decimal.TryParse(text, out decimal number))
            {
                textBoxPrice.Text = string.Format("{0:N0}", number); // Format có dấu phẩy
                textBoxPrice.SelectionStart = textBoxPrice.Text.Length; // Đặt con trỏ cuối
            }

            // Đăng ký lại sự kiện
            textBoxPrice.TextChanged += textBoxPrice_TextChanged;
        }
    }
}
