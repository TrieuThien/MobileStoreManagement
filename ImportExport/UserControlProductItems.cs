using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStoreManagement.ImportExport
{
    internal partial class UserControlProductItems : UserControl
    {
        internal string ProductItemId;
        internal string ProductItemName;
        internal int ProductItemQuantity;
        
        public UserControlProductItems(string pdId, string pdName, int pbQuantity)
        {
            InitializeComponent();
            ProductItemId = pdId;
            ProductItemName = pdName;
            ProductItemQuantity = pbQuantity;

            labelProductId.Text = ProductItemId;
            labelProductName.Text = ProductItemName;
            textBoxGetQuantity.Text = ProductItemQuantity.ToString();
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this); // Xóa chính nó khỏi danh sách control của cha
            this.Dispose(); // Giải phóng tài nguyên nếu cần
        }
    }
}
