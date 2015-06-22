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
using System.Net;
using System.Net.NetworkInformation;
using System.Web.Routing;

/// <summary>
/// Binding and displaying the detailed information about the selected event
/// </summary>
public partial class Event_details : System.Web.UI.Page
{
    bool events=false;
    InsertData obj = new InsertData();
    int id;
    Binddata obj1 = new Binddata();
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    string sid = string.Empty;
    string sid1 = string.Empty;
    DateTime current = DateTime.Now.Date;
    string city;
    string usermob;
    string Msg;
    static string excep_page = "eventdetails.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        
        friendpanel1.Visible = false;
        try
        {
            //Session["searchpg"] = "events";
            if (Page.RouteData.Values["city"] != null)
            {
                city = Convert.ToString(Page.RouteData.Values["city"]);
            }
            else if (Session["ciyonload"] != null)
            {
                city = Session["ciyonload"].ToString();
            }
            else
            {
                city = "Hyderabad";
            }
            lblmsg.Visible = false;
            pnlmap.Visible = false;
            //con.Open();
            ddlevents.Visible = false;

            string category = string.Empty;
            DataSet ds = new DataSet();
            sid = Convert.ToString(Page.RouteData.Values["id"]);
            SqlCommand cmd = new SqlCommand("events", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", SqlDbType.NVarChar).Value = sid;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                //if (ds.Tables[0].Rows[0]["event_enddate"].ToString() == "NULL")
                //{
                //    DataList1.Items[0].FindControl("enddate").Visible = false;
                //}
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }
            else
            {
                lblmsg.Visible = true;
            }
            SqlDataAdapter mapadapter = new SqlDataAdapter("select id,map,Approved_map from modulesdata where id='" + sid + "' and Approved_map=1", con);
            DataSet dsmap = new DataSet();
            mapadapter.Fill(dsmap);
            if (!dsmap.Tables[0].Rows.Count.Equals(0))
            {
                pnlmap.Visible = true;
                dlmap.Visible = true;
                dlmap.DataSource = dsmap;
                dlmap.DataBind();
            }
           // con.Close();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        
    }
    protected void cost_Click(object sender, EventArgs e)
    {
        //DataList1.FindControl("charge").Visible = true;
        //DataList1.FindControl("addr").Visible = false;
    }
    // sending mail

