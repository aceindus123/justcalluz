using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using CallUsRegistration.Registration;
/// <summary>
/// To log out from the account
/// </summary>
public partial class indusinc_Logout : System.Web.UI.Page
{
    string UserId;
    RegistrationCS reg = new RegistrationCS();
    /// <summary>
    /// Executes whenever page loads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        
        UserId = Convert.ToString(Session["LogInId"]);
        //if (UserId != "")
        //{
        //    // it will stays in the same page
        //}

        //else
        //{
        //    //After login into the account it will go Post ad
        //    Response.Redirect("Default.aspx");

        //}
        //To make connection
        //SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
        //string userid = Convert.ToString(Session["USERID"]);
        //// To Insert Last Login Time into database
        //string statement = "update register set LastLoginTime=convert(varchar, DATEADD(mi,750,CONVERT(varchar, GETDATE(), 120)), 0) where email='" + userid + "'";
        //con.Open();
        //SqlCommand cmd = new SqlCommand(statement, con);
        //cmd.ExecuteNonQuery();
        //con.Close();
        // Put user code to initialize the page here
        // To end the session
        reg.loginstat = 0;
        reg.pUserid = UserId;
        reg.LoginStatus(reg.pUserid, reg.loginstat);
        Session.Abandon();
        Response.Redirect("Default.aspx");
        Session.Abandon();
    }
   
    protected void Button1_Click1(object sender, EventArgs e)
    {

        Server.Execute("Response.aspx");
    }
}
