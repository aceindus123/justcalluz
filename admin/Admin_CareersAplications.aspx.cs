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
using Microsoft.Office;
using Microsoft.Office.Interop.Word;
using System.Data.SqlClient;
using CallUsCareers.career;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Permissions;
using System.IO;


[assembly: System.Security.AllowPartiallyTrustedCallers]
/// <summary>
/// To display applications for a perticular career.Provides downloading resumes of applicants
/// </summary>
public partial class admin_Admin_CareersAplications : System.Web.UI.Page
{
    //To make connection
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    DataSet ds = new DataSet();
    // Declare variables
    string strGetPath;
    string Filename;
    string Filepath;
    string UserId;
    string JobTitle;
    string fname;
    string lname;
    string strScript;
    string JobId;
    string emailid;
    string body;
    string jobdesc;
    // Crate objects for required classes
    Binddata obj = new Binddata();   
    CareersCS careers = new CareersCS();
    /// <summary>
    /// Executes whenever page loads
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
        // loads the page without postbacking the values
        if (!Page.IsPostBack)
        {
            BindJobApplicants();
            
        }       
    }
    /// <summary>
    /// To bind the careers applicants
    /// </summary>
    private void BindJobApplicants()
    {
        PagedDataSource objPds = new PagedDataSource();
        // To get id of perticular career
        Int16 JobId=Convert.ToInt16(Request.QueryString["jobid"]); 
        //Fill dataset with applicants data
        ds = careers.bindjobAppliersdata(JobId);
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            objPds.DataSource = ds.Tables[0].DefaultView;
            objPds.AllowPaging = true;
            objPds.PageSize = 5;
            objPds.CurrentPageIndex = CurrentPage;
            lblCurrentPage.Text = "Page: " + (CurrentPage + 1).ToString() + " of " + objPds.PageCount.ToString();
            // Disable Prev or Next buttons if necessary
            cmdPrev.Enabled = !objPds.IsFirstPage;
            cmdNext.Enabled = !objPds.IsLastPage;
            dlViewApplicants.DataKeyField = "jobid";
            //To bind the data
            dlViewApplicants.DataSource = objPds;
            dlViewApplicants.DataBind();
            
        }
        else
        {
            lblMsg.Text = "i.e, No Applications found";
            trnextpre.Visible = false;
            trlblMessage.Visible = false;
        }
        //To fill and bind the no. of applicants
        ds = careers.bindnoofJobApplicants(JobId);
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            jobdesc = ds.Tables[0].Rows[0]["jobDesc"].ToString();
            lblJobDesc.Text = jobdesc;
            dlCareersdata.DataSource = ds;
            dlCareersdata.DataBind();
        }
    }
    /// <summary>
    /// To go previous page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void cmdPrev_Click(object sender, EventArgs e)
    {
        CurrentPage -= 1;
        BindJobApplicants();
    }
    /// <summary>
    /// To go next page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void cmdNext_Click(object sender, EventArgs e)
    {
        CurrentPage += 1;
        BindJobApplicants();
    }
    /// <summary>
    /// To get the current page status
    /// </summary>
    public int CurrentPage
    {
        get
        {
            object o = this.ViewState["_CurrentPage"];
            if (o == null)
                return 0;
            else
                return (int)o;
        }
        set
        {
            this.ViewState["_CurrentPage"] = value;
        }
    }
    //private void readfilecontent(string Filepath, ref TextBox Resume)
    //{

    //    ApplicationClass wordapp = new ApplicationClass();
    //    object file = Filepath;
    //    object nullobj = System.Reflection.Missing.Value;
    //    Microsoft.Office.Interop.Word.Document doc = wordapp.Documents.Open(

    //     ref file, ref nullobj, ref nullobj,

    //    ref nullobj, ref nullobj, ref nullobj,

    //    ref nullobj, ref nullobj, ref nullobj,

    //    ref nullobj, ref nullobj, ref nullobj, ref nullobj, ref nullobj, ref nullobj, ref nullobj);

    //    doc.ActiveWindow.Selection.WholeStory();
    //    doc.ActiveWindow.Selection.Copy();
    //    string sFiletext = doc.Content.Text;
    //    Resume.Text = sFiletext;
    //    doc.Close(ref nullobj, ref nullobj, ref nullobj);
    //    wordapp.Quit(ref nullobj, ref nullobj, ref nullobj);

    //}
    protected void dlViewApplicants_ItemDataBound(object sender, DataListItemEventArgs e)
    {                                 
    //        TextBox Resume = (TextBox)e.Item.FindControl("txtresume");

    //        Label lblfilename = (Label)e.Item.FindControl("lblFileName");
    //        if (lblfilename != null)
    //        {
    //            Filename = lblfilename.Text;
    //        }
    //        Label lblfilepath = (Label)e.Item.FindControl("lblFilePath");
    //        if (lblfilepath != null)
    //        {
    //            Filepath = lblfilepath.Text;
    //        }
    //        strGetPath = Server.MapPath("~/resume");

    //        con.Close();
    //        Filepath = strGetPath + "/" + Filename;
    //        readfilecontent(Filepath, ref Resume);        
    }
    protected void dlViewApplicants_ItemCommand(object source, DataListCommandEventArgs e)
    {
    //    LinkButton lnkView = (LinkButton)e.Item.FindControl("lnkViewResume");
    //    LinkButton lnkUnView = (LinkButton)e.Item.FindControl("lnkUnview");
    //    TextBox txtRes = (TextBox)e.Item.FindControl("txtresume");
    //    if (e.CommandName == "View")
    //    {            
    //        txtRes.Visible = true;
    //        lnkUnView.Visible = true;
    //        lnkView.Visible = false;
    //    }
    //    if (e.CommandName == "UnView")
    //    {           
    //        txtRes.Visible = false;
    //        lnkUnView.Visible = false;
    //        lnkView.Visible = true;
    //    }        
    }
    /// <summary>
    /// To download resume
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkDownload(object sender, CommandEventArgs e)
    {
        //To get id of a particular applicant
        Int16 RId = Convert.ToInt16(e.CommandArgument.ToString());
        // Get directory path
        DirectoryInfo directory = new DirectoryInfo(Server.MapPath("~/resume"));
        //Fill dataset
        ds = careers.bindjobAppliersresdata(RId);
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            Filename = ds.Tables[0].Rows[0]["curriculam_vitaeName"].ToString();
        }  
        //Directing to the page download reume by passing file name
        Response.Redirect("Admin_DownloadResume.aspx?name="+Filename);       
    }

    protected void imgBtnBack_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Admin_Careers.aspx");
    }
    protected void lnkSendMail(object sender, CommandEventArgs e)
    {
        //To get id of a particular applicant        
        lblApplicantId.Text=Convert.ToString(e.CommandArgument.ToString());
        Int16 JId = Convert.ToInt16(lblApplicantId.Text);
        ds =careers.bindperticularApplicantResumeName(JId);
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            JobTitle = ds.Tables[0].Rows[0]["Title"].ToString();
            fname = ds.Tables[0].Rows[0]["firstname"].ToString();
            lname = ds.Tables[0].Rows[0]["lastname"].ToString();
            JobId = ds.Tables[0].Rows[0]["ajobid"].ToString();
            emailid = ds.Tables[0].Rows[0]["email"].ToString();            
            lblJobTitle.Text = JobTitle;
            lblFName.Text = fname;
            lblLName.Text = lname;
            lblJobId.Text = JobId;
            lbltoMail.Text = emailid;
        }
        con.Close();
        ModalPopupExtender1.Show();
        //jobdesc = Convert.ToString(lblJobDesc.Text);
        //body = "Dear " + fname + " " + lname + ",<br />" +
        //       "You are applied for the job titled as "+JobTitle+"<br />"+
        //       "Job Description: "+jobdesc;
        //txtMsg.Text = body;
                     
    }
    protected void submitbutton_Click(object sender, EventArgs e)
    {
        fname=Convert.ToString(lblFName.Text);
        lname=Convert.ToString(lblLName.Text);
        JobId=Convert.ToString(lblJobId.Text);
        JobTitle = Convert.ToString(lblJobTitle.Text);        
        string subject = txtSubject.Text;
        StringWriter sw = new StringWriter();
        HtmlTextWriter htw = new HtmlTextWriter(sw);
        emailid = Convert.ToString(lbltoMail.Text);
        jobdesc = Convert.ToString(lblJobDesc.Text);
        string msg = Convert.ToString(txtMsg.Text);
        string body="";
        body += "Dear <b>" + fname + " " + lname + "</b>," +

               "<br>You are applied for the job titled as "+JobTitle+"<br />"+
               //"Job Description: " + jobdesc +
               "<br>" + msg+"<br>"+
               "Please click on the link to view job which you applied"+
               "<br>http://www.justcalluz.com/new_justcalluz/careersjobinfo.aspx?jobid=" +JobId+
               "<br><br>Warm Regards," +
               "<br> Just Call Uz Careers Team";
        //Server.Execute("Admin_CareersSingleMail.aspx?id=" + JobId + "&fname=" + fname + "&lname=" + lname, htw);
        //string body = sw.ToString() + "<br/>";
        Mail.sendmail("careers@justcalluz.com", emailid, subject,body );
        strScript = "alert('Your Mail is Sent Successfully.');";
        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);        
    }
    protected void cancelbutton_Click(object sender, EventArgs e)
    {

    }
}
