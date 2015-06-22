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

public partial class lifestyle : System.Web.UI.Page
{
    string catname;
    string qry;
    DataSet ds = new DataSet();
    InsertData obj = new InsertData();
    static string excep_page = "lifestyle.aspx";
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    string city = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
          categories();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        SqlDataAdapter da= new SqlDataAdapter("select * from subcatageory where maincat='Lifestyle'",con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        lblcat.Text = Convert .ToString(ds.Tables[0].Rows[0]["maincat"]);
       

    }
   
    public void categories()
    {
        try
        {
            
            catg.Visible = true;
            tblbrand.Visible = false;
            dllife.Visible = true;
            DataSet ds3 = new DataSet();
            ds3 = obj.bindlife();
            dllife.DataSource = ds3;
            dllife.DataBind();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void brand_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            dlbrand.Visible = true;
            dllife.Visible = true;
            catg.Visible = false;
            tblbrand.Visible = true;
            DataSet ds2 = new DataSet();
            ds2 = obj.bindlifebrand();
            dlbrand.DataSource = ds2;
            dlbrand.DataBind();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void imgbrand_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            categories();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected string GetUrlLife(object name)
    {
        string catname = name.ToString();
        //catname = catname.Replace("%", "-");
        ////catname = catname.Replace("&", "-");
        if (catname.Contains("&"))
        {
            catname = catname.Replace("&", "amprcent");
        }
        if (catname.Contains(" "))
        {
            catname = catname.Replace(" ", "space");
        }
        if (catname.Contains("."))
        {
            catname = catname.Replace(".", "Dot");
        }
        if (catname.Contains("/"))
        {
            catname = catname.Replace("/", "slash");
        }
        if (catname.Contains("_"))
        {
            catname = catname.Replace("_", "undrscore");
        }
        return Page.GetRouteUrl("LifeStyle_Sub", new { cat = catname });
    }
    public void GetCategory()
    {
        try
        {

            if (Convert.ToString(Page.RouteData.Values["catname"]) != "" && Convert.ToString(Page.RouteData.Values["type"]) != "")
            {
                ////catname = catname.Replace("&", "-");
                metadata(catname);
                lblcat.Text = catname;
                qry = "select * from b2bcategories where maincat='" + catname + "'";

            }
            else if (Convert.ToString(Page.RouteData.Values["catname"]) != "")
            {
                ////catname = catname.Replace(",", "-");
                metadata(catname);
                lblcat.Text = catname;
                qry = "select * from subcatageory where maincat='" + catname + "'";
            }
            SqlDataAdapter ada = new SqlDataAdapter(qry, con);
            ada.Fill(ds);
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                dllife.DataSource = ds;
                dllife.DataBind();
            }
            else
            {
                Response.RedirectToRoute("Link", new { cname = catname });
            }

        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }

    private void metadata(string catname)
    {
        try
        {
            lblcat.Text = "Get data about " + catname + " | JustCalluz ";
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
