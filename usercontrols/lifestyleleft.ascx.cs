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

public partial class usercontrols_lifestyleleft : System.Web.UI.UserControl
{
    InsertData obj = new InsertData();
    static string excep_page = "lifestyleleft.ascx";
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                dlcat.Visible = false; ;
                //if (Request.QueryString["cat"] != null)
                if (Convert.ToString(Page.RouteData.Values["cat"]) != "")
                {
                    string cat = Convert.ToString(Session["Category"]);
                    left_life.Visible = true;
                    DataSet ds1 = new DataSet();
                    //SqlCommand cmd = new SqlCommand("lifestyle_leftUcSp", con);
                    //cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@Categeory", cat);
                    ds1 = obj.bindlifeleft(cat);
                    //SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    //sda.Fill(ds1);
                    left_life.DataSource = ds1;
                    left_life.DataBind();
                }
                //else if (Request.QueryString["catname"] != null)
                else if(Convert.ToString(Page.RouteData.Values["catname"]) != "")
                {
                    leftlife();
                }
                //else if (Request.QueryString["cname"] != null)
                else if (Convert.ToString(Page.RouteData.Values["cname"]) != "")
                {

                    leftlife();
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }
    


    }
    //protected void left_life_ItemCommand(object source, DataListCommandEventArgs e)
    //{
    //    try
    //    {
    //        string name = "";
    //        name = e.CommandArgument.ToString();
    //        //redirect("LifeStyle_Link.aspx?cname=" + name,false);
    //        //redirect("LifeStyle_Link.aspx?Lcatname=" + Server.UrlEncode(name) + "&cname=LifeStyle", false);
    //        Response.RedirectToRoute("Life_link", new { Lcatname = name, cname = "LifeStyle" });
              
    //    }
    //    catch (Exception ex)
    //    {
    //        obj.insert_exception(ex, excep_page);
    //        Response.Redirect("HttpErrorPage.aspx");
    //    }

    //}
    protected void leftlife()
    {
        try
        {
            string cat = Convert.ToString(Session["Category"]);

            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
            SqlDataAdapter da = new SqlDataAdapter("select distinct Category,SubCategory,catsub from modulesdata where module='LifeStyle' and SubCategory='" + cat + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                string catg = ds.Tables[0].Rows[0]["Category"].ToString();
                SqlDataAdapter da1 = new SqlDataAdapter("select distinct Categeory,stuff(\"CatSub\", 22, len(CatSub), '...') as catSname,CatSub from LifeStyle where Categeory='" + catg + "'", con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                left_life.Visible = true;
                dlcat.Visible = false;
                left_life.DataSource = ds1;
                left_life.DataBind();

            }
            else
            {
                left_life.Visible = false;
                SqlDataAdapter da1 = new SqlDataAdapter("select distinct stuff(\"Categeory\", 22, len(Categeory), '...') as LCategory,Categeory from LifeStyle", con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                dlcat.Visible = true;
                dlcat.DataSource = ds1;
                dlcat.DataBind();
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    //protected void dlcat_ItemCommand(object source, DataListCommandEventArgs e)
    //{
    //    try
    //    {
    //        string name = "";
    //        name = e.CommandArgument.ToString();
    //        Response.RedirectToRoute("LifeStyle_Sub", new { cat = name });
    //        //redirect("LifeStylesub.aspx?cat=" + name,false);
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
    protected void left_life_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        HyperLink lnkleftlife = (HyperLink)e.Item.FindControl("lnkleftlife");

        if (lnkleftlife != null)
        {
            if (lnkleftlife.Text == "")
            {
                lnkleftlife.Text = lnkleftlife.ToolTip.ToString();
            }
        }
    }
    protected void dlcat_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        HyperLink lnkcatlife = (HyperLink)e.Item.FindControl("lnkcatlife");

        if (lnkcatlife != null)
        {
            if (lnkcatlife.Text == "")
            {
                lnkcatlife.Text = lnkcatlife.ToolTip.ToString();
            }
        }

    }
    protected string GetCatSub(object catsub)
    {
        string LcatSub = catsub.ToString();
        //LcatSub = LcatSub.Replace("&", "-");
        if (LcatSub.Contains("&"))
                {
                    LcatSub = LcatSub.Replace("&", "amprcent");
                }
                if (LcatSub.Contains(" "))
                {
                   LcatSub = LcatSub.Replace(" ", "space");
                }
                if (LcatSub.Contains("."))
                {
                   LcatSub = LcatSub.Replace(".", "Dot");
                }
                if (LcatSub.Contains("/"))
                {
                   LcatSub = LcatSub.Replace("/", "slash");
                }
                if (LcatSub.Contains("_"))
                {
                    LcatSub = LcatSub.Replace("_", "undrscore");
                }
               
                 return Page.GetRouteUrl("Life_link", new { Lcatname = LcatSub, cname = "LifeStyle" });
    }
    protected string GetCate(object LCat)
    {
        string Cat = LCat.ToString();
        return Page.GetRouteUrl("LifeStyle_Sub", new { cat = Cat });
    }

}
