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
using JustCallUsData.Data;
using System.IO;
using System.Collections.Generic;
using System.Web.Routing;


public partial class City_trends1 : System.Web.UI.Page
{
    char[] separatorcomma = new char[] { ',' };
    string buslist;
    string Listing;
    string mod;
    string city1;
    string city;
    string title;
    int tag_id;
    DataSet ds = new DataSet();
    DataSet dsMovies = new DataSet();
    DataSet dsOther = new DataSet();
    DataSet dsBus = new DataSet();
    //CityTrendsCS obj = new CityTrendsCS();
    char[] separator = new char[] { '-' };
    CityTrendsCS objData = new CityTrendsCS();
    PagedDataSource objPds = new PagedDataSource();
    string strScript = string.Empty;
    InsertData obj = new InsertData();
    static string excep_page = "City_trends.aspx";
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            city1 = Convert.ToString(Page.RouteData.Values["city"]);
            //city = Session["city"].ToString();
            lblCity.Text = city1;
            if (!IsPostBack)
            {

                if (Convert.ToString(Page.RouteData.Values["category"]) != "")
                {
                       city = Convert.ToString(Page.RouteData.Values["city"]);
                        mod = Convert.ToString(Page.RouteData.Values["category"]);
                      
                        GetCT(mod);
                   
                }
                else if (Convert.ToString(Page.RouteData.Values["city"]) != "")
                {
                    city1 = Convert.ToString(Page.RouteData.Values["city"]);
                    Session["city"] = city1;
                    GetMainInfo();
                }
                else if (Convert.ToString(Page.RouteData.Values["ctid"]) != "")
                {
                    tag_id = Convert.ToInt32(Page.RouteData.Values["ctid"]);
                    //title = title.Replace("and", "&");
                    GetTitleInfo();
                }
                
                //else if (Convert.ToString(Page.RouteData.Values["title"]) != "")
                //{
                //    title = Convert.ToString(Page.RouteData.Values["title"]);
                //    title = title.Replace("and", "&");
                //    GetTitleInfo();
                //}

            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    private void GetTitleInfo()
    {
        try
        {
            //title = Convert.ToString(Page.RouteData.Values["title"]);
            tag_id = Convert.ToInt32(Page.RouteData.Values["ctid"]);
            //title = title.Replace("-", ",");
            //title = title.Replace("and", "&");
             lblCity.Text = Convert.ToString(Session["city"]);
             metadata1(title, city1);
            DlMainInfo.Visible = true;
            tblcate.Visible = false;
            lblcate.Visible = false;
            dlCT.Visible = false;
            DataSet dsmain = new DataSet();
            dsmain = objData.GetCTTitleDetails(tag_id);
            if (!dsmain.Tables[0].Rows.Count.Equals(0))
            {
                objPds.DataSource = dsmain.Tables[0].DefaultView;
                objPds.AllowPaging = true;
                objPds.PageSize = 8;
                objPds.CurrentPageIndex = CurrentPage;
                cmdPrev.Enabled = !objPds.IsFirstPage;
                cmdNext.Enabled = !objPds.IsLastPage;
                DlMainInfo.DataKeyField = "ctId";
                DlMainInfo.DataSource = objPds;
                DlMainInfo.DataBind();
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    private void GetMainInfo()
    {
        try
        {
            city1 = Convert.ToString(Page.RouteData.Values["city"]);
            lblCity.Text = city1;
            DlMainInfo.Visible = true;
            tblcate.Visible = false;
            lblcate.Visible = false;
            dlCT.Visible = false;
            DataSet dsmain = new DataSet();
            dsmain = objData.bindCTtitles(city1);
            metadata(city1);
            if (!dsmain.Tables[0].Rows.Count.Equals(0))
            {
                objPds.DataSource = dsmain.Tables[0].DefaultView;
                objPds.AllowPaging = true;
                objPds.PageSize = 8;
                objPds.CurrentPageIndex = CurrentPage;
                cmdPrev.Enabled = !objPds.IsFirstPage;
                cmdNext.Enabled = !objPds.IsLastPage;
                DlMainInfo.DataKeyField = "ctId";
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
   private void GetCT(string Mod)
    {
        try
        {
            lblCity.Text = city;
            DlMainInfo.Visible = false;
            tblcate.Visible = true;
            lblcate.Text = Mod;
            metadata1(Mod, lblCity.Text);
            ds = objData.GetCTrends(Mod);
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                objPds.DataSource = ds.Tables[0].DefaultView;
                objPds.AllowPaging = true;
                objPds.PageSize = 8;
                objPds.CurrentPageIndex = CurrentPage;
                cmdPrev.Enabled = !objPds.IsFirstPage;
                cmdNext.Enabled = !objPds.IsLastPage;
                dlCT.DataKeyField = "ctId";
                dlCT.DataSource = objPds;
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
        city1 = Convert.ToString(Page.RouteData.Values["city"]);
        try
        {
            Label lblmod = (Label)e.Item.FindControl("lblmod");
            Label lblCtId = (Label)e.Item.FindControl("lblCtId");
            mod = lblmod.Text;
            HtmlTableRow trOther = (HtmlTableRow)e.Item.FindControl("trOther");
            HtmlTableRow trMovies = (HtmlTableRow)e.Item.FindControl("trMovies");
            HtmlTableRow trBusiness = (HtmlTableRow)e.Item.FindControl("trBusiness");
            Label lblBusList = (Label)e.Item.FindControl("lblBusList");
            Repeater rp1 = (Repeater)e.Item.FindControl("rptlist");

            if (lblBusList != null)
            {
                try
                {
                    string Listing = Convert.ToString(lblBusList.Text);
                    string[] strSplitArr = Listing.Split(separatorcomma);
                    var strcount = from s in strSplitArr
                                   select s;
                    DataTable dt = new DataTable();
                    dt.Columns.Add("list");
                    dt.Columns.Add("ctid");

                    for (int i = 0; i < strSplitArr.Count(); i++)
                    {
                        dt.Rows.Add();
                        dt.Rows[i]["list"] = strSplitArr[i].ToString();
                        dt.Rows[i]["ctid"] = lblCtId.Text.ToString();

                    }
                    rp1.DataSource = dt;
                    rp1.DataBind();
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
                   // metadata1(mod,city1);
                    trOther.Visible = false;
                    trMovies.Visible = false;
                }
                else if (mod == "Companies")
                {
                    trBusiness.Visible = false;
                   // metadata1(mod, city1);
                    trOther.Visible = true;
                    trMovies.Visible = false;
                }
                else if (mod == "Education")
                {
                    trBusiness.Visible = false;
                    //metadata1(mod, city1);
                    trOther.Visible = true;
                    trMovies.Visible = false;
                }
                else if (mod == "Health")
                {
                    trBusiness.Visible = false;
                   // metadata1(mod, city1);
                    trOther.Visible = true;
                    trMovies.Visible = false;
                }
                else if (mod == "Hotels and Restaurants")
                {
                    trBusiness.Visible = false;
                   // metadata1(mod, city1);
                    trOther.Visible = true;
                    trMovies.Visible = false;
                }
                else if (mod == "Tours and Travel")
                {
                    trBusiness.Visible = false;
                   // metadata1(mod, city1);
                    trOther.Visible = true;
                    trMovies.Visible = false;
                }
                else if (mod == "Movies")
                {
                    trBusiness.Visible = false;
                   // metadata1(mod, city1);
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
            GetMainInfo();
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
            GetMainInfo();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void DlMainInfo_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        try
        {

            HyperLink lnkmode = (HyperLink)e.Item.FindControl("lnkmode");
            Label lblCtId = (Label)e.Item.FindControl("lblCtId");
            Label lblsubtitle = (Label)e.Item.FindControl("lblsubtitle");
            HtmlTableRow trOther = (HtmlTableRow)e.Item.FindControl("trOther");
            HtmlTableRow trMovies = (HtmlTableRow)e.Item.FindControl("trMovies");
            HtmlTableRow trBusiness = (HtmlTableRow)e.Item.FindControl("trBusiness");
            Label lblBusList = (Label)e.Item.FindControl("lblBusList");
            Repeater rp1 = (Repeater)e.Item.FindControl("rptlist");
            HtmlTableRow trSubtitle = (HtmlTableRow)e.Item.FindControl("trSubtitle");

            DataList DlMovieDetails = (DataList)e.Item.FindControl("DlMovieDetails");
            DataList DlTheatre = (DataList)e.Item.FindControl("DlTheatre");
            DataList DlCompanyDetails = (DataList)e.Item.FindControl("DlCompanyDetails");
            DataList DlOtherDetails = (DataList)e.Item.FindControl("DlOtherDetails");
            HtmlTableRow trTheatre = (HtmlTableRow)e.Item.FindControl("trTheatre");
            Label lblListing = (Label)e.Item.FindControl("lblListing");
            Label lblDataId = (Label)e.Item.FindControl("lbldataId");
            Int32 ctId = Convert.ToInt32(lblCtId.Text);

            if (lblBusList != null)
            {
                try
                {
                    Listing = Convert.ToString(lblBusList.Text);
                    string[] strSplitArr = Listing.Split(separatorcomma);
                    var strcount = from s in strSplitArr
                                   select s;
                    DataTable dt = new DataTable();
                    dt.Columns.Add("list");
                    dt.Columns.Add("ctid");
                    dt.Columns.Add("mod");
                    for (int i = 0; i < strSplitArr.Count(); i++)
                    {
                        dt.Rows.Add();
                        dt.Rows[i]["list"] = strSplitArr[i].ToString();
                        dt.Rows[i]["ctid"] = lblCtId.Text.ToString();
                        dt.Rows[i]["mod"] = lnkmode.Text.ToString();
                    }
                    rp1.DataSource = dt;
                    rp1.DataBind();
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
            if (lblsubtitle != null)
            {
                if (lblsubtitle.Text != "")
                {
                    trSubtitle.Visible = true;
                }
            }
            string category = lnkmode.Text;
            try
            {
                if (category == "Businesses")
                {
                    trBusiness.Visible = true;
                    trOther.Visible = false;
                   // metadata1(category, city1);
                    trMovies.Visible = false;
                    DlCompanyDetails.Visible = true;

                    string strListing = Convert.ToString(lblListing.Text); ;
                    string strlistIds = Convert.ToString(lblDataId.Text);

                    string[] strSplitArr1 = strListing.Split(separatorcomma);
                    string[] strSplitArr2 = strlistIds.Split(separatorcomma);
                    dsBus.Clear();
                    for (int i = 0; i < strSplitArr2.Length; i++)
                    {
                        string w1 = strSplitArr1[i].ToString();
                        string[] ww = strSplitArr1[i].Split(separator);
                        string company = ww[0];
                        string id = strSplitArr2[i].ToString();
                        try
                        {
                            string str1 = "select company_name,id,company_profile from ModulesData where company_name='" + company + "' and id='" + id + "'";
                            SqlDataAdapter ada1 = new SqlDataAdapter(str1, con);
                            ada1.Fill(dsBus, "Records1");
                            foreach (string arrstrr in strSplitArr1)
                            {
                                DataTable dt = dsBus.Tables["Records1"];
                                String[] keycolumns = new String[] { "company_name", "company_profile" };
                                RemoveDuplicates(dt, keycolumns);

                                DlCompanyDetails.DataSource = dsBus;
                                DlCompanyDetails.DataBind();
                            }
                        }
                        catch (Exception ex)
                        {
                            obj.insert_exception(ex, excep_page);
                            Response.Redirect("HttpErrorPage.aspx");
                        }
                    }
                }
                else if (category == "Companies")
                {

                    trBusiness.Visible = false;
                   // metadata1(category, city1);
                    trOther.Visible = true;
                    trMovies.Visible = false;
                    DlOtherDetails.Visible = true;
                    try
                    {
                        dsOther = objData.GetMoreInfo(ctId);
                        if (!dsOther.Tables[0].Rows.Count.Equals(0))
                        {
                            DlOtherDetails.DataSource = dsOther;
                            DlOtherDetails.DataBind();
                        }
                    }
                    catch (Exception ex)
                    {
                        obj.insert_exception(ex, excep_page);
                        Response.Redirect("HttpErrorPage.aspx");
                    }
                }
                else if (category == "Education")
                {
                   // metadata1(category, city1);
                    trBusiness.Visible = false;
                    trOther.Visible = true;
                    trMovies.Visible = false;
                    DlOtherDetails.Visible = true;
                    try
                    {
                        dsOther = objData.GetMoreInfo(ctId);
                        if (!dsOther.Tables[0].Rows.Count.Equals(0))
                        {
                            DlOtherDetails.DataSource = dsOther;
                            DlOtherDetails.DataBind();
                        }
                    }
                    catch (Exception ex)
                    {
                        obj.insert_exception(ex, excep_page);
                        Response.Redirect("HttpErrorPage.aspx");
                    }
                }
                else if (category == "Health")
                {
                   // metadata1(category, city1);
                    trBusiness.Visible = false;
                    trOther.Visible = true;
                    trMovies.Visible = false;
                    DlOtherDetails.Visible = true;
                    try
                    {
                        dsOther = objData.GetMoreInfo(ctId);
                        if (!dsOther.Tables[0].Rows.Count.Equals(0))
                        {
                            DlOtherDetails.DataSource = dsOther;
                            DlOtherDetails.DataBind();
                        }
                    }
                    catch (Exception ex)
                    {
                        obj.insert_exception(ex, excep_page);
                        Response.Redirect("HttpErrorPage.aspx");
                    }
                }
                else if (category == "Hotels and Restaurants")
                {
                   // metadata1(category, city1);
                    trBusiness.Visible = false;
                    trOther.Visible = true;
                    trMovies.Visible = false;
                    DlOtherDetails.Visible = true;
                    try
                    {
                        dsOther = objData.GetMoreInfo(ctId);
                        if (!dsOther.Tables[0].Rows.Count.Equals(0))
                        {
                            DlOtherDetails.DataSource = dsOther;
                            DlOtherDetails.DataBind();
                        }
                    }
                    catch (Exception ex)
                    {
                        obj.insert_exception(ex, excep_page);
                        Response.Redirect("HttpErrorPage.aspx");
                    }
                }
                else if (category == "Tours and Travel")
                {
                   // metadata1(category, city1);
                    trBusiness.Visible = false;
                    trOther.Visible = true;
                    trMovies.Visible = false;
                    DlOtherDetails.Visible = true;
                    try
                    {
                        dsOther = objData.GetMoreInfo(ctId);
                        if (!dsOther.Tables[0].Rows.Count.Equals(0))
                        {
                            DlOtherDetails.DataSource = dsOther;
                            DlOtherDetails.DataBind();
                        }
                    }
                    catch (Exception ex)
                    {
                        obj.insert_exception(ex, excep_page);
                        Response.Redirect("HttpErrorPage.aspx");
                    }
                }
                else if (category == "Movies")
                {
                   // metadata1(category, city1);
                    trMovies.Visible = true;
                    trBusiness.Visible = false;
                    trOther.Visible = false;
                    DlMovieDetails.Visible = true;
                    DlTheatre.Visible = true;
                    trTheatre.Visible = true;

                    string strListing = Convert.ToString(lblListing.Text);
                    string strlistIds = Convert.ToString(lblDataId.Text);

                    string[] strSplitArr1 = strListing.Split(separatorcomma);
                    string[] strSplitArr2 = strlistIds.Split(separatorcomma);
                    dsMovies.Clear();
                    try
                    {
                        for (int i = 0; i < strSplitArr2.Length; i++)
                        {
                            string w1 = strSplitArr1[i].ToString();
                            string[] ww = strSplitArr1[i].Split(separator);
                            string movieorcompany = ww[0];
                            string langorid = strSplitArr2[i].ToString();
                            string qry = "select Distinct Movie_Name,Movie_Desc,Movie_Language,CinemaHall_Name,Area,City from Movies where Movie_Name='" + movieorcompany + "' and Movie_Language='" + langorid + "'";
                            SqlDataAdapter sdaMovies = new SqlDataAdapter(qry, con);
                            sdaMovies.Fill(dsMovies, "Records1");
                            foreach (string arrstrr in strSplitArr1)
                            {
                                DataTable dt = dsMovies.Tables["Records1"];
                                String[] keycolumns = new String[] { "Movie_Name", "Movie_Language" };
                                RemoveDuplicates(dt, keycolumns);

                                DlMovieDetails.DataSource = dsMovies;
                                DlMovieDetails.DataBind();
                                DlTheatre.DataSource = dsMovies;
                                DlTheatre.DataBind();
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
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
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
    //protected void lnkmode_Click(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        Button lnkcategory = sender as Button;
    //        string lnkmode = lnkcategory.CommandArgument.ToString();
    //        redirect("City_trends.aspx?category=" + Server.UrlEncode(lnkmode),false);
    //    }
    //    catch (Exception ex)
    //    {
    //        obj.insert_exception(ex, excep_page);
    //        Response.Redirect("HttpErrorPage.aspx");
    //    }
    //}
    protected string GetUrlMode(object cate)
    {
        string CT_cate = cate.ToString();
       // metadata1(mod, city1);
        return Page.GetRouteUrl("CityTrends_Categories", new { category = CT_cate });
    }
    protected string GetUrl(object ctid)
    {
        string CtId = ctid.ToString();
        return Page.GetRouteUrl("CityTrendDetails", new { CtId = CtId });
    }
    protected string GetUrlCompName(object cid)
    {
        string CtId = cid.ToString();
        return Page.GetRouteUrl("CT_sessionstore", new { id = CtId });
    }
    protected string GetUrlMovies(object mname1, object mlang1, object mcity1)
    {
        string mname = Convert.ToString(mname1.ToString());
        string mlang = Convert.ToString(mlang1.ToString());
        string mcity = Convert.ToString(mcity1.ToString());
        return Page.GetRouteUrl("CT_Movies", new { mname = mname1, mlang = mlang1, mcity = mcity1 });

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
    protected void metadata1(string modname, string JCity)
    {
        try
        {
            pgtitle.Text = " Get data about " + modname + " | JustCalluz in " + JCity + " ";
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
