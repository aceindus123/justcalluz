using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_user_control_Admin_CSRHead : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void lnkbtnHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin_CorporateSocial.aspx");
    }
    protected void lnkbtnPostCSR_Click(object sender, EventArgs e)
    {
        if (Convert.ToInt32(Session["CSRPost"].ToString()) == 1)
        {
            Response.Redirect("Admin_CSRPost.aspx");
        }
        else
        {
            string strScript = "alert('You have no permission to post corporate social responsibility.');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
        }
    }
}
