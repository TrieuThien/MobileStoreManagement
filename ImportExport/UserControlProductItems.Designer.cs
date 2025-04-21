namespace MobileStoreManagement.ImportExport
{
    partial class UserControlProductItems
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
            this.textBoxGetQuantity = new System.Windows.Forms.TextBox();
            this.textBoxGetNote = new System.Windows.Forms.TextBox();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelProductId);
            this.flowLayoutPanel1.Controls.Add(this.labelProductName);
            this.flowLayoutPanel1.Controls.Add(this.textBoxGetQuantity);
            this.flowLayoutPanel1.Controls.Add(this.textBoxGetNote);
            this.flowLayoutPanel1.Controls.Add(this.buttonDeleteProduct);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(800, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(835, 100);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.WrapContents = false;
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
            // textBoxGetQuantity
            // 
            this.textBoxGetQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGetQuantity.Location = new System.Drawing.Point(366, 38);
            this.textBoxGetQuantity.Margin = new System.Windows.Forms.Padding(10, 38, 10, 38);
            this.textBoxGetQuantity.Name = "textBoxGetQuantity";
            this.textBoxGetQuantity.Size = new System.Drawing.Size(130, 24);
            this.textBoxGetQuantity.TabIndex = 18;
            // 
            // textBoxGetNote
            // 
            this.textBoxGetNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGetNote.Location = new System.Drawing.Point(516, 38);
            this.textBoxGetNote.Margin = new System.Windows.Forms.Padding(10, 38, 10, 38);
            this.textBoxGetNote.Multiline = true;
            this.textBoxGetNote.Name = "textBoxGetNote";
            this.textBoxGetNote.Size = new System.Drawing.Size(130, 22);
            this.textBoxGetNote.TabIndex = 19;
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteProduct.Image = global::MobileStoreManagement.Properties.Resources.bin;
            this.buttonDeleteProduct.Location = new System.Drawing.Point(704, 30);
            this.buttonDeleteProduct.Margin = new System.Windows.Forms.Padding(48, 30, 12, 30);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(100, 40);
            this.buttonDeleteProduct.TabIndex = 20;
            this.buttonDeleteProduct.Text = "Xóa";
            this.buttonDeleteProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // UserControlDeliveryInvoiceItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(835, 100);
            this.Name = "UserControlDeliveryInvoiceItems";
            this.Size = new System.Drawing.Size(835, 100);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelProductId;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.TextBox textBoxGetQuantity;
        private System.Windows.Forms.TextBox textBoxGetNote;
        private System.Windows.Forms.Button buttonDeleteProduct;
    }
}
