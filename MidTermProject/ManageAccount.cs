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
    class ManageAccount
    {
        public bool insertAcc(string acc, string pass)
        {
            MyAccount db = new MyAccount();
            SqlCommand command = new SqlCommand("INSERT INTO accou (acc,pass)" + " VALUES (@acc,@pass)", db.getConnection);
            command.Parameters.Add("@acc", SqlDbType.NVarChar).Value = acc;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = pass;
            db.openConnection();
            try
            {
                if ((command.ExecuteNonQuery() == 1))
                {
                    db.closeConnection();
                    return true;
                }
                else
                {
                    db.closeConnection();
                    return false;
                }
            }
            catch
            {
                db.closeConnection();
                return false;
            }
            
        }    
    }
}
