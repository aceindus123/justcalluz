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

public partial class usercontrols_City_trends_Right : System.Web.UI.UserControl
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    CityTrendsCS objdata = new CityTrendsCS();
    string Post;
    string mod;
    InsertData obj = new InsertData();
    static string excep_page = "City_trends_LeftContent.ascx";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                if (Convert.ToString(Page.RouteData.Values["city"]) != "")
                //if (Request.QueryString["city"] != null)
                {
                    Post = Convert.ToString(Page.RouteData.Values["city"]);

                }
                else
                {
                    Post = Convert.ToString(Session["city"]);
                }
                Dlposts.Visible = true;
                DataSet ds2 = new DataSet();
                ds2 = objdata.bindCTPosts(Post);
                Dlposts.DataSource = ds2;
                Dlposts.DataBind();

                DlTags.Visible = true;
                DataSet ds3 = new DataSet();
                ds3 = objdata.bindCTTags(Post);
                DlTags.DataSource = ds3;
                DlTags.DataBind();
            }
           
           
                DlpopCat.Visible = true;
                DataSet ds = new DataSet();
                ds = objdata.bindCTCategories();
                DlpopCat.DataSource = ds;
                DlpopCat.DataBind();
                if (!Page.IsPostBack)
                {
                DllocalSearch.Visible = true;
                DataSet ds1 = new DataSet();
                ds1 = objdata.bindCTPopCities();
                DllocalSearch.DataSource = ds1;
                DllocalSearch.DataBind();
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }

    protected void DllocalSearch_ItemCommand(object source, DataListCommandEventArgs e)
    {
        try
        {
            string LCity = "";
            LCity = e.CommandArgument.ToString();
            Response.RedirectToRoute("cityhome", new { city = LCity });
            //redirect("Default.aspx?city=" + LCity, false);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    //protected void DlpopCat_ItemCommand(object source, DataListCommandEventArgs e)
    //{
    //    try
    //    {
    //        string cate = "";
    //        string Post = Convert.ToString(Session["city"]);
    //        cate = e.CommandArgument.ToString();
    //        //redirect("City_trends.aspx?category=" + Server.UrlEncode(cate) + " & city=" + Server.UrlEncode(Post), false);
    //        Response.RedirectToRoute("citycattrends", new { category = cate, city = Post });
    //    }
    //    catch (Exception ex)
    //    {
    //        obj.insert_exception(ex, excep_page);
    //        Response.Redirect("HttpErrorPage.aspx");
    //    }
    //}
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
    protected string GetUrlcityid(object cityid)
    {
        string cname = cityid.ToString();
        return Page.GetRouteUrl("CityTrendDetails", new { CtId = cname });
    }
    protected string GetUrlcity_title(object city_id)
    {
        int citytrends_id = Convert.ToInt32(city_id.ToString());
        //cname = cname.Replace(",", "-");
        return Page.GetRouteUrl("citytrendz_title", new { ctid = citytrends_id });
    }
    protected string GetUrlPopCat(object popcat)
    {
        string Post = Convert.ToString(Session["city"]);
        string PCat = popcat.ToString();
        //PCat = PCat.Replace("&", "and");
        return Page.GetRouteUrl("citycattrends", new { category = PCat, city = Post });
    }
    protected string GetLocalCat(object locCity)
    {
        string LCity = locCity.ToString();
        return Page.GetRouteUrl("cityhome", new { city = LCity });
    }
}
