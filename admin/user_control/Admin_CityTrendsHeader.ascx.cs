using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_user_control_Admin_CityTrendsHeader : System.Web.UI.UserControl
{    
    string CTPost;    
    string CTView;
    string strScript;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void lnkbtnHome_Click(object sender, EventArgs e)
    {
        CTView = Convert.ToString(Session["CTView"]);
        if (CTView == "1")
        {
            Response.Redirect("Admin_CityTrends.aspx");
        }
        else
        {
            strScript = "alert('Your Doesnot have permissions to view city trends. Get Permissions to view city trends from admin');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
    }
    protected void lnkBtnPostCT_Click(object sender, EventArgs e)
    {
        CTPost = Convert.ToString(Session["CTPost"]);
        if (CTPost == "1")
        {
            Response.Redirect("Admin_ToPostCityTrends.aspx");
        }
        else
        {
            strScript = "alert('Your Doesnot have permissions to post city trends. Get Permissions to post city trends from admin');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
    }
}
