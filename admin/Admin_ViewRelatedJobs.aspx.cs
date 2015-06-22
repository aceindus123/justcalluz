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
using CallUsCareers.career;
using System.IO;
/// <summary>
/// To view related jobs for a particular category
/// </summary>
public partial class admin_Admin_ViewRelatedJobs : System.Web.UI.Page
{
    //To make connection
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    DataSet ds = new DataSet();
    DataTable dt = new DataTable();
    CareersCS careers = new CareersCS();
    Binddata obj = new Binddata();
    PagedDataSource pds = new PagedDataSource();
    //Declaration of variables
    string UserId;
    string EmailTosend;
    string cat;
    string spec;
    Int16 RId;
    string JobTitle;
    string category;
    string fname;
    string lname;
    string strScript = "";
    /// <summary>
    /// To bind the careers applicants
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        // Checking Status of Login
        UserId = Convert.ToString(Session["LogInId"]);
        if (UserId != "")
        {
            // it will stays in the same page
        }

        else
        {
            //After login into the account it will go Post ad
            Response.Redirect("Default.aspx");

        }
        RId = Convert.ToInt16(Request.QueryString["rid"].ToString());
        // loads the page without postbacking the values
        if (!Page.IsPostBack)
        {
            GetDirectResumes();
        }
    }    
    /// <summary>
    /// To get resumes
    /// </summary>
    public void GetDirectResumes()
    {
        RId = Convert.ToInt16(Request.QueryString["rid"].ToString());
        ds = careers.bindparticularResumePostedDirectly(RId);
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            EmailTosend = ds.Tables[0].Rows[0]["email"].ToString();
            cat = ds.Tables[0].Rows[0]["Category"].ToString();
            spec = ds.Tables[0].Rows[0]["Specialization"].ToString();
            fname = ds.Tables[0].Rows[0]["firstname"].ToString();
            lname = ds.Tables[0].Rows[0]["lastname"].ToString();
            lblEmail.Text = EmailTosend;
            lblCat.Text = cat;
            lblFName.Text = fname;
            lblLName.Text = lname;
            dlViewApplicants.DataSource = ds;
            dlViewApplicants.DataBind();
        }
        GetRelatedJobs();
    }
    /// <summary>
    /// View related jobs
    /// </summary>
    /// <param name="category"></param>
    public void GetRelatedJobs()
    {       
        category = Convert.ToString(lblCat.Text);
        dt = careers.GetRelatedJobsforCat(category);
        if (dt.Rows.Count > 0)
        {
            //Session["id"] = id;
            pds.DataSource = dt.DefaultView;
            pds.AllowPaging = true;
            pds.PageSize = 7;
            pds.CurrentPageIndex = CurrentPage;
            lblCurrentPage.Text = "Page: " + (CurrentPage + 1).ToString() + " of " + pds.PageCount.ToString();
            lnkbtnNext.Enabled = !pds.IsLastPage;
            lnkbtnPrevious.Enabled = !pds.IsFirstPage;
            dlViewRelatedJobs.DataSource = pds;
            dlViewRelatedJobs.DataBind();
            lnkbtnNext.Visible = true;
            lnkbtnPrevious.Visible = true;
            lblCurrentPage.Visible = true;
        }
    }
    /// <summary>
    /// To put current page status
    /// </summary>
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

    /// <summary>
    /// Function to go prevoius page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkbtnPrevious_Click1(object sender, EventArgs e)
    {
        CurrentPage -= 1;
        GetRelatedJobs();
    }
    /// <summary>
    /// Function to go next page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkbtnNext_Click1(object sender, EventArgs e)
    {
        CurrentPage += 1;
        GetRelatedJobs();
    }
    /// <summary>
    /// link to send mail
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkSendMail(object sender, CommandEventArgs e)
    {
        //To get id of a particular applicant
        Int16 JId = Convert.ToInt16(e.CommandArgument.ToString());
        ds = obj.bindAdminCareersDetais(JId);
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            JobTitle = ds.Tables[0].Rows[0]["title"].ToString();
        }
        con.Close();
        string emailid = Convert.ToString(lblEmail.Text);        
        fname = Convert.ToString(lblFName.Text);
        lname = Convert.ToString(lblLName.Text);
        string subject = fname + " " + lname + "," + "Job(s) matching your profile";
        StringWriter sw = new StringWriter();
        HtmlTextWriter htw = new HtmlTextWriter(sw);
        Server.Execute("Admin_CareersSingleMail.aspx?id=" + JId + "&fname=" + fname + "&lname=" + lname, htw);
        Mail.sendmail("careers@justcalluz.com", emailid, subject, sw.ToString());
        strScript = "alert('Your Mail is Sent Successfully.');location.replace('Admin_ViewRelatedJobs.aspx?rid=" + RId + "');";
        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                       
    }    
    protected void lnkSendAllJobs_Click(object sender, EventArgs e)
    {
        string emailid = Convert.ToString(lblEmail.Text);
        category = Convert.ToString(lblCat.Text);
        fname = Convert.ToString(lblFName.Text);
        lname = Convert.ToString(lblLName.Text);
        string subject=fname+" "+lname+","+"Job(s) matching your profile";
        StringWriter sw = new StringWriter();
        HtmlTextWriter htw = new HtmlTextWriter(sw);
        Server.Execute("Admin_CareersMail.aspx?cat="+category+"&fname="+fname+"&lname="+lname, htw);
        Mail.sendmail("careers@justcalluz.com", emailid,subject, sw.ToString());
        strScript = "alert('Your Mail is Sent Successfully.');location.replace('Admin_ViewRelatedJobs.aspx?rid="+RId+"');";
        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
    }
    protected void dlViewRelatedJobs_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        Label expiredate = (Label)e.Item.FindControl("expiredate");
        LinkButton lnkBtnSendMail = (LinkButton)e.Item.FindControl("lnkBtnSendMail");
        DataSet dscdate = new DataSet();
        dscdate = obj.GetCurrentDate();
        string todaydate = dscdate.Tables[0].Rows[0]["cdate"].ToString();
        DateTime dt1 = Convert.ToDateTime(todaydate);
        string dt3 = String.Format("{0:dd-MMM-yyyy}", dt1);
        if (expiredate != null)
        {
            DateTime dt2 = Convert.ToDateTime(expiredate.Text);
            string dt4 = String.Format("{0:dd-MMM-yyyy}", dt2);
            int result = DateTime.Compare(dt1, dt2);
            string relationship;
            if (result < 0)
            {
                lnkBtnSendMail.Enabled = true;
            }
            else
            {
                lnkBtnSendMail.Enabled = false;
            }
        }
    }
}
