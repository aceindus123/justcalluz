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

public partial class careers_jobcategorylist : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    CareersCS obj1 = new CareersCS();
    PagedDataSource pds = new PagedDataSource();
    int id;
    string category = string.Empty;
    DateTime current = DateTime.Now;
    InsertData obj = new InsertData();
    static string excep_page = "careers_jobcategorylist.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            category = Convert.ToString(Page.RouteData.Values["cat"].ToString());
            if (!Page.IsPostBack)
            {
                dlcategorylist.Visible = true;
                ViewState["previouspage"] = Request.UrlReferrer;
            }
            lblcategory.Text = category;
            metadata(category);
            BindGrid();
            
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected string GetUrlJob(object jid)
    {
        string jobid = jid.ToString();
        return Page.GetRouteUrl("CareersViewJob", new { id = jobid });
    }
    protected string GetUrl(object jid)
    {
        string jobid = jid.ToString();
        return Page.GetRouteUrl("CareersRForm", new { id = jobid });
    }
    protected void ddlPageSize_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            CurrentPage = 0;
            BindGrid(Convert.ToInt32(ddlPageSize.Text));
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
    public void BindGrid()
    {
        try
        {
            SqlDataAdapter sda = new SqlDataAdapter("select *,posttime=convert(varchar,post_date, 105) from jcalluzCareers where category ='" + category + "' and expire_date>='" + current + "' order by jobid desc", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Session["id"] = id;
                pds.DataSource = ds.Tables[0].DefaultView;
                pds.AllowPaging = true;
                pds.PageSize = 5;
                pds.CurrentPageIndex = CurrentPage;
                lblCurrentPage.Text = "Page: " + (CurrentPage + 1).ToString() + " of " + pds.PageCount.ToString();
                imgNext.Enabled = !pds.IsLastPage;
                imgPrevious.Enabled = !pds.IsFirstPage;
                dlcategorylist.DataSource = pds;
                dlcategorylist.DataBind();
            }
            else
            {
                lblMessage.Visible = true;
                lblMessage.Text = "No jobs are available for " + category + "";
                lblMessage.CssClass = "sub_menu";
                trpagesize.Visible = false;
                trpaging.Visible = false;
                trline.Visible = false;
                trcat.Visible = false;
                trcate.Visible = false;
            }
            //doPaging();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    public void BindGrid(int size)
    {
        try
        {
            SqlDataAdapter sda = new SqlDataAdapter("select *,posttime=convert(varchar,post_date, 105) from jcalluzCareers where category ='" + category + "' and expire_date>='" + current + "' order by jobid desc", con);
            DataSet ds1= new DataSet();
            sda.Fill(ds1);
            if (ds1.Tables[0].Rows.Count > 0)
            {
                Session["id"] = id;
                pds.DataSource = ds1.Tables[0].DefaultView;
                pds.AllowPaging = true;
                pds.PageSize = size;
                pds.CurrentPageIndex = CurrentPage;
                lblCurrentPage.Text = "Page: " + (CurrentPage + 1).ToString() + " of " + pds.PageCount.ToString();
                imgNext.Enabled = !pds.IsLastPage;
                imgPrevious.Enabled = !pds.IsFirstPage;
                dlcategorylist.DataSource = pds;
                dlcategorylist.DataBind();
            }
            else
            {
                lblMessage.Visible = true;
                lblMessage.Text = "No jobs are available for " + category + "";
                lblMessage.CssClass = "sub_menu";
                trpagesize.Visible = false;
                trpaging.Visible = false;
                trline.Visible = false;
                trcat.Visible = false;
                trcate.Visible = false;
            }
            //doPaging();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lnkTitle_Click(object sender, EventArgs e)
    {
        try
        {
            con.Open();
            DataSet dstitle = new DataSet();
            dstitle = obj1.getTitleOrder(category,current);
            dlcategorylist.DataSource = dstitle;
            dlcategorylist.DataBind();
            con.Close();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lnkJobType_Click(object sender, EventArgs e)
    {
        try
        {
            con.Open();
            DataSet dsJtype = new DataSet();
            dsJtype = obj1.getJTypeOrder(category,current);
            dlcategorylist.DataSource = dsJtype;
            dlcategorylist.DataBind();
            con.Close();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lnkJobStatus_Click(object sender, EventArgs e)
    {
        try
        {
            con.Open();
            DataSet dsstatus = new DataSet();
            dsstatus = obj1.getJStatusOrder(category,current);
            dlcategorylist.DataSource = dsstatus;
            dlcategorylist.DataBind();
            con.Close();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lnkSalaryRange_Click(object sender, EventArgs e)
    {
        try
        {
            con.Open();
            DataSet dssalary = new DataSet();
            dssalary = obj1.getSalRangeOrder(category,current);
            dlcategorylist.DataSource = dssalary;
            dlcategorylist.DataBind();
            con.Close();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lnkDatePosted_Click(object sender, EventArgs e)
    {
        try
        {
            con.Open();
            DataSet dsPdate = new DataSet();
            dsPdate = obj1.getPDateOrder(category,current);
            dlcategorylist.DataSource = dsPdate;
            dlcategorylist.DataBind();
            con.Close();
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
    protected void metadata(string modname)
    {
        try
        {
            pgtitle.Text = "Openings in " + modname + " | justcalluz";
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