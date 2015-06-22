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
public partial class admin_Admin_ViewCareerResume : System.Web.UI.Page
{
    //To make connection
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    DataSet ds = new DataSet();
    // Declare variables
    string strGetPath;
    string Filename;
    string Filepath;
    string UserId;
    string cat;
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
        //Fill dataset with applicants data
        ds = careers.bindResumesPostedDirectly();
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
            dlViewApplicants.DataKeyField = "id";
            //To bind the data
            dlViewApplicants.DataSource = objPds;
            dlViewApplicants.DataBind();

        }
        else
        {
            lblMsg.Text = "No Applications found";
            trnextpre.Visible = false;
            trlblMessage.Visible = false;
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
        DirectoryInfo directory = new DirectoryInfo(Server.MapPath("~/postresumes"));
        //Fill dataset
        ds = careers.bindResumesPostedDirectly();
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            Filename = ds.Tables[0].Rows[0]["curriculam_vitaeName"].ToString();
        }
        //Directing to the page download reume by passing file name
        Response.Redirect("Admin_DownloadPostResume.aspx?name=" + Filename);
    }
    protected void ViewJobs(object sender, CommandEventArgs e)
    {
        //To get id of a particular applicant
        Int16 RId = Convert.ToInt16(e.CommandArgument.ToString());
        Response.Redirect("Admin_ViewRelatedJobs.aspx?rid=" + RId);
    }
}
