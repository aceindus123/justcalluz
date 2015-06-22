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

public partial class Discount_Details : System.Web.UI.Page
{
    InsertData obj = new InsertData();
    int id;
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    string sid = string.Empty;
    string city = string.Empty;
    DateTime current = DateTime.Now.Date;
    SqlDataAdapter da;
    DataSet ds = new DataSet();
    string strScript = string.Empty;
    string current1;
    string Mobilemsg = "";
    Binddata objBd = new Binddata();
    PagedDataSource pds = new PagedDataSource();
    char[] separatorcomma = new char[] { ',' };
    static string excep_page = "Discount_details.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            //Session["searchpg"] = "discounts";
            lblerror.Visible = false;
            try
            {
                if (Session["ciyonload"] != null)
                {
                    city = Session["ciyonload"].ToString();
                }
                else
                {
                    city = "Hyderabad";
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
            if (!IsPostBack)
            {
                try
                {
                    ddldiscounts.Visible = false;
                    string category = string.Empty;
                    DataSet ds = new DataSet();
                    sid = Convert.ToString(Page.RouteData.Values["id"].ToString());
                    SqlCommand cmd = new SqlCommand("Discounts", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value =Convert.ToInt32(sid);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    if (!ds.Tables[0].Rows.Count.Equals(0))
                    {
                        DataList1.Visible = true;
                        DataList1.DataSource = ds;
                        DataList1.DataBind();
                    }
                    else
                    {
                        lblerror.Visible = true;
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
                    BindMoreInfo();
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
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
        filter_Discount(current);
    }
    protected void tombut_Click(object sender, EventArgs e)
    {
        try
        {
            DateTime tomorrow = DateTime.Now.AddDays(Convert.ToDouble(1));
            filter_Discount(tomorrow);
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
                filtered_Discounts(i);
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
                    filtered_Discounts(i);
                    i = i.AddDays(Convert.ToDouble(1));
                }
                filtered_Discounts(i);

            }
            else if (day == "Thursday")
            {
                DateTime date = DateTime.Now.AddDays(Convert.ToDouble(1));
                for (i = current; i < date; )
                {

                    i = i.AddDays(Convert.ToDouble(1));
                }
                filtered_Discounts(i);
            }
            else if (day == "Friday")
            {
                DateTime date = DateTime.Now.AddDays(Convert.ToDouble(1));

                filtered_Discounts(date);

            }
            else if (day == "Saturday")
            {
                filtered_Discounts(current);
            }
            else
            {
                filter_Discount(current);

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
            DateTime i;
            string day = DateTime.Now.DayOfWeek.ToString();
            if (day == "Monday")
            {
                DateTime date = DateTime.Now.AddDays(Convert.ToDouble(12));
                for (i = current; i < date; )
                {

                    i = i.AddDays(Convert.ToDouble(1));
                }
                filtered_Discounts(i);
            }
            else if (day == "Tuesday")
            {
                DateTime date = DateTime.Now.AddDays(Convert.ToDouble(11));
                for (i = current; i < date; )
                {

                    i = i.AddDays(Convert.ToDouble(1));
                }
                filtered_Discounts(i);
            }
            else if (day == "Wednesday")
            {
                DateTime date = DateTime.Now.AddDays(Convert.ToDouble(10));
                for (i = current; i < date; )
                {

                    i = i.AddDays(Convert.ToDouble(1));
                }
                filtered_Discounts(i);

            }
            else if (day == "Thursday")
            {
                DateTime date = DateTime.Now.AddDays(Convert.ToDouble(9));
                for (i = current; i < date; )
                {

                    i = i.AddDays(Convert.ToDouble(1));
                }
                filtered_Discounts(i);
            }
            else if (day == "Friday")
            {
                DateTime date = DateTime.Now.AddDays(Convert.ToDouble(8));
                for (i = current; i < date; )
                {

                    i = i.AddDays(Convert.ToDouble(1));
                }
                filtered_Discounts(i);

            }
            else if (day == "Saturday")
            {
                DateTime date = DateTime.Now.AddDays(Convert.ToDouble(7));
                for (i = current; i < date; )
                {

                    i = i.AddDays(Convert.ToDouble(1));
                }

                filtered_Discounts(i);
            }
            else
            {
                DateTime date = DateTime.Now.AddDays(Convert.ToDouble(6));
                for (i = current; i < date; )
                {

                    i = i.AddDays(Convert.ToDouble(1));
                }
                filtered_Discounts(i);

            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    public void filtered_Discounts(DateTime date)
    {
        try
        {
            con.Open();
            lblerror.Visible = false;
            DataList1.Visible = false;
            friendpanel.Visible = false;
            mailpanel.Visible = false;
            dvMoreInfo.Visible = false;
            pnlmap.Visible = false;
            ddldiscounts.Visible = true;
            DateTime date1 = date.AddDays(Convert.ToDouble(1));
            SqlCommand cmd = new SqlCommand("filtered_discounts", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@event_startdate", date.ToShortDateString());
            cmd.Parameters.AddWithValue("@event_enddate", date1.ToShortDateString());
            cmd.Parameters.AddWithValue("@City", city);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                ddldiscounts.DataSource = ds;
                ddldiscounts.DataBind();
            }
            else
            {
                strScript = "alert('Sorry, no Discounts found Try Different Date');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            }
            con.Close();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    public void filter_Discount(DateTime current)
    {
        try
        {
            con.Open();
            current1 = current.ToShortDateString();
            ddldiscounts.Visible = true;
            DataList1.Visible = false;
            friendpanel.Visible = false;
            mailpanel.Visible = false;
            pnlmap.Visible = false;
            dvMoreInfo.Visible = false;
            DataSet dsDiscount = new DataSet();
            dsDiscount = objBd.GetCurrentDetails(current1, city);
            if (dsDiscount.Tables[0].Rows.Count > 0)
            {
                ddldiscounts.DataSource = dsDiscount;
                ddldiscounts.DataBind();
            }
            else
            {
                strScript = "alert('Sorry, no Discounts found Try Different Date');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            }
            con.Close();
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
            con.Open();
            string from = txtfrom.Text;
            DataList1.Visible = false;
            pnlmap.Visible = false;
            dvMoreInfo.Visible = false;
            friendpanel.Visible = false;
            mailpanel.Visible = false;
            string to = txtto.Text;
            if (from != "")
            {
                lblerror.Visible = false;

                if (to != "")
                {
                    try
                    {
                        DataSet dsDate = new DataSet();
                        dsDate = objBd.GetSDateAndEDateDetails(from, to, city);
                        if (dsDate.Tables[0].Rows.Count > 0)
                        {
                            ddldiscounts.Visible = true;
                            ddldiscounts.DataSource = dsDate;
                            ddldiscounts.DataBind();

                        }
                        else
                        {
                            strScript = "alert('Sorry, no Discounts found Try Different Date');";
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
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
                        DataSet dsSDate = new DataSet();
                        dsSDate = objBd.GetSDateDetails(from, city);
                        if (dsSDate.Tables[0].Rows.Count > 0)
                        {
                            ddldiscounts.Visible = true;
                            ddldiscounts.DataSource = dsSDate;
                            ddldiscounts.DataBind();
                        }
                        else
                        {
                            strScript = "alert('Sorry, no Discounts found Try Different Date');";
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
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
                    DataSet dsEdate = new DataSet();
                    dsEdate = objBd.GetEDateDetails(to, city);
                    if (dsEdate.Tables[0].Rows.Count > 0)
                    {
                        ddldiscounts.Visible = true;
                        ddldiscounts.DataSource = dsEdate;
                        ddldiscounts.DataBind();
                    }
                    else
                    {
                        strScript = "alert('Sorry, no Discounts found Try Different Date');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
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
                strScript = "alert('Please select the date');location.replace('Discounts-discounts');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            }
            txtfrom.Text = "";
            txtto.Text = "";
            con.Close();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    public void SendMail(string name, string email, string cname, string desc, string addrs, string loc, string mob, string no)
    {
        //Discount_Details.aspx?id
         string Msg = "";

            try
            {
                MailMessage mm = new MailMessage();
                mm.From = new MailAddress("info@justcalluz.com");
                mm.To.Add(email);
                Msg += "Dear <b>" + name + "</b> ," +
                            "<br>Please find the below information you have requested:<br>" +
                            "<br>Whenever you call , please mention that you got this info from Justcalluz.com" +
                            "<br><table width=100%>" +
                            "<tr><td align=left>Event Name</td><td>:</td><td>" + cname + "</td></tr>" +
                            "<tr><td align=left>Description</td><td>:</td><td>" + desc + "</td></tr>" +
                            "<tr><td align=left>Address</td><td>:</td><td>" + addrs + "</td></tr>" +
                            "<tr><td align=left>Location</td><td>:</td><td>" + loc + "</td></tr>" +
                            "<tr><td align=left>Phone</td><td>:</td><td>" + mob + "</td></tr>" +
                            "</table>" +
                            "br>We hope the above information is in line with your request." +
                            "<br>For further details please follow the link <a href=http://www.justcalluz.com/Discount-discounts " + no + ">www.justcalluz.com</a> or call on +9166136226." +
                            "<br><br>Warm Regards," +
                            "<br> Team JustCalluz";
                mm.Subject = "Discount";
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
    public void BindMoreInfo()
    {
        try
        {
            int id = Convert.ToInt32(Page.RouteData.Values["id"].ToString());
            dvMoreInfo.Visible = true;
            string MonDur = "";
            string TuesDur = "";
            string WedDur = "";
            string ThursDur = "";
            string FriDur = "";
            string SatDur = "";
            string SunDur = "";
            string Monday = "";
            string Tuesday = "";
            string Wednesday = "";
            string Thursday = "";
            string Friday = "";
            string Satday = "";
            string Sunday = "";
            string Payment = "";
            string Established = "";
            string Emp_No = "";
            DataSet dsMoreInfo = new DataSet();
            dsMoreInfo = objBd.GetMoreInfo(id);
            if (!dsMoreInfo.Tables[0].Rows.Count.Equals(0))
            {
                Monday = dsMoreInfo.Tables[0].Rows[0]["Monday"].ToString();
                Tuesday = dsMoreInfo.Tables[0].Rows[0]["Tuesday"].ToString();
                Wednesday = dsMoreInfo.Tables[0].Rows[0]["Wednesday"].ToString();
                Thursday = dsMoreInfo.Tables[0].Rows[0]["Thursday"].ToString();
                Friday = dsMoreInfo.Tables[0].Rows[0]["Friday"].ToString();
                Satday = dsMoreInfo.Tables[0].Rows[0]["Saturday"].ToString();
                Sunday = dsMoreInfo.Tables[0].Rows[0]["Sunday"].ToString();
                MonDur = dsMoreInfo.Tables[0].Rows[0]["Mon_Dur"].ToString();
                TuesDur = dsMoreInfo.Tables[0].Rows[0]["Tues_Dur"].ToString();
                WedDur = dsMoreInfo.Tables[0].Rows[0]["Wed_Dur"].ToString();
                ThursDur = dsMoreInfo.Tables[0].Rows[0]["Thurs_Dur"].ToString();
                FriDur = dsMoreInfo.Tables[0].Rows[0]["Fri_Dur"].ToString();
                SatDur = dsMoreInfo.Tables[0].Rows[0]["Satur_Dur"].ToString();
                SunDur = dsMoreInfo.Tables[0].Rows[0]["Sun_Dur"].ToString();
                Payment = dsMoreInfo.Tables[0].Rows[0]["PaymentMode"].ToString();
                Established = dsMoreInfo.Tables[0].Rows[0]["Year_Established"].ToString();
                Emp_No = dsMoreInfo.Tables[0].Rows[0]["No_of_employees"].ToString();
                if (Monday == "Time Duration")
                {
                    string[] strMonArr = MonDur.Split(separatorcomma);
                    foreach (string arrstrrMon in strMonArr)
                    {
                        lblMonday.Text += arrstrrMon + "<br />";
                    }
                }
                else
                {
                    lblMonday.Text = Monday;
                }
                if (Tuesday == "Time Duration")
                {
                    string[] strTuesArr = TuesDur.Split(separatorcomma);
                    foreach (string arrstrrTues in strTuesArr)
                    {
                        lblTuesday.Text += arrstrrTues + "<br />";
                    }
                }
                else
                {
                    lblTuesday.Text = Tuesday;
                }
                if (Wednesday == "Time Duration")
                {
                    string[] strWedArr = WedDur.Split(separatorcomma);
                    foreach (string arrstrrWed in strWedArr)
                    {
                        lblWednesday.Text += arrstrrWed + "<br />";
                    }
                }
                else
                {
                    lblWednesday.Text = Wednesday;
                }
                if (Thursday == "Time Duration")
                {
                    string[] strThursArr = ThursDur.Split(separatorcomma);
                    foreach (string arrstrrThurs in strThursArr)
                    {
                        lblThursday.Text += arrstrrThurs + "<br />";
                    }
                }
                else
                {
                    lblThursday.Text = Thursday;
                }
                if (Friday == "Time Duration")
                {
                    string[] strFriArr = FriDur.Split(separatorcomma);
                    foreach (string arrstrrFri in strFriArr)
                    {
                        lblFriday.Text += arrstrrFri + "<br />";
                    }
                }
                else
                {
                    lblFriday.Text = Friday;
                }
                if (Satday == "Time Duration")
                {
                    string[] strSatArr = SatDur.Split(separatorcomma);
                    foreach (string arrstrrSat in strSatArr)
                    {
                        lblSaturday.Text += arrstrrSat + "<br />";
                    }
                }
                else
                {
                    lblSaturday.Text = Satday;
                }
                if (Sunday == "Time Duration")
                {
                    string[] strSunArr = SunDur.Split(separatorcomma);
                    foreach (string arrstrrSun in strSunArr)
                    {
                        lblSunday.Text += arrstrrSun + "<br />";
                    }
                }
                else
                {
                    lblSunday.Text = Sunday;
                }
                if (Payment != "")
                {
                    string[] strpayArr = Payment.Split(separatorcomma);
                    foreach (string Arrstrpay in strpayArr)
                    {
                        lblpaymodes.Text += Arrstrpay + "<br />";
                    }
                }
                else
                {
                    lblpaymodes.Text = "Not Mentioned";
                }
                if (Established == "")
                {
                    lblyrestd.Text = "Not Mentioned";
                }
                else
                {
                    lblyrestd.Text = Established;
                }
                if (Emp_No == "")
                {
                    lblempcount.Text = "Not Mentioned";
                }
                else
                {
                    lblempcount.Text = Emp_No;
                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
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
    protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
    {

    }
    protected void ddldiscounts_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        try
        {
            HtmlTableCell tdimge = (HtmlTableCell)e.Item.FindControl("tdlogo");
            Label imgname = (Label)e.Item.FindControl("lblImgName");
            if (imgname != null)
            {
                if (imgname.Text == "NULL" || imgname.Text == "0" || imgname.Text == "" || imgname.Text == "null")
                {
                    tdimge.Visible = false;
                }
                else
                {
                    tdimge.Visible = true;
                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void imggo_Click(object sender, ImageClickEventArgs e)
    {
        string Mobilefrndmsg = "";
        try
        {
            string name = txtname.Text;
            string fname = txtfname.Text;
            string email = txtEmail.Text;
                     
            SMSCAPI objSms = new SMSCAPI();
            Mobilefrndmsg = "Dear " + fname + "," + "Your Friend " + name +","+
                "Suggested you to get through the site Justcalluz.com or dial 99166136226." + "," +
                "To get an information regarding jobs,Real estates,discounts,events,Restaurents,Movies etc.,"+
                "what not ? all within seconds" +
                "JustCalluz is a fastest growing local search engine.A JustCalluz visitor can get the desired business information instantly by selecting a location name from the given options and enter the search keyword in the search option."+
                "JustCalluz works 24/7 to find innovative ways and make local search much easier & simpler, we welcome people with creative ideas and zeal to learn & develop." +
                            "Warm Regards," +
                            "Team JustCalluz";
            objSms.SendSMS(Convert.ToString(ConfigurationManager.AppSettings["SmsUsername"]), Convert.ToString(ConfigurationManager.AppSettings["SmsPassword"]), txtFMobile.Text, Mobilemsg);

            SendMail1(name, fname, email);
            string strScript = string.Empty;
            strScript = "alert('Thank you! You have successfully shared with your friend.');location.replace('Discounts-discounts');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            txtname.Text = "";
            txtfname.Text = "";
            txtEmail.Text = "";
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
            string email = txtSEmail.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from modulesdata where id=('" + sid + "')", con);

            SqlDataReader dr = cmd.ExecuteReader();
            string cname = string.Empty; ;
            string desc = string.Empty;
            string addrs = string.Empty;
            string loc = string.Empty;
            string mob = string.Empty;
            string no = string.Empty;
            while (dr.Read())
            {
                cname = Convert.ToString(dr["company_name"]);
                desc = Convert.ToString(dr["event_desc"]);
                addrs = Convert.ToString(dr["address"]);
                loc = Convert.ToString(dr["city"]);
                mob = Convert.ToString(dr["mob"]);
                no = Convert.ToString(dr["id"]);
               

                SMSCAPI objSms = new SMSCAPI();
                Mobilemsg = "Dear " + name + "," + "Please find the below information you have requested:" +
                    "Whenever you call , please mention that you got this info from Justcalluz.com" + "," + "Event name:" + cname + "," +
                    "Description:" + desc + "," +
                    "Address:" + addrs + "," +
                    "Location:" + loc + "," +
                    "Phone:" + mob + "," + 
                    "We hope the above information is in line with your request." +","+
                    "Kindly feel free to search for more information on www.justcalluz.com or call on +9166136226." +","+
                     "Warm Regards," +
                                "Team JustCalluz";
                objSms.SendSMS(Convert.ToString(ConfigurationManager.AppSettings["SmsUsername"]), Convert.ToString(ConfigurationManager.AppSettings["SmsPassword"]), txtmob1.Text, Mobilemsg);


                SendMail(name, email, cname, desc, addrs, loc, mob, no);
                string strScript = string.Empty;
                strScript = "alert('Thank you! You have successfully sent the details.');location.replace('Discounts-discounts');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);

            }
            txtname1.Text = "";
            txtSEmail.Text = "";
            con.Close();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected string GetUrl(object Did)
    {
        string DiscountId = Did.ToString();
        return Page.GetRouteUrl("DiscountDetails", new { id = DiscountId, cname = "discounts" });
    }
    protected string GetCatUrl(object PId)
    {
        string PReviewId = PId.ToString();
        return Page.GetRouteUrl("PostReviewCat", new { DataId = PReviewId, mod = "Discounts" });
    }
}
