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
/// <summary>
/// Class to login into admin control
/// </summary>
public partial class Admin_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //string strHostName = System.Net.Dns.GetHostName();
        //string strIp = System.Net.Dns.GetHostAddresses(strHostName).GetValue(0).ToString();
        //l2.Text = strIp;
    }
    /// <summary>
    /// Event fires when user clicked to log in into their account
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void AdminLogin_Click(object sender, EventArgs e)
    {
        if ((txtUserId.Text == "admin") && (txtPWD.Text == "admin"))
        {
            tdmsg.InnerHtml = "";
            Response.Redirect("data.aspx");
        }
        else
        {
            tdmsg.InnerHtml = "Please Enter Correct UserId and Password";
        }
       
    }
}
