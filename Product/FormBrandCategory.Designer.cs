namespace MobileStoreManagement
{
    partial class FormBrandCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBrandCategory));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelWindowName = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelBrandId = new System.Windows.Forms.Label();
            this.labelBrandName = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxGetBrandId = new System.Windows.Forms.TextBox();
            this.textBoxGetBrandName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddBrand = new System.Windows.Forms.Button();
            this.buttonEditBrand = new System.Windows.Forms.Button();
            this.buttonDeleteBrand = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelWindowName);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(762, 48);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // labelWindowName
            // 
            this.labelWindowName.AutoSize = true;
            this.labelWindowName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindowName.Location = new System.Drawing.Point(32, 14);
            this.labelWindowName.Margin = new System.Windows.Forms.Padding(32, 14, 0, 14);
            this.labelWindowName.Name = "labelWindowName";
            this.labelWindowName.Size = new System.Drawing.Size(157, 20);
            this.labelWindowName.TabIndex = 0;
            this.labelWindowName.Text = "Quản lý thương hiệu";
            this.labelWindowName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.labelBrandId);
            this.flowLayoutPanel2.Controls.Add(this.labelBrandName);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(65, 33);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(157, 87);
            this.flowLayoutPanel2.TabIndex = 1;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // labelBrandId
            // 
            this.labelBrandId.Location = new System.Drawing.Point(0, 12);
            this.labelBrandId.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.labelBrandId.Name = "labelBrandId";
            this.labelBrandId.Size = new System.Drawing.Size(157, 22);
            this.labelBrandId.TabIndex = 0;
            this.labelBrandId.Text = "Mã thương hiệu";
            this.labelBrandId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelBrandId.Click += new System.EventHandler(this.labelBrandId_Click);
            // 
            // labelBrandName
            // 
            this.labelBrandName.Location = new System.Drawing.Point(0, 58);
            this.labelBrandName.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.labelBrandName.Name = "labelBrandName";
            this.labelBrandName.Size = new System.Drawing.Size(157, 22);
            this.labelBrandName.TabIndex = 1;
            this.labelBrandName.Text = "Tên thương hiệu";
            this.labelBrandName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelBrandName.Click += new System.EventHandler(this.labelBrandName_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.textBoxGetBrandId);
            this.flowLayoutPanel3.Controls.Add(this.textBoxGetBrandName);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(248, 33);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(310, 87);
            this.flowLayoutPanel3.TabIndex = 2;
            this.flowLayoutPanel3.WrapContents = false;
            // 
            // textBoxGetBrandId
            // 
            this.textBoxGetBrandId.Location = new System.Drawing.Point(0, 12);
            this.textBoxGetBrandId.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.textBoxGetBrandId.Name = "textBoxGetBrandId";
            this.textBoxGetBrandId.Size = new System.Drawing.Size(273, 22);
            this.textBoxGetBrandId.TabIndex = 0;
            this.textBoxGetBrandId.Enter += new System.EventHandler(this.textBoxGetBrandId_Enter);
            this.textBoxGetBrandId.Leave += new System.EventHandler(this.textBoxGetBrandId_Leave);
            // 
            // textBoxGetBrandName
            // 
            this.textBoxGetBrandName.Location = new System.Drawing.Point(0, 58);
            this.textBoxGetBrandName.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.textBoxGetBrandName.Name = "textBoxGetBrandName";
            this.textBoxGetBrandName.Size = new System.Drawing.Size(273, 22);
            this.textBoxGetBrandName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Controls.Add(this.flowLayoutPanel3);
            this.groupBox1.Location = new System.Drawing.Point(99, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 144);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.buttonAddBrand);
            this.flowLayoutPanel4.Controls.Add(this.buttonEditBrand);
            this.flowLayoutPanel4.Controls.Add(this.buttonDeleteBrand);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(36, 240);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(696, 64);
            this.flowLayoutPanel4.TabIndex = 4;
            this.flowLayoutPanel4.WrapContents = false;
            // 
            // buttonAddBrand
            // 
            this.buttonAddBrand.Image = global::MobileStoreManagement.Properties.Resources.plus;
            this.buttonAddBrand.Location = new System.Drawing.Point(584, 8);
            this.buttonAddBrand.Margin = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.buttonAddBrand.Name = "buttonAddBrand";
            this.buttonAddBrand.Size = new System.Drawing.Size(100, 48);
            this.buttonAddBrand.TabIndex = 0;
            this.buttonAddBrand.Text = "Thêm";
            this.buttonAddBrand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddBrand.UseVisualStyleBackColor = true;
            this.buttonAddBrand.Click += new System.EventHandler(this.buttonAddBrand_Click);
            // 
            // buttonEditBrand
            // 
            this.buttonEditBrand.Image = global::MobileStoreManagement.Properties.Resources.pencil;
            this.buttonEditBrand.Location = new System.Drawing.Point(460, 8);
            this.buttonEditBrand.Margin = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.buttonEditBrand.Name = "buttonEditBrand";
            this.buttonEditBrand.Size = new System.Drawing.Size(100, 48);
            this.buttonEditBrand.TabIndex = 1;
            this.buttonEditBrand.Text = "Sửa";
            this.buttonEditBrand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEditBrand.UseVisualStyleBackColor = true;
            this.buttonEditBrand.Click += new System.EventHandler(this.buttonEditBrand_Click);
            // 
            // buttonDeleteBrand
            // 
            this.buttonDeleteBrand.Image = global::MobileStoreManagement.Properties.Resources.bin;
            this.buttonDeleteBrand.Location = new System.Drawing.Point(336, 8);
            this.buttonDeleteBrand.Margin = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.buttonDeleteBrand.Name = "buttonDeleteBrand";
            this.buttonDeleteBrand.Size = new System.Drawing.Size(100, 48);
            this.buttonDeleteBrand.TabIndex = 2;
            this.buttonDeleteBrand.Text = "Xóa";
            this.buttonDeleteBrand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDeleteBrand.UseVisualStyleBackColor = true;
            this.buttonDeleteBrand.Click += new System.EventHandler(this.buttonDeleteBrand_Click);
            // 
            // FormBrandCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 323);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(780, 370);
            this.MinimumSize = new System.Drawing.Size(780, 370);
            this.Name = "FormBrandCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mobile Manager";
            this.Load += new System.EventHandler(this.FormBrandCategory_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelWindowName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label labelBrandId;
        private System.Windows.Forms.Label labelBrandName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox textBoxGetBrandId;
        private System.Windows.Forms.TextBox textBoxGetBrandName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button buttonAddBrand;
        private System.Windows.Forms.Button buttonEditBrand;
        private System.Windows.Forms.Button buttonDeleteBrand;
    }
}