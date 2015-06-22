using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_user_control_Admin_WebAdminHeader : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void lnkbtnHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin-UserDetails.aspx");
    }
    protected void lnkbtnPostData_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin_ToCreateWebAdmins.aspx");
    }
}
