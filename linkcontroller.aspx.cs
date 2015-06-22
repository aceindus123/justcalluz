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
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Web.Routing;
using JustCallUsData.Data;
/// <summary>
/// Class to display all categories data
/// </summary>
public partial class linkcontroller : System.Web.UI.Page
{
    //To make connection
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    InsertData obj = new InsertData();
    PagedDataSource pds = new PagedDataSource();
    protected HtmlGenericControl pagetitle = new HtmlGenericControl();
    string strname = string.Empty;
    string scname;
    string rname;
    string city;
    string dataId = string.Empty;
    static string excep_page = "linkcontroller.aspx";
    DataCS obj1 = new DataCS();
    /// <summary>
    /// Executes whenever page loads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        
        try
        {
            if (Convert.ToString(Session["ciyonload"]) != "")
            {
                city = Convert.ToString(Session["ciyonload"]);
            }
            else
            {
                city = "Hyderabad";
            }
            
            if (Convert.ToString(Page.RouteData.Values["cname"]) != "")
            {

                strname = Convert.ToString(Server.UrlDecode(Page.RouteData.Values["cname"].ToString()));
                strname = obj.ReplaceCatnamewithorginalchars(strname);
                metadata(strname);

                Label10.Text = strname;
                Label11.Text = strname;
                BindGrid(strname);
            }
            else if (Convert.ToString(Page.RouteData.Values["popcate"]) != "")
            {

                strname = Convert.ToString(Server.UrlDecode(Page.RouteData.Values["popcate"].ToString()));
                strname = obj.ReplaceCatnamewithorginalchars(strname);
                metadata(strname);

                Label10.Text = strname;
                Label11.Text = strname;
                BindGrid(strname);
            }
            else if (Convert.ToString(Page.RouteData.Values["rcname"] )!= "")
            {
                rname = Convert.ToString(Page.RouteData.Values["rcname"]).Trim();
                rname = obj.ReplaceCatnamewithorginalchars(rname);
                metadata(rname);
                Label10.Text = rname;
                Label11.Text = rname;
                leftrestaurant(rname);
            }
            else
            {
                scname = Convert.ToString(Server.UrlDecode(Page.RouteData.Values["scname"].ToString()));
                scname = obj.ReplaceCatnamewithorginalchars(scname);
                metadata(scname);
                Label10.Text = scname;
                Label11.Text = scname;
                leftrestaurant(scname);

            }
           // con.Open();
           
            //strname = Session["name"].ToString();

            if (!IsPostBack)
            {
                    //if (strname != "")
                    //{
                    //    BindGrid();
                    //}
                    //else if (rname != null)
                    //{
                    //    leftrestaurant(rname);
                    //}
                    //else
                    //{
                    //    leftrestaurant(scname);
                    //}
                    //else
                    //{
                    //    BindGrid1();
                    //}
            }
            //con.Close();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }    
    /// <summary>
    /// To bind the categories data
    /// </summary>
    public void BindGrid(string stname)
    {
        try
        {
                     
            //strname = strname.Replace("Dot", ".");
            //strname = strname.Replace("-", "'");
           // SqlDataAdapter dacname = new SqlDataAdapter("select *,stuff(\"company_name\", 22, len(company_name), '...') as compname,company_name from ModulesData where (Category=('" + strname + "') or company_name=('" + strname + "') or SubCategory=('" + strname + "')) and City='" + city + "' and ApprovedStatus='1' order by id desc", con);
            SqlDataAdapter dacname = new SqlDataAdapter("select *,stuff(company_name, 22, len(company_name), '...') as compname,company_name from ModulesData where (Category=('" + stname + "') or company_name=('" + stname + "') or SubCategory=('" + stname + "')) and City='" + city + "' and ApprovedStatus='1' order by id desc", con);
            //da1.Fill(ds1, "data");
            DataSet dscname = new DataSet();
            dacname.Fill(dscname);
            if (dscname.Tables[0].Rows.Count > 0)
            {
                //Session["id"] = id;
                pds.DataSource = dscname.Tables[0].DefaultView;
                pds.AllowPaging = true;
                //pds.PageSize = Convert.ToInt16(ddlPageSize.SelectedValue);
                pds.PageSize = 10;
                if (dscname.Tables[0].Rows.Count <= pds.PageSize)
                {
                    pds.CurrentPageIndex = CurrentPage;
                    trPaging.Visible = false;
                    DLBindCatData.DataSource = pds;
                    DLBindCatData.DataBind();
                    imgbtnSendMAIL.Visible = true;
                }
                else
                {
                    trPaging.Visible = true;
                    pds.CurrentPageIndex = CurrentPage;
                    imgNext.Enabled = !pds.IsLastPage;
                    imgPrevious.Enabled = !pds.IsFirstPage;
                    DLBindCatData.DataSource = pds;
                    DLBindCatData.DataBind();
                   imgbtnSendMAIL.Visible = true;
                }

            }
            else
            {
                //redirect("Search-Not-Found.aspx?cname=" + Server.UrlEncode(strname) + "&city=" + Server.UrlEncode(city),false);
                stname = obj.ReplaceSpecialchars(stname);
                Response.RedirectToRoute("SearchResultPage", new { cname = stname, city = city });
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    /// To put current page status
    /// </summary>
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
            if (strname != "")
            {
                BindGrid(strname);
            }
            else if (rname != "")
            {
                leftrestaurant(rname);

            }
            else
            {
                leftrestaurant(scname);
            }
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
            if (strname != null)
            {
                BindGrid(strname);
            }
            else if (rname != null)
            {
                leftrestaurant(rname);

            }
            else
            {
                leftrestaurant(scname);
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void DLBindCatData_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //modpopup1.Visible = false;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //modpopup2.Visible = false;
    }
    protected void DataList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        //string str = DataList2.SelectedItem;
        //Response.Redirect("?linkcontroller=" + str);
    }
    /// <summary>
    /// Function to display records when click on the sponsored links
    /// </summary>
    /// <param name="source"></param>
    /// <param name="e"></param>
    //protected void dlsponsoredlinks_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    //{
    //    Session["name"] = e.CommandArgument.ToString();
    //    string name = "";
    //    name = e.CommandArgument.ToString();
    //    Response.Redirect("linkcontroller.aspx?cname=" + name + "");
    //}

    static string TrimRightWord(string src, string toTrim)
    {
        if (src.EndsWith(toTrim))
            return src.Substring(0, src.Length - toTrim.Length);
        return src;
    }

    static string TrimEnds(string src, string wordToRemove)
    {
        char[] trimChars = new char[] { ' ' };
        int len;
        do
        {
            len = src.Length;
            src = src.TrimEnd(trimChars);
            src = TrimRightWord(src, wordToRemove);
            src = src.TrimEnd(trimChars);
        } while (len != src.Length);
        return src;
    }
    public void leftrestaurant(string subcat)
    {
        try
        {
            string mainsubcat = subcat;
           if(subcat.Contains("Restaurants"))
           {
               string lastword="Restaurants";
               subcat = TrimEnds(subcat, lastword);
           }
           SqlDataAdapter dasubcat = new SqlDataAdapter("select *,stuff(\"company_name\", 22, len(company_name), '...') as compname,company_name from ModulesData where SubCategory like '" + "%" + subcat + "%" + "' and City='" + city + "' and ApprovedStatus='1' order by id desc ", con);
            //da1.Fill(ds1, "data");
            DataSet dssubcat = new DataSet();
            dasubcat.Fill(dssubcat);
            if (dssubcat.Tables[0].Rows.Count > 0)
            {
                //Session["id"] = id;
                pds.DataSource = dssubcat.Tables[0].DefaultView;
                pds.AllowPaging = true;
                //pds.PageSize = Convert.ToInt16(ddlPageSize.SelectedValue);
                pds.PageSize = 10;
                if (dssubcat.Tables[0].Rows.Count <= pds.PageSize)
                {
                    pds.CurrentPageIndex = CurrentPage;
                    trPaging.Visible = false;
                    DLBindCatData.DataSource = pds;
                    DLBindCatData.DataBind();
                    imgbtnSendMAIL.Visible = true;
                }
                else
                {
                    trPaging.Visible = true;
                    pds.CurrentPageIndex = CurrentPage;
                    imgNext.Enabled = !pds.IsLastPage;
                    imgPrevious.Enabled = !pds.IsFirstPage;
                    DLBindCatData.DataSource = pds;
                    DLBindCatData.DataBind();
                    imgbtnSendMAIL.Visible = true;
                }

            }
            else
            {
                mainsubcat = mainsubcat.Replace("-", " ");
                mainsubcat = mainsubcat.Replace("Dot", ".");
                mainsubcat = mainsubcat.Replace("-", "/");
                mainsubcat = mainsubcat.Replace("-", "_");
                mainsubcat = mainsubcat.Replace("-", "%20");
                mainsubcat = mainsubcat.Replace("&", "-");
                //redirect("Search-Not-Found.aspx?cname=" + Server.UrlEncode(subcat) + "&city=" + Server.UrlEncode(city),false);
                Response.RedirectToRoute("SearchResultPage", new { cname = mainsubcat, city = city });
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

    protected void DLBindCatData_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            Label lblDataId = (Label)e.Item.FindControl("lblDataId");
            Label lblnoofratings = (Label)e.Item.FindControl("lblnoofratings");
            HtmlTableCell tdimge = (HtmlTableCell)e.Item.FindControl("tdlogo");
            Label imgname = (Label)e.Item.FindControl("lblImgName");
            LinkButton lnkmap = (LinkButton)e.Item.FindControl("lnkmap");
            // HtmlTableRow tdSlash = (HtmlTableRow)e.Item.FindControl("tdSlash");
            Label lblSlash = (Label)e.Item.FindControl("lblSlash");
            if (imgname != null)
            {
                try
                {
                    if (imgname.Text != "0")
                    {
                        tdimge.Visible = true;
                    }
                    else
                    {
                        tdimge.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }

            if (lblDataId != null)
            {
                try
                {
                    dataId = Convert.ToString(lblDataId.Text);
                   // con.Open();
                    SqlCommand cmd = new SqlCommand("Select count(rid) as NumberOfUsers,sum(Stars_Rating) as Total from PostReview where dataid='" + dataId + "'", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    float count = 0, rating = 0, result = 0;

                    if (Convert.ToInt32(dt.Rows[0]["NumberOfUsers"].ToString()) != 0)
                    {
                        count = float.Parse(dt.Rows[0]["NumberOfUsers"].ToString());
                        rating = float.Parse(dt.Rows[0]["Total"].ToString());
                        result = Convert.ToInt32(Math.Ceiling((rating / count) * 18));
                        //avgrating.InnerText = Math.Round((rating / count), 1).ToString();

                    }
                    else
                    {
                        //avgrating.InnerText = "0";
                    }
                    Label testSpan0 = (Label)e.Item.FindControl("testSpan0");
                    testSpan0.Width = Convert.ToInt32(result);
                    //testSpan0.Style.Add("width", result + "px");
                   // con.Close();
                    lblnoofratings.Text = Convert.ToString(count);

                    SqlDataAdapter mapadapter = new SqlDataAdapter("select id,map,Approved_map from modulesdata where id='" + dataId + "' and Approved_map=1", con);
                    DataSet dsmap = new DataSet();
                    mapadapter.Fill(dsmap);
                    if (!dsmap.Tables[0].Rows.Count.Equals(0))
                    {
                        pnlmap.Visible = true;
                        dlmap.Visible = true;
                        dlmap.DataSource = dsmap;
                        dlmap.DataBind();
                    }
                    else
                    {
                        pnlmap.Visible = false;
                        dlmap.Visible = false;
                        lnkmap.Visible = false;
                        lblSlash.Visible=false;
                       
                    }
                        
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
            HyperLink hypCompany = (HyperLink)e.Item.FindControl("hypCompany");
            if (hypCompany != null)
            {
                if (hypCompany.Text == "")
                {
                    hypCompany.Text = hypCompany.ToolTip.ToString();
                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
            
    }
    protected void imgbtnGo_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            strname = Convert.ToString(Page.RouteData.Values["cname"]).Trim();
            strname = strname.Replace("-", "&");
            strname = strname.Replace("-", " ");
            strname = strname.Replace("Dot", ".");
            strname = strname.Replace("-", "'");
            string name = Convert.ToString(txtname.Text);
            string mobile = Convert.ToString(txtmob.Text);
            string emailid = Convert.ToString(txtemail.Text);
            string subject = "Response to your search for " + strname;
            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            Server.Execute("SendEmail.aspx?name=" + name + "&cat=" + strname + "&city=" + city, htw);
            //Server.Execute("Mail-" + name + "-" + strname + "-" + city, htw);
            Mail.sendmail("info@justcalluz.com", emailid, subject, sw.ToString());
            string strScript = "";
            strScript = "alert('Your mail is sent successfully !!! SMS sent process not done at this time !!!');";

            string msgtxt = obj1.sendSms(name, strname, city, DLBindCatData);
            if (msgtxt != "")
            {
                SMSCAPI objSms = new SMSCAPI();
                objSms.SendSMS(Convert.ToString(ConfigurationManager.AppSettings["SmsUsername"]), Convert.ToString(ConfigurationManager.AppSettings["SmsPassword"]), mobile, msgtxt);
                strScript = "alert('You will receive Mail and SMS shortly.');";
            }
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void btnXSendSMS_Click(object sender, ImageClickEventArgs e)
    {

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
    protected void metadata(string modname)
    {
        try
        {
            pgtitle.Text = "Get the data about " + modname + " through justcalluz";
            HtmlHead head = (HtmlHead)Page.Header;
            HtmlMeta met1 = new HtmlMeta();
            HtmlMeta met2 = new HtmlMeta();
            met1.Name = "descriptions";
            met1.Content = "we provide updated information on all your local search";
            head.Controls.Add(met1);
            Header.Controls.Add(met1);
            met2.Name = "Keywords";
            met2.Content = "Justcalluz, Real Estate Business,1BHK flat, yellow pages, online yellow pages, yellow pages india, India trade directory,  yellow pages directory, city yellow pages, indian search engine, JustCalluz customer care, JustCalluz customer support";
            head.Controls.Add(met1);
        }
        catch (Exception ex)
        {
        }
    }
    protected string GetViewUrl(object bid)
    {
        string id = bid.ToString();
        return Page.GetRouteUrl("CT_sessionstore", new { id = id });
    }
    protected string GetCompUrl(object bid, object bCname)
    {
        string id = bid.ToString();
        string cname = bCname.ToString().Trim();
        //cname = cname.Replace("&", "-");
        //cname = cname.Replace(" ", "-");
        //cname = cname.Replace(".", "Dot");
        //cname = cname.Replace("'", "-");
       // return Page.GetRouteUrl("sessionstore", new { id = id, cname = cname });
        return Page.GetRouteUrl("sessionrestaurant", new { id = id });
    }
    protected void lnkmap_Click(object sender, CommandEventArgs e)
    {
        btnmap.Visible = true;
        pnlmap.Visible = true;
        string dataId1 = Convert.ToString(e.CommandArgument.ToString());
        SqlDataAdapter mapadapter1 = new SqlDataAdapter("select id,map,Approved_map from modulesdata where id='" + dataId1 + "' and Approved_map=1", con);
        DataSet dsmap1 = new DataSet();
        mapadapter1.Fill(dsmap1);
        if (!dsmap1.Tables[0].Rows.Count.Equals(0))
        {
            dlmap.Visible = true;
            dlmap.DataSource = dsmap1;
            dlmap.DataBind();
        }

        ModalPopupExtender3.Show();
    }
    
}





