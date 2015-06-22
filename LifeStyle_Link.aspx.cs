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

public partial class LifeStyle_Link : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    InsertData obj = new InsertData();
    static string excep_page = "LifeStyle_Link.aspx";
    string city;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            //con.Open();
            DataSet ds = new DataSet();
            string str = string.Empty;
            if (Session["ciyonload"] != null)
            {
                city = Session["ciyonload"].ToString();
            }
            else
            {
                city = "Hyderabad";
            }
            //cname
            if (Convert.ToString(Page.RouteData.Values["Lcatname"]) != null)
            {
                try
                {
                    str = Convert.ToString(Page.RouteData.Values["Lcatname"]);
                    //str = str.Replace("-", "&");
                    if (str.Contains("amprcent"))
                    {
                        str = str.Replace("amprcent", "&");
                    }
                    if (str.Contains("space"))
                    {
                        str = str.Replace("space", " ");
                    }
                    if (str.Contains("Dot"))
                    {
                        str = str.Replace("Dot", ".");
                    }
                    if (str.Contains("slash"))
                    {
                        str = str.Replace("slash", "/");
                    }
                    if (str.Contains("undrscore"))
                    {
                        str = str.Replace("undrscore", "_");
                    }
                    LifestyleCate.Text = str;
                    SqlDataAdapter da = new SqlDataAdapter("select *,stuff(\"company_name\", 22, len(company_name), '...') as compname,company_name from modulesdata where CatSub='" + str + "'and ApprovedStatus=1 order by id desc", con);
                    da.Fill(ds);
                    if (!ds.Tables[0].Rows.Count.Equals(0))
                    {
                        dllifestyle.DataSource = ds;
                        dllifestyle.DataBind();

                    }
                    else
                        //redirect("Search-Not-Found.aspx?cname=" + Server.UrlEncode(str) + "&city=" + Server.UrlEncode(city), false);
                        Response.RedirectToRoute("SearchResultPage", new { cname = str, city = city });
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }

            }
            else if (Convert.ToString(Page.RouteData.Values["catname"]) != null)
            {
                try
                {
                    str = Convert.ToString(Page.RouteData.Values["catname"]);
                    LifestyleCate.Text = str;
                    SqlDataAdapter da = new SqlDataAdapter("select *,stuff(\"company_name\", 22, len(company_name), '...') as compname,company_name from modulesdata where Category='" + str + "'and ApprovedStatus=1 order by id desc", con);
                    da.Fill(ds);
                    if (!ds.Tables[0].Rows.Count.Equals(0))
                    {
                        dllifestyle.DataSource = ds;
                        dllifestyle.DataBind();
                        con.Close();
                    }
                    else
                        //redirect("Search-Not-Found.aspx?cname=" + Server.UrlEncode(str) + "&city=" + Server.UrlEncode(city), false);
                        Response.RedirectToRoute("SearchResultPage", new { cname = str, city = city });

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
    protected void dllifestyle_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        try
        {
            Label lblImgName = (Label)e.Item.FindControl("lblImgName");
            Image img = (Image)e.Item.FindControl("imglogo");
            HtmlTableCell colimg = (HtmlTableCell)e.Item.FindControl("tdlogo");
            if (lblImgName != null)
            {
                try
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
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }


            }

            Label lblDataId = (Label)e.Item.FindControl("lblDataId");
            Label lblnoofratings = (Label)e.Item.FindControl("lblnoofratings");
            //Label lblImgName = (Label)e.Item.FindControl("lblImgName");


            if (lblDataId != null)
            {
                try
                {
                    string dataId = Convert.ToString(lblDataId.Text);
                    //con.Open();
                    SqlCommand cmd = new SqlCommand("Select count(rid) as NumberOfUsers,sum(Stars_Rating) as Total from PostReview where dataid='" + dataId + "'", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    float count = 0, rating = 0, result = 0;

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
    protected string GetCompyUrl(object Lid)
    {
        string lifeId = Lid.ToString();
        lifeId = lifeId.Replace("&", "-");
        return Page.GetRouteUrl("LifestyleDetails", new { id = lifeId });
    }

}