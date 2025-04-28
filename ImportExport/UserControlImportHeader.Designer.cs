namespace MobileStoreManagement.ImportExport
{
    partial class UserControlImportHeader
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
            this.labelProductId = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelProductQuantity = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelProductId);
            this.flowLayoutPanel1.Controls.Add(this.labelProductName);
            this.flowLayoutPanel1.Controls.Add(this.labelProductQuantity);
            this.flowLayoutPanel1.Controls.Add(this.labelPrice);
            this.flowLayoutPanel1.Controls.Add(this.labelTotalPrice);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(850, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(849, 100);
            this.flowLayoutPanel1.TabIndex = 4;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // labelProductId
            // 
            this.labelProductId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelProductId.Location = new System.Drawing.Point(0, 0);
            this.labelProductId.Margin = new System.Windows.Forms.Padding(0);
            this.labelProductId.Name = "labelProductId";
            this.labelProductId.Size = new System.Drawing.Size(200, 100);
            this.labelProductId.TabIndex = 0;
            this.labelProductId.Text = "Mã sản phẩm";
            this.labelProductId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProductName
            // 
            this.labelProductName.Location = new System.Drawing.Point(203, 0);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(150, 100);
            this.labelProductName.TabIndex = 9;
            this.labelProductName.Text = "Tên sản phẩm";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProductQuantity
            // 
            this.labelProductQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelProductQuantity.Location = new System.Drawing.Point(359, 0);
            this.labelProductQuantity.Name = "labelProductQuantity";
            this.labelProductQuantity.Size = new System.Drawing.Size(150, 100);
            this.labelProductQuantity.TabIndex = 2;
            this.labelProductQuantity.Text = "Số lượng";
            this.labelProductQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPrice.Location = new System.Drawing.Point(515, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(150, 100);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.Text = "Giá";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTotalPrice.Location = new System.Drawing.Point(671, 0);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(150, 100);
            this.labelTotalPrice.TabIndex = 5;
            this.labelTotalPrice.Text = "Thành tiền";
            this.labelTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlImportHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(850, 100);
            this.Name = "UserControlImportHeader";
            this.Size = new System.Drawing.Size(850, 100);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelProductId;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelProductQuantity;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label labelPrice;
    }
}
