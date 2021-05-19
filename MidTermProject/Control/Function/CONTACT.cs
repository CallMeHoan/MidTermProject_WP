using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace MidTermProject
{
    class CONTACT
    {
        DBConnection dbcon = new DBConnection();
        // Function to insert a new contact
        public bool insertContact(int contactid, string fname, string lname, string phone, string address,string email,int userid,int groupid, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Contact (ID, FirstName, LastName, GroupID, Phone, Email, Address, Picture, UserID) VALUES (@id, @fn, @ln, @grp, @phn, @mail, @adrs, @pic, @uid)", dbcon.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = contactid;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@grp", SqlDbType.Int).Value = groupid;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;

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

        // Function to update contact
        public bool updateContact(int contactid, string fname, string lname, string phone, string address, string email, int groupid, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE Contact SET FirstName = @fn, LastName = @ln, GroupID = @gid, Phone = @phn, Email = @mail, Address = @adrs, pic = @pic WHERE ID = @id ", dbcon.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = contactid;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@gid", SqlDbType.Int).Value = groupid;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
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

        // delete Contact
        public bool deleteContact(int contactid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Contact WHERE ID = @id", dbcon.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = contactid;
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


        // nap du lieu
        public DataTable SelectContactList(SqlCommand command)
        {
            command.Connection = dbcon.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // create a function to get all contact by userid
        public DataTable getAllContactById(int userid)
        {
            SqlCommand command = new SqlCommand("SELECT *  FROM Groups WHERE UserID = @uid", dbcon.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        public DataTable GetContactById(int contactId)
        {
            SqlCommand command = new SqlCommand("SELECT ID, FirstName, LastName, GroupID, Phone, Email, Address, Picture, UserID FROM Contact WHERE ID = @id", dbcon.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = contactId;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // Check Id in contact have exist or not
        public bool checkID(int contactid)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM Contact WHERE ID = @cid", dbcon.getConnection);

            command.Parameters.Add("@cid", SqlDbType.Int).Value = contactid;
     


            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            if (table.Rows.Count > 0)
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
