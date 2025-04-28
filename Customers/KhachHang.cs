using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStoreManagement.Customers
{
    internal class KhachHang
    {
        internal string MaKhachHang { get; set; }
        internal string TenKhachHang { get; set; }
        internal string SDT { get; set; }
        internal string Email { get; set; }
        internal string DiaChi { get; set; }
     
        internal string PhanLoaiKH { get; set; }
    }
}
