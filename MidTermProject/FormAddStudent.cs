using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MidTermProject
{
    public partial class FormAddStudent : Form
    {
        public FormAddStudent()
        {
            InitializeComponent();
        }

        private void Cancel_btn_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void Add_btn_Click_1(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            int id = Convert.ToInt32(Id_txt.Text);
            string fname = FirstName_txt.Text;
            string lname = LastName_txt.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = Phone_txt.Text;
            string adrs = Address_txt.Text;
            string gender = "Male";

            if (Gender2.Checked)
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
                pictureBox1.Image.Save(picture, pictureBox1.Image.RawFormat);
                if (student.insertStudent(id, fname, lname, bdate, gender, phone, adrs, picture))
                {
                    MessageBox.Show("New student added successfully!", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error!", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty fields", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool Verify()
        {
            if ((FirstName_txt.Text.Trim() == "")
                || (LastName_txt.Text.Trim() == "")
                || (Address_txt.Text.Trim() == "")
                || (Phone_txt.Text.Trim() == "")
                || (pictureBox1.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void AddPic_btn_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.JPG,*.PNG;*.GIF)|*.JPG;*.PNG;*.GIF";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
