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
using JustCallUsData.Data;
/// <summary>
/// class to view reports
/// </summary>
public partial class admin_Admin_ViewReports : System.Web.UI.Page
{
    //making connection
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    //declaration of variables and creation of objects for classes
    Int32 dataid;
    string Type;
    string UserId;
    DataSet ds=new DataSet();
    DataCS obj = new DataCS();
    DataSet dsdatainfo = new DataSet();
    string companyname="";
    string cat;
    bool t;
    string strScript;
    /// <summary>
    /// Executes whenever page loads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
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
        if (!Page.IsPostBack)
        {
            BindReports();
        }
    }
    PagedDataSource objPds = new PagedDataSource();
    /// <summary>
    /// to bind reports
    /// </summary>
    private void BindReports()
    {
        Type = Convert.ToString(Request.QueryString["type"]);
        dataid = Convert.ToInt32(Request.QueryString["id"]);
        dsdatainfo = obj.GetModuleData(dataid);
        if (!dsdatainfo.Tables[0].Rows.Count.Equals(0))
        {
            companyname = dsdatainfo.Tables[0].Rows[0]["company_name"].ToString();
            cat = dsdatainfo.Tables[0].Rows[0]["Category"].ToString();
        }

        if (Type == "abuse")
        {
            ds = obj.getReport(dataid, Type);
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                objPds.DataSource = ds.Tables[0].DefaultView;
                objPds.AllowPaging = true;
                objPds.PageSize = 7;
                objPds.CurrentPageIndex = CurrentPage;
                lblCurrentPage.Text = "Page: " + (CurrentPage + 1).ToString() + " of " + objPds.PageCount.ToString();
                // Disable Prev or Next buttons if necessary
                cmdPrev.Enabled = !objPds.IsFirstPage;
                cmdNext.Enabled = !objPds.IsLastPage;
                dlReport.DataKeyField = "id";
                dlReport.DataSource = objPds;
                dlReport.DataBind();
                lblHeading.Text = "Abused Reports for <b>" + companyname + "</b> in the category of <b>" + cat+"</b>";
            }
            else
            {
                lblMsg.Text = "No Abused Reports found for <b>"+companyname+"</b> in the category of <b>"+cat+"</b>";
                trnextpre.Visible = false;
            }
        }
        else if (Type == "incorrect")
        {
            ds = obj.getReport(dataid, Type);
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                objPds.DataSource = ds.Tables[0].DefaultView;
                objPds.AllowPaging = true;
                objPds.PageSize = 15;
                objPds.CurrentPageIndex = CurrentPage;
                lblCurrentPage.Text = "Page: " + (CurrentPage + 1).ToString() + " of " + objPds.PageCount.ToString();
                // Disable Prev or Next buttons if necessary
                cmdPrev.Enabled = !objPds.IsFirstPage;
                cmdNext.Enabled = !objPds.IsLastPage;
                dlReport.DataKeyField = "id";
                dlReport.DataSource = objPds;
                dlReport.DataBind();
                lblHeading.Text = "Incorrect Reports for <b>" + companyname + "</b> in the category of <b>" + cat + "</b>";
            }
            else
            {
                lblMsg.Text = "No Incorrect Reports found for <b>" + companyname + "</b> in the category of <b>" + cat + "</b>";
                trnextpre.Visible = false;
            }
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
        BindReports();
    }
    /// <summary>
    /// To go next page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void cmdNext_Click(object sender, EventArgs e)
    {
        CurrentPage += 1;
        BindReports();
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
    /// <summary>
    /// Binding data dynamically
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void dlReport_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        HtmlTableRow trName = (HtmlTableRow)e.Item.FindControl("trName");
        Label lblName = (Label)e.Item.FindControl("lblName");

        if (trName != null)
        {
            if (lblName.Text != "")
            {
                trName.Visible = true;
            }        
            else
            {
                trName.Visible = false;
            }
        }
        HtmlTableRow trEmailId = (HtmlTableRow)e.Item.FindControl("trEmailId");
        HtmlTableRow trContNo = (HtmlTableRow)e.Item.FindControl("trContNo");
        Label lblEmail = (Label)e.Item.FindControl("lblEmail");
        Label lblContNo = (Label)e.Item.FindControl("lblContNo");
        if (trEmailId != null)
        {
            if (lblEmail.Text != "")
            {
                trEmailId.Visible = true;
                
            }           
            else
            {
                trEmailId.Visible = false;
            }
        }
        if (trContNo != null)
        {
            if (lblContNo.Text != "")
            {
                trContNo.Visible = true;

            }
            else
            {
                trContNo.Visible = false;
            }
        }
    }
    protected void lnkDeleteReport(object sender, CommandEventArgs e)
    {
        Int32 Id = Convert.ToInt32(e.CommandArgument.ToString());
        Type = Convert.ToString(Request.QueryString["type"]);
        dataid = Convert.ToInt32(Request.QueryString["id"]);
        t=obj.Delete_Report(Id);
        if (t == true)
        {
            strScript = "alert('Report is deleted Successfully');location.replace('Admin_ViewReports.aspx?type="+Type+"&id="+dataid+"');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
        }

    }
}
