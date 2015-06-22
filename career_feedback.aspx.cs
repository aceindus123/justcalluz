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
using CallUsCareers.career;
using IndusAbroad.safeConvert;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Web.Routing;

public partial class career_feedback : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    SqlDataAdapter da;
    DataSet ds = new DataSet();
    CareersCS cacs = new CareersCS();
    InsertData obj = new InsertData();
    int id;
    static string excep_page = "career_feedback.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fillStates();
        }

    }
    public void fillStates()
    {
        try
        {
            ds = cacs.GetStates();
            ddlState.DataSource = ds;
            ddlState.DataTextField = "state_name";
            ddlState.DataValueField = "state_name";
            ddlState.DataBind();
            ddlState.Items.Insert(0, "select state");
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            string statename = ddlState.SelectedItem.ToString();
            DataSet ds1 = new DataSet();
            ds1 = cacs.GetCities(statename);
            ddlCity.DataSource = ds1;
            ddlCity.DataValueField = "city_name";
            ddlCity.DataTextField = "city_name";
            ddlCity.DataBind();
            ddlCity.Items.Insert(0, "select city");
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void btnSubmit_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            CareersCS mycs = new CareersCS();
            mycs.name = SafeConvert.ToString(txtName.Text.Trim());
            mycs.emailaddress = SafeConvert.ToString(txtEmailAddress.Text.Trim());
            mycs.mobile_num = SafeConvert.ToString(txtMobileNo.Text.Trim());
            mycs.state = SafeConvert.ToString(ddlState.SelectedValue);
            mycs.city = SafeConvert.ToString(ddlCity.SelectedValue);
            mycs.feedback = SafeConvert.ToString(txtfeedback.Text.Trim());
            mycs.cPostDate = SafeConvert.ToDateTime(System.DateTime.Now);
            CareersCS myccs = new CareersCS();
            bool result = myccs.submitfeedback(mycs.name, mycs.emailaddress, mycs.mobile_num,
                              mycs.state, mycs.city, mycs.feedback, mycs.cPostDate);

            string name1 = string.Empty;
            string emailid = string.Empty;
            string mobileNo = string.Empty;
            string FeedBack = string.Empty;

            name1 = txtName.Text;
            emailid = txtEmailAddress.Text;
            mobileNo = txtMobileNo.Text;
            FeedBack = txtfeedback.Text;

            if (result == true)
            {
                 SendMail(name1, emailid, mobileNo, FeedBack);
                 string strscript = "";
                 strscript = "alert(' Your Feedback is submited successfully');location.replace('CareersFeedback');";//location.replace('CareersFeedback " + name1 +" ');
                 Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strscript, true);
               
            }
            else
            {
                string str = "";
                str = "alert('Your details are not inserted');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", str, true);
            }
            //string strmsg = "alert('Your details are submited successfully');";
            //Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strmsg, true);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    private void SendMail(string name1,string emailid,string mobileNo,string FeedBack)
    {
        string mesg = "";
        try
        {

            MailMessage mm = new MailMessage();
            mm.From = new MailAddress("test_indus@yahoo.com");
            //Set the sender address of the mail message
            mm.To.Add(emailid);
            // Set the cc address of the mail message
            mesg += "Dear " + name1 + ",<br>" +
                    "<br>Thank you for Registering with test_indus<br>" +
                    "message: " + FeedBack + "<br /><br />" + "phone: " + mobileNo + "<br /><br />";
            //Set the subject of the mail message
            mm.Subject = "Your Message IS sent Successfully";
            //Set the format of the mail message body as HTML
            mm.IsBodyHtml = true;
            //Set the body of the mail message
            mm.Body = mesg;
            //Instantiate a new instance of SmtpClient
            SmtpClient smtp = new SmtpClient();
            //Send the mail message
            smtp.Send(mm);
            lblStatus.Text = "your email is sent successfully";
            
             

        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        //catch (Exception ex)
        //{
        //    lblStatus.Text = "send email failed" + ex.Message;
 
        //}

    }
    [System.Web.Script.Services.ScriptMethod()]
    [System.Web.Services.WebMethod]
    public static List<string> Getcities(string prefixText)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from cities where city_name like @Name+'%'", con);
        cmd.Parameters.AddWithValue("@Name", prefixText);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        List<string> citynames = new List<string>();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            citynames.Add(dt.Rows[i][1].ToString());
        }
        return citynames;
    }
    
    
}
