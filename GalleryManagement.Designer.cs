namespace Opticron_CMS
{
    partial class GalleryManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GalleryManagement));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNewGallery = new System.Windows.Forms.Button();
            this.cbxSelectGallery = new System.Windows.Forms.ComboBox();
            this.lblSelectProduct = new System.Windows.Forms.Label();
            this.gbxSelectedProduct = new System.Windows.Forms.GroupBox();
            this.dgvImages = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.rtxDesc = new System.Windows.Forms.RichTextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblProductImage = new System.Windows.Forms.Label();
            this.lblProductDesc = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.gbxSelectedProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNewGallery
            // 
            this.btnNewGallery.Location = new System.Drawing.Point(257, 34);
            this.btnNewGallery.Name = "btnNewGallery";
            this.btnNewGallery.Size = new System.Drawing.Size(115, 23);
            this.btnNewGallery.TabIndex = 16;
            this.btnNewGallery.Text = "New Gallery";
            this.btnNewGallery.UseVisualStyleBackColor = true;
            this.btnNewGallery.Click += new System.EventHandler(this.btnNewGallery_Click);
            // 
            // cbxSelectGallery
            // 
            this.cbxSelectGallery.FormattingEnabled = true;
            this.cbxSelectGallery.Location = new System.Drawing.Point(378, 72);
            this.cbxSelectGallery.Name = "cbxSelectGallery";
            this.cbxSelectGallery.Size = new System.Drawing.Size(121, 21);
            this.cbxSelectGallery.TabIndex = 15;
            this.cbxSelectGallery.SelectedIndexChanged += new System.EventHandler(this.cbxSelectGallery_SelectedIndexChanged);
            // 
            // lblSelectProduct
            // 
            this.lblSelectProduct.AutoSize = true;
            this.lblSelectProduct.Location = new System.Drawing.Point(254, 75);
            this.lblSelectProduct.Name = "lblSelectProduct";
            this.lblSelectProduct.Size = new System.Drawing.Size(114, 13);
            this.lblSelectProduct.TabIndex = 12;
            this.lblSelectProduct.Text = "Please select a Gallery";
            // 
            // gbxSelectedProduct
            // 
            this.gbxSelectedProduct.Controls.Add(this.dgvImages);
            this.gbxSelectedProduct.Controls.Add(this.btnSave);
            this.gbxSelectedProduct.Controls.Add(this.txtImage);
            this.gbxSelectedProduct.Controls.Add(this.rtxDesc);
            this.gbxSelectedProduct.Controls.Add(this.btnUpload);
            this.gbxSelectedProduct.Controls.Add(this.btnCancel);
            this.gbxSelectedProduct.Controls.Add(this.btnApply);
            this.gbxSelectedProduct.Controls.Add(this.btnDelete);
            this.gbxSelectedProduct.Controls.Add(this.lblProductImage);
            this.gbxSelectedProduct.Controls.Add(this.lblProductDesc);
            this.gbxSelectedProduct.Location = new System.Drawing.Point(32, 126);
            this.gbxSelectedProduct.Name = "gbxSelectedProduct";
            this.gbxSelectedProduct.Size = new System.Drawing.Size(467, 276);
            this.gbxSelectedProduct.TabIndex = 14;
            this.gbxSelectedProduct.TabStop = false;
            this.gbxSelectedProduct.Visible = false;
            // 
            // dgvImages
            // 
            this.dgvImages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImages.Location = new System.Drawing.Point(286, 19);
            this.dgvImages.Name = "dgvImages";
            this.dgvImages.Size = new System.Drawing.Size(165, 233);
            this.dgvImages.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(175, 166);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(88, 140);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(162, 20);
            this.txtImage.TabIndex = 9;
            // 
            // rtxDesc
            // 
            this.rtxDesc.Location = new System.Drawing.Point(86, 66);
            this.rtxDesc.Name = "rtxDesc";
            this.rtxDesc.Size = new System.Drawing.Size(164, 41);
            this.rtxDesc.TabIndex = 8;
            this.rtxDesc.Text = "";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(86, 166);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(209, 229);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(128, 229);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(47, 229);
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
            this.lblProductImage.Location = new System.Drawing.Point(37, 147);
            this.lblProductImage.Name = "lblProductImage";
            this.lblProductImage.Size = new System.Drawing.Size(45, 13);
            this.lblProductImage.TabIndex = 2;
            this.lblProductImage.Text = "Image : ";
            // 
            // lblProductDesc
            // 
            this.lblProductDesc.AutoSize = true;
            this.lblProductDesc.Location = new System.Drawing.Point(13, 69);
            this.lblProductDesc.Name = "lblProductDesc";
            this.lblProductDesc.Size = new System.Drawing.Size(69, 13);
            this.lblProductDesc.TabIndex = 1;
            this.lblProductDesc.Text = "Description : ";
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxLogo.BackgroundImage")));
            this.pbxLogo.Location = new System.Drawing.Point(12, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(215, 81);
            this.pbxLogo.TabIndex = 13;
            this.pbxLogo.TabStop = false;
            // 
            // GalleryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNewGallery);
            this.Controls.Add(this.cbxSelectGallery);
            this.Controls.Add(this.lblSelectProduct);
            this.Controls.Add(this.gbxSelectedProduct);
            this.Controls.Add(this.pbxLogo);
            this.Name = "GalleryManagement";
            this.Text = "GalleryManagement";
            this.gbxSelectedProduct.ResumeLayout(false);
            this.gbxSelectedProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNewGallery;
        private System.Windows.Forms.ComboBox cbxSelectGallery;
        private System.Windows.Forms.Label lblSelectProduct;
        private System.Windows.Forms.GroupBox gbxSelectedProduct;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox rtxDesc;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblProductImage;
        private System.Windows.Forms.Label lblProductDesc;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.DataGridView dgvImages;
        private System.Windows.Forms.TextBox txtImage;
    }
}