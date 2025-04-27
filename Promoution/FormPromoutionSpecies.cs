using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStoreManagement.Promoution
{
    public partial class FormPromoutionSpecies : Form
    {
        PromoutionManager pmManager = new PromoutionManager();
        public FormPromoutionSpecies()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBoxPromoutionSpeciesId.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBoxPromoutionSpeciesName.Focus();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string pmId = textBoxPromoutionSpeciesId.Text;
            string pmName = textBoxPromoutionSpeciesName.Text;

            if (pmId.Length != 1)
            {
                MessageBox.Show("Vui lòng chỉ nhập 1 ký tự cho mã loại khuyến mãi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if (string.IsNullOrEmpty(pmName))
            {
                MessageBox.Show("Vui lòng nhập tên loại khuyến mãi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            pmManager.InsertPromotionType(pmId, pmName);   
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string pmId = textBoxPromoutionSpeciesId.Text;

            if (pmId.Length != 1)
            {
                MessageBox.Show("Vui lòng nhập 1 ký tự cho mã loại khuyến mãi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            pmManager.DeletePromotionType(pmId);
        }
    }
}
