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

public partial class usercontrols_toplife : System.Web.UI.UserControl
{
    InsertData obj = new InsertData();
    static string excep_page = "toplife.ascx";
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void jwell_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            //redirect("Lifestylesub.aspx?cat=Jewellery",false);
            Response.RedirectToRoute("LifeStyle_Sub", new { cat = "Jewellery" });
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void car_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            //redirect("Lifestylesub.aspx?cat=Car",false);
            Response.RedirectToRoute("LifeStyle_Sub", new { cat = "Car" });
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lugg_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            //redirect("Lifestylesub.aspx?cat=Luggage",false);
            Response.RedirectToRoute("LifeStyle_Sub", new { cat = "Luggage" });
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void watch_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            //redirect("Lifestylesub.aspx?cat=Wrist Watch",false);
            Response.RedirectToRoute("LifeStyle_Sub", new { cat = "Wrist Watch" });
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void fashion_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            //redirect("Lifestylesub.aspx?cat=Fashion Designer Stores", false);
            Response.RedirectToRoute("LifeStyle_Sub", new { cat="Fashion Designer Stores" });
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void sunglass_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            //redirect("Lifestylesub.aspx?cat=Sunglass",false);
            Response.RedirectToRoute("LifeStyle_Sub", new { cat = "Sunglass" });
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    public void redirect(string url, bool val)
    {
        if (!val)
        {
            HttpContext.Current.Response.Redirect(url, false);
            HttpContext.Current.ApplicationInstance.CompleteRequest();
        }
        else
        {
            HttpContext.Current.Server.ClearError();
            HttpContext.Current.Response.Redirect(url, false);
            HttpContext.Current.Server.ClearError();
        }

    }
}
