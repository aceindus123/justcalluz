using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class admin_user_control_Admin_CareersHeader : System.Web.UI.UserControl
{
    string Careers;
    string CareersPost;    
    string CareersView;
    string strScript;
    protected void Page_Load(object sender, EventArgs e)
    {
             
    }
    protected void lnkbtnPostCareers_Click(object sender, EventArgs e)
    {
        string postcareers = Convert.ToString(Session["CareersPost"]);       
        if (postcareers == "1")
        {
            Response.Redirect("Admin_ToPostCareers.aspx");
        }
        else
        {
            strScript = "alert('Your Doesnot have permissions to post careers. Get Permissions to post careers from admin');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }   
        
    }
    protected void lnkbtnHome_Click(object sender, EventArgs e)
    {
        string CareersView = Convert.ToString(Session["CareersView"]);
        if (CareersView == "1")
        {
            Response.Redirect("Admin_Careers.aspx");
        }
        else
        {
            strScript = "alert('Your Doesnot have permissions to view careers. Get Permissions to view careers from admin');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
    }
    protected void lnkBtnResumes_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin_ViewCareerResume.aspx");
    }
}
