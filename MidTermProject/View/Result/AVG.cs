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
    public partial class AVG : Form
    {
        DBConnection dbcon = new DBConnection();
        public AVG()
        {
            InitializeComponent();
        }

        private void AVG_Load(object sender, EventArgs e)
        {
            string cmd = "select StudentID, FirstName, LastName, [DBMS], [WP] from(select s.StudentID, st.FirstName, st.LastName, c.Label, s.Score as score from score s, courses c, student st where s.CourseID = c.CourseID and st.StudentID = s.StudentID) as Src pivot (AVG(score) for	Label in ([DBMS], [WP]) ) as Pvt";
            LoadData(cmd);
        }

        private void showInfo_dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            StuID_txt.Text = showInfo_dgv.Rows[e.RowIndex].Cells["StudentID"].FormattedValue.ToString();
            fname_txt.Text = showInfo_dgv.Rows[e.RowIndex].Cells["FirstName"].FormattedValue.ToString();
            lname_txt.Text = showInfo_dgv.Rows[e.RowIndex].Cells["LastName"].FormattedValue.ToString();
        }
        private void search_btn_Click(object sender, EventArgs e)
        {
            string searchValue = searchbar_txt.Text;

            showInfo_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in showInfo_dgv.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        break;
                    } 
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        /*Function*/
        //Load bảng dữ liệu
        public void LoadData(string cmd)
        {
            SqlCommand command = new SqlCommand(cmd, dbcon.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Columns.Add(new DataColumn("AVG score", typeof(float)));
            dt.Columns.Add(new DataColumn("Result", typeof(string)));
            showInfo_dgv.DataSource = dt;
            for(int i = 0; i < showInfo_dgv.Rows.Count - 1; i++)
            {
                float a = Convert.ToSingle(showInfo_dgv.Rows[i].Cells[3].Value);
                float b = Convert.ToSingle(showInfo_dgv.Rows[i].Cells[4].Value);
                showInfo_dgv.Rows[i].Cells[5].Value = Average(a, b);
                showInfo_dgv.Rows[i].Cells[6].Value = Result(Average(a, b));
            } 
        }
        //tính trung bình
        public float Average(float a, float b)
        {
            return (a + b) / 2;
        }
        //Trả về kết quả
        public string Result(float a)
        {
            if (a > 0 && a <= 3) return "E";
            else if (a > 3 && a <= 5) return "D";
            else if (a > 5 && a <= 7) return "C";
            else if (a > 7 && a <= 9) return "B";
            else if (a > 9 && a <= 10) return "A";
            else return null;
        }
    }
}
