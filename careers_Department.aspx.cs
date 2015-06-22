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
using CallUsCareers.career;
using IndusAbroad.DataAccessLayer;
using System.Collections.Generic;
using System.Web.Routing;

public partial class careers_Department : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    CareersCS ccs = new CareersCS();
    InsertData obj = new InsertData();
    static string excep_page = "careers_Department.aspx";
    int Count_jobs;
   
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            DataSet ds = new DataSet();
            ds = ccs.BindCountTitles();
            if (ds.Tables[0].Rows.Count > 0)
            {
                dlCat.DataSource = ds;
                dlCat.DataBind();
            }
            else
            {
                lblError.Text = "Currently no jobs are available for this category";
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        //catch (Exception ex)
        //{
        //    lblError.Text = ex.Message;
        //}
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
    protected string GetUrl(object jcat)
    {
        string jobcat = jcat.ToString();
        jobcat = jobcat.Replace("/", "-");
        return Page.GetRouteUrl("CareersCategories", new { cat = jobcat });
    }
    
}
