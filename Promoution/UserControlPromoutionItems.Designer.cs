namespace MobileStoreManagement
{
    partial class UserControlPromoutionItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlPromoutionItems));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelPromoutionName = new System.Windows.Forms.Label();
            this.labelPromotionDes = new System.Windows.Forms.Label();
            this.labelFromDate = new System.Windows.Forms.Label();
            this.labelToDate = new System.Windows.Forms.Label();
            this.labelForm = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonDeactivePromoution = new System.Windows.Forms.Button();
            this.buttonActivePromoution = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelPromoutionName);
            this.flowLayoutPanel1.Controls.Add(this.labelPromotionDes);
            this.flowLayoutPanel1.Controls.Add(this.labelFromDate);
            this.flowLayoutPanel1.Controls.Add(this.labelToDate);
            this.flowLayoutPanel1.Controls.Add(this.labelForm);
            this.flowLayoutPanel1.Controls.Add(this.labelStatus);
            this.flowLayoutPanel1.Controls.Add(this.buttonDeactivePromoution);
            this.flowLayoutPanel1.Controls.Add(this.buttonActivePromoution);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(1700, 100);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(1700, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1700, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // labelPromoutionName
            // 
            this.labelPromoutionName.Location = new System.Drawing.Point(12, 0);
            this.labelPromoutionName.Margin = new System.Windows.Forms.Padding(12, 0, 3, 0);
            this.labelPromoutionName.Name = "labelPromoutionName";
            this.labelPromoutionName.Size = new System.Drawing.Size(200, 100);
            this.labelPromoutionName.TabIndex = 0;
            this.labelPromoutionName.Text = "Tên khuyến mãi";
            this.labelPromoutionName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPromotionDes
            // 
            this.labelPromotionDes.Location = new System.Drawing.Point(218, 0);
            this.labelPromotionDes.Name = "labelPromotionDes";
            this.labelPromotionDes.Size = new System.Drawing.Size(200, 100);
            this.labelPromotionDes.TabIndex = 1;
            this.labelPromotionDes.Text = "Mô tả";
            this.labelPromotionDes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFromDate
            // 
            this.labelFromDate.Location = new System.Drawing.Point(424, 0);
            this.labelFromDate.Name = "labelFromDate";
            this.labelFromDate.Size = new System.Drawing.Size(200, 100);
            this.labelFromDate.TabIndex = 2;
            this.labelFromDate.Text = "Ngày bắt đầu";
            this.labelFromDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelToDate
            // 
            this.labelToDate.Location = new System.Drawing.Point(630, 0);
            this.labelToDate.Name = "labelToDate";
            this.labelToDate.Size = new System.Drawing.Size(200, 100);
            this.labelToDate.TabIndex = 3;
            this.labelToDate.Text = "Ngày kết thúc";
            this.labelToDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelForm
            // 
            this.labelForm.Location = new System.Drawing.Point(836, 0);
            this.labelForm.Name = "labelForm";
            this.labelForm.Size = new System.Drawing.Size(200, 100);
            this.labelForm.TabIndex = 4;
            this.labelForm.Text = "Hình thức";
            this.labelForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStatus
            // 
            this.labelStatus.Location = new System.Drawing.Point(1042, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(150, 100);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Trạng thái";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDeactivePromoution
            // 
            this.buttonDeactivePromoution.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeactivePromoution.Image")));
            this.buttonDeactivePromoution.Location = new System.Drawing.Point(1243, 30);
            this.buttonDeactivePromoution.Margin = new System.Windows.Forms.Padding(48, 30, 12, 30);
            this.buttonDeactivePromoution.Name = "buttonDeactivePromoution";
            this.buttonDeactivePromoution.Size = new System.Drawing.Size(159, 40);
            this.buttonDeactivePromoution.TabIndex = 6;
            this.buttonDeactivePromoution.Text = "Dừng áp dụng";
            this.buttonDeactivePromoution.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDeactivePromoution.UseVisualStyleBackColor = true;
            this.buttonDeactivePromoution.Click += new System.EventHandler(this.buttonDeactivePromoution_Click);
            // 
            // buttonActivePromoution
            // 
            this.buttonActivePromoution.Image = ((System.Drawing.Image)(resources.GetObject("buttonActivePromoution.Image")));
            this.buttonActivePromoution.Location = new System.Drawing.Point(1462, 30);
            this.buttonActivePromoution.Margin = new System.Windows.Forms.Padding(48, 30, 12, 30);
            this.buttonActivePromoution.Name = "buttonActivePromoution";
            this.buttonActivePromoution.Size = new System.Drawing.Size(130, 40);
            this.buttonActivePromoution.TabIndex = 7;
            this.buttonActivePromoution.Text = "Kích hoạt";
            this.buttonActivePromoution.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonActivePromoution.UseVisualStyleBackColor = true;
            this.buttonActivePromoution.Click += new System.EventHandler(this.buttonActivePromoution_Click);
            // 
            // UserControlPromoutionItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1700, 100);
            this.Name = "UserControlPromoutionItems";
            this.Size = new System.Drawing.Size(1700, 100);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelPromoutionName;
        private System.Windows.Forms.Label labelPromotionDes;
        private System.Windows.Forms.Label labelFromDate;
        private System.Windows.Forms.Label labelToDate;
        private System.Windows.Forms.Label labelForm;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonDeactivePromoution;
        private System.Windows.Forms.Button buttonActivePromoution;
    }
}
