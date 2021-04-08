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
    public partial class FormAddScore : Form
    {
        DBConnection dbcon = new DBConnection();
        ScoreFunction sf = new ScoreFunction();
        public FormAddScore()
        {
            InitializeComponent();
        }

        private void FormAddScore_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentManageDataSet1.courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.studentManageDataSet1.courses);
            // TODO: This line of code loads data into the 'studentManageDataSet1.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentManageDataSet1.student);

        }

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

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        /*Function*/
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
