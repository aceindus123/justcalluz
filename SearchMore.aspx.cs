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
public partial class SearchMore : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    //string catnames;
    //string catnamesHead;
   
    string catname1;
    string catname2;
    string catname3;
    string qry;
    int i = 0;
    string type;
    InsertData obj = new InsertData();
    string maincat = string.Empty;
    string returncattype = string.Empty;
    static string excep_page = "SearchMore.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        //try
        //{

            catname1 = Convert.ToString(Page.RouteData.Values["cat1"]);
            //GetCategory(catname1, dlcat1);
            catname2 = Convert.ToString(Page.RouteData.Values["cat2"]);
            //GetCategory(catname2, dlcat2);
            catname3 = Convert.ToString(Page.RouteData.Values["cat3"]);
            //GetCategory(catname3, dlcat3);
            ////catname1 = catname1.Replace(",", "-");
            ////catname2 = catname2.Replace(",", "-");
            ////catname3 = catname3.Replace(",", "-");
            if (catname2 == "null")
                GetCategory(catname1, dlcat1);
            else if (catname3 == "null")
                GetCategory(catname1+"','" + catname2, dlcat1);
            else
                GetCategory(catname1 +"','" + catname2 +"','" +catname3, dlcat1);
            //catname = catname.Replace("&", "-");
            //lblcat.Text = catname;
           
             maincat = Convert.ToString(Page.RouteData.Values["maincat"]);
           
            lblcat.Text = maincat;
            metadata(maincat);
        //}
        //catch (Exception ex)
        //{
        //    obj.insert_exception(ex, excep_page);
        //    Response.Redirect("HttpErrorPage.aspx");
        //}
    }
    public void GetCategory(string catname, DataList dl)
    {
        Session["maincat"] = catname;
        
        try
        {

            //if (catname != "" && Convert.ToString(Page.RouteData.Values["type"]) != "")
            //{
            //    catname = catname.Replace("-", ",");
            //    //metadata(catname);
            //    //lblcat.Text = catname;
            //    qry = "select * from b2bcategories where maincat='" + catname + "'";
            //    binddatalist(catname, qry, dl);
            //}
            //else 
            if (catname != "")
            {
                //++i;
                //switch (i)
                //{
                //    case 1: Label1.Text = "  "+ catname+"  ";
                //        break;
                //    case 2: Label2.Text = "  " + catname + "  ";
                //        break;
                //    case 3: Label3.Text = "  " + catname + "  ";
                //        break;
                //}
               
                //metadata(catname);
               // lblcat.Text += catname + " ,";
                //catnamesHead = catname;
                qry = "select distinct(LTrim(cat))cat from subcatageory where maincat in ('" + catname + "') order by cat asc";
                binddatalist(catname, qry, dl);               

            }
            //else if (catname == "null")
            //{
            //    //dlcat3.Visible = false;
            //}

           // catnames += catname + " ,";            
            
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        
    }    
    public void binddatalist(string catname,string query,DataList dl)
    {
        DataSet ds = new DataSet();
        SqlDataAdapter ada = new SqlDataAdapter(query, con);
        ada.Fill(ds);
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            dl.DataSource = ds;
            dl.DataBind();
        }
        else
        {
            returncattype = "null";
            maincat = Convert.ToString(Session["maincat"]);
           // Response.RedirectToRoute("Link", new { cname = catname });
            Response.RedirectToRoute("Link_popcate", new { popcate = catname, pcname = maincat, cattype = returncattype });
        }
    }
    protected string GetUrl(object mcat)
    {
        maincat = Convert.ToString(Session["maincat"]);
        string Cat = mcat.ToString();

        Cat = obj.ReplaceSpecialchars(Cat);
        //if (catname1.Contains("."))
        //{
        //    catname1 = catname1.Replace(".", "Dot");
        //}
        //if (catname1.Contains("/"))
        //{
        //    catname1 = catname1.Replace("/", "slash");
        //}
        //if (catname1.Contains("_"))
        //{
        //    catname1 = catname1.Replace("_", "undrscore");
        //}

        //if (Cat.Contains("&"))
        //{
        //    Cat = Cat.Replace("&", "amprcent");
        //}
        //if (Cat.Contains(" "))
        //{
        //    Cat = Cat.Replace(" ", "space");
        //}
        //if (catname2.Contains("."))
        //{
        //    catname2 = catname2.Replace(".", "Dot");
        //}
        //if (catname2.Contains("/"))
        //{
        //    catname2 = catname2.Replace("/", "slash");
        //}
        //if (catname2.Contains("_"))
        //{
        //    catname2 = catname2.Replace("_", "undrscore");
        //}

        //if (Cat.Contains("&"))
        //{
        //    Cat = Cat.Replace("&", "amprcent");
        //}
        //if (Cat.Contains(" "))
        //{
        //    Cat = Cat.Replace(" ", "space");
        //}
        //if (catname3.Contains("."))
        //{
        //    catname3 = catname3.Replace(".", "Dot");
        //}
        //if (catname3.Contains("/"))
        //{
        //    catname3 = catname3.Replace("/", "slash");
        //}
        //if (catname3.Contains("_"))
        //{
        //    catname3 = catname3.Replace("_", "undrscore");
        //}
         //Cat = Cat.Replace("&", "-");
       // return Page.GetRouteUrl("Link", new { cname = Cat });
        returncattype = "null";
        return Page.GetRouteUrl("Link_popcate", new { popcate = Cat, pcname = maincat, cattype = returncattype });

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