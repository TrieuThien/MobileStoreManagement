using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStoreManagement.ImportExport
{
    public partial class UserControlImoprtExportItems : UserControl
    {
        public UserControlImoprtExportItems()
        {
            InitializeComponent();
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this); // Xóa chính nó khỏi danh sách control của cha
            this.Dispose(); // Giải phóng tài nguyên nếu cần
        }
    }
}
