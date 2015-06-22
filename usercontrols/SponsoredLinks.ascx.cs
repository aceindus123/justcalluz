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

public partial class usercontrols_SponsoredLinks : System.Web.UI.UserControl
{
    string module=string.Empty;
    //string othermodule = string.Empty;
    InsertData obj = new InsertData();
    DataSet ds1,ds2,ds3,ds4 = new DataSet();
    static string excep_page;
    protected void Page_Load(object sender, EventArgs e)
    {
        ViewState["previouspage"] = Request.UrlReferrer;
        try
        {

            //if (Request.QueryString["cname"] != null)
            if (Convert.ToString(Page.RouteData.Values["searchcname"]) != "" && Convert.ToString(Page.RouteData.Values["searchcname"]) != null)
            {
                if (Convert.ToString(Session["mod"]) != "" && Convert.ToString(Session["mod"]) != null)
                {
                    module = Convert.ToString(Session["mod"]);
                    module = obj.ReplaceCatnamewithorginalchars(module);
                    excep_page = "SponseredLinks in" + module + " module";
                    //module = Request.QueryString["cname"].ToString();
                    getad1(module);

                }
            }
            else if (Convert.ToString(Page.RouteData.Values["cname"]) != "" && Convert.ToString(Page.RouteData.Values["cname"]) != null)
            {
                module = Convert.ToString(Page.RouteData.Values["cname"]);
                module = obj.ReplaceCatnamewithorginalchars(module);
                excep_page = "SponseredLinks in" + module + " module";
                //module = Request.QueryString["cname"].ToString();
                getad(module);


            }
            else if (Convert.ToString(Page.RouteData.Values["rname"]) != "" && Convert.ToString(Page.RouteData.Values["rname"]) != null)
            {
                module = Convert.ToString(Page.RouteData.Values["rname"]);
                module = obj.ReplaceCatnamewithorginalchars(module);
                excep_page = "SponseredLinks in" + module + " module";
                //module = Request.QueryString["cname"].ToString();
                getad(module);

            }
            else if (Convert.ToString(Page.RouteData.Values["pcname"]) != "" && Convert.ToString(Page.RouteData.Values["pcname"]) != null)
            {
                module = Convert.ToString(Page.RouteData.Values["pcname"]);
                module = obj.ReplaceCatnamewithorginalchars(module);
                excep_page = "SponseredLinks in" + module + " module";
                //module = Request.QueryString["cname"].ToString();
                getad(module);

            }
            else if (Convert.ToString(Page.RouteData.Values["pageid"]) != "" && Convert.ToString(Page.RouteData.Values["pageid"]) != null)
            {
                module = Convert.ToString(Page.RouteData.Values["pageid"]);
                getad(module);
                //ds2 = obj.bindsponseredlinks(othermodule);
                excep_page = "SponseredLinks in" + module + " module";
            }
            //else if (Convert.ToString(Page.RouteData.Values["rcname"]) != "" && Convert.ToString(Page.RouteData.Values["rcname"]) != null)
            //{
            //    module = Convert.ToString(Page.RouteData.Values["rcname"]);
            //    //ds2 = obj.bindsponseredlinks(othermodule);
            //    getad(module);
            //    excep_page = "SponseredLinks in" + module + " module";
            //}
            else if (Convert.ToString(Page.RouteData.Values["cat"]) != "" && Convert.ToString(Page.RouteData.Values["cat"]) != null)
            {
                module = Convert.ToString(Page.RouteData.Values["cat"]);
                getad(module);
                excep_page = "SponseredLinks in" + module + " module";
            }

            else
            {
                excep_page = "SponseredLinks usercontrol";
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

        
    }
    protected void getad1(string module)
    {
        ds1 = obj.get_sponser1(module);
        if (!ds1.Tables[0].Rows.Count.Equals(0))
        {
            string cat = ds1.Tables[0].Rows[0]["maincat"].ToString();
            bindrightmenu(cat);
        }
        else
        {
            bindrightmenu(module);
        }
    }
    protected void getad(string module)
    {
         ds1 = obj.get_sponser(module);
         if (!ds1.Tables[0].Rows.Count.Equals(0))
         {
             string cat = ds1.Tables[0].Rows[0]["maincat"].ToString();
             bindrightmenu(cat);
         }
         else
         {
             bindrightmenu(module);
         }
    }
    void bindrightmenu(string cat)
    {
        ds2 = obj.bindsponseredlinks(cat);
        ds3 = obj.bindbannerads(cat);
        if (!ds3.Tables[0].Rows.Count.Equals(0))
        {
            dlbanners.Visible = true;
            dlbanners.DataSource = ds3;
            dlbanners.DataBind();
        }
        else
        {
            dlbanners.Visible = false;
        }
        if (!ds2.Tables[0].Rows.Count.Equals(0))
        {
            dlsponsoredlinks.Visible = true;
            dlsponsoredlinks.DataSource = ds2;
            dlsponsoredlinks.DataBind();

        }
        else
        {
            dlsponsoredlinks.Visible = false;
        }
    }
}
