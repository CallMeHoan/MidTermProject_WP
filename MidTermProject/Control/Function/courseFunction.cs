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
    class courseFunction
    {
        MyCourses course = new MyCourses();

        //Insert course
        public bool insertCourse(int id, string name, int period, string des)
        {
            SqlCommand command = new SqlCommand("insert into courses (CourseID,Label,Period,Description)" + "values (@id,@cname,@period,@des)", course.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@cname", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@period", SqlDbType.Int).Value = period;
            command.Parameters.Add("@des", SqlDbType.Text).Value = des;

            course.openConnectionState();
            if (command.ExecuteNonQuery() == 1)
            {
                course.closeConnection();
                return true;
            }
            else
            {
                course.closeConnection();
                return false;
            }
        }

        // Remove course
        public bool removeCourse(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM courses WHERE CourseID = @id", course.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            course.openConnectionState();
            if ((command.ExecuteNonQuery() == 1))
            {
                course.closeConnection();
                return true;
            }
            else
            {
                course.closeConnection();
                return false;
            }
        }
        //update student
        public bool updateCourse(int id, string name, int period, string des)
        {
            SqlCommand command = new SqlCommand("UPDATE courses SET CourseID = @id, LaBel = @cname, Period = @period, Description = @des WHERE CourseID=@id", course.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@cname", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@period", SqlDbType.Int).Value = period;
            command.Parameters.Add("@des", SqlDbType.Text).Value = des;

            course.openConnectionState();
            if ((command.ExecuteNonQuery() == 1))
            {
                course.closeConnection();
                return true;
            }
            else
            {
                course.closeConnection();
                return false;
            }
        }
    }
}
