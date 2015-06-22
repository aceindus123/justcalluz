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
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;

public partial class view_jobs : System.Web.UI.Page
{
    //To make connection
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    DataSet ds = new DataSet();
    string uid;
    InsertData obj = new InsertData();
    static string excep_page = "view_jobs.aspx";
    /// <summary>
    /// Executes Whenever Page Loads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            uid = Convert.ToString(Session["USERID"]);
            string regtype = Convert.ToString(Session["RegType"]);
            if (uid != "" && regtype == "Business")
            {


            }
            else if (uid != "" && regtype == "Individual")
            {

                redirect("AuthenticationMsg.aspx?msg=jobs", false);
            }
            else
                redirect("signin.aspx?Qname=jobs", false);

            if (!IsPostBack)
            {
                ItemsGet();

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
        try
        {
            if (Session["USERID"] != null)
            {
                redirect("ToCheckPostings.aspx?id=" + uid, false);
            }
            else
            {
                string strScript = "";
                strScript = "alert('Your session is expired. Please Relogin'); location.replace('signin.aspx');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    public void ItemsGet()
    {
        try
        {
            if (Session["USERID"] != null)
            {
                string strname = string.Empty;
                uid = Convert.ToString(Session["USERID"]);
                strname = "Jobs";
                SqlConnection con1 = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                SqlCommand cmd = new SqlCommand("View_jobs", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserLoginId", uid);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                con1.Open();
                DataTable dt = new DataTable();
                da1.Fill(dt);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                DataView dtView = ds1.Tables[0].DefaultView;
                if (ds1.Tables[0].Rows.Count != 0)
                {
                    string status = ds1.Tables[0].Rows[0]["Status"].ToString();
                    PagedDataSource objPds1 = new PagedDataSource();
                    dtView.Sort = "id DESC";
                    objPds1.AllowPaging = true;
                    objPds1.PageSize = 3;
                    objPds1.DataSource = dtView;
                    objPds1.CurrentPageIndex = CurrentPage;
                    lblCurrentPage.Text = "Page:" + (CurrentPage + 1).ToString() + " of " + objPds1.PageCount.ToString();
                    imgPrevious.Enabled = !objPds1.IsFirstPage;
                    imgNext.Enabled = !objPds1.IsLastPage;
                    lblHeading1.Text = "Jobs";
                    dldata.DataSource = objPds1;
                    dldata.DataBind();

                }
                else
                {
                    lblMsg.Text = "No records found.";
                    imgPrevious.Visible = false;
                    imgNext.Visible = false;
                }
                con.Close();
            }

            else
            {
                redirect("signin.aspx", false);
            }
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
            // look for current page in ViewState
            object o = this.ViewState["_CurrentPage"];
            if (o == null)
                return 0; // default to showing the first page
            else
                return (int)o;
        }
        set
        {
            this.ViewState["_CurrentPage"] = value;
        }
    }
    /// <summary>
    /// To perform action when you click on the previous button
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void imgPrevious_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            // Set viewstate variable to the previous page
            CurrentPage -= 1;
            // Reload control
            ItemsGet();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    /// To perform action when you click on the Next button
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void imgNext_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            // Set viewstate variable to the next page
            CurrentPage += 1;
            // Reload control
            ItemsGet();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lnkUpdate(object sender, CommandEventArgs e)
    {
        try
        {
            if (Session["USERID"] != null)
            {
                int Id = Convert.ToInt32(e.CommandArgument.ToString());
                string strname = Convert.ToString(Request.QueryString["cname"]);
                if (strname == "Category")
                {
                    redirect("Advertise_Edit.aspx?DID=" + Id, false);
                }
                else if (strname == "FreeListing")
                {
                    redirect("FreeListing_Edit.aspx?DID=" + Id, false);
                }
                else if (strname == "Jobs")
                {
                    redirect("edit_job.aspx?id=" + Id, false);
                }
            }
            else
            {
                string strScript = "";
                strScript = "alert('Your session is expired. Please Relogin'); location.replace('signin.aspx');";
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
    //        Response.Redirect("view_jobs.aspx?cname=Jobs&&id=" + uid);
    //    }
    //    else
    //    {
    //        string strScript = "";
    //        strScript = "alert('Your session is expired. Please Relogin'); location.replace('signin.aspx');";
    //        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
    //    }
    //}
    /// <summary>
    /// To get the Advertise with us info
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    //protected void lnkBtnBusInfo_Click(object sender, EventArgs e)
    //{
    //    if (Session["USERID"] != null)
    //    {
    //        Response.Redirect("ToCheckPostings.aspx?cname=Category&&id=" + uid);
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
    //        Response.Redirect("ToCheckPostings.aspx?cname=FreeListing&&id=" + uid);
    //    }
    //    else
    //    {
    //        string strScript = "";
    //        strScript = "alert('Your session is expired. Please Relogin'); location.replace('signin.aspx');";
    //        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
    //    }
    //}
    protected void dlData_ItemDataBound(object sender, DataListItemEventArgs e)
    {

        Label lblStatus = (Label)e.Item.FindControl("lblStatus");
        if (lblStatus != null)
        {
            try
            {
                string status = Convert.ToString(lblStatus.Text);

                if (status == "0")
                {
                    lblStatus.Text = "Thank you for posting! Please wait for the Approval";
                }
                else if (status == "1")
                {
                    lblStatus.Text = "Your data is Approved";
                }
                else if (status == "2")
                {
                    lblStatus.Text = "You entered violated data. Please update the data";
                }
                else if (status == "3")
                {
                    lblStatus.Text = "You have updated the data. So please wait for the approval";
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }
        Label lbllast = (Label)e.Item.FindControl("lbllast");
        if (lbllast != null)
        {
            try
            {
                if (lbllast.Text != "")
                {
                    lbllast.Text = lbllast.Text;
                }
                else
                {
                    lbllast.Text = "ASAP";
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }

        Label lblsal = (Label)e.Item.FindControl("lblsal");
        if (lblsal != null)
        {
            try
            {
                if (lblsal.Text != "")
                {
                    lblsal.Text = lblsal.Text;
                }
                else
                {
                    lblsal.Text = "Not Mentioned";
                    lblsal.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }
        Label lbllmark = (Label)e.Item.FindControl("lbllmark");
        if (lbllmark != null)
        {
            try
            {
                if (lbllmark.Text != "")
                {
                    lbllmark.Text = lbllmark.Text;
                }
                else
                {
                    lbllmark.Text = "Not Mentioned ";
                    lbllmark.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }
        Label lblcmail = (Label)e.Item.FindControl("lblcmail");
        if (lblcmail != null)
        {
            try
            {
                if (lblcmail.Text != "")
                {
                    lblcmail.Text = lblcmail.Text;
                }
                else
                {
                    lblcmail.Text = "Not Mentioned";
                    lblcmail.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }
        Label lblwebsite = (Label)e.Item.FindControl("lblwebsite");
        if (lblwebsite != null)
        {
            try
            {
                if (lblwebsite.Text != "")
                {
                    lblwebsite.Text = lblwebsite.Text;
                }
                else
                {
                    lblwebsite.Text = "Not Mentioned";
                    lblwebsite.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }
    }
    //protected void editjob(object sender, CommandEventArgs e)
    //{
    //     string id = e.CommandArgument.ToString();
    //     Response.Redirect("edit_job.aspx?id=" + id + "&cname=jobs");
    //}
    [System.Web.Script.Services.ScriptMethod()]
    [System.Web.Services.WebMethod]
    public static List<string> Getcities(string prefixText)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from cities where city_name like @Name+'%'", con);
        cmd.Parameters.AddWithValue("@Name", prefixText);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        List<string> citynames = new List<string>();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            citynames.Add(dt.Rows[i][1].ToString());
        }
        return citynames;
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
    public string GetCompUrl(object jid)
    {
        string JobId = jid.ToString();
        return Page.GetRouteUrl("jobdetails", new { id = jid, cname = "jobs" });
    }
    protected string GetEditUrl(object jid)
    {
        string JobId = jid.ToString();
        return Page.GetRouteUrl("EditJob", new { id = jid, cname = "jobs" });
    }
}


