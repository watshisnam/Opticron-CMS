using Opticron.Classes;
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

namespace Opticron_CMS
{
    public partial class GalleryManagement : Form
    {
        private List<Gallery> galleryList;
        private Gallery selectedGallery;
        private bool state;
        public GalleryManagement()
        {
            InitializeComponent();
            galleryList = (new Gallery()).SelectAllGallery();
            DataGridViewImageColumn iconColumn = new DataGridViewImageColumn();
            iconColumn.Name = "Image";
            iconColumn.HeaderText = "Image";
            iconColumn.Width = 75;
            dgvImages.RowTemplate.Height = 150; 
            iconColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            iconColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvImages.Columns.Insert(0,iconColumn);
            cbxSelectGallery.DataSource = galleryList;
            cbxSelectGallery.DisplayMember = "GalleryId";
            cbxSelectGallery.SelectedItem = galleryList.First<Gallery>();
            
            gbxSelectedProduct.Visible = false;
        }

        private void btnNewGallery_Click(object sender, EventArgs e)
        {
            ClearFields();
            gbxSelectedProduct.Visible = true;
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
            selectedGallery.GalleryImage.Add(0, Path.GetFileName(txtImage.Text));
            txtImage.Text = Path.Combine("~/wwwroot/css/Assets/", Path.GetFileName(txtImage.Text));
            PopulateFields();
        }

        private void cbxSelectGallery_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedGallery = (Gallery)cbxSelectGallery.SelectedItem;
            state = false;
            gbxSelectedProduct.Visible = true;
            PopulateFields();
        }
        private void PopulateFields()
        {
            
            rtxDesc.Text = selectedGallery.GalleryDesc;

            foreach (KeyValuePair<int,string> item in selectedGallery.GalleryImage)
            {
                
                
                string fielpath = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory.ToString()).ToString()).ToString()).ToString() + "\\wwwroot\\css\\Assests\\" + item.Value;
                Bitmap img = new Bitmap(fielpath);
                dgvImages.Rows.Add(img);
            
            }
        }
        private void ClearFields()
        {
            txtImage.Text = "";
            rtxDesc.Text = "";
            dgvImages.DataSource = null;
        }
        private void CloseAndFinishManagement()
        {
            (new Form1()).Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedGallery.DeleteGallery())
                {
                    MessageBox.Show("Gallery Deleted Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CloseAndFinishManagement();
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
            selectedGallery.GalleryDesc= rtxDesc.Text;


            try
            {
                if (state)
                {
                    if (selectedGallery.InsertNewGallery())
                    {
                        MessageBox.Show("Gallery Inserted Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CloseAndFinishManagement();
                    }
                    else
                    {
                        throw new DbConnectionFailurExcpetion("Failed to find and Insert record");
                    }
                }
                else
                {
                    if (selectedGallery.UpdateGallery())
                    {
                        MessageBox.Show("Gallery Update Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CloseAndFinishManagement();
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
            CloseAndFinishManagement();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            gbxSelectedProduct.Hide();
        }
    }
}
