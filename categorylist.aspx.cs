using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class categorylist : System.Web.UI.Page
{
    InsertData obj = new InsertData();
    string sid = string.Empty;
    int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        DataList1.Visible = true;
        DataSet ds = new DataSet();
        ds = obj.bindcategory();
        DataList1.DataSource = ds;
        DataList1.DataBind();
    }
}
