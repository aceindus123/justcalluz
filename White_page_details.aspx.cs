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
using System.Web.Routing;

public partial class White_page_details : System.Web.UI.Page
{
    InsertData obj = new InsertData();
    DataCS data = new DataCS();
    string city;
    static string excep_page = "White_page_details.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            trMessage.Visible = false;
            lblMessage.Visible = false;
            if (Page.RouteData.Values["city"] != null)
            {
                city = Convert.ToString(Page.RouteData.Values["city"]);
                metadata(city);
                lblcity.Text = city;
                lblcity1.Text = city;
            }
            else
            {
                Response.RedirectToRoute("WhitePage");
            }

            if (!Page.IsPostBack)
            {
                string comp = Convert.ToString(Page.RouteData.Values["city"]);
                rpcompanies.Visible = true;
                DataSet ds = new DataSet();
                ds = obj.bindcompanies(comp);
                rpcompanies.DataSource = ds;
                rpcompanies.DataBind();

                DataSet ds1 = new DataSet();
                ds1 = data.BindWhitePages(city);
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    dlData.DataSource = ds1;
                    dlData.DataBind();
                }
                else
                {
                    trline.Visible = false;
                    trMessage.Visible = true;
                    lblMessage.Visible = true;
                    lblMessage.Text = "No records found";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected string GetUrl(object id)
    {
        string sid = id.ToString();
        return Page.GetRouteUrl("CT_sessionstore", new { id = sid });
    }
    protected void dlData_ItemDataBound(object sender, DataListItemEventArgs e)
    {
       
        HtmlTableRow trPara1 = (HtmlTableRow)e.Item.FindControl("trPara1");
        HtmlTableRow trPara2 = (HtmlTableRow)e.Item.FindControl("trPara2");
        HtmlTableRow trPara3 = (HtmlTableRow)e.Item.FindControl("trPara3");
        HtmlTableRow trPara4 = (HtmlTableRow)e.Item.FindControl("trPara4");
        HtmlTableRow trPara5 = (HtmlTableRow)e.Item.FindControl("trPara5");
        Label lblPara1 = (Label)e.Item.FindControl("lblPara1");
        Label lblPara2 = (Label)e.Item.FindControl("lblPara2");
        Label lblPara3 = (Label)e.Item.FindControl("lblPara3");
        Label lblPara4 = (Label)e.Item.FindControl("lblPara4");
        Label lblPara5 = (Label)e.Item.FindControl("lblPara5");
        try
        {
            if (lblPara1 != null)
            {
                trPara1.Visible = true;
            }
            if (lblPara2 != null)
            {
                trPara2.Visible = true;
            }
            if (lblPara3 != null)
            {
                trPara3.Visible = true;
            }
            if (lblPara4 != null)
            {
                trPara4.Visible = true;
            }
            if (lblPara5 != null)
            {
                trPara5.Visible = true;
            }
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
            pgtitle.Text = "Top Companies in " + modname + " | JustCalluz White Pages";
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
