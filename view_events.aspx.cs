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
using System.Net.Mail;
using System.Net;
using System.Net.NetworkInformation;
using System.Web.Routing;

public partial class view_events : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    string userid;
    InsertData obj = new InsertData();
    static string excep_page = "view_events.aspx";

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            userid = Convert.ToString(Session["USERID"]);
            string regtype = Convert.ToString(Session["RegType"]);
            if (userid != "" && regtype == "Business")
            {


            }
            else if (userid != "" && regtype == "Individual")
            {
                //redirect("AuthenticationMsg.aspx?msg=Events",false);
                Response.RedirectToRoute("AuthenticationMsg", new { msg = "Events" });
                
            }

            else
              // redirect("signin.aspx?Qname=Events",false);
                Response.RedirectToRoute("Signin", new { Qname = "Events" });

            if (!IsPostBack)
            {
                try
                {
                    BindGrid();
                    ViewState["previouspage"] = Request.UrlReferrer;
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        

    }

    /// <summary>
    /// Displaying the details of posted events to corresponding authenticated user 
    /// </summary>

    //protected void back_Click(object sender, ImageClickEventArgs e)
    //{
    //    try
    //    {
    //        if (ViewState["previouspage"] != null)
    //            redirect(ViewState["previouspage"].ToString(), false);
    //    }
    //    catch (Exception ex)
    //    {
    //        obj.insert_exception(ex, excep_page);
    //        Response.Redirect("HttpErrorPage.aspx");
    //    }
        
    //}
    protected void viewevent_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        try
        {

            string userid = Convert.ToString(Session["USERID"]);
            //int st;
            con.Open();
            SqlCommand cmd = new SqlCommand("view_events", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UserLoginId", userid);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            vieweventdl.DataSource = ds;
            vieweventdl.DataBind();
            con.Close();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }

    //protected void submitbutton_Click(object sender, EventArgs e)
    //{
    //    string name = txtname1.Text;
    //    string fname = txtfname.Text;
    //    string email = txtmob.Text;
    //    SendMail(name, fname, email);
    //    string strScript = string.Empty;
    //    strScript = "alert('Thank you! You have successfully shared with your friend.');location.replace('Eventshome.aspx');";
    //    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
    //}
    /// <summary>
    /// Applying paging in the form
    /// </summary>
    PagedDataSource pds = new PagedDataSource();
    public void BindGrid()
    {
        try
        {
            string userid = Convert.ToString(Session["USERID"]);
            con.Open();
            SqlCommand cmd = new SqlCommand("view_events", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserLoginId", userid);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            pds.DataSource = dt.DefaultView;
            pds.AllowPaging = true;
            //pds.PageSize = Convert.ToInt16(ddlPageSize.SelectedValue);
            pds.PageSize = 3;
            pds.CurrentPageIndex = CurrentPage;
            imgNext.Enabled = !pds.IsLastPage;
            imgPrevious.Enabled = !pds.IsFirstPage;
            vieweventdl.DataSource = pds;
            vieweventdl.DataBind();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    public int CurrentPage
    {
        get
        {
            if (this.ViewState["CurrentPage"] == null)
                return 0;
            else
                return Convert.ToInt16(this.ViewState["CurrentPage"].ToString());
        }
        set
        {
            this.ViewState["CurrentPage"] = value;
        }
    }
    protected void imgPrevious_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            CurrentPage -= 1;
            BindGrid();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        
    }
    protected void imgNext_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            CurrentPage += 1;
            BindGrid();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        
    }
    // sending mail

    public void SendMail(string name, string fname, string email)
    {
            string Msg = "";

            try
            {
                MailMessage mm = new MailMessage();
                mm.From = new MailAddress("info@aceindus.in");
                //mm.To = "test_indus@yahoo.com";
                mm.To.Add(email);
                Msg += "Dear <b>" + fname + "</b> ," +

                            "<br>Your Friend " + name + "</b>," +
                            "<br> Suggested you to get through the site Justcalluz.com or dial 99166136226." +
                            "<br>To get an information regarding jobs,Real estates,discounts,events,Restaurents,Movies etc.," +
                            "<br>what not ? all within seconds" +

                            "<br><br> JustCalluz is a fastest growing local search engine, operating from Hyderabad, India.A JustCalluz visitor can get the desired business information instantly by selecting a location name from the given options and enter the search keyword in the search option." +
                            "<br><br>JustCalluz works 24/7 to find innovative ways and make local search much easier & simpler, we welcome people with creative ideas and zeal to learn & develop." +


                            "<br><br>Warm Regards," +
                            "<br> Team JustCalluz";
                mm.Subject = "suggestion of your friend";
                mm.IsBodyHtml = true;
                mm.Body = Msg;
                SmtpClient smtp = new SmtpClient();
                smtp.Send(mm);

            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        
    }
    /// <summary>
    /// To get the Advertise with us info
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    //protected void lnkBtnBusInfo_Click(object sender, EventArgs e)
    //{

    //    if (Session["USERID"] != null)
    //    {
    //        Response.Redirect("ToCheckPostings.aspx?cname=Category&&id=" + userid);
    //    }
    //    else
    //    {
    //        string strScript = "";
    //        strScript = "alert('Your session is expired. Please Relogin'); location.replace('signin.aspx');";
    //        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
    //    }
    //}
    /// <summary>
    /// To get the free listing info
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    //protected void lnkBtnFreeListing_Click(object sender, EventArgs e)
    //{

    //    if (Session["USERID"] != null)
    //    {
    //        Response.Redirect("ToCheckPostings.aspx?cname=FreeListing&&id=" + userid);
    //    }
    //    else
    //    {
    //        string strScript = "";
    //        strScript = "alert('Your session is expired. Please Relogin'); location.replace('signin.aspx');";
    //        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
    //    }
    //}
    /// <summary>
    /// To get the Discounts
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    //protected void lnkBtnDiscounts_Click(object sender, EventArgs e)
    //{
    //    if (Session["USERID"] != null)
    //    {
    //        Response.Redirect("view_discounts.aspx");
    //    }
    //    else
    //    {
    //        string strScript = "";
    //        strScript = "alert('Your session is expired. Please Relogin'); location.replace('signin.aspx');";
    //        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
    //    }
    //}
    /// <summary>
    /// To get the events
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    //protected void lnkbtnEvents_Click(object sender, EventArgs e)
    //{
    //    if (Session["USERID"] != null)
    //    {
    //        Response.Redirect("view_events.aspx");
    //    }
    //    else
    //    {
    //        string strScript = "";
    //        strScript = "alert('Your session is expired. Please Relogin'); location.replace('signin.aspx');";
    //        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
    //    }
    //}
    /// <summary>
    /// To get the jobs
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    //protected void lnkBtnJobs_Click(object sender, EventArgs e)
    //{
    //    if (Session["USERID"] != null)
    //    {
    //        Response.Redirect("view_jobs.aspx?cname=Jobs&&id=" + userid);
    //    }
    //    else
    //    {
    //        string strScript = "";
    //        strScript = "alert('Your session is expired. Please Relogin'); location.replace('signin.aspx');";
    //        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
    //    }
    //}
    protected void lnkBtnTocheckPostings_Click(object sender, EventArgs e)
    {
        if (Session["USERID"] != null)
        {
            redirect("ToCheckPostings.aspx?id=" + userid,false);
        }
        else
        {
            string strScript = "";
            strScript = "alert('Your session is expired. Please Relogin'); location.replace('signin.aspx');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
        }

    }
    protected void cancel_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("post_event.aspx");
    }
    protected void vieweventdl_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        try
        {
            HtmlTableCell tdimge = (HtmlTableCell)e.Item.FindControl("tdlogo");
            Label imgname = (Label)e.Item.FindControl("lblImgName");
            if (imgname != null)
            {
                if (imgname.Text == "NULL" || imgname.Text == "0" || imgname.Text == "" || imgname.Text == "null")
                {
                    tdimge.Visible = false;
                }
                else
                {
                    tdimge.Visible = true;
                }
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
    protected string GetCompUrl(object Eid)
    {
        string EventId = Eid.ToString();
        return Page.GetRouteUrl("eventDetails", new {id=EventId,cname="events" });
    }
    protected string GetEditUrl(object Eid)
    {
        string EventId = Eid.ToString();
        return Page.GetRouteUrl("EditEvents", new { id = EventId, cname = "events" });
    }
}






