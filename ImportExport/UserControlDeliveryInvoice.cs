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
    public partial class UserControlDeliveryInvoice : UserControl
    {
        ConnectDatabase connectDb = new ConnectDatabase();
        ImExManager imExManager = new ImExManager();
        private Dictionary<string, ProductInfo> searchKeywordToProductMap = new Dictionary<string, ProductInfo>();

        public UserControlDeliveryInvoice()
        {
            InitializeComponent();
            labelCurrentDate.Text = DateTime.Now.ToString();
            labelRole.Text = Session.username;

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

        private void UserControlDeliveryInvoice_Load(object sender, EventArgs e)
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
            
            SetupProductAutoComplete();
            imExManager.LoadSupplierToComboBox(comboBoxSupplier);
            imExManager.LoadReceiptOrder(comboBoxReceiptOrder);

            flowLayoutPanelListDeliveryInvoice.Controls.Add(new UserControlProductItemsHeader());

            // Example load data
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
                flowLayoutPanelListDeliveryInvoice.Controls.Add(itemProduct);
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm phù hợp!");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            for (int i = flowLayoutPanelListDeliveryInvoice.Controls.Count - 1; i >= 1; i--)
            {
                flowLayoutPanelListDeliveryInvoice.Controls.RemoveAt(i);
            }
        }
    }
}
