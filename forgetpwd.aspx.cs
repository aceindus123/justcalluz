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
using System.Net;
using System.Net.Mail;
using System.Web.Routing;

/// <summary>
/// Class to forget password
/// </summary>
public partial class forgetpwd : System.Web.UI.Page
{
    //To make connection
    SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    InsertData obj = new InsertData();
    static string excep_page = "forgetpwd.aspx";
    /// <summary>
    /// Executes whenever page is loading
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    /// <summary>
    /// To check custom validation
    /// </summary>
    /// <param name="source"></param>
    /// <param name="args"></param>
    protected void custvalAnyone_ServerValidate(object source, ServerValidateEventArgs args)
    {
        try
        {
            if (txtEmail.Text != "" || txtMobNo.Text != "")
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
            if (txtEmail.Text != "" && txtMobNo.Text != "")
            {
                args.IsValid = false;
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    /// <summary>
    /// Fuction to get the forgetten password through email
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void imgBtnSubmitForgetPassword_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            //if else statement for to check user id which you entered is existed or not
            if (!txtEmail.Text.Trim().ToLower().Equals(""))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    //To open connection
                    connection.Open();
                    Int16 cnt;
                    //Checking wether the role name is already exist or not
                    cmd.CommandText = "SELECT COUNT(*) FROM register WHERE email ='" + txtEmail.Text.Replace("'", "''").Trim().ToLower() + "'";
                    cnt = Convert.ToInt16(cmd.ExecuteScalar());
                    if (cnt == 1)
                    {
                        SqlCommand cmduid = new SqlCommand("SELECT email,password,mob FROM register WHERE email='" + txtEmail.Text.Replace("'", "''").Trim() + "'", connection);
                        SqlDataReader drUid;
                        drUid = cmduid.ExecuteReader();
                        //Send mail to the id which you entered in the text field with your password details
                        if (drUid.HasRows)
                        {
                            drUid.Read();
                            string mailid = string.Empty;
                            mailid = drUid["email"].ToString();
                            MailMessage MsgMail = new MailMessage();
                            MsgMail.Subject = "Confidential Description :";
                            string bdy = "";
                            bdy += "Dear Just Call Uz Member,<br>";
                            bdy += "<br> We have received a request for your password for Email ID: '" + mailid + "'";
                            bdy += "<br> Your password : " + drUid["password"].ToString();
                            bdy += "<br> Your Mobile Number : " + drUid["mob"].ToString();
                            bdy += "<br> For security reasons we recommend the following:";
                            bdy += "<br><br> 1. Never give out your Just call us password ";
                            bdy += "<br> 2. Make a password with special characters and numbers";
                            bdy += "<br> 3. Make your password easy for you to remember, but difficult for others to guess<br><br>";
                            bdy += "<br> <br>Thank you for using Just Calluz";
                            bdy += "<br> <br><br>Regards,";
                            bdy += "<br> Customer Care Just Calluz";
                            bdy += "<br> <br><br>http://www.justcalluz.com/";
                            drUid.Close();

                            MsgMail.From = new MailAddress("info@justcalluz.com");
                            MsgMail.To.Add(mailid);

                            MsgMail.IsBodyHtml = true;
                            MsgMail.Body = bdy;
                            SmtpClient smtp = new SmtpClient();
                            smtp.Send(MsgMail);
                            //lblMsg.Text = "Your Password has been sent to your mail id.";
                            string strScript = "";
                            strScript = "alert('Your Password has been sent to your mail id');location.replace('signin');";
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                            txtEmail.Text = "";
                        }
                    }
                    else
                    {
                        lblMsg.Text = "Invalid User Id";
                        txtEmail.Text = "";
                    }
                }
                // To catch exception
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
                finally
                {
                    //To close connection
                    connection.Close();
                }
            }
            else if (!txtMobNo.Text.Trim().ToLower().Equals(""))
            {

            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        
    }
}