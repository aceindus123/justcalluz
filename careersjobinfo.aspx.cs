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
using CallUsCareers.career;
using System.Web.Routing;

public partial class careersjobinfo : System.Web.UI.Page
{
        int id;
        InsertData obj = new InsertData();
        CareersCS Objcacs = new CareersCS();
        DataSet ds1;
        static string excep_page = "careersjobinfo.aspx";
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //if (!Page.IsPostBack)
                //{
                    if (Convert.ToString(Page.RouteData.Values["jobid"]) != "")
                    {
                        id = Convert.ToInt32(Page.RouteData.Values["jobid"].ToString());
                    }
                    dlviewjob.Visible = true;
                //}
                DataSet ds = new DataSet();
                ds = Objcacs.careersinfo(id);
                if (!ds.Tables[0].Rows.Count.Equals(0))
                {
                    string mtitle = Convert.ToString(ds.Tables[0].Rows[0]["title"]);
                    string mCity = Convert.ToString(ds.Tables[0].Rows[0]["comp_city"]);
                    metadata(mtitle,mCity);
                    dlviewjob.DataSource = ds;
                    dlviewjob.DataBind();
                }
               
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
                DateTime current = DateTime.Now;
                string id =Convert.ToString(Page.RouteData.Values["jobid"]);
                if (Convert.ToString(Page.RouteData.Values["jobid"]) != "")
                {
                    DataSet ds1 = new DataSet();
                    ds1 = Objcacs.GetJobDetails(id);
                    con.Open();
                    if (!ds1.Tables[0].Rows.Count.Equals(0))
                    {
                        string cat = ds1.Tables[0].Rows[0]["category"].ToString();
                        cat = cat.Replace("/", "and");
                        string subCat = ds1.Tables[0].Rows[0]["specialization"].ToString();
                        if (Convert.ToDateTime(ds1.Tables[0].Rows[0]["expire_date"].ToString()) >= current)
                        {
                           //redirect("careers_resumeform.aspx?jobid=" + Server.UrlEncode(id) + "&cate=" + Server.UrlEncode(cat) + "&Subcat=" + Server.UrlEncode(subCat),false);
                            Response.RedirectToRoute("Careers_ResumesForm", new { jobid = id, cate = cat, Subcat = subCat });
                        }
                        else
                        {
                            string strScript = "alert('Sorry ! job is expired');location.replace('CareersJobsInfo-" + id + "')";//location.replace('careersjobinfo.aspx?jobid=" + id + "')
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
                        }

                    }
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
    protected void metadata(string modname,string mcity)
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
