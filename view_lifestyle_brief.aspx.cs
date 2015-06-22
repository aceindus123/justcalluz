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
using System.Web.Routing;

public partial class view_lifestyle_brief : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    string userid;
    InsertData obj = new InsertData();
    static string excep_page = "view_lifestyle_brief.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            //ddlPageSize.Visible = false;
            userid = Convert.ToString(Session["USERID"]);
            string regtype = Convert.ToString(Session["RegType"]);
            if (userid != "" && regtype == "Business")
            {
            
            }
            else if (userid != "" && regtype == "Individual")
            {

                //redirect("AuthenticationMsg.aspx?msg=LifeStyle", false);
                Response.RedirectToRoute("AuthenticationMsg", new { msg = "LifeStyle" });

            }

            else
                //redirect("signin.aspx?Qname=ViewLifeStyle", false);
                Response.RedirectToRoute("Signin", new { Qname = "ViewLifeStyle" });

            if (!IsPostBack)
            {
                BindGrid();
                ViewState["previouspage"] = Request.UrlReferrer;
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
    //            redirect(ViewState["previouspage"].ToString(),false);
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
            SqlCommand cmd = new SqlCommand("view_lifestyle", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UserLoginId", userid);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            viewlifestyledl.DataSource = ds;
            viewlifestyledl.DataBind();
            
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        
    }
    PagedDataSource pds = new PagedDataSource();
    public void BindGrid()
    {
        try
        {
            string userid = Convert.ToString(Session["USERID"]);
            SqlCommand cmd = new SqlCommand("view_lifestyle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserLoginId", userid);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            pds.DataSource = dt.DefaultView;
            pds.AllowPaging = true;
            //pds.PageSize = Convert.ToInt16(ddlPageSize.SelectedValue);
            pds.PageSize = 3;
            pds.CurrentPageIndex = CurrentPage;
            imgNext.Enabled = !pds.IsLastPage;
            imgPrevious.Enabled = !pds.IsFirstPage;
            viewlifestyledl.DataSource = pds;
            viewlifestyledl.DataBind();
            //doPaging();
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
    public void SendMail(string name, string fname, string email)
    {
        string Msg = "";

        try
        {
            
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
            catch (Exception ex1)
            {
                obj.insert_exception(ex1, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lnkBtnTocheckPostings_Click(object sender, EventArgs e)
    {
        userid = Convert.ToString(Session["USERID"]);
        try
        {
            if (Session["USERID"] != null)
            {
                redirect("ToCheckPostings.aspx?id=" + userid, false);
                ////Response.RedirectToRoute("checkposting", new {id = userid});
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
    //protected void cancel_Click(object sender, ImageClickEventArgs e)
    //{
    //    try
    //    {
    //        redirect("post_lifestyle.aspx",false);
    //    }
    //    catch (Exception ex)
    //    {
    //        obj.insert_exception(ex, excep_page);
    //        Response.Redirect("HttpErrorPage.aspx");
    //    }
    //}
    protected void viewlifestyledl_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        HtmlTableCell tdimge = (HtmlTableCell)e.Item.FindControl("tdlogo");
        Label imgname = (Label)e.Item.FindControl("lblImgName");
        if (imgname != null)
        {
            try
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
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
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
    protected string GetUrl(object lifeid)
    {
        string Lid = lifeid.ToString();
        return Page.GetRouteUrl("LifestyleDetails", new { id = Lid});
    }
    protected string GetEditUrl(object lifeid)
    {
        string Lid = lifeid.ToString();
        return Page.GetRouteUrl("editlife", new { id = Lid, cname = "LifeStyle" });
    }
}
