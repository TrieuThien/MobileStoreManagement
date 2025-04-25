using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStoreManagement
{
    internal static class Session
    {
        static Session()
        {
            authenticateStatus = false;
        }
        internal static int userId { get; set; }
        internal static string username { get; set; }

        internal static bool authenticateStatus { get; set; }

    }
}
