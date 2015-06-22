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
using System.Collections.Specialized;
using System.Reflection;
using System.Collections.Generic;
using System.Web.Routing;

public partial class White_Page : System.Web.UI.Page
{
    InsertData obj = new InsertData();
    static string excep_page = "White_Page.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                dlpopcities.Visible = true;
                DataSet ds25 = new DataSet();
                ds25 = obj.bindpopcities();
                dlpopcities.DataSource = ds25;
                dlpopcities.DataBind();
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }
    }
    protected string GetUrl(object pcity)
    {
        string PopCity = pcity.ToString();
        return Page.GetRouteUrl("WhitePageDetails", new { city = PopCity });
    }
   
}
