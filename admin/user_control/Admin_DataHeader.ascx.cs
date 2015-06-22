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

public partial class admin_user_control_Admin_DataHeader : System.Web.UI.UserControl
{
    string BView;
    string B2BView;
    string EveView;
    string DisView;
    string JobView;
    string LSView;
    string FLView;
    string MoviesView;
    string strScript;
    string BPost;
    string B2BPost;
    string EvePost;
    string DisPost;
    string JobPost;
    string LSPost;
    string FLPost;
    protected void Page_Load(object sender, EventArgs e)
    {        
         BView = Convert.ToString(Session["BView"]);        
         B2BView = Convert.ToString(Session["B2BView"]);
         EveView = Convert.ToString(Session["EveView"]);
         DisView = Convert.ToString(Session["DisView"]);
         JobView = Convert.ToString(Session["JobView"]);
         LSView = Convert.ToString(Session["LSView"]);
         FLView = Convert.ToString(Session["FLView"]);
         MoviesView = Convert.ToString(Session["MoviesView"]);
         BPost = Convert.ToString(Session["BPost"]);
         B2BPost = Convert.ToString(Session["B2BPost"]);
         EvePost = Convert.ToString(Session["EvePost"]);
         DisPost = Convert.ToString(Session["DisPost"]);
         JobPost = Convert.ToString(Session["JobPost"]);
         LSPost = Convert.ToString(Session["LSPost"]);
         FLPost = Convert.ToString(Session["FLPost"]);
    }
    /// <summary>
    /// To go Admin control home page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkbtnHome_Click(object sender, EventArgs e)
    {
        if (Convert.ToString(Request.QueryString["mod"]) != null)
        {
            string module = Convert.ToString(Request.QueryString["mod"]);
            Response.Redirect("Admin_Home.aspx?mod='" + module + "'");
        }
        else if (BView == "1" || B2BView == "1" || EveView == "1" || DisView == "1" || JobView == "1" || LSView == "1" || MoviesView == "1")
        {
            Response.Redirect("Admin_Home.aspx");
        }
        else
        {
            strScript = "alert('Your Doesnot have permissions to view data. Get Permissions to view data from admin');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
    }
    /// <summary>
    /// To post data from admin control
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkbtnPostData_Click(object sender, EventArgs e)
    {
        if (Convert.ToString(Request.QueryString["mod"]) != null)
        {
            string module = Convert.ToString(Request.QueryString["mod"]);
            Response.Redirect("Admin_PostData.aspx?mod=" + module + "");
        }
        else if (BPost == "1" || B2BPost == "1" || EvePost == "1" || DisPost == "1" || JobPost == "1" || LSPost == "1")
        {
            Response.Redirect("Admin_PostData.aspx");
        }
        else
        {
            strScript = "alert('Your Doesnot have permissions to post data. Get Permissions to post data from admin');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
    }

}
