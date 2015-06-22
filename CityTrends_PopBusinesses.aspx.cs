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
using System.Text.RegularExpressions;
using System.Web.Routing;

public partial class CityTrends_PopBusinesses : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    string city;
    CityTrendsCS objData = new CityTrendsCS();
    InsertData obj = new InsertData();
    static string excep_page = "CityTrends_PopBusinesses.aspx";
    string strScript = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            city = Session["city"].ToString();
            if (!IsPostBack)
            {
                BindBusinesses();
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    private void BindBusinesses()
    {
        try
        {
            city = Session["city"].ToString();
            lblCity.Text = city;
            metadata(city);
            string strcate = string.Empty;
            string strKeywords = string.Empty;
            DataSet dsBusinesses = new DataSet();
            DataSet dscate = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Categories", con);
            sda.Fill(dscate);
            dsBusinesses = objData.Get_PopBusinesses(city);
            foreach (DataRow dr in dscate.Tables[0].Rows)
            {
                foreach (DataRow dr1 in dsBusinesses.Tables[0].Rows)
                {
                    //string HlSearchString = string.Format("<a href=linkcontroller.aspx?cname=" + Server.UrlEncode(strKeywords) + ">{0}</a>", strKeywords);
                    string HlSearchString = string.Format("<a href=LinkDetails-" + Server.UrlEncode(strKeywords) + ">{0}</a>", strKeywords);
                    strcate = Convert.ToString(dr1["subTitle1"]);
                    strKeywords = Convert.ToString(dr["Category"]);

                    // create regex replace pattern and make it safe by escaping it
                    string searchPattern = string.Format("(?<find>{0})", strKeywords);
                   // string replacePattern = "<a href=linkcontroller.aspx?cname=" + Server.UrlEncode(strKeywords) + ">${find}</a>";
                    string replacePattern = "<a href=LinkDetails-" + Server.UrlEncode(strKeywords) + ">${find}</a>";

                    strcate = Regex.Replace(strcate, searchPattern, replacePattern, RegexOptions.IgnoreCase);
                    strKeywords = Regex.Replace(strKeywords, searchPattern, replacePattern, RegexOptions.IgnoreCase);
                    dr1["subTitle1"] = strcate;
                    dr["Category"] = strKeywords;
                    DlBusinesses.DataSource = dsBusinesses;
                    DlBusinesses.DataBind();
                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected string GetUrlHome(object cityname)
    {
        string city =Convert.ToString(cityname.ToString());
        return Page.GetRouteUrl("cityhome", new { city = city });
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
    protected void metadata(string modname)
    {
        try
        {
            pgtitle.Text = "Popular Businesses in " + modname + " | justcalluz";
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
