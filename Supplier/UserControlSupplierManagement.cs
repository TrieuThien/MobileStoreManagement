using MobileStoreManagement.Supplier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStoreManagement
{
    public partial class UserControlSupplierManagement : UserControl
    {
        SupplierManager suppilerManager = new SupplierManager();
        public UserControlSupplierManagement()
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
                    TextBox textBox = entry.Value;      // TextBox tương ứng

                    if (dgv.CurrentRow.Cells[columnName].Value != null)
                    {
                        textBox.Text = dgv.CurrentRow.Cells[columnName].Value.ToString();
                    }
                    else
                    {
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
            if (!FormValidator.IsValidEmail(textBoxSupEmail.Text))
            {
                MessageBox.Show("Vui lòng điều email hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!FormValidator.IsValidPhoneNumber(textBoxSupPhoneNumber.Text))
            {
                MessageBox.Show("Vui lòng điều số điện thoại hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            suppilerManager.LoadNhaCungCap(dataGridView1);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes(Parent);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var mapping = new Dictionary<string, TextBox>()
    {
                { "Ma_nha_cung_cap", textBoxSupplierId},
                { "Ten_nha_cung_cap", textBoxSupplierName },
                { "SDT", textBoxSupPhoneNumber },
                { "Email", textBoxSupEmail },
                { "Dia_chi", textBoxSupAddress }
            };

            LoadDataFromGridViewToTextBoxes(dataGridView1, mapping);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string maNhaCungCap = textBoxSupplierId.Text.Trim();
                if (!string.IsNullOrEmpty(maNhaCungCap))
                {
                    suppilerManager.DeleteNhaCungCap(maNhaCungCap);
                    MessageBox.Show("Xóa nhà cung cấp thành công!");
                    suppilerManager.LoadNhaCungCap(dataGridView1);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn nhà cung cấp để xóa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa nhà cung cấp: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (IsValidForm())
                {
                    var nhaCungCap = new NhaCungCap
                    {
                        MaNhaCungCap = textBoxSupplierId.Text,
                        TenNhaCungCap = textBoxSupplierName.Text,
                        SDT = textBoxSupPhoneNumber.Text,
                        Email = textBoxSupEmail.Text,
                        DiaChi = textBoxSupAddress.Text
                    };
                    suppilerManager.InsertNhaCungCap(nhaCungCap);
                    MessageBox.Show("Thêm nhà cung cấp thành công!");

                    suppilerManager.LoadNhaCungCap(dataGridView1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhà cung cấp: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (IsValidForm())
                {
                    var nhaCungCap = new NhaCungCap
                    {
                        MaNhaCungCap = textBoxSupplierId.Text,
                        TenNhaCungCap = textBoxSupplierName.Text,
                        SDT = textBoxSupPhoneNumber.Text,
                        Email = textBoxSupEmail.Text,
                        DiaChi = textBoxSupAddress.Text
                    };
                    suppilerManager.UpdateNhaCungCap(nhaCungCap);
                    MessageBox.Show("Cập nhật nhà cung cấp thành công!");
                    suppilerManager.LoadNhaCungCap(dataGridView1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật nhà cung cấp: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
}

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string maNCC = textBoxSupplierId.Text.Trim();
            string tenNCC = textBoxSupplierName.Text.Trim();

            dataGridView1.DataSource = suppilerManager.SearchNhaCungCap(maNCC, tenNCC);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            suppilerManager.ExportNhaCungCapFromDataGridView(dataGridView1);
        }

        private void UserControlSupplierManagement_Load(object sender, EventArgs e)
        {
            suppilerManager.LoadNhaCungCap(dataGridView1);
        }
    }
}
