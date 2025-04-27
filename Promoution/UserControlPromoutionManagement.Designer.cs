namespace MobileStoreManagement
{
    partial class UserControlPromoutionManagement
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
            this.labelPromoution = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListBoxStatus = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkedListBoxEffect = new System.Windows.Forms.CheckedListBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxGetKeyWordSearch = new System.Windows.Forms.TextBox();
            this.buttonSearchPromoution = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddPromoution = new System.Windows.Forms.Button();
            this.buttonPromoutionSpecies = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelListPromoution = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPromoution
            // 
            this.labelPromoution.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPromoution.Location = new System.Drawing.Point(3, 0);
            this.labelPromoution.Name = "labelPromoution";
            this.labelPromoution.Size = new System.Drawing.Size(197, 73);
            this.labelPromoution.TabIndex = 11;
            this.labelPromoution.Text = "Khuyến mại";
            this.labelPromoution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBoxStatus);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 186);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trạng thái";
            // 
            // checkedListBoxStatus
            // 
            this.checkedListBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxStatus.FormattingEnabled = true;
            this.checkedListBoxStatus.Items.AddRange(new object[] {
            "Tất cả",
            "Kích hoạt",
            "Chưa áp dụng"});
            this.checkedListBoxStatus.Location = new System.Drawing.Point(9, 45);
            this.checkedListBoxStatus.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.checkedListBoxStatus.Name = "checkedListBoxStatus";
            this.checkedListBoxStatus.Size = new System.Drawing.Size(176, 118);
            this.checkedListBoxStatus.TabIndex = 7;
            this.checkedListBoxStatus.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxStatus_ItemCheck);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkedListBoxEffect);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 259);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 166);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiệu lực";
            // 
            // checkedListBoxEffect
            // 
            this.checkedListBoxEffect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxEffect.FormattingEnabled = true;
            this.checkedListBoxEffect.Items.AddRange(new object[] {
            "Tất cả ",
            "Còn hiệu lực",
            "Hết hiệu lực"});
            this.checkedListBoxEffect.Location = new System.Drawing.Point(9, 38);
            this.checkedListBoxEffect.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.checkedListBoxEffect.Name = "checkedListBoxEffect";
            this.checkedListBoxEffect.Size = new System.Drawing.Size(176, 99);
            this.checkedListBoxEffect.TabIndex = 8;
            this.checkedListBoxEffect.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxEffect_ItemCheck);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.labelPromoution);
            this.flowLayoutPanel5.Controls.Add(this.groupBox1);
            this.flowLayoutPanel5.Controls.Add(this.groupBox2);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(200, 700);
            this.flowLayoutPanel5.TabIndex = 16;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.Controls.Add(this.buttonSearchPromoution);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(833, 0);
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
            this.labelSearch.Text = "Tìm kiếm theo mã, tên chương trình";
            this.labelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // buttonSearchPromoution
            // 
            this.buttonSearchPromoution.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSearchPromoution.Image = global::MobileStoreManagement.Properties.Resources.search;
            this.buttonSearchPromoution.Location = new System.Drawing.Point(290, 12);
            this.buttonSearchPromoution.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.buttonSearchPromoution.Name = "buttonSearchPromoution";
            this.buttonSearchPromoution.Size = new System.Drawing.Size(111, 48);
            this.buttonSearchPromoution.TabIndex = 2;
            this.buttonSearchPromoution.Text = "Tìm kiếm";
            this.buttonSearchPromoution.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSearchPromoution.UseVisualStyleBackColor = true;
            this.buttonSearchPromoution.Click += new System.EventHandler(this.buttonSearchPromoution_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.buttonAddPromoution);
            this.flowLayoutPanel3.Controls.Add(this.buttonPromoutionSpecies);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(1246, 0);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(404, 72);
            this.flowLayoutPanel3.TabIndex = 3;
            this.flowLayoutPanel3.WrapContents = false;
            // 
            // buttonAddPromoution
            // 
            this.buttonAddPromoution.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddPromoution.Image = global::MobileStoreManagement.Properties.Resources.plus;
            this.buttonAddPromoution.Location = new System.Drawing.Point(225, 11);
            this.buttonAddPromoution.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.buttonAddPromoution.Name = "buttonAddPromoution";
            this.buttonAddPromoution.Size = new System.Drawing.Size(167, 48);
            this.buttonAddPromoution.TabIndex = 1;
            this.buttonAddPromoution.Text = "Thêm khuyến mãi";
            this.buttonAddPromoution.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddPromoution.UseVisualStyleBackColor = true;
            this.buttonAddPromoution.Click += new System.EventHandler(this.buttonAddPromoution_Click);
            // 
            // buttonPromoutionSpecies
            // 
            this.buttonPromoutionSpecies.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPromoutionSpecies.Image = global::MobileStoreManagement.Properties.Resources.plus;
            this.buttonPromoutionSpecies.Location = new System.Drawing.Point(12, 11);
            this.buttonPromoutionSpecies.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.buttonPromoutionSpecies.Name = "buttonPromoutionSpecies";
            this.buttonPromoutionSpecies.Size = new System.Drawing.Size(189, 48);
            this.buttonPromoutionSpecies.TabIndex = 2;
            this.buttonPromoutionSpecies.Text = "QL loại khuyến mãi";
            this.buttonPromoutionSpecies.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPromoutionSpecies.UseVisualStyleBackColor = true;
            this.buttonPromoutionSpecies.Click += new System.EventHandler(this.buttonPromoutionSpecies_Click);
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
            this.flowLayoutPanel2.TabIndex = 12;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // flowLayoutPanelListPromoution
            // 
            this.flowLayoutPanelListPromoution.AutoScroll = true;
            this.flowLayoutPanelListPromoution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelListPromoution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelListPromoution.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelListPromoution.Location = new System.Drawing.Point(200, 72);
            this.flowLayoutPanelListPromoution.Name = "flowLayoutPanelListPromoution";
            this.flowLayoutPanelListPromoution.Size = new System.Drawing.Size(1650, 628);
            this.flowLayoutPanelListPromoution.TabIndex = 17;
            this.flowLayoutPanelListPromoution.WrapContents = false;
            // 
            // UserControlPromoutionManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelListPromoution);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel5);
            this.MinimumSize = new System.Drawing.Size(830, 700);
            this.Name = "UserControlPromoutionManagement";
            this.Size = new System.Drawing.Size(1850, 700);
            this.Load += new System.EventHandler(this.UserControlPromoutionManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPromoution;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBoxStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox checkedListBoxEffect;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxGetKeyWordSearch;
        private System.Windows.Forms.Button buttonSearchPromoution;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button buttonAddPromoution;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelListPromoution;
        private System.Windows.Forms.Button buttonPromoutionSpecies;
    }
}
