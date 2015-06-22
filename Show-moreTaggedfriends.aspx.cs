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

public partial class Show_moreTaggedfriends : System.Web.UI.Page
{
    SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    int fratingid;
    SSCS obj1 = new SSCS();
    InsertData obj = new InsertData();
    static string excep_page = "Show-moreTaggedfriends.aspx";
    string dataId = string.Empty;
    PagedDataSource pds = new PagedDataSource();
    int loginuserid;
    string strscript = string.Empty;
    List<string> Listfrids = new List<string> { };
    DataSet dstaggedfriendmobile = new DataSet();
    DataSet dstaggedfriendinfo = new DataSet();
    string ResultString = string.Empty;
    string strScript = string.Empty;
    int freg_id;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
        }
         BindFriendrating_details();
        
    }
    protected void BindFriendrating_details()
    {
        loginuserid = Convert.ToInt32(Page.RouteData.Values["loginid"].ToString());


        dstaggedfriendmobile = obj1.tag_Friends(loginuserid);
        if (dstaggedfriendmobile.Tables.Count > 0 && dstaggedfriendmobile.Tables[0].Rows.Count > 0)
        {
            for (int index = 0; index < dstaggedfriendmobile.Tables[0].Rows.Count; index++)
            {
                if (Convert.ToString(dstaggedfriendmobile.Tables[0].Rows[index]["friend_mobile"]) != "")
                {
                    Listfrids.Add(obj1.tagFriends_rid(Convert.ToString(dstaggedfriendmobile.Tables[0].Rows[index]["friend_mobile"])));
                }
            }
            for (int index1 = 0; index1 < Listfrids.Count; index1++)
            {
                ResultString += Listfrids[index1] + ",";
            }

            ResultString = ResultString.Substring(0, ResultString.Length - 1);

            dstaggedfriendinfo = obj1.Show_morefriends(ResultString);
            if (dstaggedfriendinfo.Tables.Count > 0 && dstaggedfriendinfo.Tables[0].Rows.Count > 0)
            {
                trmessage.Visible = false;
                pds.DataSource = dstaggedfriendinfo.Tables[0].DefaultView;
                pds.AllowPaging = true;
                pds.PageSize = 10;
                if (dstaggedfriendinfo.Tables[0].Rows.Count <= pds.PageSize)
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
        }
        //else
        //{
        //    strscript = "alert('No ratings found');location.replace('Tagmorefriends-" + loginuserid + "');";
        //    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strscript, true);

        //}


        //dlFRatings.DataSource = dstaggedfriendinfo;
        //dlFRatings.DataBind();
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
    protected void btnUntagfrnd_command(object sender, CommandEventArgs e)
    {
        loginuserid = Convert.ToInt32(Page.RouteData.Values["loginid"].ToString());

      string mobilenum = e.CommandArgument.ToString();
      bool result=obj1.untag_taggedfriend(mobilenum);
        if(result==true)
        {
            strScript = "alert('Tagged friend is deleted successful.');location.replace('Showmorefriends-" + loginuserid + "');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
        }
    }
    protected void FriendsRatings(object sender, CommandEventArgs e)
    {
        try
        {
            loginuserid = Convert.ToInt32(Page.RouteData.Values["loginid"].ToString());

            freg_id = Convert.ToInt32(e.CommandArgument.ToString());
            Response.RedirectToRoute("tag_friendsRatings", new { reg_rateid = freg_id, loginid = loginuserid });
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }


}