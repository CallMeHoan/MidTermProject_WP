using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidTermProject
{
    public partial class FormManageScore : Form
    {
        DBConnection dbcon = new DBConnection();
        ScoreFunction sf = new ScoreFunction();
        public FormManageScore()
        {
            InitializeComponent();
        }
        //load form
        private void FormManageScore_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentManageDataSet1.courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.studentManageDataSet1.courses);
            // TODO: This line of code loads data into the 'studentManageDataSet1.courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.studentManageDataSet1.courses);
            string cmd = "select StudentID, FirstName, LastName, DateOfBirth, Gender from student";
            LoadData(cmd);
        }
        //show student button
        private void showStu_btn_Click(object sender, EventArgs e)
        {
            string cmd = "select StudentID, FirstName, LastName, DateOfBirth, Gender from student";
            LoadData(cmd);
        }
        //show all score button
        private void showSco_btn_Click(object sender, EventArgs e)
        {    
            string cmd = "select score.StudentID, student.FirstName, student.LastName, score.CourseID, courses.Label, score.Score from student inner join score on student.StudentID = score.StudentID inner join courses on score.CourseID = courses.CourseID";
            LoadData(cmd);
        }
        //load dữ liệu khi click đầu dòng
        private void showInfo_dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            StuID_txt.Text = showInfo_dgv.CurrentRow.Cells[0].Value.ToString();
        }
        //cancel button
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
            FormMain fm = new FormMain();
            fm.Show();

        }
        //add button
        private void add_btn_Click(object sender, EventArgs e)
        {
            int stuid = Convert.ToInt32(StuID_txt.Text);
            int cid = Convert.ToInt32(course_cb.SelectedValue);
            double score = Convert.ToDouble(score_txt.Text);
            string des = descript_txt.Text;
            if (checkStudent())
            {
                if (checkScore(score))
                {
                    if (sf.insertScore(stuid, cid, score, des))
                    {
                        MessageBox.Show("New score added successfully!", "Add score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string cmd = "select score.StudentID, student.FirstName, student.LastName, score.CourseID, courses.Label, score.Score from student inner join score on student.StudentID = score.StudentID inner join courses on score.CourseID = courses.CourseID";
                        LoadData(cmd);
                    }
                    else
                    {
                        MessageBox.Show("Error!", "Add score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Score must between 0 and 10!", "Add score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Student ID is not exist!", "Add score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //edit button
        private void edit_btn_Click(object sender, EventArgs e)
        {
            int stuid = Convert.ToInt32(StuID_txt.Text);
            int cid = Convert.ToInt32(course_cb.SelectedValue);
            float score = float.Parse(score_txt.Text);
            string des = descript_txt.Text;

            if (score > 10 || score < 0)
            {
                MessageBox.Show("Score must between 0 and 10", "Invalid score", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Verify())
            {
                if (sf.updateScore(stuid, cid, score, des))
                {
                    MessageBox.Show("Editted!", "Edit score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string cmd = "select score.StudentID, student.FirstName, student.LastName, score.CourseID, courses.Label, score.Score from student inner join score on student.StudentID = score.StudentID inner join courses on score.CourseID = courses.CourseID";
                    LoadData(cmd);
                }
                else
                {
                    MessageBox.Show("Error!", "Edit score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty fields", "Edit course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //remove button
        private void remove_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int stuid = int.Parse(showInfo_dgv.CurrentRow.Cells[0].Value.ToString());
                int cid = int.Parse(showInfo_dgv.CurrentRow.Cells[3].Value.ToString());
                if (sf.removeScore(stuid, cid))
                {
                    MessageBox.Show("Do you want to delete this student's score?", "Delete score", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    MessageBox.Show("Deleted!", "Delete sroce", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string cmd = "select score.StudentID, student.FirstName, student.LastName, score.CourseID, courses.Label, score.Score from student inner join score on student.StudentID = score.StudentID inner join courses on score.CourseID = courses.CourseID";
                    LoadData(cmd);
                }
                else
                {
                    MessageBox.Show("Score not deleted", "Delete score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Choose a student to delete score!", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Show AVG button
        private void showAvg_btn_Click(object sender, EventArgs e)
        {
            Close();
            FormAvgScore avg = new FormAvgScore();
            avg.Show();
        }
        /*Function*/
        //Load bảng dữ liệu
        public void LoadData(string cmd)
        {
            SqlCommand command = new SqlCommand(cmd, dbcon.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            showInfo_dgv.DataSource = dt;
        }
        //kiểm tra xem học sinh có tồn tại không
        public bool checkStudent()
        {
            dbcon.openConnection();
            int id = Convert.ToInt32(StuID_txt.Text);
            SqlCommand command = new SqlCommand("select StudentID from student where StudentID = " + id, dbcon.getConnection);
            int val = Convert.ToInt32(command.ExecuteScalar());
            if (val == id)
            {
                return true;
            }
            else return false;
        }
        //check điểm của học sinh
        public bool checkScore(double score)
        {
            if (score >= 0 && score <= 10) return true;
            else return false;
        }
        //check ô nào còn trống
        public bool Verify()
        {
            if ((StuID_txt.Text.Trim() == "")
                || (score_txt.Text.Trim() == ""))
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
