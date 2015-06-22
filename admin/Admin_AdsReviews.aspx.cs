using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class admin_Admin_AdsReviews : System.Web.UI.Page
{
    //Making connection
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    DataSet ds = new DataSet();
    DataTable dt = new DataTable();
    //creating object for AdsCS class
    AdsCS obj = new AdsCS();
    PagedDataSource pds = new PagedDataSource();
    //declaration of variables
    Int32 id;
    int t;
    string strScript;
    string UserId;
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
        //loads the page without postbacking the values
        if (!Page.IsPostBack)
        {
            BinData();
        }
    }
    /// <summary>
    /// To bind the reviews of ads
    /// </summary>
    private void BinData()
    {        
        con.Open();
        dt = obj.GetAdReviews();
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
            dlreviews.DataSource = pds;
            dlreviews.DataBind();
            lnkbtnNext.Visible = true;
            lnkbtnPrevious.Visible = true;
            lblCurrentPage.Visible = true;
        }
        else
        {
            lblMessage.Text = "No comments Available";
        }
        con.Close();
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
        BinData();
    }
    /// <summary>
    /// Function to go next page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkbtnNext_Click1(object sender, EventArgs e)
    {
        CurrentPage += 1;
        BinData();
    }
    /// <summary>
    /// To delete review of ads by passing record Id
    /// </summary>
    /// <param name="sendet"></param>
    /// <param name="e"></param>
    protected void lnkDelete(object sendet, CommandEventArgs e)
    {
        id = Convert.ToInt32(e.CommandArgument.ToString());
        con.Open();
        t = obj.DeleteReviewComments(id);
        con.Close();
        if (t == 1)
        {
            strScript = "alert('The record has been deleted successfully');location.replace('Admin_AdsReviews.aspx');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
        }
    }
    //protected void dlreviews_ItemDataBound(object sender, DataListItemEventArgs e)
    //{
    //    if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
    //    {
    //        //identifying the control in DataGrid
    //        ImageButton imgbtnDelete = (ImageButton)e.Item.FindControl("imgBtnDelete");
    //        //raising javascript confirmationbox whenver user clicks on ImageButton
    //        imgbtnDelete.Attributes.Add("onclick", "javascript:return confirm_delete()");
    //    }
    //}
}
