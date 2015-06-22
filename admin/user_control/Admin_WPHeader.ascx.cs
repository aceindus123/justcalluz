using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_user_control_Admin_WPHeader : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void lnkbtnPostWP_Click(object sender, EventArgs e)
    {
        int post = Convert.ToInt32(Session["WPPost"].ToString());
        if (post == 1)
        {
            Response.Redirect("Admin_WhitePagesPost.aspx");
        }
        else
        {
            string strscript = "alert('You have no permission to post white pages');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strscript, true);
        }
    }
    protected void lnkbtnHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin_WhitePages.aspx");
    }
}
