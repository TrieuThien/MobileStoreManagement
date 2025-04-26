using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MobileStoreManagement
{
    internal class FormValidator
    {
        internal bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // Regex kiểm tra định dạng email chuẩn
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        internal bool IsValidPhoneNumber(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                return false;

            // Mẫu phổ biến: bắt đầu bằng 0, theo sau là 9-10 chữ số
            string pattern = @"^0\d{9}$";

            return Regex.IsMatch(phone, pattern);
        }
    }
}
