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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        // chuc nang kiem tra du lieu input
        bool verify()
        {
            if ((textBoxFname.Text.Trim() == "") || (textBoxLname.Text.Trim() == "") || (textBoxUname.Text.Trim() == "") || (textBoxPassword.Text.Trim() == "") || (pictureBoxUserImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // button browse image
        private void labelLogin_Click(object sender, EventArgs e)
        {
            FormLogin form1 = new FormLogin();
            form1.Show();
            this.Close();
        }

        private void close_lb_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonUpload_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxUserImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void buttonRegister_Click_1(object sender, EventArgs e)
        {
            User user = new User();
            //int id = Convert.ToInt32(textBoxUserId.Text);
            string fname = textBoxFname.Text;
            string lname = textBoxLname.Text;
            string username = textBoxUname.Text;
            string password = textBoxPassword.Text;
            MemoryStream pic = new MemoryStream();

            if (verify() == true)
            {
                pictureBoxUserImage.Image.Save(pic, pictureBoxUserImage.Image.RawFormat);
                if (user.insertUser(fname, lname, username, password, pic) == true)
                {
                    MessageBox.Show("Registration Completed Success!", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Something Wrong", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
