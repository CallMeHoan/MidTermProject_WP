using MidTermProject;
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

namespace Lab08
{
    public partial class Add_Contact_Form : Form
    {
        public Add_Contact_Form()
        {
            InitializeComponent();
        }

        private void buttonAddContact_Click(object sender, EventArgs e)
        {
            if ((textBoxContactId.Text.Trim() == "") || (textBoxFname.Text.Trim() == "") || (textBoxLname.Text.Trim() == "") || (textBoxPhone.Text.Trim() == "") || (textBoxAddress.Text.Trim() == "") || (textBoxEmail.Text.Trim() == ""))
            {
                MessageBox.Show("Empty Fields!", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = Convert.ToInt32(textBoxContactId.Text);
            string fname = textBoxFname.Text;
            string lname = textBoxLname.Text;
            string phone = textBoxPhone.Text;
            string address = textBoxAddress.Text;
            string email = textBoxEmail.Text;
            int userid = Globals.GlobalUserId;

            try
            { 
                // get the group id
                int groupid = (int)comboBoxGroup.SelectedValue;

                // get the image
                MemoryStream pic = new MemoryStream();
                pictureBoxContactImage.Image.Save(pic, pictureBoxContactImage.Image.RawFormat);

                CONTACT contact = new CONTACT();
                if (contact.checkID(Convert.ToInt32(textBoxContactId.Text)))
                {
                    if (contact.insertContact(id, fname, lname, phone, address, email, userid, groupid, pic))
                    {
                        MessageBox.Show("New Contact Added", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("This ID Already Exists, Try Another One", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxContactImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void Add_Contact_Form_Load(object sender, EventArgs e)
        {
            //CONTACT contact = new CONTACT();
            //int userid = Globals.GlobalUserId;
            //// populate the combobox with courses
            //comboBoxGroup.DataSource = contact.getAllContactById(userid);
            //comboBoxGroup.DisplayMember = "name";
            //comboBoxGroup.ValueMember = "id";

            // set the selected combo item to nothing
            //comboBoxGroup.SelectedItem = null;

            GROUP group = new GROUP();


            comboBoxGroup.DataSource = group.getGroups(Globals.GlobalUserId);
            comboBoxGroup.DisplayMember = "Name";
            comboBoxGroup.ValueMember = "ID";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
