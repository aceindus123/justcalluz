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

public partial class usercontrols_linkcontroll_innerleft : System.Web.UI.UserControl
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    InsertData obj = new InsertData();
    string scname;
    string rname;
    DataSet ds5 = new DataSet();
    string strname = string.Empty;
    string returncattype = string.Empty;
    SqlDataAdapter da;
   // string name;
    static string excep_page = "linkcontroll_innerleft.ascx";
   
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)
        //{
        try
        {
            if (Convert.ToString(Page.RouteData.Values["cname"]) != "" && Convert.ToString(Page.RouteData.Values["cname"])!=null)
            {
                strname = Convert.ToString(Page.RouteData.Values["cname"]);
                strname = obj.ReplaceSpecialchars(strname);
                Session["maincat"] = strname;
                trRestaurants.Visible = false;
                DlRestaurants.Visible = false;
                trRelCat.Visible = true;
                tradvrel.Visible = false;
                rest.Visible = false;
                dlcat.Visible = true;
                trhotels.Visible = false;
                dlpoptitle.Visible = false;
                dlpopcat.Visible = false;
                //strname = Convert.ToString(Request.QueryString["cname"]).Trim();
            }
            else if (Convert.ToString(Page.RouteData.Values["pcname"]) != "" && Convert.ToString(Page.RouteData.Values["pcname"]) != null)
            {
                strname = Convert.ToString(Page.RouteData.Values["pcname"]);
                Session["maincat"] = strname;
                trRestaurants.Visible = false;
                DlRestaurants.Visible = false;
                trRelCat.Visible = true;
                tradvrel.Visible = false;
                rest.Visible = false;
                dlcat.Visible = true;
                trhotels.Visible = false;
                dlpoptitle.Visible = false;
                dlpopcat.Visible = false;
            }
          else if (Convert.ToString(Page.RouteData.Values["rcname"]) != "" && Convert.ToString(Page.RouteData.Values["rcname"]) != null)
            {
                trRestaurants.Visible = true;
                DlRestaurants.Visible = true;
                trRelCat.Visible = false;
                dlcat.Visible = false;
                tradvrel.Visible = false;
                dladvcat.Visible = false;
                trhotels.Visible = false;
                dlhotcat.Visible = false;
                dlpoptitle.Visible = false;
                dlpopcat.Visible = false;
                SqlCommand cmd = new SqlCommand("leftLinkcontrollerUC_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //SqlDataAdapter da = new SqlDataAdapter("select *,substring(cat +' Restaurants',1,20)+'...' as Rcate from subcatageory where maincat='Restaurants'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds5);
                if (!ds5.Tables[0].Rows.Count.Equals(0))
                {
                    DlRestaurants.DataSource = ds5;
                    DlRestaurants.DataBind();
                }
                else
                {
                    trRestaurants.Visible = false;
                }
            }
            else if (Convert.ToString(Page.RouteData.Values["pageid"]) != "" && Convert.ToString(Page.RouteData.Values["pageid"]) != null)
            {
                string pageid = Convert.ToString(Page.RouteData.Values["pageid"]);
                if (pageid == "adv_search")
                {
                    trRelCat.Visible = false;
                    tradvrel.Visible = true;
                    trhotels.Visible = false;
                    rest.Visible = false;
                    dlcat.Visible = false;
                    dlpoptitle.Visible = false;
                    dlpopcat.Visible = false;
                    DataSet dscat = new DataSet();
                    string comp_name, cnctper, phone, city;
                    city = Convert.ToString(Page.RouteData.Values["city"]);
                    comp_name = Convert.ToString(Page.RouteData.Values["compname"]);
                    cnctper = Convert.ToString(Page.RouteData.Values["cnctper"]);
                    phone = Convert.ToString(Page.RouteData.Values["phone"]);
                    try
                    {
                        if (comp_name != "null")
                        {
                            SqlDataAdapter darelcat = new SqlDataAdapter("select distinct(SubCategory),Category from modulesdata where Category in (select Category from modulesdata where company_name='" + comp_name + "')", con);
                            darelcat.Fill(dscat);
                            dladvcat.DataSource = dscat;
                            dladvcat.DataBind();
                        }
                        else if (cnctper != "null")
                        {
                            SqlDataAdapter darelcat = new SqlDataAdapter("select distinct(SubCategory),Category from modulesdata where Category in (select Category from modulesdata where contact_person='" + cnctper + "')", con);
                            darelcat.Fill(dscat);
                            dladvcat.DataSource = dscat;
                            dladvcat.DataBind();
                        }
                        else if (phone != "null")
                        {
                            SqlDataAdapter darelcat = new SqlDataAdapter("select distinct(SubCategory),Category from modulesdata where Category in (select Category from modulesdata where ( mob='" + phone + "' or landphno='" + phone + "'))", con);
                            darelcat.Fill(dscat);
                            dladvcat.DataSource = dscat;
                            dladvcat.DataBind();
                        }
                    }
                    catch (Exception ex)
                    {
                        obj.insert_exception(ex, excep_page);
                        Response.Redirect("HttpErrorPage.aspx");
                    }

                }
                else if (pageid == "Hotels")
                {
                    try
                    {
                        trRelCat.Visible = true;
                        tradvrel.Visible = false;
                        rest.Visible = false;
                        dlcat.Visible = false;
                        dlpoptitle.Visible = false;
                        dlpopcat.Visible = false;
                        DataSet dscat = new DataSet();
                        string comp_name = Convert.ToString(Page.RouteData.Values["compname"]);
                        comp_name = obj.ReplaceCatnamewithorginalchars(comp_name);
                        if (comp_name == "Hotels & Resorts" || comp_name == "Restaurant & Pubs")
                        {
                            string[] strcat = comp_name.ToString().Split(' ', '&', ' ');
                            SqlDataAdapter darelcat = new SqlDataAdapter("select distinct(Category) from modulesdata where Category like '%" + strcat[0] + "%' or Category like '%" + strcat[3] + "%'", con);
                            darelcat.Fill(dscat);
                        }
                        else
                        {
                            try
                            {
                                SqlDataAdapter darelcat = new SqlDataAdapter("select distinct(Category) from modulesdata where company_name like '%" + comp_name + "%' or Category like '%" + comp_name + "%' or SubCategory like '%" + comp_name + "%'", con);
                                darelcat.Fill(dscat);
                                if (!dscat.Tables[0].Rows.Count.Equals(0))
                                {
                                    string substring = dscat.Tables[0].Rows[0]["Category"].ToString();
                                    if (substring == "5 Star Hotels")
                                    {
                                        string[] strcat = substring.ToString().Split(' ', ' ');
                                        SqlDataAdapter dastar = new SqlDataAdapter("select distinct(Category) from modulesdata where Category like '%" + strcat[2] + "%'", con);
                                        dastar.Fill(dscat);
                                    }
                                    else if (comp_name == "Hotels & Resorts" || comp_name == "Restaurant & Pubs")
                                    {
                                        string[] strcat = substring.ToString().Split(' ', '&', ' ');
                                        SqlDataAdapter dastar = new SqlDataAdapter("select distinct(Category) from modulesdata where Category like '%" + strcat[0] + "%' or Category like '%" + strcat[3] + "%'", con);
                                        dastar.Fill(dscat);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                obj.insert_exception(ex, excep_page);
                                Response.Redirect("HttpErrorPage.aspx");
                            }
                        }
                        if (!dscat.Tables[0].Rows.Count.Equals(0))
                        {
                            DataTable dtright = dscat.Tables[0];
                            String[] keycolumns = new String[] { "Category" };

                            RemoveDuplicates(dtright, keycolumns); // Here UserName is Column name of table
                            dlhotcat.DataSource = dscat;
                            dlhotcat.DataBind();
                        }
                    }
                    catch (Exception ex)
                    {
                        obj.insert_exception(ex, excep_page);
                        Response.Redirect("HttpErrorPage.aspx");
                    }

                }

            }

            else
            {
                trRestaurants.Visible = false;
                DlRestaurants.Visible = false;
                scname = Convert.ToString(Page.RouteData.Values["scname"]).Trim();
                scname = obj.ReplaceSpecialchars(scname);
                bindpopcats();
            }
            //dlothercat.Visible = true;
            //DataSet ds4 = new DataSet();
            //ds4 = obj.bindothercat();
            //dlothercat.DataSource = ds4;
            //dlothercat.DataBind();

            //DataSet ds5 = new DataSet();

            if (strname != "")
            {
              
                try
                {
                  
                    if (Convert.ToString(Page.RouteData.Values["cattype"])== "b2b")
                    {
                        da = new SqlDataAdapter("select stuff(\"cat\", 22, len(cat), '..') as catname,cat,maincat from b2bcategories where maincat in ('" + strname + "') order by cat asc", con);
                    }
                    else
                    {
                        //SqlDataAdapter da = new SqlDataAWedding Requisitesdapter("select *,substring(cat,1,25)+'...' as catname from subcatageory where maincat like '%" + strname + "%'", con);
                       //da = new SqlDataAdapter("select stuff(\"cat\", 22, len(cat), '..') as catname,cat,maincat from subcatageory where maincat in ('" + strname + "') order by cat asc", con);
                        da = new SqlDataAdapter("select distinct(len(cat)),cat,maincat from subcatageory where maincat in ('" + strname + "') order by cat asc", con);
                    }
                    da.Fill(ds5);
                    if (ds5.Tables[0].Rows.Count.Equals(0))
                    {
                        trRelCat.Visible = false;
                        bindpopcats();
                    }
                    else
                    {

                        dlcat.DataSource = ds5;
                        dlcat.DataBind();
                        if (ds5.Tables[0].Rows.Count < 10)
                        {
                            //dlpopcat.Visible = true;
                            bindpopcats();
                        }
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }

            }
            else
            {
                trRelCat.Visible = false;
            }

        }
        catch (Exception ex)
        {

            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        // }

    }
    void bindpopcats()
    {
        dlpoptitle.Visible = true;
        dlpopcat.Visible = true;
        DataSet ds = new DataSet();
        ds = obj.bindpopcat();
        //SqlCommand pcmd = new SqlCommand("leftLinkcontrollerUC_SP", con);
        //pcmd.CommandType = CommandType.StoredProcedure;
        //SqlDataAdapter psda = new SqlDataAdapter(pcmd);
        //psda.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            dlpopcat.DataSource = ds;
            dlpopcat.DataBind();
        }
    }
    private DataTable RemoveDuplicates(DataTable tbl, String[] keyColumns)
    {
        int rowNdx = 0;
        try
        {
            while (rowNdx < tbl.Rows.Count - 1)
            {
                DataRow[] dups = FindDups(tbl, rowNdx, keyColumns);
                if (dups.Length > 0)
                {
                    foreach (DataRow dup in dups)
                    {
                        tbl.Rows.Remove(dup);
                    }
                }
                else
                {
                    rowNdx++;

                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        return tbl;
    }

    private DataRow[] FindDups(DataTable tbl, int sourceNdx, String[] keyColumns)
    {
        ArrayList retVal = new ArrayList();
        try
        {
            DataRow sourceRow = tbl.Rows[sourceNdx];
            for (int i = sourceNdx + 1; i < tbl.Rows.Count; i++)
            {
                DataRow targetRow = tbl.Rows[i];
                if (IsDup(sourceRow, targetRow, keyColumns))
                {
                    if (retVal.Count.Equals(0))
                        retVal.Add(sourceRow);
                    //retVal.Add(targetRow);
                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        return (DataRow[])retVal.ToArray(typeof(DataRow));
    }

    private bool IsDup(DataRow sourceRow, DataRow targetRow, String[] keyColumns)
    {
        bool retVal = true;
        try
        {
            foreach (String column in keyColumns)
            {
                if (sourceRow.Table.Columns.Contains(column))
                {
                    retVal = retVal && sourceRow[column].Equals(targetRow[column]);
                    if (!retVal) break;
                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        return retVal;
    }

    //protected void dlcat_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    //{
    //    try
    //    {
    //        //Session["name"] = e.CommandArgument.ToString();
    //        string name = "";
    //        name = e.CommandArgument.ToString();
    //        redirect("linkcontroller.aspx?scname=" + Server.UrlEncode(name), false);
    //    }
    //    catch (Exception ex)
    //    {
    //        obj.insert_exception(ex, excep_page);
    //        Response.Redirect("HttpErrorPage.aspx");
    //    }
    //}
    //protected void dladvcat_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    //{
    //    try
    //    {
    //        //Session["name"] = e.CommandArgument.ToString();
    //        string name = "";
    //        name = e.CommandArgument.ToString();
    //        redirect("linkcontroller.aspx?acname=" + Server.UrlEncode(name),false);
    //    }
    //    catch (Exception ex)
    //    {
    //        obj.insert_exception(ex, excep_page);
    //        Response.Redirect("HttpErrorPage.aspx");
    //    }
    //}

    //protected void dlpopcat_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    //{
    //    try
    //    {
    //        //Session["name"] = e.CommandArgument.ToString();

    //        name = e.CommandArgument.ToString();
    //        redirect("linkcontroller.aspx?cname=" + Server.UrlEncode(name),false);
    //    }
    //    catch (Exception ex)
    //    {
    //        obj.insert_exception(ex, excep_page);
    //        Response.Redirect("HttpErrorPage.aspx");
    //    }
    //}
    //protected void dlhotcat_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    //{
    //    try
    //    {
    //        string name = e.CommandArgument.ToString();
    //        redirect("linkcontroller.aspx?cname=" + Server.UrlEncode(name),false);
    //    }
    //    catch (Exception ex)
    //    {
    //        obj.insert_exception(ex, excep_page);
    //        Response.Redirect("HttpErrorPage.aspx");
    //    }
    //}
    //protected void DlRestaurants_ItemCommand(object source, DataListCommandEventArgs e)
    //{
    //    try
    //    {
    //        //Session["name"] = e.CommandArgument.ToString();
    //        string name = "";
    //        name = e.CommandArgument.ToString() + " Restaurants";
    //        redirect("linkcontroller.aspx?rcname=" + Server.UrlEncode(name), false);
    //    }
    //    catch (Exception ex)
    //    {
    //        obj.insert_exception(ex, excep_page);
    //        Response.Redirect("HttpErrorPage.aspx");
    //    }
    //}
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

    protected void dlpopcat_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        try
        {
            HyperLink btnCate = (HyperLink)e.Item.FindControl("lnkPopularCat");

            if (btnCate != null)
            {
                if (btnCate.Text == "")
                {
                    btnCate.Text = btnCate.ToolTip.ToString();
                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void dlcat_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        try
        {
            HyperLink btnRelCate = (HyperLink)e.Item.FindControl("lnkRelcategory");

            if (btnRelCate != null)
            {
                if (btnRelCate.Text == "")
                {
                    btnRelCate.Text = btnRelCate.ToolTip.ToString();
                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }

    protected string GetCatUrl(object name)
    {
        string catname = name.ToString();
        catname=obj.ReplaceSpecialchars(catname);
        return Page.GetRouteUrl("Link", new { cname = catname });
      
    }
    protected string GetrestCatUrl(object name)
    {
        string catname = name.ToString();
        catname = obj.ReplaceSpecialchars(catname);
       // return Page.GetRouteUrl("Link_rest", new { rcname = catname + " Restaurants" });
        return Page.GetRouteUrl("Rest_Link", new { rcname = catname + " Restaurants", rname = "Restaurants" });
    }
    protected string GetCat_sUrl(object name)
    {

        string cat = name.ToString();
        string maincat = Convert.ToString(Session["maincat"]);

      
        //if (catname.Contains("&"))
        //{
        //    catname = catname.Replace("&", "-");
        //}
        if (Convert.ToString(Page.RouteData.Values["cattype"]) == "b2b")
        {
            returncattype = "b2b";   
        }
        else
        {
            returncattype = "null";
        }
        string   catname = obj.ReplaceSpecialchars(cat);
        //return Page.GetRouteUrl("Link_s", new { scname = catname, pcname = maincat, cattype = returncattype });

        return Page.GetRouteUrl("Link_popcate", new { popcate = catname, pcname = maincat, cattype = returncattype });

    }
    protected string GetCat_aUrl(object name)
    {
        string catname = name.ToString();
        return Page.GetRouteUrl("Link_a", new { acname = catname });
    }
}
