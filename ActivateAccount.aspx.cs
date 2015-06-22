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
using CallUsRegistration.Registration;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Net.NetworkInformation;
using System.Web.Routing;
/// <summary>
/// Class to Activate the user Account
/// </summary>
public partial class ActivateAccount : System.Web.UI.Page
{
    public string uid = "";
    public string AcId = string.Empty;
    bool t;
    static string excep_page = "ActivateAccount.aspx";
    static string gender;
    InsertData obj = new InsertData();
    // To make connection
    SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    /// <summary>
    /// It executes when page is loading
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        // Put user code to initialize the page here
        try
        {
            // This data will come from mail when you click on the link present in the mail
            if (Page.RouteData.Values["UserId"] != null)
            {
                uid = Convert.ToString(Page.RouteData.Values["UserId"]);
            }
            if (Page.RouteData.Values["ActiveId"] != null)
            {
                AcId = Convert.ToString(Page.RouteData.Values["ActiveId"].ToString().Trim());
            }
            
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        //catch (Exception ex)
        //{   //To catch the exception
        //    lblMessage.Text = ex.Message.ToString();
        //}
    }
    /// <summary>
    /// This function will execute when you click on the Activate account button
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnActivate_Click(object sender, EventArgs e)
    {
        DataSet dsUserDetails = new DataSet();
        try
        {
            // Getting the class from ApCode
            RegistrationCS regprop = new RegistrationCS();
            //Checkuser chkUser = new Checkuser();
            regprop.vActiveId = AcId.ToString();
            regprop.pUserid = uid;
            Int32 Status = 0;    
            // To check user is valid or not
            Int16 Count = Convert.ToInt16(regprop.CheckValidUser(regprop.pUserid, regprop.vActiveId, Status));
            if (Count == 1)
            {
                Status = 1;
                t = regprop.ActivateUser(regprop.pUserid, regprop.vActiveId, Status);
                // Executes when user is valid & to make the user is authenticated
                
                    if (t == true)
                    {
                        // To open connection
                        //sqlConnection.Open();
                        // To fill the adapter
                        SqlDataAdapter imgtext = new SqlDataAdapter("select * from register where id='" + uid + "'", sqlConnection);
                        //To fill the dataset
                        imgtext.Fill(dsUserDetails, "Registration");
                        // Checking dataset has rows or not if has assigning the values to the sessions
                        if (!dsUserDetails.Tables[0].Rows.Count.Equals(0))
                        {
                            Session["USERNAME"] = dsUserDetails.Tables[0].Rows[0]["name"].ToString();
                            Session["UserLName"] = dsUserDetails.Tables[0].Rows[0]["LastName"].ToString();
                            Session["USERID"] = dsUserDetails.Tables[0].Rows[0]["email"].ToString();
                            Session["PASSWORD"] = dsUserDetails.Tables[0].Rows[0]["password"].ToString();
                            gender = dsUserDetails.Tables[0].Rows[0]["Gender"].ToString();
                        }
                        Session["IPaddr"] = HttpContext.Current.Request.UserHostAddress.ToString();
                        // To close the connection
                        //sqlConnection.Close();
                        string uname = Convert.ToString(Session["USERNAME"]);
                        string lname = Convert.ToString(Session["UserLName"]);
                        string emailid = Convert.ToString(Session["USERID"]);
                        string password = Convert.ToString(Session["PASSWORD"]);
                        SqlCommand cmd = new SqlCommand("jcalluzchat", sqlConnection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@first", uname);
                        cmd.Parameters.AddWithValue("@last", lname);
                        cmd.Parameters.AddWithValue("@username", uname);
                        cmd.Parameters.AddWithValue("@pwd", password);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@userid", 0);
                        cmd.Parameters.AddWithValue("@roomid", 0);
                        sqlConnection.Open();
                        cmd.ExecuteNonQuery();
                        sqlConnection.Close();
                        // To send mail
                        SendMail(uname, lname, emailid, password);
                        string strScript = "";
                        // Script to display activation message
                        strScript = "alert('Activated Successfully');location.replace('Home');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);

                    }
                    // Executes when user is not a valid user
                    else
                    {
                        // Script to display message
                        string strScript = "";
                        strScript = "alert('Not Activated');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                    }
               
            }
            // Displays message if user is already activated
            else
            {
                //lblMessage.Text = "You Are Not Authorised to Activate Your Account";               
                string strScript = "";
                strScript = "alert('You Are already Activated Your Account');location.replace('Home');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
     
    }
    /// <summary>
    /// To send mail to confirm the activation of the registration process
    /// </summary>
    /// <param name="Uname"></param>
    /// <param name="Lname"></param>
    /// <param name="email"></param>
    /// <param name="pwd"></param>
    private void SendMail(string Uname, string Lname,string email,string pwd)
    {
            string Msg = "";

         
                MailMessage mm = new MailMessage();
                mm.From = new MailAddress("info@justcalluz.com");
                // Address to whom we send mail
                mm.To.Add(email);                
                Msg += "Dear " + Uname + " " + Lname + ",";
                // Message body
                Msg += "<br><br>Thank you for your registration to Just Callus. Registration allows you to gain access to post your business, jobs, events and discounts."+
                       "<br><br>Your ‘Login Details’ are as follows:"+
                       "<br><br> Username: "+ email +
                       "<br>Password: " + pwd +                       
                       "<br><br> For any support or query, please contact us at support@justcalluz.com "+
                       "<br><br>Warm Regards," +
                       "<br><br> Just Call Uz Team";
                // Subject of the mail     
                mm.Subject = "Just Call Uz - Account Created Successfully";
                mm.IsBodyHtml = true;
                // Adding Message to the Mail
                mm.Body = Msg;
                // Smtp Client declaration
                SmtpClient smtp = new SmtpClient();
                smtp.Send(mm);         

    }

}
