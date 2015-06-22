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
using System.Collections.Specialized;
using System.Reflection;
using System.Collections.Generic;
using JustCallUsData.Data;
using System.Net;
using System.Net.NetworkInformation;
using System.Web.Routing;

public partial class linkresults : System.Web.UI.Page
{
    //To make connection
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    InsertData obj = new InsertData();
    DataCS data_obj = new DataCS();
    DataSet dsadv_search = new DataSet();
    string city;
    string mod = string.Empty;
    string pageid = string.Empty;
    string pid = string.Empty;
    string AdvSearch = string.Empty;
    string DataId = string.Empty;
    static string excep_page = "linkresults.aspx";
    PagedDataSource pds = new PagedDataSource();
    /// <summary>
    /// Executes whenever page loads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        //ddlPageSize.Visible = false;
        try
        {
            if (!IsPostBack)
            {
                if (Convert.ToString(Page.RouteData.Values["pageid"]) != "")
                {
                    pageid = Convert.ToString(Page.RouteData.Values["pageid"].ToString());
                    if (pageid == "adv_search")
                    {
                        Session["Pid"] = pageid;
                        metadata(pageid);
                        advanced_search();
                    }
                    else if (pageid == "Hotels")
                    {
                        Session["Pid"] = pageid;
                        metadata(pageid);
                        search_hotel();
                    }
                }
                else
                {
                    BindGrid();
                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    PagedDataSource Page1 = new PagedDataSource();
    public void BindGrid()
    {
        string strcat = string.Empty;
        string strcname = string.Empty;
        try
        {
            if (Session["Searchcat"] == "")
            {
                strcat = Convert.ToString(Page.RouteData.Values["searchcname"]);
                //strcat = strcat.Replace("-", " ");
                //strcat = strcat.Replace("Dot", ".");
                //strcat = strcat.Replace("-", "/");
                //strcat = strcat.Replace("-", "_");
                //strcat = strcat.Replace("-", "%20");
                strcat = obj.ReplaceCatnamewithorginalchars(strcat);
                metadata(strcat);
            }
            else
            {
                strcat = Convert.ToString(Session["Searchcat"]);
                metadata(strcat);
            }
            if (Session["searchcname"] != "")
            {
                strcname = Convert.ToString(Session["searchcname"]);
                //strcname = strcname.Replace("-", " ");
                //strcname = strcname.Replace("Dot", ".");
                //strcname = strcname.Replace("-", "/");
                //strcname = strcname.Replace("-", "_");
                //strcname = strcname.Replace("-", "%20");
                strcname = obj.ReplaceCatnamewithorginalchars(strcname);
                metadata(strcname);
            }
            else
            {
                strcname = Convert.ToString(Page.RouteData.Values["searchcname"]);
                //strcname = strcname.Replace("-", " ");
                //strcname = strcname.Replace("Dot", ".");
                //strcname = strcname.Replace("-", "/");
                //strcname = strcname.Replace("-", "_");
                //strcname = strcname.Replace("-", "%20");

                strcname = obj.ReplaceCatnamewithorginalchars(strcname);
                metadata(strcname);
            }
            if (Session["city"] != null)
            {
                city =  Convert.ToString(Session["city"]);
            }
            else
            {
                city = Convert.ToString(Page.RouteData.Values["city"]);

            }
            if (strcat == "")//null
            {
                Label10.Text = strcname;
            }
            else
            {
                Label10.Text = strcat;
            }
            Label11.Text = strcat;
            Label12.Text = city;
            string strarea = string.Empty;
            if (Session["area"] != "")
            {
                strarea =  Convert.ToString(Session["area"]);
            }
            if (strcat != "" && strcname != "")//null
            {

                if (strarea!="")//null
                {
                    try
                    {
                        DataSet ds = new DataSet();
                        //SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);

                        SqlDataAdapter da = new SqlDataAdapter("select *,stuff(\"company_name\", 22, len(company_name), '...') as compname from ModulesData where ((Category like ('%" + strcat + "%')) or (module like ('%" + strcat + "%')) or (SubCategory like '%" + strcat + "%' ) or (company_name like '%" + strcat + "%')) and City='" + city + "' and area like ('%" + strarea + "%') and (module='Category' or module='B2BCategory' or module='FreeListing' or module='LifeStyle') and ApprovedStatus='1' order by id desc ", con);
                        //if (Session["sss"] == null)
                        //{
                        da.Fill(ds, "data");
                        //}
                        //else
                        //{
                        //    ds = (DataSet)Session["sss"];
                        //}     
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            Session["mod"] = ds.Tables[0].Rows[0]["module"].ToString();
                            mod = ds.Tables[0].Rows[0]["module"].ToString();
                            Page1.AllowPaging = true;//page object store the datasource of datalist..
                            Page1.DataSource = ds.Tables[0].DefaultView;
                            Page1.PageSize = 10;
                            //"CurrentPage" is global variable that content the current page index..
                            if (ds.Tables[0].Rows.Count <= Page1.PageSize)
                            {
                                Page1.CurrentPageIndex = CurrentPage;
                                dlSearchResults.DataSource = Page1;
                                dlSearchResults.DataKeyField = "id";
                                dlSearchResults.DataBind();
                                //now datalist only show the a images...  
                                //due to "Page.PageSize = 8;" statement...//visible true or false of next and previous button//according to last and first page...
                                trPaging.Visible = false;
                            }
                            else
                            {
                                Page1.CurrentPageIndex = CurrentPage;
                                dlSearchResults.DataSource = Page1;
                                dlSearchResults.DataKeyField = "id";
                                dlSearchResults.DataBind();
                                //now datalist only show the a images...  
                                //due to "Page.PageSize = 8;" statement...//visible true or false of next and previous button//according to last and first page...
                                trPaging.Visible = true;
                                imgNext.Enabled = !Page1.IsLastPage;
                                imgPrevious.Enabled = !Page1.IsFirstPage;
                            }
                        }
                        else
                        {
                            strcat = obj.ReplaceSpecialchars(strcat);
                            //redirect("Search-Not-Found.aspx?cname=" + Server.UrlEncode(strcat) + "&city=" + Server.UrlEncode(city),false);
                            Response.RedirectToRoute("SearchResultPage", new { cname = strcat, city = city });
                        }
                       
                    }
                    catch (Exception ex)
                    {
                        obj.insert_exception(ex, excep_page);
                        Response.Redirect("HttpErrorPage.aspx");
                    }
                }
                else if (strarea=="")//null
                {
                    try
                    {
                        DataSet ds = new DataSet();
                        //SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                        SqlDataAdapter da = new SqlDataAdapter("select *,stuff(\"company_name\", 22, len(company_name), '...') as compname from ModulesData where ((Category like ('%" + strcat + "%')) or (module like ('%" + strcat + "%')) or (SubCategory like '%" + strcat + "%' ) or (company_name like '%" + strcat + "%')) and City='" + city + "' and (module='Category' or module='B2BCategory' or module='FreeListing' or module='LifeStyle') and ApprovedStatus=1", con);

                        //if (Session["sss"] == null)
                        //{
                        da.Fill(ds, "data");

                        //}
                        //else 
                        //{
                        //    ds = (DataSet)Session["sss"];
                        //}               
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            Session["mod"] = ds.Tables[0].Rows[0]["module"].ToString();
                            mod = ds.Tables[0].Rows[0]["module"].ToString();

                            Page1.AllowPaging = true;//page object store the datasource of datalist..
                            Page1.DataSource = ds.Tables[0].DefaultView;
                            Page1.PageSize = 10;
                            //"CurrentPage" is global variable that content the current page index..
                            if (ds.Tables[0].Rows.Count <= Page1.PageSize)
                            {
                                Page1.CurrentPageIndex = CurrentPage;
                                dlSearchResults.DataSource = Page1;
                                dlSearchResults.DataKeyField = "id";
                                dlSearchResults.DataBind();
                                //now datalist only show the a images...  
                                //due to "Page.PageSize = 8;" statement...//visible true or false of next and previous button//according to last and first page...
                               trPaging.Visible=false;
                            }
                            else
                            {
                                 Page1.CurrentPageIndex = CurrentPage;
                                dlSearchResults.DataSource = Page1;
                                dlSearchResults.DataKeyField = "id";
                                dlSearchResults.DataBind();
                                //now datalist only show the a images...  
                                //due to "Page.PageSize = 8;" statement...//visible true or false of next and previous button//according to last and first page...
                                trPaging.Visible = true;
                                imgNext.Enabled = !Page1.IsLastPage;
                                imgPrevious.Enabled = !Page1.IsFirstPage;
                            }

                        }
                        else
                        {
                           // redirect("Search-Not-Found.aspx?cname=" + Server.UrlEncode(strcat) + "&city=" + Server.UrlEncode(city),false);
                            strcat = obj.ReplaceSpecialchars(strcat);
                            Response.RedirectToRoute("SearchResultPage", new { cname = strcat, city = city });

                        }
                       
                    }
                    catch (Exception ex)
                    {
                        obj.insert_exception(ex, excep_page);
                        Response.Redirect("HttpErrorPage.aspx");
                    }
                }
            }

            else if (strcat != "")//null
            {
                if ((strcat != "" && strarea!=""))//null
                {
                    try
                    {
                        DataSet ds = new DataSet();
                        //SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);

                        SqlDataAdapter da = new SqlDataAdapter("select *,stuff(\"company_name\", 22, len(company_name), '...') as compname from ModulesData where ((Category in ('" + strcat + "')) or (module in ('" + strcat + "')) or (SubCategory in ('" + strcat + "')) and City='" + city + "' and area like ('%" + strarea + "%') and (module='Category' or module='B2BCategory' or module='FreeListing' or module='LifeStyle') and ApprovedStatus=1 order by id desc ", con);
                        //if (Session["sss"] == null)
                        //{
                        da.Fill(ds, "data");
                        //}
                        //else
                        //{
                        //    ds = (DataSet)Session["sss"];
                        //}     
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            Session["mod"] = ds.Tables[0].Rows[0]["module"].ToString();
                            mod = ds.Tables[0].Rows[0]["module"].ToString();
                            Page1.AllowPaging = true;//page object store the datasource of datalist..
                            Page1.DataSource = ds.Tables[0].DefaultView;
                            Page1.PageSize = 10;
                            //"CurrentPage" is global variable that content the current page index..
                            if (ds.Tables[0].Rows.Count <= Page1.PageSize)
                            {
                                Page1.CurrentPageIndex = CurrentPage;
                                dlSearchResults.DataSource = Page1;
                                dlSearchResults.DataKeyField = "id";
                                dlSearchResults.DataBind();
                                //now datalist only show the a images...  
                                //due to "Page.PageSize = 8;" statement...//visible true or false of next and previous button//according to last and first page...
                                trPaging.Visible = false;
                            }
                            else
                            {
                                Page1.CurrentPageIndex = CurrentPage;
                                dlSearchResults.DataSource = Page1;
                                dlSearchResults.DataKeyField = "id";
                                dlSearchResults.DataBind();
                                //now datalist only show the a images...  
                                //due to "Page.PageSize = 8;" statement...//visible true or false of next and previous button//according to last and first page...
                                trPaging.Visible = true;
                                imgNext.Enabled = !Page1.IsLastPage;
                                imgPrevious.Enabled = !Page1.IsFirstPage;
                            }
                        }
                        else
                        {
                            //redirect("Search-Not-Found.aspx?cname=" + Server.UrlEncode(strcat) + "&city=" + Server.UrlEncode(city),false);
                            strcat = obj.ReplaceSpecialchars(strcat);
                            Response.RedirectToRoute("SearchResultPage", new { cname = strcat, city = city });
                        }
                      
                    }
                    catch (Exception ex)
                    {
                        obj.insert_exception(ex, excep_page);
                        Response.Redirect("HttpErrorPage.aspx");
                    }
                }

                else if ((strcat != "" && strarea == ""))//null
                {
                    try
                    {
                        DataSet ds = new DataSet();
                        //SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);

                        SqlDataAdapter da = new SqlDataAdapter("select *,stuff(\"company_name\", 22, len(company_name), '...') as compname from ModulesData where ((Category like '%" + strcat + "%') or (module like '%" + strcat + "%') or (SubCategory like '%" + strcat + "%')) and City='" + city + "' and (module='Category' or module='B2BCategory' or module='FreeListing' or module='LifeStyle') and ApprovedStatus='1' order by id desc", con);

                        //if (Session["sss"] == null)
                        //{
                        da.Fill(ds, "data");

                        //}
                        //else 
                        //{
                        //    ds = (DataSet)Session["sss"];
                        //}               
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            Session["mod"] = ds.Tables[0].Rows[0]["module"].ToString();
                            mod = ds.Tables[0].Rows[0]["module"].ToString();

                            Page1.AllowPaging = true;//page object store the datasource of datalist..
                            Page1.DataSource = ds.Tables[0].DefaultView;
                            Page1.PageSize = 10;
                            //"CurrentPage" is global variable that content the current page index..
                            if (ds.Tables[0].Rows.Count <= Page1.PageSize)
                            {
                                Page1.CurrentPageIndex = CurrentPage;
                                dlSearchResults.DataSource = Page1;
                                dlSearchResults.DataKeyField = "id";
                                dlSearchResults.DataBind();
                                //now datalist only show the a images...  
                                //due to "Page.PageSize = 8;" statement...//visible true or false of next and previous button//according to last and first page...
                                trPaging.Visible = false;
                            }
                            else
                            {
                                Page1.CurrentPageIndex = CurrentPage;
                                dlSearchResults.DataSource = Page1;
                                dlSearchResults.DataKeyField = "id";
                                dlSearchResults.DataBind();
                                //now datalist only show the a images...  
                                //due to "Page.PageSize = 8;" statement...//visible true or false of next and previous button//according to last and first page...
                                trPaging.Visible = true;
                                imgNext.Enabled = !Page1.IsLastPage;
                                imgPrevious.Enabled = !Page1.IsFirstPage;
                            }

                        }
                        else
                        {
                            //redirect("Search-Not-Found.aspx?cname=" + Server.UrlEncode(strcat) + "&city=" + Server.UrlEncode(city),false);
                            strcat = obj.ReplaceSpecialchars(strcat);
                            Response.RedirectToRoute("SearchResultPage", new { cname = strcat, city = city });

                        }
                                          }
                    catch (Exception ex)
                    {
                        obj.insert_exception(ex, excep_page);
                        Response.Redirect("HttpErrorPage.aspx");
                    }
                }
            }
            else if (strcname != "")//null
            {
                if ((strcname != "" && strarea!=""))//null
                {
                    try
                    {
                        DataSet ds = new DataSet();
                        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                     
                        SqlDataAdapter da = new SqlDataAdapter("select *,stuff(\"company_name\", 22, len(company_name), '...') as compname from ModulesData where (company_name like '%" + strcname + "%')) and (area like ('%" + strarea + "%')) and City='" + city + "' and (module='Category' or module='B2BCategory' or module='FreeListing' or module='LifeStyle') and ApprovedStatus='1' order by id desc", con);
                        //if (Session["sss"] == null)
                        //{
                        da.Fill(ds, "data");

                        //}
                        //else
                        //{
                        //    ds = (DataSet)Session["sss"];
                        //}     
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                Session["mod"] = ds.Tables[0].Rows[i]["module"].ToString();
                                mod = ds.Tables[0].Rows[0]["module"].ToString();

                                Page1.AllowPaging = true;//page object store the datasource of datalist..
                                Page1.DataSource = ds.Tables[0].DefaultView;
                                Page1.PageSize = 10;
                                //"CurrentPage" is global variable that content the current page index..
                                if (ds.Tables[0].Rows.Count <= Page1.PageSize)
                                {
                                    Page1.CurrentPageIndex = CurrentPage;
                                    dlSearchResults.DataSource = Page1;
                                    dlSearchResults.DataKeyField = "id";
                                    dlSearchResults.DataBind();

                                    //now datalist only show the a images...  
                                    //due to "Page.PageSize = 8;" statement...//visible true or false of next and previous button//according to last and first page...
                                    trPaging.Visible = false;
                                }
                                else
                                {
                                    Page1.CurrentPageIndex = CurrentPage;
                                    dlSearchResults.DataSource = Page1;
                                    dlSearchResults.DataKeyField = "id";
                                    dlSearchResults.DataBind();

                                    //now datalist only show the a images...  
                                    //due to "Page.PageSize = 8;" statement...//visible true or false of next and previous button//according to last and first page...
                                    trPaging.Visible = true;
                                    imgNext.Enabled = !Page1.IsLastPage;
                                    imgPrevious.Enabled = !Page1.IsFirstPage;
                                }

                            }
                        }
                        else
                        {
                            //redirect("Search-Not-Found.aspx?cname=" + Server.UrlEncode(strcat) + "&city=" + Server.UrlEncode(city),false);
                            strcat = obj.ReplaceSpecialchars(strcat);
                            Response.RedirectToRoute("SearchResultPage", new { cname = strcat, city = city });

                        }
                    }
                    catch (Exception ex)
                    {
                        obj.insert_exception(ex, excep_page);
                        Response.Redirect("HttpErrorPage.aspx");
                    }
                }

