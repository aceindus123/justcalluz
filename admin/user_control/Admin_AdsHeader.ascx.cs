using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_user_control_Admin_AdsHeader : System.Web.UI.UserControl
{
    string Ad;
    string AdsPost;
    string AdsEdit;
    string AdsDel;
    string AdsView;
    string strScript;
    protected void Page_Load(object sender, EventArgs e)
    {
        Ad = Convert.ToString(Session["Ads"]);
        AdsPost = Convert.ToString(Session["AdsPost"]);
        AdsEdit = Convert.ToString(Session["AdsEdit"]);
        AdsDel = Convert.ToString(Session["AdsDel"]);
        AdsView = Convert.ToString(Session["AdsView"]);

    }
    protected void lnkbtnPostAds_Click(object sender, EventArgs e)
    {
        if (AdsPost == "1")
        {
            Response.Redirect("Admin_AdsPost.aspx");
        }
        else
        {
            strScript = "alert('Your Doesnot have permissions to post ads. Get Permissions to post ads from admin');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
    }
    protected void lnkbtnHome_Click(object sender, EventArgs e)
    {
        if (AdsView == "1")
        {
            Response.Redirect("Admin_Ads.aspx");
        }
        else
        {
            strScript = "alert('Your Doesnot have permissions to view ads. Get Permissions to view ads from admin');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
    }
    protected void lnkBtnComments_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin_AdsReviews.aspx");
    }
    protected void lnkBtnViewRatings_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin_AdsRatingView.aspx");
    }
}
