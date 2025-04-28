using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobileStoreManagement.Customers;
using System.Data.SqlClient;
using MobileStoreManagement.Supplier;

namespace MobileStoreManagement
{
    
    public partial class UserControlCustomerManagement : UserControl
    {
        CustomersManager customersManager = new CustomersManager();
        public UserControlCustomerManagement()
        {
            InitializeComponent();
        }
        

        internal void ClearAllTextBoxes(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (control.HasChildren)
                {
                    // Nếu trong control còn chứa các control con (ví dụ Panel, GroupBox...), thì duyệt tiếp
                    ClearAllTextBoxes(control);
                }
            }
        }

        internal void LoadDataFromGridViewToTextBoxes(DataGridView dgv, Dictionary<string, TextBox> mapping)
        {
            if (dgv.CurrentRow != null)
            {
                foreach (var entry in mapping)
                {
                    string columnName = entry.Key;     // Tên cột trong DataGridView
                    TextBox textBox = entry.Value;     // TextBox tương ứng

                    // Kiểm tra giá trị của ô trong cột
                    if (dgv.CurrentRow.Cells[columnName].Value != null)
                    {
                        var cellValue = dgv.CurrentRow.Cells[columnName].Value;

                        // Xử lý kiểu dữ liệu
                        if (cellValue is DateTime)
                        {
                            // Nếu là DateTime, chuyển đổi thành chuỗi với định dạng mong muốn
                            textBox.Text = ((DateTime)cellValue).ToString("yyyy-MM-dd");
                        }
                        else if (cellValue is decimal || cellValue is double || cellValue is float)
                        {
                            // Nếu là số (decimal, double, float), chuyển thành chuỗi
                            textBox.Text = Convert.ToDecimal(cellValue).ToString("N2"); // Hiển thị 2 chữ số thập phân
                        }
                        else if (cellValue is int || cellValue is long)
                        {
                            // Nếu là số nguyên (int, long), chuyển thành chuỗi
                            textBox.Text = Convert.ToInt32(cellValue).ToString();
                        }
                        else
                        {
                            // Nếu là các kiểu dữ liệu khác (chuỗi, bool, v.v.), chuyển thành chuỗi
                            textBox.Text = cellValue.ToString();
                        }
                    }
                    else
                    {
                        // Nếu giá trị là null, làm trống TextBox
                        textBox.Clear();
                    }
                }
            }
        }

        private bool IsValidForm()
        {
            if (!FormValidator.IsAllTextBoxesFilled(this))
            {
                MessageBox.Show("Vui lòng điều thông tin vào các trường dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!FormValidator.IsValidEmail(textBoxEmail.Text))
            {
                MessageBox.Show("Vui lòng điều email hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!FormValidator.IsValidPhoneNumber(textBoxSDT.Text))
            {
                MessageBox.Show("Vui lòng điều số điện thoại hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            customersManager.LoadKhachHang(dataGridViewCustomers);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes(Parent);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var mapping = new Dictionary<string, TextBox>()
    {
                { "Ma_khach_hang", textBoxMaKH},
                { "Ten_khach_hang", textBoxTenKH },
                { "SDT", textBoxSDT },
                { "Email", textBoxEmail },
                { "Dia_chi", textBoxDiaChi },
                
            };

            LoadDataFromGridViewToTextBoxes(dataGridViewCustomers, mapping);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidForm())
                {
                    var khachHang = new KhachHang
                    {
                        MaKhachHang = textBoxMaKH.Text,
                        TenKhachHang = textBoxTenKH.Text,
                        SDT = textBoxSDT.Text,
                        Email = textBoxEmail.Text,
                        DiaChi = textBoxDiaChi.Text,
                       
                    };
                    customersManager.InsertKhachHang(khachHang);
                    MessageBox.Show("Thêm khách hàng thành công!");

                    customersManager.LoadKhachHang(dataGridViewCustomers);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm khách hàng: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string maKH = textBoxMaKH.Text.Trim();
            string tenKH = textBoxTenKH.Text.Trim();

            dataGridViewCustomers.DataSource = customersManager.SearchKhachHang(maKH, tenKH);
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
           customersManager.ExportKhachHangFromDataGridView(dataGridViewCustomers);
        }

        private void buttonShowGridView_Click(object sender, EventArgs e)
        {
            customersManager.LoadKhachHang(dataGridViewCustomers);
        }

        private void UserControlCustomerManagement_Load(object sender, EventArgs e)
        {
            customersManager.LoadKhachHang(dataGridViewCustomers);
        }
    }
}
