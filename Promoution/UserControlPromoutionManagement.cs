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
    public partial class UserControlPromoutionManagement : UserControl
    {
        PromoutionManager promoutionManager = new PromoutionManager();  
        public UserControlPromoutionManagement()
        {
            InitializeComponent();
        }

        private void buttonAddPromoution_Click(object sender, EventArgs e)
        {
            FormAddPromoution formAddPromoution = new FormAddPromoution();
            formAddPromoution.ShowDialog(); 
        }
        private void setUpPromoutionItems(DataTable promoutionsTable)
        {
            flowLayoutPanelListPromoution.Controls.Clear();

            UserControlPromoutionItems ucPromoutionItemHeader = new UserControlPromoutionItems(isSetUp: true);
            flowLayoutPanelListPromoution.Controls.Add(ucPromoutionItemHeader);

            foreach (DataRow row in promoutionsTable.Rows)
            {
                UserControlPromoutionItems promoutionItem = new UserControlPromoutionItems(row["Ma_khuyen_mai"].ToString());
                promoutionItem.PromotionStatusChanged += Item_PromotionStatusChanged;
                promoutionItem.setPromoutionName(row["Ten_CTKM"].ToString());
                promoutionItem.setPromoutionDes(row["Mo_ta"].ToString());
                promoutionItem.setFromDate(row["Thoi_gian_bat_dau"].ToString());
                promoutionItem.setToDate(row["Thoi_gian_ket_thuc"].ToString());
                promoutionItem.setPromoutionForm(row["Ten_loai_khuyen_mai"].ToString());

                bool status = false;
                bool.TryParse(row["Trang_thai"].ToString(), out status);
                if (status)
                    promoutionItem.setPromoutionStatus("Đã kích hoạt");
                else
                    promoutionItem.setPromoutionStatus("Ngưng kích hoạt");
                flowLayoutPanelListPromoution.Controls.Add(promoutionItem);
            }
        }
        private void LoadPromoutionItemsToUI()
        {
            // Add data
            DataTable promoutions = promoutionManager.GetPromotionDetailsWithType();
            setUpPromoutionItems(promoutions);
        }

        private void LoadFilteredProductsToUI()
        {
            // Add data
            DataTable promoutions = promoutionManager.FilterAndCombineData(checkedListBoxStatus, checkedListBoxEffect); ;
            setUpPromoutionItems(promoutions);
        }
        private void LoadSearchedPromoutionToUI()
        {
            string keyword = textBoxGetKeyWordSearch.Text;
            // Add data
            DataTable promoutions = promoutionManager.SearchPromotion(keyword); 
            setUpPromoutionItems(promoutions);
        }
        private void Item_PromotionStatusChanged(object sender, EventArgs e)
        {
            LoadPromoutionItemsToUI();
        }
        private void UserControlPromoutionManagement_Load(object sender, EventArgs e)
        {
            LoadPromoutionItemsToUI();
        }

        private void buttonPromoutionSpecies_Click(object sender, EventArgs e)
        {
            FormPromoutionSpecies pmSpeciese = new FormPromoutionSpecies();
            pmSpeciese.ShowDialog();
        }

        private void checkedListBoxStatus_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke(new Action(LoadFilteredProductsToUI));
        }

        private void checkedListBoxEffect_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke(new Action(LoadFilteredProductsToUI));
        }

        private void buttonSearchPromoution_Click(object sender, EventArgs e)
        {
            LoadSearchedPromoutionToUI();
        }
    }
}
