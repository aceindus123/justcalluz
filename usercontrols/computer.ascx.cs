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

public partial class usercontrol_computer : System.Web.UI.UserControl
{
    DataAccess obj1 = new DataAccess();
    InsertData obj = new InsertData();
    protected void Page_Load(object sender, EventArgs e)
    {
        //DataList1.Visible = true;
        //DataSet ds = new DataSet();
        //ds = obj.bindcathead();
        //DataList1.DataSource = ds;
        //DataList1.DataBind();
    }

    //protected void DataList1_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    //{
    //    Session["name"] = e.CommandArgument.ToString();
    //    string name = "";
    //    name = e.CommandArgument.ToString();
    //    Response.Redirect("linkcontroller.aspx?cname=" + name + "");

    //}
    protected void Category(object sender, CommandEventArgs e)
    {
        string cat = e.CommandArgument.ToString();
        Response.Redirect("linkcontroller.aspx?cname=" + Server.UrlEncode(cat));
    }
}
