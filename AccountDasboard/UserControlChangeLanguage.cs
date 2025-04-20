using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStoreManagement.AccountDasboard
{
    public partial class UserControlChangeLanguage : UserControl
    {
        public UserControlChangeLanguage()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSaveLanguage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng sẽ sớm được nâng cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
