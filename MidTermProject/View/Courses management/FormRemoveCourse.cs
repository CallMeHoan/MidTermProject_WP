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
    public partial class FormRemoveCourse : Form
    {
        courseFunction cf = new courseFunction();
        public FormRemoveCourse()
        {
            InitializeComponent();
        }

        //Cancel button (return main form)
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
            FormMain fm = new FormMain();
            fm.Show();
        }

        // remove course button
        private void remove_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(cid_txt.Text);
                if (cf.removeCourse(id))
                {
                    MessageBox.Show("Do you want to delete this course?", "Delete course", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    MessageBox.Show("Deleted!", "Delete course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cid_txt.Text = "";
                }
                else
                {
                    MessageBox.Show("Student not deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Please Enter a valid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
