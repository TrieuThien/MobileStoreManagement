namespace MobileStoreManagement
{
    partial class UserControlProductManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanelLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.labelProduct = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedLbPdCategories = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkedLbBrandCategories = new System.Windows.Forms.CheckedListBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddNewProduct = new System.Windows.Forms.Button();
            this.buttonAddNewProductCategory = new System.Windows.Forms.Button();
            this.buttonAddNewManufacturer = new System.Windows.Forms.Button();
            this.buttonExportFile = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxGetKeyWordSearch = new System.Windows.Forms.TextBox();
            this.buttonSearchProduct = new System.Windows.Forms.Button();
            this.flowLayoutPanelProductList = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelLeft.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelLeft
            // 
            this.flowLayoutPanelLeft.Controls.Add(this.labelProduct);
            this.flowLayoutPanelLeft.Controls.Add(this.groupBox1);
            this.flowLayoutPanelLeft.Controls.Add(this.groupBox2);
            this.flowLayoutPanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelLeft.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelLeft.Name = "flowLayoutPanelLeft";
            this.flowLayoutPanelLeft.Size = new System.Drawing.Size(200, 700);
            this.flowLayoutPanelLeft.TabIndex = 0;
            // 
            // labelProduct
            // 
            this.labelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduct.Location = new System.Drawing.Point(3, 0);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(197, 73);
            this.labelProduct.TabIndex = 0;
            this.labelProduct.Text = "Sản phẩm";
            this.labelProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedLbPdCategories);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 273);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục hàng hóa";
            // 
            // checkedLbPdCategories
            // 
            this.checkedLbPdCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedLbPdCategories.FormattingEnabled = true;
            this.checkedLbPdCategories.Location = new System.Drawing.Point(9, 45);
            this.checkedLbPdCategories.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.checkedLbPdCategories.Name = "checkedLbPdCategories";
            this.checkedLbPdCategories.Size = new System.Drawing.Size(176, 202);
            this.checkedLbPdCategories.TabIndex = 7;
            this.checkedLbPdCategories.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedLbPdCategories_ItemCheck);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkedLbBrandCategories);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 315);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thương hiệu";
            // 
            // checkedLbBrandCategories
            // 
            this.checkedLbBrandCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedLbBrandCategories.FormattingEnabled = true;
            this.checkedLbBrandCategories.Location = new System.Drawing.Point(9, 38);
            this.checkedLbBrandCategories.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.checkedLbBrandCategories.Name = "checkedLbBrandCategories";
            this.checkedLbBrandCategories.Size = new System.Drawing.Size(176, 246);
            this.checkedLbBrandCategories.TabIndex = 8;
            this.checkedLbBrandCategories.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedLbBrandCategories_ItemCheck);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(200, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1650, 72);
            this.flowLayoutPanel2.TabIndex = 2;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.buttonAddNewProduct);
            this.flowLayoutPanel3.Controls.Add(this.buttonAddNewProductCategory);
            this.flowLayoutPanel3.Controls.Add(this.buttonAddNewManufacturer);
            this.flowLayoutPanel3.Controls.Add(this.buttonExportFile);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(1034, 0);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(616, 72);
            this.flowLayoutPanel3.TabIndex = 3;
            this.flowLayoutPanel3.WrapContents = false;
            // 
            // buttonAddNewProduct
            // 
            this.buttonAddNewProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddNewProduct.Image = global::MobileStoreManagement.Properties.Resources.plus;
            this.buttonAddNewProduct.Location = new System.Drawing.Point(437, 11);
            this.buttonAddNewProduct.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.buttonAddNewProduct.Name = "buttonAddNewProduct";
            this.buttonAddNewProduct.Size = new System.Drawing.Size(167, 48);
            this.buttonAddNewProduct.TabIndex = 1;
            this.buttonAddNewProduct.Text = "Thêm sản phẩm";
            this.buttonAddNewProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddNewProduct.UseVisualStyleBackColor = true;
            this.buttonAddNewProduct.Click += new System.EventHandler(this.buttonAddNewProduct_Click);
            // 
            // buttonAddNewProductCategory
            // 
            this.buttonAddNewProductCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddNewProductCategory.Location = new System.Drawing.Point(291, 11);
            this.buttonAddNewProductCategory.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.buttonAddNewProductCategory.Name = "buttonAddNewProductCategory";
            this.buttonAddNewProductCategory.Size = new System.Drawing.Size(122, 48);
            this.buttonAddNewProductCategory.TabIndex = 3;
            this.buttonAddNewProductCategory.Text = "Quản lý danh mục";
            this.buttonAddNewProductCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddNewProductCategory.UseVisualStyleBackColor = true;
            this.buttonAddNewProductCategory.Click += new System.EventHandler(this.buttonAddNewProductCategory_Click);
            // 
            // buttonAddNewManufacturer
            // 
            this.buttonAddNewManufacturer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddNewManufacturer.Image = global::MobileStoreManagement.Properties.Resources.smartphone;
            this.buttonAddNewManufacturer.Location = new System.Drawing.Point(136, 11);
            this.buttonAddNewManufacturer.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.buttonAddNewManufacturer.Name = "buttonAddNewManufacturer";
            this.buttonAddNewManufacturer.Size = new System.Drawing.Size(131, 48);
            this.buttonAddNewManufacturer.TabIndex = 0;
            this.buttonAddNewManufacturer.Text = "Quản lý thương hiệu";
            this.buttonAddNewManufacturer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddNewManufacturer.UseVisualStyleBackColor = true;
            this.buttonAddNewManufacturer.Click += new System.EventHandler(this.buttonAddNewManufacturer_Click);
            // 
            // buttonExportFile
            // 
            this.buttonExportFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExportFile.Image = global::MobileStoreManagement.Properties.Resources.export;
            this.buttonExportFile.Location = new System.Drawing.Point(12, 11);
            this.buttonExportFile.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.buttonExportFile.Name = "buttonExportFile";
            this.buttonExportFile.Size = new System.Drawing.Size(100, 48);
            this.buttonExportFile.TabIndex = 2;
            this.buttonExportFile.Text = "Xuất file";
            this.buttonExportFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExportFile.UseVisualStyleBackColor = true;
            this.buttonExportFile.Click += new System.EventHandler(this.buttonExportFile_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.Controls.Add(this.buttonSearchProduct);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(621, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(413, 72);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.labelSearch);
            this.flowLayoutPanel4.Controls.Add(this.textBoxGetKeyWordSearch);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(278, 72);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // labelSearch
            // 
            this.labelSearch.Location = new System.Drawing.Point(0, 9);
            this.labelSearch.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(280, 24);
            this.labelSearch.TabIndex = 2;
            this.labelSearch.Text = "Tìm kiếm theo mã, tên sản phẩm";
            this.labelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSearch.Click += new System.EventHandler(this.labelSearch_Click);
            // 
            // textBoxGetKeyWordSearch
            // 
            this.textBoxGetKeyWordSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxGetKeyWordSearch.Location = new System.Drawing.Point(0, 33);
            this.textBoxGetKeyWordSearch.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxGetKeyWordSearch.Name = "textBoxGetKeyWordSearch";
            this.textBoxGetKeyWordSearch.Size = new System.Drawing.Size(280, 22);
            this.textBoxGetKeyWordSearch.TabIndex = 1;
            // 
            // buttonSearchProduct
            // 
            this.buttonSearchProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSearchProduct.Image = global::MobileStoreManagement.Properties.Resources.search;
            this.buttonSearchProduct.Location = new System.Drawing.Point(290, 12);
            this.buttonSearchProduct.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.buttonSearchProduct.Name = "buttonSearchProduct";
            this.buttonSearchProduct.Size = new System.Drawing.Size(111, 48);
            this.buttonSearchProduct.TabIndex = 2;
            this.buttonSearchProduct.Text = "Tìm kiếm";
            this.buttonSearchProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSearchProduct.UseVisualStyleBackColor = true;
            this.buttonSearchProduct.Click += new System.EventHandler(this.buttonSearchProduct_Click);
            // 
            // flowLayoutPanelProductList
            // 
            this.flowLayoutPanelProductList.AutoScroll = true;
            this.flowLayoutPanelProductList.AutoSize = true;
            this.flowLayoutPanelProductList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelProductList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelProductList.Location = new System.Drawing.Point(200, 72);
            this.flowLayoutPanelProductList.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelProductList.Name = "flowLayoutPanelProductList";
            this.flowLayoutPanelProductList.Size = new System.Drawing.Size(1650, 628);
            this.flowLayoutPanelProductList.TabIndex = 3;
            this.flowLayoutPanelProductList.WrapContents = false;
            // 
            // UserControlProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.flowLayoutPanelProductList);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanelLeft);
            this.Margin = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.MinimumSize = new System.Drawing.Size(830, 700);
            this.Name = "UserControlProductManagement";
            this.Size = new System.Drawing.Size(1850, 700);
            this.Load += new System.EventHandler(this.UserControlProductManagement_Load);
            this.flowLayoutPanelLeft.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelLeft;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.CheckedListBox checkedLbBrandCategories;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProductList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedLbPdCategories;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button buttonAddNewManufacturer;
        private System.Windows.Forms.Button buttonAddNewProduct;
        private System.Windows.Forms.Button buttonExportFile;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxGetKeyWordSearch;
        private System.Windows.Forms.Button buttonSearchProduct;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button buttonAddNewProductCategory;
    }
}
