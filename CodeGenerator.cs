using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStoreManagement
{
    internal static class CodeGenerator
    {
        private static readonly ConnectDatabase connectDb = new ConnectDatabase();

        // Hàm tạo mã phiếu nhập (10 ký tự)
        public static string GenerateReceiptImportId()
        {
            string prefix = "PN"; // Tiền tố mã phiếu nhập
            string datePart = DateTime.Now.ToString("MMdd"); // Phần ngày tháng năm (ví dụ: 20250428)
            string baseReceiptId = prefix + datePart; // Mã phiếu nhập theo ngày
            return GetNewCode(baseReceiptId, 10);
        }

        // Hàm tạo mã phiếu xuất (10 ký tự)
        public static string GenerateReceiptExportId()
        {
            string prefix = "PX"; // Tiền tố mã phiếu xuất
            string datePart = DateTime.Now.ToString("MMdd");
            string baseReceiptId = prefix + datePart;
            return GetNewCode(baseReceiptId, 10);
        }

        // Hàm tạo mã khách hàng (10 ký tự)
        public static string GenerateCustomerId()
        {
            string prefix = "KH"; // Tiền tố mã khách hàng
            string datePart = DateTime.Now.ToString("MMdd"); // Phần ngày tháng năm (ví dụ: 20250428)
            string baseCustomerId = prefix + datePart; // Mã khách hàng theo ngày
            return GetNewCode(baseCustomerId, 10);
        }

        // Hàm tạo mã sản phẩm (10 ký tự)
        public static string GenerateProductId()
        {
            string prefix = "SP"; // Tiền tố mã sản phẩm
            string datePart = DateTime.Now.ToString("MMdd");
            string baseProductId = prefix + datePart; // Mã sản phẩm theo ngày
            return GetNewCode(baseProductId, 10);
        }

        // Hàm tạo mã khuyến mãi (5 ký tự)
        public static string GeneratePromotionCode()
        {
            string prefix = "KM"; // Tiền tố mã khuyến mãi
            string datePart = DateTime.Now.ToString("MMdd"); 
            string basePromotionCode = prefix + datePart; 
            return GetNewCode(basePromotionCode, 5);
        }

        // Hàm kiểm tra và tạo mã mới theo kiểu mã có sẵn
        private static string GetNewCode(string baseCode, int requiredLength)
        {
            string newCode = baseCode;
            int counter = 1;

            // Kiểm tra mã đã tồn tại trong CSDL
            string checkQuery = $"SELECT COUNT(*) FROM {GetTableName(baseCode)} WHERE {GetColumnName(baseCode)} LIKE @code";

            using (SqlConnection connection = connectDb.GetConnection())
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                using (SqlCommand command = new SqlCommand(checkQuery, connection))
                {
                    command.Parameters.AddWithValue("@code", baseCode + "%");
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // Nếu có mã đã tồn tại, tăng số tự động
                    counter = count + 1;

                    // Đảm bảo rằng độ dài của mã cuối cùng luôn bằng với requiredLength
                    int counterLength = requiredLength - baseCode.Length; // Tính chiều dài của phần số đếm
                    string counterStr = counter.ToString();

                    // Nếu phần số đếm quá dài, chỉ lấy phần cuối của nó
                    if (counterStr.Length > counterLength)
                    {
                        counterStr = counterStr.Substring(counterStr.Length - counterLength);
                    }
                    else
                    {
                        // Nếu phần số đếm ngắn hơn, thêm số 0 vào trước
                        counterStr = counterStr.PadLeft(counterLength, '0');
                    }

                    newCode = baseCode + counterStr; // Ghép lại mã hoàn chỉnh
                }
            }

            return newCode;
        }

        // Hàm lấy tên bảng tương ứng với mã để kiểm tra trong CSDL
        private static string GetTableName(string baseCode)
        {
            if (baseCode.StartsWith("PN")) return "Phieu_nhap_hang_";
            if (baseCode.StartsWith("PX")) return "Phieu_xuat_hang";
            if (baseCode.StartsWith("KH")) return "Khach_hang";
            if (baseCode.StartsWith("SP")) return "San_pham";
            if (baseCode.StartsWith("KM")) return "CT_KHUYEN_MAI";
            return string.Empty;
        }

        // Hàm lấy tên cột tương ứng với mã để kiểm tra trong CSDL
        private static string GetColumnName(string baseCode)
        {
            if (baseCode.StartsWith("PN")) return "Ma_phieu_nhap";
            if (baseCode.StartsWith("PX")) return "Ma_phieu_xuat";
            if (baseCode.StartsWith("KH")) return "Ma_khach_hang";
            if (baseCode.StartsWith("SP")) return "Ma_san_pham";
            if (baseCode.StartsWith("KM")) return "Ma_khuyen_mai";
            return string.Empty;
        }
    }
}
