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
using System.Web.Routing;

public partial class job_archieve : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    DateTime current = DateTime.Now;
    string city = string.Empty;
    InsertData obj = new InsertData();
    static string excep_page = "job_archieve.aspx";

    protected void Page_Load(object sender, EventArgs e)
    {
        
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
            if (!ds.Tables[3].Rows.Count.Equals(0))
            {

                dldata.DataSource = ds.Tables[3];
                dldata.DataBind();
            }
            if (!IsPostBack)
            {
                BindGrid();
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
            SqlCommand cmdpg = new SqlCommand("view_job", con);
            cmdpg.CommandType = CommandType.StoredProcedure;
            cmdpg.Parameters.AddWithValue("@city", city);
            cmdpg.Parameters.AddWithValue("@date", date);
            cmdpg.Parameters.AddWithValue("@subcat", "");
            //cmdpg.Parameters.AddWithValue("@subcat", SqlDbType.NVarChar).Value = "null";
            SqlDataAdapter da = new SqlDataAdapter(cmdpg);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = new DataTable();
            dt = ds.Tables[3];
            //Session["id"] = id;
            pds.DataSource = dt.DefaultView;
            pds.AllowPaging = true;
            pds.PageSize = 3;
            //pds.PageSize = Convert.ToInt16(ddlPageSize.SelectedValue);
            pds.CurrentPageIndex = CurrentPage;
            imgPrevious.Enabled = !pds.IsLastPage;
            imgPrevious.Enabled = !pds.IsFirstPage;
            dldata.DataSource = pds;
            dldata.DataBind();
            //doPaging();
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
    //private void doPaging()
    //{
    //    DataTable dt = new DataTable();
    //    dt.Columns.Add("PageIndex");
    //    dt.Columns.Add("PageText");
    //    for (int i = 0; i < pds.PageCount; i++)
    //    {
    //        DataRow dr = dt.NewRow();
    //        dr[0] = i;
    //        dr[1] = i + 1;
    //        dt.Rows.Add(dr);
    //    }
    //    dlPaging.DataSource = dt;
    //    dlPaging.DataBind();
    //}

    //protected void dlPaging_ItemCommand(object source, DataListCommandEventArgs e)
    //{
    //    if (e.CommandName.Equals("lnkbtnPaging"))
    //    {
    //        CurrentPage = Convert.ToInt16(e.CommandArgument.ToString());
    //        BindGrid();
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
    //protected void ddlPageSize_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    CurrentPage = 0;
    //    BindGrid();
    //}
    //protected void dlPaging_ItemDataBound(object sender, DataListItemEventArgs e)
    //{
    //    LinkButton lnkbtnPage = (LinkButton)e.Item.FindControl("lnkbtnPaging");
    //    if (lnkbtnPage.CommandArgument.ToString() == CurrentPage.ToString())
    //    {
    //        lnkbtnPage.Enabled = false;
    //        lnkbtnPage.Font.Bold = true;
    //    }
    //}
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
