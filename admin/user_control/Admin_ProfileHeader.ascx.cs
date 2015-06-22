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

public partial class admin_user_control_Admin_ProfileHeader : System.Web.UI.UserControl
{
    string userid;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        userid = Convert.ToString(Session["LoginId"]);
        
    }
    protected void lnkProfile_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin_Profile.aspx?uid="+userid);
    }
    protected void lnkbChangePW_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin_ChangePW.aspx");
    }    
}
