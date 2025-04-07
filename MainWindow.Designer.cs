namespace MobileStoreManagement
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.flowLayoutPanelHeader = new System.Windows.Forms.FlowLayoutPanel();
            this.labelApplicationName = new System.Windows.Forms.Label();
            this.flowLayoutPanelSystem = new System.Windows.Forms.FlowLayoutPanel();
            this.labelShowUserName = new System.Windows.Forms.Label();
            this.labelForSetting = new System.Windows.Forms.Label();
            this.labelForSuport = new System.Windows.Forms.Label();
            this.flowLayoutPanelFunctions = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonToCustomerManagementWindow = new System.Windows.Forms.Button();
            this.buttonToBillManagementWindow = new System.Windows.Forms.Button();
            this.buttonToSellManagementWindow = new System.Windows.Forms.Button();
            this.buttonToProductManagementWindow = new System.Windows.Forms.Button();
            this.buttonToImportExportManagementWindow = new System.Windows.Forms.Button();
            this.buttonToSupplierManagementWindow = new System.Windows.Forms.Button();
            this.buttonToPromotionManagementWindow = new System.Windows.Forms.Button();
            this.buttonToStaticticalWindow = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonToAccountWindow = new System.Windows.Forms.Button();
            this.buttonToSettingWindow = new System.Windows.Forms.Button();
            this.buttonToSuportWindow = new System.Windows.Forms.Button();
            this.flowLayoutPanelHeader.SuspendLayout();
            this.flowLayoutPanelSystem.SuspendLayout();
            this.flowLayoutPanelFunctions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelHeader
            // 
            this.flowLayoutPanelHeader.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelHeader.Controls.Add(this.pictureBoxLogo);
            this.flowLayoutPanelHeader.Controls.Add(this.labelApplicationName);
            this.flowLayoutPanelHeader.Controls.Add(this.flowLayoutPanelSystem);
            this.flowLayoutPanelHeader.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelHeader.Name = "flowLayoutPanelHeader";
            this.flowLayoutPanelHeader.Size = new System.Drawing.Size(1126, 68);
            this.flowLayoutPanelHeader.TabIndex = 0;
            this.flowLayoutPanelHeader.WrapContents = false;
            // 
            // labelApplicationName
            // 
            this.labelApplicationName.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApplicationName.Location = new System.Drawing.Point(139, 8);
            this.labelApplicationName.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.labelApplicationName.Name = "labelApplicationName";
            this.labelApplicationName.Size = new System.Drawing.Size(225, 52);
            this.labelApplicationName.TabIndex = 2;
            this.labelApplicationName.Text = "Mobile Manager";
            this.labelApplicationName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanelSystem
            // 
            this.flowLayoutPanelSystem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanelSystem.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelSystem.Controls.Add(this.buttonToAccountWindow);
            this.flowLayoutPanelSystem.Controls.Add(this.labelShowUserName);
            this.flowLayoutPanelSystem.Controls.Add(this.labelForSetting);
            this.flowLayoutPanelSystem.Controls.Add(this.buttonToSettingWindow);
            this.flowLayoutPanelSystem.Controls.Add(this.labelForSuport);
            this.flowLayoutPanelSystem.Controls.Add(this.buttonToSuportWindow);
            this.flowLayoutPanelSystem.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelSystem.Location = new System.Drawing.Point(391, 0);
            this.flowLayoutPanelSystem.Margin = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.flowLayoutPanelSystem.Name = "flowLayoutPanelSystem";
            this.flowLayoutPanelSystem.Size = new System.Drawing.Size(735, 68);
            this.flowLayoutPanelSystem.TabIndex = 3;
            // 
            // labelShowUserName
            // 
            this.labelShowUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelShowUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowUserName.Location = new System.Drawing.Point(564, 10);
            this.labelShowUserName.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.labelShowUserName.Name = "labelShowUserName";
            this.labelShowUserName.Size = new System.Drawing.Size(112, 48);
            this.labelShowUserName.TabIndex = 1;
            this.labelShowUserName.Text = "Tên người dùng ";
            this.labelShowUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelShowUserName.Click += new System.EventHandler(this.labelShowUserName_Click);
            // 
            // labelForSetting
            // 
            this.labelForSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelForSetting.Location = new System.Drawing.Point(481, 18);
            this.labelForSetting.Margin = new System.Windows.Forms.Padding(0, 18, 24, 18);
            this.labelForSetting.Name = "labelForSetting";
            this.labelForSetting.Size = new System.Drawing.Size(59, 32);
            this.labelForSetting.TabIndex = 5;
            this.labelForSetting.Text = "Cài đặt";
            this.labelForSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelForSetting.Click += new System.EventHandler(this.labelForSetting_Click);
            // 
            // labelForSuport
            // 
            this.labelForSuport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelForSuport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForSuport.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelForSuport.Location = new System.Drawing.Point(361, 18);
            this.labelForSuport.Margin = new System.Windows.Forms.Padding(0, 18, 0, 18);
            this.labelForSuport.Name = "labelForSuport";
            this.labelForSuport.Size = new System.Drawing.Size(64, 32);
            this.labelForSuport.TabIndex = 4;
            this.labelForSuport.Text = "Hỗ trợ";
            this.labelForSuport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelForSuport.Click += new System.EventHandler(this.labelForSuport_Click);
            // 
            // flowLayoutPanelFunctions
            // 
            this.flowLayoutPanelFunctions.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.flowLayoutPanelFunctions.Controls.Add(this.buttonToCustomerManagementWindow);
            this.flowLayoutPanelFunctions.Controls.Add(this.buttonToBillManagementWindow);
            this.flowLayoutPanelFunctions.Controls.Add(this.buttonToSellManagementWindow);
            this.flowLayoutPanelFunctions.Controls.Add(this.buttonToProductManagementWindow);
            this.flowLayoutPanelFunctions.Controls.Add(this.buttonToImportExportManagementWindow);
            this.flowLayoutPanelFunctions.Controls.Add(this.buttonToSupplierManagementWindow);
            this.flowLayoutPanelFunctions.Controls.Add(this.buttonToPromotionManagementWindow);
            this.flowLayoutPanelFunctions.Controls.Add(this.buttonToStaticticalWindow);
            this.flowLayoutPanelFunctions.Location = new System.Drawing.Point(0, 68);
            this.flowLayoutPanelFunctions.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelFunctions.Name = "flowLayoutPanelFunctions";
            this.flowLayoutPanelFunctions.Size = new System.Drawing.Size(1126, 68);
            this.flowLayoutPanelFunctions.TabIndex = 1;
            // 
            // buttonToCustomerManagementWindow
            // 
            this.buttonToCustomerManagementWindow.Image = ((System.Drawing.Image)(resources.GetObject("buttonToCustomerManagementWindow.Image")));
            this.buttonToCustomerManagementWindow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonToCustomerManagementWindow.Location = new System.Drawing.Point(3, 14);
            this.buttonToCustomerManagementWindow.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.buttonToCustomerManagementWindow.Name = "buttonToCustomerManagementWindow";
            this.buttonToCustomerManagementWindow.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonToCustomerManagementWindow.Size = new System.Drawing.Size(125, 40);
            this.buttonToCustomerManagementWindow.TabIndex = 0;
            this.buttonToCustomerManagementWindow.Text = "Khách hàng";
            this.buttonToCustomerManagementWindow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonToCustomerManagementWindow.UseVisualStyleBackColor = true;
            // 
            // buttonToBillManagementWindow
            // 
            this.buttonToBillManagementWindow.Image = global::MobileStoreManagement.Properties.Resources.bill_icon;
            this.buttonToBillManagementWindow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonToBillManagementWindow.Location = new System.Drawing.Point(134, 14);
            this.buttonToBillManagementWindow.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.buttonToBillManagementWindow.Name = "buttonToBillManagementWindow";
            this.buttonToBillManagementWindow.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonToBillManagementWindow.Size = new System.Drawing.Size(110, 40);
            this.buttonToBillManagementWindow.TabIndex = 1;
            this.buttonToBillManagementWindow.Text = "Hóa đơn";
            this.buttonToBillManagementWindow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonToBillManagementWindow.UseVisualStyleBackColor = true;
            // 
            // buttonToSellManagementWindow
            // 
            this.buttonToSellManagementWindow.Image = global::MobileStoreManagement.Properties.Resources.sell_icon;
            this.buttonToSellManagementWindow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonToSellManagementWindow.Location = new System.Drawing.Point(250, 14);
            this.buttonToSellManagementWindow.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.buttonToSellManagementWindow.Name = "buttonToSellManagementWindow";
            this.buttonToSellManagementWindow.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonToSellManagementWindow.Size = new System.Drawing.Size(110, 40);
            this.buttonToSellManagementWindow.TabIndex = 2;
            this.buttonToSellManagementWindow.Text = "Bán hàng";
            this.buttonToSellManagementWindow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonToSellManagementWindow.UseVisualStyleBackColor = true;
            // 
            // buttonToProductManagementWindow
            // 
            this.buttonToProductManagementWindow.Image = global::MobileStoreManagement.Properties.Resources.product_icon;
            this.buttonToProductManagementWindow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonToProductManagementWindow.Location = new System.Drawing.Point(366, 14);
            this.buttonToProductManagementWindow.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.buttonToProductManagementWindow.Name = "buttonToProductManagementWindow";
            this.buttonToProductManagementWindow.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonToProductManagementWindow.Size = new System.Drawing.Size(118, 40);
            this.buttonToProductManagementWindow.TabIndex = 3;
            this.buttonToProductManagementWindow.Text = "Sản phẩm";
            this.buttonToProductManagementWindow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonToProductManagementWindow.UseVisualStyleBackColor = true;
            // 
            // buttonToImportExportManagementWindow
            // 
            this.buttonToImportExportManagementWindow.Image = global::MobileStoreManagement.Properties.Resources.ImportSuport_icon;
            this.buttonToImportExportManagementWindow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonToImportExportManagementWindow.Location = new System.Drawing.Point(490, 14);
            this.buttonToImportExportManagementWindow.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.buttonToImportExportManagementWindow.Name = "buttonToImportExportManagementWindow";
            this.buttonToImportExportManagementWindow.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonToImportExportManagementWindow.Size = new System.Drawing.Size(151, 40);
            this.buttonToImportExportManagementWindow.TabIndex = 4;
            this.buttonToImportExportManagementWindow.Text = "Xuất nhập hàng";
            this.buttonToImportExportManagementWindow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonToImportExportManagementWindow.UseVisualStyleBackColor = true;
            // 
            // buttonToSupplierManagementWindow
            // 
            this.buttonToSupplierManagementWindow.Image = global::MobileStoreManagement.Properties.Resources.supplier_icon;
            this.buttonToSupplierManagementWindow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonToSupplierManagementWindow.Location = new System.Drawing.Point(647, 14);
            this.buttonToSupplierManagementWindow.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.buttonToSupplierManagementWindow.Name = "buttonToSupplierManagementWindow";
            this.buttonToSupplierManagementWindow.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonToSupplierManagementWindow.Size = new System.Drawing.Size(137, 40);
            this.buttonToSupplierManagementWindow.TabIndex = 5;
            this.buttonToSupplierManagementWindow.Text = "Nhà cung cấp";
            this.buttonToSupplierManagementWindow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonToSupplierManagementWindow.UseVisualStyleBackColor = true;
            // 
            // buttonToPromotionManagementWindow
            // 
            this.buttonToPromotionManagementWindow.Image = global::MobileStoreManagement.Properties.Resources.promotion_icon;
            this.buttonToPromotionManagementWindow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonToPromotionManagementWindow.Location = new System.Drawing.Point(790, 14);
            this.buttonToPromotionManagementWindow.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.buttonToPromotionManagementWindow.Name = "buttonToPromotionManagementWindow";
            this.buttonToPromotionManagementWindow.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonToPromotionManagementWindow.Size = new System.Drawing.Size(125, 40);
            this.buttonToPromotionManagementWindow.TabIndex = 6;
            this.buttonToPromotionManagementWindow.Text = "Khuyến mãi";
            this.buttonToPromotionManagementWindow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonToPromotionManagementWindow.UseVisualStyleBackColor = true;
            // 
            // buttonToStaticticalWindow
            // 
            this.buttonToStaticticalWindow.Image = global::MobileStoreManagement.Properties.Resources.statistical_icon;
            this.buttonToStaticticalWindow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonToStaticticalWindow.Location = new System.Drawing.Point(921, 14);
            this.buttonToStaticticalWindow.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.buttonToStaticticalWindow.Name = "buttonToStaticticalWindow";
            this.buttonToStaticticalWindow.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonToStaticticalWindow.Size = new System.Drawing.Size(112, 40);
            this.buttonToStaticticalWindow.TabIndex = 7;
            this.buttonToStaticticalWindow.Text = "Thống kê";
            this.buttonToStaticticalWindow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonToStaticticalWindow.UseVisualStyleBackColor = true;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::MobileStoreManagement.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(27, 8);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(27, 8, 0, 8);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(112, 52);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonToAccountWindow
            // 
            this.buttonToAccountWindow.BackColor = System.Drawing.Color.White;
            this.buttonToAccountWindow.BackgroundImage = global::MobileStoreManagement.Properties.Resources.account_icon;
            this.buttonToAccountWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonToAccountWindow.Location = new System.Drawing.Point(676, 18);
            this.buttonToAccountWindow.Margin = new System.Windows.Forms.Padding(0, 18, 27, 18);
            this.buttonToAccountWindow.Name = "buttonToAccountWindow";
            this.buttonToAccountWindow.Size = new System.Drawing.Size(32, 32);
            this.buttonToAccountWindow.TabIndex = 0;
            this.buttonToAccountWindow.UseVisualStyleBackColor = false;
            // 
            // buttonToSettingWindow
            // 
            this.buttonToSettingWindow.BackgroundImage = global::MobileStoreManagement.Properties.Resources.setting_icon;
            this.buttonToSettingWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonToSettingWindow.Location = new System.Drawing.Point(449, 18);
            this.buttonToSettingWindow.Margin = new System.Windows.Forms.Padding(24, 18, 0, 18);
            this.buttonToSettingWindow.Name = "buttonToSettingWindow";
            this.buttonToSettingWindow.Size = new System.Drawing.Size(32, 32);
            this.buttonToSettingWindow.TabIndex = 2;
            this.buttonToSettingWindow.UseVisualStyleBackColor = true;
            // 
            // buttonToSuportWindow
            // 
            this.buttonToSuportWindow.BackgroundImage = global::MobileStoreManagement.Properties.Resources.support_icon;
            this.buttonToSuportWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonToSuportWindow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonToSuportWindow.Location = new System.Drawing.Point(326, 18);
            this.buttonToSuportWindow.Margin = new System.Windows.Forms.Padding(3, 18, 3, 18);
            this.buttonToSuportWindow.Name = "buttonToSuportWindow";
            this.buttonToSuportWindow.Size = new System.Drawing.Size(32, 32);
            this.buttonToSuportWindow.TabIndex = 3;
            this.buttonToSuportWindow.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 532);
            this.Controls.Add(this.flowLayoutPanelFunctions);
            this.Controls.Add(this.flowLayoutPanelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1136, 579);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mobile Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.flowLayoutPanelHeader.ResumeLayout(false);
            this.flowLayoutPanelSystem.ResumeLayout(false);
            this.flowLayoutPanelFunctions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHeader;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelApplicationName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSystem;
        private System.Windows.Forms.Button buttonToAccountWindow;
        private System.Windows.Forms.Label labelShowUserName;
        private System.Windows.Forms.Button buttonToSettingWindow;
        private System.Windows.Forms.Button buttonToSuportWindow;
        private System.Windows.Forms.Label labelForSuport;
        private System.Windows.Forms.Label labelForSetting;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFunctions;
        private System.Windows.Forms.Button buttonToCustomerManagementWindow;
        private System.Windows.Forms.Button buttonToBillManagementWindow;
        private System.Windows.Forms.Button buttonToSellManagementWindow;
        private System.Windows.Forms.Button buttonToProductManagementWindow;
        private System.Windows.Forms.Button buttonToImportExportManagementWindow;
        private System.Windows.Forms.Button buttonToSupplierManagementWindow;
        private System.Windows.Forms.Button buttonToPromotionManagementWindow;
        private System.Windows.Forms.Button buttonToStaticticalWindow;
    }
}

