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
using IndusAbroad.DataAccessLayer;
using System.Collections.Generic;
using CallUsCareers.career;
using System.Web.Routing;

public partial class Careers_Location : System.Web.UI.Page
{
    InsertData obj = new InsertData();
    CareersCS objCs = new CareersCS();
    string loc;
    int id;
    string cityname = string.Empty;
    static string excep_page = "Careers_Location.aspx";
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = objCs.Location(loc);
                dlloc.DataSource = ds;
                dlloc.DataBind();
                if (Page.RouteData.Values["cityname"] != null)
                {
                    cityname = Convert.ToString(Page.RouteData.Values["cityname"]);
                    metadata(cityname);
                    BindJobs();
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
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
   protected string GetUrlJob(object id)
   {
       string jobid = id.ToString();
       return Page.GetRouteUrl("CareersJobInfo", new { jobid = jobid });
       //string url = "";
       //try
       //{
       //    url = "careersjobinfo.aspx?jobid=" + Server.UrlEncode(id.ToString());
       //}
       //catch (Exception ex)
       //{
       //    obj.insert_exception(ex, excep_page);
       //    Response.Redirect("HttpErrorPage.aspx");
       //}
       //return url;
   }
   protected void BindJobs()
   {
       try
       {
           DataSet ds1 = new DataSet();
           ds1 = objCs.GetJobs(cityname);
           dllocation.DataSource = ds1;
           dllocation.DataBind();
       }
       catch (Exception ex)
       {
           obj.insert_exception(ex, excep_page);
           Response.Redirect("HttpErrorPage.aspx");
       }
   }
   protected string GetUrlCity(object comp_city)
   {
       string compCity = comp_city.ToString();
       return Page.GetRouteUrl("Careers", new { cityname = compCity });
   }
   protected void metadata(string modname)
   {
       try
       {
           pgtitle.Text = "Career Opportunities - " + modname + " | justcalluz";
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