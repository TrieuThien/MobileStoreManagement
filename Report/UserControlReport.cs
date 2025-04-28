using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStoreManagement
{
    public partial class UserControlReport : UserControl
    {
        ConnectDatabase connectDb = new ConnectDatabase();
        public UserControlReport()
        {
            InitializeComponent();
        }
        internal DataTable LoadStockData()
        {
            // Tạo kết nối cơ sở dữ liệu
            using (SqlConnection connection = connectDb.GetConnection())
            {
                connection.Open();

                // Truy vấn để lấy thông tin số lượng tồn kho của sản phẩm
                string query = @"
            SELECT Ma_san_pham, Ten_san_pham, So_luong_ton_kho, Tinh_trang_san_pham
            FROM San_pham
            WHERE Tinh_trang_san_pham IN ('M', 'C')"; // 'M' cho sản phẩm mới, 'C' cho sản phẩm cũ

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Tạo DataTable để lưu dữ liệu
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Thêm cột DisplayText cho báo cáo đẹp hơn (VD: "SP001 - Sản phẩm mới - 50")
                        dataTable.Columns.Add("DisplayText", typeof(string));

                        foreach (DataRow row in dataTable.Rows)
                        {
                            string tinhTrang = row["Tinh_trang_san_pham"].ToString();
                            string displayText = $"{row["Ma_san_pham"]} - {row["Ten_san_pham"]} - {(tinhTrang == "M" ? "Mới" : "Cũ")} - {row["So_luong_ton_kho"]}";
                            row["DisplayText"] = displayText;
                        }

                        // Trả về DataTable chứa dữ liệu báo cáo
                        return dataTable;
                    }
                }
            }
        }


        public DataTable LoadPromoutionData()
        {
            DataTable dt = new DataTable();

            // Câu lệnh SQL để lấy dữ liệu từ bảng CT_KHUYEN_MAI
            string query = @"
            SELECT Ma_khuyen_mai, Ten_CTKM, Thoi_gian_bat_dau, Thoi_gian_ket_thuc, Trang_thai
            FROM CT_KHUYEN_MAI where Ma_nguoi_ban = @maNguoiBan";

            using (SqlConnection connection = connectDb.GetConnection())
            {
                // Mở kết nối
                connection.Open();

                // Tạo command và tham số nếu cần thiết
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@maNguoiBan", Session.userId);
                    // Sử dụng SqlDataAdapter để điền dữ liệu vào DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public DataTable LoadImportReceiptData()
        {
            DataTable dt = new DataTable();

            // Câu lệnh SQL để lấy dữ liệu từ ba bảng với JOIN
            string query = @"
            SELECT 
                pn.Ma_phieu_nhap,
                pn.Ngay_nhap,
                pn.Tong_tien_nhap,
                pn.Giam_gia,
                pn.Ghi_chu_phieu_nhap,
                ctpn.Ma_san_pham,
                sp.Ten_san_pham,
                ctpn.So_luong_nhap,
                ctpn.Gia_nhap_vao,
                sp.So_luong_ton_kho
            FROM Phieu_nhap_hang_ pn
            INNER JOIN Chi_tiet_phieu_nhap ctpn ON pn.Ma_phieu_nhap = ctpn.Ma_phieu_nhap
            INNER JOIN San_pham sp ON ctpn.Ma_san_pham = sp.Ma_san_pham";

            using (SqlConnection connection = connectDb.GetConnection())
            {
                // Mở kết nối
                connection.Open();

                // Tạo command và tham số nếu cần thiết
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Sử dụng SqlDataAdapter để điền dữ liệu vào DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        private void ShowStockReport()
        {
            ReportDocument report = new ReportDocument();

            // Thay đổi đường dẫn .rpt ở đây để chạy chương trình
            report.Load(@"E:\Learning\University\Practice\Windows_form\MobileStoreManagement\Report\CrystalReport_InventoryReport.rpt");  

            DataTable stockData = LoadStockData();

            report.SetDataSource(stockData);

            crystalReportViewer1.ReportSource = report;

            // Làm mới báo cáo
            crystalReportViewer1.Refresh();
        }

        private void ShowPromoutionReport()
        {
            ReportDocument report = new ReportDocument();

            // Thay đổi đường dẫn .rpt ở đây để chạy chương trình
            report.Load(@"E:\Learning\University\Practice\Windows_form\MobileStoreManagement\Report\CrystalReport_PromoutionReport.rpt");

            DataTable promoutionData = LoadPromoutionData();

            report.SetDataSource(promoutionData);

            crystalReportViewer1.ReportSource = report;

            // Làm mới báo cáo
            crystalReportViewer1.Refresh();
        }

        private void ShowImportReceiptReport()
        {
            ReportDocument report = new ReportDocument();

            // Thay đổi đường dẫn .rpt ở đây để chạy chương trình
            report.Load(@"E:\Learning\University\Practice\Windows_form\MobileStoreManagement\Report\CrystalReport_ImportProduct.rpt");

            DataTable importReceiptData = LoadImportReceiptData();

            report.SetDataSource(importReceiptData);

            crystalReportViewer1.ReportSource = report;

            // Làm mới báo cáo
            crystalReportViewer1.Refresh();
        }

        private void buttonRevenueReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng sẽ sớm được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSalesReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng sẽ sớm được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonInventoryReport_Click(object sender, EventArgs e)
        {
            ShowStockReport();
        }

        private void buttonPromoutionReport_Click(object sender, EventArgs e)
        {
            ShowPromoutionReport();
        }

        private void buttonImportReceiptReport_Click(object sender, EventArgs e)
        {
            ShowImportReceiptReport();
        }
    }
}
