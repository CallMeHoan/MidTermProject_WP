using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace MidTermProject
{
    public partial class FormEditRemove : Form
    {
        public FormEditRemove()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();

        private void edit_btn_Click(object sender, EventArgs e)
        {
            int id;
            string fname = fName_txt.Text;
            string lname = lName_txt.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = phone_txt.Text;
            string adrs = address_txt.Text;
            string gender = "Male";
            if (fMale_rbtn.Checked)
            {
                gender = "Female";
            }
            MemoryStream picture = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;

            if (((this_year - born_year) < 10 || (this_year - born_year) > 100))
            {
                MessageBox.Show("The student age must between 10 and 100 years old", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Verify())
            {
                try
                {
                    id = Convert.ToInt32(ID_txt.Text);

                    picture_ptb.Image.Save(picture, picture_ptb.Image.RawFormat);
                    if (student.updateStudent(id, fname, lname, bdate, gender, phone, adrs, picture))
                    {
                        MessageBox.Show("Update successfully!", "Edit student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Error!", "Edit student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty fields", "Edit student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void remove_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(ID_txt.Text);
                if(student.deleteStudent(id))
                {
                    MessageBox.Show("Do you want to delete this student?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    ID_txt.Text = "";
                    fName_txt.Text = "";
                    lName_txt.Text = "";
                    address_txt.Text = "";
                    phoneNum_lb.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                    picture_ptb.Image = null;
                }
                else
                {
                    MessageBox.Show("Student not deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Please Enter a valid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public bool Verify()
        {
            if ((fName_txt.Text.Trim() == "")
                || (lName_txt.Text.Trim() == "")
                || (address_txt.Text.Trim() == "")
                || (phone_txt.Text.Trim() == "")
                || (picture_ptb.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void loadPic_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.JPG,*.PNG;*.GIF)|*.JPG;*.PNG;*.GIF";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                picture_ptb.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
