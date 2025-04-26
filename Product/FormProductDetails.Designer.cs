namespace MobileStoreManagement
{
    partial class FormProductDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductDetails));
            this.buttonSaveProduct = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonChangePicture = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelProductId = new System.Windows.Forms.Label();
            this.textBoxProductId = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelProductCategoryId = new System.Windows.Forms.Label();
            this.comboBoxSelectCategory = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelInventoryQuantity = new System.Windows.Forms.Label();
            this.comboBoxSelectBrand = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelProductPrice = new System.Windows.Forms.Label();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelDescribe = new System.Windows.Forms.Label();
            this.richTextBoxProductDescribe = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelProductStatus = new System.Windows.Forms.Label();
            this.comboBoxProductStatus = new System.Windows.Forms.ComboBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.pictureBoxProductImage = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelWindowName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductImage)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSaveProduct
            // 
            this.buttonSaveProduct.Image = global::MobileStoreManagement.Properties.Resources.save;
            this.buttonSaveProduct.Location = new System.Drawing.Point(674, 487);
            this.buttonSaveProduct.Margin = new System.Windows.Forms.Padding(27, 9, 27, 24);
            this.buttonSaveProduct.Name = "buttonSaveProduct";
            this.buttonSaveProduct.Size = new System.Drawing.Size(150, 54);
            this.buttonSaveProduct.TabIndex = 1;
            this.buttonSaveProduct.Text = "Lưu thông tin";
            this.buttonSaveProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSaveProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSaveProduct.UseVisualStyleBackColor = true;
            this.buttonSaveProduct.Click += new System.EventHandler(this.buttonSaveProduct_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.buttonChangePicture);
            this.panel1.Controls.Add(this.buttonSaveProduct);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.textBoxProductName);
            this.panel1.Controls.Add(this.labelProductName);
            this.panel1.Controls.Add(this.pictureBoxProductImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 553);
            this.panel1.TabIndex = 1;
            // 
            // buttonChangePicture
            // 
            this.buttonChangePicture.Location = new System.Drawing.Point(111, 440);
            this.buttonChangePicture.Name = "buttonChangePicture";
            this.buttonChangePicture.Size = new System.Drawing.Size(147, 29);
            this.buttonChangePicture.TabIndex = 5;
            this.buttonChangePicture.Text = "Thay ảnh";
            this.buttonChangePicture.UseVisualStyleBackColor = true;
            this.buttonChangePicture.Click += new System.EventHandler(this.buttonChangePicture_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel9);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(343, 111);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(481, 364);
            this.flowLayoutPanel2.TabIndex = 3;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.labelProductId);
            this.flowLayoutPanel1.Controls.Add(this.textBoxProductId);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(475, 48);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // labelProductId
            // 
            this.labelProductId.Location = new System.Drawing.Point(0, 12);
            this.labelProductId.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.labelProductId.Name = "labelProductId";
            this.labelProductId.Size = new System.Drawing.Size(168, 24);
            this.labelProductId.TabIndex = 1;
            this.labelProductId.Text = "Mã sản phẩm";
            this.labelProductId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxProductId
            // 
            this.textBoxProductId.Location = new System.Drawing.Point(168, 12);
            this.textBoxProductId.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.textBoxProductId.Name = "textBoxProductId";
            this.textBoxProductId.Size = new System.Drawing.Size(307, 24);
            this.textBoxProductId.TabIndex = 0;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.Controls.Add(this.labelProductCategoryId);
            this.flowLayoutPanel5.Controls.Add(this.comboBoxSelectCategory);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 57);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(475, 50);
            this.flowLayoutPanel5.TabIndex = 7;
            this.flowLayoutPanel5.WrapContents = false;
            // 
            // labelProductCategoryId
            // 
            this.labelProductCategoryId.Location = new System.Drawing.Point(0, 12);
            this.labelProductCategoryId.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.labelProductCategoryId.Name = "labelProductCategoryId";
            this.labelProductCategoryId.Size = new System.Drawing.Size(168, 26);
            this.labelProductCategoryId.TabIndex = 2;
            this.labelProductCategoryId.Text = "Danh mục sản phẩm";
            this.labelProductCategoryId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxSelectCategory
            // 
            this.comboBoxSelectCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectCategory.FormattingEnabled = true;
            this.comboBoxSelectCategory.Location = new System.Drawing.Point(168, 12);
            this.comboBoxSelectCategory.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.comboBoxSelectCategory.Name = "comboBoxSelectCategory";
            this.comboBoxSelectCategory.Size = new System.Drawing.Size(307, 26);
            this.comboBoxSelectCategory.TabIndex = 7;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.Controls.Add(this.labelInventoryQuantity);
            this.flowLayoutPanel6.Controls.Add(this.comboBoxSelectBrand);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 113);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(475, 50);
            this.flowLayoutPanel6.TabIndex = 8;
            this.flowLayoutPanel6.WrapContents = false;
            // 
            // labelInventoryQuantity
            // 
            this.labelInventoryQuantity.Location = new System.Drawing.Point(0, 12);
            this.labelInventoryQuantity.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.labelInventoryQuantity.Name = "labelInventoryQuantity";
            this.labelInventoryQuantity.Size = new System.Drawing.Size(168, 26);
            this.labelInventoryQuantity.TabIndex = 3;
            this.labelInventoryQuantity.Text = "Thương hiệu";
            this.labelInventoryQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxSelectBrand
            // 
            this.comboBoxSelectBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectBrand.FormattingEnabled = true;
            this.comboBoxSelectBrand.Location = new System.Drawing.Point(168, 12);
            this.comboBoxSelectBrand.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.comboBoxSelectBrand.Name = "comboBoxSelectBrand";
            this.comboBoxSelectBrand.Size = new System.Drawing.Size(307, 26);
            this.comboBoxSelectBrand.TabIndex = 6;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.AutoSize = true;
            this.flowLayoutPanel7.Controls.Add(this.labelProductPrice);
            this.flowLayoutPanel7.Controls.Add(this.textBoxProductPrice);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(3, 169);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(475, 48);
            this.flowLayoutPanel7.TabIndex = 9;
            this.flowLayoutPanel7.WrapContents = false;
            // 
            // labelProductPrice
            // 
            this.labelProductPrice.Location = new System.Drawing.Point(0, 12);
            this.labelProductPrice.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.labelProductPrice.Name = "labelProductPrice";
            this.labelProductPrice.Size = new System.Drawing.Size(168, 24);
            this.labelProductPrice.TabIndex = 2;
            this.labelProductPrice.Text = "Giá bán";
            this.labelProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.Location = new System.Drawing.Point(168, 12);
            this.textBoxProductPrice.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(307, 24);
            this.textBoxProductPrice.TabIndex = 2;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.AutoSize = true;
            this.flowLayoutPanel8.Controls.Add(this.labelDescribe);
            this.flowLayoutPanel8.Controls.Add(this.richTextBoxProductDescribe);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(3, 223);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(475, 82);
            this.flowLayoutPanel8.TabIndex = 10;
            this.flowLayoutPanel8.WrapContents = false;
            // 
            // labelDescribe
            // 
            this.labelDescribe.Location = new System.Drawing.Point(0, 12);
            this.labelDescribe.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.labelDescribe.Name = "labelDescribe";
            this.labelDescribe.Size = new System.Drawing.Size(168, 58);
            this.labelDescribe.TabIndex = 4;
            this.labelDescribe.Text = "Mô tả sản phẩm";
            // 
            // richTextBoxProductDescribe
            // 
            this.richTextBoxProductDescribe.Location = new System.Drawing.Point(168, 12);
            this.richTextBoxProductDescribe.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.richTextBoxProductDescribe.Name = "richTextBoxProductDescribe";
            this.richTextBoxProductDescribe.Size = new System.Drawing.Size(307, 58);
            this.richTextBoxProductDescribe.TabIndex = 4;
            this.richTextBoxProductDescribe.Text = "";
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.AutoSize = true;
            this.flowLayoutPanel9.Controls.Add(this.labelProductStatus);
            this.flowLayoutPanel9.Controls.Add(this.comboBoxProductStatus);
            this.flowLayoutPanel9.Location = new System.Drawing.Point(3, 311);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(475, 50);
            this.flowLayoutPanel9.TabIndex = 11;
            this.flowLayoutPanel9.WrapContents = false;
            // 
            // labelProductStatus
            // 
            this.labelProductStatus.Location = new System.Drawing.Point(0, 12);
            this.labelProductStatus.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.labelProductStatus.Name = "labelProductStatus";
            this.labelProductStatus.Size = new System.Drawing.Size(168, 26);
            this.labelProductStatus.TabIndex = 6;
            this.labelProductStatus.Text = "Tình trạng sản phẩm";
            this.labelProductStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxProductStatus
            // 
            this.comboBoxProductStatus.FormattingEnabled = true;
            this.comboBoxProductStatus.Items.AddRange(new object[] {
            "Sản phẩm mới",
            "Sản phẩm cũ"});
            this.comboBoxProductStatus.Location = new System.Drawing.Point(168, 12);
            this.comboBoxProductStatus.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.comboBoxProductStatus.Name = "comboBoxProductStatus";
            this.comboBoxProductStatus.Size = new System.Drawing.Size(307, 26);
            this.comboBoxProductStatus.TabIndex = 5;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(57, 111);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(249, 24);
            this.textBoxProductName.TabIndex = 2;
            // 
            // labelProductName
            // 
            this.labelProductName.Location = new System.Drawing.Point(54, 77);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(252, 21);
            this.labelProductName.TabIndex = 1;
            this.labelProductName.Text = "Tên sản phẩm";
            this.labelProductName.Click += new System.EventHandler(this.labelProductName_Click);
            // 
            // pictureBoxProductImage
            // 
            this.pictureBoxProductImage.Image = global::MobileStoreManagement.Properties.Resources.online_store;
            this.pictureBoxProductImage.Location = new System.Drawing.Point(54, 149);
            this.pictureBoxProductImage.Name = "pictureBoxProductImage";
            this.pictureBoxProductImage.Size = new System.Drawing.Size(252, 284);
            this.pictureBoxProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProductImage.TabIndex = 0;
            this.pictureBoxProductImage.TabStop = false;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.labelWindowName);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(902, 48);
            this.flowLayoutPanel4.TabIndex = 3;
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
            // FormProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 553);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(920, 600);
            this.MinimumSize = new System.Drawing.Size(920, 600);
            this.Name = "FormProductDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mobile Manager";
            this.Load += new System.EventHandler(this.FormProductDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductImage)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSaveProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label labelProductPrice;
        private System.Windows.Forms.Label labelInventoryQuantity;
        private System.Windows.Forms.Label labelDescribe;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.PictureBox pictureBoxProductImage;
        private System.Windows.Forms.TextBox textBoxProductId;
        private System.Windows.Forms.TextBox textBoxProductPrice;
        private System.Windows.Forms.RichTextBox richTextBoxProductDescribe;
        private System.Windows.Forms.ComboBox comboBoxProductStatus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label labelWindowName;
        private System.Windows.Forms.Button buttonChangePicture;
        private System.Windows.Forms.ComboBox comboBoxSelectBrand;
        private System.Windows.Forms.ComboBox comboBoxSelectCategory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelProductId;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label labelProductCategoryId;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.Label labelProductStatus;
    }
}