                else if ((strcname != "" && strarea == ""))//null
                {
                    try
                    {
                        DataSet ds = new DataSet();
                        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                       
                        SqlDataAdapter da = new SqlDataAdapter("select *,stuff(\"company_name\", 22, len(company_name), '...') as compname from ModulesData where (company_name like '%" + strcname + "%') and City='" + city + "' and (module='Category' or module='B2BCategory' or module='FreeListing' or module='LifeStyle') and ApprovedStatus='1' order by id desc", con);
                        //if (Session["sss"] == null)
                        //{
                        da.Fill(ds, "data");

                        //}
                        //else
                        //{
                        //    ds = (DataSet)Session["sss"];
                        //}     
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            //{
                            Session["mod"] = ds.Tables[0].Rows[0]["module"].ToString();
                            mod = ds.Tables[0].Rows[0]["module"].ToString();

                            Page1.AllowPaging = true;//page object store the datasource of datalist..
                            Page1.DataSource = ds.Tables[0].DefaultView;
                            Page1.PageSize = 10;
                            //"CurrentPage" is global variable that content the current page index..
                            if (ds.Tables[0].Rows.Count <= Page1.PageSize)
                            {
                                Page1.CurrentPageIndex = CurrentPage;
                                dlSearchResults.DataSource = Page1;
                                dlSearchResults.DataKeyField = "id";
                                dlSearchResults.DataBind();
                                //now datalist only show the a images...  
                                //due to "Page.PageSize = 8;" statement...//visible true or false of next and previous button//according to last and first page...

                                //}
                                trPaging.Visible = false;
                            }
                            else
                            {
                                Page1.CurrentPageIndex = CurrentPage;
                                dlSearchResults.DataSource = Page1;
                                dlSearchResults.DataKeyField = "id";
                                dlSearchResults.DataBind();
                                //now datalist only show the a images...  
                                //due to "Page.PageSize = 8;" statement...//visible true or false of next and previous button//according to last and first page...

                                //}
                                trPaging.Visible = true;
                                imgNext.Enabled = !Page1.IsLastPage;
                                imgPrevious.Enabled = !Page1.IsFirstPage;
                            }

                        }
                        else
                        {
                            //redirect("Search-Not-Found.aspx?cname=" + Server.UrlEncode(strcat) + "&city=" + Server.UrlEncode(city),false);
                            strcat = obj.ReplaceSpecialchars(strcat);
                            Response.RedirectToRoute("SearchResultPage", new { cname = strcat, city = city });

                        }
                        
                    }
                    catch (Exception ex)
                    {
                        obj.insert_exception(ex, excep_page);
                        Response.Redirect("HttpErrorPage.aspx");
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
    public void advanced_search()
    {
        string comp_name, cnctper, phone, city;
        city = Convert.ToString(Page.RouteData.Values["city"]);
        comp_name = Convert.ToString(Page.RouteData.Values["compname"].ToString());
        comp_name = comp_name.Replace("-", " ");
        cnctper = Convert.ToString(Page.RouteData.Values["cnctper"].ToString());
        phone = Convert.ToString(Page.RouteData.Values["phone"].ToString());
        try
        {
            if (comp_name != "null" && cnctper != "null" && phone != "null")
            {
                try
                {
                    Label10.Text = comp_name + " , " + cnctper + " , " + phone + "";
                    Label12.Text = city;
                    dsadv_search = data_obj.searchbyall(city, comp_name, cnctper, phone);
                    if (!dsadv_search.Tables[0].Rows.Count.Equals(0))
                    {
                        dlSearchResults.DataSource = dsadv_search;
                        dlSearchResults.DataBind();
                    }
                    else
                    {
                        //redirect("Search-Not-Found.aspx?cname=" + Server.UrlEncode(cnctper) + "&city=" + Server.UrlEncode(city),false);
                       cnctper = obj.ReplaceSpecialchars(cnctper);
                        Response.RedirectToRoute("SearchResultPage", new { cname = cnctper, city = city });
                    }

                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
            else if (comp_name != "null" && phone != "null")
            {
                try
                {
                    Label10.Text = comp_name + " , " + phone + "";
                    Label12.Text = city;
                    dsadv_search = data_obj.searchbycomphone(city, comp_name, phone);
                    if (!dsadv_search.Tables[0].Rows.Count.Equals(0))
                    {
                        dlSearchResults.DataSource = dsadv_search;
                        dlSearchResults.DataBind();
                    }
                    else
                    {
                        //redirect("Search-Not-Found.aspx?cname=" + Server.UrlEncode(comp_name) + "&city=" + Server.UrlEncode(city),false);
                        comp_name = obj.ReplaceSpecialchars(comp_name);
                        Response.RedirectToRoute("SearchResultPage", new { cname = comp_name, city = city });
                    }

                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
            else if (comp_name != "null" && cnctper != "null")
            {
                try
                {
                    Label10.Text = comp_name + " , " + cnctper + "";
                    Label12.Text = city;
                    dsadv_search = data_obj.searchbycomper(city, comp_name, cnctper);
                    if (!dsadv_search.Tables[0].Rows.Count.Equals(0))
                    {
                        dlSearchResults.DataSource = dsadv_search;
                        dlSearchResults.DataBind();
                    }
                    else
                    {
                        // redirect("Search-Not-Found.aspx?cname=" + Server.UrlEncode(comp_name) + "&city=" + Server.UrlEncode(city),false);
                        comp_name = obj.ReplaceSpecialchars(comp_name);
                        Response.RedirectToRoute("SearchResultPage", new { cname = comp_name, city = city });
                    }

                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
            else if (cnctper != "null" && phone != "null")
            {
                try
                {
                    Label10.Text = cnctper + " , " + phone + "";
                    Label12.Text = city;
                    dsadv_search = data_obj.searchbyperphone(city, cnctper, phone);
                    if (!dsadv_search.Tables[0].Rows.Count.Equals(0))
                    {
                        dlSearchResults.DataSource = dsadv_search;
                        dlSearchResults.DataBind();
                    }
                    else
                    {
                        // redirect("Search-Not-Found.aspx?cname=" + Server.UrlEncode(cnctper) + "&city=" + Server.UrlEncode(city),false);

                        cnctper = obj.ReplaceSpecialchars(cnctper);
                        Response.RedirectToRoute("SearchResultPage", new { cname = cnctper, city = city });
                    }

                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
            else if (comp_name != "null")
            {
                try
                {
                    Label10.Text = comp_name;
                    Label12.Text = city;
                    dsadv_search = data_obj.searchbycomp(city, comp_name);
                    if (!dsadv_search.Tables[0].Rows.Count.Equals(0))
                    {
                        dlSearchResults.DataSource = dsadv_search;
                        dlSearchResults.DataBind();
                    }
                    else
                    {
                        //redirect("Search-Not-Found.aspx?cname=" + Server.UrlEncode(comp_name) + "&city=" + Server.UrlEncode(city),false);

                        comp_name = obj.ReplaceSpecialchars(comp_name);
                        Response.RedirectToRoute("SearchResultPage", new { cname = comp_name, city = city });
                    }

                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
            else if (cnctper != "null")
            {
                try
                {
                    Label10.Text = cnctper;
                    Label12.Text = city;
                    dsadv_search = data_obj.searchbyper(city, cnctper);
                    if (!dsadv_search.Tables[0].Rows.Count.Equals(0))
                    {
                        dlSearchResults.DataSource = dsadv_search;
                        dlSearchResults.DataBind();
                    }
                    else
                    {
                        //redirect("Search-Not-Found.aspx?cname=" + Server.UrlEncode(cnctper) + "&city=" + Server.UrlEncode(city),false);
                        cnctper = obj.ReplaceSpecialchars(cnctper);
                        Response.RedirectToRoute("SearchResultPage", new { cname = cnctper, city = city });
                    }

                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
            else if (phone != "null")
            {
                try
                {
                    Label10.Text = phone;
                    Label12.Text = city;
                    dsadv_search = data_obj.searchbyphone(city, phone);
                    if (!dsadv_search.Tables[0].Rows.Count.Equals(0))
                    {
                        dlSearchResults.DataSource = dsadv_search;
                        dlSearchResults.DataBind();
                    }
                    else
                    {

                        Response.RedirectToRoute("search");
                       // Response.Redirect("Search-Not-Found.aspx");
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    public void search_hotel()
    {
        try
        {
            string company_name, area, city;
            company_name = Convert.ToString(Page.RouteData.Values["compname"].ToString());
            company_name = obj.ReplaceCatnamewithorginalchars(company_name);
            area = Convert.ToString(Page.RouteData.Values["area"].ToString());
            city = Convert.ToString(Page.RouteData.Values["city"].ToString());
            Label10.Text = company_name;
            Label12.Text = city;
            dsadv_search = obj.gethotel_det(city, company_name, area);
            if (!dsadv_search.Tables[0].Rows.Count.Equals(0))
            {
                pds.DataSource = dsadv_search.Tables[0].DefaultView;
                pds.AllowPaging = true;
                pds.PageSize = 10;
                if (dsadv_search.Tables[0].Rows.Count <= pds.PageSize)
                {
                    pds.CurrentPageIndex = CurrentPage;
                    trPaging.Visible = false;
                    dlSearchResults.DataSource = pds;
                    dlSearchResults.DataBind();
                }
                else
                {
                    pds.CurrentPageIndex = CurrentPage;
                    trPaging.Visible = true;
                    imgPrevious.Enabled = !pds.IsFirstPage;
                    imgNext.Enabled = !pds.IsLastPage;
                    dlSearchResults.DataSource = pds;
                    dlSearchResults.DataBind();
                }
                //foreach (DataListItem dl in dlSearchResults.Items)
                //{
                //    HtmlTableCell colimg = (HtmlTableCell)dl.FindControl("tdlogo");
                //    for (int i = 0; i < dsadv_search.Tables[0].Rows.Count; i++)
                //    {
                //        string img = dsadv_search.Tables[0].Rows[i]["ImageName"].ToString();
                //        if (img == "NULL" || img == "0")
                //        {
                //            colimg.Visible = false;

                //        }
                //        else
                //        {
                //            colimg.Visible = true;

                //        }
                //    }
                //}
            }
            else
            {
                company_name =obj.ReplaceSpecialchars(company_name);
                Response.RedirectToRoute("SearchResultPage", new { cname = company_name, city = city });

               //redirect("Search-Not-Found.aspx?cname=" + Server.UrlEncode(company_name) + "&city=" + Server.UrlEncode(city),false);
                //lblDatanotfound.Text = "Result not found , Try with some other city or area or category or company name";
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
     }
    /// <summary>
    /// To put current page status
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
    protected void imgPrevious_Click(object sender, ImageClickEventArgs e)
    {
        //try
        //{
            CurrentPage -= 1;
            //"CurrentPage" is global variable that content the current page index..
            //pid = Session["Pid"].ToString();
            //AdvSearch = Session["advSearch"].ToString();
            if (Convert.ToString(Session["Pid"]) == "Hotels")
            {
                search_hotel();
            }
            else if (Convert.ToString(Session["Pid"]) == "adv_search")
            {
                advanced_search();
            }
            else
            {
                BindGrid();
            }
        //}
        //catch (Exception ex)
        //{
        //    obj.insert_exception(ex, excep_page);
        //    Response.Redirect("HttpErrorPage.aspx");
        //}
    }
    protected void imgNext_Click(object sender, ImageClickEventArgs e)
    {
        //try
        //{
            CurrentPage += 1;
               //"CurrentPage" is global variable that content the current page index..
               //AdvSearch = Session["advSearch"].ToString();
                //pid = Session["Pid"].ToString();
                if (Convert.ToString(Session["Pid"]) == "Hotels")
                {
                    search_hotel();
                }
                else if (Convert.ToString(Session["Pid"]) == "adv_search")
                {
                    advanced_search();
                }
                else
                {
                    BindGrid();
                }
        //}
        //catch (Exception ex)
        //{
        //    obj.insert_exception(ex, excep_page);
        //    Response.Redirect("HttpErrorPage.aspx");
        //}
    }
    protected void btnSubmitSMS_Click(object sender, EventArgs e)
    {

    }
    protected void dlSearchResults_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            Label lblDataId = (Label)e.Item.FindControl("lblDataId");
            Label lblnoofratings = (Label)e.Item.FindControl("lblnoofratings");
            HtmlTableCell tdimge = (HtmlTableCell)e.Item.FindControl("tdlogo");
            Label imgname = (Label)e.Item.FindControl("lblImgName");
            LinkButton lnkmap = (LinkButton)e.Item.FindControl("lnkmap");
            Label lblSlash = (Label)e.Item.FindControl("lblSlash");
            try
            {
                if (imgname != null)
                {
                    if (imgname.Text != "0")
                    {
                        tdimge.Visible = true;
                    }
                    else
                    {
                        tdimge.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
            if (Convert.ToString(lblDataId) != "")
            {
                DataId = Convert.ToString(lblDataId.Text);
                //con.Open();
                SqlCommand cmd = new SqlCommand("Select count(rid) as NumberOfUsers,sum(Stars_Rating) as Total from PostReview where dataid='" + DataId + "'", con);
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
                   // con.Close();
                    lblnoofratings.Text = Convert.ToString(count);
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
                SqlDataAdapter mapadapter = new SqlDataAdapter("select id,map,Approved_map from modulesdata where id='" + DataId + "' and Approved_map=1", con);
                DataSet dsmap = new DataSet();
                mapadapter.Fill(dsmap);
                try
                {
                    if (!dsmap.Tables[0].Rows.Count.Equals(0))
                    {
                        pnlmap.Visible = true;
                        dlmap.Visible = true;
                        dlmap.DataSource = dsmap;
                        dlmap.DataBind();
                    }
                    else
                    {
                        pnlmap.Visible = false;
                        dlmap.Visible = false;
                        lnkmap.Visible = false;
                        lblSlash.Visible = false;

                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
            HyperLink hypCompany = (HyperLink)e.Item.FindControl("hypCompName");
            if (hypCompany != null)
            {
                if (hypCompany.Text == "")
                {
                    hypCompany.Text = hypCompany.ToolTip.ToString();
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
    protected string GetRatingUrl(object Pid)
    {
        string PReviewid = pid.ToString();
        return Page.GetRouteUrl("CommonPostReviewCat", new { DataId = PReviewid });
    }
    protected string GetCompUrl(object cid,object cname)
    {
        string compId = cid.ToString();
        string compName = cname.ToString();
        compName = compName.Replace(" ", "-");
        compName = compName.Replace(".", "Dot");
        compName = compName.Replace("/", "-");
        compName = compName.Replace("_", "-");
        compName = compName.Replace("%20", "-");
        return Page.GetRouteUrl("sessionstore", new { id = compId, cname = compName });
    }
    protected string GetViewUrl(object Vid)
    {
        string cId = Vid.ToString();
        return Page.GetRouteUrl("CT_sessionstore", new { id = cId });
    }
    protected void metadata(string modname)
    {
        try
        {
            pgtitle.Text = "Get the data about " + modname + " through justcalluz";
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
    protected void lnkmap_Click(object sender, CommandEventArgs e)
    {
        btnmap.Visible = true;
        pnlmap.Visible = true;
        string dataId1 = Convert.ToString(e.CommandArgument.ToString());
        SqlDataAdapter mapadapter1 = new SqlDataAdapter("select id,map,Approved_map from modulesdata where id='" + dataId1 + "' and Approved_map=1", con);
        DataSet dsmap1 = new DataSet();
        mapadapter1.Fill(dsmap1);
        if (!dsmap1.Tables[0].Rows.Count.Equals(0))
        {
            dlmap.Visible = true;
            dlmap.DataSource = dsmap1;
            dlmap.DataBind();
        }

        ModalPopupExtender3.Show();
    }
   
}
