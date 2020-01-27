namespace Opticron_CMS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnOffers = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.btnNews = new System.Windows.Forms.Button();
            this.btnGallery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxLogo.BackgroundImage")));
            this.pbxLogo.Location = new System.Drawing.Point(12, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(215, 81);
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(110, 122);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(163, 80);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Manage Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.Location = new System.Drawing.Point(110, 208);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(163, 80);
            this.btnCategories.TabIndex = 2;
            this.btnCategories.Text = "Manage Categories";
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnOffers
            // 
            this.btnOffers.Location = new System.Drawing.Point(110, 294);
            this.btnOffers.Name = "btnOffers";
            this.btnOffers.Size = new System.Drawing.Size(163, 80);
            this.btnOffers.TabIndex = 3;
            this.btnOffers.Text = "Manage Offers";
            this.btnOffers.UseVisualStyleBackColor = true;
            this.btnOffers.Click += new System.EventHandler(this.btnOffers_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.Location = new System.Drawing.Point(296, 122);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(163, 80);
            this.btnEvents.TabIndex = 4;
            this.btnEvents.Text = "Manage Events";
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // btnNews
            // 
            this.btnNews.Location = new System.Drawing.Point(296, 208);
            this.btnNews.Name = "btnNews";
            this.btnNews.Size = new System.Drawing.Size(163, 80);
            this.btnNews.TabIndex = 5;
            this.btnNews.Text = "Manage News";
            this.btnNews.UseVisualStyleBackColor = true;
            this.btnNews.Click += new System.EventHandler(this.btnNews_Click);
            // 
            // btnGallery
            // 
            this.btnGallery.Location = new System.Drawing.Point(296, 294);
            this.btnGallery.Name = "btnGallery";
            this.btnGallery.Size = new System.Drawing.Size(163, 80);
            this.btnGallery.TabIndex = 6;
            this.btnGallery.Text = "Manage Gallery";
            this.btnGallery.UseVisualStyleBackColor = true;
            this.btnGallery.Click += new System.EventHandler(this.btnGallery_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.btnGallery);
            this.Controls.Add(this.btnNews);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.btnOffers);
            this.Controls.Add(this.btnCategories);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.pbxLogo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnOffers;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnNews;
        private System.Windows.Forms.Button btnGallery;
    }
}

