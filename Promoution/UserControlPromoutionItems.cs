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
    public partial class UserControlPromoutionItems : UserControl
    {
        public UserControlPromoutionItems()
        {
            InitializeComponent();
        }
        public UserControlPromoutionItems(bool isSetUp)
        {
            InitializeComponent();
            if (isSetUp)
            {
                buttonDeactivePromoution.Hide();
                buttonActivePromoution.Hide();
            }
        }


        internal void setPromoutionName(string name)
        {
            labelPromoutionName.Text = name;
        }

        internal void setPromoutionDes(string des)
        {
            labelPromotionDes.Text = des;
        }

        internal void setFromDate(string fromDate)
        {
            labelFromDate.Text = fromDate;
        }

        internal void setToDate(string toDate)
        {
            labelToDate.Text = toDate;
        }

        internal void setPromoutionForm(string formPromoution)
        {
            labelForm.Text = formPromoution;
        }

        internal void setPromoutionStatus(string status)
        {
            labelStatus.Text = status;
        }
    }
}
