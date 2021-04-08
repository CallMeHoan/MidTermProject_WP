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
    class AccountFunction
    {
        public bool insertAcc(string acc, string pass)
        {
            DBConnection dbcon = new DBConnection();
            SqlCommand command = new SqlCommand("INSERT INTO account (acc,pass)" + " VALUES (@acc,@pass)", dbcon.getConnection);
            command.Parameters.Add("@acc", SqlDbType.NVarChar).Value = acc;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = pass;
            dbcon.openConnection();
            try
            {
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
            catch
            {
                dbcon.closeConnection();
                return false;
            }

        }
    }
}
