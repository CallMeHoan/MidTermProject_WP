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
using Lab08;

namespace MidTermProject
{
    public partial class FormLogin : Form
    {
        DBConnection dbcon = new DBConnection();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if(student_rbtn.Checked)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();

                DataTable table = new DataTable();

                SqlCommand command = new SqlCommand("SELECT * FROM account WHERE acc = @acc AND pass = @pass", dbcon.getConnection);

                command.Parameters.Add("@acc", SqlDbType.VarChar).Value = uname_txt.Text;
                command.Parameters.Add("@pass", SqlDbType.VarChar).Value = pword_txt.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if ((table.Rows.Count > 0))
                {
                    MessageBox.Show("Successfully Login <3");
                    Hide();
                    FormMain fm = new FormMain();
                    fm.Show(this);
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }    
            else if(human_rbtn.Checked)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();

                DataTable table = new DataTable();

                SqlCommand command = new SqlCommand("SELECT * FROM [User] WHERE UserName = @acc AND Password = @pass", dbcon.getConnection);

                command.Parameters.Add("@acc", SqlDbType.VarChar).Value = uname_txt.Text;
                command.Parameters.Add("@pass", SqlDbType.VarChar).Value = pword_txt.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if ((table.Rows.Count > 0))
                {
                    MessageBox.Show("Successfully Login <3");
                    Hide();
                    Contacts_Full_List_Form frm = new Contacts_Full_List_Form();
                    frm.Show(this);
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }    
            
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            Hide();
            FormSignUp signUp = new FormSignUp();
            signUp.Show(this);
        }
    }
}
