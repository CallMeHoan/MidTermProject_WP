using System.Data;
using System.Data.SqlClient;

namespace MidTermProject
{
    class GROUP
    {
        DBConnection dbcon = new DBConnection();

        // Function to insert a new group
        public bool insertGroup(int id, string gname, int userid)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Groups (ID, Name, UserID) VALUES (@id, @gn, @uid)", dbcon.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@gn", SqlDbType.VarChar).Value = gname;
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

        // update khi thay doi ten
        public bool updateGroup(int gid, string gname)
        {
            SqlCommand command = new SqlCommand("UPDATE Groups SET Name = @name WHERE ID = @id", dbcon.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = gid;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = gname;

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

        //Xoa
        public bool deleteGroup(int groupid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Groups WHERE ID = @id", dbcon.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = groupid;
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

        // Chức năng này quan trọng, xác định group cho userid nào
        public DataTable getGroups(int userid)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Groups WHERE UserID = @id", dbcon.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = userid;
            command.Connection = dbcon.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // Phan nay kiem tra xem grp co ton tai chua,copy tu phan truoc, thay doi de ktra ID trong muc Add Contact
        public bool groupExist(string name, string operation, int userid,int groupid = 0)
        {
            string query = "";

            SqlCommand command = new SqlCommand(query, dbcon.getConnection);

            if (operation == "add")
            {
                query = "SELECT * FROM Groups WHERE Name = @name AND UserID = @uid";

                command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            }
            else if (operation == "edit")
            {
                query = "SELECT * FROM Groups WHERE Name = @name AND UserID = @uid AND ID <> @gid";

                command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
                command.Parameters.Add("@gid", SqlDbType.Int).Value = groupid;
            }


            command.Connection = dbcon.getConnection;
            command.CommandText = query;


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

        public bool checkID(int groupid)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM Groups WHERE ID = @gid", dbcon.getConnection);

            command.Parameters.Add("@gid", SqlDbType.Int).Value = groupid;



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
