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
using System.Web.Routing;

public partial class Lifestylesub : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    InsertData obj = new InsertData();
    static string excep_page = "Lifestylesub.aspx";
    string city = string.Empty;
    string id;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
                subrelated.Visible = true;
                dlsubcat.Visible = true;
                string cat = Convert.ToString(Page.RouteData.Values["cat"]);
                if (cat.Contains("amprcent"))
                {
                    cat = cat.Replace("amprcent", "&");
                }
                if (cat.Contains("space"))
                {
                    cat = cat.Replace("space", " ");
                }
                if (cat.Contains("Dot"))
                {
                    cat = cat.Replace("Dot", ".");
                }
                if (cat.Contains("slash"))
                {
                    cat = cat.Replace("slash", "/");
                }
                if (cat.Contains("undrscore"))
                {
                    cat = cat.Replace("undrscore", "_");
                }

                //string cat = Request.QueryString["cat"];
                Session["Category"] = cat;
                metadata(cat);
                //con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select SubCategeory from lifestyle where Categeory='" + cat + "' order by SubCategeory", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (!ds.Tables[0].Rows.Count.Equals(0))
                {
                    dlsubcat.DataSource = ds;
                    dlsubcat.DataBind();
                    //con.Close();

                }
                else
                    Response.RedirectToRoute("LifeStyle_home", new { cat = cat, cname = "LifeStyle" });
                //redirect("Lifestylehome.aspx?catname=" + Server.UrlEncode(cat) + "&cname=LifeStyle", false);
                // con.Close();
            }
        
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }


    }
    
    protected void linkcor_Click(object sender, EventArgs e)
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
    public string GethomeLife(object name)
    {
        string subcat = name.ToString();
        //subcat = subcat.Replace("&", "-");
        if (subcat.Contains("&"))
        {
            subcat = subcat.Replace("&", "amprcent");
        }
        if (subcat.Contains(" "))
        {
            subcat = subcat.Replace(" ", "space");
        }
        if (subcat.Contains("."))
        {
            subcat = subcat.Replace(".", "Dot");
        }
        if (subcat.Contains("/"))
        {
            subcat = subcat.Replace("/", "slash");
        }
        if (subcat.Contains("_"))
        {
            subcat = subcat.Replace("_", "undrscore");
        }
        return Page.GetRouteUrl("LifeStyle_home", new { cat = subcat, cname = "LifeStyle" });
      
    }
    //protected void metadata(string modname,string mcity)
    //{
    //    try
    //    {
    //        pgtitle.InnerText = " List of " + modname + " in " + mcity + ", India | Justcalluz";
    //        HtmlHead head = (HtmlHead)Page.Header;
    //        HtmlMeta met1 = new HtmlMeta();
    //        HtmlMeta met2 = new HtmlMeta();
    //        met1.Name = "descriptions";
    //        met1.Content = "" + modname + " in " + mcity + " Find Phone Numbers, Addresses, Best Deals, Reviews. Call 08888888888 for " + modname + " " + mcity + " and more | Justcalluz.";
    //        head.Controls.Add(met1);
    //        Header.Controls.Add(met1);
    //        met2.Name = "Keywords";
    //        met2.Content = " " + modname  +" in " + mcity + ", " + modname + " " + mcity + ", " + mcity + " " + modname + ", list of " + modname + " in " + mcity + ", " + modname + " list";
    //        head.Controls.Add(met1);
    //    }
    //    catch (Exception ex)
    //    {
           
    //    }
    //}
    protected void metadata(string modname)
    {
        try
        {
            pgtitle.InnerText = " List of " + modname + " , India | Justcalluz";
            HtmlHead head = (HtmlHead)Page.Header;
            HtmlMeta met1 = new HtmlMeta();
            HtmlMeta met2 = new HtmlMeta();
            met1.Name = "descriptions";
            met1.Content = "" + modname + " Find Phone Numbers, Addresses, Best Deals, Reviews. Call 9166136226 for " + modname + " and more | Justcalluz.";
            head.Controls.Add(met1);
            Header.Controls.Add(met1);
            met2.Name = "Keywords";
            met2.Content = " " + modname + " , " + modname + " , " + modname + ", list of " + modname + " , " + modname + " list";
            head.Controls.Add(met1);
        }
        catch (Exception ex)
        {

        }
    }
}

