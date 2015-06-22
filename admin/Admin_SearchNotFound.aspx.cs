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
using JustCallUsData.Data;

public partial class admin_Admin_SearchNotFound : System.Web.UI.Page
{
    PagedDataSource objPds = new PagedDataSource();
    DataCS obj = new DataCS();
    DataSet ds = new DataSet();
    string UserId;
    bool t;
    string strScript;
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
        if(Convert.ToInt32(Session["SNFDel"].ToString())==1)
        if (!Page.IsPostBack)
        {
            BindSearchNotFound();
        }
    }
    private void BindSearchNotFound()
    {
        ds = obj.Get_SearchNotFound();
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
            dlSearchNotFound.DataKeyField = "id";
            dlSearchNotFound.DataSource = objPds;
            dlSearchNotFound.DataBind();            
        }
        else
        {
            lblMsg.Text = "<b>No Records Found</b>";
            trnextpre.Visible = false;
        }       
    }
    protected void cmdPrev_Click(object sender, EventArgs e)
    {
        CurrentPage -= 1;
        BindSearchNotFound();
    }
    /// <summary>
    /// To go next page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void cmdNext_Click(object sender, EventArgs e)
    {
        CurrentPage += 1;
        BindSearchNotFound();
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
    protected void lnkDeleteReport(object sender, CommandEventArgs e)
    {
        Int32 Id = Convert.ToInt32(e.CommandArgument.ToString());       
        t = obj.Delete_SearchNotFound(Id);
        if (t == true)
        {
            strScript = "alert('Serach not found record is deleted Successfully');location.replace('Admin_SearchNotFound.aspx');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
        }

    }
    protected void dlSearchNotFound_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        HtmlTableCell tddel_snf = (HtmlTableCell)e.Item.FindControl("tddel");
        if (tddel_snf != null)
        {
            if (Convert.ToInt32(Session["SNFDel"].ToString()) == 1)
            {
                tddel_snf.Visible = true;
            }
            else
            {
                tddel_snf.Visible = false;
            }
        }
    }
    protected void lnkBack_Click(object sender, EventArgs e)
    {
        string designation;
        if (Session["LoginId"] != null)
        {
            designation = Convert.ToString(Session["Designation"]);
            if (designation == "Admin")
            {
                Response.Redirect("Admin-MainPage.aspx");
            }
            else
            {
                Response.Redirect("Admin_Home.aspx");
            }
        }
    }
}
