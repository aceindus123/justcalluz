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
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Web.Routing;
using JustCallUsData.Data;

public partial class Education : System.Web.UI.Page
{
    //To make connection
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    InsertData obj = new InsertData();
    PagedDataSource pds = new PagedDataSource();
    string strname = string.Empty;
    string scname;
    string rname;
    string city;
    string dataId = string.Empty;
    static string excep_page = "Education.aspx";
    DataCS obj1 = new DataCS();
    /// <summary>
    /// Executes whenever page loads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Convert.ToString(Session["ciyonload"]) != "")
            {
                city = Convert.ToString(Session["ciyonload"]);
            }
            else
            {
                city = "Hyderabad";
            }

            if (Convert.ToString(Page.RouteData.Values["cname"]) != "")
            {
                strname = Convert.ToString(Page.RouteData.Values["cname"]).Trim();
                Label10.Text = strname;
                Label11.Text = strname;
            }
           // else if (Page.RouteData.Values["rcname"] != null)
           // {
            //    rname = Convert.ToString(Page.RouteData.Values["rcname"]).Trim();
            //    Label10.Text = rname;
           //     Label11.Text = rname;
           //     leftrestaurant(rname);
           // }
            else
            {
                scname = Convert.ToString(Page.RouteData.Values["scname"]).Trim();
                Label10.Text = scname;
                Label11.Text = scname;
                leftrestaurant(scname);

            }
           // con.Open();

            //strname = Session["name"].ToString();

