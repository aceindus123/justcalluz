using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class usercontrols_WebUserControl : System.Web.UI.UserControl
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    InsertData obj = new InsertData();
    string strname = string.Empty;
    string scname;
    string rname;
    DataSet ds = new DataSet();
    // string name;
    static string excep_page = "innerleft1.ascx";
    protected void Page_Load(object sender, EventArgs e)
    {
        ds = obj.bindpopcat();
        
        if (ds.Tables[0].Rows.Count > 0)
        {
            dlpopcat.DataSource = ds;
            dlpopcat.DataBind();
        }
    }
    protected void dlpopcat_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        try
        {
            HyperLink btnCate = (HyperLink)e.Item.FindControl("lnkPopularCat");

            if (btnCate != null)
            {
                if (btnCate.Text == "")
                {
                    btnCate.Text = btnCate.ToolTip.ToString();
                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected string GetCatUrl(object name)
    {
        string catname = name.ToString();
        if (catname.Contains("&"))
        {
            catname = catname.Replace("&", "amprcent");
        }
        if (catname.Contains(" "))
        {
            catname = catname.Replace(" ", "space");
        }
        if (catname.Contains("."))
        {
            catname = catname.Replace(".", "Dot");
        }
        if (catname.Contains("/"))
        {
            catname = catname.Replace("/", "slash");
        }
        if (catname.Contains("_"))
        {
            catname = catname.Replace("_", "undrscore");
        }
        return Page.GetRouteUrl("Link", new { cname = catname });
    }
}