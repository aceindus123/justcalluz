using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_user_control_Admin_SSHeader : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void lnkbtnHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin_SuccessStories.aspx?Type=SSText&s=Andhra Pradesh&c=Hyderabad");
    }
    protected void lnkbtnPostSS_Click(object sender, EventArgs e)
    {
        if (Convert.ToInt32(Session["SSPost"].ToString()) == 1)
        {
            Response.Redirect("Admin_SSPost.aspx");
        }
        else
        {
            string strscript = "alert('You have no permission to post success stories.');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strscript, true);
        }

    }
    protected void lnkBtnPostSSVideos_Click(object sender, EventArgs e)
    {
        if (Convert.ToInt32(Session["SSPost"].ToString()) == 1)
        {
            Response.Redirect("Admin_SSPostVideos.aspx");
        }
        else
        {
            string strscript = "alert('You have no permission to post success videos .');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strscript, true);
        }

        
    }
    protected void lnkBtnViewVideos_Click(object sender, EventArgs e)
    {
        if (Convert.ToInt32(Session["SSView"].ToString()) == 1)
        {
            Response.Redirect("Admin_SuccessStories.aspx?Type=SSVideo&s=Andhra Pradesh&c=Hyderabad");
        }
        else
        {
            string strscript = "alert('You have no permission to view success stories and success videos.');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strscript, true);
        }

        
    }
}
