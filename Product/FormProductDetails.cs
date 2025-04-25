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
    public partial class FormProductDetails : Form
    {
        public FormProductDetails()
        {
            InitializeComponent();
        }

        public FormProductDetails(string productId, string productName, decimal productPrice)
        {
            InitializeComponent();
            textBoxProductName.Text = productName;
            textBoxProductId.Text = productId;
            textBoxProductPrice.Text = productPrice.ToString();
        }

        private void buttonChangePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn một tập tin";
            openFileDialog.Filter = "Tất cả các tệp (*.*)|*.*|Tệp văn bản (*.txt)|*.txt|Tệp hình ảnh (*.jpg;*.png)|*.jpg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                MessageBox.Show("Đã chọn file: " + filePath);
                // Bạn có thể sử dụng filePath ở đây, ví dụ: hiển thị lên textbox, xử lý file...
            }
        }

        private void labelProductName_Click(object sender, EventArgs e)
        {
            textBoxProductName.Focus();
        }
    }
}
