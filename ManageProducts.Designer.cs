namespace Opticron_CMS
{
    partial class ManageProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProducts));
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.gbxSelectedProduct = new System.Windows.Forms.GroupBox();
            this.cbxCategories = new System.Windows.Forms.ComboBox();
            this.lblCategories = new System.Windows.Forms.Label();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.rtxProdDesc = new System.Windows.Forms.RichTextBox();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblProductImage = new System.Windows.Forms.Label();
            this.lblProductDesc = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblSelectProduct = new System.Windows.Forms.Label();
            this.cbxSelectProduct = new System.Windows.Forms.ComboBox();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.gbxSelectedProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxLogo.BackgroundImage")));
            this.pbxLogo.Location = new System.Drawing.Point(12, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(215, 81);
            this.pbxLogo.TabIndex = 1;
            this.pbxLogo.TabStop = false;
            // 
            // gbxSelectedProduct
            // 
            this.gbxSelectedProduct.Controls.Add(this.btnSave);
            this.gbxSelectedProduct.Controls.Add(this.cbxCategories);
            this.gbxSelectedProduct.Controls.Add(this.lblCategories);
            this.gbxSelectedProduct.Controls.Add(this.txtImage);
            this.gbxSelectedProduct.Controls.Add(this.rtxProdDesc);
            this.gbxSelectedProduct.Controls.Add(this.txtProdName);
            this.gbxSelectedProduct.Controls.Add(this.btnUpload);
            this.gbxSelectedProduct.Controls.Add(this.btnCancel);
            this.gbxSelectedProduct.Controls.Add(this.btnApply);
            this.gbxSelectedProduct.Controls.Add(this.btnDelete);
            this.gbxSelectedProduct.Controls.Add(this.lblProductImage);
            this.gbxSelectedProduct.Controls.Add(this.lblProductDesc);
            this.gbxSelectedProduct.Controls.Add(this.lblProductName);
            this.gbxSelectedProduct.Location = new System.Drawing.Point(101, 126);
            this.gbxSelectedProduct.Name = "gbxSelectedProduct";
            this.gbxSelectedProduct.Size = new System.Drawing.Size(398, 258);
            this.gbxSelectedProduct.TabIndex = 2;
            this.gbxSelectedProduct.TabStop = false;
            this.gbxSelectedProduct.Visible = false;
            // 
            // cbxCategories
            // 
            this.cbxCategories.FormattingEnabled = true;
            this.cbxCategories.Location = new System.Drawing.Point(165, 192);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.Size = new System.Drawing.Size(156, 21);
            this.cbxCategories.TabIndex = 11;
            this.cbxCategories.SelectedIndexChanged += new System.EventHandler(this.cbxCategories_SelectedIndexChanged);
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(70, 192);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(58, 13);
            this.lblCategories.TabIndex = 10;
            this.lblCategories.Text = "Category : ";
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(159, 125);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(162, 20);
            this.txtImage.TabIndex = 9;
            // 
            // rtxProdDesc
            // 
            this.rtxProdDesc.Location = new System.Drawing.Point(157, 45);
            this.rtxProdDesc.Name = "rtxProdDesc";
            this.rtxProdDesc.Size = new System.Drawing.Size(164, 68);
            this.rtxProdDesc.TabIndex = 8;
            this.rtxProdDesc.Text = "";
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(157, 16);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(164, 20);
            this.txtProdName.TabIndex = 7;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(157, 151);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(246, 229);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(165, 229);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(84, 229);
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
            this.lblProductImage.Location = new System.Drawing.Point(74, 132);
            this.lblProductImage.Name = "lblProductImage";
            this.lblProductImage.Size = new System.Drawing.Size(45, 13);
            this.lblProductImage.TabIndex = 2;
            this.lblProductImage.Text = "Image : ";
            // 
            // lblProductDesc
            // 
            this.lblProductDesc.AutoSize = true;
            this.lblProductDesc.Location = new System.Drawing.Point(50, 43);
            this.lblProductDesc.Name = "lblProductDesc";
            this.lblProductDesc.Size = new System.Drawing.Size(69, 13);
            this.lblProductDesc.TabIndex = 1;
            this.lblProductDesc.Text = "Description : ";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(75, 16);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(44, 13);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Name : ";
            // 
            // lblSelectProduct
            // 
            this.lblSelectProduct.AutoSize = true;
            this.lblSelectProduct.Location = new System.Drawing.Point(254, 75);
            this.lblSelectProduct.Name = "lblSelectProduct";
            this.lblSelectProduct.Size = new System.Drawing.Size(118, 13);
            this.lblSelectProduct.TabIndex = 0;
            this.lblSelectProduct.Text = "Please select a product";
            // 
            // cbxSelectProduct
            // 
            this.cbxSelectProduct.FormattingEnabled = true;
            this.cbxSelectProduct.Location = new System.Drawing.Point(378, 72);
            this.cbxSelectProduct.Name = "cbxSelectProduct";
            this.cbxSelectProduct.Size = new System.Drawing.Size(121, 21);
            this.cbxSelectProduct.TabIndex = 3;
            this.cbxSelectProduct.SelectedIndexChanged += new System.EventHandler(this.cbxSelectProduct_SelectedIndexChanged);
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.Location = new System.Drawing.Point(257, 34);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(115, 23);
            this.btnNewProduct.TabIndex = 4;
            this.btnNewProduct.Text = "New Product";
            this.btnNewProduct.UseVisualStyleBackColor = true;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(246, 151);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNewProduct);
            this.Controls.Add(this.cbxSelectProduct);
            this.Controls.Add(this.lblSelectProduct);
            this.Controls.Add(this.gbxSelectedProduct);
            this.Controls.Add(this.pbxLogo);
            this.Name = "ManageProducts";
            this.Text = "ManageProducts";
            this.Load += new System.EventHandler(this.ManageProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.gbxSelectedProduct.ResumeLayout(false);
            this.gbxSelectedProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.GroupBox gbxSelectedProduct;
        private System.Windows.Forms.Label lblSelectProduct;
        private System.Windows.Forms.ComboBox cbxSelectProduct;
        private System.Windows.Forms.Button btnNewProduct;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.RichTextBox rtxProdDesc;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblProductImage;
        private System.Windows.Forms.Label lblProductDesc;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cbxCategories;
        private System.Windows.Forms.Button btnSave;
    }
}