using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidTermProject
{
    public partial class FormAvgScore : Form
    {
        DBConnection dbcon = new DBConnection();
        public FormAvgScore()
        {
            InitializeComponent();
        }
        //load all information
        private void FormAvgScore_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentManageDataSet1.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentManageDataSet1.student);
            // TODO: This line of code loads data into the 'studentManageDataSet1.courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.studentManageDataSet1.courses);
            string cmd = "select score.StudentID, student.FirstName, student.LastName, score.CourseID, courses.Label, score.Score from student inner join score on student.StudentID = score.StudentID inner join courses on score.CourseID = courses.CourseID";
            LoadScore(cmd);
        }
        //click listbox's item
        private void course_lb_Click(object sender, EventArgs e)
        {
            //load score dgv
            string cmdScore = "select score.StudentID, student.FirstName, student.LastName, score.CourseID, courses.Label, score.Score from student inner join score on student.StudentID = score.StudentID inner join courses on score.CourseID = courses.CourseID where courses.CourseID =" + int.Parse(course_lb.SelectedValue.ToString());
            LoadScore(cmdScore);
            //load student dgv
            string cmdStu = "select  student.StudentID, student.FirstName, student.LastName from student, score where student.StudentID = score.StudentID and score.CourseID =" + int.Parse(course_lb.SelectedValue.ToString());
            LoadStudent(cmdStu);
        }
        //show avg
        private void result_btn_Click(object sender, EventArgs e)
        {
            string cmd = "select AVG(Score) from score where score.CourseID =" + int.Parse(course_lb.SelectedValue.ToString());
            AVG_txt.Text = AVG(cmd).ToString();
            courseID_txt.Text = course_lb.SelectedValue.ToString();
            courseName_txt.Text = course_lb.Text;
        }
        /*Function*/
        //Load score function
        public void LoadScore(string cmd)
        {
            SqlCommand command = new SqlCommand(cmd, dbcon.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            showScore_dgv.DataSource = dt;
        }
        //Load student function
        public void LoadStudent(string cmd)
        {
            SqlCommand command = new SqlCommand(cmd, dbcon.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            showStu_dgv.DataSource = dt;
        }
        //calculate avg of course score
        public double AVG(string cmd)
        {
            dbcon.openConnection();
            SqlCommand command = new SqlCommand(cmd, dbcon.getConnection);
            double value = Convert.ToDouble(command.ExecuteScalar());
            return value;
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
            FormMain fm = new FormMain();
            fm.Show();
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            if (printDlg.ShowDialog() == DialogResult.OK) printDoc.Print();
        }
    }
}
