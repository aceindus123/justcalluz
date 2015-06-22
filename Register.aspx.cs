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
using System.Net.Mail;
using System.Net;
using System.Net.Mime;
using System.Data.SqlClient;
using IndusAbroad.safeConvert;
using CallUsRegistration.Registration;
using JustCallUsData.Data;
using System.Web.Routing;

public partial class Register : System.Web.UI.Page
{
    bool Regis = false;
    string strScript = "";
    InsertData obj = new InsertData();
    static string excep_page = "Register.aspx";
    //To make connection
    SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    //Creation of object for insert data class
    /// <summary>
    /// Executes whenever page loads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    
    protected void Page_Load(object sender, EventArgs e)
    {
        txtpwd.Attributes.Add("value", txtpwd.Text);
        txtrpwd.Attributes.Add("value", txtrpwd.Text);
        try
        {
            radbtnBusiness.CheckedChanged += new EventHandler(radbtnBusiness_CheckedChanged);
            // Execute the code without postbacking the page values
            if (!Page.IsPostBack)
            {
                // creation of object for registration class
                RegistrationCS reg = new RegistrationCS();
                DataCS data = new DataCS();
                //To bind States
                reg.FillStates(ddlState);
                data.FillCategory(ddlCategory);
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    /// To fill the cities for the corresponding States
    /// </summary>
    /// <param name="StateName"></param>
    public void fillCities(string StateName)
    {
        try
        {
            //string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            //SqlConnection oCon = new SqlConnection(Connection);
            //string s = "select city_Id,city_name from Cities where state_name= '" + StateName + "'";
            SqlDataAdapter da = new SqlDataAdapter("select city_Id,city_name from Cities where state_name= '" + StateName + "'", connection);
            DataSet ds = new DataSet();
            da.Fill(ds, "Cities");
            ddlCity.DataSource = ds.Tables["Cities"];
            ddlCity.DataValueField = "city_name";
            ddlCity.DataTextField = "city_name";
            ddlCity.DataBind();
            ddlCity.Items.Insert(0, "Select City");
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        //catch (Exception ex)
        //{
        //    lblMessage.Text = ex.Message.ToString();
        //}
    }
    /// <summary>
    /// To register into just call uz
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ImgBtnSubmit_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            if (Page.IsValid == false)
                return;

            if (ChkBoxAccept.Checked == false)
            {
                try
                {
                    strScript = "alert('Please accept the Terms & Conditions.');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
            else
            {
                if (IsValid)
                {
                    string username = "";
                    string userLname = "";
                    string usermob = "";
                    string userpassword = "";
                    string userrpwd = "";
                    string useremail = "";
                    string usercity = "";
                    string userbname = "";
                    string userkindofbusiness = "";
                    string userwebsite = "";
                    string userdes = "";
                    string useraddr = "";
                    string userlandmark = "";
                    string userstate = "";
                    string userpincode = "";
                    string userlandline = "";
                    string userfax = "";
                    string regtype = "";
                    username = Convert.ToString(txtuname.Text);
                    userLname = Convert.ToString(txtLatName.Text);
                    usermob = Convert.ToString(txtmob.Text);
                    userpassword = Convert.ToString(txtpwd.Text);
                    userrpwd = Convert.ToString(txtrpwd.Text);
                    useremail = Convert.ToString(txtemail.Text);
                    usercity = Convert.ToString(ddlCity.SelectedValue);
                    userbname = Convert.ToString(txtbusiname.Text);
                    userkindofbusiness = Convert.ToString(ddlCategory.SelectedValue);
                    userwebsite = Convert.ToString(txtweb.Text);
                    userdes = Convert.ToString(txtdesc.Text);
                    useraddr = Convert.ToString(txtaddr.Text);
                    userlandmark = Convert.ToString(txtlanm.Text);
                    userstate = Convert.ToString(ddlState.SelectedValue);
                    userpincode = Convert.ToString(txtPincode.Text);
                    userlandline = Convert.ToString(txtlandline.Text);
                    userfax = Convert.ToString(txtfax.Text);
                    try
                    {
                        if (radbtnBusiness.Checked == true)
                        {
                            regtype = "Business";
                        }
                        else if (radbtnIndividual.Checked == true)
                        {
                            regtype = "Individual";
                        }
                    }
                    catch (Exception ex)
                    {
                        obj.insert_exception(ex, excep_page);
                        Response.Redirect("HttpErrorPage.aspx");
                    }

                    DateTime theDate = DateTime.Now;
                    string format = "d MMM yyyy";
                    string custom = theDate.ToString(format);

                    RegistrationCS reg = new RegistrationCS();
                    Int32 i = Convert.ToInt32(reg.CheckEmailid(useremail));
                    Int32 j = Convert.ToInt32(reg.CheckMobileNumber(usermob));
                              
                    if (i != 0 && j != 0)
                    {
                        strScript = "alert('The given Mobile No. " + usermob + " and Email Id: " + useremail + " Already Exists, \\n Please enter another Mobile Number and Email Id');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                        txtemail.Text = "";
                        txtmob.Text = "";
                    }
                    else if (i != 0)
                    {
                        strScript = "alert('The given " + useremail + " Already Exists,\\n Please enter another Email Id');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                        txtemail.Text = "";
                    }
                    else if (j != 0)
                    {
                        strScript = "alert('The given " + usermob + " Already Exists,\\n Please enter another Mobile Number');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                        txtmob.Text = "";
                    }

                    else if (i == 0 && j == 0)
                    {
                        reg.rUserName = username;
                        reg.rLastName = userLname;
                        reg.rMobile = usermob;
                        reg.rPassword = userpassword;
                        reg.rEmailId = useremail;
                        reg.rCity = usercity;
                        reg.rBusinessName = userbname;
                        reg.rKindofBusiness = userkindofbusiness;
                        reg.rWebSite = userwebsite;
                        reg.rDescription = userdes;
                        reg.rAddress = useraddr;
                        reg.rLandMark = userlandmark;
                        reg.rState = userstate;
                        reg.rPinCode = userpincode;
                        reg.rLandLine = userlandline;
                        reg.rFax = userfax;
                        reg.regDate = DateTime.Now.Date;
                        reg.expDate = (reg.regDate.AddDays(Convert.ToDouble(30)));
                        reg.rRegType = regtype;
                        Regis = reg.Insert(reg.rUserName, reg.rLastName, reg.rMobile, reg.rPassword, reg.rEmailId, reg.rCity, reg.rAddress, reg.rLandMark,
                            reg.rState, reg.rPinCode, reg.rLandLine, reg.rFax, reg.rBusinessName, reg.rKindofBusiness, reg.rWebSite,
                            reg.rDescription, reg.regDate, reg.expDate, reg.rRegType);

                        if (Regis.Equals(true))
                        {
                            DataSet dsUserDetails = new DataSet();
                            RegistrationCS oReguser = new RegistrationCS();
                            Int32 UserID = 0;
                            string ActiveId = string.Empty;
                            string UName = string.Empty;
                            string LName = string.Empty;
                            dsUserDetails = oReguser.getNewUserDetails(reg.rEmailId, reg.rPassword);
                            try
                            {
                                if (!dsUserDetails.Tables["UserDetails"].Rows.Count.Equals(0))
                                {
                                    UserID = SafeConvert.ToInt32(dsUserDetails.Tables[0].Rows[0]["id"].ToString());
                                    UName = dsUserDetails.Tables[0].Rows[0]["name"].ToString();
                                    LName = dsUserDetails.Tables[0].Rows[0]["LastName"].ToString();

                                    ActiveId = SafeConvert.ToString(dsUserDetails.Tables[0].Rows[0]["iActiveId"]);

                                    //            /****************************************************/                    

                                }
                                Random rd = new Random();
                                lblsms.Text = Convert.ToString(rd.Next(10000));
                                SMSCAPI objSms = new SMSCAPI();
                                objSms.SendSMS("montessori", "Gani1525", usermob, "Your Justcalluz Verification Code is " + lblsms.Text + "");
                                SendMailToUser(UserID, ActiveId, userbname, userkindofbusiness, username, userLname, userpassword, useremail, usercity, userdes, userwebsite, useraddr, userlandmark, userstate, usermob, userlandline, userfax);
                                //strScript = "alert('Thanking you! You have been registered successfully.');location.replace('ThankYou.aspx?Msg=register');";
                                //Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                                Response.RedirectToRoute("Mobile_verification", new { MobVCode = lblsms.Text });
                                //Response.RedirectToRoute("ThankYou", new { Msg = "register" });
                                //redirect("ThankYou.aspx?Msg=register",false);
                                //SendMailToUser(UserID, ActiveId, userbname, userkindofbusiness, username, userLname, userpassword, useremail, usercity, userdes, userwebsite, useraddr, userlandmark, userstate, usermob, userlandline, userfax);
                                ////strScript = "alert('Thanking you! You have been registered successfully.');location.replace('ThankYou.aspx?Msg=register');";
                                ////Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                                //Response.RedirectToRoute("ThankYou", new { Msg = "register" });
                                ////redirect("ThankYou.aspx?Msg=register",false);
                               
                            }
                            catch (Exception ex)
                            {
                                obj.insert_exception(ex, excep_page);
                                Response.Redirect("HttpErrorPage.aspx");
                            }
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }

    /// <summary>
    /// To send mail to the registered user
    /// </summary>
    /// <param name="Uid"></param>
    /// <param name="AId"></param>
    /// <param name="bname"></param>
    /// <param name="kindofbusiness"></param>
    /// <param name="name"></param>
    /// <param name="password"></param>
    /// <param name="email"></param>
    /// <param name="city"></param>
    /// <param name="des"></param>
    /// <param name="website"></param>
    /// <param name="addr"></param>
    /// <param name="landmark"></param>
    /// <param name="state"></param>
    /// <param name="mob"></param>
    /// <param name="landline"></param>
    /// <param name="fax"></param>
    private void SendMail(Int32 Uid, string AId, string bname, string kindofbusiness, string name, string password, string email, string city, string des, string website, string addr, string landmark, string state, string mob, string landline, string fax)
    {
        string Msg = "";

        try
        {
            
            try
            {
                MailMessage mm = new MailMessage();
                //mm.From = new MailAddress("info@aceindus.in");
                mm.From = new MailAddress("info@justcalluz.com");
                mm.To.Add(email);
                //mm.To.Add("training@wizardsedu.com");
                //mm.To.Add("info@mnhbs.com");
                //mm.To.Add("infohyd@mnhbs.com");
                //mm.To.Add("accounts@mnhbs.com");
                if (bname != "")
                {
                    Msg += "My Business Name :'" + bname + "'" +
                                "<br>My Kind Of Business :'" + kindofbusiness + "'" +
                                "<br>My Name :'" + name + "'" +
                                "<br>My Password : '" + password + "'" +
                                "<br>Email :'" + email + "'" +
                                "<br>City: '" + city + "'" +
                                "<br>Description : '" + des + "'" +
                                "<br>Website:'" + website + "'" +
                                "<br>Address:'" + addr + "'" +
                                "<br>Landmark:'" + landmark + "'" +
                                "<br>State :'" + state + "'" +
                                "<br>Mobile:'" + mob + "'" +
                                "<br>Landline: '" + landline + "'" +
                                "<br>Fax: '" + fax + "'";
                }
                else
                {
                    Msg += "Name :'" + name + "'" +
                                "<br>Password : '" + password + "'" +
                                "<br>Email :'" + email + "'" +
                                "<br>City: '" + city + "'" +
                                "<br>Mobile:'" + mob + "'";

                }
                Msg += "<br>Thank you for Registering with Justcalluz.com.<br>" +
                       "<br>Please Click on the URL Specified below to finish the remaining Process<br> " + Page.GetRouteUrl("AcivateAccount", new { UserId = Uid, ActiveId = AId }) +
                       "<br>Please Activate Your Account";
                mm.Subject = "Register Form of Just Call Us ";//ActivateAccount.aspx?UserId=
                mm.IsBodyHtml = true;
                mm.Body = Msg;
                SmtpClient smtp = new SmtpClient();
                smtp.Send(mm);


            }
            catch (Exception ex1)
            {
                obj.insert_exception(ex1, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
            //catch (Exception ex)
            //{
            //    lblerror.Text = ex.Message;
            //}
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        //Response.Redirect("Register.aspx?ret=ok");


    }
    /// <summary>
    /// To send mail to user
    /// </summary>
    /// <param name="Uid"></param>
    /// <param name="AId"></param>
    /// <param name="bname"></param>
    /// <param name="kindofbusiness"></param>
    /// <param name="name"></param>
    /// <param name="uLname"></param>
    /// <param name="password"></param>
    /// <param name="email"></param>
    /// <param name="city"></param>
    /// <param name="des"></param>
    /// <param name="website"></param>
    /// <param name="addr"></param>
    /// <param name="landmark"></param>
    /// <param name="state"></param>
    /// <param name="mob"></param>
    /// <param name="landline"></param>
    /// <param name="fax"></param>
    private void SendMailToUser(Int32 Uid, string AId, string bname, string kindofbusiness, string name, string uLname, string password, string email, string city, string des, string website, string addr, string landmark, string state, string mob, string landline, string fax)
    {
        
        string Msg = "";
        try
        {
           

            try
            {
                string activateurl1 = Page.GetRouteUrl("ActivateAccount", new { UserId = Uid, ActiveId = AId });
                string siteurl = "http://www.justcalluz.com";
                string activateurl = siteurl + "/" + activateurl1;
                MailMessage mm = new MailMessage();
                mm.From = new MailAddress("info@justcalluz.com");
                mm.To.Add(email);

                Msg += "Dear " + name + " " + uLname + ",";

                Msg += "<br><br>You recently registered for Just Call us using this email address. To complete your registration and activate your account follow the instructions below. Confirming your request helps prevent unauthorized access to your account. If you didn't register to this service, please ignore and delete this email.<br>" +
                       "<br><br>1. Copy the following web address: " +
                       "<br><br>" + activateurl +
                       "<br><br>IMPORTANT: Because fraudulent (phishing) e-mail often uses misleading links, We recommends that you do not click links in e-mail, but instead copy and paste them into your browsers, as described above. " +
                       "<br><br>2. Open your web browser, paste the link in the address bar, and then press ENTER." +
                       "<br><br>If you have received this message in error, please report the incident to support@justcalluz.com " +
                       "<br><br>To login at a later date, please enter your username and the password that you entered during registration." +
                       "<br><br>Warm Regards," +
                       "<br> Just Call Uz Team";

                mm.Subject = "Just Call Uz Create Account";
                mm.IsBodyHtml = true;
                mm.Body = Msg;
                SmtpClient smtp = new SmtpClient();
                smtp.Send(mm);


            }
            catch (Exception ex1)
            {
                obj.insert_exception(ex1, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    /// To reset the register form values
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ImgBtnReset_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            txtuname.Text = "";
            txtLatName.Text = "";
            ddlCategory.SelectedIndex = 0;
            txtmob.Text = "";
            txtpwd.Text = "";
            txtrpwd.Text = "";
            txtemail.Text = "";
            ddlCity.Text = "Select City";
            txtbusiname.Text = "";
            txtweb.Text = "";
            txtaddr.Text = "";
            txtlanm.Text = "";
            ddlState.Text = "Select State";
            txtlandline.Text = "";
            txtPincode.Text = "";
            txtfax.Text = "";
            txtdesc.Text = "";
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    /// <summary>
    /// function when business check is changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void radbtnBusiness_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            //pnlindividual.Visible = !radbtnIndividual.Checked;
            //pnlbusiness.Visible = radbtnIndividual.Checked;
            trname.Visible = true;
            trLname.Visible = true;
            trmob.Visible = true;
            trpwd.Visible = true;
            trrpwd.Visible = true;
            tremail.Visible = true;
            trcity.Visible = true;
            //trrefimage.Visible = true;
            trbname.Visible = true;
            trkindofbusiness.Visible = true;
            trwebsite.Visible = true;
            traddress.Visible = true;
            trlandmark.Visible = true;
            trstate.Visible = true;
            trlandline.Visible = true;
            trfax.Visible = true;
            trdes.Visible = true;
            trpincode.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    /// <summary>
    /// function when individual check is changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void radbtnIndividual_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            //pnlbusiness.Visible = !radbtnBusiness.Checked;
            //pnlindividual.Visible = radbtnBusiness.Checked;
            trname.Visible = true;
            trLname.Visible = true;
            trmob.Visible = true;
            trpwd.Visible = true;
            trrpwd.Visible = true;
            tremail.Visible = true;
            trcity.Visible = true;
            //trrefimage.Visible = true;
            trbname.Visible = false;
            trkindofbusiness.Visible = false;
            trwebsite.Visible = false;
            traddress.Visible = false;
            trlandmark.Visible = false;
            trstate.Visible = true;
            trlandline.Visible = false;
            trfax.Visible = false;
            trdes.Visible = false;
            trpincode.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    /// Executes whenever sub category drown down selection changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddlState.SelectedIndex != 0)
            {
                string State_Name = Convert.ToString(ddlState.SelectedValue);
                fillCities(State_Name);
            }
            else
            {
                ddlCity.Items.Clear();
                ddlCity.Items.Insert(0, "Select City");
            }
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
