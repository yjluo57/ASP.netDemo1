using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace demo1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDataSet();
               // ReaderAdmin();
            }
        }
        private void BindDataSet()
        {
            SqlConnection conn = Util.getConnection();
            conn.Open();
            string sqlString = "select * from Administrator";
            SqlDataAdapter dap = new SqlDataAdapter(sqlString,conn);
            //dap.SelectCommand = new SqlCommand(sqlString, conn);
            DataSet ds = new DataSet();
            dap.Fill(ds, "admin");
            conn.Close();
            this.GridView1.DataSource = ds.Tables["admin"];
            this.GridView1.DataBind();

            this.DropDownList1.DataSource = ds.Tables["admin"];
            this.DropDownList1.DataTextField = "admin_name";
            this.DropDownList1.DataValueField = "admin_id";
            this.DropDownList1.DataBind();

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Util.getConnection();
            conn.Open();
            String sqlString = "select * from Administrator where admin_name='" + txtName + "'";
            SqlCommand command = new SqlCommand(sqlString);
            command.ExecuteNonQuery();
            conn.Close();

        }
        private void ReaderAdmin()
        {
            SqlConnection conn = Util.getConnection();
            conn.Open();
            string sqlString = "select * from Administrator";
            SqlCommand cmd = new SqlCommand(sqlString, conn);
            SqlDataReader dar= cmd.ExecuteReader();
            this.Label1.Text = "id\t\tname\t\tloginpasswd<br/>";
            while (dar.Read())
            {
                this.Label1.Text += dar["admin_id"].ToString() + "\t\t"
                    + dar["admin_name"].ToString() + "<br/>";
            }
            dar.Close();
            conn.Close();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            this.Label1.Text = this.DropDownList1.SelectedItem.Text;
        }
    }
}