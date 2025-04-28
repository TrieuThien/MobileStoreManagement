using MobileStoreManagement.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            labelRole.Text = Session.username;
        }
        string placeholderTextIdOrNamePd = "Nhập mã, tên sản phẩm";
        string placeholderTextQuantityPd = "Số lượng";

        ImExManager imExManager = new ImExManager();
        ConnectDatabase connectDb = new ConnectDatabase();
        private Dictionary<string, ProductInfo> searchKeywordToProductMap = new Dictionary<string, ProductInfo>();

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
        private void SetupProductAutoComplete()
        {
            List<string> searchKeywords = new List<string>();
            searchKeywordToProductMap.Clear();

            try
            {
                using (SqlConnection connection = connectDb.GetConnection())
                {
                    if (connection.State != ConnectionState.Open)
                        connection.Open();

                    string query = "SELECT Ma_san_pham, Ten_san_pham FROM SAN_PHAM WHERE Ma_nguoi_ban = @maNguoiBan";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@maNguoiBan", Session.userId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string maSanPham = reader.GetString(0).Trim();
                                string tenSanPham = reader.GetString(1).Trim();

                                // Gợi ý theo mã và tên
                                searchKeywords.Add(maSanPham);
                                searchKeywords.Add(tenSanPham);

                                var productInfo = new ProductInfo
                                {
                                    ProductId = maSanPham,
                                    ProductName = tenSanPham
                                };

                                // Ánh xạ từ khoá -> ProductInfo (key chuyển về lowercase)
                                if (!searchKeywordToProductMap.ContainsKey(maSanPham.ToLower()))
                                    searchKeywordToProductMap.Add(maSanPham.ToLower(), productInfo);
                                if (!searchKeywordToProductMap.ContainsKey(tenSanPham.ToLower()))
                                    searchKeywordToProductMap.Add(tenSanPham.ToLower(), productInfo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy sản phẩm: " + ex.Message);
            }

            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(searchKeywords.ToArray());

            textBoxGetIdOrNamePd.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxGetIdOrNamePd.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxGetIdOrNamePd.AutoCompleteCustomSource = autoComplete;
        }

        // Xử lý sự kiện
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

            imExManager.LoadSupplierToComboBox(comboBoxGetSupplierId);
            SetupProductAutoComplete();
            // Example: Load data

        }

        private void buttonDownPaymentInvoice_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng sẽ sớm được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
   
        private void buttonAddPd_Click(object sender, EventArgs e)
        {
            string userInput = textBoxGetIdOrNamePd.Text.Trim().ToLower();
            string productQuantityText = textBoxGetQuantity.Text.Trim();

            int quantity;

            if (!int.TryParse(productQuantityText, out quantity))
            {
                MessageBox.Show("Vui lòng nhập sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (searchKeywordToProductMap.ContainsKey(userInput))
            {
                var productInfo = searchKeywordToProductMap[userInput];

                string pdId = productInfo.ProductId;
                string pdName = productInfo.ProductName;

                // Add Selected Products
                UserControlProductItems itemProduct = new UserControlProductItems(pdId, pdName, quantity);
                flowLayoutPanelListOrderProduct.Controls.Add(itemProduct);
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm phù hợp!");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            List<OrderProductDetails> listReceipImport = new List<OrderProductDetails>();
            for (int i = 1; i < flowLayoutPanelListOrderProduct.Controls.Count; i++)
            {
                Control control = flowLayoutPanelListOrderProduct.Controls[i];

                // Kiểm tra kiểu của control trước khi ép kiểu
                if (control is UserControlProductItems item)
                {
                    if (item.ProductItemId != null && item.ProductItemName != null && item.ProductItemQuantity >= 0)
                    {
                        listReceipImport.Add(new OrderProductDetails
                        {
                            ProductId = item.ProductItemId.ToString(),
                            ProductName = item.ProductName,
                            ProductQuantity = item.ProductItemQuantity,
                        });
                    }
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            for (int i = flowLayoutPanelListOrderProduct.Controls.Count - 1; i >= 1; i--)
            {
                flowLayoutPanelListOrderProduct.Controls.RemoveAt(i);
            }
        }
    }
}
