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
    public partial class FormStatics : Form
    {
        DBConnection dbcon = new DBConnection();
        public FormStatics()
        {
            InitializeComponent();
        }
        public double total(string sqlcommand)
        {
            dbcon.openConnection();
            SqlCommand command = new SqlCommand(sqlcommand, dbcon.getConnection);
            int value = Convert.ToInt32(command.ExecuteScalar());
            return value;
        }

        string totalStu = "select count(*) from student";
        string maleStu = "select count(*) from student where gender = 'Male'";
        string femaleStu = "select count(*) from student where gender = 'Female'";

        private void FormStatics_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet3.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentDataSet3.student);

            tt_lb.Text = total(totalStu).ToString();

            double malePercent = Math.Round(((total(maleStu) / total(totalStu)) * 100), 2);
            m_lb.Text = malePercent.ToString() + "%";

            double femalePercent = Math.Round(((total(femaleStu) / total(totalStu)) * 100), 2);
            fm_lb.Text = malePercent.ToString() + "%";

        }

        private void viewChart_btn_Click(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Points.AddXY("Male", (Math.Round(((total(maleStu) / total(totalStu)) * 100), 2)).ToString());
            chart1.Series["Series1"].Points.AddXY("Female", (Math.Round(((total(femaleStu) / total(totalStu)) * 100), 2)).ToString());
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
            FormMain fm = new FormMain();
            fm.Show();
        }
    }
}
