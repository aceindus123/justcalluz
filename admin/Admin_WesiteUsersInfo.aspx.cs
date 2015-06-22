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
using System.Data.SqlClient;
using CallUsRegistration.Registration;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
/// <summary>
/// class to view justcalluz.com users
/// </summary>
public partial class admin_Admin_WesiteUsersInfo : System.Web.UI.Page
{
    //making connection
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    //declaration of variables and creation of objects for classes
    RegistrationCS reg=new RegistrationCS();
    DataSet ds = new DataSet();
    Int32 status;
    string designation;
    bool t;
    string strScript;
    string Email;
    string UFName;
    string ULName;
    string AId;
    string UserId;
    string ActiveDeactive;
    /// <summary>
    /// Executes whenever page loads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        UserId = Convert.ToString(Session["LogInId"]);
        if (UserId != "")
        {
            // it will stays in the same page
        }

        else
        {
            //After login into the account it will go Post ad
            Response.Redirect("Default.aspx");

        }
        //loads the page without postbacking the values
        if (!IsPostBack)
        {
            ItemsGet();
        }
    }
    /// <summary>
    /// bind users info
    /// </summary>
    private void ItemsGet()
    {
        Binddata obj = new Binddata();
        DataSet ds = new DataSet();
        con.Open();
        ds = obj.bindRegisteredUsers();
        ViewGridRegUsers.DataSource = ds;
        ViewGridRegUsers.DataBind();
        con.Close();
        ActiveDeactive = Convert.ToString(Session["UInfoStatus"]);
        if (ActiveDeactive == "1")
        {
            ViewGridRegUsers.Columns[7].Visible = true;
        }
        else
        {
            ViewGridRegUsers.Columns[7].Visible = false;
        }
    }
    /// <summary>
    /// when page changes
    /// </summary>
    /// <param name="source"></param>
    /// <param name="e"></param>
    protected void ViewGridRegUsers_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        ViewGridRegUsers.PageIndex = e.NewPageIndex;
        ItemsGet();
    }
    /// <summary>
    /// To change status of the user
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ChangeStatus(object sender, CommandEventArgs e)
    {
        Int32 id = Convert.ToInt32(e.CommandArgument.ToString());
        con.Open();
        ds =reg.getWebsiteUserStatus(id);
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            status = Convert.ToInt32(ds.Tables[0].Rows[0]["iStatus"].ToString());
            Email = Convert.ToString(ds.Tables[0].Rows[0]["email"].ToString());
            UFName = Convert.ToString(ds.Tables[0].Rows[0]["name"].ToString());
            ULName = Convert.ToString(ds.Tables[0].Rows[0]["LastName"].ToString());
            AId = Convert.ToString(ds.Tables[0].Rows[0]["iActiveId"].ToString());            
        }
        if (status == 1)
        {
            reg.pId = id;
            reg.pStatus = 0;           
            t = reg.User_ChangeStatus(reg.pId, reg.pStatus);
            SendMailStatusConfirmation(UFName, ULName, Email, AId,Convert.ToString(reg.pStatus), id);            
            strScript = "alert('" + Email + " is successfully Dectivated.');location.replace('Admin_WesiteUsersInfo.aspx');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);

        }
        else if (status == 0)
        {
            reg.pId = id;
            reg.pStatus = 1;            
            t = reg.User_ChangeStatus(reg.pId, reg.pStatus);
            SendMailStatusConfirmation(UFName, ULName, Email, AId, Convert.ToString(reg.pStatus), id);            
            strScript = "alert('" + Email + " is successfully Activated.');location.replace('Admin_WesiteUsersInfo.aspx');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
        con.Close();
    }
    /// <summary>
    /// binding dynamically
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ViewGridRegUsers_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {

            LinkButton lnkStatusChange = (LinkButton)e.Row.FindControl("lnkBtnStatusChange");
            Label lblStatus = (Label)e.Row.FindControl("lblStatus");
            Label lblRegDate = (Label)e.Row.FindControl("lblRDate");

            if (lblStatus != null)
            {
                if (lblStatus.Text == "1")
                {
                    lnkStatusChange.Text = "Deactivate";
                }
                else if (lblStatus.Text == "0")
                {
                    lnkStatusChange.Text = "Activate";
                }
            }
            if (lblRegDate != null)
            {
                if (lblRegDate.Text != "")
                {
                    string rdate = DateTime.Parse(lblRegDate.Text).ToString("MMM dd yyyy");
                    lblRegDate.Text = rdate;
                }
            }
        }
    }
    /// <summary>
    /// send activation code as mail to activate his account
    /// </summary>
    /// <param name="FName"></param>
    /// <param name="LName"></param>
    /// <param name="EmailId"></param>
    /// <param name="ActiveId"></param>
    /// <param name="Status"></param>
    /// <param name="Uid"></param>
    private void SendMailStatusConfirmation(string FName, string LName, string EmailId, string ActiveId,string Status,Int32 Uid)
    {
        try
        {
            string Msg = "";

            MailMessage mm = new MailMessage();
            //mm.From = new MailAddress("info@aceindus.in");
            mm.From = new MailAddress("info@justcalluz.com");
            mm.To.Add(EmailId);
            Msg += "Dear <b>" + FName + " " + LName + "</b>,";
            if (Status == "1")
            {               
                Msg+="<br><br>" +
                    "Thanks for your interest with Justcalluz.Your account has been activated sucessfully" +
                    //"<br><br> <b>Your Business Details: </b>"+
                    //"<br><br>"+
                    //"Contact Information: <br>"+

                    "<br><br>Warm Regards," +
                    "<br> Justcalluz Team";

                mm.Subject = "Your Registration confirmation with Justcalluz ";
            }
            else if(Status=="0")
            {
                Msg += "<br><br>Your account has been deactivated. To activate your account follow the instructions below. Confirming your request helps prevent unauthorized access to your account. If you didn't register to this service, please ignore and delete this email.<br>" +
                       "<br><br>1. Copy the following web address: " +
                       "<br><br>http://www.justcalluz.com/ActivateAccount.aspx?UserId=" + Uid + "&ActiveId=" + ActiveId + " " +
                       "<br><br>IMPORTANT: Because fraudulent (phishing) e-mail often uses misleading links, We recommends that you do not click links in e-mail, but instead copy and paste them into your browsers, as described above. " +
                       "<br><br>2. Open your web browser, paste the link in the address bar, and then press ENTER." +
                       "<br><br>If you have received this message in error, please report the incident to support@justcalluz.com " +
                       "<br><br>To login at a later date, please enter your username and the password that you entered during registration." +
                       "<br><br>Warm Regards," +
                       "<br> Justcalluz Team";

                mm.Subject = "Please activate your account";
            }
            mm.IsBodyHtml = true;
            mm.Body = Msg;
            SmtpClient smtp = new SmtpClient();
            smtp.Send(mm);

        }
        catch (Exception ex)
        {
            lblerror.Text = ex.Message;
        }
    }
    /// <summary>
    ///  calling send activation code as mail to activate his account
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void SendActiveId(object sender, CommandEventArgs e)
    {
        Int32 id = Convert.ToInt32(e.CommandArgument.ToString());
        con.Open();
        ds = reg.getWebsiteUserStatus(id);
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            status = Convert.ToInt32(ds.Tables[0].Rows[0]["iStatus"].ToString());
            Email = Convert.ToString(ds.Tables[0].Rows[0]["email"].ToString());
            UFName = Convert.ToString(ds.Tables[0].Rows[0]["name"].ToString());
            ULName = Convert.ToString(ds.Tables[0].Rows[0]["LastName"].ToString());
            AId = Convert.ToString(ds.Tables[0].Rows[0]["iActiveId"].ToString());
            SendMailActiveId(UFName, ULName, Email, AId,id);
            strScript = "alert('Mail has been sent sucessfully to "+Email+", to activate his/her account');location.replace('Admin_WesiteUsersInfo.aspx');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
        con.Close();
    }
    /// <summary>
    /// send mail
    /// </summary>
    /// <param name="FName"></param>
    /// <param name="LName"></param>
    /// <param name="EmailId"></param>
    /// <param name="ActiveId"></param>
    /// <param name="Uid"></param>
    private void SendMailActiveId(string FName, string LName, string EmailId, string ActiveId, Int32 Uid)
    {
        try
        {
            string Msg = "";

            MailMessage mm = new MailMessage();
            //mm.From = new MailAddress("info@aceindus.in");
            mm.From = new MailAddress("info@justcalluz.com");
            mm.To.Add(EmailId);
            Msg += "Dear <b>" + FName + " " + LName + "</b>,";            
            Msg += "<br><br>Thank you for registering with juscalluz.com. To activate your account follow the instructions below. Confirming your request helps prevent unauthorized access to your account. If you didn't register to this service, please ignore and delete this email.<br>" +
                       "<br><br>1. Copy the following web address: " +
                       "<br><br>http://www.justcalluz.com/ActivateAccount.aspx?UserId=" + Uid + "&ActiveId=" + ActiveId + " " +
                       "<br><br>IMPORTANT: Because fraudulent (phishing) e-mail often uses misleading links, We recommends that you do not click links in e-mail, but instead copy and paste them into your browsers, as described above. " +
                       "<br><br>2. Open your web browser, paste the link in the address bar, and then press ENTER." +
                       "<br><br>If you have received this message in error, please report the incident to support@justcalluz.com " +
                       "<br><br>To login at a later date, please enter your username and the password that you entered during registration." +
                       "<br><br>Warm Regards," +
                       "<br> Justcalluz Team";

            mm.Subject = "Please activate your account to use Justcalluz services";            
            mm.IsBodyHtml = true;
            mm.Body = Msg;
            SmtpClient smtp = new SmtpClient();
            smtp.Send(mm);

        }
        catch (Exception ex)
        {
            lblerror.Text = ex.Message;
        }
    }
    protected void lnkBack_Click(object sender, EventArgs e)
    {
        if (Session["LoginId"] != null)
        {
            designation = Convert.ToString(Session["Designation"]);
            if (designation == "Admin")
            {
                Response.Redirect("Admin-MainPage.aspx");
            }
            else
            {
                Response.Redirect("Admin_Home.aspx");
            }
        }
    }

}
