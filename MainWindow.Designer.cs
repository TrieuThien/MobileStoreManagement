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
            this.buttonToCustomerManagement = new System.Windows.Forms.Button();
            this.buttonToBillWindow = new System.Windows.Forms.Button();
            this.buttonToSellWindow = new System.Windows.Forms.Button();
            this.buttonToProductWindow = new System.Windows.Forms.Button();
            this.buttonToImportExportWindow = new System.Windows.Forms.Button();
            this.buttonToSupplierWindow = new System.Windows.Forms.Button();
            this.buttonToPromotionWindow = new System.Windows.Forms.Button();
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
            this.flowLayoutPanelFunctions.Controls.Add(this.buttonToCustomerManagement);
            this.flowLayoutPanelFunctions.Controls.Add(this.buttonToBillWindow);
            this.flowLayoutPanelFunctions.Controls.Add(this.buttonToSellWindow);
            this.flowLayoutPanelFunctions.Controls.Add(this.buttonToProductWindow);
            this.flowLayoutPanelFunctions.Controls.Add(this.buttonToImportExportWindow);
            this.flowLayoutPanelFunctions.Controls.Add(this.buttonToSupplierWindow);
            this.flowLayoutPanelFunctions.Controls.Add(this.buttonToPromotionWindow);
            this.flowLayoutPanelFunctions.Controls.Add(this.buttonToStaticticalWindow);
            this.flowLayoutPanelFunctions.Location = new System.Drawing.Point(0, 68);
            this.flowLayoutPanelFunctions.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelFunctions.Name = "flowLayoutPanelFunctions";
            this.flowLayoutPanelFunctions.Size = new System.Drawing.Size(1126, 68);
            this.flowLayoutPanelFunctions.TabIndex = 1;
            // 
            // buttonToCustomerManagement
            // 
            this.buttonToCustomerManagement.Image = ((System.Drawing.Image)(resources.GetObject("buttonToCustomerManagement.Image")));
            this.buttonToCustomerManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonToCustomerManagement.Location = new System.Drawing.Point(3, 14);
            this.buttonToCustomerManagement.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.buttonToCustomerManagement.Name = "buttonToCustomerManagement";
            this.buttonToCustomerManagement.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonToCustomerManagement.Size = new System.Drawing.Size(125, 40);
            this.buttonToCustomerManagement.TabIndex = 0;
            this.buttonToCustomerManagement.Text = "Khách hàng";
            this.buttonToCustomerManagement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonToCustomerManagement.UseVisualStyleBackColor = true;
            // 
            // buttonToBillWindow
            // 
            this.buttonToBillWindow.Image = global::MobileStoreManagement.Properties.Resources.bill_icon;
            this.buttonToBillWindow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonToBillWindow.Location = new System.Drawing.Point(134, 14);
            this.buttonToBillWindow.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.buttonToBillWindow.Name = "buttonToBillWindow";
            this.buttonToBillWindow.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonToBillWindow.Size = new System.Drawing.Size(110, 40);
            this.buttonToBillWindow.TabIndex = 1;
            this.buttonToBillWindow.Text = "Hóa đơn";
            this.buttonToBillWindow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonToBillWindow.UseVisualStyleBackColor = true;
            // 
            // buttonToSellWindow
            // 
            this.buttonToSellWindow.Image = global::MobileStoreManagement.Properties.Resources.sell_icon;
            this.buttonToSellWindow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonToSellWindow.Location = new System.Drawing.Point(250, 14);
            this.buttonToSellWindow.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.buttonToSellWindow.Name = "buttonToSellWindow";
            this.buttonToSellWindow.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonToSellWindow.Size = new System.Drawing.Size(110, 40);
            this.buttonToSellWindow.TabIndex = 2;
            this.buttonToSellWindow.Text = "Bán hàng";
            this.buttonToSellWindow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonToSellWindow.UseVisualStyleBackColor = true;
            // 
            // buttonToProductWindow
            // 
            this.buttonToProductWindow.Image = global::MobileStoreManagement.Properties.Resources.product_icon;
            this.buttonToProductWindow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonToProductWindow.Location = new System.Drawing.Point(366, 14);
            this.buttonToProductWindow.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.buttonToProductWindow.Name = "buttonToProductWindow";
            this.buttonToProductWindow.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonToProductWindow.Size = new System.Drawing.Size(118, 40);
            this.buttonToProductWindow.TabIndex = 3;
            this.buttonToProductWindow.Text = "Sản phẩm";
            this.buttonToProductWindow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonToProductWindow.UseVisualStyleBackColor = true;
            // 
            // buttonToImportExportWindow
            // 
            this.buttonToImportExportWindow.Image = global::MobileStoreManagement.Properties.Resources.ImportSuport_icon;
            this.buttonToImportExportWindow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonToImportExportWindow.Location = new System.Drawing.Point(490, 14);
            this.buttonToImportExportWindow.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.buttonToImportExportWindow.Name = "buttonToImportExportWindow";
            this.buttonToImportExportWindow.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonToImportExportWindow.Size = new System.Drawing.Size(151, 40);
            this.buttonToImportExportWindow.TabIndex = 4;
            this.buttonToImportExportWindow.Text = "Xuất nhập hàng";
            this.buttonToImportExportWindow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonToImportExportWindow.UseVisualStyleBackColor = true;
            // 
            // buttonToSupplierWindow
            // 
            this.buttonToSupplierWindow.Image = global::MobileStoreManagement.Properties.Resources.supplier_icon;
            this.buttonToSupplierWindow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonToSupplierWindow.Location = new System.Drawing.Point(647, 14);
            this.buttonToSupplierWindow.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.buttonToSupplierWindow.Name = "buttonToSupplierWindow";
            this.buttonToSupplierWindow.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonToSupplierWindow.Size = new System.Drawing.Size(137, 40);
            this.buttonToSupplierWindow.TabIndex = 5;
            this.buttonToSupplierWindow.Text = "Nhà cung cấp";
            this.buttonToSupplierWindow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonToSupplierWindow.UseVisualStyleBackColor = true;
            // 
            // buttonToPromotionWindow
            // 
            this.buttonToPromotionWindow.Image = global::MobileStoreManagement.Properties.Resources.promotion_icon;
            this.buttonToPromotionWindow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonToPromotionWindow.Location = new System.Drawing.Point(790, 14);
            this.buttonToPromotionWindow.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.buttonToPromotionWindow.Name = "buttonToPromotionWindow";
            this.buttonToPromotionWindow.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonToPromotionWindow.Size = new System.Drawing.Size(125, 40);
            this.buttonToPromotionWindow.TabIndex = 6;
            this.buttonToPromotionWindow.Text = "Khuyến mãi";
            this.buttonToPromotionWindow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonToPromotionWindow.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button buttonToCustomerManagement;
        private System.Windows.Forms.Button buttonToBillWindow;
        private System.Windows.Forms.Button buttonToSellWindow;
        private System.Windows.Forms.Button buttonToProductWindow;
        private System.Windows.Forms.Button buttonToImportExportWindow;
        private System.Windows.Forms.Button buttonToSupplierWindow;
        private System.Windows.Forms.Button buttonToPromotionWindow;
        private System.Windows.Forms.Button buttonToStaticticalWindow;
    }
}

