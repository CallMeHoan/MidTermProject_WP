using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MidTermProject
{
    public partial class FormManageCourse : Form
    {
        CourseFunction cf = new CourseFunction();
        public FormManageCourse()
        {
            InitializeComponent();
        }

        private void FormManageCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentManageDataSet1.courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter1.Fill(this.studentManageDataSet1.courses);


        }
        //cancel button
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
            FormMain formMain = new FormMain();
            formMain.Show();
        }
        //add button
        private void add_btn_Click(object sender, EventArgs e)
        {
            //adding course
            int id = Convert.ToInt32(cid_txt.Text);
            string cName = cName_txt.Text;
            int period = Convert.ToInt32(period_txt.Text);
            string des = descript_txt.Text;

            if (period < 10)
            {
                MessageBox.Show("Number of period must equal or greater than 10", "Invalid number of period", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Verify())
            {
                if (cf.insertCourse(id, cName, period, des))
                {
                    MessageBox.Show("New course added successfully!", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error!", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty fields", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //edit button
        private void edit_btn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cid_txt.Text);
            string cName = cName_txt.Text;
            int period = Convert.ToInt32(period_txt.Text);
            string des = descript_txt.Text;

            if (period < 10)
            {
                MessageBox.Show("Number of period must equal or greater than 10", "Invalid number of period", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Verify())
            {
                if (cf.updateCourse(id, cName, period, des))
                {
                    MessageBox.Show("Editted!", "Edit course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error!", "Edit course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty fields", "Edit course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //delete button
        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(cid_txt.Text);
                if (cf.removeCourse(id))
                {
                    MessageBox.Show("Do you want to delete this course?", "Delete course", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    MessageBox.Show("Deleted!", "Delete course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cid_txt.Text = "";
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
        //Click into row header
        private void show_datagv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cid_txt.Text = showCourse_dgv.CurrentRow.Cells[0].Value.ToString();
            cName_txt.Text = showCourse_dgv.CurrentRow.Cells[1].Value.ToString();
            period_txt.Text = showCourse_dgv.CurrentRow.Cells[2].Value.ToString();
            descript_txt.Text = showCourse_dgv.CurrentRow.Cells[3].Value.ToString();

        }
        //refresh button
        private void refresh_btn_Click(object sender, EventArgs e)
        {
            this.coursesTableAdapter1.Fill(this.studentManageDataSet1.courses);
        }
        //Search button
        private void search_btn_Click(object sender, EventArgs e)
        {
            if (id_rabtn.Checked)
            {
                SqlCommand command = new SqlCommand("select * from courses where CourseID = " + SearchBar_txt.Text);
                showCourse_dgv.DataSource = cf.getCourse(command);
            }
            else if (name_rbtn.Checked)
            {
                SqlCommand command = new SqlCommand("select * from courses where Label LIKE '%" + SearchBar_txt.Text + "%'");
                showCourse_dgv.DataSource = cf.getCourse(command);
            }
            else
            {
                SqlCommand command = new SqlCommand("select * from courses");
                showCourse_dgv.DataSource = cf.getCourse(command);
            }
        }


        /*Function*/
        public bool Verify()
        {
            if ((cid_txt.Text.Trim() == "")
                || (cName_txt.Text.Trim() == "")
                || (period_txt.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
