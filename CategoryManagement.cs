using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Opticron.Classes;
namespace Opticron_CMS
{
    public partial class CategoryManagement : Form
    {
        private List<Category> categoryList;
        private Category selectedCategory;
        private bool state;
        public CategoryManagement()
        {
            InitializeComponent();
            categoryList = (new Category()).SelectAllCategoies();
            cbxSelectCategory.DataSource = categoryList;
            cbxSelectCategory.DisplayMember = "CategoryName";
            gbxSelectedCategory.Visible = false;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg;,*.jpeg;,*.gif;,*.png;)";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtImage.Text = open.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string filepath = Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory.ToString()).ToString()).ToString()).ToString() + "\\wwwroot\\css\\Assests\\", Path.GetFileName(txtImage.Text));
            File.Copy(txtImage.Text, filepath);
            selectedCategory.CategoryName = Path.GetFileName(txtImage.Text);
            txtImage.Text = Path.Combine("~/wwwroot/css/Assests/", Path.GetFileName(txtImage.Text));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedCategory.DeleteCategory())
                {
                    MessageBox.Show("Category Deleted Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CloseAndFinishCategorymanagement();
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
            try
            {
                if (state)
                {
                    if (selectedCategory.InsertNewCategory())
                    {
                        MessageBox.Show("Category Inserted Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CloseAndFinishCategorymanagement();
                    }
                    else
                    {
                        throw new DbConnectionFailurExcpetion("Failed to find and Insert record");
                    }
                }
                else
                {
                    if (selectedCategory.UpdateCategory())
                    {
                        MessageBox.Show("Category Update Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CloseAndFinishCategorymanagement();
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
            gbxSelectedCategory.Visible = false;
        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            gbxSelectedCategory.Visible = true;
            btnDelete.Visible = false;
            state = true;
        }

        private void cbxSelectCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCategory =(Category)cbxSelectCategory.SelectedItem;
            gbxSelectedCategory.Visible = true;
            btnDelete.Visible = false;
            state = false;
            PopulateCategoryInfo();

        }
        private void PopulateCategoryInfo()
        {
            txtCategoryName.Text = selectedCategory.CategoryName;
            txtImage.Text = "~/wwwroot/css/Assests/" + selectedCategory.CategoryImage;
        }
        private void ClearCategoryInfo()
        {
            txtCategoryName.Text = "";
            txtImage.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CloseAndFinishCategorymanagement();


        }
        private void CloseAndFinishCategorymanagement()
        {
            (new Form1()).Show();
            this.Hide();
        }
    }
}
