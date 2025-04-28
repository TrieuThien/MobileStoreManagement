namespace MobileStoreManagement
{
    partial class UserControlReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlReport));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonRevenueReport = new System.Windows.Forms.Button();
            this.buttonSalesReport = new System.Windows.Forms.Button();
            this.buttonInventoryReport = new System.Windows.Forms.Button();
            this.buttonPromoutionReport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFunctionName = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonExportReport = new System.Windows.Forms.Button();
            this.buttonPrintReport = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.buttonRevenueReport);
            this.flowLayoutPanel1.Controls.Add(this.buttonSalesReport);
            this.flowLayoutPanel1.Controls.Add(this.buttonInventoryReport);
            this.flowLayoutPanel1.Controls.Add(this.buttonPromoutionReport);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 700);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // buttonRevenueReport
            // 
            this.buttonRevenueReport.Image = global::MobileStoreManagement.Properties.Resources.cost;
            this.buttonRevenueReport.Location = new System.Drawing.Point(25, 12);
            this.buttonRevenueReport.Margin = new System.Windows.Forms.Padding(25, 12, 25, 12);
            this.buttonRevenueReport.Name = "buttonRevenueReport";
            this.buttonRevenueReport.Size = new System.Drawing.Size(200, 48);
            this.buttonRevenueReport.TabIndex = 0;
            this.buttonRevenueReport.Text = "Báo cáo doanh thu";
            this.buttonRevenueReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRevenueReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRevenueReport.UseVisualStyleBackColor = true;
            this.buttonRevenueReport.Click += new System.EventHandler(this.buttonRevenueReport_Click);
            // 
            // buttonSalesReport
            // 
            this.buttonSalesReport.Image = global::MobileStoreManagement.Properties.Resources.analysis;
            this.buttonSalesReport.Location = new System.Drawing.Point(25, 84);
            this.buttonSalesReport.Margin = new System.Windows.Forms.Padding(25, 12, 25, 12);
            this.buttonSalesReport.Name = "buttonSalesReport";
            this.buttonSalesReport.Size = new System.Drawing.Size(200, 48);
            this.buttonSalesReport.TabIndex = 1;
            this.buttonSalesReport.Text = "Báo cáo doanh số";
            this.buttonSalesReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalesReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSalesReport.UseVisualStyleBackColor = true;
            this.buttonSalesReport.Click += new System.EventHandler(this.buttonSalesReport_Click);
            // 
            // buttonInventoryReport
            // 
            this.buttonInventoryReport.Image = global::MobileStoreManagement.Properties.Resources.inventory;
            this.buttonInventoryReport.Location = new System.Drawing.Point(25, 156);
            this.buttonInventoryReport.Margin = new System.Windows.Forms.Padding(25, 12, 25, 12);
            this.buttonInventoryReport.Name = "buttonInventoryReport";
            this.buttonInventoryReport.Size = new System.Drawing.Size(200, 48);
            this.buttonInventoryReport.TabIndex = 2;
            this.buttonInventoryReport.Text = "Báo cáo hàng tồn kho";
            this.buttonInventoryReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInventoryReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonInventoryReport.UseVisualStyleBackColor = true;
            this.buttonInventoryReport.Click += new System.EventHandler(this.buttonInventoryReport_Click);
            // 
            // buttonPromoutionReport
            // 
            this.buttonPromoutionReport.Image = global::MobileStoreManagement.Properties.Resources.megaphone;
            this.buttonPromoutionReport.Location = new System.Drawing.Point(25, 228);
            this.buttonPromoutionReport.Margin = new System.Windows.Forms.Padding(25, 12, 25, 12);
            this.buttonPromoutionReport.Name = "buttonPromoutionReport";
            this.buttonPromoutionReport.Size = new System.Drawing.Size(200, 48);
            this.buttonPromoutionReport.TabIndex = 3;
            this.buttonPromoutionReport.Text = "Báo cáo khuyến mãi";
            this.buttonPromoutionReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPromoutionReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPromoutionReport.UseVisualStyleBackColor = true;
            this.buttonPromoutionReport.Click += new System.EventHandler(this.buttonPromoutionReport_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelFunctionName);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(250, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 68);
            this.panel1.TabIndex = 1;
            // 
            // labelFunctionName
            // 
            this.labelFunctionName.AutoSize = true;
            this.labelFunctionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFunctionName.Location = new System.Drawing.Point(24, 23);
            this.labelFunctionName.Name = "labelFunctionName";
            this.labelFunctionName.Size = new System.Drawing.Size(71, 18);
            this.labelFunctionName.TabIndex = 3;
            this.labelFunctionName.Text = "Báo cáo";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.buttonExportReport);
            this.flowLayoutPanel2.Controls.Add(this.buttonPrintReport);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(373, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(349, 68);
            this.flowLayoutPanel2.TabIndex = 2;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // buttonExportReport
            // 
            this.buttonExportReport.Image = global::MobileStoreManagement.Properties.Resources.export;
            this.buttonExportReport.Location = new System.Drawing.Point(187, 10);
            this.buttonExportReport.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.buttonExportReport.Name = "buttonExportReport";
            this.buttonExportReport.Size = new System.Drawing.Size(150, 48);
            this.buttonExportReport.TabIndex = 0;
            this.buttonExportReport.Text = "Xuất báo cáo";
            this.buttonExportReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExportReport.UseVisualStyleBackColor = true;
            // 
            // buttonPrintReport
            // 
            this.buttonPrintReport.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrintReport.Image")));
            this.buttonPrintReport.Location = new System.Drawing.Point(13, 10);
            this.buttonPrintReport.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.buttonPrintReport.Name = "buttonPrintReport";
            this.buttonPrintReport.Size = new System.Drawing.Size(150, 48);
            this.buttonPrintReport.TabIndex = 1;
            this.buttonPrintReport.Text = "In báo cáo";
            this.buttonPrintReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPrintReport.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(250, 68);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(722, 632);
            this.crystalReportViewer1.TabIndex = 2;
            // 
            // UserControlReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(830, 700);
            this.Name = "UserControlReport";
            this.Size = new System.Drawing.Size(972, 700);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonRevenueReport;
        private System.Windows.Forms.Button buttonSalesReport;
        private System.Windows.Forms.Button buttonInventoryReport;
        private System.Windows.Forms.Button buttonPromoutionReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelFunctionName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button buttonExportReport;
        private System.Windows.Forms.Button buttonPrintReport;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}
