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
using JustCallUsData.Data;
using System.Data.SqlClient;
/// <summary>
/// Class to post Data into the just call uz site from admin control
/// </summary>
public partial class admin_Admin_Data : System.Web.UI.Page
{
    //creating object
    DataCS data = new DataCS();
    //Declaration of variables
    bool Alldata = false;
    string imgName;
    string imgContentType;
    string Str;
    string strScript = "";
    string UserId;
    // Making Sql Connection
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
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
        con.Open();
        string getdate = "select startmindate=DATEADD(mi,750,GETDATE()), startdatemax=DATEADD(dd,90,DATEADD(mi,750,GETDATE())),enddatemax=DATEADD(dd,365,DATEADD(mi,750,GETDATE())),jobexpdate=DATEADD(dd,60,DATEADD(mi,750,GETDATE()))";
        SqlDataAdapter ada = new SqlDataAdapter(getdate, con);
        DataSet ds = new DataSet();
        ada.Fill(ds);
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            string startdatemin = ds.Tables[0].Rows[0]["startmindate"].ToString();
            string startdatemax = ds.Tables[0].Rows[0]["startdatemax"].ToString();
            string enddatemax = ds.Tables[0].Rows[0]["enddatemax"].ToString();
            string jobexpdate = ds.Tables[0].Rows[0]["jobexpdate"].ToString();
            // Giving max and min values to the range validators at run time
            rangevalStartDate.ErrorMessage = " Please select " + Convert.ToDateTime(startdatemin).ToShortDateString() + " Onwards and till " + Convert.ToDateTime(startdatemax).ToShortDateString();
            rangevalEndDate.ErrorMessage = " Please select " + Convert.ToDateTime(startdatemin).ToShortDateString() + " Onwards and till " + Convert.ToDateTime(enddatemax).ToShortDateString();
            rangevalStartDate.MinimumValue = Convert.ToDateTime(startdatemin).ToShortDateString();
            rangevalStartDate.MaximumValue = Convert.ToDateTime(startdatemax).ToShortDateString();
            rangevalEndDate.MinimumValue = Convert.ToDateTime(startdatemin).ToShortDateString();
            rangevalEndDate.MaximumValue = Convert.ToDateTime(enddatemax).ToShortDateString();
            rangeValJobExpire.MinimumValue =Convert.ToDateTime(startdatemin).ToShortDateString();
            rangeValJobExpire.MaximumValue = Convert.ToDateTime(jobexpdate).ToShortDateString();
            rangeValJobExpire.ErrorMessage = " Please select " + Convert.ToDateTime(startdatemin).ToShortDateString() + " Onwards and till " + Convert.ToDateTime(jobexpdate).ToShortDateString();
            //Page loads without postbacking the values
            if (!Page.IsPostBack)
            {
                trCatandJobs.Visible = false;
                trEventName.Visible = false;
                trEventsPlace.Visible = false;

                //trEventsDiscounts.Visible = false;
                trEvDiDesc.Visible = false;
                trEvDiDuration.Visible = false;
                trEvDiEventTime.Visible = false;
                trEvDiStartDate.Visible = false;
                trEndDate.Visible = false;
                //trEvents.Visible = false;
                //trEventsDiscounts.Visible = false;
                trExpOther.Visible = false;
                trJobCat.Visible = false;
                //trJobs.Visible = false;
                trJobsAge.Visible = false;
                trJobsDesc.Visible = false;
                trJobsExperience.Visible = false;
                trJobsExpiry.Visible = false;
                trJobsFA.Visible = false;
                trJobsInd.Visible = false;
                trJobsQual.Visible = false;
                trJobsRole.Visible = false;
                trJobsSal.Visible = false;
                trJobsSkill.Visible = false;
                trOtherSubCat.Visible = false;
                trEndDate.Visible = false;
                trSubCat.Visible = false;
                
                //To bind Modules
                if (Convert.ToString(Request.QueryString["mod"]) != null)
                {
                    string module = Convert.ToString(Request.QueryString["mod"]);
                    ddlModule.Items.Add(module);
                }
                else
                {
                    string BPost = Convert.ToString(Session["BPost"]);
                    if (BPost == "1")
                    {
                        ddlModule.Items.Add("Category");

                    }

                    string B2BPost = Convert.ToString(Session["B2BPost"]);
                    if (B2BPost == "1")
                    {
                        ddlModule.Items.Add("B2B Category");

                    }
                    string EvePost = Convert.ToString(Session["EvePost"]);
                    if (EvePost == "1")
                    {
                        ddlModule.Items.Add("Events");

                    }
                    string DisPost = Convert.ToString(Session["DisPost"]);
                    if (DisPost == "1")
                    {
                        ddlModule.Items.Add("Discounts");

                    }
                    string JobPost = Convert.ToString(Session["JobPost"]);
                    if (JobPost == "1")
                    {
                        ddlModule.Items.Add("Jobs");

                    }
                    string LSPost = Convert.ToString(Session["LSPost"]);
                    if (LSPost == "1")
                    {
                        ddlModule.Items.Add("LifeStyle");

                    }
                    string FLPost = Convert.ToString(Session["FLPost"]);
                    if (FLPost == "1")
                    {
                        ddlModule.Items.Add("FreeListing");
                    }
                }
                //data.FillModule(ddlModule);
                //To bind States
                data.FillStates(ddlState);
                //To bind Industries
                data.FillIndustry(ddlJIndustry);
                //To bind Funtional Area
                data.FillFunctionalArea(ddlJFunArea);

            }
        }
        con.Close();
    }
    /// <summary>
    /// Function to bind the categories for the respective module
    /// </summary>
    /// <param name="Module_Name"></param>
    public void fillCategories(string Module_Name)
    {
        try
        {
            string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection oCon = new SqlConnection(Connection);
            if (Module_Name == "Discounts")
            {
                Module_Name = "Category";
            }
            else
            {
            }
            string s = "(select Category from Categories where Module= '"+Module_Name+"') except (select Category from Categories where Category='Movies') order by Category";
            SqlCommand cmd = new SqlCommand(s, oCon);
            oCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, oCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "Category");
            ddlCategory.DataSource = ds.Tables["Category"];
            ddlCategory.DataValueField = "Category";
            ddlCategory.DataTextField = "Category";
            ddlCategory.DataBind();
            ddlCategory.Items.Insert(0, "Select Category");
            oCon.Close();
        }
        //To catch exception
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    public void fillB2BSubCategories(string Categoty_Name)
    {
        try
        {
            string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection oCon = new SqlConnection(Connection);
            string s = "select id,cat from B2BCategories where maincat= '" + Categoty_Name + "' order by cat";
            SqlCommand cmd = new SqlCommand(s, oCon);
            oCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, oCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "SubCategory");
            ddlSubCat.DataSource = ds.Tables["SubCategory"];
            ddlSubCat.DataValueField = "cat";
            ddlSubCat.DataTextField = "cat";
            ddlSubCat.DataBind();
            ddlSubCat.Items.Insert(0, "Select Sub Category");
            oCon.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    public void fillFLSubCategories(string Categoty_Name)
    {
        try
        {
            string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection oCon = new SqlConnection(Connection);
            string s = "select sid,Sub_Cat from FreeListing_SubCat where Cat= '" + Categoty_Name + "' order by cat";
            SqlCommand cmd = new SqlCommand(s, oCon);
            oCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, oCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "SubCategory");
            ddlSubCat.DataSource = ds.Tables["SubCategory"];
            ddlSubCat.DataValueField = "Sub_Cat";
            ddlSubCat.DataTextField = "Sub_Cat";
            ddlSubCat.DataBind();
            ddlSubCat.Items.Insert(0, "Select Sub Category");
            oCon.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    /// <summary>
    /// To fill the sub ctegories for the coreesponding category 
    /// </summary>
    /// <param name="Categoty_Name"></param>
    public void fillSubCategories(string Categoty_Name)
    {
        try
        {
            string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection oCon = new SqlConnection(Connection);            
            string s = "select id,cat from subcatageory where maincat= '" + Categoty_Name + "'";
            SqlCommand cmd = new SqlCommand(s, oCon);
            oCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, oCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "SubCategory");
            ddlSubCat.DataSource = ds.Tables["SubCategory"];
            ddlSubCat.DataValueField = "cat";
            ddlSubCat.DataTextField = "cat";
            ddlSubCat.DataBind();
            ddlSubCat.Items.Insert(0, "Select Sub Category");
            oCon.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    public void fillLifeStyleSubCat(string Categoty_Name)
    {
        try
        {
            string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection oCon = new SqlConnection(Connection);
            string s = "select id,SubCategeory from Lifestyle where Categeory= '" + Categoty_Name + "' order by SubCategeory";
            SqlCommand cmd = new SqlCommand(s, oCon);
            oCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, oCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "SubCategory");
            ddlSubCat.DataSource = ds.Tables["SubCategory"];
            ddlSubCat.DataValueField = "SubCategeory";
            ddlSubCat.DataTextField = "SubCategeory";
            ddlSubCat.DataBind();
            ddlSubCat.Items.Insert(0, "Select Sub Category");
            oCon.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    /// <summary>
    /// To fill the cities for the corresponding States
    /// </summary>
    /// <param name="StateName"></param>
    public void fillCities(string StateName)
    {
        try
        {
            string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection oCon = new SqlConnection(Connection);
            string s = "select city_Id,city_name from Cities where state_name= '" + StateName + "' order by city_name";
            SqlCommand cmd = new SqlCommand(s, oCon);
            oCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, oCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "Cities");
            //DlCities.SelectedIndex = 0;

            ddlCity.DataSource = ds.Tables["Cities"];
            ddlCity.DataValueField = "city_name";
            ddlCity.DataTextField = "city_name";
            ddlCity.DataBind();
            ddlCity.Items.Insert(0, "Select City");
            oCon.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    /// <summary>
    /// Executes whenever module drop down selection changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlModule_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlModule.SelectedIndex != 0)
        {
            if (ddlModule.SelectedValue == "LifeStyle")
            {
                data.FillLifeStyleCategory(ddlCategory);
            }
            else if (ddlModule.SelectedValue == "B2B Category")
            {
                string Module_Name = Convert.ToString(ddlModule.SelectedValue);
                DataCS data = new DataCS();
                //To bind Categories
                data.FillB2BCategory(ddlCategory);
            }
            else if (ddlModule.SelectedValue == "FreeListing")
            {
                string Module_Name = Convert.ToString(ddlModule.SelectedValue);
                DataCS data = new DataCS();
                //To bind Categories
                data.FillFreeListing(ddlCategory);
                lblCompanyname.Text = "Title";
                lblCompProfile.Text = "Description";
            }
            else
            {
                string Module_Name = Convert.ToString(ddlModule.SelectedValue);
                fillCategories(Module_Name);
            }

        }
        else
        {
            ddlCategory.Items.Clear();
            ddlCategory.Items.Insert(0, "Select Category");
        }
        if (ddlModule.SelectedValue == "Category")
        {
            trCatandJobs.Visible = true;
            //trEvents.Visible = false;
            trEventName.Visible = false;
            trEventsPlace.Visible = false;

            //trEventsDiscounts.Visible = false;
            trEvDiDesc.Visible = false;
            trEvDiDuration.Visible = false;
            trEvDiEventTime.Visible = false;
            trEvDiStartDate.Visible = false;
            trEndDate.Visible = false;

            trExpOther.Visible = false;
            trJobCat.Visible = true;
            //trJobs.Visible = false;
            trJobsAge.Visible = false;
            trJobsDesc.Visible = false;
            trJobsExperience.Visible = false;
            trJobsExpiry.Visible = false;
            trJobsFA.Visible = false;
            trJobsInd.Visible = false;
            trJobsQual.Visible = false;
            trJobsRole.Visible = false;
            trJobsSal.Visible = false;
            trJobsSkill.Visible = false;

            trUploadPhoto.Visible = true;
            lblPhoto.Text = "Logo";
            
        }
        if (ddlModule.SelectedValue == "FreeListing")
        {
            trCatandJobs.Visible = true;
            //trEvents.Visible = false;
            trEventName.Visible = false;
            trEventsPlace.Visible = false;

            //trEventsDiscounts.Visible = false;
            trEvDiDesc.Visible = false;
            trEvDiDuration.Visible = false;
            trEvDiEventTime.Visible = false;
            trEvDiStartDate.Visible = false;
            trEndDate.Visible = false;

            trExpOther.Visible = false;
            trJobCat.Visible = true;
            //trJobs.Visible = false;
            trJobsAge.Visible = false;
            trJobsDesc.Visible = false;
            trJobsExperience.Visible = false;
            trJobsExpiry.Visible = false;
            trJobsFA.Visible = false;
            trJobsInd.Visible = false;
            trJobsQual.Visible = false;
            trJobsRole.Visible = false;
            trJobsSal.Visible = false;
            trJobsSkill.Visible = false;

            trUploadPhoto.Visible = true;
            lblPhoto.Text = "Logo";
        }
        else if (ddlModule.SelectedValue == "Events")
        {
            trCatandJobs.Visible = false;
            //trEvents.Visible = true;
            trEventName.Visible = true;
            trEventsPlace.Visible = true;

            //trEventsDiscounts.Visible = true;
            trEvDiDesc.Visible = true;
            trEvDiDuration.Visible = true;
            trEvDiEventTime.Visible = true;
            trEvDiStartDate.Visible = true;
            trEndDate.Visible = false;

            trExpOther.Visible = false;
            trJobCat.Visible = false;
            //trJobs.Visible = false;
            trJobsAge.Visible = false;
            trJobsDesc.Visible = false;
            trJobsExperience.Visible = false;
            trJobsExpiry.Visible = false;
            trJobsFA.Visible = false;
            trJobsInd.Visible = false;
            trJobsQual.Visible = false;
            trJobsRole.Visible = false;
            trJobsSal.Visible = false;
            trJobsSkill.Visible = false;

            trUploadPhoto.Visible = true;
            lblPhoto.Text = "Image";
            
        }
        else if (ddlModule.SelectedValue == "Jobs")
        {
            trCatandJobs.Visible = true;
            //trEvents.Visible = false;
            trEventName.Visible = false;
            trEventsPlace.Visible = false;
            //trEventsDiscounts.Visible = false;
            trEvDiDesc.Visible = false;
            trEvDiDuration.Visible = false;
            trEvDiEventTime.Visible = false;
            trEvDiStartDate.Visible = false;
            trEndDate.Visible = false;

            trExpOther.Visible = false;
            trJobCat.Visible = true;
            //trJobs.Visible = true;
            trJobsAge.Visible = true;
            trJobsDesc.Visible = true;
            trJobsExperience.Visible = true;
            trJobsExpiry.Visible = true;
            trJobsFA.Visible = true;
            trJobsInd.Visible = true;
            trJobsQual.Visible = true;
            trJobsRole.Visible = true;
            trJobsSal.Visible = true;
            trJobsSkill.Visible = true;

            trUploadPhoto.Visible = true;
            lblPhoto.Text = "Logo";
        }
        else if (ddlModule.SelectedValue == "Discounts")
        {
            trCatandJobs.Visible = true;
            //trEvents.Visible = false;
            trEventName.Visible = false;
            trEventsPlace.Visible = false;

            //trEventsDiscounts.Visible = true;
            trEvDiDesc.Visible = true;
            trEvDiDuration.Visible = true;
            trEvDiEventTime.Visible = true;
            trEvDiStartDate.Visible = true;
            trEndDate.Visible = false;

            trExpOther.Visible = false;
            trJobCat.Visible = true;
            //trJobs.Visible = false;
            trJobsAge.Visible = false;
            trJobsDesc.Visible = false;
            trJobsExperience.Visible = false;
            trJobsExpiry.Visible = false;
            trJobsFA.Visible = false;
            trJobsInd.Visible = false;
            trJobsQual.Visible = false;
            trJobsRole.Visible = false;
            trJobsSal.Visible = false;
            trJobsSkill.Visible = false;

            trUploadPhoto.Visible = true;
            lblPhoto.Text = "Logo";
        }
        else if (ddlModule.SelectedValue == "B2B Category")
        {            
            trCatandJobs.Visible = true;
            //trEvents.Visible = false;
            trEventName.Visible = false;
            trEventsPlace.Visible = false;
            //trEventsDiscounts.Visible = false;
            trEvDiDesc.Visible = false;
            trEvDiDuration.Visible = false;
            trEvDiEventTime.Visible = false;
            trEvDiStartDate.Visible = false;
            trEndDate.Visible = false;

            trExpOther.Visible = false;
            trJobCat.Visible = true;
            //trJobs.Visible = false;
            trJobsAge.Visible = false;
            trJobsDesc.Visible = false;
            trJobsExperience.Visible = false;
            trJobsExpiry.Visible = false;
            trJobsFA.Visible = false;
            trJobsInd.Visible = false;
            trJobsQual.Visible = false;
            trJobsRole.Visible = false;
            trJobsSal.Visible = false;
            trJobsSkill.Visible = false;

            trUploadPhoto.Visible = true;
            lblPhoto.Text = "Logo";
        }
        else if (ddlModule.SelectedValue == "LifeStyle")
        {
            trCatandJobs.Visible = true;
            //trEvents.Visible = false;
            trEventName.Visible = false;
            trEventsPlace.Visible = false;
            //trEventsDiscounts.Visible = false;
            trEvDiDesc.Visible = false;
            trEvDiDuration.Visible = false;
            trEvDiEventTime.Visible = false;
            trEvDiStartDate.Visible = false;
            trEndDate.Visible = false;

            trExpOther.Visible = false;
            trJobCat.Visible = true;
            //trJobs.Visible = false;
            trJobsAge.Visible = false;
            trJobsDesc.Visible = false;
            trJobsExperience.Visible = false;
            trJobsExpiry.Visible = false;
            trJobsFA.Visible = false;
            trJobsInd.Visible = false;
            trJobsQual.Visible = false;
            trJobsRole.Visible = false;
            trJobsSal.Visible = false;
            trJobsSkill.Visible = false;

            trUploadPhoto.Visible = true;
            lblPhoto.Text = "Logo";
        }
    }
    /// <summary>
    /// Executes whenever category drop down selection changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlCategory.SelectedIndex != 0)
        {
            string Categoty_Name = Convert.ToString(ddlCategory.SelectedValue);

            if (ddlModule.SelectedValue == "LifeStyle")
            {
                string statement = "select * from Lifestyle where Categeory='" + ddlCategory.SelectedValue + "'";
                con.Open();
                SqlDataAdapter adabrand = new SqlDataAdapter(statement, con);
                DataSet dsbrand = new DataSet();
                adabrand.Fill(dsbrand);
                con.Close();
                if (!dsbrand.Tables[0].Rows.Count.Equals(0))
                {
                    trSubCat.Visible = true;
                    fillLifeStyleSubCat(Categoty_Name);
                }
                else
                {
                    trSubCat.Visible = false;
                    ddlSubCat.Items.Clear();
                    ddlSubCat.Items.Insert(0, "Select SubCategory");
                }               
            }
            else if (ddlModule.SelectedValue == "B2B Category")
            {
                string statement1 = "select * from B2BCategories where maincat='" + ddlCategory.SelectedValue + "'";
                con.Open();
                SqlDataAdapter adab2b= new SqlDataAdapter(statement1, con);
                DataSet dsb2b = new DataSet();
                adab2b.Fill(dsb2b);
                con.Close();
                if (!dsb2b.Tables[0].Rows.Count.Equals(0))
                {

                    trSubCat.Visible = true;
                    fillB2BSubCategories(Categoty_Name);
                }
                else
                {
                    trSubCat.Visible = false;
                    ddlSubCat.Items.Clear();
                    ddlSubCat.Items.Insert(0, "Select SubCategory");
                }  
            }
            else if (ddlModule.SelectedValue == "FreeListing")
            {
                string statement0 = "select * from FreeListing_SubCat where Cat='" + ddlCategory.SelectedValue + "'";
                con.Open();
                SqlDataAdapter adFL= new SqlDataAdapter(statement0, con);
                DataSet dsFL = new DataSet();
                adFL.Fill(dsFL);
                con.Close();
                if (!dsFL.Tables[0].Rows.Count.Equals(0))
                {
                    trSubCat.Visible = true;
                    fillFLSubCategories(Categoty_Name);
                }
                else
                {
                    trSubCat.Visible = false;
                    ddlSubCat.Items.Clear();
                    ddlSubCat.Items.Insert(0, "Select SubCategory");
                }
            }
            else
            {
                string statement2 = "select * from subcatageory where maincat='" + ddlCategory.SelectedValue + "'";
                con.Open();
                SqlDataAdapter adacat = new SqlDataAdapter(statement2, con);
                DataSet dscat = new DataSet();
                adacat.Fill(dscat);
                con.Close();
                if (!dscat.Tables[0].Rows.Count.Equals(0))
                {
                    trSubCat.Visible = true;
                    fillSubCategories(Categoty_Name);
                }
                else
                {
                    trSubCat.Visible = false;
                    ddlSubCat.Items.Clear();
                    ddlSubCat.Items.Insert(0, "Select SubCategory");
                }
            }
        }
        else
        {
            ddlSubCat.Items.Clear();
            ddlSubCat.Items.Insert(0, "Select Sub Category");
        }
    }
    /// <summary>
    /// Executes whenever state drop down selection changed
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
    /// Function to post data
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSubmit_Click(object sender, ImageClickEventArgs e)
    {      
        string UserId = Convert.ToString(Session["LogInId"]);
        string Modules="";
        string Cat = "";
        string SubCat = "";
        string SubCat_Other = "";
        string State="";
        string City="";
        string Area = "";
        string CompanyName = "";
        string Industry = "";
        string FunctionalArea = "";
        string Role="";
        string Qualification = "";
        string JobAge = "";
        string Experience = "";
        string Salary = "";
        string JobDesc = "";
        string KeySkills = "";
        DateTime JobExpiryDate;
        string CompanyProfile = "";
        string EventName="";
        string EventPlace="";
        string EventDurationType = "";
        DateTime StartDate;
        DateTime EndDate;
        string Description="";
        string TimeDuration="";
        string Address="";
        string LandMark="";
        string ContactPerson = "";
        string EmailId = "";
        string Phone = "";
        string Mobile="";
        string Fax = "";
        string WebSite = "";
        string Pincode = "";
             
        Modules = Convert.ToString(ddlModule.SelectedValue);
        Cat = Convert.ToString(ddlCategory.SelectedValue);
        if (ddlSubCat.SelectedItem.Text == "Others")
        {
            SubCat_Other = Convert.ToString(txtOthers.Text);
        }
        else
        {

            SubCat_Other = Convert.ToString(ddlSubCat.SelectedItem.Text);
        }
        State = Convert.ToString(ddlState.SelectedValue);
        Area = Convert.ToString(txtArea.Text);
        City = Convert.ToString(ddlCity.SelectedValue);
        CompanyName = Convert.ToString(txtCompanyname.Text);
        Industry = Convert.ToString(ddlJIndustry.Text);
        FunctionalArea = Convert.ToString(ddlJFunArea.Text);
        Role = Convert.ToString(txtJRole.Text);
        Qualification = Convert.ToString(txtJQual.Text);
        JobAge = Convert.ToString(txtAge.Text);
        if (ddlExp.SelectedValue == "Experience")
        {
            Experience = Convert.ToString(txtJExp.Text);
        }
        else
        {
            Experience = Convert.ToString(ddlExp.SelectedValue);
        }
        Salary = Convert.ToString(txtJSal.Text);
        JobDesc = Convert.ToString(txtJobDesc.Text);
        KeySkills = Convert.ToString(txtJkeyskills.Text);
        if (txtJobExpire.Text != "")
        {
            JobExpiryDate = Convert.ToDateTime(txtJobExpire.Text);
        }
        else
        {
            JobExpiryDate = DateTime.MinValue;
        }
        CompanyProfile = Convert.ToString(txtCompanyProfile.Text);
        EventName = Convert.ToString(txtEveName.Text);
        EventPlace = Convert.ToString(txtEvePlace.Text);
        EventDurationType = Convert.ToString(ddlDurationType.SelectedValue);
        if (txtEveDiStartDate.Text != "")
        {
            StartDate = Convert.ToDateTime(txtEveDiStartDate.Text);
        }
        else
        {
            StartDate = DateTime.MinValue;
        }
        if (txtEveDiEndDate.Text != "")
        {
            EndDate = Convert.ToDateTime(txtEveDiEndDate.Text);
        }
        else
        {
            EndDate = DateTime.MinValue;
        }
        Description = Convert.ToString(txtEveDiDesc.Text);
        TimeDuration = Convert.ToString(txtEveDiTime.Text);
        Address = Convert.ToString(txtaddr.Text);
        LandMark = Convert.ToString(txtLandMark.Text);
        Pincode = Convert.ToString(txtPinCode.Text);
        ContactPerson = Convert.ToString(txtContPerson.Text);
        EmailId = Convert.ToString(txtemail.Text);
        Phone = Convert.ToString(txtph.Text);
        Mobile = Convert.ToString(txtmobile.Text);
        Fax = Convert.ToString(txtFax.Text);
        WebSite = Convert.ToString(txtWebsite.Text);
        string CatSub = string.Empty;
        con.Open();
        if (ddlSubCat.SelectedIndex != 0)
        {
            SubCat = Convert.ToString(ddlSubCat.SelectedValue);
            CatSub =ddlCategory.SelectedValue + "-" + ddlSubCat.SelectedValue;
        }
        else
        {
            SubCat = "";
            CatSub = "";
        }        
        // Checking file size to upload
        if (Session["LoginId"] != null)
        {
            if (Imgupload.HasFile)
            {
                if (Imgupload.PostedFile.ContentLength < 20000)
                {
                    Str = Imgupload.PostedFile.FileName;
                    imgName = System.IO.Path.GetFileName(Imgupload.PostedFile.FileName);
                    if (Modules == "Events")
                    {
                        Imgupload.PostedFile.SaveAs(Server.MapPath("~/Event_Images/" + imgName));
                        using (System.Drawing.Image Img = System.Drawing.Image.FromFile(Server.MapPath("~/Event_Images/" + imgName)))
                        {
                            if (Img.Width == 250 & Img.Height == 300)
                            {
                                Str = Imgupload.PostedFile.FileName;
                                imgName = System.IO.Path.GetFileName(Imgupload.PostedFile.FileName);                               
                                imgContentType = Imgupload.PostedFile.ContentType;
                            }
                        }
                    }
                    else
                    {
                        Imgupload.PostedFile.SaveAs(Server.MapPath("~/Logos/" + imgName));
                        using (System.Drawing.Image Img = System.Drawing.Image.FromFile(Server.MapPath("~/Logos/" + imgName)))
                        {
                            if (Img.Width == 100 & Img.Height == 75)
                            {
                                Str = Imgupload.PostedFile.FileName;
                                imgName = System.IO.Path.GetFileName(Imgupload.PostedFile.FileName);
                                imgContentType = Imgupload.PostedFile.ContentType;
                            }
                        }
                    }
                }
            }
            else
            {
                if (Modules == "Events")
                {
                    if (SubCat == "Arts And Crafts")
                    {
                        imgName = "ArtsandCrafts.png";
                        imgContentType = "image/x-png";
                    }
                    if (SubCat == "AwardCeremonies")
                    {
                        imgName = "AwardCeremonies.png";
                        imgContentType = "image/x-png";
                    }
                    if (SubCat == "Awards night")
                    {
                        imgName = "Awards-night.png";
                        imgContentType = "image/x-png";
                    }
                    if (SubCat == "Beauty pageant")
                    {
                        imgName = "Beauty-Pageant.png";
                        imgContentType = "image/x-png";
                    }
                    if (SubCat == "Birthdays")
                    {
                        imgName = "Birthdays.png";
                        imgContentType = "image/x-png";
                    }
                    if (SubCat == "Board Meetings")
                    {
                        imgName = "Board-Meetings.png";
                        imgContentType = "image/x-png";
                    }
                    if (SubCat == "Business Dinners")
                    {
                        imgName = "Business-Dinners.png";
                        imgContentType = "image/x-png";
                    }
                    if (SubCat == "Community")
                    {
                        imgName = "Community.png";
                        imgContentType = "image/x-png";
                    }
                    if (SubCat == "Concerts")
                    {
                        imgName = "Concerts.png";
                        imgContentType = "image/x-png";
                    }
                    if (SubCat == "Conferences")
                    {
                        imgName = "Conferences1.png";
                        imgContentType = "image/x-png";
                    }
                    if (SubCat == "Educational tours")
                    {
                        imgName = "Educational-tours.png";
                        imgContentType = "image/x-png";
                    }
                    if (SubCat == "Executive Retreats")
                    {
                        imgName = "Executive-Retreats.png";
                        imgContentType = "image/x-png";
                    }
                    if (SubCat == "Fashion shows")
                    {
                        imgName = "Fashion-shows.png";
                        imgContentType = "image/x-png";
                    }
                    if (SubCat == "Food And Drinks")
                    {
                        imgName = "Food-&-Drinks.png";
                        imgContentType = "image/x-png";
                    }
                    if (SubCat == "Golf Events")
                    {
                        imgName = "Golf-Events.png";
                        imgContentType = "image/x-png";
                    }
                    if (SubCat == "Graduations")
                    {
                        imgName = "Graduations.png";
                        imgContentType = "image/x-png";
                    }
                    if (SubCat == "Holiday Occasions")
                    {
                        imgName = "Holiday-Occasions.png";
                        imgContentType = "image/x-png";
                    }
                    if (SubCat == "Incentive Events")
                    {
                        imgName = "Incentive-Events.png";
                        imgContentType = "image/x-png";
                    }
                    if (SubCat == "Job Fairs")
                    {
                        imgName = "Job-Fairs.png";
                        imgContentType = "image/x-png";
                    }
                    if (SubCat == "Music")
                    {
                        imgName = "Music-1.png";
                        imgContentType = "image/x-png";
                    }
                    if (SubCat == "Networking Events")
                    {
                        imgName = "Networking-Events.png";
                        imgContentType = "image/x-png";
                    }
                    if (SubCat == "Opening Ceremonies")
                    {
                        imgName = "Opening-Cermonies.png";
                        imgContentType = "image/x-png";
                    }
                    if (SubCat == "Political rallies")
                    {
                        imgName = "Political-rallies.png";
                        imgContentType = "image/x-png";
                    }
                    if (SubCat == "Product Launches")
                    {
                        imgName = "Product-Launches.png";
                        imgContentType = "image/x-png";
                    }
                    if (SubCat == "Sales And Exhibitions")
                    {
                        imgName = "Sales-And-Exhibitions.png";
                        imgContentType = "image/x-png";
                    }
                    if (SubCat == "Seminars")
                    {
                        imgName = "Seminars.png";
                        imgContentType = "image/x-png";
                    }
                    if (SubCat == "Shareholder Meetings")
                    {
                        imgName = "Shareholder-Meetings.png";
                        imgContentType = "image/x-png";
                    }
                    if (SubCat == "Sports events")
                    {
                        imgName = "Sports-events.png";
                        imgContentType = "image/x-png";
                    }
                    if (SubCat == "Team Building Events")
                    {
                        imgName = "Team-Building-Events.png";
                        imgContentType = "image/x-png";
                    }
                    if (SubCat == "Theatre")
                    {
                        imgName = "Theatre.png";
                        imgContentType = "image/x-png";
                    }
                    if (SubCat == "Theme Parties")
                    {
                        imgName = "Theme-Parties.png";
                        imgContentType = "image/x-png";
                    }
                    if (SubCat == "Trade Fairs")
                    {
                        imgName = "Trade-Fairs.png";
                        imgContentType = "image/x-png";
                    }
                    if (SubCat == "VIP Events")
                    {
                        imgName = "VIP-Events.png";
                        imgContentType = "image/x-png";
                    }
                    if (SubCat == "Wedding Anniversaries")
                    {
                        imgName = "Wedding-Anniversaries.png";
                        imgContentType = "image/x-png";
                    }
                    if (SubCat == "Weddings")
                    {
                        imgName = "Weddings.png";
                        imgContentType = "image/x-png";
                    }
                }
                else
                {
                    imgName = "0";
                    imgContentType = "0";
                }
            }
            if (Imgupload.HasFile)
            {
                if (Imgupload.PostedFile.ContentLength < 20000)
                {
                    if (Modules == "Events")
                    {
                        using (System.Drawing.Image Img = System.Drawing.Image.FromFile(Server.MapPath("~/Event_Images/" + imgName)))
                        {
                            if (Img.Width == 250 & Img.Height == 300)
                            {
                                DataCS data1 = new DataCS();
                                data1.dModule = Modules;
                                data1.dCategory = Cat;
                                data1.dSubCategory = SubCat;
                                data1.dSubCategory_Other = SubCat_Other;
                                data1.dState = State;
                                data1.dCity = City;
                                data1.dArea = Area;
                                data1.jcdCompany_Name = CompanyName;
                                data1.jIndustry = Industry;
                                data1.jFun_Area = FunctionalArea;
                                data1.jRole = Role;
                                data1.jQualification = Qualification;
                                data1.jAge = JobAge;
                                data1.jExp = Experience;
                                data1.jSal = Salary;
                                data1.jJob_Desc = JobDesc;
                                data1.jSkills = KeySkills;
                                data1.jJob_Expiry = JobExpiryDate;
                                data1.jcdCompany_Profile = CompanyProfile;
                                data1.eEventName = EventName;
                                data1.eEventPlace = EventPlace;
                                data1.ediDurationType = EventDurationType;
                                data1.ediStartDate = StartDate;
                                data1.ediEndDate = EndDate;
                                data1.ediDescription = Description;
                                data1.ediTimeDuration = TimeDuration;
                                data1.dAddress = Address;
                                data1.dLandMark = LandMark;
                                data1.dPinCode = Pincode;
                                data1.dContact_Person = ContactPerson;
                                data1.dEmail = EmailId;
                                data1.dPhNumber = Phone;
                                data1.dMobile = Mobile;
                                data1.dFaxNo = Fax;
                                data1.dWebSite = WebSite;
                                data1.dPostDate = DateTime.Now.Date;
                                data1.dExpDate = (data1.dPostDate.AddDays(Convert.ToDouble(30)));
                                data1.dImgName = imgName;
                                data1.dImgContType = imgContentType;
                                data1.dLoginId = UserId;
                                data1.dCatSub = CatSub;
                                // Post data using 3-tier architecture
                                Alldata = data1.Data_Insert(data1.dModule, data1.dCategory, data1.dSubCategory, data1.dSubCategory_Other, data1.dState, data1.dCity, data1.dArea,
                                                          data1.jcdCompany_Name, data1.jIndustry, data1.jFun_Area, data1.jRole, data1.jQualification, data1.jAge,
                                                          data1.jExp, data1.jSal, data1.jJob_Desc, data1.jSkills, data1.jJob_Expiry, data1.jcdCompany_Profile,
                                                          data1.eEventName, data1.eEventPlace, data1.ediDurationType, data1.ediStartDate, data1.ediEndDate, data1.ediDescription,
                                                          data1.ediTimeDuration, data1.dAddress, data1.dLandMark, data1.dContact_Person, data1.dEmail,
                                                          data1.dPhNumber, data1.dMobile, data1.dFaxNo, data1.dWebSite, data1.dPostDate, data1.dExpDate, data1.dPinCode, data1.dLoginId, data1.dImgName, data1.dImgContType, data1.dCatSub);
                                // To alert
                                string getID = "select top 1 id from Modulesdata where UserLoginId='" + UserId + "' order by id desc";
                                SqlDataAdapter adaId = new SqlDataAdapter(getID, con);
                                DataSet dsId = new DataSet();
                                adaId.Fill(dsId);
                                if (!dsId.Tables[0].Rows.Count.Equals(0))
                                {
                                    string dId = dsId.Tables[0].Rows[0]["id"].ToString();
                                    strScript = "alert('Your Event is Posted Successfully.');location.replace('Admin_Data_Details.aspx?did=" + dId + "');";
                                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                                }
                            }
                            else
                            {
                                strScript = "alert('Image dimenstions should be 250 X 300.');";
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                            }
                        }
                    }
                    else
                    {
                        using (System.Drawing.Image Img = System.Drawing.Image.FromFile(Server.MapPath("~/Logos/" + imgName)))
                        {
                            if (Img.Width == 100 & Img.Height == 75)
                            {
                                DataCS data1 = new DataCS();
                                data1.dModule = Modules;
                                data1.dCategory = Cat;
                                data1.dSubCategory = SubCat;
                                data1.dSubCategory_Other = SubCat_Other;
                                data1.dState = State;
                                data1.dCity = City;
                                data1.dArea = Area;
                                data1.jcdCompany_Name = CompanyName;
                                data1.jIndustry = Industry;
                                data1.jFun_Area = FunctionalArea;
                                data1.jRole = Role;
                                data1.jQualification = Qualification;
                                data1.jAge = JobAge;
                                data1.jExp = Experience;
                                data1.jSal = Salary;
                                data1.jJob_Desc = JobDesc;
                                data1.jSkills = KeySkills;
                                data1.jJob_Expiry = JobExpiryDate;
                                data1.jcdCompany_Profile = CompanyProfile;
                                data1.eEventName = EventName;
                                data1.eEventPlace = EventPlace;
                                data1.ediDurationType = EventDurationType;
                                data1.ediStartDate = StartDate;
                                data1.ediEndDate = EndDate;
                                data1.ediDescription = Description;
                                data1.ediTimeDuration = TimeDuration;
                                data1.dAddress = Address;
                                data1.dLandMark = LandMark;
                                data1.dPinCode = Pincode;
                                data1.dContact_Person = ContactPerson;
                                data1.dEmail = EmailId;
                                data1.dPhNumber = Phone;
                                data1.dMobile = Mobile;
                                data1.dFaxNo = Fax;
                                data1.dWebSite = WebSite;
                                data1.dPostDate = DateTime.Now.Date;
                                data1.dExpDate = (data1.dPostDate.AddDays(Convert.ToDouble(30)));
                                data1.dImgName = imgName;
                                data1.dImgContType = imgContentType;
                                data1.dLoginId = UserId;
                                data1.dCatSub = CatSub;
                                // Post data using 3-tier architecture
                                Alldata = data1.Data_Insert(data1.dModule, data1.dCategory, data1.dSubCategory, data1.dSubCategory_Other, data1.dState, data1.dCity, data1.dArea,
                                                          data1.jcdCompany_Name, data1.jIndustry, data1.jFun_Area, data1.jRole, data1.jQualification, data1.jAge,
                                                          data1.jExp, data1.jSal, data1.jJob_Desc, data1.jSkills, data1.jJob_Expiry, data1.jcdCompany_Profile,
                                                          data1.eEventName, data1.eEventPlace, data1.ediDurationType, data1.ediStartDate, data1.ediEndDate, data1.ediDescription,
                                                          data1.ediTimeDuration, data1.dAddress, data1.dLandMark, data1.dContact_Person, data1.dEmail,
                                                          data1.dPhNumber, data1.dMobile, data1.dFaxNo, data1.dWebSite, data1.dPostDate, data1.dExpDate, data1.dPinCode, data1.dLoginId, data1.dImgName, data1.dImgContType, data1.dCatSub);
                                // To alert
                                string getID = "select top 1 id from Modulesdata where UserLoginId='" + UserId + "' order by id desc";
                                SqlDataAdapter adaId = new SqlDataAdapter(getID, con);
                                DataSet dsId = new DataSet();
                                adaId.Fill(dsId);
                                if (!dsId.Tables[0].Rows.Count.Equals(0))
                                {
                                    string dId = dsId.Tables[0].Rows[0]["id"].ToString();
                                    if (ddlModule.SelectedValue == "Category")
                                    {
                                        strScript = "alert('Your Category is Posted Successfully.');location.replace('Admin_EditData.aspx?did=" + dId + "#HRO');";
                                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                                    }
                                    else if (ddlModule.SelectedValue == "Jobs")
                                    {

                                        strScript = "alert('Your Job is Posted Successfully.');location.replace('Admin_Data_Details.aspx?did=" + dId + "');";
                                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                                    }                                   
                                    else if (ddlModule.SelectedValue == "Discounts")
                                    {
                                        strScript = "alert('Your Discount is Posted Successfully.');location.replace('Admin_EditData.aspx?did=" + dId + "#HRO');";
                                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                                    }
                                    else if (ddlModule.SelectedValue == "LifeStyle")
                                    {
                                        strScript = "alert('Your LifeStyle is Posted Successfully.');location.replace('Admin_EditData.aspx?did=" + dId + "#HRO');";
                                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                                    }
                                    else if (ddlModule.SelectedValue == "B2B Category")
                                    {
                                        strScript = "alert('Your B2B Category is Posted Successfully.');location.replace('Admin_EditData.aspx?did=" + dId + "#HRO');";
                                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                                    }
                                    else if (ddlModule.SelectedValue == "FreeListing")
                                    {
                                        strScript = "alert('Your Free Listing is Posted Successfully.');location.replace('Admin_EditData.aspx?did=" + dId + "#HRO');";
                                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                                    }
                                }
                            }
                            else
                            {
                                strScript = "alert('Image dimenstions should be 250 X 300.');";
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                            }
                        }
                    }
                }
                else
                {
                    strScript = "alert('Image size should be less than 20KB.');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                }
            }
            else
            {
                DataCS data1 = new DataCS();
                data1.dModule = Modules;
                data1.dCategory = Cat;
                data1.dSubCategory = SubCat;
                data1.dSubCategory_Other = SubCat_Other;
                data1.dState = State;
                data1.dCity = City;
                data1.dArea = Area;
                data1.jcdCompany_Name = CompanyName;
                data1.jIndustry = Industry;
                data1.jFun_Area = FunctionalArea;
                data1.jRole = Role;
                data1.jQualification = Qualification;
                data1.jAge = JobAge;
                data1.jExp = Experience;
                data1.jSal = Salary;
                data1.jJob_Desc = JobDesc;
                data1.jSkills = KeySkills;
                data1.jJob_Expiry = JobExpiryDate;
                data1.jcdCompany_Profile = CompanyProfile;
                data1.eEventName = EventName;
                data1.eEventPlace = EventPlace;
                data1.ediDurationType = EventDurationType;
                data1.ediStartDate = StartDate;
                data1.ediEndDate = EndDate;
                data1.ediDescription = Description;
                data1.ediTimeDuration = TimeDuration;
                data1.dAddress = Address;
                data1.dLandMark = LandMark;
                data1.dPinCode = Pincode;
                data1.dContact_Person = ContactPerson;
                data1.dEmail = EmailId;
                data1.dPhNumber = Phone;
                data1.dMobile = Mobile;
                data1.dFaxNo = Fax;
                data1.dWebSite = WebSite;
                data1.dPostDate = DateTime.Now.Date;
                data1.dExpDate = (data1.dPostDate.AddDays(Convert.ToDouble(30)));
                data1.dImgName = imgName;
                data1.dImgContType = imgContentType;
                data1.dLoginId = UserId;
                data1.dCatSub = CatSub;
                // Post data using 3-tier architecture
                Alldata = data1.Data_Insert(data1.dModule, data1.dCategory, data1.dSubCategory, data1.dSubCategory_Other, data1.dState, data1.dCity, data1.dArea,
                                          data1.jcdCompany_Name, data1.jIndustry, data1.jFun_Area, data1.jRole, data1.jQualification, data1.jAge,
                                          data1.jExp, data1.jSal, data1.jJob_Desc, data1.jSkills, data1.jJob_Expiry, data1.jcdCompany_Profile,
                                          data1.eEventName, data1.eEventPlace, data1.ediDurationType, data1.ediStartDate, data1.ediEndDate, data1.ediDescription,
                                          data1.ediTimeDuration, data1.dAddress, data1.dLandMark, data1.dContact_Person, data1.dEmail,
                                          data1.dPhNumber, data1.dMobile, data1.dFaxNo, data1.dWebSite, data1.dPostDate, data1.dExpDate, data1.dPinCode, data1.dLoginId, data1.dImgName, data1.dImgContType,data1.dCatSub);
                
                string getID="select top 1 id from Modulesdata where UserLoginId='"+UserId+"' order by id desc";
                SqlDataAdapter adaId = new SqlDataAdapter(getID, con);
                DataSet dsId=new DataSet();
                adaId.Fill(dsId);
                if (!dsId.Tables[0].Rows.Count.Equals(0))
                {
                    string dId = dsId.Tables[0].Rows[0]["id"].ToString();
                    if (ddlModule.SelectedValue == "Category")
                    {
                        strScript = "alert('Your Category is Posted Successfully.');location.replace('Admin_EditData.aspx?did="+dId+"#HRO');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                    }
                    else if (ddlModule.SelectedValue == "Jobs")
                    {
                        //write here code to send jobs data into careersgen site .
                        string exper = Experience; 
                        SqlConnection careercon = new SqlConnection(ConfigurationManager.AppSettings["career_connectionstring"]);
                        careercon.Open();
                        SqlCommand cmd = new SqlCommand("Insert_Postcareers_Jobs", careercon);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_jobtitle", "With the reference of Justcalluz.com");
                        cmd.Parameters.AddWithValue("@p_walkin", SqlDbType.Int).Value = 0;
                        cmd.Parameters.AddWithValue("@p_designation", Role);
                        cmd.Parameters.AddWithValue("@p_skills", KeySkills);
                        if (exper == "Fresher")
                        {
                            cmd.Parameters.AddWithValue("@p_minexp", 0);
                            cmd.Parameters.AddWithValue("@p_maxexp", 0);
                        }
                        else
                        {
                            string[] ex = exper.Split('-', ' ');
                            if (ex.Length == 2)
                            {
                                cmd.Parameters.AddWithValue("@p_minexp", ex[0]);
                                cmd.Parameters.AddWithValue("@p_maxexp", ex[1]);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@p_minexp", ex[0]);
                                cmd.Parameters.AddWithValue("@p_maxexp", 0);
                            }
                        }
                        if (City == "Hyderabad" || City == "Secunderabad")
                        {
                            cmd.Parameters.AddWithValue("@p_location", "Hyderabad/Secunderabad,");
                            cmd.Parameters.AddWithValue("@p_hiringoff", "Hyderabad/Secunderabad,");
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@p_location", City + ",");
                            cmd.Parameters.AddWithValue("@p_hiringoff", City + ",");
                        }
                        cmd.Parameters.AddWithValue("@p_ctc", "INR");
                        cmd.Parameters.AddWithValue("@p_ctc_lak", "Lakhs");
                        cmd.Parameters.AddWithValue("@p_ctc_thous", "Thousands");
                        cmd.Parameters.AddWithValue("@p_ctc1_lak", "Lakhs");
                        cmd.Parameters.AddWithValue("@p_ctc1_thous", "Thousands");
                        cmd.Parameters.AddWithValue("@p_ctc2_hunthous", "select");
                        cmd.Parameters.AddWithValue("@p_ctc2_thous", "select");
                        cmd.Parameters.AddWithValue("@p_ctc2_hunthous1", "select");
                        cmd.Parameters.AddWithValue("@p_ctc2_thous1", "select");
                        cmd.Parameters.AddWithValue("@p_ctc_hundthous", "select");
                        cmd.Parameters.AddWithValue("@p_ctc_thous1", "select");
                        cmd.Parameters.AddWithValue("@p_ctc1_hunthous", "select");
                        cmd.Parameters.AddWithValue("@p_ctc1_thous1", "select");
                        cmd.Parameters.AddWithValue("@p_hidecandidates", Salary);
                        cmd.Parameters.AddWithValue("@p_perks", "Empty");
                        cmd.Parameters.AddWithValue("@p_vacancies", SqlDbType.Int).Value = 1;
                        cmd.Parameters.AddWithValue("@p_gender", "Select");
                        cmd.Parameters.AddWithValue("@p_farea", FunctionalArea);
                        cmd.Parameters.AddWithValue("@p_industry", Industry);
                        cmd.Parameters.AddWithValue("@p_graduate", "Any Graduate");
                        cmd.Parameters.AddWithValue("@p_graduatecours", "Any Specialization");
                        cmd.Parameters.AddWithValue("@p_graduatecoursspec", "Graduation Not Required");
                        cmd.Parameters.AddWithValue("@p_pg", "Not Required");
                        cmd.Parameters.AddWithValue("@p_pgcourse", Qualification);
                        cmd.Parameters.AddWithValue("@p_pgcoursspec", "Post Graduation Not Required");
                        cmd.Parameters.AddWithValue("@p_gother", "select");
                        cmd.Parameters.AddWithValue("@p_pgother", "select");
                        cmd.Parameters.AddWithValue("@p_hirecomp", CompanyName);
                        cmd.Parameters.AddWithValue("@p_compname", "Ace Indus Tech Sol India Pvt. Ltd");
                        cmd.Parameters.AddWithValue("@p_address", Address);
                        cmd.Parameters.AddWithValue("@p_contact", Mobile + "/" + Phone);
                        cmd.Parameters.AddWithValue("@p_Executname", ContactPerson);
                        cmd.Parameters.AddWithValue("@p_days", "select");
                        cmd.Parameters.AddWithValue("@p_times", "select");
                        cmd.Parameters.AddWithValue("@p_emailid", EmailId);
                        cmd.Parameters.AddWithValue("@p_mail_parameters", "Empty,Empty,Empty,Empty,Empty,Empty,Empty");
                        cmd.Parameters.AddWithValue("@p_refcode", "Empty");
                        cmd.Parameters.AddWithValue("@p_onekeys", "Empty");
                        cmd.Parameters.AddWithValue("@p_allkeys", "Empty");
                        cmd.Parameters.AddWithValue("@p_mail_matchparams", "Empty,,Empty,Empty,Empty,Empty");
                        cmd.Parameters.AddWithValue("@p_rdo_recvjobs", "Recieve Only Relavent Jobs");
                        cmd.Parameters.AddWithValue("@p_rdo_hirecomp", "Hiring Company List");
                        cmd.Parameters.AddWithValue("@p_aboutcomp", CompanyProfile);
                        cmd.Parameters.AddWithValue("@p_aboutmycomp", "Empty");
                        cmd.Parameters.AddWithValue("@p_expiredate", (data1.dPostDate.AddDays(Convert.ToDouble(30))));
                        cmd.Parameters.AddWithValue("@p_relocatgender", "select");
                        cmd.Parameters.AddWithValue("@job_poston", DateTime.Now.Date);
                        cmd.Parameters.AddWithValue("@login_id", "jcalluz");
                        cmd.Parameters.AddWithValue("@app_received", 0);
                        cmd.Parameters.AddWithValue("@app_view", 0);
                        cmd.Parameters.AddWithValue("@p_url", WebSite);
                        cmd.Parameters.AddWithValue("@CompanyLogo", "Empty");
                        cmd.Parameters.AddWithValue("@Logopath", "Empty");
                        cmd.Parameters.AddWithValue("@p_nonekeys", "Empty");
                        cmd.Parameters.AddWithValue("@p_restype", "Key Skills");
                        cmd.Parameters.AddWithValue("@p_hiremycomp", CompanyName);
                        cmd.Parameters.AddWithValue("@p_jobdescription", JobDesc);
                        cmd.Parameters.AddWithValue("@p_disply_addres", "Empty");
                        cmd.Parameters.AddWithValue("@p_desiredprofile", "Empty");
                        cmd.Parameters.AddWithValue("@p_disply_contact", "Empty");
                        cmd.Parameters.AddWithValue("@p_status", SqlDbType.Int).Value = 1;
                        
                        cmd.Parameters.AddWithValue("@p_jobtype", "company");
                        cmd.ExecuteNonQuery();
                        SqlCommand cmdcareer = new SqlCommand("get_careerid", careercon);
                        cmdcareer.CommandType = CommandType.StoredProcedure;
                        cmdcareer.Parameters.AddWithValue("@cmp_name", CompanyName);
                        SqlDataAdapter dacareer = new SqlDataAdapter(cmdcareer);
                        DataSet dscareer = new DataSet();
                        dacareer.Fill(dscareer);
                        careercon.Close();
                        SqlCommand cmdinsert = new SqlCommand("job_careers", con);
                        cmdinsert.CommandType = CommandType.StoredProcedure;
                        cmdinsert.Parameters.AddWithValue("@job_id", Convert.ToInt32(dsId.Tables[0].Rows[0]["id"].ToString()));
                        cmdinsert.Parameters.AddWithValue("@careers_id", Convert.ToInt32(dscareer.Tables[0].Rows[0]["p_jobcode"].ToString()));
                        cmdinsert.ExecuteNonQuery();
                        strScript = "alert('Your Job is Posted Successfully.');location.replace('Admin_Data_Details.aspx?did=" + dId + "');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                    }
                    else if (ddlModule.SelectedValue == "Events")
                    {
                        strScript = "alert('Your Event is Posted Successfully.');location.replace('Admin_Data_Details.aspx?did=" + dId + "');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                    }
                    else if (ddlModule.SelectedValue == "Discounts")
                    {
                        strScript = "alert('Your Discount is Posted Successfully.');location.replace('Admin_Data_Details.aspx?did=" + dId + "');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                    }
                    else if (ddlModule.SelectedValue == "LifeStyle")
                    {
                        strScript = "alert('Your LifeStyle is Posted Successfully.');location.replace('Admin_EditData.aspx?did=" + dId + "#HRO');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                    }
                    else if (ddlModule.SelectedValue == "B2B Category")
                    {
                        strScript = "alert('Your B2B Category is Posted Successfully.');location.replace('Admin_EditData.aspx?did=" + dId + "#HRO');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                    }
                }
            }

        }
        else
        {
            Response.Redirect("Default.aspx");
        }
        con.Close();
    }
    /// <summary>
    /// Executes whenever Exp drop down selection changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlExp_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlExp.SelectedValue == "Experience")
        {
            trExpOther.Visible = true;
           
        }
        else
        {
            trExpOther.Visible = false;
        }
    }
    /// <summary>
    /// Executes whenever subcategory drop down selection changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlSubCat_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlSubCat.SelectedValue == "Others")
        {

            trOtherSubCat.Visible = true;
        }
        else
        {
            trOtherSubCat.Visible = false;
        }
    }
    /// <summary>
    /// Executes whenever duration type drop down selection changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlDurationType_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlDurationType.SelectedValue == "One Day Event")
        {            
            trEndDate.Visible = false;
        }
        else if (ddlDurationType.SelectedValue == "Multi Day Event")
        {
            trEndDate.Visible = true;
        }
    }
    protected void lnkfileupload_Click(object sender, EventArgs e)
    {
        Imgupload.Dispose();
    }
}
