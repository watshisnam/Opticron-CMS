namespace Opticron_CMS
{
    partial class OfferManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfferManagement));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNewOffer = new System.Windows.Forms.Button();
            this.cbxSelectOffer = new System.Windows.Forms.ComboBox();
            this.lblSelectProduct = new System.Windows.Forms.Label();
            this.gbxSelectedProduct = new System.Windows.Forms.GroupBox();
            this.cbxProducts = new System.Windows.Forms.ComboBox();
            this.lblCategories = new System.Windows.Forms.Label();
            this.rtxDesc = new System.Windows.Forms.RichTextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblProductDesc = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.gbxSelectedProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNewOffer
            // 
            this.btnNewOffer.Location = new System.Drawing.Point(257, 34);
            this.btnNewOffer.Name = "btnNewOffer";
            this.btnNewOffer.Size = new System.Drawing.Size(115, 23);
            this.btnNewOffer.TabIndex = 10;
            this.btnNewOffer.Text = "New Offer";
            this.btnNewOffer.UseVisualStyleBackColor = true;
            this.btnNewOffer.Click += new System.EventHandler(this.btnNewOffer_Click);
            // 
            // cbxSelectOffer
            // 
            this.cbxSelectOffer.FormattingEnabled = true;
            this.cbxSelectOffer.Location = new System.Drawing.Point(378, 72);
            this.cbxSelectOffer.Name = "cbxSelectOffer";
            this.cbxSelectOffer.Size = new System.Drawing.Size(121, 21);
            this.cbxSelectOffer.TabIndex = 9;
            this.cbxSelectOffer.SelectedIndexChanged += new System.EventHandler(this.cbxSelectOffer_SelectedIndexChanged);
            // 
            // lblSelectProduct
            // 
            this.lblSelectProduct.AutoSize = true;
            this.lblSelectProduct.Location = new System.Drawing.Point(254, 75);
            this.lblSelectProduct.Name = "lblSelectProduct";
            this.lblSelectProduct.Size = new System.Drawing.Size(103, 13);
            this.lblSelectProduct.TabIndex = 6;
            this.lblSelectProduct.Text = "Please select a offer";
            // 
            // gbxSelectedProduct
            // 
            this.gbxSelectedProduct.Controls.Add(this.cbxProducts);
            this.gbxSelectedProduct.Controls.Add(this.lblCategories);
            this.gbxSelectedProduct.Controls.Add(this.rtxDesc);
            this.gbxSelectedProduct.Controls.Add(this.txtTitle);
            this.gbxSelectedProduct.Controls.Add(this.btnCancel);
            this.gbxSelectedProduct.Controls.Add(this.btnApply);
            this.gbxSelectedProduct.Controls.Add(this.btnDelete);
            this.gbxSelectedProduct.Controls.Add(this.lblProductDesc);
            this.gbxSelectedProduct.Controls.Add(this.lblProductName);
            this.gbxSelectedProduct.Location = new System.Drawing.Point(101, 126);
            this.gbxSelectedProduct.Name = "gbxSelectedProduct";
            this.gbxSelectedProduct.Size = new System.Drawing.Size(398, 235);
            this.gbxSelectedProduct.TabIndex = 8;
            this.gbxSelectedProduct.TabStop = false;
            this.gbxSelectedProduct.Visible = false;
            // 
            // cbxProducts
            // 
            this.cbxProducts.FormattingEnabled = true;
            this.cbxProducts.Location = new System.Drawing.Point(157, 127);
            this.cbxProducts.Name = "cbxProducts";
            this.cbxProducts.Size = new System.Drawing.Size(164, 21);
            this.cbxProducts.TabIndex = 11;
            this.cbxProducts.SelectedIndexChanged += new System.EventHandler(this.cbxProducts_SelectedIndexChanged);
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(68, 127);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(53, 13);
            this.lblCategories.TabIndex = 10;
            this.lblCategories.Text = "Product : ";
            // 
            // rtxDesc
            // 
            this.rtxDesc.Location = new System.Drawing.Point(157, 45);
            this.rtxDesc.Name = "rtxDesc";
            this.rtxDesc.Size = new System.Drawing.Size(164, 68);
            this.rtxDesc.TabIndex = 8;
            this.rtxDesc.Text = "";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(157, 16);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(164, 20);
            this.txtTitle.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(246, 179);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(165, 179);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(84, 179);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.lblProductName.Size = new System.Drawing.Size(36, 13);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Title : ";
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxLogo.BackgroundImage")));
            this.pbxLogo.Location = new System.Drawing.Point(12, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(215, 81);
            this.pbxLogo.TabIndex = 7;
            this.pbxLogo.TabStop = false;
            // 
            // OfferManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNewOffer);
            this.Controls.Add(this.cbxSelectOffer);
            this.Controls.Add(this.lblSelectProduct);
            this.Controls.Add(this.gbxSelectedProduct);
            this.Controls.Add(this.pbxLogo);
            this.Name = "OfferManagement";
            this.Text = "OfferManagement";
            this.gbxSelectedProduct.ResumeLayout(false);
            this.gbxSelectedProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNewOffer;
        private System.Windows.Forms.ComboBox cbxSelectOffer;
        private System.Windows.Forms.Label lblSelectProduct;
        private System.Windows.Forms.GroupBox gbxSelectedProduct;
        private System.Windows.Forms.ComboBox cbxProducts;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.RichTextBox rtxDesc;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblProductDesc;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}