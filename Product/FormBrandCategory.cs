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
    public partial class FormBrandCategory : Form
    {
        public FormBrandCategory()
        {
            InitializeComponent();
        }

        private void labelBrandId_Click(object sender, EventArgs e)
        {
            textBoxGetBrandId.Focus();
        }

        private void labelBrandName_Click(object sender, EventArgs e)
        {
            textBoxGetBrandName.Focus();
        }
    }
}
