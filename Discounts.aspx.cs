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
using JustCallUsData.Data;
using System.Net;
using System.Net.NetworkInformation;
using System.Web.Routing;


/// <summary>
/// To display the existing discounts , display of average rating , To check the authentication to display further pages.  
/// </summary>
public partial class Discounts : System.Web.UI.Page
{
    string sid = string.Empty;
    int id;
    string city;
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
    DateTime current = DateTime.Now.Date;
    string current1;
    SqlDataAdapter da;
    DataSet ds;
    string strScript = string.Empty;
    Binddata objBd = new Binddata();
    InsertData obj = new InsertData();
    static string excep_page = "Discounts.aspx";
    DateTime date1;
    DateTime date;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            Session["searchpg"] = "discounts";
            lblerror.Visible = false;
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
            //ddlPageSize.Visible = false;
            if (!IsPostBack)
            {
                BindGrid();
                //rating();
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
            current1 = current.ToShortDateString();
            DataSet ds = new DataSet();
            ds = objBd.BindInitialValues(current1, city);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Session["id"] = id;
                pds.DataSource = ds.Tables[0].DefaultView;
                pds.AllowPaging = true;
                pds.PageSize = 10;
                //pds.PageSize = Convert.ToInt16(ddlPageSize.SelectedValue);
                if (ds.Tables[0].Rows.Count <= pds.PageSize)
                {
                    pds.CurrentPageIndex = CurrentPage;
                    trPaging.Visible = false;
                    ddldiscounts.DataSource = pds;
                    ddldiscounts.DataBind();
                }
                else
                {
                    pds.CurrentPageIndex = CurrentPage;
                    imgNext.Enabled = !pds.IsLastPage;
                    imgPrevious.Enabled = !pds.IsFirstPage;
                    ddldiscounts.DataSource = pds;
                    ddldiscounts.DataBind();
                }
                //doPaging();
            }
            else
            {
                lblerror.Visible = true;
                lblerror.Text = "Sorry, no Discounts found <br/>" + "<span class=side_menu>Suggestions :</span>Try Different Date";
                lblerror.CssClass = "sub_menu";
                trpagesize.Visible = false;
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
        CurrentPage -= 1;
        BindGrid();
    }
    protected void imgNext_Click(object sender, ImageClickEventArgs e)
    {
        CurrentPage += 1;
        BindGrid();
    }
    protected void ddldiscounts_SelectedIndexChanged(object sender, EventArgs e)
    {

    } 
    // sending mail
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
    protected void todaybut_Click(object sender, EventArgs e)
    {
        try
        {
            DateTime current = DateTime.Now.Date;
            filter_Discount(current);
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
            //DateTime current = DateTime.Now.Date;

            if (day == "Monday")
            {
               date = DateTime.Now.AddDays(Convert.ToDouble(4));
                for (i = current; i < date; )
                {

                    i = i.AddDays(Convert.ToDouble(1));
                }
                filtered_Discounts(i);
            }
            else if (day == "Tuesday")
            {
                date = DateTime.Now.AddDays(Convert.ToDouble(3));
                for (i = current; i < date; )
                {

                    i = i.AddDays(Convert.ToDouble(1));
                }
            }
            else if (day == "Wednesday")
            {
               date = DateTime.Now.AddDays(Convert.ToDouble(2));
                for (i = current; i < date; )
                {
                    filtered_Discounts(i);
                    i = i.AddDays(Convert.ToDouble(1));
                }
                filtered_Discounts(i);

            }
            else if (day == "Thursday")
            {
                date = DateTime.Now.AddDays(Convert.ToDouble(1));
                for (i = current; i < date; )
                {

                    i = i.AddDays(Convert.ToDouble(1));
                }
                filtered_Discounts(i);
            }
            else if (day == "Friday")
            {
                date = DateTime.Now.AddDays(Convert.ToDouble(1));

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
                date = DateTime.Now.AddDays(Convert.ToDouble(12));
                for (i = current; i < date; )
                {

                    i = i.AddDays(Convert.ToDouble(1));
                }
                filtered_Discounts(i);
            }
            else if (day == "Tuesday")
            {
                date = DateTime.Now.AddDays(Convert.ToDouble(11));
                for (i = current; i < date; )
                {

                    i = i.AddDays(Convert.ToDouble(1));
                }
                filtered_Discounts(i);
            }
            else if (day == "Wednesday")
            {
                date = DateTime.Now.AddDays(Convert.ToDouble(10));
                for (i = current; i < date; )
                {

                    i = i.AddDays(Convert.ToDouble(1));
                }
                filtered_Discounts(i);

            }
            else if (day == "Thursday")
            {
                date = DateTime.Now.AddDays(Convert.ToDouble(9));
                for (i = current; i < date; )
                {

                    i = i.AddDays(Convert.ToDouble(1));
                }
                filtered_Discounts(i);
            }
            else if (day == "Friday")
            {
               date = DateTime.Now.AddDays(Convert.ToDouble(8));
                for (i = current; i < date; )
                {

                    i = i.AddDays(Convert.ToDouble(1));
                }
                filtered_Discounts(i);

            }
            else if (day == "Saturday")
            {
                date = DateTime.Now.AddDays(Convert.ToDouble(7));
                for (i = current; i < date; )
                {

                    i = i.AddDays(Convert.ToDouble(1));
                }

                filtered_Discounts(i);
            }
            else
            {
                date = DateTime.Now.AddDays(Convert.ToDouble(6));
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
            string to = txtto.Text;
            if (from != "")
            {
                lblerror.Visible = false;

                if (to != "")
                {
                    DataSet dsDate = new DataSet();
                    dsDate = objBd.GetSDateAndEDateDetails(from, to, city);
                    if (dsDate.Tables[0].Rows.Count > 0)
                    {
                        ddldiscounts.DataSource = dsDate;
                        ddldiscounts.DataBind();
                    }
                    else
                    {
                        strScript = "alert('Sorry, no Discounts found Try Different Date');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                    }

                }
                else
                {
                    DataSet dsSDate = new DataSet();
                    dsSDate = objBd.GetSDateDetails(from, city);
                    if (dsSDate.Tables[0].Rows.Count > 0)
                    {
                        ddldiscounts.DataSource = dsSDate;
                        ddldiscounts.DataBind();
                    }
                    else
                    {
                        strScript = "alert('Sorry, no Discounts found Try Different Date');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                    }

                }
            }
            else if (to != "")
            {
                DataSet dsEdate = new DataSet();
                dsEdate = objBd.GetEDateDetails(to, city);
                if (dsEdate.Tables[0].Rows.Count > 0)
                {
                    ddldiscounts.DataSource = dsEdate;
                    ddldiscounts.DataBind();
                }
                else
                {
                    strScript = "alert('Sorry, no Discounts found Try Different Date');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                }
            }
            else
            {
                strScript = "alert('Please select the date');location.replace('Discounts-discounts');";//Discounts.aspx?cname=discounts
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
