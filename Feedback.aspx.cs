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
using System.Net.Mail;
using System.Web.Routing;

public partial class Feedback : System.Web.UI.Page
{
    string strScript = "";
    InsertData obj = new InsertData();
    static string excep_page = "Feedback.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    /// <summary>
    /// To Post Feedback
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ImgBtnSubmit_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            ccJoin.ValidateCaptcha(txtvid.Text);
            //If you entered captcha wrong if statement will execute otherwise else statement execute
            if (!ccJoin.UserValidated)
            {
                strScript = "alert('Your have to enter as like in the image.');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                //Inform user that his input was wrong ...
                txtvid.Text = "";
                return;

            }
            else
            {
                //try
                //{
                    DataSet ds = new DataSet();
                    string fname = txtname.Text.ToString();
                    string mob = txtmob.Text.ToString();
                    string ph = txtph.Text.ToString();
                    string email = txtemail.Text.ToString();
                    string comm = txtcomm.Text.ToString();
                    //string vid = txtvid.Text.ToString();
                    ds = obj.insert_Feedbackform(fname, mob, ph, email, comm);
                    strScript = "alert('Your Feedback is posted successfully.');location.replace('Home');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                    SendMail(fname, mob, ph, email, comm);
                //}
                ////To catch exception
                //catch (Exception ex)
                //{
                //    obj.insert_exception(ex, excep_page);
                //    Response.Redirect("HttpErrorPage.aspx");
                //}
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }


    }
    /// <summary>
    /// To reset the fields
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ImgBtnReset_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            txtname.Text = "";
            txtmob.Text = "";
            txtph.Text = "";
            txtemail.Text = "";
            txtcomm.Text = "";
            txtvid.Text = "";
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    /// To send mail 
    /// </summary>
    /// <param name="fname"></param>
    /// <param name="mob"></param>
    /// <param name="ph"></param>
    /// <param name="email"></param>
    /// <param name="comm"></param>
    private void SendMail(string fname, string mob, string ph, string email, string comm)
    {
        string Msg = "";
        try
        {
               MailMessage mm = new MailMessage();
                mm.From = new MailAddress("info1@aceindus.in", email);
                mm.To.Add("portals1234@gmail.com");
                //mm.To.Add("rlaxmi2003@gmail.com");
                Msg += "My Name : '" + fname + "'" +

                           "<br>My mail ID :'" + email + "'" +
                    //"<br>My Address:'" + Address + "'" +
                            "<br>MY Mobile :'" + mob + "'" +
                           "<br>My Phone :'" + ph + "'" +
                    //"<br>My State :'" + State + "'" +
                    // "<br>My Country :'" + Country + "'" +
                    //  "<br>Zip : '" + Zip + "'" +
                    //   "<br>Course Attended : '" + course + "'" +
                                "<br>Comments : '" + comm + "'";


                mm.Subject = "Subject : FeedBack Information ";
                mm.IsBodyHtml = true;
                mm.Body = Msg;
                SmtpClient SmtpMail = new SmtpClient();
                SmtpMail.Send(mm);
               // Response.Redirect("feedback.aspx?ret=ok");
           
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }


    }
    protected void btnRefresh_Click(object sender, EventArgs e)
    {
        try
        {
            UpdatePanel1.Update();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
}
