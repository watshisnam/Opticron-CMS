namespace Opticron_CMS
{
    partial class CategoryManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryManagement));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNewCategory = new System.Windows.Forms.Button();
            this.cbxSelectCategory = new System.Windows.Forms.ComboBox();
            this.lblSelectCategory = new System.Windows.Forms.Label();
            this.gbxSelectedCategory = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblProductImage = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.gbxSelectedCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(8, 413);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNewCategory
            // 
            this.btnNewCategory.Location = new System.Drawing.Point(253, 32);
            this.btnNewCategory.Name = "btnNewCategory";
            this.btnNewCategory.Size = new System.Drawing.Size(115, 23);
            this.btnNewCategory.TabIndex = 10;
            this.btnNewCategory.Text = "New Category";
            this.btnNewCategory.UseVisualStyleBackColor = true;
            this.btnNewCategory.Click += new System.EventHandler(this.btnNewCategory_Click);
            // 
            // cbxSelectCategory
            // 
            this.cbxSelectCategory.FormattingEnabled = true;
            this.cbxSelectCategory.Location = new System.Drawing.Point(374, 70);
            this.cbxSelectCategory.Name = "cbxSelectCategory";
            this.cbxSelectCategory.Size = new System.Drawing.Size(121, 21);
            this.cbxSelectCategory.TabIndex = 9;
            this.cbxSelectCategory.SelectedIndexChanged += new System.EventHandler(this.cbxSelectCategory_SelectedIndexChanged);
            // 
            // lblSelectCategory
            // 
            this.lblSelectCategory.AutoSize = true;
            this.lblSelectCategory.Location = new System.Drawing.Point(250, 73);
            this.lblSelectCategory.Name = "lblSelectCategory";
            this.lblSelectCategory.Size = new System.Drawing.Size(124, 13);
            this.lblSelectCategory.TabIndex = 6;
            this.lblSelectCategory.Text = "Please select a Category";
            // 
            // gbxSelectedCategory
            // 
            this.gbxSelectedCategory.Controls.Add(this.btnSave);
            this.gbxSelectedCategory.Controls.Add(this.txtImage);
            this.gbxSelectedCategory.Controls.Add(this.txtCategoryName);
            this.gbxSelectedCategory.Controls.Add(this.btnUpload);
            this.gbxSelectedCategory.Controls.Add(this.btnCancel);
            this.gbxSelectedCategory.Controls.Add(this.btnApply);
            this.gbxSelectedCategory.Controls.Add(this.btnDelete);
            this.gbxSelectedCategory.Controls.Add(this.lblProductImage);
            this.gbxSelectedCategory.Controls.Add(this.lblProductName);
            this.gbxSelectedCategory.Location = new System.Drawing.Point(97, 124);
            this.gbxSelectedCategory.Name = "gbxSelectedCategory";
            this.gbxSelectedCategory.Size = new System.Drawing.Size(398, 258);
            this.gbxSelectedCategory.TabIndex = 8;
            this.gbxSelectedCategory.TabStop = false;
            this.gbxSelectedCategory.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(244, 118);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(157, 92);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(162, 20);
            this.txtImage.TabIndex = 9;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(157, 46);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(164, 20);
            this.txtCategoryName.TabIndex = 7;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(155, 118);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(246, 194);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(165, 194);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(84, 194);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblProductImage
            // 
            this.lblProductImage.AutoSize = true;
            this.lblProductImage.Location = new System.Drawing.Point(72, 99);
            this.lblProductImage.Name = "lblProductImage";
            this.lblProductImage.Size = new System.Drawing.Size(45, 13);
            this.lblProductImage.TabIndex = 2;
            this.lblProductImage.Text = "Image : ";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(75, 46);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(44, 13);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Name : ";
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxLogo.BackgroundImage")));
            this.pbxLogo.Location = new System.Drawing.Point(8, 10);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(215, 81);
            this.pbxLogo.TabIndex = 7;
            this.pbxLogo.TabStop = false;
            // 
            // CategoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNewCategory);
            this.Controls.Add(this.cbxSelectCategory);
            this.Controls.Add(this.lblSelectCategory);
            this.Controls.Add(this.gbxSelectedCategory);
            this.Controls.Add(this.pbxLogo);
            this.Name = "CategoryManagement";
            this.Text = "CategoryManagement";
            this.gbxSelectedCategory.ResumeLayout(false);
            this.gbxSelectedCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNewCategory;
        private System.Windows.Forms.ComboBox cbxSelectCategory;
        private System.Windows.Forms.Label lblSelectCategory;
        private System.Windows.Forms.GroupBox gbxSelectedCategory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblProductImage;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}