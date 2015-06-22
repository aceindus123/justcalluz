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
using System.Collections.Generic;
using System.Web.Routing;

public partial class viewjob : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    int id;
    DateTime current = DateTime.Now;
    DataSet ds = new DataSet();
    CareersCS ViewJob = new CareersCS();
    InsertData obj = new InsertData();
    static string excep_page = "careers_viewjob.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            id = Convert.ToInt32(Page.RouteData.Values["id"].ToString());
            ds = ViewJob.careersinfo(id);
            string mtitle = Convert.ToString(ds.Tables[0].Rows[0]["title"]);
            string mCity = Convert.ToString(ds.Tables[0].Rows[0]["comp_city"]);
            metadata(mtitle, mCity);
            dlviewjob.DataSource = ds;
            dlviewjob.DataBind();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void btnapply_Click1(object sender, ImageClickEventArgs e)
    {
        try
        {
            string id1 = Convert.ToString(Page.RouteData.Values["id"].ToString());
            DataSet ds1 = new DataSet();
            ds1 = ViewJob.GetJobDetails(id1);
            if (!ds1.Tables[0].Rows.Count.Equals(0))
            {
                if (Convert.ToDateTime(ds1.Tables[0].Rows[0]["expire_date"].ToString()) >= current)
                {
                    //redirect("careers_resumeform.aspx?id=" + id1 + "",false);
                    Response.RedirectToRoute("CareersRForm", new { id = id1 });
                }
                else
                {
                    string strScript = "";
                    strScript = "alert('Sorry ! Job is expired');location.replace('CareersViewJob-" + id1 + "')";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lnkcatelist_Click(object sender, EventArgs e)
    {
        try
        {
            string id2 = Convert.ToString(Page.RouteData.Values["id"].ToString());
            DataSet ds2 = new DataSet();
            ds2 = ViewJob.GetJobDetails(id2);
            if (!ds2.Tables[0].Rows.Count.Equals(0))
            {
                string cat = ds2.Tables[0].Rows[0]["category"].ToString();
                Response.RedirectToRoute("CareersCategories", new { cat = cat });
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
    protected void metadata(string modname, string mcity)
    {
        try
        {
            pgtitle.Text = "" + modname + " in " + mcity + " | justcalluz";
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
