using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WorkDemo.App_Code;

namespace demo1
{
    public partial class GridView : System.Web.UI.Page
    {
        public string Name
        {
            get
            {
                return "张三";
            }
        }
        public string DataToString(DateTime dateTime)
        {
            return dateTime.ToString("yyyy年m月dd日");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Page.DataBind();
                BindBooks();

            }
        }

        private void BindBooks()
        {
            string sql = "select* from tb_bookinfo";
            DataSet dataSet = SqlHelper.ExecDataSet(sql);
            gvBookinfo.DataSource = dataSet.Tables[0];
            gvBookinfo.DataBind();
        }

        protected void gvBookinfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvBookinfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.gvBookinfo.PageIndex = e.NewPageIndex;
            BindBooks();
        }
    }
}