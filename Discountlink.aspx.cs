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

/// <summary>
/// To display the existing discounts when a link is selected  , display of average rating , To check the authentication to display further pages.  
/// </summary>
public partial class Discountlink : System.Web.UI.Page
{
    InsertData obj = new InsertData();
    static string excep_page = "Discountlink.aspx";
    PagedDataSource pds = new PagedDataSource();
    string sid;
    int id;
    string city;
    string popcity = string.Empty;
    Binddata objBd = new Binddata();
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    DateTime current = DateTime.Now.Date;
    string strScript = string.Empty;
    string strname = string.Empty;
    string current1 = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            //Session["searchpg"] = "discounts";
            //ddlPageSize.Visible = false;
            if (Convert.ToString(Session["ciyonload"]) != "")
            {
                city = Convert.ToString(Session["ciyonload"]);
            }
            else
            {
                city = "Hyderabad";
            }
            if (!IsPostBack)
            {
                if (Convert.ToString(Page.RouteData.Values["Dscname"]) != "")
                {
                    strname = Convert.ToString(Page.RouteData.Values["Dscname"]);
                    bindSubcatData();
                }
                else if (Convert.ToString(Page.RouteData.Values["Dcname"]) != "")
                {
                    strname = Convert.ToString(Page.RouteData.Values["Dcname"]);
                    BindGrid();
                }
                else if (Convert.ToString(Page.RouteData.Values["popcity"]) != "")
                {
                    strname = Convert.ToString(Page.RouteData.Values["popcity"]);
                    BindPopCityData();
                }
                else
                    Response.RedirectToRoute("SearchResultPage", new { cname = strname, city=city });

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
    DataSet dsDCate = new DataSet();
    public void BindGrid()
    {
        try
        {
            ddldiscounts.Visible = true;
            current1 = current.ToShortDateString();
            strname = Convert.ToString(Page.RouteData.Values["Dcname"]);
            lblcatresult.Text = strname;
            lblresultcat.Text = strname;
            if (Convert.ToString(Page.RouteData.Values["Dcname"]) != "")
            {
                dsDCate = objBd.BindDLCatDetails(strname, city, current1);
                if (dsDCate.Tables[0].Rows.Count > 0)
                {
                    Session["id"] = id;
                    pds.DataSource = dsDCate.Tables[0].DefaultView;
                    pds.AllowPaging = true;
                    pds.PageSize = 3;
                    pds.CurrentPageIndex = CurrentPage;
                    imgNext.Enabled = !pds.IsLastPage;
                    imgPrevious.Enabled = !pds.IsFirstPage;
                    ddldiscounts.DataSource = pds;
                    ddldiscounts.DataBind();
                    //doPaging();
                }
                else
                {
                    lblDatanotfound.Visible = true;
                    lblDatanotfound.Text = "Sorry, no Discounts found for '" + strname + "'.<br/>" + "<span class=side_menu>Suggestions :</span>Try Different Date";
                    lblDatanotfound.CssClass = "sub_menu";
                    trpagesize.Visible = false;
                    //dlPaging.Visible = false;
                }

            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    public void BindPopCityData()
    {
        try
        {
            ddldiscounts.Visible = true;
            current1 = current.ToShortDateString();
            strname = Convert.ToString(Page.RouteData.Values["popcity"]);
            lblcatresult.Text = strname;
            lblresultcat.Text = strname;
            if (Convert.ToString(Page.RouteData.Values["popcity"]) != "")
            {
                dsDCate = objBd.BindPopCityData(strname, current1);
                if (dsDCate.Tables[0].Rows.Count > 0)
                {
                    Session["id"] = id;
                    pds.DataSource = dsDCate.Tables[0].DefaultView;
                    pds.AllowPaging = true;
                    pds.PageSize = 3;
                    pds.CurrentPageIndex = CurrentPage;
                    imgNext.Enabled = !pds.IsLastPage;
                    imgPrevious.Enabled = !pds.IsFirstPage;
                    ddldiscounts.DataSource = pds;
                    ddldiscounts.DataBind();
                    //doPaging();
                }
                else
                {
                    lblDatanotfound.Visible = true;
                    lblDatanotfound.Text = "Sorry, no Discounts found in '" + strname + "'.<br/>" + "<span class=side_menu>Suggestions :</span>Try Different City";
                    lblDatanotfound.CssClass = "sub_menu";
                    trpagesize.Visible = false;
                    //dlPaging.Visible = false;
                }
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
            if (this.ViewState["currentpage"] == null)
                return 0;
            else
                return Convert.ToInt16(this.ViewState["currentpage"].ToString());
        }
        set
        {
            this.ViewState["currentpage"] = value;
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
            DateTime current = DateTime.Now.Date;
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
            DateTime date1 = date.AddDays(Convert.ToDouble(1));
            SqlCommand cmd = new SqlCommand("filtered_discounts", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@event_startdate", date.ToShortDateString());
            cmd.Parameters.AddWithValue("@event_enddate", date1.ToShortDateString());
            cmd.Parameters.AddWithValue("@City", city);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ddldiscounts.DataSource = ds;
            ddldiscounts.DataBind();
            lblDatanotfound.Visible = false;
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
            string current1 = current.ToShortDateString();
            DataSet dsDiscount = new DataSet();
            dsDiscount = objBd.GetCurrentDetails(current1, city);
            if (dsDiscount.Tables[0].Rows.Count > 0)
            {
                ddldiscounts.DataSource = dsDiscount;
                ddldiscounts.DataBind();
                lblDatanotfound.Visible = false;
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
    protected void go_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            string from = txtfrom.Text;
            string to = txtto.Text;
            if (from != "")
            {
                if (to != "")
                {
                    DataSet dsDate = new DataSet();
                    dsDate = objBd.GetSDateAndEDateDetails(from, to, city);
                    if (!dsDate.Tables[0].Rows.Count.Equals(0))
                    {
                        lblDatanotfound.Visible = false;
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
                    if (!dsSDate.Tables[0].Rows.Count.Equals(0))
                    {
                        lblDatanotfound.Visible = false;
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
                if (!dsEdate.Tables[0].Rows.Count.Equals(0))
                {
                    lblDatanotfound.Visible = false;
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
                //strScript = "alert('Please select the date');location.replace('Discounts-" + strname + "');";
                strScript = "alert('Please select the date');location.replace('Discounts-discounts');";
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
    public void bindSubcatData()
    {
        try
        {
            DataSet dsSubCat = new DataSet();
            current1 = current.ToShortDateString();
            strname = Convert.ToString(Page.RouteData.Values["Dscname"]);
            lblcatresult.Text = strname;
            lblresultcat.Text = strname;
            dsSubCat = objBd.BindDLSubCatDetails(strname, city, current1);
            if (dsSubCat.Tables[0].Rows.Count > 0)
            {
                //Session["id"] = id;
                pds.DataSource = dsSubCat.Tables[0].DefaultView;
                pds.AllowPaging = true;
                //pds.PageSize = Convert.ToInt16(ddlPageSize.SelectedValue);
                pds.PageSize = 5;
                pds.CurrentPageIndex = CurrentPage;
                imgNext.Enabled = !pds.IsLastPage;
                imgPrevious.Enabled = !pds.IsFirstPage;
                ddldiscounts.DataSource = pds;
                ddldiscounts.DataBind();
                //doPaging();
            }
            else
            {
                lblDatanotfound.Visible = true;
                lblDatanotfound.Text = "Sorry, no Discounts found for '" + strname + "'.<br/>" + "<span class=side_menu>Suggestions :</span>Try Different Date";
                lblDatanotfound.CssClass = "sub_menu";
                trpagesize.Visible = false;
                //dlPaging.Visible = false;
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
    protected void ddldiscounts_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        try
        {
            HtmlTableCell tdimge = (HtmlTableCell)e.Item.FindControl("tdlogo");
            Label imgname = (Label)e.Item.FindControl("lblImgName");
            if (imgname != null)
            {
                //if (imgname.Text == "NULL" || imgname.Text == "0" || imgname.Text == "" || imgname.Text == "null")
                if (imgname.Text == "0")
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
    protected string GetUrl(object Did)
    {
        string DiscountId = Did.ToString();
        return Page.GetRouteUrl("DiscountDetails", new { id = DiscountId, cname = "discounts" });
    }
    protected string GetUrlCat(object PId)
    {
        string PReviewId = PId.ToString();
        return Page.GetRouteUrl("PostReviewCat", new { DataId = PReviewId, mod = "Discounts" });
    }
   

}
