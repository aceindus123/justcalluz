using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Routing;

public partial class Taggedfriends_Ratingdetails : System.Web.UI.Page
{
    SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    int fratingid;
    SSCS obj1 = new SSCS();
    InsertData obj = new InsertData();
    static string excep_page = "Taggedfriends-Ratingdetails.aspx";
    string dataId=string.Empty;
    PagedDataSource pds = new PagedDataSource();
    int loginuserid;
    string strscript = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        BindFriendrating_details();
    }
    protected void BindFriendrating_details()
    {
        loginuserid = Convert.ToInt32(Page.RouteData.Values["loginid"].ToString());
        fratingid = Convert.ToInt32(Page.RouteData.Values["reg_rateid"].ToString());

        DataSet dsratingDetails = new DataSet();
        dsratingDetails = obj1.tag_FriendsRatings(fratingid);
        if (dsratingDetails.Tables.Count > 0 && dsratingDetails.Tables[0].Rows.Count > 0)
        {
            trmessage.Visible = false;
            pds.DataSource = dsratingDetails.Tables[0].DefaultView;
            pds.AllowPaging = true;
            pds.PageSize = 10;
            if (dsratingDetails.Tables[0].Rows.Count <= pds.PageSize)
            {
                pds.CurrentPageIndex = CurrentPage;
                trPaging.Visible = false;
                dlFRatings.DataSource = pds;
                 dlFRatings.DataBind();
            }
            else
            {
                trPaging.Visible = true;
                pds.CurrentPageIndex = CurrentPage;
                lblCurrentPage.Text = "Page: " + (CurrentPage + 1).ToString() + " of " + pds.PageCount.ToString();
                imgNext.Enabled = !pds.IsLastPage;
                imgPrevious.Enabled = !pds.IsFirstPage;
                dlFRatings.DataSource = pds;
                dlFRatings.DataBind();
            }
       }
        else
        {
            strscript = "alert('No ratings found');location.replace('Tagmorefriends-" + loginuserid + "');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strscript, true);

        }
     }
    /// <summary>
    /// Code for binding friends ratings 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void dlFRatings_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        Label lblDataId = (Label)e.Item.FindControl("lblDataId");
        if (lblDataId != null)
        {
            try
            {
                dataId = Convert.ToString(lblDataId.Text);
                // con.Open();
                SqlCommand cmd = new SqlCommand("Select count(rid) as NumberOfUsers,sum(Stars_Rating) as Total from PostReview where reg_id='" + fratingid + "'", sqlConnection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                float count = 0, rating = 0, result = 0;

                if (Convert.ToInt32(dt.Rows[0]["NumberOfUsers"].ToString()) != 0)
                {
                    count = float.Parse(dt.Rows[0]["NumberOfUsers"].ToString());
                    rating = float.Parse(dt.Rows[0]["Total"].ToString());
                    result = Convert.ToInt32(Math.Ceiling((rating / count) * 18));
                    //avgrating.InnerText = Math.Round((rating / count), 1).ToString();

                }
                else
                {
                    //avgrating.InnerText = "0";
                }
                Label testSpan0 = (Label)e.Item.FindControl("testSpan0");
                testSpan0.Width = Convert.ToInt32(result);
                //testSpan0.Style.Add("width", result + "px");
                // con.Close();

            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
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
    /// code for getting previous page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void imgPrevious_Click(object sender, EventArgs e)
    {
        try
        {
            CurrentPage -= 1;
            BindFriendrating_details();
          
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    /// Code for getting next page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void imgNext_Click(object sender, EventArgs e)
    {
        try
        {
            CurrentPage += 1;
            BindFriendrating_details();
         
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected string GetViewUrl(object bid)
    {
        string id = bid.ToString();
        return Page.GetRouteUrl("CT_sessionstore", new { id = id });
    }
}