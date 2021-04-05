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
using System.Data.SqlClient;


namespace MidTermProject
{
    public partial class FormManageStudent : Form
    {
        STUDENT student = new STUDENT();
        MyDB mydb = new MyDB();
        public FormManageStudent()
        {
            InitializeComponent();
        }

        public void LoadGridByKey()
        {

            if (id_rabtn.Checked == true)
            {
                SqlCommand sqlcommand = new SqlCommand("Select * from student where StudentID LIKE '%" + SearchBar_txt.Text + "%'");
                show_datagv.DataSource = student.getStudents(sqlcommand);
            }
            else if (fName_rabtn.Checked == true)
            {
                SqlCommand sqlcommand = new SqlCommand("Select * from student where FirstName LIKE '%" + SearchBar_txt.Text + "%'");
                show_datagv.DataSource = student.getStudents(sqlcommand);
            }
            else
            {
                SqlCommand sqlcommand = new SqlCommand("Select * from student where LastName LIKE '%" + SearchBar_txt.Text + "%'");
                show_datagv.DataSource = student.getStudents(sqlcommand);
            }

        }

        private void FormManageStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet1.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentDataSet.student);
            result_lb.Text = total().ToString();

        }

        private void search_btn_Click_1(object sender, EventArgs e)
        {
            LoadGridByKey();
        }

        private void show_datagv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID_txt.Text = show_datagv.CurrentRow.Cells[0].Value.ToString();
            fName_txt.Text = show_datagv.CurrentRow.Cells[1].Value.ToString();
            lName_txt.Text = show_datagv.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Value = (DateTime)show_datagv.CurrentRow.Cells[3].Value;

            if ((show_datagv.CurrentRow.Cells[4].Value.ToString() == "Female"))
            {
                fMale_rbtn.Checked = true;
            }
            phone_txt.Text = show_datagv.CurrentRow.Cells[5].Value.ToString();
            address_txt.Text = show_datagv.CurrentRow.Cells[6].Value.ToString();

            byte[] pic;
            pic = (byte[])show_datagv.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            picture_ptb.Image = Image.FromStream(picture);
        }

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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty fields", "Edit student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void remove_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(ID_txt.Text);
                if (student.deleteStudent(id))
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

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM student");
            show_datagv.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            show_datagv.RowTemplate.Height = 80;
            show_datagv.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)show_datagv.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            show_datagv.AllowUserToAddRows = false;
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            int id = Convert.ToInt32(ID_txt.Text);
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
                picture_ptb.Image.Save(picture, picture_ptb.Image.RawFormat);
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
        public int total()
        {
            mydb.openConnectionState();
            SqlCommand command = new SqlCommand("select count(*) from student", mydb.GetConnection);
            int value = Convert.ToInt32(command.ExecuteScalar());
            return value;
        }
    }
}
