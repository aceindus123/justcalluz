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

public partial class usercontrols_rightsearch : System.Web.UI.UserControl
{
    InsertData obj = new InsertData();
    static string excep_page = "rightsearch.ascx";
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                Bindstatedropdown();
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }
    }
    protected void Bindstatedropdown()
    {
        try
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select state_name from states", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            ddlstate.DataSource = ds;
            ddlstate.DataTextField = "state_name";
            ddlstate.DataValueField = "state_name";
            ddlstate.DataBind();
            ddlstate.Items.Insert(0, "select");
            ddlcity.Items.Insert(0, "select");
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }

    protected void ddlstate_selectedindexchanged(object sender, EventArgs e)
    {
        try
        {
            ddlcity.Enabled = true;
            string statename = ddlstate.SelectedItem.ToString();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select city_name from cities where state_name='" + statename + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            ddlcity.DataSource = ds;
            ddlcity.DataTextField = "city_name";
            ddlcity.DataValueField = "city_name";
            ddlcity.DataBind();
            ddlcity.Items.Insert(0, "select");
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void srchbtn_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            string mod = Session["searchpg"].ToString();
            string rgt_city = ddlcity.SelectedItem.Text;
            if (mod == "jobs")
            {
                Response.RedirectToRoute("rgt_jobs", new { city = rgt_city, cname = "jobs" });
                //redirect("jobs.aspx?city=" + city + "&cname=jobs",false);
            }
            else if (mod == "events")
            {
                //redirect("events.aspx?city=" + city + "&cname=events",false);
                Response.RedirectToRoute("rgt_Events", new { city = rgt_city, cname = "events" });
            }
            else if (mod == "discounts")
            {
                //redirect("discounts.aspx?city=" + city + "&cname=discounts",false);
                Response.RedirectToRoute("rgt_discounts", new { city = rgt_city, cname = "discounts" });
            }
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
