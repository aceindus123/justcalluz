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

public partial class usercontrols_everight : System.Web.UI.UserControl
{
    InsertData obj = new InsertData();
    string sid = string.Empty;
    
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
    protected void Page_Load(object sender, EventArgs e)
    {
        DataList3.Visible = true;
        DataSet ds2 = new DataSet();
        //ds2 = obj.bindsponseredlinks();
        DataList3.DataSource = ds2;
        DataList3.DataBind();

        dlcities.Visible = true;
        DataSet ds1 = new DataSet();
        ds1 = obj.bindpopcities();
        dlcities.DataSource = ds1;
        dlcities.DataBind();
    }
    protected void dlcities_ItemCommand(object source, DataListCommandEventArgs e)
    {
        Session["name"] = e.CommandArgument.ToString();
        string name = "";
        name = e.CommandArgument.ToString();
        Response.Redirect("Eventslink.aspx?popcity=" + name + "");
    }


    
}
