namespace MobileStoreManagement
{
    partial class FormAddPromoution
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddPromoution));
            this.labelWindowName = new System.Windows.Forms.Label();
            this.labelProductStatus = new System.Windows.Forms.Label();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelDescribe = new System.Windows.Forms.Label();
            this.richTextBoxPromoutionDescribe = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelProductPrice = new System.Windows.Forms.Label();
            this.textBoxMinimumCondition = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelInventoryQuantity = new System.Windows.Forms.Label();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelProductCategoryId = new System.Windows.Forms.Label();
            this.comboBoxSelectPromoutionSpecies = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelProductId = new System.Windows.Forms.Label();
            this.textBoxGetPromotionId = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSavePromoution = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.maskedTextBoxFromDate = new System.Windows.Forms.MaskedTextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxToDate = new System.Windows.Forms.MaskedTextBox();
            this.textBoxGetPromotionQuantity = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel9.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWindowName
            // 
            this.labelWindowName.AutoSize = true;
            this.labelWindowName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindowName.Location = new System.Drawing.Point(32, 14);
            this.labelWindowName.Margin = new System.Windows.Forms.Padding(32, 14, 0, 14);
            this.labelWindowName.Name = "labelWindowName";
            this.labelWindowName.Size = new System.Drawing.Size(156, 20);
            this.labelWindowName.TabIndex = 0;
            this.labelWindowName.Text = "Thông tin sản phẩm";
            // 
            // labelProductStatus
            // 
            this.labelProductStatus.Location = new System.Drawing.Point(0, 12);
            this.labelProductStatus.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.labelProductStatus.Name = "labelProductStatus";
            this.labelProductStatus.Size = new System.Drawing.Size(184, 26);
            this.labelProductStatus.TabIndex = 6;
            this.labelProductStatus.Text = "Số lượng khuyến mại";
            this.labelProductStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.AutoSize = true;
            this.flowLayoutPanel9.Controls.Add(this.labelProductStatus);
            this.flowLayoutPanel9.Controls.Add(this.textBoxGetPromotionQuantity);
            this.flowLayoutPanel9.Location = new System.Drawing.Point(3, 367);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(514, 50);
            this.flowLayoutPanel9.TabIndex = 11;
            this.flowLayoutPanel9.WrapContents = false;
            // 
            // labelDescribe
            // 
            this.labelDescribe.Location = new System.Drawing.Point(0, 12);
            this.labelDescribe.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.labelDescribe.Name = "labelDescribe";
            this.labelDescribe.Size = new System.Drawing.Size(184, 58);
            this.labelDescribe.TabIndex = 4;
            this.labelDescribe.Text = "Mô tả khuyến mãi";
            // 
            // richTextBoxPromoutionDescribe
            // 
            this.richTextBoxPromoutionDescribe.Location = new System.Drawing.Point(184, 12);
            this.richTextBoxPromoutionDescribe.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.richTextBoxPromoutionDescribe.Name = "richTextBoxPromoutionDescribe";
            this.richTextBoxPromoutionDescribe.Size = new System.Drawing.Size(330, 58);
            this.richTextBoxPromoutionDescribe.TabIndex = 4;
            this.richTextBoxPromoutionDescribe.Text = "";
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.AutoSize = true;
            this.flowLayoutPanel8.Controls.Add(this.labelDescribe);
            this.flowLayoutPanel8.Controls.Add(this.richTextBoxPromoutionDescribe);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(3, 279);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(514, 82);
            this.flowLayoutPanel8.TabIndex = 10;
            this.flowLayoutPanel8.WrapContents = false;
            // 
            // labelProductPrice
            // 
            this.labelProductPrice.Location = new System.Drawing.Point(0, 12);
            this.labelProductPrice.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.labelProductPrice.Name = "labelProductPrice";
            this.labelProductPrice.Size = new System.Drawing.Size(184, 24);
            this.labelProductPrice.TabIndex = 2;
            this.labelProductPrice.Text = "Điều kiện áp dụng (tối thiếu)";
            this.labelProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxMinimumCondition
            // 
            this.textBoxMinimumCondition.Location = new System.Drawing.Point(184, 12);
            this.textBoxMinimumCondition.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.textBoxMinimumCondition.Name = "textBoxMinimumCondition";
            this.textBoxMinimumCondition.Size = new System.Drawing.Size(330, 22);
            this.textBoxMinimumCondition.TabIndex = 2;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.AutoSize = true;
            this.flowLayoutPanel7.Controls.Add(this.labelProductPrice);
            this.flowLayoutPanel7.Controls.Add(this.textBoxMinimumCondition);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(3, 225);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(514, 48);
            this.flowLayoutPanel7.TabIndex = 9;
            this.flowLayoutPanel7.WrapContents = false;
            // 
            // labelInventoryQuantity
            // 
            this.labelInventoryQuantity.Location = new System.Drawing.Point(0, 12);
            this.labelInventoryQuantity.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.labelInventoryQuantity.Name = "labelInventoryQuantity";
            this.labelInventoryQuantity.Size = new System.Drawing.Size(184, 26);
            this.labelInventoryQuantity.TabIndex = 3;
            this.labelInventoryQuantity.Text = "Thời gian bắt đầu";
            this.labelInventoryQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.Controls.Add(this.labelInventoryQuantity);
            this.flowLayoutPanel6.Controls.Add(this.maskedTextBoxFromDate);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 113);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(514, 50);
            this.flowLayoutPanel6.TabIndex = 8;
            this.flowLayoutPanel6.WrapContents = false;
            // 
            // labelProductCategoryId
            // 
            this.labelProductCategoryId.Location = new System.Drawing.Point(0, 12);
            this.labelProductCategoryId.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.labelProductCategoryId.Name = "labelProductCategoryId";
            this.labelProductCategoryId.Size = new System.Drawing.Size(184, 26);
            this.labelProductCategoryId.TabIndex = 2;
            this.labelProductCategoryId.Text = "Loại khuyến mãi";
            this.labelProductCategoryId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxSelectPromoutionSpecies
            // 
            this.comboBoxSelectPromoutionSpecies.FormattingEnabled = true;
            this.comboBoxSelectPromoutionSpecies.Location = new System.Drawing.Point(184, 12);
            this.comboBoxSelectPromoutionSpecies.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.comboBoxSelectPromoutionSpecies.Name = "comboBoxSelectPromoutionSpecies";
            this.comboBoxSelectPromoutionSpecies.Size = new System.Drawing.Size(330, 24);
            this.comboBoxSelectPromoutionSpecies.TabIndex = 7;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.Controls.Add(this.labelProductCategoryId);
            this.flowLayoutPanel5.Controls.Add(this.comboBoxSelectPromoutionSpecies);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 57);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(514, 50);
            this.flowLayoutPanel5.TabIndex = 7;
            this.flowLayoutPanel5.WrapContents = false;
            // 
            // labelProductId
            // 
            this.labelProductId.Location = new System.Drawing.Point(0, 12);
            this.labelProductId.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.labelProductId.Name = "labelProductId";
            this.labelProductId.Size = new System.Drawing.Size(184, 24);
            this.labelProductId.TabIndex = 1;
            this.labelProductId.Text = "Mã khuyến mãi";
            this.labelProductId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxGetPromotionId
            // 
            this.textBoxGetPromotionId.Location = new System.Drawing.Point(184, 12);
            this.textBoxGetPromotionId.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.textBoxGetPromotionId.Name = "textBoxGetPromotionId";
            this.textBoxGetPromotionId.Size = new System.Drawing.Size(330, 22);
            this.textBoxGetPromotionId.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.labelProductId);
            this.flowLayoutPanel1.Controls.Add(this.textBoxGetPromotionId);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(514, 48);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel9);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(140, 26);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(520, 420);
            this.flowLayoutPanel2.TabIndex = 3;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.buttonSavePromoution);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 575);
            this.panel1.TabIndex = 4;
            // 
            // buttonSavePromoution
            // 
            this.buttonSavePromoution.Image = global::MobileStoreManagement.Properties.Resources.save;
            this.buttonSavePromoution.Location = new System.Drawing.Point(507, 475);
            this.buttonSavePromoution.Margin = new System.Windows.Forms.Padding(27, 9, 27, 24);
            this.buttonSavePromoution.Name = "buttonSavePromoution";
            this.buttonSavePromoution.Size = new System.Drawing.Size(150, 54);
            this.buttonSavePromoution.TabIndex = 1;
            this.buttonSavePromoution.Text = "Lưu thông tin";
            this.buttonSavePromoution.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSavePromoution.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSavePromoution.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.labelWindowName);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(782, 48);
            this.flowLayoutPanel4.TabIndex = 5;
            // 
            // maskedTextBoxFromDate
            // 
            this.maskedTextBoxFromDate.Location = new System.Drawing.Point(184, 12);
            this.maskedTextBoxFromDate.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.maskedTextBoxFromDate.Mask = "00/00/0000";
            this.maskedTextBoxFromDate.Name = "maskedTextBoxFromDate";
            this.maskedTextBoxFromDate.Size = new System.Drawing.Size(330, 22);
            this.maskedTextBoxFromDate.TabIndex = 12;
            this.maskedTextBoxFromDate.ValidatingType = typeof(System.DateTime);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Controls.Add(this.maskedTextBoxToDate);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 169);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(514, 50);
            this.flowLayoutPanel3.TabIndex = 12;
            this.flowLayoutPanel3.WrapContents = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thời gian kết thúc";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maskedTextBoxToDate
            // 
            this.maskedTextBoxToDate.Location = new System.Drawing.Point(184, 12);
            this.maskedTextBoxToDate.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.maskedTextBoxToDate.Mask = "00/00/0000";
            this.maskedTextBoxToDate.Name = "maskedTextBoxToDate";
            this.maskedTextBoxToDate.Size = new System.Drawing.Size(330, 22);
            this.maskedTextBoxToDate.TabIndex = 12;
            this.maskedTextBoxToDate.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxGetPromotionQuantity
            // 
            this.textBoxGetPromotionQuantity.Location = new System.Drawing.Point(184, 12);
            this.textBoxGetPromotionQuantity.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.textBoxGetPromotionQuantity.Name = "textBoxGetPromotionQuantity";
            this.textBoxGetPromotionQuantity.Size = new System.Drawing.Size(330, 22);
            this.textBoxGetPromotionQuantity.TabIndex = 7;
            // 
            // FormAddPromoution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 623);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 670);
            this.MinimumSize = new System.Drawing.Size(800, 670);
            this.Name = "FormAddPromoution";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mobile Manager";
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel9.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWindowName;
        private System.Windows.Forms.Label labelProductStatus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.Label labelDescribe;
        private System.Windows.Forms.RichTextBox richTextBoxPromoutionDescribe;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.Label labelProductPrice;
        private System.Windows.Forms.TextBox textBoxMinimumCondition;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label labelInventoryQuantity;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label labelProductCategoryId;
        private System.Windows.Forms.ComboBox comboBoxSelectPromoutionSpecies;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label labelProductId;
        private System.Windows.Forms.TextBox textBoxGetPromotionId;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSavePromoution;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFromDate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxToDate;
        private System.Windows.Forms.TextBox textBoxGetPromotionQuantity;
    }
}