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
using System.IO;
using System.Web.Routing;

public partial class City_TrendsCate : System.Web.UI.Page
{
    char[] separatorcomma = new char[] { ',' };
    string buslist;
    Int32 CTId;
    string mod;
    string city;
    DataCS data = new DataCS();
    DataSet ds = new DataSet();
    DataSet dsMovies = new DataSet();
    DataSet dsTheatres = new DataSet();
    DataSet dsBus = new DataSet();
    DataSet dsOther = new DataSet();
    //CityTrendsCS obj = new CityTrendsCS();
    char[] separator = new char[] { '-' };
    CityTrendsCS objCTCS = new CityTrendsCS();
    InsertData obj = new InsertData();
    static string excep_page = "City_TrendsDetails.aspx";
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

            CTId = Convert.ToInt32(Page.RouteData.Values["CtId"]);
            city = Convert.ToString(Session["city"]);
            lblCity.Text = city;
            if (!Page.IsPostBack)
            {
                GetCTs();
                if (mod == "Movies")
                {
                    trmoreinfo.Visible = false;
                    trcate.Visible = false;
                    trmoreinfo1.Visible = false;
                    trcate1.Visible = false;
                    GetCTMovieDetails();
                    metadata(mod);
                }
                else if (mod == "Businesses")
                {
                    trcate.Visible = false;
                    trmoreinfo.Visible = false;
                    trmoreinfo2.Visible = false;
                    trcate2.Visible = false;
                    GetCTBusDetails();
                    metadata(mod);
                }
                else
                {
                    trcate2.Visible = false;
                    trmoreinfo1.Visible = false;
                    trcate1.Visible = false;
                    trmoreinfo2.Visible = false;
                    GetOtherCatDetails();
                    metadata(mod);
                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        
    }
    private void GetCTBusDetails()
    {
        try
        {
            lblCity.Text = Convert.ToString(Session["city"]);
            tblcate.Visible = false;
            trTheatre.Visible = false;
            lblmodcate1.Text = mod;
            string strListing = Convert.ToString(lblListings.Text); ;
            string strlistIds = Convert.ToString(lblDataIds.Text);

            string[] strSplitArr1 = strListing.Split(separatorcomma);
            string[] strSplitArr2 = strlistIds.Split(separatorcomma);

            for (int i = 0; i < strSplitArr2.Length; i++)
            {
                string w1 = strSplitArr1[i].ToString();
                string[] ww = strSplitArr1[i].Split(separator);
                string company = ww[0];
                string id = strSplitArr2[i].ToString();
                string str1 = "select company_name,id,company_profile from ModulesData where company_name='" + company + "' and id='" + id + "'";
                SqlDataAdapter ada1 = new SqlDataAdapter(str1, con);
                ada1.Fill(dsBus, "Records1");
                foreach (string arrstrr in strSplitArr1)
                {
                    DataTable dt = dsBus.Tables["Records1"];
                    String[] keycolumns = new String[] { "company_name", "company_profile" };
                    RemoveDuplicates(dt, keycolumns);

                    dlBusinesDetails.DataSource = dsBus;
                    dlBusinesDetails.DataBind();
                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    private void GetCTs()
    {
        try
        {

            lblCity.Text = Convert.ToString(Session["city"]);
            trTheatre.Visible = false;
            ds = objCTCS.GetCTrendParticular(CTId);
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                mod = ds.Tables[0].Rows[0]["mod"].ToString();
                dlCT.DataSource = ds;
                dlCT.DataBind();
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void dlCT_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        Label lblmod = (Label)e.Item.FindControl("lblmod");
        Label lblListing = (Label)e.Item.FindControl("lblListing");
        Label lbldataId = (Label)e.Item.FindControl("lbldataId");
        Label lblsubtitle = (Label)e.Item.FindControl("lblsubtitle");
        HtmlTableRow trSubtitle = (HtmlTableRow)e.Item.FindControl("trSubtitle");
        if (lblsubtitle != null)
        {
            if (lblsubtitle.Text != "")
            {
                trSubtitle.Visible = true;
            }
        }
        lblListings.Text = lblListing.Text;
        lblDataIds.Text = lbldataId.Text;
        mod = Convert.ToString(lblmod.Text);
        HtmlTableRow trOther = (HtmlTableRow)e.Item.FindControl("trOther");
        HtmlTableRow trMovies = (HtmlTableRow)e.Item.FindControl("trMovies");
        HtmlTableRow trBusiness = (HtmlTableRow)e.Item.FindControl("trBusiness");
        Label lblBusList = (Label)e.Item.FindControl("lblBusList");
        if (lblBusList != null)
        {
            try
            {
                string Listing = Convert.ToString(lblBusList.Text);
                string[] strSplitArr = Listing.Split(separatorcomma);
                var strcount = from s in strSplitArr
                               select s;
                int c = strcount.Count();
                if (c > 2)
                {
                    buslist = strSplitArr[0] + "," + strSplitArr[1] + " & More";
                    lblBusList.Text = buslist;
                }
                else
                {
                    buslist = Listing.Remove(Listing.Length - 1, 1);
                    lblBusList.Text = buslist;
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }
        try
        {
            if (mod == "Businesses")
            {
                trBusiness.Visible = true;
                trOther.Visible = false;
                trMovies.Visible = false;
            }
            else if (mod == "Companies")
            {
                trBusiness.Visible = false;
                trOther.Visible = true;
                trMovies.Visible = false;
            }
            else if (mod == "Education")
            {
                trBusiness.Visible = false;
                trOther.Visible = true;
                trMovies.Visible = false;
            }
            else if (mod == "Health")
            {
                trBusiness.Visible = false;
                trOther.Visible = true;
                trMovies.Visible = false;
            }
            else if (mod == "Hotels and Restaurants")
            {
                trBusiness.Visible = false;
                trOther.Visible = true;
                trMovies.Visible = false;
            }
            else if (mod == "Tours and Travel")
            {
                trBusiness.Visible = false;
                trOther.Visible = true;
                trMovies.Visible = false;
            }
            else if (mod == "Movies")
            {
                trBusiness.Visible = false;
                trMovies.Visible = true;
                trOther.Visible = false;
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }   
    private void GetCTMovieDetails()
    {
        try
        {

            lblCity.Text = Convert.ToString(Session["city"]);
            lblmodcate2.Text = mod;
            tblcate.Visible = false;
            trTheatre.Visible = true;
            DlTheatres.Visible = false;
            lbltheatres.Visible = true;

            string strListing = Convert.ToString(lblListings.Text);
            string strlistIds = Convert.ToString(lblDataIds.Text);

            string[] strSplitArr1 = strListing.Split(separatorcomma);
            string[] strSplitArr2 = strlistIds.Split(separatorcomma);

            for (int i = 0; i < strSplitArr2.Length; i++)
            {
                try
                {
                    string w1 = strSplitArr1[i].ToString();
                    string[] ww = strSplitArr1[i].Split(separator);
                    string movieorcompany = ww[0];
                    string langorid = strSplitArr2[i].ToString();
                    string qry = "select distinct Movie_Desc,Movie_Name,Movie_Language,CinemaHall_Name,Area,City from Movies where Movie_Name='" + movieorcompany + "' and Movie_Language='" + langorid + "'";
                    SqlDataAdapter sdaMovies = new SqlDataAdapter(qry, con);
                    sdaMovies.Fill(dsMovies, "Records1");
                    //dsMovies = objCTCS.GetMovieDistinctDetails(movieorcompany,langorid);
                    foreach (string arrstrr in strSplitArr1)
                    {
                        DataTable dt = dsMovies.Tables["Records1"];
                        String[] keycolumns = new String[] { "Movie_Name", "Movie_Language" };
                        RemoveDuplicates(dt, keycolumns);

                        dlMovieDetails.Visible = true;
                        dlMovieDetails.DataSource = dsMovies;
                        dlMovieDetails.DataBind();
                        DlTheatres.Visible = true;
                        DlTheatres.DataSource = dsMovies;
                        DlTheatres.DataBind();
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
    private void GetOtherCatDetails()
    {
        try
        {
            lblmodcate.Text = mod;
            lblCity.Text = Convert.ToString(Session["city"]);
            tblcate.Visible = false;
            trTheatre.Visible = false;
            dsOther = objCTCS.GetMoreInfo(CTId);
            if (!dsOther.Tables[0].Rows.Equals(0))
            {
                dlOtherCatDetails.DataSource = dsOther;
                dlOtherCatDetails.DataBind();
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
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
    protected void lnkmodcate2_Click(object sender, EventArgs e)
    {
        try
        {
            string lnkmode = lblmodcate2.Text;
            //redirect("City_trends.aspx?category=" + Server.UrlEncode(lnkmode),false);
            Response.RedirectToRoute("CityTrends_Categories", new { category = lnkmode });
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lnkmodcate1_Click(object sender, EventArgs e)
    {
        try
        {
            string lnkmode = lblmodcate1.Text;
            //redirect("City_trends.aspx?category=" + Server.UrlEncode(lnkmode), false);
            Response.RedirectToRoute("CityTrends_Categories", new { category = lnkmode });
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lnkmodcate_Click(object sender, EventArgs e)
    {
        try
        {
            string lnkmode = lblmodcate.Text;
            //redirect("City_trends.aspx?category=" + Server.UrlEncode(lnkmode), false);
            Response.RedirectToRoute("CityTrends_Categories", new { category = lnkmode });
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    //protected string GetUrlMode(object cate)
    //{
    //    string CT_cate = cate.ToString();
    //    return Page.GetRouteUrl("CityTrends_Categories", new { category = CT_cate });
    //}
    //protected string GetUrl(object ctid)
    //{
    //    string CtId = ctid.ToString();
    //    return Page.GetRouteUrl("CityTrendDetails", new { CtId = CtId });
    //}
    protected string GetUrlCompName(object cid)
    {
        string CtId = cid.ToString();
        return Page.GetRouteUrl("CT_sessionstore", new { id = CtId });
    }
    //protected string GetUrlMovies(object mname1, object mlang1, object mcity1)
    //{
    //    string mname = Convert.ToString(mname1.ToString());
    //    string mlang = Convert.ToString(mlang1.ToString());
    //    string mcity = Convert.ToString(mcity1.ToString());
    //    return Page.GetRouteUrl("CT_Movies", new { mname = mname1, mlang = mlang1, mcity = mcity1 });
    //}
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
    protected void metadata(string modname)
    {
        try
        {
            pgtitle.Text = "JustCalluz " + modname + " ";
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
