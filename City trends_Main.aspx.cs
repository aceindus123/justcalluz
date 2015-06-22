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
using JustCallUsData.Data;
using System.Collections.Generic;
using System.Web.Routing;

public partial class City_trends1_Main : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    CityTrendsCS objbds = new CityTrendsCS();
    InsertData obj = new InsertData();
    static string excep_page = "City trends_Main.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            DataSet ds = new DataSet();
            ds = objbds.bindCTPopCities();
            DlPopCities.DataSource = ds;
            DlPopCities.DataBind();
            DlPopCities1.DataSource = ds;
            DlPopCities1.DataBind();
            

            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                Session["city"] = ds.Tables[0].Rows[0]["cname"].ToString();
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
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
    protected string GetUrl(object city)
    {
        string cityName = city.ToString();
        return Page.GetRouteUrl("CityTrends_Home", new { city = cityName });
    }
}
