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
using System.Data.SqlClient;
using System.Web.Routing;

/// <summary>
/// Class to change password
/// </summary>
public partial class ChangePassword : System.Web.UI.Page
{
       SqlConnection Connection =new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
         
    InsertData obj = new InsertData();
    string UName = string.Empty;
    static string excep_page = "ChangePassword.aspx";
    /// <summary>
    /// Executes when ever a page loads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
           // Put user code to initialize the page here
            lblemail.Text = Convert.ToString(Session["USERID"]);
            lblmob.Text = Convert.ToString(Session["Mob"]);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    /// Class to alert
    /// </summary>
    public static class Alert
    {

        /// <summary> 
        /// Shows a client-side JavaScript alert in the browser. 
        /// </summary> 
        /// <param name="message">The message to appear in the alert.</param> 
        public static void Show(string message)
        {
            InsertData obj = new InsertData();
            try
            {
                // Cleans the message to allow single quotation marks 
                string cleanMessage = message.Replace("'", "\\'");
                string script = "<script type=\"text/javascript\">alert('" + cleanMessage + "');</script>";

                // Gets the executing web page 
                Page page = HttpContext.Current.CurrentHandler as Page;

                // Checks if the handler is a Page and that the script isn't allready on the Page 
                if (page != null && !page.ClientScript.IsClientScriptBlockRegistered("alert"))
                {
                    page.ClientScript.RegisterClientScriptBlock(typeof(Alert), "alert", script);
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                ChangePassword obj1 = new ChangePassword();
                obj1.redirect("HttpErrorPage.aspx", false);
                
            }
        }
    }
    /// <summary>
    /// To check the login is correct or not
    /// </summary>
    /// <param name="Username"></param>
    /// <param name="Password"></param>
    /// <returns></returns>
    public int Validate_Login(String Username, String Mob, String Password)
    {
           SqlCommand cmdselect = new SqlCommand();
            cmdselect.CommandType = CommandType.StoredProcedure;
            cmdselect.CommandText = "[dbo].[loginSP]";
            cmdselect.Parameters.Add("@userid", SqlDbType.VarChar, 50).Value = Username;
            cmdselect.Parameters.Add("@mobno", SqlDbType.VarChar, 50).Value = Mob;
            cmdselect.Parameters.Add("@userpwd", SqlDbType.VarChar, 50).Value = Password;
            cmdselect.Parameters.Add("@OutRes", SqlDbType.Int, 4);
            cmdselect.Parameters["@OutRes"].Direction = ParameterDirection.Output;
            cmdselect.Connection = Connection;
            int Results = 0;

            try
            {
                Connection.Open();
                cmdselect.ExecuteNonQuery();
                Results = (int)cmdselect.Parameters["@OutRes"].Value;
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
            //catch (SqlException ex)
            //{
            //    lblerror.Text = ex.Message;
            //}
            finally
            {
                cmdselect.Dispose();
                if (Connection != null)
                {
                    Connection.Close();
                }
            }
          return Results;

    }
    /// <summary>
    /// Executes when you click on the change password button
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSubmitChangePWD_Click(object sender, EventArgs e)
    {
        try
        {
            if (Session["USERID"] != null)
            {
                int Results = 0;
                //Check the user id and old password if you entered the correct values then validate_login function will execute
                if (email.Text != "" && oldpassword.Text != "")
                {

                    Results = Validate_Login(lblemail.Text, lblmob.Text, oldpassword.Text);
                    //lblmsg.Text = "you entered correct emailid and password";
                }
                else
                {
                    lblmsg.Text = "Please make sure that the Username and the Password is Correct";
                }

                if (Results == 1)
                {
                    try
                    {

                        if (newpassword.Text == confirmpassword.Text)
                        {
                            //To Make Connection
                            //string Connection = ConfigurationManager.AppSettings["ConnectionString"];
                            //SqlConnection conn = new SqlConnection(Connection);
                            string query = "update register set password='" + newpassword.Text + "' WHERE email='" + lblemail.Text + "'";
                           
                                SqlCommand cmd = new SqlCommand(query, Connection);
                            try{
                                
                                //To open connection
                                 Connection.Open();
                                //To execute the query
                                cmd.ExecuteNonQuery();
                                UName=Convert.ToString(Session["USERNAME"]);
                                string strScript = "";
                                strScript = "alert('Your Password has been Changed.');location.replace('Profile-" + UName + "');";//'MyProfile.aspx?uid=" + lblemail.Text + "'
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                            }
                            catch (Exception ex)
                            {
                                obj.insert_exception(ex, excep_page);
                                Response.Redirect("HttpErrorPage.aspx");
                            }
                            finally
                            {
                                cmd.Dispose();
                                //To close connection
                                Connection.Close();
                            }

                            oldpassword.Text = string.Empty;
                            lblerror.Text = ""; ;
                            lblerror.ForeColor = System.Drawing.Color.Green;

                        }

                        else
                        {
                            lblerror.Text = "retry";
                            lblerror.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                    catch (Exception ex)
                    {
                        obj.insert_exception(ex, excep_page);
                        Response.Redirect("HttpErrorPage.aspx");
                    }

                    lblmsg.Visible = false;




                }
                else
                {
                    lblerror.Visible = false;
                    lblmsg.Text = "Please make sure that the User Name and the password is Correct";
                    lblmsg.ForeColor = System.Drawing.Color.Red;
                    //Dont Give too much information this might tell a hacker what is wrong in the login
                }
            }
            else
            {
                string strScript = "";
                strScript = "alert('Your session is expired. Please Relogin');location.replace('signin');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    /// To cancel the changing password
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        UName = Convert.ToString(Session["USERNAME"]);
        try
        {
            string strScript = "";
            strScript = "alert('Cancel Password Change.');location.replace('Profile-" + UName + "');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    public void redirect(string url, bool val)
    {
        if (!val)
        {
            HttpContext.Current.Response.Redirect(url, false);
            HttpContext.Current.ApplicationInstance.CompleteRequest();
        }
        else
        {
            HttpContext.Current.Server.ClearError();
            HttpContext.Current.Response.Redirect(url, false);
            HttpContext.Current.Server.ClearError();
        }

    }
}
