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
    public partial class UserControlOrderSupplier : UserControl
    {
        public UserControlOrderSupplier()
        {
            InitializeComponent();
            labelCurrentDate.Text = DateTime.Now.ToString();
        }
        string placeholderTextIdOrNamePd = "Nhập mã, tên sản phẩm";
        string placeholderTextQuantityPd = "Số lượng";
        private void RemovePlaceholderIdOrNamePd(object sender, EventArgs e)
        {
            if (textBoxGetIdOrNamePd.Text == placeholderTextIdOrNamePd)
            {
                textBoxGetIdOrNamePd.Text = "";
                textBoxGetIdOrNamePd.ForeColor = Color.Black;
            }
        }

        private void RemovePlaceholderQuantityPd(object sender, EventArgs e)
        {

            if (textBoxGetQuantity.Text == placeholderTextQuantityPd)
            {
                textBoxGetQuantity.Text = "";
                textBoxGetQuantity.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholderIdOrNamePd(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxGetIdOrNamePd.Text))
            {
                textBoxGetIdOrNamePd.Text = placeholderTextIdOrNamePd;
                textBoxGetIdOrNamePd.ForeColor = Color.Gray;
            }
        }

        private void SetPlaceholderQuantityPd(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxGetQuantity.Text))
            {
                textBoxGetQuantity.Text = placeholderTextQuantityPd;
                textBoxGetQuantity.ForeColor = Color.Gray;
            }
        }
        private void UserControlOrderSupplier_Load(object sender, EventArgs e)
        {
            textBoxGetIdOrNamePd.Text = placeholderTextIdOrNamePd;
            textBoxGetIdOrNamePd.ForeColor = Color.Gray;

            textBoxGetQuantity.Text = placeholderTextQuantityPd;
            textBoxGetQuantity.ForeColor = Color.Gray;

            // Gắn sự kiện
            textBoxGetIdOrNamePd.Enter += RemovePlaceholderIdOrNamePd;
            textBoxGetIdOrNamePd.Leave += SetPlaceholderIdOrNamePd;

            textBoxGetQuantity.Enter += RemovePlaceholderQuantityPd;
            textBoxGetQuantity.Leave += SetPlaceholderQuantityPd;
            flowLayoutPanelListOrderProduct.Controls.Add(new UserControlProductItemsHeader());

            // Example: Load data
            for (int i = 0; i<5 ; i++)
            {
                flowLayoutPanelListOrderProduct.Controls.Add(new UserControlProductItems());
            }
        }
    }
}
