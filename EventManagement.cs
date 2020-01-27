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
    public partial class EventManagement : Form
    {
        private bool state;
        private List<Event> eventList;
        private Event selectedEvent;
        public EventManagement()
        {
            InitializeComponent();

            eventList = (new Event()).SelectAllEvents();
            cbxSelectEvent.DataSource = eventList;
            cbxSelectEvent.DisplayMember = "EventId";
            gbxSelectedProduct.Visible = false;
        }

        private void btnNewEvent_Click(object sender, EventArgs e)
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
            selectedEvent.EventImage = Path.GetFileName(txtImage.Text);
            txtImage.Text = Path.Combine("~/wwwroot/css/Assets/", Path.GetFileName(txtImage.Text));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedEvent.DeleteEvent())
                {
                    MessageBox.Show("Event Deleted Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            selectedEvent.EventDesc= rtxDesc.Text;


            try
            {
                if (state)
                {
                    if (selectedEvent.InsertNewEvent())
                    {
                        MessageBox.Show("Event Inserted Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CloseAndFinishManagement();
                    }
                    else
                    {
                        throw new DbConnectionFailurExcpetion("Failed to find and Insert record");
                    }
                }
                else
                {
                    if (selectedEvent.UpdateEvent())
                    {
                        MessageBox.Show("Event Update Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cbxSelectEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbxSelectedProduct.Visible = true;
            selectedEvent = (Event)cbxSelectEvent.SelectedItem;
            state = false;
            PopulateFields();

        }
        private void PopulateFields()
        {
            txtImage.Text = "~/wwwroot/css/Assets/" + selectedEvent.EventImage;
            rtxDesc.Text = selectedEvent.EventDesc;
        }
        private void ClearFields()
        {
            txtImage.Text = "";
            rtxDesc.Text = "";
        }
        private void CloseAndFinishManagement()
        {
            (new Form1()).Show();
            this.Hide();
        }

        private void lblSelectProduct_Click(object sender, EventArgs e)
        {

        }

        private void gbxSelectedProduct_Enter(object sender, EventArgs e)
        {

        }

        private void pbxLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
