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
using System.Web.Routing;

public partial class national_search : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            movies.Visible = true;
            restaurants.Visible = false;
            hotel.Visible = false;
            auction.Visible = false;
            reseller.Visible = false;
            trends.Visible = false;
            lifestyle.Visible = false;
        }
    }
    protected void lnkmovie_Click(object sender, EventArgs e)
    {
        movies.Visible = true;
        restaurants.Visible = false;
        hotel.Visible = false;
        auction.Visible = false;
        reseller.Visible = false;
        trends.Visible = false;
        lifestyle.Visible = false;
        //Response.Redirect("Movies.aspx?mname=null&mlang=null");
        Response.RedirectToRoute("Movies", new { mname = "null", mlang = "null" });

    }
    protected void lnkrest_Click(object sender, EventArgs e)
    {
        string str = "Restaurant and Pubs";
        movies.Visible = false;
        restaurants.Visible = true;
        hotel.Visible = false;
        auction.Visible = false;
        reseller.Visible = false;
        trends.Visible = false;
        lifestyle.Visible = false;
       // Response.Redirect("More.aspx?catname=" + Server.UrlEncode(str));
        Response.RedirectToRoute("More", new { catname = str });

    }
    protected void lnkhotel_Click(object sender, EventArgs e)
    {
        movies.Visible = false;
        restaurants.Visible = false;
        hotel.Visible = true;
        auction.Visible = false;
        reseller.Visible = false;
        trends.Visible = false;
        lifestyle.Visible = false;
       // Response.Redirect("Hotels.aspx");
        Response.RedirectToRoute("Hotels", new { pageid = "Hotels" });

    }
    protected void lnkauction_Click(object sender, EventArgs e)
    {
        movies.Visible = false;
        restaurants.Visible = false;
        hotel.Visible = false;
        auction.Visible = true;
        reseller.Visible = false;
        trends.Visible = false;
        lifestyle.Visible = false;
        //Response.Redirect("jc_reverse_auction.aspx");
        Response.RedirectToRoute("Reverse");

        
    }
    protected void lnkreseller_Click(object sender, EventArgs e)
    {
        movies.Visible = false;
        restaurants.Visible = false;
        hotel.Visible = false;
        auction.Visible = false;
        reseller.Visible = true;
        trends.Visible = false;
        lifestyle.Visible = false;
    }
    protected void lnktrends_Click(object sender, EventArgs e)
    {
        movies.Visible = false;
        restaurants.Visible = false;
        hotel.Visible = false;
        auction.Visible = false;
        reseller.Visible = false;
        trends.Visible = true;
        lifestyle.Visible = false;
    }
    //protected void lnklifestyle_Click(object sender, EventArgs e)
    //{
    //    movies.Visible = false;
    //    restaurants.Visible = false;
    //    hotel.Visible = false;
    //    auction.Visible = false;
    //    reseller.Visible = false;
    //    trends.Visible = false;
    //    lifestyle.Visible = true;
    //   // Response.Redirect("lifestyle.aspx");
    //    Response.RedirectToRoute("LifeStyle");

        
    //}
}
