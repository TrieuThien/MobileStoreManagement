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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MobileStoreManagement.ImportExport
{
    public partial class UserControlImportExportProduct : UserControl
    {
        string placeholderTextIdOrNamePd = "Nhập mã, tên sản phẩm";
        string placeholderTextQuantityPd = "Số lượng";
        decimal totalReceiptImportPrice = 0;
        bool isImport;
        ConnectDatabase connectDb = new ConnectDatabase();
        private Dictionary<string, ProductInfo> searchKeywordToProductMap = new Dictionary<string, ProductInfo>();


        ImExManager imExManager = new ImExManager();
        public UserControlImportExportProduct(bool isImport)
        {
            InitializeComponent();
            labelRole.Text = Session.username;
            labelCurrentDate.Text = DateTime.Now.ToString();
            textBoxTotalPrice.Text = totalReceiptImportPrice.ToString();
            this.isImport = isImport;
            if (this.isImport)
                SetLabelFunctionName("Nhập hàng");
            else
            {
                SetLabelFunctionName("Xuất hàng");
                flowLayoutPanelSupplier.Hide();
                flowLayoutPanelDiscout.Hide();
            }
                
        }

        private void RemovePlaceholderIdOrNamePd(object sender, EventArgs e)
        {
            if (textBoxGetNamePd.Text == placeholderTextIdOrNamePd)
            {
                textBoxGetNamePd.Text = "";
                textBoxGetNamePd.ForeColor = Color.Black;
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
            if (string.IsNullOrWhiteSpace(textBoxGetNamePd.Text))
            {
                textBoxGetNamePd.Text = placeholderTextIdOrNamePd;
                textBoxGetNamePd.ForeColor = Color.Gray;
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

            textBoxGetNamePd.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxGetNamePd.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxGetNamePd.AutoCompleteCustomSource = autoComplete;
        }
        // Xử lý sự kiện
        private void UserControlImportProduct_Load(object sender, EventArgs e)
        {
            // Chuẩn bị dữ liệu để gợi ý sản phẩm
            SetupProductAutoComplete();

            // Gán placeholder ban đầu
            textBoxGetNamePd.Text = placeholderTextIdOrNamePd;
            textBoxGetNamePd.ForeColor = Color.Gray;

            textBoxGetQuantity.Text = placeholderTextQuantityPd;
            textBoxGetQuantity.ForeColor = Color.Gray;

            // Gắn sự kiện
            textBoxGetNamePd.Enter += RemovePlaceholderIdOrNamePd;
            textBoxGetNamePd.Leave += SetPlaceholderIdOrNamePd;

            textBoxGetQuantity.Enter += RemovePlaceholderQuantityPd;
            textBoxGetQuantity.Leave += SetPlaceholderQuantityPd;

            imExManager.LoadSupplierToComboBox(comboBoxSupplier);
     
            flowLayoutPanelListProduct.Controls.Add(new UserControlImportHeader());


        }

        private void UpdateTotalReceipImportPrice()
        {
            totalReceiptImportPrice = 0; 

            // Duyệt qua các UserControl trong flowLayoutPanelListProduct nhưng bỏ qua phần tử đầu tiên
            for (int i = 1; i < flowLayoutPanelListProduct.Controls.Count; i++)
            {
                Control control = flowLayoutPanelListProduct.Controls[i];

                // Kiểm tra kiểu của control trước khi ép kiểu
                if (control is UserControlImExItems item)
                {
                    totalReceiptImportPrice += item.totalPriceItem;
                }
            }

            // Cập nhật tổng tiền vào textbox
            textBoxTotalPrice.Text = totalReceiptImportPrice.ToString();
        }

        private void buttonAddPd_Click(object sender, EventArgs e)
        {
            string userInput = textBoxGetNamePd.Text.Trim().ToLower();
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
                UserControlImExItems itemProduct = new UserControlImExItems(pdId, pdName, quantity);
                itemProduct.textBoxCapitalPriceLeaveEvent += UserControlImExItems_TextBoxLeaveEvent;
                itemProduct.removeItemEvent += UserControlImExItems_Remove;
                flowLayoutPanelListProduct.Controls.Add(itemProduct);
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm phù hợp!");
            }
        }
        private void UserControlImExItems_Remove(object sender, EventArgs e)
        {
            UpdateTotalReceipImportPrice();
        }
        private void UserControlImExItems_TextBoxLeaveEvent(object sender, EventArgs e)
        {
            UpdateTotalReceipImportPrice();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (this.isImport)
            {
                if (comboBoxSupplier.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string supplierId = comboBoxSupplier.SelectedValue.ToString();
                decimal receiptImportTotalPrice = decimal.Parse(textBoxTotalPrice.Text);
                string receiptNote = textBoxNote.Text.Trim();
                decimal discount = 0;

                if (!decimal.TryParse(textBoxDiscount.Text, out discount))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            
                List<ReceiptImportDetails> listReceipImport = new List<ReceiptImportDetails>();
                for (int i = 1; i < flowLayoutPanelListProduct.Controls.Count; i++)
                {
                    Control control = flowLayoutPanelListProduct.Controls[i];
                    
                    // Kiểm tra kiểu của control trước khi ép kiểu
                    if (control is UserControlImExItems item)
                    {
                        if (item.productItemId != null && item.productPrice >= 0 && item.productQuantity >= 0)
                        {
                            listReceipImport.Add(new ReceiptImportDetails
                            {
                                ProductId = item.productItemId.ToString(),
                                ProductPrice = item.productPrice,
                                ProductQuantity = item.productQuantity,
                            });
                        }
                    }
                }
                try
                {
                    string ReceiptImportID = CodeGenerator.GenerateReceiptImportId();
                    imExManager.InsertReceiptImport(ReceiptImportID, supplierId, DateTime.Now, receiptImportTotalPrice, discount, receiptNote, listReceipImport);
                    MessageBox.Show("Lưu phiếu nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            else if (this.isImport == false)
            {
                decimal receiptExportTotalPrice = decimal.Parse(textBoxTotalPrice.Text);
                string receiptNote = textBoxNote.Text.Trim();
                
                List<ReceiptExportDetails> listReceipExportProduct = new List<ReceiptExportDetails>();
                for (int i = 1; i < flowLayoutPanelListProduct.Controls.Count; i++)
                {
                    Control control = flowLayoutPanelListProduct.Controls[i];

                    // Kiểm tra kiểu của control trước khi ép kiểu
                    if (control is UserControlImExItems item)
                    {
                        if (item.productItemId != null && item.productPrice >= 0 && item.productQuantity >= 0)
                        {
                            listReceipExportProduct.Add(new ReceiptExportDetails
                            {
                                ProductId = item.productItemId.ToString(),
                                ProductPrice = item.productPrice,
                                ProductQuantity = item.productQuantity,
                            });
                        }
                    }
                }
                try
                {
                    string receiptExportID = CodeGenerator.GenerateReceiptExportId();
                    
                    imExManager.InsertReceiptExport(receiptExportID, DateTime.Now, receiptNote, receiptExportTotalPrice, listReceipExportProduct);
                    MessageBox.Show("Lưu phiếu nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            for (int i = flowLayoutPanelListProduct.Controls.Count - 1; i >= 1; i--)
            {
                flowLayoutPanelListProduct.Controls.RemoveAt(i);
            }
        }
    }
}
