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
using System.Web.Routing;

public partial class CityTrends_PopularCompanies : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    string city = string.Empty;
    string title = string.Empty;
    //CityTrendsCS obj = new CityTrendsCS();
    CityTrendsCS objData = new CityTrendsCS();
    PagedDataSource objPds = new PagedDataSource();
    string strScript = string.Empty;
    InsertData obj = new InsertData();
    static string excep_page = "CityTrends_PopularCompanies.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
           
            if (!IsPostBack)
            {
                city = Session["city"].ToString();
                lblCity.Text = city;
                GetMainInfo(city);
                metadata(city);
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    private void GetMainInfo(string City)
    {
        try
        {
            //city = Session["city"].ToString();
            city = City;
            lblCity.Text = city;
            DlMainInfo.Visible = true;
            //tblcate.Visible = true;
            DataSet dsmain = new DataSet();
            dsmain = objData.Get_popcompanies(city);
            if (!dsmain.Tables[0].Rows.Count.Equals(0))
            {
                objPds.DataSource = dsmain.Tables[0].DefaultView;
                objPds.AllowPaging = true;
                objPds.PageSize = 8;
                objPds.CurrentPageIndex = CurrentPage;
                cmdPrev.Enabled = !objPds.IsFirstPage;
                cmdNext.Enabled = !objPds.IsLastPage;
                DlMainInfo.DataKeyField = "id";
                DlMainInfo.DataSource = objPds;
                DlMainInfo.DataBind();
            }
            else
            {
                strScript = "alert('No records are available for selected city, Please Try with different city');location.replace('CityTrendz');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            }
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
            object o = this.ViewState["_CurrentPage"];
            if (o == null)
                return 0;
            else
                return (int)o;
        }
        set
        {
            this.ViewState["_CurrentPage"] = value;
        }
  
    }
    protected void cmdNext_Click(object sender, EventArgs e)
    {
        try
        {
            CurrentPage += 1;
            GetMainInfo(city);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void cmdPrev_Click(object sender, EventArgs e)
    {
        try
        {
            CurrentPage -= 1;
            GetMainInfo(city);
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
    protected void DlMainInfo_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        try
        {
            Label lblDataId = (Label)e.Item.FindControl("lblDataId");
            Label lblnoofratings = (Label)e.Item.FindControl("lblnoofratings");
            HtmlTableCell tdimge = (HtmlTableCell)e.Item.FindControl("tdlogo");
            Label imgname = (Label)e.Item.FindControl("lblImgName");
            if (imgname != null)
            {
                try
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
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }

            if (lblDataId != null)
            {
                try
                {
                    string dataId = Convert.ToString(lblDataId.Text);
                    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                    con.Open();
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
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected string GetUrl(object sid)
    {
        string sId = sid.ToString();
        return Page.GetRouteUrl("CT_sessionstore", new { id = sId });
    }
    protected void metadata(string modname)
    {
        try
        {
            pgtitle.Text = "Popular Companies in " + modname + " | justcalluz";
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
