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

public partial class usercontrols_Search : System.Web.UI.UserControl
{
    string strcname;
    int count;
    InsertData obj = new InsertData();
    string city;
    string mod;
    DataSet ds = new DataSet();
    static string excep_page = "Search.ascx";
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
            //if (rb1comp.Checked)
            //{
            //    txtSearchFor.AutoPostBack = true;

            //}
            //else
            //{
            //    txtSearchFor.AutoPostBack = true;

            //}
            //check whether the querystring passed from footer is null or not
            if (Convert.ToString(Page.RouteData.Values["city"]) != "")
            {
                if (txtSelectCity.Text != Convert.ToString(Page.RouteData.Values["city"]))
                {
                    try
                    {
                        if (txtSelectCity.Text != "")
                        {

                            lblarea.Text = "Where in &nbsp" + txtSelectCity.Text + "&nbsp;?";
                            Session["ciyonload"] = txtSelectCity.Text;
                            BindtxtSearch();
                        }
                        else
                        {
                            txtSelectCity.Text = Convert.ToString(Page.RouteData.Values["city"]);

                            lblarea.Text = "Where in &nbsp" + txtSelectCity.Text + "&nbsp;?";
                            Session["ciyonload"] = txtSelectCity.Text;
                            BindtxtSearch();
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
                    txtSelectCity.Text = Convert.ToString(Page.RouteData.Values["city"]);

                    lblarea.Text = "Where in &nbsp" + txtSelectCity.Text + "&nbsp;?";
                    Session["ciyonload"] = txtSelectCity.Text;
                    BindtxtSearch();
                }
            }
            else
            {
                try
                {
                    if (txtSelectCity.Text != "")
                    {
                        city = txtSelectCity.Text;

                        lblarea.Text = "Where in &nbsp" + txtSelectCity.Text + "&nbsp;?";
                        Session["ciyonload"] = txtSelectCity.Text;
                        BindtxtSearch();
                    }
                    else
                    {
                        try
                        {
                            if (Session["ciyonload"] != null)
                            {
                                txtSelectCity.Text = Session["ciyonload"].ToString();
                                city = txtSelectCity.Text;

                                lblarea.Text = "Where in &nbsp" + txtSelectCity.Text + "&nbsp;?";
                                BindtxtSearch();
                            }
                            else
                            {
                                txtSelectCity.Text = "Hyderabad";
                                lblarea.Text = "Where in Hyderabad?";
                                BindtxtSearch();
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
            if (Session["rbtype"] != null)
            {
                if (Convert.ToString(Session["rbtype"]) == "Company Name")
                {
                    rb1comp.Checked = true;
                    rb2cat.Checked = false;
                }
                else if (Convert.ToString(Session["rbtype"]) == "Category")
                {
                    rb2cat.Checked = true;
                    rb1comp.Checked = false;
                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        
             //try
             //{
             //    //code for radio buttons of company and category
             //    if (rb1comp.Checked)
             //    {
             //        txtSearchFor.AutoPostBack = false;

             //    }
             //    else
             //    {
             //        txtSearchFor.AutoPostBack = true;
             //    }
             //    //check whether the querystring passed from footer is null or not
             //    //if (Request.QueryString["city"] != null)
             //    if (Convert.ToString(Page.RouteData.Values["city"]) != "")
             //    {
             //        if (txtSelectCity.Text != Convert.ToString(Page.RouteData.Values["city"]))
             //        {
                        
             //                if (txtSelectCity.Text != "")
             //                {

             //                    lblarea.Text = "Where in &nbsp" + txtSelectCity.Text + "&nbsp;?";
             //                    Session["ciyonload"] = txtSelectCity.Text;
             //                    BindtxtSearch();
             //                }
             //                else
             //                {
             //                    txtSelectCity.Text = Convert.ToString(Page.RouteData.Values["city"]);

             //                    lblarea.Text = "Where in &nbsp" + txtSelectCity.Text + "&nbsp;?";
             //                    Session["ciyonload"] = txtSelectCity.Text;
             //                    BindtxtSearch();
             //                }
                         
             //        }
             //        else
             //        {
             //            txtSelectCity.Text = Convert.ToString(Page.RouteData.Values["city"]);

             //            lblarea.Text = "Where in &nbsp" + txtSelectCity.Text + "&nbsp;?";
             //            Session["ciyonload"] = txtSelectCity.Text;
             //            BindtxtSearch();
             //        }
             //    }
             //    else
             //    {

             //        if (txtSelectCity.Text != "")
             //        {
             //            city = txtSelectCity.Text;

             //            lblarea.Text = "Where in &nbsp" + txtSelectCity.Text + "&nbsp;?";
             //            Session["ciyonload"] = txtSelectCity.Text;
             //            BindtxtSearch();
             //        }
             //        else
             //        {

             //            if (Convert.ToString(Session["ciyonload"]) != "")
             //            {
             //                txtSelectCity.Text = Convert.ToString(Session["ciyonload"]);
             //                city = txtSelectCity.Text;

             //                lblarea.Text = "Where in &nbsp" + txtSelectCity.Text + "&nbsp;?";
             //                BindtxtSearch();
             //            }
             //            else
             //            {
             //                txtSelectCity.Text = "Hyderabad";
             //                lblarea.Text = "Where in Hyderabad?";
             //                BindtxtSearch();
             //            }


             //        }
                    
             //    }
             //}
             //catch (Exception ex)
             //{
             //    obj.insert_exception(ex, excep_page);
             //    Response.Redirect("HttpErrorPage.aspx");
             //}       
       
    }
    //protected void txtcityCha1(object sender, EventArgs e)
    //{

    //    lblarea.Text = "Where in " + txtSelectCity.Text + "?";
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
                    if (txtSearchFor.Text != searchvalue)
                    {
                        if (txtSearchFor.Text != "")
                        {
                            Session["searchfor"] = txtSearchFor.Text;
                        }
                        else
                        {
                            txtSearchFor.Text = searchvalue;
                           
                            Session["searchfor"] = txtSearchFor.Text;
                        }
                    }
                    else
                    {
                        txtSearchFor.Text = searchvalue;
                        Session["searchfor"] = txtSearchFor.Text;
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
                searchvalue = obj.ReplaceCatnamewithorginalchars(Convert.ToString(Page.RouteData.Values["catname"]));
                try
                {
                    if (txtSearchFor.Text != searchvalue)
                    {
                        if (txtSearchFor.Text != "")
                        {
                            Session["searchfor"] = txtSearchFor.Text;
                        }
                        else
                        {
                            txtSearchFor.Text = searchvalue;

                            Session["searchfor"] = txtSearchFor.Text;
                        }
                    }
                    else
                    {
                        txtSearchFor.Text = searchvalue;

                        Session["searchfor"] = txtSearchFor.Text;
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
                    if (txtSearchFor.Text != searchvalue)
                    {
                        if (txtSearchFor.Text != "")
                        {
                            Session["searchfor"] = txtSearchFor.Text;
                        }
                        else
                        {

                            txtSearchFor.Text = searchvalue;
                            Session["searchfor"] = txtSearchFor.Text;
                        }
                    }
                    else
                    {
                        txtSearchFor.Text = searchvalue;
                        Session["searchfor"] = txtSearchFor.Text;
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
               searchvalue=obj.ReplaceCatnamewithorginalchars(Convert.ToString(Page.RouteData.Values["popcate"]));
                try
                {
                    if (txtSearchFor.Text != searchvalue)
                    {
                        if (txtSearchFor.Text != "")
                        {                          
                            Session["searchfor"] = txtSearchFor.Text;
                        }
                        else
                        {

                            txtSearchFor.Text = searchvalue;
                            Session["searchfor"] = txtSearchFor.Text;
                        }
                    }
                    else
                    {
                        txtSearchFor.Text = searchvalue;
                        Session["searchfor"] = txtSearchFor.Text;
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
                    if (txtSearchFor.Text != Convert.ToString(Page.RouteData.Values["scname"]))
                    {
                        if (txtSearchFor.Text != "")
                        {
                            obj.ReplaceCatnamewithorginalchars(txtSearchFor.Text);
                            Session["searchfor"] = txtSearchFor.Text;
                        }
                        else
                        {
                            txtSearchFor.Text = Convert.ToString(Page.RouteData.Values["scname"]);
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", " ");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("Dot", ".");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", "/");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", "_");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", "%20");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", "&");
                            Session["searchfor"] = txtSearchFor.Text;
                        }
                    }
                    else
                    {
                        txtSearchFor.Text = Convert.ToString(Page.RouteData.Values["scname"]);
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", " ");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("Dot", ".");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", "/");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", "_");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", "%20");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", "&");
                        Session["searchfor"] = txtSearchFor.Text;
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
                    if (txtSearchFor.Text != Convert.ToString(Page.RouteData.Values["rcname"]))
                    {
                        if (txtSearchFor.Text != "")
                        {
                            Session["searchfor"] = txtSearchFor.Text;
                        }
                        else
                        {
                            txtSearchFor.Text = Convert.ToString(Page.RouteData.Values["rcname"]);
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", " ");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("Dot", ".");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", "/");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", "_");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", "%20");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", "&");
                            Session["searchfor"] = txtSearchFor.Text;
                        }
                    }
                    else
                    {
                        txtSearchFor.Text = Convert.ToString(Page.RouteData.Values["rcname"]);
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", " ");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("Dot", ".");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", "/");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", "_");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", "%20");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", "&");
                        Session["searchfor"] = txtSearchFor.Text;
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
                    if (txtSearchFor.Text != Convert.ToString(Page.RouteData.Values["str"]))
                    {
                        if (txtSearchFor.Text != "")
                        {
                            Session["searchfor"] = txtSearchFor.Text;
                        }
                        else
                        {
                            txtSearchFor.Text = Convert.ToString(Page.RouteData.Values["str"]);
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", " ");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("Dot", ".");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", "/");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", "_");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", "%20");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", "&");
                            Session["searchfor"] = txtSearchFor.Text;
                        }
                    }
                    else
                    {
                        txtSearchFor.Text = Convert.ToString(Page.RouteData.Values["str"]);
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", " ");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("Dot", ".");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", "/");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", "_");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", "%20");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", "&");
                        Session["searchfor"] = txtSearchFor.Text;
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
                    if (txtSearchFor.Text != Convert.ToString(Page.RouteData.Values["Dcname"]))
                    {
                        if (txtSearchFor.Text != "")
                        {
                            Session["searchfor"] = txtSearchFor.Text;
                        }
                        else
                        {
                            txtSearchFor.Text = Convert.ToString(Page.RouteData.Values["Dcname"]);
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", " ");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("Dot", ".");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", "/");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", "_");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", "%20");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", "&");
                            Session["searchfor"] = txtSearchFor.Text;
                        }
                    }
                    else
                    {
                        txtSearchFor.Text = Convert.ToString(Page.RouteData.Values["Dcname"]);
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", " ");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("Dot", ".");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", "/");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", "_");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", "%20");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", "&");
                        Session["searchfor"] = txtSearchFor.Text;
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
                    if (txtSearchFor.Text != Convert.ToString(Page.RouteData.Values["Dscname"]))
                    {
                        if (txtSearchFor.Text != "")
                        {
                            Session["searchfor"] = txtSearchFor.Text;
                        }
                        else
                        {
                            txtSearchFor.Text = Convert.ToString(Page.RouteData.Values["Dscname"]);
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", " ");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("Dot", ".");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", "/");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", "_");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", "%20");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", "&");
                            Session["searchfor"] = txtSearchFor.Text;
                        }
                    }
                    else
                    {
                        txtSearchFor.Text = Convert.ToString(Page.RouteData.Values["Dscname"]);
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", " ");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("Dot", ".");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", "/");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", "_");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", "%20");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", "&");
                        Session["searchfor"] = txtSearchFor.Text;
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
                    if (txtSearchFor.Text != Convert.ToString(Page.RouteData.Values["pageid"]))
                    {
                        if (txtSearchFor.Text != "")
                        {
                            Session["searchfor"] = txtSearchFor.Text;
                        }
                        else
                        {
                            txtSearchFor.Text = Convert.ToString(Page.RouteData.Values["pageid"]);
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", " ");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("Dot", ".");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", "/");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", "_");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", "%20");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", "&");
                            Session["searchfor"] = txtSearchFor.Text;
                        }
                    }
                    else
                    {
                        txtSearchFor.Text = Convert.ToString(Page.RouteData.Values["pageid"]);
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", " ");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("Dot", ".");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", "/");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", "_");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", "%20");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", "&");
                        Session["searchfor"] = txtSearchFor.Text;
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
                    if (txtSearchFor.Text != Convert.ToString(Page.RouteData.Values["compname"]))
                    {
                        if (txtSearchFor.Text != "")
                        {
                            Session["searchfor"] = txtSearchFor.Text;
                        }
                        else
                        {
                            txtSearchFor.Text = Convert.ToString(Page.RouteData.Values["compname"]);
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", " ");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("Dot", ".");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", "/");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", "_");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", "%20");
                            txtSearchFor.Text = txtSearchFor.Text.Replace("-", "&");
                            Session["searchfor"] = txtSearchFor.Text;
                        }
                    }
                    else
                    {
                        txtSearchFor.Text = Convert.ToString(Page.RouteData.Values["compname"]);
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", " ");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("Dot", ".");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", "/");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", "_");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", "%20");
                        txtSearchFor.Text = txtSearchFor.Text.Replace("-", "&");
                        Session["searchfor"] = txtSearchFor.Text;
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
        Session.Clear();
        try
        {
            if (rb2cat.Checked == true)
            {
                Session["rbtype"] = "Category";
                if (txtWhereIn.Text != "")
                {

                    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from ModulesData where City like '%" + txtSelectCity.Text + "%' and ((Category  in ('" + txtSearchFor.Text + "')) or (module  in ('" + txtSearchFor.Text + "')) or (SubCategory  in ('" + txtSearchFor.Text + "'))) and Area like '%" + txtWhereIn.Text + "%' and ApprovedStatus='1' order by id desc ", con);
                    da.Fill(ds, "data");
                    //Session["sss"] = ds;
                    con.Close();

                }
                else
                {

                    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from ModulesData where City like '%" + txtSelectCity.Text + "%' and ((Category  in ('" + txtSearchFor.Text + "')) or (module  in ('" + txtSearchFor.Text + "')) or (SubCategory  in ('" + txtSearchFor.Text + "'))) and ApprovedStatus=1 ", con);
                    da.Fill(ds, "data");
                    //Session["sss"] = ds;
                    con.Close();


                }
                Session["Searchcat"] = txtSearchFor.Text;
                Session["area"] = txtWhereIn.Text;
                Session["searchcname"] = "";
                Session["value"] = txtSearchFor.Text;
                Session["city"] = txtSelectCity.Text;
                //txtSearchFor.Text = txtSearchFor.Text.Replace(" ", "-");
                //txtSearchFor.Text = txtSearchFor.Text.Replace(".", "Dot");
                //txtSearchFor.Text = txtSearchFor.Text.Replace("/", "-");
                //txtSearchFor.Text = txtSearchFor.Text.Replace("_", "-");
                //txtSearchFor.Text = txtSearchFor.Text.Replace("%20", "-");
                txtSearchFor.Text=obj.ReplaceSpecialchars(txtSearchFor.Text);

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
                            //Response.RedirectToRoute("Searchresults", new { cname = txtSearchFor.Text, city = txtSelectCity.Text, area = txtWhereIn.Text });
                            Response.RedirectToRoute("lnkresultss", new { pcname = txtSearchFor.Text, city = txtSelectCity.Text });
                            //redirect("linkresults.aspx?cname=" + txtSearchFor.Text + "&city=" + txtSelectCity.Text + "", false);
                        }
                   
                }
                else
                {
                    //redirect("Search-Not-Found.aspx?cname=" + txtSearchFor.Text + "&city=" + txtSelectCity.Text + "", false);
                    //Response.RedirectToRoute("SearchNotFoundPage", new { cname = txtSearchFor.Text, city = txtSelectCity.Text, area = txtWhereIn.Text });
                    Response.RedirectToRoute("SearchResultPage", new { cname = txtSearchFor.Text, city = txtSelectCity.Text });
                }
            }
            else if (rb1comp.Checked == true)
            {
                Session["rbtype"] = "Company Name";
                if (txtWhereIn.Text != "")
                {
                    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from ModulesData where City like '%" + txtSelectCity.Text + "%' and company_name like '%" + txtSearchFor.Text + "%' and Area='%" + txtWhereIn.Text + "%' and ApprovedStatus='1' order by id desc ", con);
                    da.Fill(ds, "data");
                    //Session["sss"] = ds;
                    con.Close();

                }
                else
                {
                    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from ModulesData where City like '%" + txtSelectCity.Text + "%' and company_name like '%" + txtSearchFor.Text + "%' and ApprovedStatus='1' order by id desc", con);
                    da.Fill(ds, "data");
                    //Session["sss"] = ds;
                    con.Close();


                }
                Session["Searchcat"] = "";
                Session["area"] = txtWhereIn.Text;
                //Session["cname"] = txtSearchFor.Text;
                Session["searchcname"] = txtSearchFor.Text;
                Session["value"] = txtSearchFor.Text;
                Session["city"] = txtSelectCity.Text;
                 txtSearchFor.Text=obj.ReplaceSpecialchars(txtSearchFor.Text);

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
                            
                            //redirect("linkresults.aspx?cname=" + txtSearchFor.Text + "&city=" + txtSelectCity.Text + "", false);
                            Response.RedirectToRoute("lnkresultss", new { pcname = txtSearchFor.Text, city = txtSelectCity.Text });
                           // Response.RedirectToRoute("Searchresults", new { cname = txtSearchFor.Text, city = txtSelectCity.Text, area = txtWhereIn.Text });
                        }
                   
                }
                else
                {
                    //Response.RedirectToRoute("SearchNotFoundPage", new { cname = txtSearchFor.Text, city = txtSelectCity.Text, area = txtWhereIn.Text });
                    Response.RedirectToRoute("SearchResultPage", new { cname = txtSearchFor.Text, city = txtSelectCity.Text });
                    //redirect("Search-Not-Found.aspx?cname=" + txtSearchFor.Text + "&city=" + txtSelectCity.Text + "", false);
                }

            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }  
    }
    //protected void txtSearchFor_TextChanged(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        if (rb2cat.Checked == true)
    //        {
               
    //                if (txtWhereIn.Text != "")
    //                {
    //                    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    //                    con.Open();
    //                    SqlDataAdapter da = new SqlDataAdapter("select * from ModulesData where City like '%" + txtSelectCity.Text + "%' and (Category like '%" + txtSearchFor.Text + "%' or module like '%" + txtSearchFor.Text + "%' or SubCategory like '%" + txtSearchFor.Text + "%' ) and Area like '%" + txtWhereIn.Text + "%' and ApprovedStatus='1' order by id desc ", con);
    //                    da.Fill(ds, "data");
    //                    //Session["sss"] = ds;
    //                    con.Close();

    //                }
    //                else
    //                {
    //                    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    //                    con.Open();
    //                    SqlDataAdapter da = new SqlDataAdapter("select * from ModulesData where City like '%" + txtSelectCity.Text + "%' and (Category like '%" + txtSearchFor.Text + "%' or module like '%" + txtSearchFor.Text + "%' or SubCategory like '%" + txtSearchFor.Text + "%' ) and ApprovedStatus='1' order by id desc", con);
    //                    da.Fill(ds, "data");
    //                    //Session["sss"] = ds;
    //                    con.Close();


    //                }
    //                Session["cat"] = txtSearchFor.Text;
    //                Session["area"] = txtWhereIn.Text;
    //                Session["cname"] = "";
    //                Session["value"] = txtSearchFor.Text;
    //                Session["city"] = txtSelectCity.Text;
                 
               
    //        }
    //        else if (rb1comp.Checked == true)
    //        {
                
    //                if (txtWhereIn.Text != "")
    //                {
    //                    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    //                    con.Open();
    //                    SqlDataAdapter da = new SqlDataAdapter("select * from ModulesData where City like '%" + txtSelectCity.Text + "%' and company_name like '%" + txtSearchFor.Text + "%' and Area='%" + txtWhereIn.Text + "%' and ApprovedStatus='1' order by id desc ", con);
    //                    da.Fill(ds, "data");
    //                    //Session["sss"] = ds;
    //                    con.Close();

    //                }
    //                else
    //                {
    //                    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    //                    con.Open();
    //                    SqlDataAdapter da = new SqlDataAdapter("select * from ModulesData where City like '%" + txtSelectCity.Text + "%' and company_name like '%" + txtSearchFor.Text + "%' and ApprovedStatus='1' order by id desc", con);
    //                    da.Fill(ds, "data");
    //                    //Session["sss"] = ds;
    //                    con.Close();

    //                }
    //                Session["cat"] = "";
    //                Session["area"] = txtWhereIn.Text;
    //                Session["cname"] = txtSearchFor.Text;
    //                Session["value"] = txtSearchFor.Text;
    //                Session["city"] = txtSelectCity.Text;
    //         }
            
    //    }
    //    catch (Exception ex)
    //    {
    //        obj.insert_exception(ex, excep_page);
    //        Response.Redirect("HttpErrorPage.aspx");
    //    }
    //}
    protected void adv_search_Click(object sender, EventArgs e)
    {
        try
        {
            string advcity = txtSelectCity.Text;
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