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
using System.Web.Routing;

public partial class usercontrols_eventleft : System.Web.UI.UserControl
{
    InsertData obj = new InsertData();
    static string excep_page = "eventleft.ascx";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                dlevent.Visible = true;
                DataSet ds1 = new DataSet();
                ds1 = obj.bindevent();
                dlevent.DataSource = ds1;
                dlevent.DataBind();
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }

        
    }

    //protected void dlevent_ItemCommand(object source, DataListCommandEventArgs e)
    //{
    //    try
    //    {
    //        //Session["name"] = e.CommandArgument.ToString();
    //        string name = "";
    //        name = e.CommandArgument.ToString();
    //        redirect("Eventslink.aspx?Ecname=" + Server.UrlEncode(name) + "&cname=events", false);
    //    }
    //    catch (Exception ex)
    //    {
    //        obj.insert_exception(ex, excep_page);
    //        Response.Redirect("HttpErrorPage.aspx");
    //    }
    //}
    //public void redirect(string url, bool val)
    //{
    //    if (!val)
    //    {
    //        HttpContext.Current.Response.Redirect(url, false);
    //        HttpContext.Current.ApplicationInstance.CompleteRequest();
    //    }
    //    else
    //    {
    //        HttpContext.Current.Server.ClearError();
    //        HttpContext.Current.Response.Redirect(url, false);
    //        HttpContext.Current.Server.ClearError();
    //    }

    //}

    protected void dlevent_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        try
        {
            HyperLink Hypcate = (HyperLink)e.Item.FindControl("Hypcate");

            if (Hypcate != null)
            {
                if (Hypcate.Text == "")
                {
                    Hypcate.Text = Hypcate.ToolTip.ToString();


                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected string GeteventUrl(object catname)
    {
        string cat = catname.ToString();
        return Page.GetRouteUrl("event_lnk", new { Ecname = cat, cname = "events" });
    }
}

