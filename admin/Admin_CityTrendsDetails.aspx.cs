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
/// <summary>
/// Displaying of city trends in detailed manner
/// </summary>
public partial class admin_Admin_CityTrendsDetails : System.Web.UI.Page
{
    //declaration of variables and creation of objects for classes
    char[] separatorcomma = new char[] { ',' };
    string buslist;
    string UserId;
    Int32 CTId;
    string mod;
    DataCS data = new DataCS();
    DataSet ds = new DataSet();
    DataSet dsMovies = new DataSet();
    DataSet dsBus = new DataSet();
    DataSet dsOther = new DataSet();
    CityTrendsCS obj = new CityTrendsCS();    
    char[] separator = new char[] { '-' };
    //making connection
    SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    /// <summary>
    /// Executes whenever page loads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        UserId = Convert.ToString(Session["LogInId"]);

        if (UserId != "")
        {
            // it will stays in the same page
        }

        else
        {
            //After login into the account it will go Post ad
            Response.Redirect("Default.aspx");

        }
        CTId = Convert.ToInt32(Request.QueryString["CtId"].ToString());
        // loads the page without postbacking the values
        if (!Page.IsPostBack)
        {
            //binding 
            GetCTs();
            if (mod == "Movies")
            {
                GetCTMovieDetails();
            }
            else if (mod == "Businesses")
            {
                GetCTBusDetails();
            }
            else
            {
                GetOtherCatDetails();
            }
        }
    }
    /// <summary>
    /// To get city trends
    /// </summary>
    private void GetCTs()
    {
        connection.Open();
        ds = obj.GetCTrendParticular(CTId);
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            mod = ds.Tables[0].Rows[0]["mod"].ToString();
            lblHeader.Text = mod;            
                dlCT.DataSource = ds;
                dlCT.DataBind();                    
        }
        connection.Close();
    }
    /// <summary>
    /// binding fields of datalist dynamically
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void dlCT_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        Label lblmod = (Label)e.Item.FindControl("lblmod");
        Label lblListing = (Label)e.Item.FindControl("lblListing");
        Label lbldataId = (Label)e.Item.FindControl("lbldataId");
        Label lblsubtitle=(Label)e.Item.FindControl("lblsubtitle");
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
        mod =Convert.ToString(lblmod.Text);
        HtmlTableRow trOther = (HtmlTableRow)e.Item.FindControl("trOther");
        HtmlTableRow trMovies = (HtmlTableRow)e.Item.FindControl("trMovies");
        HtmlTableRow trBusiness = (HtmlTableRow)e.Item.FindControl("trBusiness");
        Label lblBusList = (Label)e.Item.FindControl("lblBusList");
        if (lblBusList != null)
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
        else if (mod == "Hotels & Restaurants")
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
    /// <summary>
    /// To get movie details in the category of city trends and binding
    /// </summary>
    private void GetCTMovieDetails()
    {
        connection.Open();
        string strListing = Convert.ToString(lblListings.Text); ;
        string strlistIds = Convert.ToString(lblDataIds.Text);

        string[] strSplitArr1 = strListing.Split(separatorcomma);
        string[] strSplitArr2 = strlistIds.Split(separatorcomma);

        for (int i = 0; i < strSplitArr2.Length; i++)
        {
            string w1 = strSplitArr1[i].ToString();
            string[] ww = strSplitArr1[i].Split(separator);
            string movieorcompany = ww[0];
            string langorid = strSplitArr2[i].ToString();
            string str = "select distinct Movie_Desc,Movie_Name,Movie_Language from Movies where Movie_Name='" + movieorcompany + "' and Movie_Language='" + langorid + "'";
            SqlDataAdapter ada = new SqlDataAdapter(str, connection);
            ada.Fill(dsMovies);
                foreach (string arrstrr in strSplitArr1)
                {                   
                    dlMovieDetails.DataSource = dsMovies;
                    dlMovieDetails.DataBind();
                }                               
        }
        connection.Close();
    }
    /// <summary>
    /// To get business details in the category of city trends and binding
    /// </summary>
    private void GetCTBusDetails()
    {
        connection.Open();
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
            SqlDataAdapter ada1 = new SqlDataAdapter(str1, connection);
            ada1.Fill(dsBus);            
            foreach (string arrstrr in strSplitArr1)
            {
                dlBusinesDetails.DataSource = dsBus;
                dlBusinesDetails.DataBind();
            }            
        }
        connection.Close();
    }
    /// <summary>
    /// To get other categories details in the category of city trends and binding
    /// </summary>
    private void GetOtherCatDetails()
    {       
        dsOther = obj.GetMoreInfo(CTId);
        if (!ds.Tables[0].Rows.Equals(0))
        {
            dlOtherCatDetails.DataSource = dsOther;
            dlOtherCatDetails.DataBind();
        }
    }
    protected void lnkBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin_CityTrends.aspx?mod=" + lblHeader.Text + "");
    }
}
