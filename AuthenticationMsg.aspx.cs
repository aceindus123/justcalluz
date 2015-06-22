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
using System.Net;
using System.Net.NetworkInformation;
using System.Web.Routing;

/// <summary>
/// Class to display Message
/// </summary>
public partial class AuthenticationMsg : System.Web.UI.Page
{
    static string excep_page = "AuthenticationMsg.aspx";
    InsertData obj = new InsertData();
    //Function to execute whenever page is loading
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string ms = Convert.ToString(Page.RouteData.Values["msg"]);
            if (ms == "Advertise")
            {
                lblMsg.Text = "You are registered as Individual User.<br>" +
                    "Inorder to Advertise with us you need to registered as Business type registration";
            }
            else if (ms == "jobs")
            {
                lblMsg.Text = "Sorry , You are not the authenticated user to post the Jobs .<br>" + " To post the job register as Business type";
            }
            else if (ms == "Events")
            {
                lblMsg.Text = "Sorry , You are not the authenticated user to post the Events .<br>" + " To post the job register as Business type ";
            }
            else if (ms == "Discount")
            {
                lblMsg.Text = "Sorry , You are not the authenticated user to post the Discount .<br>" + " To post the job register as Business type";
            }
            else if (ms == "LifeStyle")
            {
                lblMsg.Text = "Sorry , You are not the authenticated user to post the Lifestyle .<br>" + " To post the job register as Business type";
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
}
