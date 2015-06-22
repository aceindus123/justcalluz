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
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Web.Routing;

public partial class view_discounts : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    string userid;
    InsertData obj = new InsertData();
    static string excep_page = "view_discounts.aspx";
    /// <summary>
    /// While viewing discount ,To check whether the user is loggedin or not if so ,is he is registered as business type ? assuming that may session will get closed.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            //ddlPageSize.Visible = false;
            userid = Convert.ToString(Session["USERID"]);
            string regtype = Convert.ToString(Session["RegType"]);
            if (userid != "" && regtype == "Business")
            {
            }
            else if (userid != "" && regtype == "Individual")
            {
                //redirect("AuthenticationMsg.aspx?msg=Discount",false);
                Response.RedirectToRoute("AuthenticationMsg", new { msg = "Discount" });
            }
            else
                //redirect("signin.aspx?Qname=ViewDiscount",false);
                Response.RedirectToRoute("Signin", new { Qname = "ViewDiscount" });

            if (!IsPostBack)
            {
                Bindddldiscounts();

            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    /// Bind the data from the database related to the posted discount based on userid 
    /// </summary>
    PagedDataSource pds = new PagedDataSource();
    protected void Bindddldiscounts()
    {
        try
        {
            string userid = Convert.ToString(Session["USERID"]);
            SqlCommand cmd = new SqlCommand("view_discounts", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserLoginId", userid);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            pds.DataSource = dt.DefaultView;
            pds.AllowPaging = true;
            pds.PageSize = 3;
            //pds.PageSize = Convert.ToInt16(ddlPageSize.SelectedValue);
            pds.CurrentPageIndex = CurrentPage;
            imgNext.Enabled = !pds.IsLastPage;
            imgPrevious.Enabled = !pds.IsFirstPage;
            ddldiscounts.DataSource = pds;
            ddldiscounts.DataBind();
            //doPaging();
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
            Bindddldiscounts();
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
            Bindddldiscounts();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lnkBtnTocheckPostings_Click(object sender, EventArgs e)
    {
        try
        {
            if (Session["USERID"] != null)
            {
                redirect("ToCheckPostings.aspx?id=" + userid, false);
                ////Response.RedirectToRoute("checkposting", new { id = userid });
            }
            else
            {
                string strScript = "";
                strScript = "alert('Your session is expired. Please Relogin'); location.replace('signin');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void ddldiscounts_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        try
        {
            HtmlTableCell tdimge = (HtmlTableCell)e.Item.FindControl("tdlogo");
            Label imgname = (Label)e.Item.FindControl("lblImgName");
            if (imgname != null)
            {
                if (imgname.Text == "NULL" || imgname.Text == "0" || imgname.Text == "" || imgname.Text == "null")
                {
                    tdimge.Visible = false;
                }
                else
                {
                    tdimge.Visible = true;
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
    protected string GetEditUrl(object Eid)
    {
        string EditDid=Eid.ToString();
        //EditDid = EditDid.Replace(",", "/");
        return Page.GetRouteUrl("EditDiscount", new { id = EditDid, cname = "discounts" });
    }
    protected string GetUrl(object Vid)
    {
        string VDiscountid = Vid.ToString();
        return Page.GetRouteUrl("ViewDiscountDetails", new { id = VDiscountid });
    }

}
