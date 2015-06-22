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
/// class to update city trends
/// </summary>
public partial class admin_Admin_ToEditCityTrends : System.Web.UI.Page
{
    //declaration of variables and creation of objects for classes
    string mod;
    string cat;
    string SubCat;
    string state;
    string City;
    string title;
    string desc;
    string Listing;
    string Lang;
    string ListingId;
    string ListingLang;
    string Subtitle;
    string UserId;
    int selectionCount;
    string strScript;
    string query;
    string enteredTitle;
    string MName;
    string MLang;
    string MDesc;
    string Area;
    bool t;
    Int32 ctid;
    DataCS data = new DataCS();
    DataSet ds = new DataSet();
    DataSet dscat = new DataSet();
    DataSet dsMovies = new DataSet();
    DataSet dsBus = new DataSet();
    DataSet dsOther = new DataSet();
    CityTrendsCS obj = new CityTrendsCS();
    char[] separator = new char[] { '-' };
    char[] separatorcomma = new char[] { ',' };
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
        ctid = Convert.ToInt32(Request.QueryString["CtId"]);
        //loads the page without postbacking the values
        if (!IsPostBack)
        {    
            //fill city trends categories
            data.FillCityTrends_Cat(ddlMod);
            //fill states
            data.FillStates(ddlState);
            //calling Get Basic city trends information
            GetCityTrends();
            //visibility conditions
            Conditions();
            //calling Get city trends information based on categories
            if (mod == "Movies")
            {
                GetCTMovieDetails();
                lnkMoreInfo.Visible = false;
            }
            else if (mod == "Businesses")
            {
                GetCTBusDetails();
                lnkMoreInfo.Visible = false;
            }
            else
            {
                GetOtherCatDetails();
                //lnkMoreInfo.Visible = true;
            }
        }
    }
    /// <summary>
    /// Get Basic city trends information
    /// </summary>
    private void GetCityTrends()
    {
              
        ds = obj.GetCTrendParticular(ctid);
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            mod = ds.Tables[0].Rows[0]["mod"].ToString();
            cat = ds.Tables[0].Rows[0]["cat"].ToString();
            SubCat = ds.Tables[0].Rows[0]["subcat"].ToString();
            state = ds.Tables[0].Rows[0]["state"].ToString();
            City = ds.Tables[0].Rows[0]["city"].ToString();
            title = ds.Tables[0].Rows[0]["title"].ToString();
            desc = ds.Tables[0].Rows[0]["description"].ToString();
            Listing = ds.Tables[0].Rows[0]["listings"].ToString();
            enteredTitle = ds.Tables[0].Rows[0]["titleEntered"].ToString();
            ListingId = ds.Tables[0].Rows[0]["dataIds_lang"].ToString();
            Area = ds.Tables[0].Rows[0]["Area"].ToString();
            lblModule.Text = mod;
            for (int i = 0; i < ddlMod.Items.Count; i++)
            {
                if (ddlMod.Items[i].Value == mod.ToString())
                {
                    ddlMod.SelectedValue = ddlMod.Items[i].Value;
                    break;
                }
            }
            if (mod == "Businesses")
            {
                fillBusinessCategories();
                fillBusinessSubCategories(cat);
            }
            for (int i = 0; i < ddlCat.Items.Count; i++)
            {
                if (ddlCat.Items[i].Value == cat.ToString())
                {
                    ddlCat.SelectedValue = ddlCat.Items[i].Value;
                    break;
                }
            }
            for (int i = 0; i < ddlSubCat.Items.Count; i++)
            {
                if (ddlSubCat.Items[i].Value == SubCat.ToString())
                {
                    ddlSubCat.SelectedValue = ddlSubCat.Items[i].Value;
                    break;
                }
            }
            for (int i = 0; i < ddlState.Items.Count; i++)
            {
                if (ddlState.Items[i].Value == state.ToString())
                {
                    ddlState.SelectedValue = ddlState.Items[i].Value;
                    break;
                }
            }
            fillCities(state);
            for (int i = 0; i < ddlCity.Items.Count; i++)
            {
                if (ddlCity.Items[i].Value == City.ToString())
                {
                    ddlCity.SelectedValue = ddlCity.Items[i].Value;
                    break;
                }
            }
            Conditions();
            txtTitle.Text = enteredTitle;
            txtDesc.Text = desc;
            txtArea.Text = Area;
            if (mod == "Businesses")
            {
                fillBusinessListing(City);
                string[] strSplitArr = Listing.Split(separatorcomma);
                foreach (string arrstrr in strSplitArr)
                {
                    for (int i = 0; i < lstCompNames.Items.Count; i++)
                    {
                        if (lstCompNames.Items[i].Text == arrstrr)
                        {
                            lstCompNames.Items[i].Selected = true;
                            break;
                        }
                    }
                }
            }
            else if (mod == "Companies")
            {
                fillCompaniesListing(City);

                for (int i = 0; i < ddlCompNames.Items.Count; i++)
                {
                    if (ddlCompNames.Items[i].Text == Listing.ToString())
                    {
                        ddlCompNames.SelectedItem.Text = ddlCompNames.Items[i].Text;
                        break;
                    }
                }
            }
            else if (mod == "Education")
            {
                fillEducationListing(City);

                for (int i = 0; i < ddlCompNames.Items.Count; i++)
                {
                    if (ddlCompNames.Items[i].Text == Listing.ToString())
                    {
                        ddlCompNames.SelectedItem.Text = ddlCompNames.Items[i].Text;
                        break;
                    }
                }
            }
            else if (mod == "Health")
            {
                fillHealthListing(City);

                for (int i = 0; i < ddlCompNames.Items.Count; i++)
                {
                    if (ddlCompNames.Items[i].Text == Listing.ToString())
                    {
                        ddlCompNames.SelectedItem.Text = ddlCompNames.Items[i].Text;
                        break;
                    }
                }
            }
            else if (mod == "Hotels & Restaurants")
            {
                fillHotelsListing(City);

                for (int i = 0; i < ddlCompNames.Items.Count; i++)
                {
                    if (ddlCompNames.Items[i].Text == Listing.ToString())
                    {
                        ddlCompNames.SelectedItem.Text = ddlCompNames.Items[i].Text;
                        break;
                    }
                }
            }
            else if (mod == "Tours and Travel")
            {
                fillCompaniesListing(City);

                for (int i = 0; i < ddlCompNames.Items.Count; i++)
                {
                    if (ddlCompNames.Items[i].Text == Listing.ToString())
                    {
                        ddlCompNames.SelectedItem.Text = ddlCompNames.Items[i].Text;
                        break;
                    }
                }
            }
            else if (mod == "Movies")
            {
                fillMoviesListing(City);
                string[] strSplitArr = Listing.Split(separatorcomma);
                foreach (string arrstrr in strSplitArr)
                {
                    for (int i = 0; i < lstCompNames.Items.Count; i++)
                    {
                        if (lstCompNames.Items[i].Value == arrstrr)
                        {
                            lstCompNames.Items[i].Selected = true;
                            break;
                        }
                    }
                }
            }
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
            query = "select city_Id,city_name from Cities where state_name= '" + StateName + "'";
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
        Conditions();
        ddlState.SelectedIndex = 0;
        if (ddlMod.SelectedValue == "Businesses")
        {
            fillBusinessCategories();
        }
    }
    /// <summary>
    /// Filling business categories
    /// </summary>
    public void fillBusinessCategories()
    {
        try
        {
            query = "select * from Categories where Module='Category' order by Category";

            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataAdapter da1 = new SqlDataAdapter(query, connection);
            da1.Fill(dscat, "Cat");
            ddlCat.DataSource = dscat.Tables["Cat"];
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
            query = "select * from subcatageory where maincat='" + cat + "' order by cat";

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
            query = "select id,company_name from ModulesData where City='" + City + "' and SubCategory='" + ddlSubCat.SelectedValue + "' order by company_name";
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
        ModuleSelectionConditions();
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
    /// Visibility conditions of data
    /// </summary>
    private void Conditions()
    {
        if (ddlMod.SelectedValue == "Businesses")
        {
            trArea.Visible = false;            
            trGDesc.Visible = true;
            trddlList.Visible = false;
            trCat.Visible = true;
            trSubCat.Visible = true;
            trTitle.Visible = true;
            trState.Visible = true;
            trCity.Visible = true;
            trList.Visible = true;
            lblselecttop.Text = "Businesses";           
        }
        else if (ddlMod.SelectedValue == "Companies")
        {
            trArea.Visible = true;           
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
        }
        else if (ddlMod.SelectedValue == "Education")
        {
            trArea.Visible = true;            
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
        }
        else if (ddlMod.SelectedValue == "Health")
        {
            trArea.Visible = true;           
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
        }
        else if (ddlMod.SelectedValue == "Hotels & Restaurants")
        {
            trArea.Visible = true;           
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
        }
        else if (ddlMod.SelectedValue == "Movies")
        {
            trArea.Visible = false;            
            trGDesc.Visible = true;
            trddlList.Visible = false;
            trList.Visible = true;
            trCat.Visible = false;
            trSubCat.Visible = false;
            trCity.Visible = true;
            trState.Visible = true;
            trTitle.Visible = false;
            lblselecttop.Text = "Movies";           
        }
        else if (ddlMod.SelectedValue == "Tours and Travel")
        {
            trArea.Visible = true;            
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
        }
    }
    /// <summary>
    /// module selection conditions 
    /// </summary>
    private void ModuleSelectionConditions()
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
    }
    /// <summary>
    /// click event to update city trends
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
   protected void btnUpdate_Click(object sender, EventArgs e)
    {
        if (lblInfo.Text == "True")
        {
            SubCat = Convert.ToString(ddlSubCat.SelectedValue);
            City = Convert.ToString(ddlCity.SelectedValue);
            obj.ctMod = Convert.ToString(ddlMod.SelectedValue);
            obj.ctCat = Convert.ToString(ddlCat.SelectedValue);
            obj.ctSubCat = SubCat;
            obj.ctState = Convert.ToString(ddlState.SelectedValue);
            obj.ctCity = City;
            obj.ctTitleentered = Convert.ToString(txtTitle.Text);
            obj.ctDesc = Convert.ToString(txtDesc.Text);
            obj.ctId = ctid;
            obj.ctUserId = UserId;
            obj.ctPostdate = DateTime.Now;
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
                string title = Convert.ToString(txtTitle.Text);
                obj.ctTitle = title + " in " + City;
            }
            else if (ddlMod.SelectedValue == "Companies")
            {
                obj.ctListing_Lang_Ids = ddlCompNames.SelectedValue;
                Listing = ddlCompNames.SelectedItem.Text;
                Subtitle = "";
                obj.ctTitle = ddlCompNames.SelectedItem.Text + " in " + txtArea.Text + ", " + ddlCity.SelectedValue;
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
                obj.ctTitle = "Movie Trends in " + City;
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
            t = obj.CityTrends_Update(obj.ctMod, obj.ctCat, obj.ctSubCat, obj.ctState, obj.ctCity, obj.ctTitle,
                                    obj.ctDesc, obj.ctListing, obj.ctListing_Lang_Ids, obj.ctSubHeading,
                                    obj.ctUserId, obj.ctPostdate,obj.ctId,obj.ctTitleentered);            
                lblInfo.Text = "";
                mod=ddlMod.SelectedValue;
                if (mod == "Businesses")
                {
                    strScript = "alert('City Trend in Businesses Category is updated Successfully.');location.replace('Admin_CityTrends.aspx?mod=" + mod + "');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                }
                else if (mod == "Companies")
                {
                    strScript = "alert('City Trend in Companies Category is updated Successfully.');location.replace('Admin_CityTrends.aspx?mod=" + mod + "');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                }

                else if (mod == "Movies")
                {
                    strScript = "alert('City Trend in Movies Category is updated Successfully.');location.replace('Admin_CityTrends.aspx?mod=" + mod + "');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                }
                else if (mod == "Education")
                {
                    strScript = "alert('City Trend in Education Category is updated Successfully.');location.replace('Admin_CityTrends.aspx?mod=" + mod + "');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                }
                else if (mod == "Health")
                {
                    strScript = "alert('City Trend in Health Category is updated Successfully.');location.replace('Admin_CityTrends.aspx?mod=" + mod + "');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                }
                else if (mod == "Hotels & Restaurants")
                {
                    strScript = "alert('City Trend in Hotels & Restaurants Category is updated Successfully.');location.replace('Admin_CityTrends.aspx?mod=" + mod + "');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                }
                else if (mod == "Tours and Travel")
                {
                    strScript = "alert('City Trend in Tours and Travel Category is updated Successfully.');location.replace('Admin_CityTrends.aspx?mod=" + mod + "');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                }            
        }
        else
        {
            lblInfo.Text = "";
        }
    }
    /// <summary>
    /// click event to cance update and going to the view page of city trends based on the module
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
   protected void btnCancel_Click(object sender, EventArgs e)
    {
        if (ddlMod.SelectedValue == "Businesses")
        {
            Response.Redirect("Admin_CityTrends.aspx");

        }
        else if (ddlMod.SelectedValue == "Companies")
        {
            Response.Redirect("Admin_ToPostCityTrendsMoredetails.aspx?ctid=" + ctid + "&mod=Companies");

        }
        else if (ddlMod.SelectedValue == "Movies")
        {
            Response.Redirect("Admin_CityTrends.aspx?mod=Movies");
        }
    }
    /// <summary>
    /// click event post more information for city trends
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkMoreInfo_Click(object sender, EventArgs e)
    {
        mod = ddlMod.SelectedValue;
        Response.Redirect("Admin_ToPostCityTrendsMoredetails.aspx?ctid="+ctid+"&mod="+mod);
    }
    /// <summary>
    /// To get movie details and binding to the respective fields
    /// </summary>
    private void GetCTMovieDetails()
    {
        connection.Open();
        string strListing = Convert.ToString(Listing); ;
        string strlistIds = Convert.ToString(ListingId);

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
    /// to get business details and binding to the respective fields
    /// </summary>
    private void GetCTBusDetails()
    {
        connection.Open();
        string strListing = Convert.ToString(Listing); ;
        string strlistIds = Convert.ToString(ListingId);

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
    /// to get other category details and binding to the respective fields
    /// </summary>
    private void GetOtherCatDetails()
    {
        dsOther = obj.GetMoreInfo(ctid);
        if (!dsOther.Tables[0].Rows.Count.Equals(0))
        {
            lblDisplay.Text = "More Information for "+ Listing+ " in the category of " +mod;
            dlOtherCatDetails.DataSource = dsOther;
            dlOtherCatDetails.DataBind();
            if ((dsOther.Tables[0].Rows.Count) >= 2)
            {
                lbldis.Text = "You entered already two more informations. You can't enter more";
                lnkMoreInfo.Enabled = false;
            }
            else
            {
                lbldis.Text = "You can enter one more information";
                lnkMoreInfo.Visible = true;
            }
        }
        else
        {
            lblDisplay.Text = "No More Information found. Please click on the below link to post more information about "+Listing;
        }
    }
    /// <summary>
    /// click event to pop up a window to edit movie description
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkEditMovieDescription(object sender, CommandEventArgs e)
    {        
        string getmovieinfo = e.CommandArgument.ToString();
        string[] strMdetails = getmovieinfo.Split(separatorcomma);
        MName = strMdetails[0];
        MLang = strMdetails[1];
        for (int i = 2; i<strMdetails.Length; i++)
        {
            MDesc += strMdetails[i];
        }
        lblMovieName.Text = MName;
        txtMoviedesc.Text = MDesc;
        lblMLang.Text = MLang;
        //To show modal pop up extender              
        ModalPopupExtender1.Show();
    }
    /// <summary>
    /// click event to edit movie description
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnMDescSubmit_Click(object sender, EventArgs e)
    {
        obj.ctMovieName = Convert.ToString(lblMovieName.Text);
        obj.ctMovieLang = Convert.ToString(lblMLang.Text);
        obj.ctMovieDesc = Convert.ToString(txtMoviedesc.Text);
        bool m = obj.ToEditMovieDesc(obj.ctMovieName, obj.ctMovieLang, obj.ctMovieDesc);
        strScript = "alert('Movie Description is updated successfully');location.replace('Admin_ToEditCityTrends.aspx?CtId=" + ctid + "');";
        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
    }
    /// <summary>
    /// To cancel editing of movie description
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnMDescCancel_Click(object sender, EventArgs e)
    {

    }
    /// <summary>
    /// click event to pop up a window to edit business description
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkEditBusinessDescription(object sender, CommandEventArgs e)
    {
        Int32 getBusId =Convert.ToInt32(e.CommandArgument.ToString());
        DataSet ds1 = new DataSet();
        ds1 = obj.GetBusinessInfo(getBusId);
        if (!ds1.Tables[0].Rows.Count.Equals(0))
        {
            lblbId.Text = ds1.Tables[0].Rows[0]["id"].ToString();
            lblbName.Text = ds1.Tables[0].Rows[0]["company_name"].ToString();
            txtBusDescription.Text = ds1.Tables[0].Rows[0]["company_profile"].ToString();
        }
            //To show modal pop up extender              
            ModalPopupExtender2.Show();            
    }
    /// <summary>
    /// click event to update business description
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnBProfileSubmit_Click(object sender, EventArgs e)
    {
        obj.ctdataid = Convert.ToInt32(lblbId.Text);
        obj.ctBusDesc = txtBusDescription.Text;
        bool b = obj.ToEditCompanyProfile(obj.ctdataid, obj.ctBusDesc);
        strScript = "alert('Business Description is updated successfully');location.replace('Admin_ToEditCityTrends.aspx?CtId=" + ctid + "');";
        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
    }
    /// <summary>
    /// To cancel editing of business profile
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnBProfileCancel_Click(object sender, EventArgs e)
    {

    }
    /// <summary>
    /// click event to go to another page to edit more information
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkEditMoreInfo(object sender, CommandEventArgs e)
    {
        Int32 getmoreId = Convert.ToInt32(e.CommandArgument.ToString());
        Response.Redirect("Admin_EditCTMoreInfo.aspx?MoreId=" + getmoreId);       
    }

}

