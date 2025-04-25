namespace MobileStoreManagement
{
    partial class FormAccountDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccountDashboard));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonPersonalInfor = new System.Windows.Forms.Button();
            this.buttonChangeLangua = new System.Windows.Forms.Button();
            this.panelAcountDashboard = new System.Windows.Forms.Panel();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.buttonPersonalInfor);
            this.flowLayoutPanel1.Controls.Add(this.buttonChangeLangua);
            this.flowLayoutPanel1.Controls.Add(this.buttonLogOut);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(240, 753);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // buttonPersonalInfor
            // 
            this.buttonPersonalInfor.Location = new System.Drawing.Point(40, 24);
            this.buttonPersonalInfor.Margin = new System.Windows.Forms.Padding(40, 24, 40, 12);
            this.buttonPersonalInfor.Name = "buttonPersonalInfor";
            this.buttonPersonalInfor.Size = new System.Drawing.Size(160, 48);
            this.buttonPersonalInfor.TabIndex = 0;
            this.buttonPersonalInfor.Text = "Thông tin tài khoản";
            this.buttonPersonalInfor.UseVisualStyleBackColor = true;
            this.buttonPersonalInfor.Click += new System.EventHandler(this.buttonPersonalInfor_Click);
            // 
            // buttonChangeLangua
            // 
            this.buttonChangeLangua.Location = new System.Drawing.Point(40, 108);
            this.buttonChangeLangua.Margin = new System.Windows.Forms.Padding(40, 24, 40, 12);
            this.buttonChangeLangua.Name = "buttonChangeLangua";
            this.buttonChangeLangua.Size = new System.Drawing.Size(160, 48);
            this.buttonChangeLangua.TabIndex = 1;
            this.buttonChangeLangua.Text = "Ngôn ngữ";
            this.buttonChangeLangua.UseVisualStyleBackColor = true;
            this.buttonChangeLangua.Click += new System.EventHandler(this.buttonChangeLangua_Click);
            // 
            // panelAcountDashboard
            // 
            this.panelAcountDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAcountDashboard.Location = new System.Drawing.Point(240, 0);
            this.panelAcountDashboard.Name = "panelAcountDashboard";
            this.panelAcountDashboard.Size = new System.Drawing.Size(1242, 753);
            this.panelAcountDashboard.TabIndex = 2;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(40, 192);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(40, 24, 40, 12);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(160, 48);
            this.buttonLogOut.TabIndex = 2;
            this.buttonLogOut.Text = "Đăng xuất";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // FormAccountDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.panelAcountDashboard);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1500, 800);
            this.Name = "FormAccountDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mobile Manager";
            this.Load += new System.EventHandler(this.FormAccountDashboard_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonPersonalInfor;
        private System.Windows.Forms.Button buttonChangeLangua;
        private System.Windows.Forms.Panel panelAcountDashboard;
        private System.Windows.Forms.Button buttonLogOut;
    }
}