namespace MobileStoreManagement.Promoution
{
    partial class FormPromoutionSpecies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPromoutionSpecies));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPromoutionSpeciesId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPromoutionSpeciesName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại khuyến mãi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxPromoutionSpeciesId
            // 
            this.textBoxPromoutionSpeciesId.Location = new System.Drawing.Point(236, 60);
            this.textBoxPromoutionSpeciesId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPromoutionSpeciesId.Name = "textBoxPromoutionSpeciesId";
            this.textBoxPromoutionSpeciesId.Size = new System.Drawing.Size(252, 24);
            this.textBoxPromoutionSpeciesId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên loại khuyến mãi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxPromoutionSpeciesName
            // 
            this.textBoxPromoutionSpeciesName.Location = new System.Drawing.Point(236, 132);
            this.textBoxPromoutionSpeciesName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPromoutionSpeciesName.Name = "textBoxPromoutionSpeciesName";
            this.textBoxPromoutionSpeciesName.Size = new System.Drawing.Size(252, 24);
            this.textBoxPromoutionSpeciesName.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Image = global::MobileStoreManagement.Properties.Resources.plus;
            this.buttonAdd.Location = new System.Drawing.Point(353, 235);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(112, 54);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Image = global::MobileStoreManagement.Properties.Resources.delete;
            this.buttonDelete.Location = new System.Drawing.Point(207, 235);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(112, 54);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // PromoutionSpecies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 372);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxPromoutionSpeciesName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPromoutionSpeciesId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(564, 419);
            this.MinimumSize = new System.Drawing.Size(564, 419);
            this.Name = "PromoutionSpecies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mobile Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPromoutionSpeciesId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPromoutionSpeciesName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
    }
}