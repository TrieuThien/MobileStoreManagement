using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MobileStoreManagement
{
    internal static class FormValidator
    {
        internal static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                var mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        internal static bool IsValidPhoneNumber(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                return false;

            // Mẫu phổ biến: bắt đầu bằng 0, theo sau là 9-10 chữ số
            string pattern = @"^0\d{9}$";

            return Regex.IsMatch(phone, pattern);
        }

        internal static bool IsAllTextBoxesFilled(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return false;
                }
                else if (ctrl.HasChildren)
                {
                    if (!IsAllTextBoxesFilled(ctrl))
                        return false;
                }
            }
            return true;
        }
        internal static bool Is10Character(string str)
        {
            return (str.Length == 10) ? true : false;
        }

        internal static bool IsMaxiMum20Character(string str)
        {
            return (str.Length <= 20) ? true : false;
        }
    }
}
