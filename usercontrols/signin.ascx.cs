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
using CallUsSession.SessionChecking;
using System.Security.Cryptography;
using System.Text;

public partial class usercontrol_signin : System.Web.UI.UserControl
{
    InsertData obj = new InsertData();
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    static string excep_page = "signin.ascx";
    string ipaddress;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            SessionCheck schk = new SessionCheck();
            string uid = Convert.ToString(Session["USERID"]);
            string upw = Convert.ToString(Session["PASSWORD"]);
            DataSet dsUserDetails = new DataSet();
            //schk.EnableViewState = true;
            ipaddress = GetIP();
            lblIPaddress.Text = ipaddress;     
            if (uid != "" && upw != "")
            {
                if (!IsPostBack)
                {
                    try
                    {
                        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                        sqlConnection.Open();
                        SqlDataAdapter imgtext = new SqlDataAdapter("select id,name,LastLoginTime from register where email='" + uid + "'", sqlConnection);
                        imgtext.Fill(dsUserDetails, "Registration");

                        if (!dsUserDetails.Tables[0].Rows.Count.Equals(0))
                        {
                            Session["Id"] = dsUserDetails.Tables[0].Rows[0]["id"].ToString();
                            Session["USERNAME"] = dsUserDetails.Tables[0].Rows[0]["name"].ToString();
                            lblUName.Text = Session["USERNAME"].ToString();
                            string date = dsUserDetails.Tables[0].Rows[0]["LastLoginTime"].ToString();
                            DateTime logdate=Convert.ToDateTime(date);
                           // string dt = Convert.ToDateTime(date).ToString("dd-MMM-yyyy hh:mm tt");
                           

                            
                            TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById(TimeZone.CurrentTimeZone.StandardName);
                            DateTime easternTime = TimeZoneInfo.ConvertTimeFromUtc(logdate, easternZone);
                            string[] words = TimeZone.CurrentTimeZone.StandardName.Split(" ".ToCharArray());
                            string tzabbr = "";
                            foreach (string word in words)
                                tzabbr += word[0];
                            lblLastLogIn.Text = easternTime.ToString() + " (" + tzabbr + ")";
                            //Response.Write(easternTime);  
                        }                                      
                      
                        sqlConnection.Close();
                        tdLogout.Visible = true;
                        tdLastLogin.Visible = true;
                        tdMyProfile.Visible = true;
                        tdSignIn.Visible = false;
                        tdPostCheck.Visible = true;
                        tdSignUp.Visible = false;
                        tdSignUpImg.Visible = false;
                        tdSignInImg.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        obj.insert_exception(ex, excep_page);
                        Response.Redirect("HttpErrorPage.aspx");
                    }
                }
            }
            else
            {
                lblUName.Text = "Guest";
                Session["USERNAME"] = lblUName.Text;
                tdLogout.Visible = false;
                tdLastLogin.Visible = false;
                tdMyProfile.Visible = false;
                tdSignIn.Visible = true;
                tdPostCheck.Visible = false;
                tdSignUp.Visible = true;
                tdSignUpImg.Visible = true;
                tdSignInImg.Visible = true;
               
            }                                                             
            //CheckSessionTimeout();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }    
    protected void lnkBtnMyProfile_Click(object sender, EventArgs e)
    {
        // string sid = Convert.ToString(Session["USERID"]);
        string sid = Convert.ToString(Session["USERNAME"]);
        //RSACryptoServiceProvider myRsa = new RSACryptoServiceProvider();
        //byte[] messageBytes = Encoding.Unicode.GetBytes(uid);
        //byte[] encryptedMessage = myRsa.Encrypt(messageBytes, false);
        //string userid = Convert.ToString(Encoding.Unicode.GetString(encryptedMessage));
        if (Session["USERID"] != null)
        {

            //Response.Redirect("MyProfile.aspx?uid=" + uid);
            Response.RedirectToRoute("profile", new { uid = sid });
        }
        else
        {
            string strScript = "";
            strScript = "alert('Your session is expired. Please Relogin'); location.replace('signin');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
        }
    }

    protected void lnkBtnTocheckPostings_Click(object sender, EventArgs e)
    {
        //string uid = Convert.ToString(Session["USERID"]);
        string uid = Convert.ToString(Session["USERNAME"]);
        if (Session["USERID"] != null)
        {
            //Response.Redirect("ToCheckPostings.aspx?id=" + uid);
            Response.RedirectToRoute("checkposting", new { id = uid });
        }
        else
        {
            string strScript = "";
            strScript = "alert('Your session is expired. Please Relogin'); location.replace('signin');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
        }

    }
    protected string GetIP()
    {

        try
        {
            string Sinfo;
            HttpRequest currentRequest = HttpContext.Current.Request;
            Sinfo = currentRequest.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (Sinfo == null || Sinfo.ToLower() == "unknown")
            {
                Sinfo = currentRequest.ServerVariables["REMOTE_ADDR"];
                Sinfo += "/" + currentRequest.ServerVariables["LOGON_USER"];
            }
            string[] computerinfo = Sinfo.Split('/');

            return computerinfo[0];
        }
        catch (Exception ex)
        {
            throw ex;
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
