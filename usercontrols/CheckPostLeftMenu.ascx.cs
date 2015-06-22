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

public partial class usercontrols_CheckPostLeftMenu : System.Web.UI.UserControl
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    DataSet ds = new DataSet();
    string uid;
    InsertData obj = new InsertData();
    static string excep_page;
     protected void Page_Load(object sender, EventArgs e)
    {
        uid = Convert.ToString(Session["USERID"]);
        try
        {
           
            if (!Page.IsPostBack)
            {
                if (Session["USERID"] != null)
                {
                    con.Open();
                    string LoginId = Convert.ToString(Page.RouteData.Values["id"]);
                    SqlDataAdapter da = new SqlDataAdapter("select RegType from register where email='" + LoginId + "'", con);
                    da.Fill(ds);
                    if (!ds.Tables[0].Rows.Count.Equals(0))
                    {
                        string RegType = ds.Tables[0].Rows[0]["RegType"].ToString();
                        if (RegType == "Individual")
                        {
                            trAdvertise.Visible = false;
                            trDiscounts.Visible = false;
                            trEvents.Visible = false;
                            trFreeListing.Visible = true;
                            trJobs.Visible = false;
                           // trLifeStyle.Visible = false;
                            excep_page = "" + RegType + " link in CheckPostLeftMenu Usercontrol";

                        }
                        else if (RegType == "Business")
                        {
                            trAdvertise.Visible = true;
                            trDiscounts.Visible = true;
                            trEvents.Visible = true;
                            trFreeListing.Visible = true;
                            trJobs.Visible = true;
                            //trLifeStyle.Visible = true;
                            excep_page = "" + RegType + " link in CheckPostLeftMenu usercontrol";

                        }
                    }
                    else
                    {
                        excep_page = "CheckPostLeftMenu usercontrol";
                    }

                    con.Close();
                }
                else
                {
                    Response.RedirectToRoute("free");
                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lnkBtnBusInfo_Click(object sender, EventArgs e)
    {
        try
        {
            if (Convert.ToString(Session["USERID"]) != "")
            {
                uid = Convert.ToString(Session["USERNAME"]);
                //redirect("ToCheckPostings.aspx?cname=Category&id=" + uid,false);
                Response.RedirectToRoute("tocheck", new { cname = "Category", id = uid });
                excep_page = "Advertise With Us Info link in CheckPostLeftMenu Usercontrol";
            }
            else
            {
                string strScript = "";
                strScript = "alert('Your session is expired. Please Relogin');location.replace('signin');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    /// To get the free listing info
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkBtnFreeListing_Click(object sender, EventArgs e)
    {
        try
        {
            if (Convert.ToString(Session["USERID"]) != "")
            {
                //redirect("ToCheckPostings.aspx?cname=FreeListing&id=" + uid,false);
                //Response.RedirectToRoute("free");
                Response.RedirectToRoute("checkFreelisting", new { cname = "FreeListing" });
                excep_page = "FreeListing link in CheckPostLeftMenu Usercontrol";
            }
            else
            {
                string strScript = "";
                strScript = "alert('Your session is expired. Please Relogin'); location.replace('signin');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    /// To get the Discounts
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkBtnDiscounts_Click(object sender, EventArgs e)
    {
        try
        {
            if (Session["USERID"] != null)
            {
               //redirect("view_discounts.aspx",false);
               Response.RedirectToRoute("ViewDiscount");
               excep_page = "view_discounts link in CheckPostLeftMenu Usercontrol";
            }
            else
            {
                string strScript = "";
                strScript = "alert('Your session is expired. Please Relogin'); location.replace('signin');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    /// To get the events
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkbtnEvents_Click(object sender, EventArgs e)
    {
        try
        {
            if (Session["USERID"] != null)
            {
                //redirect("view_events.aspx",false);
                Response.RedirectToRoute("viewEvents");
                excep_page = "view_events link in CheckPostLeftMenu Usercontrol";
            }
            else
            {
                string strScript = "";
                strScript = "alert('Your session is expired. Please Relogin'); location.replace('signin');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    /// To get the jobs
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkBtnJobs_Click(object sender, EventArgs e)
    {
        try
        {
            if (Session["USERID"] != null)
            {
                //redirect("view_jobs.aspx?cname=Jobs&id=" + uid,false);
                Response.RedirectToRoute("Viewjob");
                excep_page = "view_jobs link in CheckPostLeftMenu Usercontrol";
            }
            else
            {
                string strScript = "";
                strScript = "alert('Your session is expired. Please Relogin'); location.replace('signin');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    //protected void lnklifestylebtn_Click(object sender, EventArgs e)
    //{
    //    try
    //    {

    //        if (Session["USERID"] != null)
    //        {
    //            //redirect("view_lifestyle_brief.aspx",false);
    //            Response.RedirectToRoute("viewLife");
    //            excep_page = "view_lifestyle_brief link in CheckPostLeftMenu Usercontrol";
    //        }
    //        else
    //        {
    //            string strScript = "";
    //            strScript = "alert('Your session is expired. Please Relogin');location.replace('signin');";
    //            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        obj.insert_exception(ex, excep_page);
    //        Response.Redirect("HttpErrorPage.aspx");
    //    }
    //}
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
