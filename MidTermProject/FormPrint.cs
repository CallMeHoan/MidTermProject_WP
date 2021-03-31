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
using System.IO;
using System.Drawing.Imaging;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace MidTermProject
{
    public partial class FormPrint : Form
    {
        STUDENT student = new STUDENT();
        public FormPrint()
        {
            InitializeComponent();
        }

        //load data từ db lên khi chạy
        private void FormPrint_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet2.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentDataSet2.student);

        }
        public void loadStudent()
        {
            MyDB mydb = new MyDB();
            mydb.openConnectionState();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from student", mydb.GetConnection);
            info_dgv.AllowUserToAddRows = false;
            mydb.closeConnection();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FormPrint_Load(sender, e);
        }

        private void StudentDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormEditRemove edit = new FormEditRemove();
            edit.ID_txt.Text = info_dgv.CurrentRow.Cells[0].Value.ToString();
            edit.fName_txt.Text = info_dgv.CurrentRow.Cells[1].Value.ToString();
            edit.lName_txt.Text = info_dgv.CurrentRow.Cells[2].Value.ToString();
            edit.dateTimePicker1.Value = (DateTime)info_dgv.CurrentRow.Cells[3].Value;
            if ((info_dgv.CurrentRow.Cells[4].Value.ToString() == "Female    "))
                edit.fMale_rbtn.Checked = true;
            else
                edit.Male_rbtn.Checked = true;
            edit.phone_txt.Text = info_dgv.CurrentRow.Cells[5].Value.ToString();
            edit.address_txt.Text = info_dgv.CurrentRow.Cells[6].Value.ToString();
            byte[] pic;
            pic = (byte[])info_dgv.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            edit.picture_ptb.Image = Image.FromStream(picture);
            edit.Show();
        }
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void saveToExcel_btn_Click(object sender, EventArgs e)
        {
            if (info_dgv.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcel = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = xcel.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                xcel.Visible = true;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Exported from gridview";
                for (int i = 1; i < info_dgv.Columns.Count + 1; i++)
                {
                    xcel.Cells[1, i] = info_dgv.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < info_dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < info_dgv.Columns.Count; j++)
                    {
                        if (info_dgv.Rows[i].Cells[j].Value.GetType() == typeof(byte[]))
                        {
                            Image image1 = byteArrayToImage((byte[])info_dgv.Rows[i].Cells[j].Value);
                            image1.Save(@"D:\Năm 2 20-21 p2\Window Programing\W5.PNG");
                            Microsoft.Office.Interop.Excel.Range oRange = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[i + 2, j + 1];
                            float Left = (float)((double)oRange.Left);
                            float Top = (float)((double)oRange.Top);
                            worksheet.Shapes.AddPicture(@"D:\Năm 2 20-21 p2\Window Programing\W5.PNG", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, 32, 32);
                            oRange.RowHeight = 36;
                            File.Delete(@"D:\Năm 2 20-21 p2\Window Programing\W5.PNG");
                        }
                        else
                            xcel.Cells[i + 2, j + 1] = info_dgv.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcel.Columns.AutoFit();
                xcel.Visible = true;
            }
        }

        private void check_btn_Click(object sender, EventArgs e)
        {
            LoadByGender();
        }

        public void LoadByGender()
        {
            if (fMale_rbtn.Checked == true && yes_rbtn.Checked == true)
            {
                SqlCommand sqlcommand = new SqlCommand("   Select * from student where gender = 'female' and datediff(day, DateOfBirth," + time1_tp.Value + ") >= 0 and datediff(day," + time1_tp.Value + ", DateOfBirth) >= 0");
                info_dgv.DataSource = student.getStudents(sqlcommand);
            }
            else if (male_rbtn.Checked == true && yes_rbtn.Checked == true)
            {
                SqlCommand sqlcommand = new SqlCommand("   Select * from student where gender = 'male' and datediff(day, DateOfBirth," + time1_tp.Value + ") >= 0 and datediff(day," + time1_tp.Value + ", DateOfBirth) >= 0");
                info_dgv.DataSource = student.getStudents(sqlcommand);
            }
            else if (male_rbtn.Checked == true && no_rbtn.Checked == true)
            {
                SqlCommand sqlcommand = new SqlCommand("   Select * from student where gender = 'male'");
                info_dgv.DataSource = student.getStudents(sqlcommand);
            }
            else if (fMale_rbtn.Checked == true && no_rbtn.Checked == true)
            {
                SqlCommand sqlcommand = new SqlCommand("   Select * from student where gender = 'female'");
                info_dgv.DataSource = student.getStudents(sqlcommand);
            }
            else
            {
                SqlCommand sqlcommand = new SqlCommand("  Select * from student");
                info_dgv.DataSource = student.getStudents(sqlcommand);
            }
        }
    }
}

