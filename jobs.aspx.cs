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
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Text;
using System.Web.Services;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Web.Routing;
/// <summary>
/// Binding data from the data base to Jobs homepage , Displaying rate and applying paging in the form  
/// </summary>
public partial class _jobs : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    DateTime current = DateTime.Now;
    InsertData obj = new InsertData();
    string sid = string.Empty;
    string city;
    int id;
    DataRow dr;
    Binddata obj1 = new Binddata();
    static string excep_page = "jobs.aspx";
    /// <summary>
    /// To bind the data from the database to datalist
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
   {
        try
        {
            //pnlreportabuse.Visible = false;
            lastdate.Visible = false;
            Session["searchpg"] = "jobs";
            if (Convert.ToString(Page.RouteData.Values["city"]) != "")
            {
                city = Convert.ToString(Page.RouteData.Values["city"]);
            }
            else if (Convert.ToString(Session["ciyonload"]) != "")
            {
                city = Convert.ToString(Session["ciyonload"]);
            }
            else
            {
                city = "Hyderabad";
            }
            if (!Page.IsPostBack)
            {
                dldata.Visible = true;
                ViewState["previouspage"] = Request.UrlReferrer;
            }
           // con.Open();
            string date = current.ToShortDateString();
            SqlCommand cmd = new SqlCommand("view_job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@city", city);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@subcat", "");
            //cmd.Parameters.AddWithValue("@subcat", SqlDbType.NVarChar).Value = "null";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
           // con.Close();
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {

                dldata.DataSource = ds.Tables[0];
                dldata.DataBind();

            }
            else
            {
                lblnotfound.Text = "Currently No Jobs are posted in " + city;
                imgPrevious.Visible = false;
                imgNext.Visible = false;
                lblnotfound.CssClass = "sub_menu";
            }

            if (!IsPostBack)
            {
                BindGrid();
                lastdate_jobs();
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
   }
    /// <summary>
    /// // Applying paging to the form
    /// </summary>
    PagedDataSource pds = new PagedDataSource();
    public void BindGrid()
    {
        try
        {
            string date = current.ToShortDateString();
           // con.Open();
            SqlCommand cmdpg = new SqlCommand("view_job", con);
            cmdpg.CommandType = CommandType.StoredProcedure;
            cmdpg.Parameters.AddWithValue("@city", city);
            cmdpg.Parameters.AddWithValue("@date", date);
            cmdpg.Parameters.AddWithValue("@subcat", "");
            //cmdpg.Parameters.AddWithValue("@subcat", SqlDbType.NVarChar).Value = "null";
            SqlDataAdapter da = new SqlDataAdapter(cmdpg);
           // DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);
            //con.Close();
            Session["id"] = id;
            pds.DataSource = ds.Tables[0].DefaultView;
            pds.AllowPaging = true;
            pds.PageSize = 10;
            if (ds.Tables[0].Rows.Count <= pds.PageSize)
            {
                //pds.PageSize = Convert.ToInt16(ddlPageSize.SelectedValue);
                pds.CurrentPageIndex = CurrentPage;
                tblPaging.Visible = false;
                dldata.DataSource = pds;
                dldata.DataBind();
            }
            else
            {
                pds.CurrentPageIndex = CurrentPage;
                tblPaging.Visible = true;
                imgPrevious.Enabled = !pds.IsFirstPage;
                imgNext.Enabled = !pds.IsLastPage;
                dldata.DataSource = pds;
                dldata.DataBind();
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    /// To put the current page status
    /// </summary>
    public int CurrentPage
    {
        get
        {
            if (this.ViewState["CurrentPage"] == null)
                return 0;
            else
                return Convert.ToInt16(this.ViewState["CurrentPage"].ToString());
        }
        set
        {
            this.ViewState["CurrentPage"] = value;
        }
    }
    /// <summary>
    /// Functionality of the job for which today is the lastdate to apply
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnklastdate_Click(object sender, EventArgs e)
    {
        try
        {
            DataSet dslast_jobs = new DataSet();
            dslast_jobs = lastdate_jobs();
            dldata.DataSource = dslast_jobs.Tables[1];
            dldata.DataBind();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    /// Function called to display lastdated jobs 
    /// </summary>
    /// <returns></returns>
    public DataSet lastdate_jobs()
    {
        DataSet ds = new DataSet();
        try
        {
            string date = current.ToShortDateString();
            SqlCommand cmdpglast = new SqlCommand("view_job", con);
            cmdpglast.CommandType = CommandType.StoredProcedure;
            cmdpglast.Parameters.AddWithValue("@city", city);
            cmdpglast.Parameters.AddWithValue("@date", date);
            cmdpglast.Parameters.AddWithValue("@subcat", "");
            //cmdpglast.Parameters.AddWithValue("@subcat", SqlDbType.NVarChar).Value = "null";
            SqlDataAdapter da = new SqlDataAdapter(cmdpglast);
            da.Fill(ds);
            if (!ds.Tables[1].Rows.Count.Equals(0))
            {
                lastdate.Visible = true;

            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        return ds;


    }
    /// <summary>
    /// service method to get city through autocomplete extender
    /// </summary>
    /// <param name="prefixText"></param>
    /// <returns></returns>
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
    /// <summary>
    /// Functionality for job archieve
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    //protected void lnkarchieve_Click(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        con.Open();
    //        string date = current.ToShortDateString();
    //        SqlCommand cmd = new SqlCommand("view_job", con);
    //        cmd.CommandType = CommandType.StoredProcedure;
    //        cmd.Parameters.AddWithValue("@city", city);
    //        cmd.Parameters.AddWithValue("@date", date);
    //        cmd.Parameters.AddWithValue("@subcat", "");
    //        //cmd.Parameters.AddWithValue("@subcat", SqlDbType.NVarChar).Value = "null";
    //        SqlDataAdapter da = new SqlDataAdapter(cmd);
    //        DataSet ds = new DataSet();
    //        da.Fill(ds);
    //        con.Close();
    //        if (!ds.Tables[0].Rows.Count.Equals(0))
    //        {

    //            dldata.DataSource = ds.Tables[3];
    //            dldata.DataBind();
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        obj.insert_exception(ex, excep_page);
    //        //Response.Redirect("HttpErrorPage.aspx");
    //    }
    //}

    protected void imgPrevious_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            CurrentPage -= 1;
            BindGrid();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void imgNext_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            CurrentPage += 1;
            BindGrid();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected string GetUrl(object jid)
    {
        string jobid = jid.ToString();
        return Page.GetRouteUrl("jobdetails", new { id = jobid, cname = "jobs" });
    }
}
  

    
    
