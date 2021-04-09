using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace demo1.App_Code
{
    public class SqlHelper
    {
        private static string connString = ConfigurationManager.ConnectionStrings["SqlLibraryMS"].ConnectionString;
        private static SqlCommand PreParedCommand(string sql, SqlParamater[] commandparamaters, SqlConnection conn, SqlCommand cmd)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            cmd.CommandText = sql;
            cmd.Connection = conn;
            if (commandparamaters != null)
            {
                foreach (SqlParamater sp in commandparamaters)
                {
                    cmd.Parameters.Add(sp);
                }
            }
            return cmd;
        }
        public static int ExecNoQuery(string sql,params SqlParamater[] commandparamaters)
        {
            //using自动释放资源
            using(SqlConnection conn=new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd = PreParedCommand(sql, commandparamaters, conn, cmd);
                return cmd.ExecuteNonQuery();
            }
        }

        public static SqlDataReader ExecDataReader(string sql, SqlParamater[] sqlParamater)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            PreParedCommand(sql, sqlParamater, conn, cmd);
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        //执行查询，断开式
        public static DataSet ExecDataSet(string sql, params SqlParamater[] sqlParamaters)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand();
                PreParedCommand(sql, sqlParamaters, conn, cmd);
                using (SqlDataAdapter dap = new SqlDataAdapter())
                {
                    dap.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    dap.Fill(ds);
                    return ds;
                }
            }
        }
    }
    
}