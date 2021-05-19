using MidTermProject.View.Courses_management;
using MidTermProject.View.Result;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidTermProject
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void AddStuToolStrip_Click(object sender, EventArgs e)
        {
            Close();
            FormAddStudent addStudent = new FormAddStudent();
            addStudent.Show();
        }

        private void ListStuToolStrip_Click(object sender, EventArgs e)
        {
            Close();
            FormShowData showData = new FormShowData();
            showData.Show();
        }

        private void searchStuToolStrip_Click(object sender, EventArgs e)
        {
            Close();
            FormSearchStudent search = new FormSearchStudent();
            search.Show();
        }

        private void printStu_ToolStrip_Click(object sender, EventArgs e)
        {
            Close();
            FormPrint print = new FormPrint();
            print.Show();
        }

        private void staticToolStrip_Click(object sender, EventArgs e)
        {
            Close();
            FormStatics statics = new FormStatics();
            statics.Show();
        }

        private void manageStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            FormManageStudent manageStudent = new FormManageStudent();
            manageStudent.Show();
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            FormAddCourse addCourse = new FormAddCourse();
            addCourse.Show();

        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            FormEditCourse editCourse = new FormEditCourse();
            editCourse.Show();
        }

        private void manageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            FormManageCourse manageCourse = new FormManageCourse();
            manageCourse.Show();
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            FormRemoveCourse removeCourse = new FormRemoveCourse();
            removeCourse.Show();
        }

        private void printCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            FormPrintCourse print = new FormPrintCourse();
            print.Show();
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            FormAddScore addScore = new FormAddScore();
            addScore.Show();
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            FormManageScore manageScore = new FormManageScore();
            manageScore.Show();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            FormPrint print = new FormPrint();
            print.Show();
        }

        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            FormRemoveScore remove = new FormRemoveScore();
            remove.Show();
        }

        private void aVGScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void aVGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            AVG avg = new AVG();
            avg.Show();
        }

        private void staticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Static stt = new Static();
            stt.Show();
        }
    }
}
