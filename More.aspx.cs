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
using System.Web.Routing;

public partial class More : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    string catname;
    //string id;
    string qry;
    DataSet ds = new DataSet();
    string type;
    InsertData obj = new InsertData();
    static string excep_page = "More.aspx";
    string maincat = string.Empty;
    string returncate = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            catname = Convert.ToString(Page.RouteData.Values["catname"]);
            //id = Convert.ToString(Page.RouteData.Values["id"]);
            ////catname = catname.Replace("-", ",");
            //lblcat.Text = catname;
            GetCategory();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }

    
    public void GetCategory()
    {
        try
        {

            if (Convert.ToString(Page.RouteData.Values["catname"]) != "" && Convert.ToString(Page.RouteData.Values["type"])!="")
            {
                catname = catname.Replace("-", ",");
                metadata(catname);
                lblcat.Text = catname;
                qry = "select distinct(cat) from b2bcategories where maincat='" + catname + "' order by cat asc";
                ////metadata(id);
                ////lblcat.Text = id;
                ////qry = "select * from b2bcategories where maincat='" + id + "' order by cat asc";

            }
            else if (Convert.ToString(Page.RouteData.Values["catname"]) != "")
            {
                catname = catname.Replace(",", "-");
                metadata(catname);
                lblcat.Text = catname;
                qry = "select distinct(cat) from subcatageory where maincat='" + catname + "' order by cat asc";
                
               //// metadata(id);
               ////lblcat.Text = id;
               ////qry = "select * from subcatageory where maincat='" + id + "' order by cat asc";
            }
            SqlDataAdapter ada = new SqlDataAdapter(qry, con);
            ada.Fill(ds);
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                dlcat.DataSource = ds;
                dlcat.DataBind();
            }
            else
            {
                 maincat = Convert.ToString(Page.RouteData.Values["catname"]);
                 catname = obj.ReplaceSpecialchars(catname);

               // Response.RedirectToRoute("Link", new { cname = catname });

                Response.RedirectToRoute("Link_popcate", new { popcate = catname, pcname = maincat });
                
                ////Response.RedirectToRoute("Linkk", new { id = id });
                
            }

        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
          
          }
    }
    protected string GetUrl(object mcat)
    {
        maincat = Convert.ToString(Page.RouteData.Values["catname"]);

        string Cat = mcat.ToString().Trim();

        Cat = obj.ReplaceSpecialchars(Cat);
        if (Convert.ToString(Page.RouteData.Values["catname"]) != "" && Convert.ToString(Page.RouteData.Values["type"]) != "")
        {
            // return Page.GetRouteUrl("Link", new { cname = Cat });
            returncate = Page.GetRouteUrl("Link_popcate", new { popcate = Cat, pcname = maincat, cattype = "b2b" });
        }
        else if (Convert.ToString(Page.RouteData.Values["catname"]) != "")
        {
            returncate = Page.GetRouteUrl("Link_popcate", new { popcate = Cat, pcname = maincat, cattype = "pop" });
        }
        return returncate;
        
        ////return Page.GetRouteUrl("Linkk", new { id = Cat });
    }
    protected void metadata(string modname)
    {
        try
        {
            pgtitle.Text = "Get data about " + modname + " | JustCalluz ";
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
}
