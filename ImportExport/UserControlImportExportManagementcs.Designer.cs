namespace MobileStoreManagement
{
    partial class UserControlImportExportManagementcs
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonImportProduct = new System.Windows.Forms.Button();
            this.buttonExportProduct = new System.Windows.Forms.Button();
            this.buttonDeliveryNote = new System.Windows.Forms.Button();
            this.buttonOrderSuplier = new System.Windows.Forms.Button();
            this.buttonPaying = new System.Windows.Forms.Button();
            this.buttonGetOldProduct = new System.Windows.Forms.Button();
            this.panelFunctions = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.buttonImportProduct);
            this.flowLayoutPanel1.Controls.Add(this.buttonExportProduct);
            this.flowLayoutPanel1.Controls.Add(this.buttonDeliveryNote);
            this.flowLayoutPanel1.Controls.Add(this.buttonOrderSuplier);
            this.flowLayoutPanel1.Controls.Add(this.buttonPaying);
            this.flowLayoutPanel1.Controls.Add(this.buttonGetOldProduct);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(220, 700);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // buttonImportProduct
            // 
            this.buttonImportProduct.Image = global::MobileStoreManagement.Properties.Resources.import;
            this.buttonImportProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonImportProduct.Location = new System.Drawing.Point(20, 12);
            this.buttonImportProduct.Margin = new System.Windows.Forms.Padding(20, 12, 20, 12);
            this.buttonImportProduct.Name = "buttonImportProduct";
            this.buttonImportProduct.Size = new System.Drawing.Size(180, 50);
            this.buttonImportProduct.TabIndex = 0;
            this.buttonImportProduct.Text = "Nhập kho";
            this.buttonImportProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonImportProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonImportProduct.UseVisualStyleBackColor = true;
            this.buttonImportProduct.Click += new System.EventHandler(this.buttonImportProduct_Click);
            // 
            // buttonExportProduct
            // 
            this.buttonExportProduct.Image = global::MobileStoreManagement.Properties.Resources.upload;
            this.buttonExportProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExportProduct.Location = new System.Drawing.Point(20, 86);
            this.buttonExportProduct.Margin = new System.Windows.Forms.Padding(20, 12, 20, 12);
            this.buttonExportProduct.Name = "buttonExportProduct";
            this.buttonExportProduct.Size = new System.Drawing.Size(180, 50);
            this.buttonExportProduct.TabIndex = 1;
            this.buttonExportProduct.Text = "Xuất kho ";
            this.buttonExportProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExportProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExportProduct.UseVisualStyleBackColor = true;
            this.buttonExportProduct.Click += new System.EventHandler(this.buttonExportProduct_Click);
            // 
            // buttonDeliveryNote
            // 
            this.buttonDeliveryNote.Image = global::MobileStoreManagement.Properties.Resources.road;
            this.buttonDeliveryNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeliveryNote.Location = new System.Drawing.Point(20, 160);
            this.buttonDeliveryNote.Margin = new System.Windows.Forms.Padding(20, 12, 20, 12);
            this.buttonDeliveryNote.Name = "buttonDeliveryNote";
            this.buttonDeliveryNote.Size = new System.Drawing.Size(180, 50);
            this.buttonDeliveryNote.TabIndex = 2;
            this.buttonDeliveryNote.Text = "Quản lý phiếu giao hàng";
            this.buttonDeliveryNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeliveryNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDeliveryNote.UseVisualStyleBackColor = true;
            // 
            // buttonOrderSuplier
            // 
            this.buttonOrderSuplier.Image = global::MobileStoreManagement.Properties.Resources.checkout;
            this.buttonOrderSuplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrderSuplier.Location = new System.Drawing.Point(20, 234);
            this.buttonOrderSuplier.Margin = new System.Windows.Forms.Padding(20, 12, 20, 12);
            this.buttonOrderSuplier.Name = "buttonOrderSuplier";
            this.buttonOrderSuplier.Size = new System.Drawing.Size(180, 50);
            this.buttonOrderSuplier.TabIndex = 3;
            this.buttonOrderSuplier.Text = "Đặt hàng NCC";
            this.buttonOrderSuplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrderSuplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOrderSuplier.UseVisualStyleBackColor = true;
            // 
            // buttonPaying
            // 
            this.buttonPaying.Image = global::MobileStoreManagement.Properties.Resources.cash_on_delivery;
            this.buttonPaying.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPaying.Location = new System.Drawing.Point(20, 308);
            this.buttonPaying.Margin = new System.Windows.Forms.Padding(20, 12, 20, 12);
            this.buttonPaying.Name = "buttonPaying";
            this.buttonPaying.Size = new System.Drawing.Size(180, 50);
            this.buttonPaying.TabIndex = 4;
            this.buttonPaying.Text = "Thanh toán đơn nhập";
            this.buttonPaying.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPaying.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPaying.UseVisualStyleBackColor = true;
            // 
            // buttonGetOldProduct
            // 
            this.buttonGetOldProduct.Image = global::MobileStoreManagement.Properties.Resources.delivery_box;
            this.buttonGetOldProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGetOldProduct.Location = new System.Drawing.Point(20, 382);
            this.buttonGetOldProduct.Margin = new System.Windows.Forms.Padding(20, 12, 20, 12);
            this.buttonGetOldProduct.Name = "buttonGetOldProduct";
            this.buttonGetOldProduct.Size = new System.Drawing.Size(180, 50);
            this.buttonGetOldProduct.TabIndex = 5;
            this.buttonGetOldProduct.Text = "Thu cũ sản phẩm";
            this.buttonGetOldProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGetOldProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGetOldProduct.UseVisualStyleBackColor = true;
            // 
            // panelFunctions
            // 
            this.panelFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFunctions.Location = new System.Drawing.Point(220, 0);
            this.panelFunctions.Name = "panelFunctions";
            this.panelFunctions.Size = new System.Drawing.Size(803, 700);
            this.panelFunctions.TabIndex = 1;
            // 
            // UserControlImportExportManagementcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelFunctions);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(830, 700);
            this.Name = "UserControlImportExportManagementcs";
            this.Size = new System.Drawing.Size(1023, 700);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonImportProduct;
        private System.Windows.Forms.Button buttonExportProduct;
        private System.Windows.Forms.Panel panelFunctions;
        private System.Windows.Forms.Button buttonDeliveryNote;
        private System.Windows.Forms.Button buttonOrderSuplier;
        private System.Windows.Forms.Button buttonPaying;
        private System.Windows.Forms.Button buttonGetOldProduct;
    }
}
