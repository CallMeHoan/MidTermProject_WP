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
    public partial class FormRemoveScore : Form
    {
        DBConnection dbcon = new DBConnection();
        ScoreFunction sf = new ScoreFunction();
        public FormRemoveScore()
        {
            InitializeComponent();
        }

        //Load form
        private void FormRemoveScore_Load(object sender, EventArgs e)
        {
            LoadData();
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
                    LoadData();
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

        //Cancel button
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
            FormMain fm = new FormMain();
            fm.Show();
        }
        //Function
        public void LoadData()
        {
            SqlCommand command = new SqlCommand("select score.StudentID, student.FirstName, student.LastName, score.CourseID, courses.Label, score.Score from student inner join score on student.StudentID = score.StudentID inner join courses on score.CourseID = courses.CourseID", dbcon.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            showInfo_dgv.DataSource = dt;
        }
    }
}
