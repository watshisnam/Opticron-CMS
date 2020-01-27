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
    public partial class NewsManagement : Form
    {
        private List<News> newsList;
        private News selectedNews;
        private bool state;
        public NewsManagement()
        {
            InitializeComponent();
            newsList = (new News()).SelectAllNews();
            cbxSelectNews.DataSource = newsList;
            cbxSelectNews.DisplayMember = "NewsId";

            gbxSelectedProduct.Visible = false;
        }

        private void btnNewNews_Click(object sender, EventArgs e)
        {
            gbxSelectedProduct.Visible = true;
            state = true;
            ClearFields();
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
            selectedNews.NewsImage= Path.GetFileName(txtImage.Text);
            txtImage.Text = Path.Combine("~/wwwroot/css/Assests/", Path.GetFileName(txtImage.Text));
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedNews.DeleteNews())
                {
                    MessageBox.Show("News Deleted Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            selectedNews.NewsDesc = rtxDesc.Text;


            try
            {
                if (state)
                {
                    if (selectedNews.InsertNewNews())
                    {
                        MessageBox.Show("News Inserted Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CloseAndFinishManagement();
                    }
                    else
                    {
                        throw new DbConnectionFailurExcpetion("Failed to find and Insert record");
                    }
                }
                else
                {
                    if (selectedNews.UpdateNews())
                    {
                        MessageBox.Show("News Update Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void CloseAndFinishManagement()
        {
            (new Form1()).Show();
            this.Hide();
        }
        private void PopulateFields()
        {
            txtImage.Text = "~/wwwroot/css/Assests/" + selectedNews.NewsImage;
            rtxDesc.Text = selectedNews.NewsImage;
            btnDelete.Visible = true;
        }
        private void ClearFields()
        {
            txtImage.Text = "";
            rtxDesc.Text = "";
            btnDelete.Visible = false; ;
        }

        private void cbxSelectNews_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbxSelectedProduct.Visible = true;
            selectedNews = (News)cbxSelectNews.SelectedItem;
            state = false;
           
            PopulateFields();
        }
    }
}
