using MidTermProject;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Lab08
{
    class User
    {
        DBConnection dbcon = new DBConnection();
        public DataTable getUserById(Int32 userid)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM User WHERE Id = @uid",dbcon.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        // Function to insert a new user
        public bool insertUser(string fname, string lname,string username, string password, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [User] (FirstName, LastName, UserName, Password, Picture) VALUES (@fn, @ln, @un,@pass, @pic)", dbcon.getConnection);
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            dbcon.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                dbcon.closeConnection();
                return true;
            }
            else
            {
                dbcon.closeConnection();
                return false;
            }
        }

        // kiem tra ton tai, lam theo kieu flag. van con sai
        public bool usernameExist(string username, string operation, int userid = 0)
        {
            string query = "";
            if (operation == "register")
            {
                query = "SELECT * FROM User WHERE UserName = @un";
            }
            else if(operation == "edit")
            {
                query = "SELECT * FROM User WHERE UserName = @un AND ID <> @uid";
            }

            SqlCommand command = new SqlCommand(query, dbcon.getConnection);

            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;


            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // update a user information
        public bool updateUser(int userid, string fname, string lname, string username, string password, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE User SET FirstName=@fn,LastName=@ln,UserName=@un,Password=@pass,Picture=@pic WHERE id=@uid", dbcon.getConnection);

            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            dbcon.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                dbcon.closeConnection();
                return true;
            }
            else
            {
                dbcon.closeConnection();
                return false;
            }
        }
    }
}
