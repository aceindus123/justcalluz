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
using System.Web.Routing;

public partial class success_stories : System.Web.UI.Page
{
     SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
     SSCS obj1 = new SSCS();
     InsertData obj = new InsertData();
     static string excep_page = "success_stories.aspx";
    string type = "SSText";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string city;
            //ddlPageSize.Visible = false;
            if (!IsPostBack)
            {
                city = "Hyderabad";
                bind_relcity(city, type);
                fill_cities(type);
                metadata(city);
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    PagedDataSource pds = new PagedDataSource();
    protected void bind_relcity(string city, string type)
    {
        try
        {
            DataSet dssuccess = new DataSet();
            dssuccess = obj1.GetSS_byCity(city, type);
            metadata(city);
            if (!dssuccess.Tables[0].Rows.Count.Equals(0))
            {
                lblmsg.Visible = false;
                pds.DataSource = dssuccess.Tables[0].DefaultView;
                pds.AllowPaging = true;
                pds.PageSize = 3;
                pds.CurrentPageIndex = CurrentPage;
                imgNext.Enabled = !pds.IsLastPage;
                imgPrevious.Enabled = !pds.IsFirstPage;
                dlsuccessdata.DataSource = pds;
                dlsuccessdata.DataBind();
                //doPaging();
            }
            else
            {
                lblmsg.Text = "Sorry, no events found <br/>" + "<span class=side_menu>Suggestions :</span>Try Different Date";
                lblmsg.CssClass = "sub_menu";
                imgPrevious.Visible = false;
                imgNext.Visible = false;
                //dlPaging.Visible = false;
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
            string city = lblcity_out.Text;
            bind_relcity(city, type);
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
            string city = lblcity_out.Text;
            bind_relcity(city, type);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void fill_cities(string type)
    {
        try
        {
            DataSet dssuccess_cities = new DataSet();
            dssuccess_cities = obj1.GetSS_Fillcities(type);
            dlcity.DataSource = dssuccess_cities;
            dlcity.DataBind();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
       
    }
    
    protected void  other_cities(object sender, EventArgs e)
    {
        try
        {
            DataSet dssuccess_other_cities = new DataSet();
            dssuccess_other_cities = obj1.GetSS_Fillothcities(type);
            dlother_cities.DataSource = dssuccess_other_cities;
            dlother_cities.DataBind();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lnk_to_othcities(object sender, CommandEventArgs e)
    {
        try
        {
            string city = e.CommandArgument.ToString();
            bind_relcity(city, type);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected string lnk_to_othcities(object city)
    {
        string SCity = city.ToString();
        bind_relcity(SCity, type);
        return Page.GetRouteUrl("success");
    }
    protected void dlsuccessdata_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        try
        {
            Label lblcity = (Label)e.Item.FindControl("lblcity");
            lblcity_out.Text = lblcity.Text;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void metadata(string modname)
    {
        try
        {
            pgtitle.Text = "Client Success Stories - " + modname + " | justcalluz";
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
    protected void GetCompDetails(object sender, CommandEventArgs e)
    {
        string Cat = Convert.ToString(e.CommandArgument.ToString());
        if (Cat.Contains("&"))
        {
            Cat = Cat.Replace("&", "amp");
        }
        else
        {
            
        }
        Response.RedirectToRoute("Link", new { cname = Cat });
    }
}
