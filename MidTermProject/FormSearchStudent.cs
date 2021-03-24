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
        STUDENT student = new STUDENT();
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
            SqlCommand sqlcommand = new SqlCommand("Select * from student where concat(StudentID, FirstName, LastName) LIKE '%" + SearchBar_txt + "%'");
            show_datagv.DataSource = student.getStudents(sqlcommand);
        }
        private void search_btn_Click(object sender, EventArgs e)
        {
            LoadGridByKey();   
        }

        private void show_datagv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.studentTableAdapter.Fill(this.studentDataSet.student);
        }
    }
}