    public void SendMail(string name, string email, string cname, string place, string desc, string loc, string mob, string no)
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
                            "<tr><td align=left>Event Name</td><td>:</td><td>" + cname + "</td></tr>" +
                            "<tr><td align=left>Job Description</td><td>:</td><td>" + desc + "</td></tr>" +
                            "<tr><td align=left>Venue</td><td>:</td><td>" + place + "</td></tr>" +
                            "<tr><td align=left>Location</td><td>:</td><td>" + loc + "</td></tr>" +
                            "<tr><td align=left>Phone</td><td>:</td><td>" + mob + "</td></tr>" +
                            "</table>" +
                            "br>We hope the above information is in line with your request." +
                            "<br>For further details please follow the link <a href=http://www.justcalluz.com/EventDetails-" + no + ">www.justcalluz.com</a> or call on +9166136226." +
                            "<br><br>Warm Regards," +
                            "<br> Team JustCalluz";
                mm.Subject = "Event";
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
    protected void tombut_Click(object sender, EventArgs e)
    {
        try
        {
            friendpanel.Visible = false;
            mailpanel.Visible = false;
            DateTime tomorrow = DateTime.Now.AddDays(Convert.ToDouble(1));
            filter_event(tomorrow);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void weekbut_Click(object sender, EventArgs e)
    {
        try
        {
            friendpanel.Visible = false;
            mailpanel.Visible = false;
            DateTime i;
            string day = DateTime.Now.DayOfWeek.ToString();
            DateTime current = DateTime.Now.Date;

            if (day == "Monday")
            {
                DateTime date = DateTime.Now.AddDays(Convert.ToDouble(4));
                for (i = current; i < date; )
                {

                    i = i.AddDays(Convert.ToDouble(1));
                }
                filtered_events(i);
            }
            else if (day == "Tuesday")
            {
                DateTime date = DateTime.Now.AddDays(Convert.ToDouble(3));
                for (i = current; i < date; )
                {

                    i = i.AddDays(Convert.ToDouble(1));
                }
            }
            else if (day == "Wednesday")
            {
                DateTime date = DateTime.Now.AddDays(Convert.ToDouble(2));
                for (i = current; i < date; )
                {
                    filtered_events(i);
                    i = i.AddDays(Convert.ToDouble(1));
                }
                filtered_events(i);

            }
            else if (day == "Thursday")
            {
                DateTime date = DateTime.Now.AddDays(Convert.ToDouble(1));
                for (i = current; i < date; )
                {

                    i = i.AddDays(Convert.ToDouble(1));
                }
                filtered_events(i);
            }
            else if (day == "Friday")
            {
                DateTime date = DateTime.Now.AddDays(Convert.ToDouble(1));

                filtered_events(date);

            }
            else if (day == "Saturday")
            {
                filtered_events(current);
            }
            else
            {
                filter_event(current);

            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void nweekbut_Click(object sender, EventArgs e)
    {
        try
        {
            friendpanel.Visible = false;
            DateTime i;
            string day = DateTime.Now.DayOfWeek.ToString();
            string current = DateTime.Now.Date.ToShortDateString();
            if (day == "Monday")
            {
                string date = DateTime.Now.AddDays(Convert.ToDouble(12)).ToShortDateString();
                for (i = Convert.ToDateTime(current); i < Convert.ToDateTime(date); )
                {

                    i = i.AddDays(Convert.ToDouble(1));
                }
                filtered_events(i);
            }
            else if (day == "Tuesday")
            {
                string date = DateTime.Now.AddDays(Convert.ToDouble(11)).ToShortDateString();
                for (i = Convert.ToDateTime(current); i < Convert.ToDateTime(date); )
                {
                    i = i.AddDays(Convert.ToDouble(1));
                }
                filtered_events(i);
            }
            else if (day == "Wednesday")
            {
                string date = DateTime.Now.AddDays(Convert.ToDouble(10)).ToShortDateString();
                for (i = Convert.ToDateTime(current); i < Convert.ToDateTime(date); )
                {

                    i = i.AddDays(Convert.ToDouble(1));
                }
                filtered_events(i);

            }
            else if (day == "Thursday")
            {
                string date = DateTime.Now.AddDays(Convert.ToDouble(9)).ToShortDateString();
                for (i = Convert.ToDateTime(current); i < Convert.ToDateTime(date); )
                {

                    i = i.AddDays(Convert.ToDouble(1));
                }
                filtered_events(i);
            }
            else if (day == "Friday")
            {
                string date = DateTime.Now.AddDays(Convert.ToDouble(8)).ToShortDateString();
                for (i = Convert.ToDateTime(current); i < Convert.ToDateTime(date); )
                {

                    i = i.AddDays(Convert.ToDouble(1));
                }
                filtered_events(i);

            }
            else if (day == "Saturday")
            {
                string date = DateTime.Now.AddDays(Convert.ToDouble(7)).ToShortDateString();
                for (i = Convert.ToDateTime(current); i < Convert.ToDateTime(date); )
                {

                    i = i.AddDays(Convert.ToDouble(1));
                }

                filtered_events(i);
            }
            else
            {
                string date = DateTime.Now.AddDays(Convert.ToDouble(6)).ToShortDateString();
                for (i = Convert.ToDateTime(current); i < Convert.ToDateTime(date); )
                {

                    i = i.AddDays(Convert.ToDouble(1));
                }
                filtered_events(i);
                {
               
           
                 }
                    
                
            }
        }
        
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
                 
    }        
             
       public void filtered_events(DateTime date)
    {
        try
        {
            ddlevents.Visible = true;
            DataList1.Visible = false;
            pnlmap.Visible = false;
            DateTime date1 = date.AddDays(Convert.ToDouble(1));
            SqlCommand cmd = new SqlCommand("filtered_events", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@event_startdate", date.ToShortDateString());
            cmd.Parameters.AddWithValue("@event_enddate", date1.ToShortDateString());
            cmd.Parameters.AddWithValue("@city", city);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                lblmsg.Visible = false;
                ddlevents.DataSource = ds;
                ddlevents.DataBind();
            }
            else
            {
                lblmsg.Visible = true;
                lblmsg.Text = "No matching details , Try with some other date";
            }

        }

        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        
       }
    public void filter_event(DateTime current)
    {
        try
        {
            ddlevents.Visible = true;
            DataList1.Visible = false;
            pnlmap.Visible = false;
            string current1 = current.ToShortDateString();
            SqlCommand cmd = new SqlCommand("select * from modulesdata where module='Events' and city='" + city + "' and event_enddate>='" + current1 + "' or event_startdate='" + current1 + "' and ApprovedStatus=1", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "modulesdata");
            if (ds.Tables[0].Rows.Count > 0)
            {
                ddlevents.DataSource = ds;
                ddlevents.DataBind();
            }
            else
            {
                lblmsg.Visible = true;
                lblmsg.Text = "No matching details , Try with some other date";
            }
}
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }

    protected void todaybut_Click(object sender, EventArgs e)
    {
        try
        {
            friendpanel.Visible = false;
            mailpanel.Visible = false;
            DateTime current = DateTime.Now.Date;
            filter_event(current);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
}

    protected void go_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            friendpanel.Visible = false;
            mailpanel.Visible = false;
            ddlevents.Visible = true;
            pnlmap.Visible = false;
            DataList1.Visible = false;
            string from = txtfrom.Text;
            string to = txtto.Text;
            if (from != "")
            {
                if (to != "")
                {
                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter("select * from modulesdata where event_startdate='" + from + "'and event_enddate='" + to + "'or event_enddate='" + from + "'or event_startdate='" + to + "'and ApprovedStatus=1", con);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            ddlevents.DataSource = ds;
                            ddlevents.DataBind();
                        }
                        else
                        {
                            lblmsg.Visible = true;
                            lblmsg.Text = "No matching details , Try with some other date";
                        }

                    }
                    catch (Exception ex)
                    {
                        obj.insert_exception(ex, excep_page);
                        Response.Redirect("HttpErrorPage.aspx");
                    }
                }
                else
                {
                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter("select * from modulesdata where event_startdate='" + from + "' or event_enddate='" + from + "'and ApprovedStatus=1", con);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            ddlevents.DataSource = ds;
                            ddlevents.DataBind();
                        }
                        else
                        {
                            lblmsg.Visible = true;
                            lblmsg.Text = "No matching details , Try with some other date";
                        }
                    }
                    catch (Exception ex)
                    {
                        obj.insert_exception(ex, excep_page);
                        Response.Redirect("HttpErrorPage.aspx");
                    }
                }
            }
           
            else if (to != "")
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from modulesdata where event_startdate='" + to + "' or event_enddate='" + to + "'and ApprovedStatus=1", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        ddlevents.DataSource = ds;
                        ddlevents.DataBind();
                    }
                    else
                    {
                        lblmsg.Visible = true;
                        lblmsg.Text = "No matching details , Try with some other date";
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
            else
            {
                string strScript = string.Empty;
                strScript = "alert('Please select the date');location.replace('Events-events');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            }
            txtfrom.Text = "";
            txtto.Text = "";
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        //Label lbl = (Label)sender;
        //lbl =(e.Item.FindControl(Convert.ChangeType("enddate")));
        //Label char1 = (Label)e.Item.FindControl("charge");
        ////string enddate = Convert.ToString(Session["enddate"]);
        //if (lbl.ToString == "" || lbl.ToString == "null")
        //{
        //    lbl.Visible = false;
        //}
        
    }
    protected void imgeGo_Click(object sender, ImageClickEventArgs e)
    {
        string mobilesfrd = "";
        try
        {
            string name = txtSName1.Text;
            string fname = txtSFName1.Text;
            string email = txtSEmail1.Text;
            SendMail1(name, fname, email);
            string strScript = string.Empty;
            SMSCAPI objSms = new SMSCAPI();
            mobilesfrd = "Dear" + fname + " ," +

                            "Your Friend " + name + "," +
                            " Suggested you to get through the site Justcalluz.com or dial 99166136226." +
                            "To get an information regarding jobs,Real estates,discounts,events,Restaurents,Movies etc.," +
                            "what not ? all within seconds" +

                            " JustCalluz is a fastest growing local search engine, operating from Hyderabad, India.A JustCalluz visitor can get the desired business information instantly by selecting a location name from the given options and enter the search keyword in the search option." +
                            "JustCalluz works 24/7 to find innovative ways and make local search much easier & simpler, we welcome people with creative ideas and zeal to learn & develop." +


                            "Warm Regards," +
                            "Team JustCalluz";
            objSms.SendSMS(Convert.ToString(ConfigurationManager.AppSettings["SmsUsername"]), Convert.ToString(ConfigurationManager.AppSettings["SmsPassword"]), txtSMobile1.Text, mobilesfrd);
            strScript = "alert('Thank you! You have successfully shared with your friend.');location.replace('Events-events');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            txtSName1.Text = "";
            txtSFName1.Text = "";
            txtSEmail1.Text = "";
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void imggo_Click(object sender, ImageClickEventArgs e)
    {
        string Mobileshrfrnd = "";
        try
        {
            string name = txtname.Text;
            string fname = txtfname.Text;
            string email = txtFEmail.Text;
            SendMail1(name, fname, email);
            string strScript = string.Empty;
            SMSCAPI objSms = new SMSCAPI();
            Mobileshrfrnd = "Dear" + fname + " ," +

                            "Your Friend " + name + "," +
                            " Suggested you to get through the site Justcalluz.com or dial 99166136226." +
                            "To get an information regarding jobs,Real estates,discounts,events,Restaurents,Movies etc.," +
                            "what not ? all within seconds" +

                            " JustCalluz is a fastest growing local search engine, operating from Hyderabad, India.A JustCalluz visitor can get the desired business information instantly by selecting a location name from the given options and enter the search keyword in the search option." +
                            "JustCalluz works 24/7 to find innovative ways and make local search much easier & simpler, we welcome people with creative ideas and zeal to learn & develop." +


                            "Warm Regards," +
                            "Team JustCalluz";
            objSms.SendSMS(Convert.ToString(ConfigurationManager.AppSettings["SmsUsername"]), Convert.ToString(ConfigurationManager.AppSettings["SmsPassword"]), txtmob.Text, Mobileshrfrnd);
            strScript = "alert('Thank you! You have successfully shared with your friend.');location.replace('Events-events');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            txtname.Text = "";
            txtfname.Text = "";
            txtFEmail.Text = "";
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void imggo1_Click(object sender, ImageClickEventArgs e)
    {
        string Msg = " ";
        try
        {


            sid = Convert.ToString(Page.RouteData.Values["id"]);

            string name = txtname1.Text;
            string email = txtSEmail.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand("select id,event_name,event_place,event_desc,city,mob from modulesdata where id=('" + sid + "')", con);

            SqlDataReader dr = cmd.ExecuteReader();
            string cname = string.Empty; ;
            string place = string.Empty;
            string desc = string.Empty;
            string loc = string.Empty;
            string mob = string.Empty;
            string no = string.Empty;
            while (dr.Read())
            {
                cname = Convert.ToString(dr["event_name"]);
                place = Convert.ToString(dr["event_place"]);
                desc = Convert.ToString(dr["event_desc"]);
                loc = Convert.ToString(dr["city"]);
                mob = Convert.ToString(dr["mob"]);
                no = Convert.ToString(dr["id"]);

                SMSCAPI objSms = new SMSCAPI();
                Msg = "Dear " + name + " ," + "Please find the below information you have requested:<br>" +
                            "Whenever you call , please mention that you got this info from Justcalluz.com" +" ," +
                            "Event Name" + cname + "," +
                            "Job Description" + desc + "," +
                            "Venue" + place + "," +
                            "Location" + loc + "," +
                            "Phone" + mob + "," +
                            "We hope the above information is in line with your request." +","+
                            "Kindly feel free to search for more information on www.justcalluz.com or call on +9166136226." + "," +
                             "Warm Regards," +
                            " Team JustCalluz";
                objSms.SendSMS(Convert.ToString(ConfigurationManager.AppSettings["SmsUsername"]), Convert.ToString(ConfigurationManager.AppSettings["SmsPassword"]), txtmob1.Text, Msg);


                SendMail(name, email, cname, place, desc, loc, mob, no);
                string strScript = string.Empty;
                strScript = "alert('Thank you! You have successfully sent the details.');location.replace('Events-events');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);

            }


            txtname1.Text = "";
            txtSEmail.Text = "";

        }
       
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }

            finally
            {
                con.Close();
            }
        }
    

    
    protected string GetCompUrl(object cid)
    {
        string cmpid = cid.ToString();
        return Page.GetRouteUrl("Event_Details", new { id = cmpid, cname = "events" });
    }

    //protected void friend1_Click(object sender,EventArgs e)
    //{
    //    pnlmap.Visible = false;
    //    //friendpanel.Visible = true;
    //    ModalPopupExtender4.Show();
    //}
  
 }
