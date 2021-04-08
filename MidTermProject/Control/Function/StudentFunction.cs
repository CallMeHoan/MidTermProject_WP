using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace MidTermProject
{
    class StudentFunction
    {
        DBConnection dbcon = new DBConnection();
        public bool insertStudent(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO student (StudentID,FirstName,LastName,DateOfBirth,Gender,PhoneNumber,Address,Picture)" + " VALUES (@id,@fn,@ln,@bdt,@gdr,@phn,@adrs,@pic)", dbcon.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            dbcon.openConnection();
            if (command.ExecuteNonQuery() == 1)
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
        public DataTable getStudents(SqlCommand command)
        {
            DataTable table = new DataTable();
            try
            {
                command.Connection = dbcon.getConnection;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                return table;
            }
            catch
            {
                table = null;
                return table;
            }
            finally
            {
                dbcon.closeConnection();
            }
        }
        public bool deleteStudent(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM student WHERE StudentID = @id", dbcon.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
        public bool updateStudent(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE student SET FirstName=@fn,LastName=@ln,DateOfBirth=@bdt,Gender=@gdr,PhoneNumber=@phn,Address=@adrs,Picture=@pic WHERE StudentID=@id", dbcon.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
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
    }
}
