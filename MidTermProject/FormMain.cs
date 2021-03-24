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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void AddStuToolStrip_Click(object sender, EventArgs e)
        {
            Hide();
            FormAddStudent addStudent = new FormAddStudent();
            addStudent.Show(this);
        }

        private void ListStuToolStrip_Click(object sender, EventArgs e)
        {
            Hide();
            FormShowData showData = new FormShowData();
            showData.Show(this);
        }

        private void searchStuToolStrip_Click(object sender, EventArgs e)
        {
            Close();
            FormSearchStudent search = new FormSearchStudent();
            search.Show();
        }
    }
}
