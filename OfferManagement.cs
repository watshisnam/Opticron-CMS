using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Opticron.Classes;
namespace Opticron_CMS
{
    public partial class OfferManagement : Form
    {
        private List<Offer> offersList;
        private Offer selectedOffer;
        private List<Product> productList;
        private bool state;
        public OfferManagement()
        {
            InitializeComponent();
            offersList = (new Offer()).SelectAllOffers();
            productList = (new Product()).SelectProduct();
            
            cbxSelectOffer.DataSource = offersList;
            cbxProducts.DataSource = productList;
            cbxSelectOffer.DisplayMember = "OfferTitle";
            cbxProducts.DisplayMember = "ProductName";
            gbxSelectedProduct.Visible = false;
        }
        private void PopulateOfferInfo()
        {
            txtTitle.Text = selectedOffer.OfferTitle;
            rtxDesc.Text = selectedOffer.OfferDesc;
            cbxProducts.Text = selectedOffer.OfferProd.ProductName;
            btnDelete.Visible = true;

        }
        private void ClearOfferInfo()
        {
            txtTitle.Text = "";
            rtxDesc.Text = "";
            cbxProducts.Text = "";
            btnDelete.Visible = false;
        }

        private void btnNewOffer_Click(object sender, EventArgs e)
        {
            gbxSelectedProduct.Visible = true;
            btnDelete.Visible = false;
            state = true;
            ClearOfferInfo();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedOffer.DeleteOffer())
                {
                    MessageBox.Show("OFfer Deleted Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CloseAndFinishOffermanagement();
                }
                else
                {
                    throw new DbConnectionFailurExcpetion("Failed to find and delete record");
                }
            }
            catch (DbConnectionFailurExcpetion err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            selectedOffer.OfferTitle= txtTitle.Text;
            selectedOffer.OfferDesc= rtxDesc.Text;


            try
            {
                if (state)
                {
                    if (selectedOffer.InsertNewOffer())
                    {
                        MessageBox.Show("Offer Inserted Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CloseAndFinishOffermanagement();
                    }
                    else
                    {
                        throw new DbConnectionFailurExcpetion("Failed to find and Insert record");
                    }
                }
                else
                {
                    if (selectedOffer.UpdateOffer())
                    {
                        MessageBox.Show("Offer Update Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CloseAndFinishOffermanagement();
                    }
                    else
                    {
                        throw new DbConnectionFailurExcpetion("Failed to find and Update record");
                    }
                }
            }
            catch (DbConnectionFailurExcpetion err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gbxSelectedProduct.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CloseAndFinishOffermanagement();
        }

        private void cbxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedOffer.OfferProd = (Product)cbxProducts.SelectedItem;
        }

        private void cbxSelectOffer_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedOffer = (Offer)cbxSelectOffer.SelectedItem;
            gbxSelectedProduct.Visible = true;
            state = false;
            PopulateOfferInfo();
        }
        public void CloseAndFinishOffermanagement()
        {
            (new Form1()).Show();
            this.Hide();
        }
    }
}
