using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MidTermProject
{
    class MyDB
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1559CCJ;Initial Catalog=student;Integrated Security=True");

        public SqlConnection GetConnection
        {
            get
            {
                return con;
            }
        }

        public void openConnectionState()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }
        }

        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
