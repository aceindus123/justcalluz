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
/// class to post city trends
/// </summary>
public partial class admin_Admin_ToPostCityTrends : System.Web.UI.Page
{
    //declaration of variables and creation of objects for classes
    string buslisting;
    string buslist;
    string Listing;
    string Lang;
    string ListingId;
    string ListingLang;
    string Subtitle;
    string UserId;
    int selectionCount;
    string strScript;
    string query;
    string SubCat;
    string City;
    string ctId;
    bool t;
    string mod;
    DataCS data = new DataCS();
    DataSet ds = new DataSet();
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
        //loads the page without postbacking the values
        if (!IsPostBack)
        {
            data.FillCityTrends_Cat(ddlMod);
            data.FillStates(ddlState);            

        }
    }
    /// <summary>
    /// To fill Cities
    /// </summary>
    /// <param name="StateName"></param>
    public void fillCities(string StateName)
    {
        try
        {          
            query= "select city_Id,city_name from Cities where state_name= '" + StateName + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, connection);            
            da.Fill(ds, "Cities");
            //DlCities.SelectedIndex = 0;

            ddlCity.DataSource = ds.Tables["Cities"];
            ddlCity.DataValueField = "city_name";
            ddlCity.DataTextField = "city_name";
            ddlCity.DataBind();
            ddlCity.Items.Insert(0, "Select City");
            connection.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    /// <summary>
    /// Executes whenever State drop down selection changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlState.SelectedIndex != 0)
        {
            string State_Name = Convert.ToString(ddlState.SelectedValue);
            fillCities(State_Name);
        }
        else
        {
            ddlCity.Items.Clear();
            ddlCity.Items.Insert(0, "Select City");
        }
    }
    /// <summary>
    /// executes whenever module selection is changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlMod_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlMod.SelectedValue == "Businesses")
        {
            trArea.Visible = false;
            //trCompDesc.Visible = false;
            trGDesc.Visible = true;
            trddlList.Visible = false;
            trCat.Visible = true;
            trSubCat.Visible = true;
            trTitle.Visible = true;
            trState.Visible = true;
            trCity.Visible = true;
            trList.Visible = true;
            lblselecttop.Text = "Businesses";
            fillBusinessCategories();
            ddlState.SelectedIndex = 0;           
        }
        else if (ddlMod.SelectedValue == "Companies")
        {
            trArea.Visible = true;
            //trCompDesc.Visible = true;
            trGDesc.Visible = true;
            trddlList.Visible = true;
            trList.Visible = false;
            trCat.Visible = false;
            trSubCat.Visible = false;
            trCity.Visible = true;
            trState.Visible = true;
            trTitle.Visible = false;
            lbl.Text = "Companies";
            lblcompdesc.Text = "Company";
            lblInfo.Text = "True";
            ddlState.SelectedIndex = 0;            
        }
        else if (ddlMod.SelectedValue == "Education")
        {
            trArea.Visible = true;
            //trCompDesc.Visible = true;
            trGDesc.Visible = true;
            trddlList.Visible = true;
            trList.Visible = false;
            trCat.Visible = false;
            trSubCat.Visible = false;
            trCity.Visible = true;
            trState.Visible = true;
            trTitle.Visible = false;
            lbl.Text = "One";
            lblcompdesc.Text = "Education";
            lblInfo.Text = "True";
            ddlState.SelectedIndex = 0;           
        }
        else if (ddlMod.SelectedValue == "Health")
        {
            trArea.Visible = true;
            //trCompDesc.Visible = true;
            trGDesc.Visible = true;
            trddlList.Visible = true;
            trList.Visible = false;
            trCat.Visible = false;
            trSubCat.Visible = false;
            trCity.Visible = true;
            trState.Visible = true;
            trTitle.Visible = false;
            lbl.Text = "One";
            lblcompdesc.Text = "Health";
            lblInfo.Text = "True";
            ddlState.SelectedIndex = 0;            
        }
        else if (ddlMod.SelectedValue == "Hotels & Restaurants")
        {
            trArea.Visible = true;
            //trCompDesc.Visible = true;
            trGDesc.Visible = true;
            trddlList.Visible = true;
            trList.Visible = false;
            trCat.Visible = false;
            trSubCat.Visible = false;
            trCity.Visible = true;
            trState.Visible = true;
            trTitle.Visible = false;
            lbl.Text = "One";
            lblcompdesc.Text = "Hotels & Restaurants";
            lblInfo.Text = "True";
            ddlState.SelectedIndex = 0;           
        }
        else if (ddlMod.SelectedValue == "Movies")
        {
            trArea.Visible = false;
            //trCompDesc.Visible = false;
            trGDesc.Visible = true;
            trddlList.Visible = false;
            trList.Visible = true;
            trCat.Visible = false;
            trSubCat.Visible = false;
            trCity.Visible = true;
            trState.Visible = true;
            trTitle.Visible = false;
            lblselecttop.Text = "Movies";
            ddlState.SelectedIndex = 0;            
        }
        else if (ddlMod.SelectedValue == "Tours and Travel")
        {
            trArea.Visible = true;
            //trCompDesc.Visible = true;
            trGDesc.Visible = true;
            trddlList.Visible = true;
            trList.Visible = false;
            trCat.Visible = false;
            trSubCat.Visible = false;
            trCity.Visible = true;
            trState.Visible = true;
            trTitle.Visible = false;
            lbl.Text = "One";
            lblcompdesc.Text = "Tours and Travel";
            lblInfo.Text = "True";
            ddlState.SelectedIndex = 0;            
        }
    }
    /// <summary>
    /// filling business sub categories based on category
    /// </summary>
    public void fillBusinessCategories()
    {        
        try
        {
            query = "select * from Categories where Module='Category' order by Category";

            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, connection);           
            da.Fill(ds, "Cat");
            ddlCat.DataSource = ds.Tables["Cat"];
            ddlCat.DataValueField = "Category";
            ddlCat.DataTextField = "Category";
            ddlCat.DataBind();
            ddlCat.Items.Insert(0, "Select Category");
            connection.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    /// <summary>
    /// filling business sub categories based on category
    /// </summary>
    /// <param name="cat"></param>
    public void fillBusinessSubCategories(string cat)
    {
        try
        {
            query = "select * from subcatageory where maincat='"+cat+"' order by cat";

            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            da.Fill(ds, "SubCat");

            ddlSubCat.DataSource = ds.Tables["SubCat"];
            ddlSubCat.DataValueField = "cat";
            ddlSubCat.DataTextField = "cat";
            ddlSubCat.DataBind();
            ddlSubCat.Items.Insert(0, "Select SubCategory");
            connection.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    /// <summary>
    /// filling business listings based on city
    /// </summary>
    /// <param name="City"></param>
    public void fillBusinessListing(string City)
    {
        try
        {
            query = "select id,company_name from ModulesData where City='" + City + "' and SubCategory='"+ddlSubCat.SelectedValue+"' order by company_name";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            da.Fill(ds, "BListing");                       
            lstCompNames.DataSource = ds.Tables["BListing"];
            lstCompNames.DataValueField = "id";
            lstCompNames.DataTextField = "company_name";
            lstCompNames.DataBind();
            connection.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    /// <summary>
    /// filling companies listings based on city
    /// </summary>
    /// <param name="City"></param>
    public void fillCompaniesListing(string City)
    {
        try
        {
            query = "select id,company_name from ModulesData where City='" + City + "' and (module='Category' or module='B2B Category' or module='LifeStyle') order by company_name";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            da.Fill(ds, "CompListing");
            ddlCompNames.DataSource = ds.Tables["CompListing"];
            ddlCompNames.DataValueField = "id";
            ddlCompNames.DataTextField = "company_name";           
            ddlCompNames.DataBind();
            ddlCompNames.Items.Insert(0, "Select Listing");
            connection.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    /// <summary>
    /// filling education listing based on city
    /// </summary>
    /// <param name="City"></param>
    public void fillEducationListing(string City)
    {
        try
        {
            query = "select id,company_name from ModulesData where City='" + City + "' and (Category='Schools & Colleges' or Category='Education & Training' or Category='Institutes') order by company_name";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            da.Fill(ds, "EdListing");
            ddlCompNames.DataSource = ds.Tables["EdListing"];
            ddlCompNames.DataValueField = "id";
            ddlCompNames.DataTextField = "company_name";           
            ddlCompNames.DataBind();
            ddlCompNames.Items.Insert(0, "Select Listing");
            connection.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    /// <summary>
    /// filing health listing based on city
    /// </summary>
    /// <param name="City"></param>
    public void fillHealthListing(string City)
    {
        try
        {
            query = "select id,company_name from ModulesData where City='" + City + "' and (Category='Doctors & Specialists' or Category='Emergency Services' or Category='Hospitals & Healthcare' or Category='Health Clubs' or Category='Diagnostics Centres' or Category='Chemists & Druggists') order by company_name";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            da.Fill(ds, "HealthListing");
            ddlCompNames.DataSource = ds.Tables["HealthListing"];
            ddlCompNames.DataValueField = "id";
            ddlCompNames.DataTextField = "company_name";            
            ddlCompNames.DataBind();
            ddlCompNames.Items.Insert(0, "Select Listing");
            connection.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    /// <summary>
    /// Filling Hotel listing based on city
    /// </summary>
    /// <param name="City"></param>
    public void fillHotelsListing(string City)
    {
        try
        {
            query = "select id,company_name from ModulesData where City='" + City + "' and (Category='Hotels & Resorts' or Category='Restaurant & Pubs' or Category='Restaurants') order by company_name";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            da.Fill(ds, "HotelsListing");
            ddlCompNames.DataSource = ds.Tables["HotelsListing"];
            ddlCompNames.DataValueField = "id";
            ddlCompNames.DataTextField = "company_name";            
            ddlCompNames.DataBind();
            ddlCompNames.Items.Insert(0, "Select Listing");
            connection.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    /// <summary>
    /// filling movies listing based on city
    /// </summary>
    /// <param name="City"></param>
    public void fillMoviesListing(string City)
    {        
        try
        {                     
            query = "select distinct Movie_Name,Movie_Language from movies where City='" + City + "' order by Movie_Name";            
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            da.Fill(ds, "Listing");
            //DlCities.SelectedIndex = 0;     
            ds.Tables[0].Columns.Add("NameAndLang", typeof(string), "Movie_Name+ '-' + Movie_Language");
            lstCompNames.DataSource = ds.Tables["Listing"];
            lstCompNames.DataValueField = "NameAndLang";
            lstCompNames.DataTextField = "NameAndLang";           
            lstCompNames.DataBind();
            connection.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    /// <summary>
    /// Filling tours and travels listing based on city
    /// </summary>
    /// <param name="City"></param>
    public void fillToursTravelsListing(string City)
    {
        try
        {
            query = "select id,company_name from ModulesData where City='" + City + "' and (Category='Travel Services' or Category='Logistics Services') order by company_name";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            da.Fill(ds, "TourTravelListing");
            ddlCompNames.DataSource = ds.Tables["TourTravelListing"];
            ddlCompNames.DataValueField = "id";
            ddlCompNames.DataTextField = "company_name";            
            ddlCompNames.DataBind();
            ddlCompNames.Items.Insert(0, "Select Listing");
            connection.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    /// <summary>
    /// executes whenever city selection is changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlMod.SelectedValue == "Businesses")
        {
            if (ddlCity.SelectedIndex != 0)
            {
                string City = Convert.ToString(ddlCity.SelectedValue);
                fillBusinessListing(City);
            }
            else
            {
                lstCompNames.Items.Clear();
                lstCompNames.Items.Insert(0, "Select Listing");
            }
        }
        else if (ddlMod.SelectedValue == "Companies")
        {
            if (ddlCity.SelectedIndex != 0)
            {
                string City = Convert.ToString(ddlCity.SelectedValue);
                fillCompaniesListing(City);
            }
            else
            {
                ddlCompNames.Items.Clear();
                ddlCompNames.Items.Insert(0, "Select Listing");
            }
        }
        if (ddlMod.SelectedValue == "Education")
        {
            if (ddlCity.SelectedIndex != 0)
            {
                string City = Convert.ToString(ddlCity.SelectedValue);
                fillEducationListing(City);
            }
            else
            {
                ddlCompNames.Items.Clear();
                ddlCompNames.Items.Insert(0, "Select Listing");
            }
        }
        if (ddlMod.SelectedValue == "Health")
        {
            if (ddlCity.SelectedIndex != 0)
            {
                string City = Convert.ToString(ddlCity.SelectedValue);
                fillHealthListing(City);
            }
            else
            {
                ddlCompNames.Items.Clear();
                ddlCompNames.Items.Insert(0, "Select Listing");
            }
        }
        if (ddlMod.SelectedValue == "Hotels & Restaurants")
        {
            if (ddlCity.SelectedIndex != 0)
            {
                string City = Convert.ToString(ddlCity.SelectedValue);
                fillHotelsListing(City);
            }
            else
            {
                ddlCompNames.Items.Clear();
                ddlCompNames.Items.Insert(0, "Select Listing");
            }
        }
        else if (ddlMod.SelectedValue == "Movies")
        {
            if (ddlCity.SelectedIndex != 0)
            {
                string City = Convert.ToString(ddlCity.SelectedValue);
                fillMoviesListing(City);
            }
            else
            {
                lstCompNames.Items.Clear();
                lstCompNames.Items.Insert(0, "Select Listing");
            }
        }
        if (ddlMod.SelectedValue == "Tours and Travel")
        {
            if (ddlCity.SelectedIndex != 0)
            {
                string City = Convert.ToString(ddlCity.SelectedValue);
                fillToursTravelsListing(City);
            }
            else
            {
                ddlCompNames.Items.Clear();
                ddlCompNames.Items.Insert(0, "Select Listing");
            }
        }
    }
    /// <summary>
    /// click event to post city trends
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void imgBtnPost_Click(object sender, ImageClickEventArgs e)
    {
        mod=Convert.ToString(ddlMod.SelectedValue);

        if (lblInfo.Text == "True")
        {
            SubCat = Convert.ToString(ddlSubCat.SelectedValue);
            City = Convert.ToString(ddlCity.SelectedValue);
            obj.ctMod = mod;
            obj.ctCat = Convert.ToString(ddlCat.SelectedValue);
            obj.ctSubCat = SubCat;
            obj.ctState = Convert.ToString(ddlState.SelectedValue);
            obj.ctCity = City;
            obj.ctTitleentered = Convert.ToString(txtTitle.Text);
            obj.ctDesc = Convert.ToString(txtDesc.Text);
            obj.ctArea = Convert.ToString(txtArea.Text);
            obj.ctUserId = UserId;
            obj.ctPostdate = DateTime.Now;
            DateTime date = DateTime.Now;
            mod = Server.UrlEncode(ddlMod.SelectedValue);
            if (ddlMod.SelectedValue == "Businesses")
            {
                for (int i = 0; i < lstCompNames.Items.Count; i++)      // Select Multiple items from Listbox
                {
                    if (lstCompNames.Items[i].Selected == true)
                    {
                        Listing += lstCompNames.Items[i].Text + ",";
                        ListingId += lstCompNames.Items[i].Value + ",";                        
                        selectionCount = selectionCount + 1;
                    }
                }
                Subtitle = "Brief information about the top " + selectionCount + " " + SubCat + " of " + City;
                obj.ctListing_Lang_Ids = ListingId;
                string title=Convert.ToString(txtTitle.Text);
                obj.ctTitle =title+" in " +City ;
            }
            else if (ddlMod.SelectedValue == "Companies")
            {
                obj.ctListing_Lang_Ids = ddlCompNames.SelectedValue;
                Listing = ddlCompNames.SelectedItem.Text;
                Subtitle = "";
                obj.ctTitle = ddlCompNames.SelectedItem.Text + " in " +txtArea.Text+", "+ ddlCity.SelectedValue;
            }
            else if (ddlMod.SelectedValue == "Education")
            {
                obj.ctListing_Lang_Ids = ddlCompNames.SelectedValue;
                Listing = ddlCompNames.SelectedItem.Text;
                Subtitle = "";
                obj.ctTitle = ddlCompNames.SelectedItem.Text + " in " + txtArea.Text + ", " + ddlCity.SelectedValue;
            }
            else if (ddlMod.SelectedValue == "Health")
            {
                obj.ctListing_Lang_Ids = ddlCompNames.SelectedValue;
                Listing = ddlCompNames.SelectedItem.Text;
                Subtitle = "";
                obj.ctTitle = ddlCompNames.SelectedItem.Text + " in " + txtArea.Text + ", " + ddlCity.SelectedValue;
            }
            else if (ddlMod.SelectedValue == "Hotels & Restaurants")
            {
                obj.ctListing_Lang_Ids = ddlCompNames.SelectedValue;
                Listing = ddlCompNames.SelectedItem.Text;
                Subtitle = "";
                obj.ctTitle = ddlCompNames.SelectedItem.Text + " in " + txtArea.Text + ", " + ddlCity.SelectedValue;
            }
            else if (ddlMod.SelectedValue == "Movies")
            {
                for (int i = 0; i < lstCompNames.Items.Count; i++)      // Select Multiple items from Listbox
                {
                    if (lstCompNames.Items[i].Selected == true)
                    {
                        Listing += lstCompNames.Items[i].Value + ",";
                        string[] strSplitArr1 = lstCompNames.Items[i].Value.Split(separator);
                        Lang = strSplitArr1[1];
                        ListingLang += Lang + ",";
                        selectionCount = selectionCount + 1;
                    }
                }
                Subtitle = "Brief synopsis of the top " + selectionCount + " movies";
                obj.ctListing_Lang_Ids = ListingLang;
                obj.ctTitle = "Movie Trends in "+City;
            }
            else if (ddlMod.SelectedValue == "Tours and Travel")
            {
                obj.ctListing_Lang_Ids = ddlCompNames.SelectedValue;
                Listing = ddlCompNames.SelectedItem.Text;
                Subtitle = "";
                obj.ctTitle = ddlCompNames.SelectedItem.Text + " in " + txtArea.Text + ", " + ddlCity.SelectedValue;
            }
            obj.ctListing = Listing;
            obj.ctSubHeading = Subtitle;
            t = obj.CityTrends_Post(obj.ctMod, obj.ctCat, obj.ctSubCat, obj.ctState, obj.ctCity, obj.ctTitle,
                                    obj.ctDesc, obj.ctListing, obj.ctListing_Lang_Ids, obj.ctSubHeading,
                                    obj.ctUserId, obj.ctPostdate,obj.ctArea,obj.ctTitleentered);
            string getID = "select top 1 ctId from CityTrends where postedby='" + UserId + "' order by ctId desc";
            connection.Open();
            SqlDataAdapter adaId = new SqlDataAdapter(getID, connection);
            DataSet dsId = new DataSet();
            adaId.Fill(dsId);
            connection.Close();
            if (!dsId.Tables[0].Rows.Count.Equals(0))
            {
                ctId = dsId.Tables[0].Rows[0]["ctId"].ToString();               
                lblInfo.Text = "";
                if (ddlMod.SelectedValue == "Businesses")
                {
                    strScript = "alert('City Trend in Businesses Category is Posted Successfully.');location.replace('Admin_CityTrends.aspx?mod="+mod+"');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                }
                else if (ddlMod.SelectedValue == "Companies")
                {
                    strScript = "alert('City Trend in Companies Category is Posted Successfully.');location.replace('Admin_ToPostCityTrendsMoredetails.aspx?ctid=" + ctId + "&mod="+mod+"');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                }
                else if (ddlMod.SelectedValue == "Education")
                {
                    strScript = "alert('City Trend in Education Category is Posted Successfully.');location.replace('Admin_ToPostCityTrendsMoredetails.aspx?ctid=" + ctId + "&mod=" + mod + "');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                }
                else if (ddlMod.SelectedValue == "Health")
                {
                    strScript = "alert('City Trend in Health Category is Posted Successfully.');location.replace('Admin_ToPostCityTrendsMoredetails.aspx?ctid=" + ctId + "&mod=" + mod + "');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                }
                else if (ddlMod.SelectedValue == "Hotels & Restaurants")
                {
                    strScript = "alert('City Trend in Hotels & Restaurants Category is Posted Successfully.');location.replace('Admin_ToPostCityTrendsMoredetails.aspx?ctid=" + ctId + "&mod=" + mod + "');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                }
                else if (ddlMod.SelectedValue == "Movies")
                {
                    strScript = "alert('City Trend in Movies Category is Posted Successfully.');location.replace('Admin_CityTrends.aspx?mod="+mod+"');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                }
                else if (ddlMod.SelectedValue == "Tours and Travel")
                {
                    strScript = "alert('City Trend in Tours and Travel Category is Posted Successfully.');location.replace('Admin_ToPostCityTrendsMoredetails.aspx?ctid=" + ctId + "&mod=" + mod + "');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                }
            }
        }
        else
        {
            lblInfo.Text = "";
        }
    }
    /// <summary>
    /// validation for selection of listings count limit to 5
    /// </summary>
    /// <param name="source"></param>
    /// <param name="args"></param>
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        int count = 0;

        for (int i = 0; i < lstCompNames.Items.Count; i++)
        {

            if (lstCompNames.Items[i].Selected)

                count++;

        }

        args.IsValid = (count > 5) ? false : true;
        lblInfo.Text = Convert.ToString(args.IsValid);
    }
    /// <summary>
    /// executes whenever category selection is changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlCat_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlCat.SelectedIndex != 0)
        {
            string Cat = Convert.ToString(ddlCat.SelectedValue);
            fillBusinessSubCategories(Cat);
        }
        else
        {
            ddlSubCat.Items.Clear();
            ddlSubCat.Items.Insert(0, "Select SubCategory");
        }        
    }
    /// <summary>
    /// to cancel posting of city trends 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void imgBtn_Cancel_Click(object sender, ImageClickEventArgs e)
    {        
          Response.Redirect("Admin_CityTrends.aspx");                   
    }
    /// <summary>
    /// whenever company names selection is changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlCompNames_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataSet dsdesc = new DataSet();
        dsdesc = data.getDesc(ddlCompNames.SelectedValue);
        if (!dsdesc.Tables[0].Rows.Count.Equals(0))
        {
            txtDesc.Text = dsdesc.Tables[0].Rows[0]["company_profile"].ToString();
            txtArea.Text = dsdesc.Tables[0].Rows[0]["Area"].ToString();
        }
    }
}
