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
    public partial class FormAddCourse : Form
    {
        courseFunction course = new courseFunction();
        public FormAddCourse()
        {
            InitializeComponent();
        }

        //return main form (cancel button)
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        // Add course button
        private void add_btn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cid_txt.Text);
            string cName = cName_txt.Text;
            int period = Convert.ToInt32(period_txt.Text);
            string des = descript_txt.Text;

            if(period < 10)
            {
                MessageBox.Show("Number of period must equal or greater than 10", "Invalid number of period", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Verify())
            {
                if(course.insertCourse(id, cName, period, des))
                {
                    MessageBox.Show("New course added successfully!", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error!", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty fields", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /*Function*/
        //verify empty field
        public bool Verify()
        {
            if ((cid_txt.Text.Trim() == "")
                || (cName_txt.Text.Trim() == "")
                || (period_txt.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
