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
        protected void Page_Load(object sender, EventArgs e)
        {
            string sql = "select* from tb_bookinfo";
            DataSet dataSet = SqlHelper.ExecDataSet(sql);
            gvBookinfo.DataBind();
        }
    }
}