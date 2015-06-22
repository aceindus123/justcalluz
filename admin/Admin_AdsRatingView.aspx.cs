using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
/// <summary>
/// To view ratings of the ads
/// </summary>
public partial class admin_Admin_AdsRatingView : System.Web.UI.Page
{
    //object creation of class
    AdsCS obj = new AdsCS();
    //declaration of variables
    string UserId;
    DataTable dt = new DataTable();
    PagedDataSource pds = new PagedDataSource();
    string strScript;
    int id;
    int t;
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
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
            GetRating();
        }
    }
    /// <summary>
    /// get ratings of ads
    /// </summary>
    private void GetRating()
    {
        con.Open();
        dt = obj.GetTVAdRatings();
        if (dt.Rows.Count > 0)
        {
            //Session["id"] = id;
            //pds.DataSource = dt.DefaultView;
            //pds.AllowPaging = true;
            //pds.PageSize = 10;
            //pds.CurrentPageIndex = CurrentPage;
            //lblCurrentPage.Text = "Page: " + (CurrentPage + 1).ToString() + " of " + pds.PageCount.ToString();
            //lnkbtnNext.Enabled = !pds.IsLastPage;
            //lnkbtnPrevious.Enabled = !pds.IsFirstPage;
            dlAdRatings.DataSource = dt;
            dlAdRatings.DataBind();
            //lnkbtnNext.Visible = true;
            //lnkbtnPrevious.Visible = true;
            //lblCurrentPage.Visible = true;
        }
        else
        {
            lblMessage.Text = "No Ratings Available";
        }
        con.Close();
    }
    /// <summary>
    /// To put current page status
    /// </summary>
    //public int CurrentPage
    //{
    //    get
    //    {
    //        if (this.ViewState["CurrentPage"] == null)
    //            return 0;
    //        else
    //            return Convert.ToInt16(this.ViewState["CurrentPage"].ToString());
    //    }
    //    set
    //    {
    //        this.ViewState["CurrentPage"] = value;
    //    }
    //}

    /// <summary>
    /// Function to go prevoius page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    //protected void lnkbtnPrevious_Click1(object sender, EventArgs e)
    //{
    //    CurrentPage -= 1;
    //    GetRating();
    //}
    ///// <summary>
    ///// Function to go next page
    ///// </summary>
    ///// <param name="sender"></param>
    ///// <param name="e"></param>
    //protected void lnkbtnNext_Click1(object sender, EventArgs e)
    //{
    //    CurrentPage += 1;
    //    GetRating();
    //}
    /// <summary>
    /// To delete rating by passing respective record id
    /// </summary>
    /// <param name="sendet"></param>
    /// <param name="e"></param>
    protected void lnkDelete(object sendet, CommandEventArgs e)
    {
        id = Convert.ToInt32(e.CommandArgument.ToString());
        con.Open();
        t = obj.DeleteTVAdRatings(id);
        con.Close();
        if (t == 1)
        {
            strScript = "alert('The record has been deleted successfully');location.replace('Admin_AdsRatingView.aspx');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
        }        
    }
    /// <summary>
    /// Functionality whenever page changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ViewGrid_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        dlAdRatings.PageIndex = e.NewPageIndex;
        GetRating();
    }
}
