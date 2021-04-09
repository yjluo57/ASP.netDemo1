using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace demo1
{
    public class Util
    {
        public static SqlConnection getConnection()
        {
            string connString = "server=localhost;database=db_LibraryMS;uid=sa;pwd=123";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}