using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MobileStoreManagement.ImportExport
{
    public partial class UserControlImportExportProduct : UserControl
    {

        
        public UserControlImportExportProduct()
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

        internal void SetLabelFunctionName(string name)
        {
            labelFunctionName.Text = name;
        }

        private void UserControlImportProduct_Load(object sender, EventArgs e)
        {
            // Gán placeholder ban đầu
            
            textBoxGetIdOrNamePd.Text = placeholderTextIdOrNamePd;
            textBoxGetIdOrNamePd.ForeColor = Color.Gray;

            textBoxGetQuantity.Text = placeholderTextQuantityPd;
            textBoxGetQuantity.ForeColor = Color.Gray;

            // Gắn sự kiện
            textBoxGetIdOrNamePd.Enter += RemovePlaceholderIdOrNamePd;
            textBoxGetIdOrNamePd.Leave += SetPlaceholderIdOrNamePd;

            textBoxGetQuantity.Enter += RemovePlaceholderQuantityPd;
            textBoxGetQuantity.Leave += SetPlaceholderQuantityPd;

            flowLayoutPanelListProduct.Controls.Add(new UserControlImportExportHeader()); 
            for (int i = 0; i < 10; i++)
            {
                UserControlImoprtExportItems item = new UserControlImoprtExportItems();
                flowLayoutPanelListProduct.Controls.Add(item);
            }
        }
    }
}
