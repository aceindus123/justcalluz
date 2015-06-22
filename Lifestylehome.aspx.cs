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
using System.Web.Routing;

public partial class Lifestylehome : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    string current = DateTime.Now.ToShortDateString();
    static string image;
    string city = string.Empty;
    string category = string.Empty;
    InsertData obj = new InsertData();
    PagedDataSource pds = new PagedDataSource();
    static string excep_page = "Lifestylehome.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
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
                    city = "Hyderabad";
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
            BindGrid();
        }
        //category = Request.QueryString["cat"];
        //if (Request.QueryString["cat"] != null)
        //{
        //    category = Request.QueryString["cat"];
        //    LifestyleCate.Text = category;
        //    SqlDataAdapter da = new SqlDataAdapter("select id,SubCategory,company_name,Address,City,state,land_mark,ImageName,ImageContentType,mob,emailid,city from modulesdata where SubCategory='" + category + "'and ApprovedStatus=1 order by id desc", con);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds);
        //    try
        //    {
        //        if (!ds.Tables[0].Rows.Count.Equals(0))
        //        {
        //            pds.DataSource = ds.Tables[0].DefaultView;
        //            pds.AllowPaging = true;
        //            pds.PageSize = 7;
        //            //pds.PageSize = Convert.ToInt16(ddlPageSize.SelectedValue);
        //            pds.CurrentPageIndex = CurrentPage;
        //            imgNext.Enabled = !pds.IsLastPage;
        //            imgPrevious.Enabled = !pds.IsFirstPage;
        //            dllifestyle.DataSource = ds;
        //            dllifestyle.DataBind();
        //            con.Close();
        //        }
        //        else
        //            redirect("Search-Not-Found.aspx?cname=" + Server.UrlEncode(category) + "&city=" + Server.UrlEncode(city),false);
        //    }
        //    catch (Exception ex)
        //    {
        //        obj.insert_exception(ex, excep_page);
        //        Response.Redirect("HttpErrorPage.aspx");
        //    }
        //}
        //else if (Request.QueryString["catname"] != null)
        //{
        //    try
        //    {
        //        category = Request.QueryString["catname"];
        //        LifestyleCate.Text = category;
        //        SqlDataAdapter da = new SqlDataAdapter("select id,Category,SubCategory,company_name,Address,city,state,land_mark,ImageName,ImageContentType,mob,emailid,City from modulesdata where Category='" + category + "'and ApprovedStatus=1 order by id desc", con);
        //        DataSet ds = new DataSet();
        //        da.Fill(ds);
        //        if (!ds.Tables[0].Rows.Count.Equals(0))
        //        {
        //            pds.DataSource = ds.Tables[0].DefaultView;
        //            pds.AllowPaging = true;
        //            pds.PageSize = 7;
        //            //pds.PageSize = Convert.ToInt16(ddlPageSize.SelectedValue);
        //            pds.CurrentPageIndex = CurrentPage;
        //            imgNext.Enabled = !pds.IsLastPage;
        //            imgPrevious.Enabled = !pds.IsFirstPage;
        //            dllifestyle.DataSource = ds;
        //            dllifestyle.DataBind();
        //            con.Close();
        //        }
        //        else
        //            redirect("Search-Not-Found.aspx?cname=" + Server.UrlEncode(category) + "&city=" + Server.UrlEncode(city), false);
        //    }
        //    catch (Exception ex)
        //    {
        //        obj.insert_exception(ex, excep_page);
        //        Response.Redirect("HttpErrorPage.aspx");
        //    }

        //}

        
        
        
        //DataSet ds8 = new DataSet();
        //sid = Convert.ToString(Request.QueryString["id"]);
        //ds8 = obj.postreview(sid);
        //reviewdl.DataSource = ds8;
        //reviewdl.DataBind();
    }
    public void BindGrid()
    {
        //category = Request.QueryString["cat"];
        //if (Request.QueryString["cat"] != null)
        if(Convert.ToString(Page.RouteData.Values["cat"])!="")
        {
            //category = Request.QueryString["cat"];
            category = Convert.ToString(Page.RouteData.Values["cat"]);
            LifestyleCate.Text = category;
            metadata(category);
            SqlDataAdapter da = new SqlDataAdapter("select id,SubCategory,stuff(\"company_name\", 22, len(company_name), '...') as compname,company_name,Address,City,state,land_mark,ImageName,ImageContentType,mob,emailid,city from modulesdata where SubCategory='" + category + "' and City='" + city + "' and ApprovedStatus=1 order by id desc", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            try
            {
                if (!ds.Tables[0].Rows.Count.Equals(0))
                {
                    pds.DataSource = ds.Tables[0].DefaultView;
                    pds.AllowPaging = true;
                    pds.PageSize = 10;
                    //pds.PageSize = Convert.ToInt16(ddlPageSize.SelectedValue);
                    if (ds.Tables[0].Rows.Count <= pds.PageSize)
                    {
                        pds.CurrentPageIndex = CurrentPage;
                        trPaging.Visible = false;
                        dllifestyle.DataSource = pds;
                        dllifestyle.DataBind();
                    }
                    else
                    {
                        pds.CurrentPageIndex = CurrentPage;
                        imgNext.Enabled = !pds.IsLastPage;
                        imgPrevious.Enabled = !pds.IsFirstPage;
                        dllifestyle.DataSource = pds;
                        dllifestyle.DataBind();
                    }
                    
                }
                else
                    //redirect("Search-Not-Found.aspx?cname=" + Server.UrlEncode(category) + "&city=" + Server.UrlEncode(city), false);
                    Response.RedirectToRoute("SearchResultPage", new { cname = category, city = city });
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }
        //else if (Request.QueryString["catname"] != null)
        else if (Convert.ToString(Page.RouteData.Values["catname"]) != "")
        {
            try
            {
                category = Convert.ToString(Page.RouteData.Values["catname"]);
                LifestyleCate.Text = category;
                metadata(category);
                SqlDataAdapter da = new SqlDataAdapter("select id,Category,SubCategory,stuff(\"company_name\", 22, len(company_name), '...') as compname,company_name,Address,city,state,land_mark,ImageName,ImageContentType,mob,emailid,City from modulesdata where Category='" + category + "' and City='" + city + "' and ApprovedStatus=1 order by id desc", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (!ds.Tables[0].Rows.Count.Equals(0))
                {
                    pds.DataSource = ds.Tables[0].DefaultView;
                    pds.AllowPaging = true;
                    pds.PageSize = 10;
                    //pds.PageSize = Convert.ToInt16(ddlPageSize.SelectedValue);
                    if (ds.Tables[0].Rows.Count <= pds.PageSize)
                    {
                        pds.CurrentPageIndex = CurrentPage;
                        trPaging.Visible = false;
                        dllifestyle.DataSource = pds;
                        dllifestyle.DataBind();
                    }
                    else
                    {
                        pds.CurrentPageIndex = CurrentPage;
                        imgNext.Enabled = !pds.IsLastPage;
                        imgPrevious.Enabled = !pds.IsFirstPage;
                        dllifestyle.DataSource = pds;
                        dllifestyle.DataBind();
                    }
                   
                }
                else
                    //redirect("Search-Not-Found.aspx?cname=" + Server.UrlEncode(category) + "&city=" + Server.UrlEncode(city), false);
                    Response.RedirectToRoute("SearchResultPage", new { cname = category, city = city });

            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }

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

    protected void dllifestyle_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        try
        {
            Label lblImgName = (Label)e.Item.FindControl("lblImgName");
            Image img = (Image)e.Item.FindControl("imglogo");
            HtmlTableCell colimg = (HtmlTableCell)e.Item.FindControl("tdlogo");
            try
            {
                if (lblImgName != null)
                {
                    if (lblImgName.Text == "NULL" || lblImgName.Text == "0" || lblImgName.Text == "")
                    {
                        colimg.Visible = false;

                    }
                    else
                    {
                        colimg.Visible = true;
                    }

                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }

            Label lblDataId = (Label)e.Item.FindControl("lblDataId");
            Label lblnoofratings = (Label)e.Item.FindControl("lblnoofratings");
            //Label lblImgName = (Label)e.Item.FindControl("lblImgName");


            if (lblDataId != null)
            {
                string dataId = Convert.ToString(lblDataId.Text);
                //con.Open();
                SqlCommand cmd = new SqlCommand("Select count(rid) as NumberOfUsers,sum(Stars_Rating) as Total from PostReview where dataid='" + dataId + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                float count = 0, rating = 0, result = 0;
                try
                {
                    if (Convert.ToInt32(dt.Rows[0]["NumberOfUsers"].ToString()) != 0)
                    {
                        count = float.Parse(dt.Rows[0]["NumberOfUsers"].ToString());
                        rating = float.Parse(dt.Rows[0]["Total"].ToString());
                        result = Convert.ToInt32(Math.Ceiling((rating / count) * 18));
                        //avgrating.InnerText = Math.Round((rating / count), 1).ToString();

                    }
                    else
                    {
                        //avgrating.InnerText = "0";
                    }
                    Label testSpan0 = (Label)e.Item.FindControl("testSpan0");
                    testSpan0.Style.Add("width", result + "px");
                    //testSpan0.Style.Add("width", result + "px");
                    con.Close();
                    lblnoofratings.Text = Convert.ToString(count);
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
            HyperLink hypCompName = (HyperLink)e.Item.FindControl("hypCompName");

            if (hypCompName != null)
            {
                if (hypCompName.Text == "")
                {
                    hypCompName.Text = hypCompName.ToolTip.ToString();
                }
            }
            con.Close();
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
    protected string GetLifeDetailsUrl(object lid)
    {
        string lifeId = lid.ToString();
        lifeId = lifeId.Replace("-", "&");
        return Page.GetRouteUrl("LifestyleDetails", new { id = lifeId });
    }
    protected void metadata(string modname)
    {
        try
        {
            pgtitle.InnerText = "Get the data about " + modname + " LifeStyle | Justcalluz";
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

