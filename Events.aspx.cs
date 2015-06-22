﻿using System;
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

/// <summary>
/// Binding and displaying the events from the database , Calculating and displaying overallrating , checking for authentication
/// </summary>
public partial class Eventshome : System.Web.UI.Page
{
    InsertData obj = new InsertData();
    string sid = string.Empty;
    int id;
    string city;
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
    DateTime current = DateTime.Now.Date;
    static string excep_page = "Events.aspx";
    //string currtime = DateTime.Now.ToString("hh:mm:ss tt");
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            Session["searchpg"] = "events";
            lblmsg.Visible = false;
            if (Convert.ToString(Page.RouteData.Values["city"]) != "")
            {
                city = Convert.ToString(Page.RouteData.Values["city"]);
            }
            else if (Convert.ToString(Session["ciyonload"]) != "")
            {
                city = Convert.ToString(Session["ciyonload"]);
            }
            else
            {
                city = "Hyderabad";
            }
            string strname = string.Empty;
            //ddlPageSize.Visible = false;
            if (!IsPostBack)
            {
                BindGrid();


            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }

    /// <summary>
    /// Applying paging in the form
    /// </summary>
    PagedDataSource pds = new PagedDataSource();
    public void BindGrid()
    {
        try
        {
            string current1 = current.ToShortDateString();
            //SqlDataAdapter da = new SqlDataAdapter("select * from modulesdata where module='Events'and City='" + city + "'and event_enddate>='" + current1 + "' and event_startdate>='" + current1 + "' and ApprovedStatus='1'", con);
            SqlDataAdapter da = new SqlDataAdapter("select * from modulesdata where module='Events' and city='" + city + "' and ( ( event_enddate >= '" + current1 + "' and event_startdate >= '" + current1 + "') or ( event_startdate >= '" + current1 + "' or event_enddate >= '" + current1 + "') ) and ApprovedStatus=1 order by id desc", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (!dt.Rows.Count.Equals(0))
            {
                lblmsg.Visible = false;
                Session["id"] = id;
                pds.DataSource = dt.DefaultView;
                pds.AllowPaging = true;
                //pds.PageSize = Convert.ToInt16(ddlPageSize.SelectedValue);
                pds.PageSize = 3;
                pds.CurrentPageIndex = CurrentPage;
                imgNext.Enabled = !pds.IsLastPage;
                imgPrevious.Enabled = !pds.IsFirstPage;
                ddlevents.DataSource = pds;
                ddlevents.DataBind();
                //doPaging();
            }
            else
            {
                lblmsg.Visible = true;
                lblmsg.Text = "Sorry, no events found <br/>" + "<span class=side_menu>Suggestions :</span>Try Different Date";
                lblmsg.CssClass = "sub_menu";
                trpagesize.Visible = false;
                //dlPaging.Visible = false;
                friendpanel.Visible = false;
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    public int CurrentPage
    {
        get
        {
            if (this.ViewState["CurrentPage"] == null)
                return 0;
            else
                return Convert.ToInt16(this.ViewState["CurrentPage"].ToString());
        }
        set
        {
            this.ViewState["CurrentPage"] = value;
        }
    }
    protected void imgPrevious_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            CurrentPage -= 1;
            BindGrid();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void imgNext_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            CurrentPage += 1;
            BindGrid();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    //private void doPaging()
    //{
    //    DataTable dt = new DataTable();
    //    dt.Columns.Add("PageIndex");
    //    dt.Columns.Add("PageText");
    //    for (int i = 0; i < pds.PageCount; i++)
    //    {
    //        DataRow dr = dt.NewRow();
    //        dr[0] = i;
    //        dr[1] = i + 1;
    //        dt.Rows.Add(dr);
    //    }
    //    dlPaging.DataSource = dt;
    //    dlPaging.DataBind();
    //}

    //protected void dlPaging_ItemCommand(object source, DataListCommandEventArgs e)
    //{
    //    if (e.CommandName.Equals("lnkbtnPaging"))
    //    {
    //        CurrentPage = Convert.ToInt16(e.CommandArgument.ToString());
    //        BindGrid();
    //    }
    //}
    //protected void lnkbtnPrevious_Click1(object sender, EventArgs e)
    //{
    //    CurrentPage -= 1;
    //    BindGrid();
    //}
    //protected void lnkbtnNext_Click1(object sender, EventArgs e)
    //{
    //    CurrentPage += 1;
    //    BindGrid();
    //}
    //protected void ddlPageSize_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    CurrentPage = 0;
    //    BindGrid();
    //}
    //protected void dlPaging_ItemDataBound(object sender, DataListItemEventArgs e)
    //{
    //    LinkButton lnkbtnPage = (LinkButton)e.Item.FindControl("lnkbtnPaging");
    //    if (lnkbtnPage.CommandArgument.ToString() == CurrentPage.ToString())
    //    {
    //        lnkbtnPage.Enabled = false;
    //        lnkbtnPage.Font.Bold = true;
    //    }
    //}

     //sending mail

    public void SendMail(string name, string fname, string email)
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
                ddlevents.Visible = true;
                ddlevents.DataSource = ds;
                ddlevents.DataBind();
            }
            else
            {
                ddlevents.Visible = false;
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
           
            string current1 = current.ToShortDateString();
            SqlCommand cmd = new SqlCommand("select * from modulesdata where module='Events' and (event_enddate>='" + current1 + "' or event_startdate='" + current1 + "')and City='" + city + "' and ApprovedStatus='1' order by id desc", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "modulesdata");
           
            if (ds.Tables[0].Rows.Count > 0)
            {
                ddlevents.Visible = true;
                ddlevents.DataSource = ds;
                ddlevents.DataBind();
            }
            else
            {
                ddlevents.Visible = false;
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
            lblmsg.Visible = false;
            string from = txtfrom.Text;
            string to = txtto.Text;
            if (from != "")
            {
                if (to != "")
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from modulesdata where event_startdate='" + from + "'and (event_enddate='" + to + "'or event_enddate='" + from + "'or event_startdate='" + to + "')and City='" + city + "' and ApprovedStatus='1' order by id desc", con);
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
                else if (from != "")
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from modulesdata where (event_startdate='" + from + "' or event_enddate='" + from + "') and City='" + city + "' and ApprovedStatus='1' order by id desc", con);
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
            }
            else if (to != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from modulesdata where(event_startdate='" + to + "' or event_enddate='" + to + "')and City='" + city + "' and ApprovedStatus='1' order by id desc", con);
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

    protected void imggo_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            string name = txtname1.Text;
            string fname = txtfname.Text;
            string email = txtFEmail.Text;
            SendMail(name, fname, email);
            string strScript = string.Empty;
            strScript = "alert('Thank you! You have successfully shared with your friend.');location.replace('Events-events');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            txtname1.Text = "";
            txtfname.Text = "";
            txtFEmail.Text = "";
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected string GetCompUrl(object cid)
    {
        string cmpid = cid.ToString();
        return Page.GetRouteUrl("Event_Details", new { id = cmpid, cname = "events" });
    }
   
}