            if (!IsPostBack)
            {
                if (strname != "")
                {
                    BindGrid();
                }
                //else if (rname != "")
               // {
               //     leftrestaurant(rname);
               // }
                else
                {
                    leftrestaurant(scname);
                }
                //else
                //{
                //    BindGrid1();
                //}
            }
           // con.Close();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    /// <summary>
    /// To bind the categories data
    /// </summary>
    public void BindGrid()
    {
        try
        {
            string strname = string.Empty;
            strname = Convert.ToString(Page.RouteData.Values["cname"]);
            SqlDataAdapter dacname = new SqlDataAdapter("select *,stuff(\"company_name\", 22, len(company_name), '...') as compname from ModulesData where (Category=('" + strname + "') or company_name=('" + strname + "') or SubCategory=('" + strname + "')) and City='" + city + "' and ApprovedStatus='1' order by id desc ", con);
            //da1.Fill(ds1, "data");
            DataSet dscname = new DataSet();
            dacname.Fill(dscname);
            if (dscname.Tables[0].Rows.Count > 0)
            {
                //Session["id"] = id;
                pds.DataSource = dscname.Tables[0].DefaultView;
                pds.AllowPaging = true;
                //pds.PageSize = Convert.ToInt16(ddlPageSize.SelectedValue);
                pds.PageSize = 10;
                if (dscname.Tables[0].Rows.Count < pds.PageSize)
                {
                    pds.CurrentPageIndex = CurrentPage;
                    DLBindCatData.DataSource = pds;
                    DLBindCatData.DataBind();
                    imgbtnSendMAIL.Visible = true;
                }
                else
                {
                    trPaging.Visible = true;
                    pds.CurrentPageIndex = CurrentPage;
                    imgNext.Enabled = !pds.IsLastPage;
                    imgPrevious.Enabled = !pds.IsFirstPage;
                    DLBindCatData.DataSource = pds;
                    DLBindCatData.DataBind();
                    imgbtnSendMAIL.Visible = true;
                }

            }
            else
            {
                //redirect("Search-Not-Found.aspx?cname=" + Server.UrlEncode(strname) + "&city=" + Server.UrlEncode(city), false);
                Response.RedirectToRoute("SearchResultPage", new { cname = strname, city = city });
               // Page.GetRouteUrl("SearchResultPage", new { cname = strname, city = city });

              
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
        try
        {
            CurrentPage -= 1;
            if (strname != "")
            {
                BindGrid();
            }
            //else if (rname != "")
            //{
            //    leftrestaurant(rname);

           // }
            else
            {
                leftrestaurant(scname);
            }
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
            if (strname != "")
            {
                BindGrid();
            }
           // else if (rname != "")
           // {
           //     leftrestaurant(rname);

          //  }
            else
            {
                leftrestaurant(scname);
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    ///// <summary>
    ///// To do paging
    ///// </summary>
    //private void doPaging()
    //{
    //    DataTable dt = new DataTable();
    //    dt.Columns.Add("PageIndex");
    //    dt.Columns.Add("PageText");
    //    for (int i = 0; i < pds.PageCount; i++)
    //    {
    //        DataRow dr = dt.NewRow();
    //        dr[0] = i;
    //        dr[1] = i + 1;
    //        dt.Rows.Add(dr);
    //    }
    //    dlPaging.DataSource = dt;
    //    dlPaging.DataBind();
    //}
    ///// <summary>
    ///// To do for page changing
    ///// </summary>
    ///// <param name="source"></param>
    ///// <param name="e"></param>
    //protected void dlPaging_ItemCommand(object source, DataListCommandEventArgs e)
    //{
    //    if (e.CommandName.Equals("lnkbtnPaging"))
    //    {
    //        CurrentPage = Convert.ToInt16(e.CommandArgument.ToString());
    //        if (strname!=null)
    //        {
    //            BindGrid();
    //        }
    //        else if(rname!=null)
    //        {
    //            leftrestaurant(rname);

    //        }
    //        else
    //        {
    //            leftrestaurant(scname);
    //        }
    //    }
    //}
    ///// <summary>
    ///// Function to go prevoius page
    ///// </summary>
    ///// <param name="sender"></param>
    ///// <param name="e"></param>
    //protected void lnkbtnPrevious_Click1(object sender, EventArgs e)
    //{
    //    CurrentPage -= 1;
    //    if (strname != "")
    //    {
    //        BindGrid();
    //    }
    //    else if (rname != "")
    //    {
    //        leftrestaurant(rname);

    //    }
    //    else
    //    {
    //        leftrestaurant(scname);
    //    }
    //}
    ///// <summary>
    ///// Function to go next page
    ///// </summary>
    ///// <param name="sender"></param>
    ///// <param name="e"></param>
    //protected void lnkbtnNext_Click1(object sender, EventArgs e)
    //{
    //    CurrentPage += 1;
    //    if (strname != "")
    //    {
    //        BindGrid();
    //    }
    //    else if (rname != "")
    //    {
    //        leftrestaurant(rname);

    //    }
    //    else
    //    {
    //        leftrestaurant(scname);
    //    }
    //}
    ///// <summary>
    ///// To change page size
    ///// </summary>
    ///// <param name="sender"></param>
    ///// <param name="e"></param>
    //protected void ddlPageSize_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    CurrentPage = 0;
    //    if (strname != "")
    //    {
    //        BindGrid();
    //    }
    //    else if (rname != "")
    //    {
    //        leftrestaurant(rname);

    //    }
    //    else
    //    {
    //        leftrestaurant(scname);
    //    }
    //}
    ///// <summary>
    ///// Paging item data bound
    ///// </summary>
    ///// <param name="sender"></param>
    ///// <param name="e"></param>
    //protected void dlPaging_ItemDataBound(object sender, DataListItemEventArgs e)
    //{
    //    LinkButton lnkbtnPage = (LinkButton)e.Item.FindControl("lnkbtnPaging");
    //    if (lnkbtnPage.CommandArgument.ToString() == CurrentPage.ToString())
    //    {
    //        lnkbtnPage.Enabled = false;
    //        lnkbtnPage.Font.Bold = true;
    //    }
    //}

   /// <summary>
    /// Function to display records when click on the sponsored links
    /// </summary>
    /// <param name="source"></param>
    /// <param name="e"></param>
    //protected void dlsponsoredlinks_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    //{
    //    Session["name"] = e.CommandArgument.ToString();
    //    string name = "";
    //    name = e.CommandArgument.ToString();
    //    Response.Redirect("linkcontroller.aspx?cname=" + name + "");
    //}
    public void leftrestaurant(string subcat)
    {
        try
        {
            SqlDataAdapter dasubcat = new SqlDataAdapter("select *,stuff(\"company_name\", 22, len(company_name), '...') as compname from ModulesData where SubCategory='" + subcat + "'and City='" + city + "'and ApprovedStatus='1' order by id desc ", con);
            //da1.Fill(ds1, "data");
            DataSet dssubcat = new DataSet();
            dasubcat.Fill(dssubcat);
            if (dssubcat.Tables[0].Rows.Count > 0)
            {
                pds.DataSource = dssubcat.Tables[0].DefaultView;
                pds.AllowPaging = true;
                //pds.PageSize = Convert.ToInt16(ddlPageSize.SelectedValue);
                pds.PageSize = 10;
                if (dssubcat.Tables[0].Rows.Count < pds.PageSize)
                {
                    pds.CurrentPageIndex = CurrentPage;
                    DLBindCatData.DataSource = pds;
                    DLBindCatData.DataBind();
                    imgbtnSendMAIL.Visible = true;
                }
                else
                {
                    trPaging.Visible = true;
                    pds.CurrentPageIndex = CurrentPage;
                    imgNext.Enabled = !pds.IsLastPage;
                    imgPrevious.Enabled = !pds.IsFirstPage;
                    DLBindCatData.DataSource = pds;
                    DLBindCatData.DataBind();
                    imgbtnSendMAIL.Visible = true;
                }
            }
            else
            {
                //redirect("Search-Not-Found.aspx?cname=" + Server.UrlEncode(subcat) + "&city=" + Server.UrlEncode(city), false);
                Response.RedirectToRoute("SearchResultPage", new { cname = subcat, city = city });
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

    protected void DLBindCatData_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            Label lblDataId = (Label)e.Item.FindControl("lblDataId");
            Label lblnoofratings = (Label)e.Item.FindControl("lblnoofratings");
            HtmlTableCell tdimge = (HtmlTableCell)e.Item.FindControl("tdlogo");
            Label imgname = (Label)e.Item.FindControl("lblImgName");
            HyperLink lnkmap = (HyperLink)e.Item.FindControl("lnkmap");
            Label lblSlash = (Label)e.Item.FindControl("lblSlash");
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

            if (lblDataId != null)
            {
                dataId = Convert.ToString(lblDataId.Text);
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
               // testSpan0.Style.Add("width", result + "px");
                testSpan0.Width = Convert.ToInt32(result);
                //testSpan0.Style.Add("width", result + "px");
                //con.Close();
                lblnoofratings.Text = Convert.ToString(count);

                SqlDataAdapter mapadapter = new SqlDataAdapter("select id,map,Approved_map from modulesdata where id='" + dataId + "' and Approved_map=1", con);
                DataSet dsmap = new DataSet();
                mapadapter.Fill(dsmap);
                if (!dsmap.Tables[0].Rows.Count.Equals(0))
                {
                    pnlmap.Visible = true;
                    dlmap.Visible = true;
                    dlmap.DataSource = dsmap;
                    dlmap.DataBind();
                }
                else
                {
                    lblSlash.Visible = false;
                    lnkmap.Visible = false;

                }
            }
            HyperLink hypCompany = (HyperLink)e.Item.FindControl("hypCompany");
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
    protected void imgbtnGo_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            strname = Convert.ToString(Page.RouteData.Values["cname"]).Trim();
            string name = Convert.ToString(txtname.Text);
            string mobile = Convert.ToString(txtmob.Text);
            string emailid = Convert.ToString(txtemail.Text);
            string subject = "Response to your search for " + strname;
            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            Server.Execute("SendEmail.aspx?name=" + name + "&cat=" + strname + "&city=" + city, htw,true);
            //Server.Execute("Mail-" + name + "-" + strname + "-" + city, htw);
            Mail.sendmail("info@justcalluz.com", emailid, subject, sw.ToString());
            string strScript = "";
            strScript = "alert('Your mail is sent successfully !!! SMS sent process not done at this time !!!');";

            string msgtxt = obj1.sendSms(name, strname, city, DLBindCatData);
            if (msgtxt != "")
            {
                SMSCAPI objSms = new SMSCAPI();
                objSms.SendSMS(Convert.ToString(ConfigurationManager.AppSettings["SmsUsername"]), Convert.ToString(ConfigurationManager.AppSettings["SmsPassword"]), mobile, msgtxt);
                strScript = "alert('You will receive Mail and SMS shortly.');";
            }
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void btnXSendSMS_Click(object sender, ImageClickEventArgs e)
    {

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
    protected string GetViewUrl(object Eid)
    {
        string id = Eid.ToString();
        return Page.GetRouteUrl("CT_sessionstore", new { id = id });
    }
    protected string GetCompUrl(object Eid, object ECname)
    {
        string id = Eid.ToString();
        string cname = ECname.ToString();
        return Page.GetRouteUrl("Sessionstoreedu", new { id = id });
    }
    protected string GetRateUrl(object Eid)
    {
        string id = Eid.ToString();
        return Page.GetRouteUrl("CommonPostReviewCat", new { DataId = id });
    }
}
