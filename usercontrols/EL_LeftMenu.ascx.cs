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

public partial class usercontrols_EL_LeftMenu : System.Web.UI.UserControl
{
    int id;
    string businame;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null)
        {
            id = Convert.ToInt16(Request.QueryString["id"]);
        }
        if (Request.QueryString["cname"] != null)
        {
            businame = Request.QueryString["cname"].ToString();
        }

    }
    protected void lnkLocaton_Click(object sender, EventArgs e)
    {
        Response.Redirect("EditListing.aspx?id=" + id + "&cname='" + businame + "'");
    }
    protected void lnkcontactinfo_Click(object sender, EventArgs e)
    {
        Response.Redirect("EL_ContactInfo.aspx?id=" + id + "&cname='" + businame + "'");
    }
    protected void lnkotherinfo_Click(object sender, EventArgs e)
    {
        Response.Redirect("EL_OtherInfo.aspx?id=" + id + "&cname='" + businame + "'");
    }
    protected void lnkbusikeywrds_Click(object sender, EventArgs e)
    {
        Response.Redirect("EL_Busineskeywrds.aspx?id=" + id + "&cname='" + businame + "'");
    }
    protected void lnkaddremwrd_Click(object sender, EventArgs e)
    {
        Response.Redirect("EL_Busineskeywrds.aspx?id=" + id + "&cname='" + businame + "'");
    }
    protected void lnkadd_Click(object sender, EventArgs e)
    {
        Response.Redirect("EditListing.aspx?id=" + id + "&cname='" + businame + "'");
    }
}
