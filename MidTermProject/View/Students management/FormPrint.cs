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
using System.Drawing.Printing;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.Office.Interop.Word;
using Image = System.Drawing.Image;

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

        //refresh page (button fresh)
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FormPrint_Load(sender, e);
        }

        //edit student in print form (click cell in dgv)
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
        //button save
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
        //button save to word
        private void saveWord_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "DOCX files(*.docx)|*.docx";

            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                Export_Data_To_Word(info_dgv, savefile.FileName);
                MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //button check
        private void check_btn_Click(object sender, EventArgs e)
        {
            LoadByGender();
        }
        //in data grid view (button print)
        private void print_btn_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            if (printDlg.ShowDialog() == DialogResult.OK) printDoc.Print();
        }
        private void savePDF_btn_Click(object sender, EventArgs e)
        {
            if (info_dgv.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf"; bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(info_dgv.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn column in info_dgv.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }
                            foreach (DataGridViewRow row in info_dgv.Rows)
                            {
                                string id = row.Cells[0].Value.ToString();
                                pdfTable.AddCell(id);
                                string Fname = row.Cells[1].Value.ToString();
                                pdfTable.AddCell(Fname);
                                string Lname = row.Cells[2].Value.ToString();
                                pdfTable.AddCell(Lname);
                                string Bdate = row.Cells[3].Value.ToString();
                                pdfTable.AddCell(Bdate);
                                string gender = row.Cells[4].Value.ToString();
                                pdfTable.AddCell(gender);
                                string phone = row.Cells[5].Value.ToString();
                                pdfTable.AddCell(phone);
                                string address = row.Cells[6].Value.ToString();
                                pdfTable.AddCell(address);
                                byte[] imageByte = (byte[])row.Cells[7].Value;
                                iTextSharp.text.Image Image = iTextSharp.text.Image.GetInstance(imageByte);
                                pdfTable.AddCell(Image);
                            }
                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream); pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }




        // function


        //load student từ database
        public void loadStudent()
        {
            MyDB mydb = new MyDB();
            mydb.openConnectionState();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from student", mydb.GetConnection);
            info_dgv.AllowUserToAddRows = false;
            mydb.closeConnection();
        }
        // check điều kiện của radio button để load dữ liệu lên data grid view
        public void LoadByGender()
        {
            if (yes_rbtn.Checked)
            {
                DateTime start = time1_tp.Value;
                DateTime end = time2_tp.Value;
                if (start > end)
                {
                    DateTime temp = start;
                    start = end;
                    end = temp;
                }
                if (male_rbtn.Checked)
                {
                    SqlCommand command = new SqlCommand("SELECT * from student where DateOfBirth between @start and @end and gender = 'Male'");
                    command.Parameters.Add("@start", SqlDbType.DateTime).Value = start;
                    command.Parameters.Add("@end", SqlDbType.DateTime).Value = end;
                    info_dgv.DataSource = student.getStudents(command);
                }
                else if (fMale_rbtn.Checked)
                {
                    SqlCommand command = new SqlCommand("SELECT * from student where DateOfBirth between @start and @end and gender = 'Female'");
                    command.Parameters.Add("@start", SqlDbType.DateTime).Value = start;
                    command.Parameters.Add("@end", SqlDbType.DateTime).Value = end;
                    info_dgv.DataSource = student.getStudents(command);
                }
                else
                {
                    SqlCommand command = new SqlCommand("SELECT * from student where DateOfBirth between @start and @end");
                    command.Parameters.Add("@start", SqlDbType.DateTime).Value = start;
                    command.Parameters.Add("@end", SqlDbType.DateTime).Value = end;
                    info_dgv.DataSource = student.getStudents(command);
                }
            }
            else
            {
                if (allGender_rbtn.Checked)
                {
                    SqlCommand command = new SqlCommand("SELECT * from student");
                    info_dgv.DataSource = student.getStudents(command);
                }
                else if (fMale_rbtn.Checked)
                {
                    SqlCommand command = new SqlCommand("SELECT * from student where gender = 'female'");
                    info_dgv.DataSource = student.getStudents(command);
                }
                else
                {
                    SqlCommand command = new SqlCommand("SELECT * from student where gender = 'male'");
                    info_dgv.DataSource = student.getStudents(command);
                }
            }
        }
        //chuyển đổi ảnh sang kiểu byte
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }
        //đổi ảnh kiểu byte sang ảnh
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        //xuất ra file word
        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;

                Microsoft.Office.Interop.Word.Document oDoc = new Microsoft.Office.Interop.Word.Document();
                oDoc.Application.Visible = true;

                oDoc.PageSetup.Orientation = WdOrientation.wdOrientLandscape;

                //dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                Object oMissing = System.Reflection.Missing.Value;
                for (int r = 0; r <= RowCount - 1; r++)
                {
                    oTemp = "";
                    for (int c = 0; c < ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DGV.Rows[r].Cells[c].Value + "\t";
                    }
                    var oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara1.Range.Text = oTemp;
                    oPara1.Range.InsertParagraphAfter();
                    byte[] imgbyte = (byte[])info_dgv.Rows[r].Cells[7].Value;
                    MemoryStream ms = new MemoryStream(imgbyte);
                    //Image sparePicture = Image.FromStream(ms);
                    Image finalPic = (Image)(new Bitmap(Image.FromStream(ms), new Size(50, 50)));
                    Clipboard.SetDataObject(finalPic);
                    var oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara2.Range.Paste();
                    oPara2.Range.InsertParagraphAfter();
                    //oTemp += "\n";
                }

                //save the file
                oDoc.SaveAs2(filename);
            }
        }
    }

}
