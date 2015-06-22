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

public partial class discount_left : System.Web.UI.UserControl
{
    InsertData obj = new InsertData();
    string sid = string.Empty;
    int id;
    Binddata objBd = new Binddata();
    string Module_Name = string.Empty;
    string strname = string.Empty;
    string strScript = string.Empty;
    static string excep_page = "discount_left.ascx";
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            DlCate.Visible = true;
            DataSet ds = new DataSet();
            //ds = obj.bindcategory();
            Module_Name = "Category";
            if (!IsPostBack)
            {
                //SqlCommand cmd = new SqlCommand("DiscountCateUC_SP", con);
                ds = objBd.getDiscountCate(Module_Name);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DlCate.DataSource = ds;
                    DlCate.DataBind();
                }

                if (Convert.ToString(Page.RouteData.Values["Dcname"]) != "")
                {
                    try
                    {
                        strname = Convert.ToString(Page.RouteData.Values["Dcname"]);
                        Session["Dcname"] = strname;
                        trRelatedSubCat.Visible = true;
                        trDlSubcat.Visible = true;
                        DataSet dsDcname = new DataSet();
                        dsDcname = objBd.BindDLSubCat(strname);
                        if (dsDcname.Tables[0].Rows.Count > 0)
                        {
                            DlSubcat.DataSource = dsDcname;
                            DlSubcat.DataBind();
                        }
                        else
                        {
                            trRelatedSubCat.Visible = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        obj.insert_exception(ex, excep_page);
                        Response.Redirect("HttpErrorPage.aspx");
                    }
                }
                if (Convert.ToString(Page.RouteData.Values["Dscname"]) != "")
                {
                    try
                    {
                        strname = Convert.ToString(Session["Dcname"]);
                        trRelatedSubCat.Visible = true;
                        trDlSubcat.Visible = true;
                        DataSet dsDcname = new DataSet();
                        dsDcname = objBd.BindDLSubCat(strname);
                        if (dsDcname.Tables[0].Rows.Count > 0)
                        {
                            DlSubcat.DataSource = dsDcname;
                            DlSubcat.DataBind();
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
    protected string GetSCatUrl(object DScat)
    {
        string DSCate = DScat.ToString();
        return Page.GetRouteUrl("Discountsubcat_link", new { Dscname = DSCate, cname = "discounts" });
    }
    protected string GetCatUrl(object Dcat)
    {
        string DCate = Dcat.ToString();
        return Page.GetRouteUrl("Discountcat_link", new { Dcname = DCate, cname = "discounts" });
    }
     //protected void DlCate_ItemCommand(object source, DataListCommandEventArgs e)
     //{
     //    try
     //    {
     //        string Dcname = "";
     //        Dcname = e.CommandArgument.ToString();
     //        Response.RedirectToRoute("Discountcat_link", new { Dcname = Dcname, cname = "discounts" });
     //        //redirect("Discountlink.aspx?Dcname=" + Server.UrlEncode(name) + "&cname=discounts", false);
     //    }
     //    catch (Exception ex)
     //    {
     //        obj.insert_exception(ex, excep_page);
     //        Response.Redirect("HttpErrorPage.aspx");
     //    }
     //}
     //protected void DlSubcat_ItemCommand(object source, DataListCommandEventArgs e)
     //{
     //    try
     //    {
     //        string Dscname = "";
     //        Dscname = e.CommandArgument.ToString();
     //        Response.RedirectToRoute("Discountsubcat_link", new { Dscname = Dscname, cname = "discounts" });
     //        //redirect("Discountlink.aspx?Dscname=" + Server.UrlEncode(name) + "&cname=discounts", false);
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
    protected void DlCate_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        try
        {
            HyperLink Hypcate = (HyperLink)e.Item.FindControl("Hypcate");

            if (Hypcate != null)
            {
                if (Hypcate.Text == "")
                {
                    Hypcate.Text = Hypcate.ToolTip.ToString();


                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void DlSubcat_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        try
        {
            HyperLink HypScat = (HyperLink)e.Item.FindControl("HypScat");

            if (HypScat != null)
            {
                if (HypScat.Text == "")
                {
                    HypScat.Text = HypScat.ToolTip.ToString();

                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
   
}
