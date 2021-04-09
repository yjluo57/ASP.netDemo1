using System;
using System.Data;
using System.Data.SqlClient;
using demo1.App_Code;
namespace demo1
{
    public partial class HomeWord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = Util.getConnection();
            conn.Open();
            string sqlString = "select * from tb_booktype";
            SqlDataAdapter dap = new SqlDataAdapter(sqlString, conn);
            //dap.SelectCommand = new SqlCommand(sqlString, conn);
            DataSet ds = new DataSet();
            dap.Fill(ds, "booktype");
            this.DropDownList1.DataSource = ds.Tables["booktype"];
            this.DropDownList1.DataTextField = "name";
            this.DropDownList1.DataValueField = "id";
            this.DropDownList1.DataBind();
            string sqlString1 = "select * from tb_bookcase";
            SqlDataAdapter dap1 = new SqlDataAdapter(sqlString1, conn);
            //dap.SelectCommand = new SqlCommand(sqlString1, conn);
            DataSet ds1 = new DataSet();
            dap1.Fill(ds1, "bookcase");
            conn.Close();
            this.DropDownList2.DataSource = ds1.Tables["bookcase"];
            this.DropDownList2.DataTextField = "name";
            this.DropDownList2.DataValueField = "id";
            this.DropDownList2.DataBind();
            if (!IsPostBack)
            {
                string sql = "select * from tb_bookcase;select * from tb_booktype";
                DataSet ds2 = SqlHelper.ExecDataSet(sql);


            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string bookcode = TextBox1.Text;
            string bookname = TextBox2.Text;
            string type = DropDownList1.SelectedValue;
            string author = TextBox3.Text;
            string translator = TextBox4.Text;
            string pubname = TextBox5.Text;
            int price = int.Parse(TextBox6.Text);
            int page = int.Parse(TextBox7.Text);
            string bcase = DropDownList2.SelectedValue;
            int storage = int.Parse(TextBox8.Text);
            DateTime inTime = Convert.ToDateTime(TextBox9.Text);
            string oper = TextBox10.Text;
            //添加
            SqlConnection conn = Util.getConnection();
            conn.Open();
            string sql = "insert into tb_bookinfo(bookcode,bookname,type,author,translator,pubname,price,page,bcase,storage,inTime,oper )values('" + bookcode + "','" + bookname + "','" + type + "','" + author + "','" + translator + "','" + pubname + "','" + price + "','" + page + "','" + bcase + "','" + storage + "','" + inTime + "','" + oper + "')";
            //string sql = "insert into tb_bookinfo(bookcode,bookname)values(bookcode,bookname)";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.ExecuteNonQuery();
            conn.Close();


        }
    }
}