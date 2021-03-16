using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MidTermProject
{
    public partial class FormShowData : Form
    {
        public FormShowData()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();

        private void FormShowData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentDataSet.student);
            // TODO: This line of code loads data into the 'studentDataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentDataSet.student);
            SqlCommand command = new SqlCommand("SELECT * FROM student");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }
    }
}
