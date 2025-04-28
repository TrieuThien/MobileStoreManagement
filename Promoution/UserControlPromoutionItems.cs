using MobileStoreManagement.Promoution;
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
        string promoutionId = string.Empty;
        PromoutionManager pmManager = new PromoutionManager();
        public event EventHandler PromotionStatusChanged;
        public UserControlPromoutionItems(string promoutionId)
        {
            InitializeComponent();
            this.promoutionId = promoutionId;
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

        private void buttonDeactivePromoution_Click(object sender, EventArgs e)
        {
            pmManager.UpdatePromotionStatus(promoutionId, false);
            PromotionStatusChanged?.Invoke(this, EventArgs.Empty);
        }

        private void buttonActivePromoution_Click(object sender, EventArgs e)
        {
            pmManager.UpdatePromotionStatus(promoutionId, true);
            PromotionStatusChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
