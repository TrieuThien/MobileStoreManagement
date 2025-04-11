using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStoreManagement
{
    public partial class UserControlHeader : UserControl
    {
        public UserControlHeader()
        {
            InitializeComponent();
        }

        private void buttonToSumarylWindow_Click(object sender, EventArgs e)
        {
            SumaryWindow sumaryWindow = new SumaryWindow();
            sumaryWindow.Show();
        }

    }
}
