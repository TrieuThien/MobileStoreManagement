using MobileStoreManagement.Promoution;
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

namespace MobileStoreManagement
{
    public partial class FormAddPromoution : Form
    {
        ConnectDatabase connectDb = new ConnectDatabase();
        PromoutionManager pmManager = new PromoutionManager();
        public FormAddPromoution()
        {
            InitializeComponent();
        }

        internal void LoadPromotionTypesIntoComboBox(ComboBox comboBox)
        {
            try
            {
                using (SqlConnection connection = connectDb.GetConnection())
                {
                    string query = @"
                SELECT Loai_khuyen_mai, Ten_loai_khuyen_mai
                FROM HINH_THUC_KHUYEN_MAI
                WHERE Ma_nguoi_ban = @Ma_nguoi_ban";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Ma_nguoi_ban", Session.userId);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        comboBox.DataSource = dt;
                        comboBox.DisplayMember = "Ten_loai_khuyen_mai";   // Hiển thị tên cho người dùng thấy
                        comboBox.ValueMember = "Loai_khuyen_mai";         // Giá trị thực sự (mã khuyến mãi)
                        comboBox.SelectedIndex = -1; // Không chọn mặc định
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách hình thức khuyến mãi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAddPromoution_Load(object sender, EventArgs e)
        {
            LoadPromotionTypesIntoComboBox(comboBoxSelectPromoutionSpecies);
        }

        private void buttonSavePromoution_Click(object sender, EventArgs e)
        {
            if (!FormValidator.IsAllTextBoxesFilled(this))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin các trường dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string maKhuyenMai = textBoxGetPromotionId.Text;
            string tenKhuyenMai = textBoxPromoutionName.Text;
            string loaiKhuyenMai = comboBoxSelectPromoutionSpecies.SelectedValue.ToString();
            
            
            string moTa = richTextBoxPromoutionDescribe.Text;

            DateTime thoiGianBatDau = DateTime.Now;
            DateTime thoiGianKetThuc = DateTime.Now;
            decimal dkadTheoSoTien = 0;
            int dkadTheoSoLuong = 0;
            int soLuongKhuyenMai = 0;
            float khuyenMaiApDung = 0;
            try
            {
                DateTime.TryParse(maskedTextBoxFromDate.Text, out thoiGianBatDau);
                DateTime.TryParse(maskedTextBoxToDate.Text, out thoiGianKetThuc);
                float.TryParse(textBoxPromoutionPercent.Text, out khuyenMaiApDung);
                decimal.TryParse(textBoxMoneyCondition.Text, out dkadTheoSoTien);
                int.TryParse(textBoxGetPromotionQuantity.Text, out dkadTheoSoLuong);
                int.TryParse(textBoxGetPromotionQuantity.Text, out soLuongKhuyenMai);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            pmManager.InsertPromotion(maKhuyenMai, loaiKhuyenMai, tenKhuyenMai, moTa, thoiGianBatDau, thoiGianKetThuc, dkadTheoSoTien, dkadTheoSoLuong, khuyenMaiApDung, soLuongKhuyenMai, false);
        }
    }
}
