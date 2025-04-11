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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddNewManufacturer = new System.Windows.Forms.Button();
            this.buttonAddNewProduct = new System.Windows.Forms.Button();
            this.buttonExportFile = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxGetKeyWordSearch = new System.Windows.Forms.TextBox();
            this.buttonSearchProduct = new System.Windows.Forms.Button();
            this.flowLayoutPanelProductList = new System.Windows.Forms.FlowLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ProductItemsPrimary = new MobileStoreManagement.UserControlProductItems();
            this.userControlProductItems2 = new MobileStoreManagement.UserControlProductItems();
            this.flowLayoutPanelLeft.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanelProductList.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Location = new System.Drawing.Point(3, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 232);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại hàng";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Điện thoại",
            "Sạc",
            "Tai nghe",
            "Phụ kiện"});
            this.checkedListBox1.Location = new System.Drawing.Point(10, 45);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(176, 157);
            this.checkedListBox1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkedListBox2);
            this.groupBox2.Location = new System.Drawing.Point(3, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 223);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hãng sản xuất";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Apple",
            "SamSung",
            "Oppo",
            "Vivo"});
            this.checkedListBox2.Location = new System.Drawing.Point(9, 38);
            this.checkedListBox2.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(176, 157);
            this.checkedListBox2.TabIndex = 8;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(200, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1163, 73);
            this.flowLayoutPanel2.TabIndex = 2;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.buttonAddNewManufacturer);
            this.flowLayoutPanel3.Controls.Add(this.buttonAddNewProduct);
            this.flowLayoutPanel3.Controls.Add(this.buttonExportFile);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(674, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(486, 70);
            this.flowLayoutPanel3.TabIndex = 3;
            this.flowLayoutPanel3.WrapContents = false;
            // 
            // buttonAddNewManufacturer
            // 
            this.buttonAddNewManufacturer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddNewManufacturer.Image = global::MobileStoreManagement.Properties.Resources.smartphone;
            this.buttonAddNewManufacturer.Location = new System.Drawing.Point(308, 11);
            this.buttonAddNewManufacturer.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.buttonAddNewManufacturer.Name = "buttonAddNewManufacturer";
            this.buttonAddNewManufacturer.Size = new System.Drawing.Size(166, 48);
            this.buttonAddNewManufacturer.TabIndex = 0;
            this.buttonAddNewManufacturer.Text = "Thêm hãng sản xuất";
            this.buttonAddNewManufacturer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddNewManufacturer.UseVisualStyleBackColor = true;
            // 
            // buttonAddNewProduct
            // 
            this.buttonAddNewProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddNewProduct.Image = global::MobileStoreManagement.Properties.Resources.plus;
            this.buttonAddNewProduct.Location = new System.Drawing.Point(136, 11);
            this.buttonAddNewProduct.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.buttonAddNewProduct.Name = "buttonAddNewProduct";
            this.buttonAddNewProduct.Size = new System.Drawing.Size(148, 48);
            this.buttonAddNewProduct.TabIndex = 1;
            this.buttonAddNewProduct.Text = "Thêm sản phẩm";
            this.buttonAddNewProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddNewProduct.UseVisualStyleBackColor = true;
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
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.textBoxGetKeyWordSearch);
            this.flowLayoutPanel1.Controls.Add(this.buttonSearchProduct);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(254, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(414, 70);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // textBoxGetKeyWordSearch
            // 
            this.textBoxGetKeyWordSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxGetKeyWordSearch.Location = new System.Drawing.Point(3, 24);
            this.textBoxGetKeyWordSearch.Name = "textBoxGetKeyWordSearch";
            this.textBoxGetKeyWordSearch.Size = new System.Drawing.Size(273, 22);
            this.textBoxGetKeyWordSearch.TabIndex = 1;
            // 
            // buttonSearchProduct
            // 
            this.buttonSearchProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSearchProduct.Image = global::MobileStoreManagement.Properties.Resources.search;
            this.buttonSearchProduct.Location = new System.Drawing.Point(291, 11);
            this.buttonSearchProduct.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.buttonSearchProduct.Name = "buttonSearchProduct";
            this.buttonSearchProduct.Size = new System.Drawing.Size(111, 48);
            this.buttonSearchProduct.TabIndex = 2;
            this.buttonSearchProduct.Text = "Tìm kiếm";
            this.buttonSearchProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSearchProduct.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelProductList
            // 
            this.flowLayoutPanelProductList.AutoScroll = true;
            this.flowLayoutPanelProductList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelProductList.Controls.Add(this.ProductItemsPrimary);
            this.flowLayoutPanelProductList.Controls.Add(this.userControlProductItems2);
            this.flowLayoutPanelProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelProductList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelProductList.Location = new System.Drawing.Point(200, 73);
            this.flowLayoutPanelProductList.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelProductList.Name = "flowLayoutPanelProductList";
            this.flowLayoutPanelProductList.Size = new System.Drawing.Size(1163, 627);
            this.flowLayoutPanelProductList.TabIndex = 3;
            this.flowLayoutPanelProductList.WrapContents = false;
            // 
            // ProductItemsPrimary
            // 
            this.ProductItemsPrimary.Location = new System.Drawing.Point(0, 0);
            this.ProductItemsPrimary.Margin = new System.Windows.Forms.Padding(0);
            this.ProductItemsPrimary.MaximumSize = new System.Drawing.Size(0, 100);
            this.ProductItemsPrimary.MinimumSize = new System.Drawing.Size(1500, 100);
            this.ProductItemsPrimary.Name = "ProductItemsPrimary";
            this.ProductItemsPrimary.Size = new System.Drawing.Size(1500, 100);
            this.ProductItemsPrimary.TabIndex = 0;
            // 
            // userControlProductItems2
            // 
            this.userControlProductItems2.Location = new System.Drawing.Point(0, 104);
            this.userControlProductItems2.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.userControlProductItems2.MaximumSize = new System.Drawing.Size(0, 100);
            this.userControlProductItems2.MinimumSize = new System.Drawing.Size(1500, 100);
            this.userControlProductItems2.Name = "userControlProductItems2";
            this.userControlProductItems2.Size = new System.Drawing.Size(1500, 100);
            this.userControlProductItems2.TabIndex = 1;
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
            this.Size = new System.Drawing.Size(1363, 700);
            this.Load += new System.EventHandler(this.UserControlProductManagement_Load);
            this.flowLayoutPanelLeft.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanelProductList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelLeft;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProductList;
        private UserControlProductItems ProductItemsPrimary;
        private UserControlProductItems userControlProductItems2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button buttonAddNewManufacturer;
        private System.Windows.Forms.Button buttonAddNewProduct;
        private System.Windows.Forms.Button buttonExportFile;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxGetKeyWordSearch;
        private System.Windows.Forms.Button buttonSearchProduct;
    }
}
