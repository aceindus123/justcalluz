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
using System.Collections.Specialized;
using System.Reflection;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Services;
using System.Web.Routing;

public partial class Customer_Care : System.Web.UI.Page
{
    InsertData obj = new InsertData();
    static string excep_page = "Customer_Care.aspx";
    
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                Session["city"] = txtcity.Text;
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    [System.Web.Script.Services.ScriptMethod()]
    [System.Web.Services.WebMethod(EnableSession = true)]
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
    [System.Web.Script.Services.ScriptMethod()]
    [System.Web.Services.WebMethod(EnableSession=true)]
    public static List<string> Getcompanies(string prefixText)
    {
        try
        {
            string city = HttpContext.Current.Session["city"].ToString();
            List<string> cmpnames = new List<string>();
            SqlConnection con1 = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
            con1.Open();
            SqlCommand cmpcmd = new SqlCommand("select distinct company_name,area,City from modulesdata where City='" + city + "'and company_name like @name+'%'", con1);
            cmpcmd.Parameters.AddWithValue("@name", prefixText);
            SqlDataAdapter da = new SqlDataAdapter(cmpcmd);
            DataTable dtcmp = new DataTable();
            da.Fill(dtcmp);
            for (int i = 0; i < dtcmp.Rows.Count; i++)
            {
                cmpnames.Add(dtcmp.Rows[i]["company_name"].ToString() + "(" + dtcmp.Rows[i]["area"].ToString() + ")");

            }
            return cmpnames;
        }
        catch (Exception e)
        {
            Label lblexception = new Label();
            lblexception.Text = e.Message;
            return null;
        }
        
    }


    protected void txtcity_TextChanged(object sender, EventArgs e)
    {
        try
        {
            Session["city"] = txtcity.Text;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void imggo_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            string[] args = new string[2];
            string city = txtcity.Text;
            args = txtcmp.Text.Split('(', ')');
            string cmp = args[0];
            string area = args[1];
           //redirect("customercare_details.aspx?cmpname=" + Server.UrlEncode(args[0]) + " &area=" + Server.UrlEncode(args[1]) + " &city=" + Server.UrlEncode(city),false);
            Response.RedirectToRoute("customercare", new { cmpname = args[0], area = args[1], city = city });
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
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
}
