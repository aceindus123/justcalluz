

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
using System.Web.Routing;

public partial class usercontrols_catageories : System.Web.UI.UserControl
{
    string strcname;
    int count;
    InsertData obj = new InsertData();
    string city;
    string mod;
    DataSet ds = new DataSet();
    static string excep_page = "catageories.ascx";
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
    string searchvalue = string.Empty;
    string mergestring = string.Empty;
    string mergestringcat1 = string.Empty;
    string mergestringcat2 = string.Empty;
    string mergestringcat3 = string.Empty;
    //String clientScriptName = "ButtonClickScript";
    //Type clientScriptType = this.GetType();

    //// Get a ClientScriptManager reference from the Page class.
    //ClientScriptManager clientScript = Page.ClientScript;



    protected void Page_Load(object sender, EventArgs e)
    {

        try
        {
           
            //code for radio buttons of company and category
            if (rb1comp.Checked)
            {
                txtSearchMFor.AutoPostBack = false;

            }
            else
            {
                txtSearchMFor.AutoPostBack = true;

            }
            //check whether the querystring passed from footer is null or not
            //if (Request.QueryString["city"] != null)
            if (Convert.ToString(Page.RouteData.Values["city"]) != "")
            {
                if (txtSelectMCity.Text != Convert.ToString(Page.RouteData.Values["city"]))
                {

                    if (txtSelectMCity.Text != "")
                    {

                        lblarea.Text = "Where in &nbsp;" + txtSelectMCity.Text + "&nbsp;?";
                        Session["ciyonload"] = txtSelectMCity.Text;
                        BindtxtSearch();
                    }
                    else
                    {
                        txtSelectMCity.Text = Convert.ToString(Page.RouteData.Values["city"]);

                        lblarea.Text = "Where in &nbsp;" + txtSelectMCity.Text + "&nbsp;?";
                        Session["ciyonload"] = txtSelectMCity.Text;
                        BindtxtSearch();
                    }

                }
                else
                {
                    txtSelectMCity.Text = Convert.ToString(Page.RouteData.Values["city"]);

                    lblarea.Text = "Where in &nbsp;" + txtSelectMCity.Text + "&nbsp;?";
                    Session["ciyonload"] = txtSelectMCity.Text;
                    BindtxtSearch();
                }
            }
            else
            {

                if (txtSelectMCity.Text != "")
                {
                    city = txtSelectMCity.Text;

                    lblarea.Text = "Where in &nbsp;" + txtSelectMCity.Text + "&nbsp;?";
                    Session["ciyonload"] = txtSelectMCity.Text;
                    BindtxtSearch();
                }
                else
                {

                    if (Convert.ToString(Session["ciyonload"]) != "")
                    {
                        txtSelectMCity.Text = Convert.ToString(Session["ciyonload"]);
                        city = txtSelectMCity.Text;

                        lblarea.Text = "Where in &nbsp;" + txtSelectMCity.Text + "&nbsp;?";
                        BindtxtSearch();
                    }
                    else
                    {
                        txtSelectMCity.Text = "Hyderabad";
                        lblarea.Text = "Where in " + txtSelectMCity.Text + "?";
                        BindtxtSearch();
                    }


                }

            }
            if (!IsPostBack)
            {
                Session["MyCity"] = txtSelectMCity.Text;
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }


    }
    protected void txtcityCha(object sender, EventArgs e)
    {

        lblarea.Text = "Where in " + txtSelectMCity.Text + "?";
    }
    //protected void txtareaCha(object sender, EventArgs e)
    //{

    //}

    private void BindtxtSearch()
    {
        try
        {
            if (Convert.ToString(Page.RouteData.Values["cname"]) != "")
            {
                searchvalue = obj.ReplaceCatnamewithorginalchars(Convert.ToString(Page.RouteData.Values["cname"]));
                try
                {
                    if (txtSearchMFor.Text != searchvalue)
                    {
                        if (txtSearchMFor.Text != "")
                        {
                            Session["searchfor"] = txtSearchMFor.Text;
                        }
                        else
                        {
                            txtSearchMFor.Text = searchvalue;                           
                            Session["searchfor"] = txtSearchMFor.Text;
                        }
                    }
                    else
                    {
                        txtSearchMFor.Text = searchvalue;
                      
                        Session["searchfor"] = txtSearchMFor.Text;
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
            else if (Convert.ToString(Page.RouteData.Values["catname"]) != "")
            {
               searchvalue=obj.ReplaceCatnamewithorginalchars(Convert.ToString(Page.RouteData.Values["catname"]));
                try
                {
                    if (txtSearchMFor.Text != searchvalue)
                    {
                        if (txtSearchMFor.Text != "")
                        {
                            Session["searchfor"] = txtSearchMFor.Text;
                        }
                        else
                        {
                            txtSearchMFor.Text = searchvalue;
                          
                            Session["searchfor"] = txtSearchMFor.Text;
                        }
                    }
                    else
                    {
                        txtSearchMFor.Text = searchvalue;
                      
                        Session["searchfor"] = txtSearchMFor.Text;
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
            else if (Convert.ToString(Page.RouteData.Values["maincat"]) != "")
            {
                searchvalue = obj.ReplaceCatnamewithorginalchars(Convert.ToString(Page.RouteData.Values["maincat"]));
                try
                {
                    if (txtSearchMFor.Text != searchvalue)
                    {
                        if (txtSearchMFor.Text != "")
                        {
                            Session["searchfor"] = txtSearchMFor.Text;
                        }
                        else
                        {

                            txtSearchMFor.Text = searchvalue;
                            Session["searchfor"] = txtSearchMFor.Text;
                        }
                    }
                    else
                    {
                        txtSearchMFor.Text = searchvalue;
                        Session["searchfor"] = txtSearchMFor.Text;
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
            else if (Convert.ToString(Page.RouteData.Values["popcate"]) != "")
            {
                searchvalue = obj.ReplaceCatnamewithorginalchars(Convert.ToString(Page.RouteData.Values["popcate"]));
                try
                {
                    if (txtSearchMFor.Text != searchvalue)
                    {
                        if (txtSearchMFor.Text != "")
                        {
                            Session["searchfor"] = txtSearchMFor.Text;
                        }
                        else
                        {

                            txtSearchMFor.Text = searchvalue;
                            Session["searchfor"] = txtSearchMFor.Text;
                        }
                    }
                    else
                    {
                        txtSearchMFor.Text = searchvalue;
                        Session["searchfor"] = txtSearchMFor.Text;
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
           else if (Convert.ToString(Page.RouteData.Values["scname"]) != "")
            {
                try
                {
                    if (txtSearchMFor.Text != Convert.ToString(Page.RouteData.Values["scname"]))
                    {
                        if (txtSearchMFor.Text != "")
                        {
                            Session["searchfor"] = txtSearchMFor.Text;
                        }
                        else
                        {
                            txtSearchMFor.Text = Convert.ToString(Page.RouteData.Values["scname"]);
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", " ");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("Dot", ".");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "/");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "_");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "%20");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "&");
                            Session["searchfor"] = txtSearchMFor.Text;
                        }
                    }
                    else
                    {
                        txtSearchMFor.Text = Convert.ToString(Page.RouteData.Values["scname"]);
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", " ");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("Dot", ".");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "/");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "_");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "%20");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "&");
                        Session["searchfor"] = txtSearchMFor.Text;
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
            else if (Convert.ToString(Page.RouteData.Values["rcname"]) != "")
            {
                try
                {
                    if (txtSearchMFor.Text != Convert.ToString(Page.RouteData.Values["rcname"]))
                    {
                        if (txtSearchMFor.Text != "")
                        {
                            Session["searchfor"] = txtSearchMFor.Text;
                        }
                        else
                        {
                            txtSearchMFor.Text = Convert.ToString(Page.RouteData.Values["rcname"]);
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", " ");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("Dot", ".");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "/");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "_");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "%20");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "&");
                            Session["searchfor"] = txtSearchMFor.Text;
                        }
                    }
                    else
                    {
                        txtSearchMFor.Text = Convert.ToString(Page.RouteData.Values["rcname"]);
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", " ");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("Dot", ".");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "/");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "_");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "%20");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "&");
                        Session["searchfor"] = txtSearchMFor.Text;
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
            else if (Convert.ToString(Page.RouteData.Values["str"]) != "")
            {
                try
                {
                    if (txtSearchMFor.Text != Convert.ToString(Page.RouteData.Values["str"]))
                    {
                        if (txtSearchMFor.Text != "")
                        {
                            Session["searchfor"] = txtSearchMFor.Text;
                        }
                        else
                        {
                            txtSearchMFor.Text = Convert.ToString(Page.RouteData.Values["str"]);
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", " ");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("Dot", ".");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "/");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "_");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "%20");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "&");
                            Session["searchfor"] = txtSearchMFor.Text;
                        }
                    }
                    else
                    {
                        txtSearchMFor.Text = Convert.ToString(Page.RouteData.Values["str"]);
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", " ");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("Dot", ".");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "/");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "_");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "%20");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "&");
                        Session["searchfor"] = txtSearchMFor.Text;
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
            else if (Convert.ToString(Page.RouteData.Values["Dcname"]) != "")
            {
                try
                {
                    if (txtSearchMFor.Text != Convert.ToString(Page.RouteData.Values["Dcname"]))
                    {
                        if (txtSearchMFor.Text != "")
                        {
                            Session["searchfor"] = txtSearchMFor.Text;
                        }
                        else
                        {
                            txtSearchMFor.Text = Convert.ToString(Page.RouteData.Values["Dcname"]);
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", " ");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("Dot", ".");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "/");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "_");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "%20");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "&");
                            Session["searchfor"] = txtSearchMFor.Text;
                        }
                    }
                    else
                    {
                        txtSearchMFor.Text = Convert.ToString(Page.RouteData.Values["Dcname"]);
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", " ");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("Dot", ".");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "/");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "_");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "%20");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "&");
                        Session["searchfor"] = txtSearchMFor.Text;
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
            else if (Convert.ToString(Page.RouteData.Values["Dscname"]) != "")
            {
                try
                {
                    if (txtSearchMFor.Text != Convert.ToString(Page.RouteData.Values["Dscname"]))
                    {
                        if (txtSearchMFor.Text != "")
                        {
                            Session["searchfor"] = txtSearchMFor.Text;
                        }
                        else
                        {
                            txtSearchMFor.Text = Convert.ToString(Page.RouteData.Values["Dscname"]);
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", " ");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("Dot", ".");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "/");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "_");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "%20");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "&");
                            Session["searchfor"] = txtSearchMFor.Text;
                        }
                    }
                    else
                    {
                        txtSearchMFor.Text = Convert.ToString(Page.RouteData.Values["Dscname"]);
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", " ");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("Dot", ".");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "/");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "_");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "%20");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "&");
                        Session["searchfor"] = txtSearchMFor.Text;
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
            else if (Convert.ToString(Page.RouteData.Values["pageid"]) != "")
            {
                try
                {
                    if (txtSearchMFor.Text != Convert.ToString(Page.RouteData.Values["pageid"]))
                    {
                        if (txtSearchMFor.Text != "")
                        {
                            Session["searchfor"] = txtSearchMFor.Text;
                        }
                        else
                        {
                            txtSearchMFor.Text = Convert.ToString(Page.RouteData.Values["pageid"]);
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", " ");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("Dot", ".");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "/");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "_");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "%20");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "&");
                            Session["searchfor"] = txtSearchMFor.Text;
                        }
                    }
                    else
                    {
                        txtSearchMFor.Text = Convert.ToString(Page.RouteData.Values["pageid"]);
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", " ");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("Dot", ".");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "/");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "_");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "%20");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "&");
                        Session["searchfor"] = txtSearchMFor.Text;
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
            else if (Convert.ToString(Page.RouteData.Values["compname"]) != "")
            {
                try
                {
                    if (txtSearchMFor.Text != Convert.ToString(Page.RouteData.Values["compname"]))
                    {
                        if (txtSearchMFor.Text != "")
                        {
                            Session["searchfor"] = txtSearchMFor.Text;
                        }
                        else
                        {
                            txtSearchMFor.Text = Convert.ToString(Page.RouteData.Values["compname"]);
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", " ");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("Dot", ".");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "/");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "_");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "%20");
                            txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "&");
                            Session["searchfor"] = txtSearchMFor.Text;
                        }
                    }
                    else
                    {
                        txtSearchMFor.Text = Convert.ToString(Page.RouteData.Values["compname"]);
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", " ");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("Dot", ".");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "/");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "_");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "%20");
                        txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "&");
                        Session["searchfor"] = txtSearchMFor.Text;
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
                Session["searchfor"] = null;
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void BtnSearch_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            if (rb2cat.Checked == true)
            {
                if (txtWhereMIn.Text != "Enter area")
                {

                    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from ModulesData where City like '%" + txtSelectMCity.Text + "%' and ((Category  in ('" + txtSearchMFor.Text + "')) or (module  in ('" + txtSearchMFor.Text + "')) or (SubCategory  in ('" + txtSearchMFor.Text + "'))) and Area like '%" + txtWhereMIn.Text + "%' and ApprovedStatus='1' order by id desc ", con);
                    da.Fill(ds, "data");
                    //Session["sss"] = ds;
                    con.Close();

                }
                else
                {

                    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from ModulesData where City like '%" + txtSelectMCity.Text + "%' and ((Category  in ('" + txtSearchMFor.Text + "')) or (module  in ('" + txtSearchMFor.Text + "')) or (SubCategory  in ('" + txtSearchMFor.Text + "'))) and ApprovedStatus=1 ", con);
                    da.Fill(ds, "data");
                    //Session["sss"] = ds;
                    con.Close();


                }
                Session["cat"] = txtSearchMFor.Text;
                Session["area"] = txtWhereMIn.Text;
                Session["cname"] = null;
                Session["value"] = txtSearchMFor.Text;
                Session["city"] = txtSelectMCity.Text;
                txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", " ");
                txtSearchMFor.Text = txtSearchMFor.Text.Replace("Dot", ".");
                txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "/");
                txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "_");
                txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "%20");
                txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "&");

                if (ds.Tables[0].Rows.Count > 0)
                {

                    Session["mod"] = ds.Tables[0].Rows[0]["module"].ToString();
                    mod = ds.Tables[0].Rows[0]["module"].ToString();
                    if (mod == "Events")
                    {
                        //Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "", "window.open('Events.aspx');", true);
                        //redirect("Events.aspx?cname=events", false);
                        Response.RedirectToRoute("Events", new { cname = "events" });
                    }
                    else
                    {
                        //Response.RedirectToRoute("Searchresults", new { cname = txtSearchMFor.Text, city = txtSelectCity.Text, area = txtWhereIn.Text });
                        Response.RedirectToRoute("lnkresults", new { cname = txtSearchMFor.Text, city = txtSelectMCity.Text });
                        //redirect("linkresults.aspx?cname=" + txtSearchMFor.Text + "&city=" + txtSelectCity.Text + "", false);
                    }

                }
                else
                {
                    //redirect("Search-Not-Found.aspx?cname=" + txtSearchMFor.Text + "&city=" + txtSelectCity.Text + "", false);
                    //Response.RedirectToRoute("SearchNotFoundPage", new { cname = txtSearchMFor.Text, city = txtSelectCity.Text, area = txtWhereIn.Text });
                    Response.RedirectToRoute("SearchResultPage", new { cname = txtSearchMFor.Text, city = txtSelectMCity.Text });
                }
            }
            else if (rb1comp.Checked == true)
            {
                if (txtWhereMIn.Text != "")
                {
                    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from ModulesData where City like '%" + txtSelectMCity.Text + "%' and company_name like '%" + txtSearchMFor.Text + "%' and Area='%" + txtWhereMIn.Text + "%' and ApprovedStatus='1' order by id desc ", con);
                    da.Fill(ds, "data");
                    //Session["sss"] = ds;
                    con.Close();

                }
                else
                {
                    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from ModulesData where City like '%" + txtSelectMCity.Text + "%' and company_name like '%" + txtSearchMFor.Text + "%' and ApprovedStatus='1' order by id desc", con);
                    da.Fill(ds, "data");
                    //Session["sss"] = ds;
                    con.Close();


                }
                Session["cat"] = null;
                Session["area"] = txtWhereMIn.Text;
                Session["cname"] = txtSearchMFor.Text;
                Session["value"] = txtSearchMFor.Text;
                Session["city"] = txtSelectMCity.Text;
                txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", " ");
                txtSearchMFor.Text = txtSearchMFor.Text.Replace("Dot", ".");
                txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "/");
                txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "_");
                txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "%20");
                txtSearchMFor.Text = txtSearchMFor.Text.Replace("-", "&");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    Session["mod"] = ds.Tables[0].Rows[0]["module"].ToString();
                    mod = ds.Tables[0].Rows[0]["module"].ToString();
                    if (mod == "Events")
                    {
                        //// Not preferred java script error is coming in 2nd time when we are doing events serach 
                        //Response.Write("<script>");
                        //Response.Write("window.open('Events.aspx','_blank')");
                        //Response.Write("</script>");
                        //redirect("Events.aspx?cname=events", false);
                        //Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "", "window.open('Events.aspx');", true);  
                        Response.RedirectToRoute("Events", new { cname = "events" });
                    }
                    else
                    {
                        //redirect("linkresults.aspx?cname=" + txtSearchMFor.Text + "&city=" + txtSelectCity.Text + "", false);
                        Response.RedirectToRoute("lnkresults", new { cname = txtSearchMFor.Text, city = txtSelectMCity.Text });
                        // Response.RedirectToRoute("Searchresults", new { cname = txtSearchMFor.Text, city = txtSelectCity.Text, area = txtWhereIn.Text });
                    }

                }
                else
                {
                    //Response.RedirectToRoute("SearchNotFoundPage", new { cname = txtSearchMFor.Text, city = txtSelectCity.Text, area = txtWhereIn.Text });
                    Response.RedirectToRoute("SearchResultPage", new { cname = txtSearchMFor.Text, city = txtSelectMCity.Text });
                    //redirect("Search-Not-Found.aspx?cname=" + txtSearchMFor.Text + "&city=" + txtSelectCity.Text + "", false);
                }

            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }



    }

    protected void txtSearchMFor_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (rb2cat.Checked == true)
            {

                if (txtWhereMIn.Text != "")
                {
                    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from ModulesData where City like '%" + txtSelectMCity.Text + "%' and (Category like '%" + txtSearchMFor.Text + "%' or module like '%" + txtSearchMFor.Text + "%' or SubCategory like '%" + txtSearchMFor.Text + "%' ) and Area like '%" + txtWhereMIn.Text + "%' and ApprovedStatus='1' order by id desc ", con);
                    da.Fill(ds, "data");
                    //Session["sss"] = ds;
                    con.Close();

                }
                else
                {
                    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from ModulesData where City like '%" + txtSelectMCity.Text + "%' and (Category like '%" + txtSearchMFor.Text + "%' or module like '%" + txtSearchMFor.Text + "%' or SubCategory like '%" + txtSearchMFor.Text + "%' ) and ApprovedStatus='1' order by id desc", con);
                    da.Fill(ds, "data");
                    //Session["sss"] = ds;
                    con.Close();


                }
                Session["cat"] = txtSearchMFor.Text;
                Session["area"] = txtWhereMIn.Text;
                Session["cname"] = "";
                Session["value"] = txtSearchMFor.Text;
                Session["city"] = txtSelectMCity.Text;


            }
            else if (rb1comp.Checked == true)
            {

                if (txtWhereMIn.Text != "")
                {
                    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from ModulesData where City like '%" + txtSelectMCity.Text + "%' and company_name like '%" + txtSearchMFor.Text + "%' and Area='%" + txtWhereMIn.Text + "%' and ApprovedStatus='1' order by id desc ", con);
                    da.Fill(ds, "data");
                    //Session["sss"] = ds;
                    con.Close();

                }
                else
                {
                    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from ModulesData where City like '%" + txtSelectMCity.Text + "%' and company_name like '%" + txtSearchMFor.Text + "%' and ApprovedStatus='1' order by id desc", con);
                    da.Fill(ds, "data");
                    //Session["sss"] = ds;
                    con.Close();

                }
                Session["cat"] = "";
                Session["area"] = txtWhereMIn.Text;
                Session["cname"] = txtSearchMFor.Text;
                Session["value"] = txtSearchMFor.Text;
                Session["city"] = txtSelectMCity.Text;
            }

        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void adv_search_Click(object sender, EventArgs e)
    {
        try
        {
            string advcity = txtSelectMCity.Text;
            //string advcity = Convert.ToString(Session["ciyonload"]);
            //Response.RedirectToRoute("advanced", new { city = advcity });
            Response.RedirectToRoute("advanced", new { city = advcity });
            //redirect("Advanced_Search.aspx?city=" + city, false);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    //protected string GetAdvancedUrl()
    //{
    //    string advcity = txtSelectCity.Text;
    //    //Response.RedirectToRoute("advanced", new { city = advcity });
    //    return Page.GetRouteUrl("advanced", new { city = advcity });
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
   

}