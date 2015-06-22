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
using System.Net.Mail;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Web.Routing;

public partial class jobdetails : System.Web.UI.Page
{
    SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    InsertData obj = new InsertData();
    static string sid = string.Empty;
    int id;
    string Mobilemsg = "";
    string Mobilefrndmsg = "";
    string MobileReportmsg = "";
    Binddata obj1 = new Binddata();
    static string excep_page = "jobdetails.aspx";
   /// <summary>
   /// To bind the particular details of job and display the posted reviews
   /// </summary>
   /// <param name="sender"></param>
   /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                Session["searchpg"] = "jobs";
                dlcenter.Visible = true;

                if (Convert.ToString(Page.RouteData.Values["pageid"]) != null)
                {
                    DataSet ds = jobdetail();
                    if (!ds.Tables[2].Rows.Count.Equals(0))
                    {
                        Session["companyname"] = ds.Tables[2].Rows[0]["company_name"].ToString();
                    }
                    lbljobdesc.Text = Convert.ToString(Session["companyname"]);
                    dlcenter.DataSource = ds.Tables[2];
                    dlcenter.DataBind();
                    pnlmap.Visible = true;
                    dlmap.Visible = true;
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        dlmap.DataSource = ds.Tables[1];
                        dlmap.DataBind();

                    }
                    else
                    {
                        lblnorecords.Visible = true;
                        dlmap.Visible = false;
                    }

                }
                else
                {
                    DataSet ds = jobdetail();
                    if (!ds.Tables[0].Rows.Count.Equals(0))
                    {
                        Session["companyname"] = ds.Tables[0].Rows[0]["company_name"].ToString();
                    }
                    lbljobdesc.Text = Convert.ToString(Session["companyname"]);
                    dlcenter.DataSource = ds.Tables[0];
                    dlcenter.DataBind();
                    pnlmap.Visible = true;
                    dlmap.Visible = true;
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        dlmap.DataSource = ds.Tables[1];
                        dlmap.DataBind();
                    }
                    else
                    {
                        lblnorecords.Visible = true;
                        dlmap.Visible = false;

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
    /// To display company name in a label and rating images
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public DataSet jobdetail()
    {
        DataSet ds6 = new DataSet();
        try
        {
           // sid = Convert.ToString(Page.RouteData.Values["id"]);
            //if (sid == "")
            //    sid = Convert.ToString(Page.RouteData.Values["cname"]);
            if (Convert.ToInt32(Page.RouteData.Values["id"]) != 0)
            {
                id = Convert.ToInt32(Page.RouteData.Values["id"]);
                SqlCommand cmd = new SqlCommand("viewjob", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds6);
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        return ds6;
        
    }
   
    protected void btnXSendSMS_Click(object sender, EventArgs e)
    {
        mailpanel.Visible = false;
    }

    // sending mail

    public void SendMail(string name, string email, string cname, string exp, string desc, string loc, string mob, string no)
    {
       
          string Msg = "";

          try
          {
              MailMessage mm = new MailMessage();
              mm.From = new MailAddress("info@justcalluz.com");
              //mm.To = "test_indus@yahoo.com";
              mm.To.Add(email);
              Msg += "Dear <b>" + name + "</b> ," +
                          "<br>Please find the below information you have requested:<br>" +
                          "<br>Whenever you call , please mention that you got this info from Justcalluz.com" +
                          "<br><table width=100%>" +
                          "<tr><td align=left>Company Name</td><td>:</td><td>" + cname + "</td></tr>" +
                          "<tr><td align=left>Job Description</td><td>:</td><td>" + desc + "</td></tr>" +
                          "<tr><td align=left>Experience</td><td>:</td><td>" + exp + "</td></tr>" +
                          "<tr><td align=left>Location</td><td>:</td><td>" + loc + "</td></tr>" +
                          "<tr><td align=left>Phone</td><td>:</td><td>" + mob + "</td></tr>" +
                          "</table>" +
                          "br>We hope the above information is in line with your request." +
                          "<br>For further details please follow the link <a href=http://www.justcalluz.com/Job-" + no + "-"+Convert.ToString(Session["searchpg"])+">www.justcalluz.com</a> or call on +9166136226." +
                          "<br><br>Warm Regards," +
                          "<br> Team JustCalluz";
              mm.Subject = " Job Vacency ";
              mm.IsBodyHtml = true;
              mm.Body = Msg;
              SmtpClient smtp = new SmtpClient();
              smtp.Send(mm);
          }
          catch (Exception ex)
          {
              obj.insert_exception(ex, excep_page);
              Response.Redirect("HttpErrorPage.aspx");
          }
        //Response.Redirect("Register.aspx?ret=ok");
    }
    // sending mail
    public void SendMail1(string name, string fname, string email)
    {
          string Msg = "";

          try
          {
              MailMessage mm = new MailMessage();
              mm.From = new MailAddress("info@justcalluz.com");
              //mm.To = "test_indus@yahoo.com";
              mm.To.Add(email);
              Msg += "Dear <b>" + fname + "</b> ," +

                          "<br>Your Friend " + name + "</b>," +
                          "<br> Suggested you to get through the site Justcalluz.com or dial 99166136226." +
                          "<br>To get an information regarding jobs,Real estates,discounts,events,Restaurents,Movies etc.," +
                          "<br>what not ? all within seconds" +

                          "<br><br> JustCalluz is a fastest growing local search engine, operating from Hyderabad, India.A JustCalluz visitor can get the desired business information instantly by selecting a location name from the given options and enter the search keyword in the search option." +
                          "<br><br>JustCalluz works 24/7 to find innovative ways and make local search much easier & simpler, we welcome people with creative ideas and zeal to learn & develop." +


                          "<br><br>Warm Regards," +
                          "<br> Team JustCalluz";
              mm.Subject = "suggestion of your friend";
              mm.IsBodyHtml = true;
              mm.Body = Msg;
              SmtpClient smtp = new SmtpClient();
              smtp.Send(mm);
          }
          catch (Exception ex)
          {
              obj.insert_exception(ex, excep_page);
              Response.Redirect("HttpErrorPage.aspx");
          }
    }
    public void SendMail2(string name, string fname, string email)
    {
          string Msg = "";

          try
          {
              MailMessage mm = new MailMessage();
              mm.From = new MailAddress("info@justcalluz.com");
              //mm.To = "test_indus@yahoo.com";
              mm.To.Add(email);
              Msg += "Dear <b>" + fname + "</b> ," +

                          "<br>Your Friend " + name + "</b>," +
                          "<br> Suggested you to get through the site Justcalluz.com or dial 99166136226." +
                          "<br>To get an information regarding jobs,Real estates,discounts,events,Restaurents,Movies etc.," +
                          "<br>what not ? all within seconds" +

                          "<br><br> JustCalluz is a fastest growing local search engine, operating from Hyderabad, India.A JustCalluz visitor can get the desired business information instantly by selecting a location name from the given options and enter the search keyword in the search option." +
                          "<br><br>JustCalluz works 24/7 to find innovative ways and make local search much easier & simpler, we welcome people with creative ideas and zeal to learn & develop." +


                          "<br><br>Warm Regards," +
                          "<br> Team JustCalluz";
              mm.Subject = "suggestion of your friend";
              mm.IsBodyHtml = true;
              mm.Body = Msg;
              SmtpClient smtp = new SmtpClient();
              smtp.Send(mm);
          }
          catch (Exception ex)
          {
              obj.insert_exception(ex, excep_page);
              Response.Redirect("HttpErrorPage.aspx");
          }
    }
    protected void dlData_ItemDataBound(object sender, DataListItemEventArgs e)
    {
       
       
        HtmlTableRow trWebsite = (HtmlTableRow)e.Item.FindControl("trWebSite");
        if (trWebsite != null)
        {
            if (Convert.ToString(Session["WebSite"]) != "")
            {
                trWebsite.Visible = true;
            }
            else
            {
                trWebsite.Visible = false;
            }
        }
        HtmlTableRow trFax = (HtmlTableRow)e.Item.FindControl("trFax");
        if (trFax != null)
        {
            if (Convert.ToString(Session["Fax"]) != "")
            {
                trFax.Visible = true;
            }
            else
            {
                trFax.Visible = false;
            }
        }
        HtmlTableRow trComProf = (HtmlTableRow)e.Item.FindControl("trComprofile");
        if (trComProf != null)
        {
            if (Convert.ToString(Session["Company_Profile"]) != "")
            {
                trComProf.Visible = true;
            }
            else
            {
                trComProf.Visible = false;
            }
        }
        Label lblfax = (Label)e.Item.FindControl("lblfax");
        if (lblfax != null)
        {
            if (lblfax.Text != "")
            {
                lblfax.Text = lblfax.Text;
            }
            else
            {
                lblfax.Text = "Not Mentioned";
            }
        }
       
        Label lbllastdate = (Label)e.Item.FindControl("lbllastdate");
        if (lbllastdate != null)
        {
            if (lbllastdate.Text != "")
            {
                lbllastdate.Text = lbllastdate.Text;
            }
            else
            {
                lbllastdate.Text = "ASAP";
            }
        }
       
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
    protected void imgAbuseGo_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            string strscript = string.Empty;
            string ipaddress = getipaddress();
            //string physicaladdress = get_physicaladdress();
            DateTime pdate = DateTime.Now;
            //int id = Convert.ToInt32(Session["sid"]);
            int id = Convert.ToInt32(Page.RouteData.Values["id"]);
            SqlCommand cmd = new SqlCommand("insert into Report(Name,Contact_No,Email_Id,Comment,dataid,report_type,postdate,IP_Address) values(@Name,@Contact_No,@Email_Id,@Comment,@dataid,@report_type,@postdate,@IP_Address)", sqlConnection);
            cmd.Parameters.AddWithValue("Name", txtname.Text);
            cmd.Parameters.AddWithValue("Contact_No", txtcntno.Text);
            cmd.Parameters.AddWithValue("Email_Id", txtmail.Text);
            cmd.Parameters.AddWithValue("Comment", txtcmnt.Text);
            cmd.Parameters.AddWithValue("dataid", SqlDbType.Int).Value = id;
            cmd.Parameters.AddWithValue("report_type", SqlDbType.NVarChar).Value = "abuse";
            cmd.Parameters.AddWithValue("postdate", pdate);
            cmd.Parameters.AddWithValue("IP_Address", ipaddress);
            //cmd.Parameters.AddWithValue("PhysicalAddress", physicaladdress);
            try
            {
                sqlConnection.Open();
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
                sqlConnection.Close();
            }
            strscript = "alert('Thank You.......!');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strscript, true);
            txtname.Text = "";
            txtcntno.Text = "";
            txtmail.Text = "";
            txtcmnt.Text = "";
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected string getipaddress()
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
    //protected string get_physicaladdress()
    //{
    //    NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
    //    string phyadd = string.Empty;
    //    foreach (NetworkInterface adapter in nics)
    //    {
    //        if (phyadd == string.Empty)
    //        {
    //            IPInterfaceProperties properties = adapter.GetIPProperties();
    //            phyadd = adapter.GetPhysicalAddress().ToString();
    //        }
    //    }
    //    return phyadd;
    //}
    protected void imggo_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            string name = txtyourname.Text;
            string fname = txtfname.Text;
            string email = txtfemail.Text;

            SMSCAPI objSms = new SMSCAPI();
            Mobilefrndmsg += "Dear" + fname + "," +

                          "Your Friend " + name + "," +
                          "Suggested you to get through the site Justcalluz.com or dial 99166136226." +
                          "To get an information regarding jobs,Real estates,discounts,events,Restaurents,Movies etc.," +
                          "what not ? all within seconds." +

                          "JustCalluz is a fastest growing local search engine.A JustCalluz visitor can get the desired business information instantly by selecting a location name from the given options and enter the search keyword in the search option." +
                          "JustCalluz works 24/7 to find innovative ways and make local search much easier & simpler, we welcome people with creative ideas and zeal to learn & develop." +


                          "Warm Regards," +
                          "Team JustCalluz";
            objSms.SendSMS(Convert.ToString(ConfigurationManager.AppSettings["SmsUsername"]), Convert.ToString(ConfigurationManager.AppSettings["SmsPassword"]), txtmob.Text, Mobilefrndmsg);
            SendMail2(name, fname, email);
            string strScript = string.Empty;
            strScript = "alert('Thank you! You have successfully shared with your friend.');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            txtyourname.Text = "";
            txtfname.Text = "";
            txtfemail.Text = "";
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void imggo1_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            sid = Convert.ToString(Page.RouteData.Values["id"]);

            string name = txtname1.Text;
            string email = txtEmail.Text;
            string mobile = txtmobile.Text;
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("viewjob", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", sid);
            SqlDataReader dr = cmd.ExecuteReader();
            string cname = string.Empty; ;
            string exp = string.Empty;
            string desc = string.Empty;
            string loc = string.Empty;
            string mob = string.Empty;
            string no = string.Empty;
            while (dr.Read())
            {
                cname = Convert.ToString(dr["company_name"]);
                exp = Convert.ToString(dr["job_exp"]);
                desc = Convert.ToString(dr["job_desc"]);
                loc = Convert.ToString(dr["city"]);
                mob = Convert.ToString(dr["mob"]);
                no = Convert.ToString(dr["id"]);

                SMSCAPI objSms = new SMSCAPI();
                Mobilemsg += "Dear " + name + "," +
                        "Please find the below information you have requested:" +
                        "Whenever you call , please mention that you got this info from Justcalluz.com." +
                        "Company Name:" + cname +"," +
                        "Job Description:" + desc + "," +
                        "Experience:" + exp + "," +
                        "Location:" + loc + "," +
                        "Phone:" + mob + "," +
                        "We hope the above information is in line with your request." +
                        "For further details please follow the link www.justcalluz.com or call on +9166136226." +
                        "Warm Regards," +
                        "Team JustCalluz";
                objSms.SendSMS(Convert.ToString(ConfigurationManager.AppSettings["SmsUsername"]), Convert.ToString(ConfigurationManager.AppSettings["SmsPassword"]), txtmobile.Text, Mobilemsg);
                SendMail(name, email, cname, exp, desc, loc, mob, no);
                string strScript = string.Empty;
                strScript = "alert('Thank you! You have successfully sent the details.');location.replace('Jobs-jobs');";//('jobs.aspx?cname=jobs');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);

            }
            dr.Close();
            string str = "Insert into sendmail(name,email,ph,companyname,adid) values('" + name + "','" + email + "','" + mobile + "','" + cname + "','" + sid + "')";
            SqlCommand cmdmail = new SqlCommand(str, sqlConnection);
            cmdmail.ExecuteNonQuery();
            txtname1.Text = "";
            txtEmail.Text = "";

        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        finally
        {
            sqlConnection.Close();
        }
    }
    protected void imgapply_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            DataSet ds_career = new DataSet();
            sid = Convert.ToString(Page.RouteData.Values["id"]);
            SqlCommand cmdcareer = new SqlCommand("viewjob", sqlConnection);
            cmdcareer.CommandType = CommandType.StoredProcedure;
            cmdcareer.Parameters.AddWithValue("@id", sid);
            SqlDataAdapter dacereer = new SqlDataAdapter(cmdcareer);
            dacereer.Fill(ds_career);
            if (ds_career.Tables[3].Rows.Count > 0)
            {
                int id = Convert.ToInt32(ds_career.Tables[3].Rows[0]["careers_id"].ToString());
                //redirect("http://careersgen.net/new_careersgen/without_login_job_description.aspx?id=" + id, false);
                redirect("http://careersgen.com/without_login_job_description.aspx?id=" + id, false);
            }
            else
                ClientScript.RegisterStartupScript(typeof(Page), "message", "<script>alert('Process not done at this time. May be time expired.');</script>");
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
    



    

