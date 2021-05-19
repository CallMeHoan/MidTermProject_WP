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

namespace MidTermProject.View.Result
{
    public partial class Static : Form
    {
        DBConnection dbcon = new DBConnection();
        public Static()
        {
            InitializeComponent();
        }

        private void Static_Load(object sender, EventArgs e)
        {
            string cmd = "select AVG(Score) from score where score.CourseID = 1";
            dbms_lb.Text = AVG(cmd).ToString();
            string cmd2 = "select AVG(Score) from score where score.CourseID = 3";
            wp_lb.Text = AVG(cmd2).ToString();
            int dem = 0;
            if(Convert.ToSingle(AVG(cmd).ToString()) > 3)
            {
                dem += 1;
            }
            if (Convert.ToSingle(AVG(cmd2).ToString()) > 3)
            {
                dem += 1;
            }
            pass_lb.Text = Result(dem).ToString() + "%";
            fail_lb.Text = (100 - Result(dem)).ToString() + "%";
        }


        //Find AVG score for one course
        public double AVG(string cmd)
        {
            dbcon.openConnection();
            SqlCommand command = new SqlCommand(cmd, dbcon.getConnection);
            double value = Convert.ToDouble(command.ExecuteScalar());
            return value;
        }

        //Return pass and fail
        public double Result(int a)
        {
            return a / 2 * 100;
        }
    }
}
