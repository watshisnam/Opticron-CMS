using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Opticron.Classes.DataHandler;
using Opticron.Classes;
using System.IO;

namespace Opticron_CMS
{
    public partial class ManageProducts : Form
    {
        private List<Product> productList;
        private Product selectedProduct;
        private List<Category> categoryList;
        private bool state;
        public ManageProducts()
        {
            InitializeComponent();
            
            productList = (new Product()).SelectProduct();
            categoryList = (new Category()).SelectAllCategoies();
            cbxSelectProduct.DataSource = productList;
            cbxSelectProduct.DisplayMember = "ProductName";
            cbxCategories.DataSource = categoryList;
            cbxCategories.DisplayMember = "CategoryName";


            gbxSelectedProduct.Visible = false;
        }
        private void PopulateProductInfo()
        {
            txtProdName.Text = selectedProduct.ProductName;
            rtxProdDesc.Text = selectedProduct.ProductDesc;
            txtImage.Text = "~/wwwroot/css/Assets/"+selectedProduct.ProductImage;
            cbxCategories.Text = selectedProduct.ProductCategory.CategoryName;
            btnDelete.Visible = true;

        }
        private void ClearProductInfo()
        {
            txtProdName.Text = "";
            rtxProdDesc.Text = "";
            txtImage.Text = "" ;
            cbxCategories.Text = "";
            btnDelete.Visible = false;
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            gbxSelectedProduct.Visible = true;
            state = true;
            ClearProductInfo();
             
        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {

        }

        private void cbxSelectProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbxSelectedProduct.Visible = true;
            selectedProduct =(Product)cbxSelectProduct.SelectedItem;
            state = false;
            PopulateProductInfo();
        }

        private void cbxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProduct.ProductCategory = (Category)cbxCategories.SelectedItem;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gbxSelectedProduct.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedProduct.DeleteProduct())
                {
                    MessageBox.Show("Product Deleted Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CloseAndFinishProductmanagement();
                }
                else
                {
                    throw new DbConnectionFailurExcpetion("Failed to find and delete record");
                }
            }
            catch(DbConnectionFailurExcpetion err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CloseAndFinishProductmanagement()
        {
            (new Form1()).Show();
            this.Hide();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg;,*.jpeg;,*.gif;,*.png;)|*.jpg;,*.jpeg;,*.gif;,*.png;";
            if(open.ShowDialog() == DialogResult.OK)
            {
                txtImage.Text = open.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string filepath = Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory.ToString()).ToString()).ToString()).ToString() + "\\wwwroot\\css\\Assests\\", Path.GetFileName(txtImage.Text));
            File.Copy(txtImage.Text,filepath);
            selectedProduct.ProductImage = Path.GetFileName(txtImage.Text);
            txtImage.Text = Path.Combine("~/wwwroot/css/Assests/", Path.GetFileName(txtImage.Text));
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            selectedProduct.ProductName = txtProdName.Text;
            selectedProduct.ProductDesc = rtxProdDesc.Text;
            

            try
            {
                if (state)
                {
                    if (selectedProduct.InsertNewProduct())
                    {
                        MessageBox.Show("Product Inserted Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CloseAndFinishProductmanagement();
                    }
                    else
                    {
                        throw new DbConnectionFailurExcpetion("Failed to find and Insert record");
                    }
                }
                else
                {
                    if (selectedProduct.UpdateProduct())
                    {
                        MessageBox.Show("Product Update Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CloseAndFinishProductmanagement();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            CloseAndFinishProductmanagement();
        }
    }
}
