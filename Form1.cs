using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opticron_CMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            (new ManageProducts()).Show();
            this.Hide();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            (new CategoryManagement()).Show();
            this.Hide();
        }

        private void btnOffers_Click(object sender, EventArgs e)
        {
            (new OfferManagement()).Show();
            this.Hide();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            (new EventManagement()).Show();
            this.Hide();
        }

        private void btnNews_Click(object sender, EventArgs e)
        {
            (new NewsManagement()).Show();
            this.Hide();
        }

        private void btnGallery_Click(object sender, EventArgs e)
        {this.Hide();
            (new GalleryManagement()).Show();
            
        }
    }
}
