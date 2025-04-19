using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStoreManagement
{
    internal static class LoginService
    {
        public static bool Authenticate(string username, string password)
        {
            // Đây là demo, nên kiểm tra với database
            return username == "admin" && password == "123";
        }
    }
}
