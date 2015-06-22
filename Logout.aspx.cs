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
using System.Web.Routing;

/// <summary>
/// To log out from the account
/// </summary>
public partial class indusinc_Logout : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    static string excep_page = "Logout.aspx";
    InsertData obj = new InsertData();
    /// <summary>
    /// Executes whenever page loads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            //To make connection

            string userid = Convert.ToString(Session["USERID"]);
            // To Insert Last Login Time into database
            string statement = "update register set LastLoginTime='" + DateTime.UtcNow.ToString() + "' where email='" + userid + "'";

            SqlCommand cmd = new SqlCommand(statement, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            // Put user code to initialize the page here
            // To end the session
            Session.Abandon();
            // Response.Redirect("Default.aspx");
            Response.RedirectToRoute("HomeRoute");
            Session.Abandon();
        }
         catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
   
    protected void Button1_Click1(object sender, EventArgs e)
    {
         Server.Execute("Response.aspx");
    }
}
