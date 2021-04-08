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
    public partial class FormEditCourse : Form
    {
        CourseFunction cf = new CourseFunction();
        DBConnection dbcon = new DBConnection();
        public FormEditCourse()
        {
            InitializeComponent();
        }
        private void FormEditCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentManageDataSet1.courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.studentManageDataSet1.courses);
            ID_cb.SelectedItem = null;
        }
        private void ID_cb_SelectedValueChanged(object sender, EventArgs e)
        {
            loadData();
        }
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ID_cb.Text);
            string cName = cName_txt.Text;
            int period = Convert.ToInt32(period_nud.Text);
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
        /*Function*/
        //verify empty field
        public bool Verify()
        {
            if ((ID_cb.Text.Trim() == "")
                || (cName_txt.Text.Trim() == "")
                || (period_nud.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void loadData()
        {
            int id = Convert.ToInt32(ID_cb.SelectedValue);
            dbcon.openConnection();
            //load course name
            SqlCommand cmdName = new SqlCommand("select Label from courses where CourseID = " + id, dbcon.getConnection);
            cName_txt.Text = Convert.ToString(cmdName.ExecuteScalar());

            //load period
            SqlCommand cmdPeriod = new SqlCommand("select Period from courses where CourseID = " + id, dbcon.getConnection);
            period_nud.Value = Convert.ToInt32(cmdPeriod.ExecuteScalar());

            //load description
            SqlCommand cmdDes = new SqlCommand("select Description from courses where CourseID = " + id, dbcon.getConnection);
            descript_txt.Text = Convert.ToString(cmdDes.ExecuteScalar());
        }
    }
}
