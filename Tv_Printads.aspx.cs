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

public partial class Tv_Printads : System.Web.UI.Page
{
    AdsCS obj1 = new AdsCS();
    InsertData obj = new InsertData();
    static string excep_page = "Tv_Printads.aspx";
    string cityname = string.Empty; 
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            con.Open();
            DataSet dsad = new DataSet();
            dsad = obj1.printad_cities();
            dlpopcities.DataSource = dsad;
            dlpopcities.DataBind();
            SqlDataAdapter dadefaut = new SqlDataAdapter("select top 1(adId),PaperName,Content_Name from Ads where AdType='Print Ads' and City='Hyderabad' order by adId desc", con);
            DataSet dsdefault = new DataSet();
            dadefaut.Fill(dsdefault);
            dlpapers.DataSource = dsdefault;
            dlpapers.DataBind();
            dlads.DataSource = dsdefault;
            dlads.DataBind();
            con.Close();
            if (Request.QueryString["cityname"] != null)
            {
                cityname = Request.QueryString["cityname"].ToString();
                citieslnk();
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void citieslnk()
    {
        try
        {
            cityname = Request.QueryString["cityname"].ToString();
            Session["city"] = cityname;
            con.Open();
            DataSet dsnewpap = new DataSet();
            dsnewpap = obj1.print_paper(cityname);
            dlpapers.DataSource = dsnewpap;
            dlpapers.DataBind();
            dlads.DataSource = dsnewpap;
            dlads.DataBind();
            con.Close();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }   
    public string GetPaperAd(object PAdName)
    {
        string url = "";
        try
        {
            string paperad = Convert.ToString(PAdName);
            string city = Convert.ToString(Session["city"]);
            DataSet dspaperad = new DataSet();
            dspaperad = obj1.print_paperad(paperad, city);
            dlads.DataSource = dspaperad;
            dlads.DataBind();
            url = "../Tv_Printads.aspx";
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        return url;
    }
    
}
