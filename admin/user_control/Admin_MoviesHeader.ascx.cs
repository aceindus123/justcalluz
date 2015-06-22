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

public partial class admin_user_control_Admin_MoviesHeader : System.Web.UI.UserControl
{
    string MoviesPost;
    string MoviesView;
    string strScript;
    protected void Page_Load(object sender, EventArgs e)
    {
        MoviesPost = Convert.ToString(Session["MoviesPost"]);
        MoviesView = Convert.ToString(Session["MoviesView"]);
    }
    protected void lnkbtnHome_Click(object sender, EventArgs e)
    {
        if (MoviesView == "1")
        {
            Response.Redirect("Admin_Movies.aspx");
        }
        else
        {
            strScript = "alert('Your Doesnot have permissions to view Movies. Get Permissions to view Movies from admin');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
    }
    protected void lnkBtnPostHallsData_Click(object sender, EventArgs e)
    {
        if (MoviesPost == "1")
        {
            Response.Redirect("Admin_ToPostCinemaHallDetails.aspx");
        }
        else
        {
            strScript = "alert('Your Doesnot have permissions to post theatres information. Get Permissions to post theatres information from admin');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
    }
    protected void lnkbtnPostMovies_Click(object sender, EventArgs e)
    {
        if (MoviesPost == "1")
        {
            Response.Redirect("Admin_TopostMovies.aspx");
        }
        else
        {
            strScript = "alert('Your Doesnot have permissions to post movies. Get Permissions to post movies from admin');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
    }
    protected void lnkBtnView_Click(object sender, EventArgs e)
    {
        if (MoviesView == "1")
        {
            Response.Redirect("Admin_ViewHallsData.aspx");
        }
        else
        {
            strScript = "alert('Your Doesnot have permissions to view theatres information. Get Permissions to view theatres information from admin');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
    }
}
