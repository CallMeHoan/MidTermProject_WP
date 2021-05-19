using MidTermProject;
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

namespace Lab08
{
    public partial class Select_Contact_Form : Form
    {
        public Select_Contact_Form()
        {
            InitializeComponent();
        }

        private void Select_Contact_Form_Load(object sender, EventArgs e)
        {
            CONTACT contact = new CONTACT();
            SqlCommand command = new SqlCommand("SELECT ID ,  FirstName  as 'first name',  LastName  as 'last name',  GroupID  as'group id' FROM  Contact  WHERE  UserID  = @uid");
            command.Parameters.Add("@uid", SqlDbType.Int).Value = Globals.GlobalUserId;
            dataGridView1.DataSource = contact.SelectContactList(command);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
