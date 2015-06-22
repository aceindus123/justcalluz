using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_user_control_Admin_MediaHeader : System.Web.UI.UserControl
{

    string strScript;
    string MSPost;
    string MSView;
    protected void Page_Load(object sender, EventArgs e)
    {
        MSPost = Convert.ToString(Session["MSPost"]);
        MSView = Convert.ToString(Session["MSView"]);
    }
    protected void lnkbtnPostMedia_Click(object sender, EventArgs e)
    {       
        if (MSPost == "1")
        {
            Response.Redirect("Admin_MediaPost.aspx");
        }
        else
        {
            strScript = "alert('Your Doesnot have permissions to post media speak. Get Permissions to post media speak from admin');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
    }
    protected void lnkbtnHome_Click(object sender, EventArgs e)
    {        
        if (MSView == "1")
        {
            Response.Redirect("Admin_Media.aspx");
        }
        else
        {
            strScript = "alert('Your Doesnot have permissions to view media speak. Get Permissions to view media speak from admin');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
    }
}
