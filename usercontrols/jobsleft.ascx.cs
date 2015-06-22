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
using System.Web.Routing;

public partial class usercontrols_jobsleft : System.Web.UI.UserControl
{
    InsertData obj = new InsertData();
    static string excep_page = "jobsleft.ascx";
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                dljob.Visible = true;
                DataSet ds1 = new DataSet();
                //SqlCommand cmd = new SqlCommand("bindleftJobsUc_sp", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                //SqlDataAdapter sda = new SqlDataAdapter(cmd);
                //sda.Fill(ds1);
                ds1 = obj.bindleftjob();
                dljob.DataSource = ds1;
                dljob.DataBind();
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }
       
     
          
    }
    protected string GetCatUrls(object name)
    {

        string cname = Convert.ToString(name.ToString());
        cname = cname.Replace("/", "and");
        cname = cname.Replace("+", "-");
        cname = cname.Replace(".", "dot");
        return Page.GetRouteUrl("job_link", new { catname = cname, cname = "jobs" });
    }
    /// <summary>
    /// //Bounding data to the links in left menu
    /// </summary>
    /// <param name="source"></param>
    /// <param name="e"></param>
    //protected void dljob_ItemCommand(object source, DataListCommandEventArgs e)
    //{
    //    try
    //    {
    //        //Session["name"] = e.CommandArgument.ToString();
    //        string name = "";
    //        name = e.CommandArgument.ToString();
    //        redirect("joblinks.aspx?catname=" + Server.UrlEncode(name) + "&cname=jobs", false);
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
    protected void dljob_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        try
        {
            //Button btnJcate = (Button)e.Item.FindControl("btnJcate");
            HyperLink hyplnk=(HyperLink)e.Item.FindControl("lnkjob");
            if (hyplnk != null)
            {
                if (hyplnk.Text == "")
                {
                    hyplnk.Text = hyplnk.ToolTip.ToString();


                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
}
