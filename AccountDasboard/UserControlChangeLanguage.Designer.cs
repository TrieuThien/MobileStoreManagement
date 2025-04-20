namespace MobileStoreManagement.AccountDasboard
{
    partial class UserControlChangeLanguage
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
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSaveLanguage = new System.Windows.Forms.Button();
            this.comboBoxSelectLanguage = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel9.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel10);
            this.flowLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel9.Location = new System.Drawing.Point(20, 12);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(882, 97);
            this.flowLayoutPanel9.TabIndex = 7;
            this.flowLayoutPanel9.WrapContents = false;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Controls.Add(this.label6);
            this.flowLayoutPanel8.Controls.Add(this.label7);
            this.flowLayoutPanel8.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel8.Location = new System.Drawing.Point(3, 14);
            this.flowLayoutPanel8.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(281, 72);
            this.flowLayoutPanel8.TabIndex = 0;
            this.flowLayoutPanel8.WrapContents = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngôn ngữ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Thay đổi ngôn ngữ";
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.Controls.Add(this.buttonSaveLanguage);
            this.flowLayoutPanel10.Controls.Add(this.comboBoxSelectLanguage);
            this.flowLayoutPanel10.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel10.Location = new System.Drawing.Point(290, 25);
            this.flowLayoutPanel10.Margin = new System.Windows.Forms.Padding(3, 25, 3, 25);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Size = new System.Drawing.Size(587, 50);
            this.flowLayoutPanel10.TabIndex = 2;
            // 
            // buttonSaveLanguage
            // 
            this.buttonSaveLanguage.Location = new System.Drawing.Point(458, 9);
            this.buttonSaveLanguage.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.buttonSaveLanguage.Name = "buttonSaveLanguage";
            this.buttonSaveLanguage.Size = new System.Drawing.Size(117, 32);
            this.buttonSaveLanguage.TabIndex = 1;
            this.buttonSaveLanguage.Text = "Lưu thay đổi";
            this.buttonSaveLanguage.UseVisualStyleBackColor = true;
            this.buttonSaveLanguage.Click += new System.EventHandler(this.buttonSaveLanguage_Click);
            // 
            // comboBoxSelectLanguage
            // 
            this.comboBoxSelectLanguage.FormattingEnabled = true;
            this.comboBoxSelectLanguage.Items.AddRange(new object[] {
            "Tiếng Việt (Mặc định)",
            "Tiếng Anh"});
            this.comboBoxSelectLanguage.Location = new System.Drawing.Point(161, 14);
            this.comboBoxSelectLanguage.Margin = new System.Windows.Forms.Padding(12, 14, 12, 14);
            this.comboBoxSelectLanguage.Name = "comboBoxSelectLanguage";
            this.comboBoxSelectLanguage.Size = new System.Drawing.Size(273, 24);
            this.comboBoxSelectLanguage.TabIndex = 2;
            // 
            // UserControlChangeLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel9);
            this.MinimumSize = new System.Drawing.Size(920, 120);
            this.Name = "UserControlChangeLanguage";
            this.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
            this.Size = new System.Drawing.Size(922, 121);
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.flowLayoutPanel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
        private System.Windows.Forms.Button buttonSaveLanguage;
        private System.Windows.Forms.ComboBox comboBoxSelectLanguage;
    }
}
