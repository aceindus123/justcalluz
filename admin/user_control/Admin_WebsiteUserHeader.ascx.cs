using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_user_control_Admin_WebsiteUserHeader : System.Web.UI.UserControl
{
    string UInfoView;
    string strScript;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void lnkbtnHome_Click(object sender, EventArgs e)
    {
        UInfoView=Convert.ToString(Session["UInfoView"]);
        if (UInfoView == "1")
        {
            Response.Redirect("Admin_WesiteUsersInfo.aspx");
        }
        else
        {
            strScript = "alert('Your Doesnot have permissions to view justcalluz.com users info. Get Permissions to view justcalluz.com users info from admin');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
    }
}
