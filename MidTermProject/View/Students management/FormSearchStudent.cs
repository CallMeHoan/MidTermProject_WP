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
    public partial class FormSearchStudent : Form
    {
        StudentFunction stuf = new StudentFunction();
        public FormSearchStudent()
        {
            InitializeComponent();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
            FormMain fm = new FormMain();
            fm.Show();
        }
        public void LoadGridByKey()
        {

            if (id_rabtn.Checked == true)
            {
                SqlCommand sqlcommand = new SqlCommand("Select * from student where StudentID LIKE '%" + SearchBar_txt.Text + "%'");
                show_datagv.DataSource = stuf.getStudents(sqlcommand);
            }
            else if (fName_rabtn.Checked == true)
            {
                SqlCommand sqlcommand = new SqlCommand("Select * from student where FirstName LIKE '%" + SearchBar_txt.Text + "%'");
                show_datagv.DataSource = stuf.getStudents(sqlcommand);
            }
            else
            {
                SqlCommand sqlcommand = new SqlCommand("Select * from student where LastName LIKE '%" + SearchBar_txt.Text + "%'");
                show_datagv.DataSource = stuf.getStudents(sqlcommand);
            }

        }
        private void search_btn_Click(object sender, EventArgs e)
        {
            LoadGridByKey();
        }

        private void FormSearchStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentManageDataSet1.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentManageDataSet1.student);
            this.studentTableAdapter.Fill(this.studentManageDataSet1.student);
        }
    }
}
