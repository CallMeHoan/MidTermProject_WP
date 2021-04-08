using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MidTermProject
{
    class ScoreFunction
    {
        DBConnection dbcon = new DBConnection();
        public bool insertScore(int stuid, int cid, double score, string des)
        {
            SqlCommand command = new SqlCommand("insert into score (StudentID,CourseID,Score,Description)" + "values (@stuid,@cid,@score,@des)", dbcon.getConnection);
            command.Parameters.Add("@stuid", SqlDbType.Int).Value = stuid;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = cid;
            command.Parameters.Add("@score", SqlDbType.Float).Value = score;
            command.Parameters.Add("@des", SqlDbType.Text).Value = des;

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

        // Remove course
        public bool removeScore(int stuid, int cid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM score WHERE StudentID = @stuid and CourseID = @cid", dbcon.getConnection);
            command.Parameters.Add("@stuid", SqlDbType.Int).Value = stuid;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = cid;
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
        //update student
        public bool updateScore(int stuid, int cid, float score, string des)
        {
            SqlCommand command = new SqlCommand("UPDATE score SET StudentID = @stuid, CourseID = @cid, Score = @score, Description = @des WHERE StudentID = @stuid and CourseID=@cid", dbcon.getConnection);
            command.Parameters.Add("@stuid", SqlDbType.Int).Value = stuid;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = cid;
            command.Parameters.Add("@score", SqlDbType.Float).Value = score;
            command.Parameters.Add("@des", SqlDbType.Text).Value = des;

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
        public DataTable getCourse(SqlCommand command)
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
    }
}
