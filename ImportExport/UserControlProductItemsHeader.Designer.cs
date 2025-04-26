namespace MobileStoreManagement.ImportExport
{
    partial class UserControlProductItemsHeader
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
            this.labelNote = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelProductId);
            this.flowLayoutPanel1.Controls.Add(this.labelProductName);
            this.flowLayoutPanel1.Controls.Add(this.labelProductQuantity);
            this.flowLayoutPanel1.Controls.Add(this.labelNote);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(800, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // labelProductId
            // 
            this.labelProductId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelProductId.Location = new System.Drawing.Point(0, 0);
            this.labelProductId.Margin = new System.Windows.Forms.Padding(0);
            this.labelProductId.Name = "labelProductId";
            this.labelProductId.Size = new System.Drawing.Size(200, 100);
            this.labelProductId.TabIndex = 14;
            this.labelProductId.Text = "Mã sản phẩm";
            this.labelProductId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProductName
            // 
            this.labelProductName.Location = new System.Drawing.Point(203, 0);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(150, 100);
            this.labelProductName.TabIndex = 17;
            this.labelProductName.Text = "Tên sản phẩm";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProductQuantity
            // 
            this.labelProductQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelProductQuantity.Location = new System.Drawing.Point(359, 0);
            this.labelProductQuantity.Name = "labelProductQuantity";
            this.labelProductQuantity.Size = new System.Drawing.Size(150, 100);
            this.labelProductQuantity.TabIndex = 15;
            this.labelProductQuantity.Text = "Số lượng";
            this.labelProductQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNote
            // 
            this.labelNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNote.Location = new System.Drawing.Point(515, 0);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(150, 100);
            this.labelNote.TabIndex = 16;
            this.labelNote.Text = "Ghi chú";
            this.labelNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlDeliveryListHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UserControlDeliveryListHeader";
            this.Size = new System.Drawing.Size(800, 100);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelProductId;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelProductQuantity;
        private System.Windows.Forms.Label labelNote;
    }
}
