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
    public partial class UserControlPromoutionManagement : UserControl
    {
        public UserControlPromoutionManagement()
        {
            InitializeComponent();
        }

        private void buttonAddPromoution_Click(object sender, EventArgs e)
        {
            FormAddPromoution formAddPromoution = new FormAddPromoution();
            formAddPromoution.ShowDialog(); 
        }

        private void UserControlPromoutionManagement_Load(object sender, EventArgs e)
        {
            UserControlPromoutionItems ucPromoutionItemHeader = new UserControlPromoutionItems(isSetUp: true);
            flowLayoutPanelListPromoution.Controls.Add(ucPromoutionItemHeader);

            // Add data
            
        }

        private void buttonPromoutionSpecies_Click(object sender, EventArgs e)
        {
            
        }
    }
}
