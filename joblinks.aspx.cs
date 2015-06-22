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
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Web.Routing;
/// <summary>
/// Binding data from the data base to Jobs homepage , Displaying rate and applying paging in the form  
/// </summary>
public partial class joblinks : System.Web.UI.Page
{
    InsertData obj = new InsertData();
    string sid = string.Empty;
    int id;
    Binddata obj1 = new Binddata();
    string city;
    DateTime current = DateTime.Now.Date;
    static string excep_page = "joblinks.aspx";
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    /// <summary>
    /// To bind the data from the database to datalist according to selected link
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            lastdate.Visible = false;
            if (Session["ciyonload"] != null)
            {
                city = Session["ciyonload"].ToString();
            }
            else
            {
                city = "Hyderabad";
            }

            //ddlPageSize.Visible = false;
            if (!IsPostBack)
            {
                BindGrid();
                lastdate_jobs();
            }
          
               // string strname = Convert.ToString(Request.QueryString["catname"]);
                string strname = Convert.ToString(Page.RouteData.Values["catname"]);
                strname = strname.Replace("and", "/");
                strname = strname.Replace("-", "+");
                strname = strname.Replace("dot", ".");
                Label10.Text = strname;
          
            
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        
    }
    
    /// <summary>
    /// //Applying paging to the form .
    /// </summary>

    PagedDataSource pds = new PagedDataSource();
    public void BindGrid()
    {
        try
        {
            //dldata.Visible = true;
            string date = current.ToShortDateString();
            string strname = string.Empty;
            //Label10.Text = Convert.ToString(Request.QueryString["cname"]);
            //strname = Convert.ToString(Session["name"]);
            //strname = Convert.ToString(Request.QueryString["catname"]);
            strname = Convert.ToString(Page.RouteData.Values["catname"]);
            strname = strname.Replace("and", "/");
            strname = strname.Replace("-", "+");
            strname = strname.Replace("dot", ".");
            SqlCommand cmd = new SqlCommand("view_job", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@city", city);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@subcat", strname);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Session["id"] = id;
            if (!ds.Tables[2].Rows.Count.Equals(0))
            {
                pds.DataSource = ds.Tables[2].DefaultView;
                pds.AllowPaging = true;
                pds.PageSize = 5;
                pds.CurrentPageIndex = CurrentPage;
                imgPrevious.Enabled = !pds.IsFirstPage;
                imgNext.Enabled = !pds.IsLastPage;
                //lnkbtnNext.Enabled = !pds.IsLastPage;
                //lnkbtnPrevious.Enabled = !pds.IsFirstPage;
                dldata.DataSource = pds;
                dldata.DataBind();
                
            }
            else
            {
                imgPrevious.Visible = false;
                imgNext.Visible = false;
                //dlPaging.Visible = false;
                lblmsg.Text = " Currently no Jobs are posted for -" + strname + "- in -" + city;
                lblmsg.CssClass = "sub_menu";
                lastdate_jobs();
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
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
    protected void lnklastdate_Click(object sender, EventArgs e)
    {
        lblmsg.Visible = false;
        DataSet dslast_jobs = new DataSet();
        dslast_jobs = lastdate_jobs();
        dldata.DataSource = dslast_jobs.Tables[1];
        dldata.DataBind();
    }
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
    protected string GetViewUrl(object jid)
    {
        string JobId = jid.ToString();
        return Page.GetRouteUrl("jobdetails", new { id = JobId, cname = "jobs" });
    }
    
 }


    

    
   



