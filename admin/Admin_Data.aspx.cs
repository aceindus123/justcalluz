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

public partial class admin_Admin_Data : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    bool Alldata = false;
    string UserId;
    protected void Page_Load(object sender, EventArgs e)
    {
        // Checking Status of Login
        
        UserId= Convert.ToString(Session["LogInId"]);
        if (UserId != "")
        {
            // it will stays in the same page
        }

        else
        {
            //After login into the account it will go Post ad
            Response.Redirect("Default.aspx");

        }
        rangevalStartDate.ErrorMessage = " Please select " + System.DateTime.Now.ToShortDateString() + " Onwards and till " + System.DateTime.Now.AddDays(90).ToShortDateString();
        rangevalEndDate.ErrorMessage = " Please select " + System.DateTime.Now.ToShortDateString() + " Onwards and till " + System.DateTime.Now.AddDays(365).ToShortDateString();
        rangevalStartDate.MinimumValue = System.DateTime.Now.ToShortDateString();
        rangevalStartDate.MaximumValue=System.DateTime.Now.AddDays(90).ToShortDateString();
        rangevalEndDate.MinimumValue = System.DateTime.Now.ToShortDateString();
        rangevalEndDate.MaximumValue = System.DateTime.Now.AddDays(365).ToShortDateString();
        if (!Page.IsPostBack)
        {
            trCatandJobs.Visible = false;
            trEvents.Visible = false;
            trEventsDiscounts.Visible = false;
            trExpOther.Visible = false;
            trJobCat.Visible = false;
            trJobs.Visible = false;
            trOtherSubCat.Visible = false;
           
            DataCS data = new DataCS();
            //To bind Modules
            data.FillModule(ddlModule);
            //To bind States
            data.FillStates(ddlState);
            
            
        }
    }
    public void fillCategories(string Module_Name)
    {
        try
        {
            string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection oCon = new SqlConnection(Connection);
            string s = "select id,Category from Categories where Module= '" + Module_Name + "'";
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
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
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
    /// To fill the cities for the corresponding States
    /// </summary>
    /// <param name="CountryId"></param>
    public void fillCities(string StateName)
    {
        try
        {
            string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection oCon = new SqlConnection(Connection);
            string s = "select city_Id,city_name from Cities where state_name= '" + StateName + "'";
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
    protected void ddlModule_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlModule.SelectedIndex != 0)
        {
            string Module_Name = Convert.ToString(ddlModule.SelectedValue);
            fillCategories(Module_Name);
        }
        else
        {
            ddlCategory.Items.Clear();
            ddlCategory.Items.Insert(0, "Select Category");
        }
        if (ddlModule.SelectedValue == "Category")
        {
            trCatandJobs.Visible = false;
            trEvents.Visible = false;
            trEventsDiscounts.Visible = false;
            trExpOther.Visible = false;
            trJobCat.Visible = true;
            trJobs.Visible = false;
            
        }
        else if (ddlModule.SelectedValue == "Events")
        {
            trCatandJobs.Visible = false;
            trEvents.Visible = true;
            trEventsDiscounts.Visible = true;
            trExpOther.Visible = false;
            trJobCat.Visible = false;
            trJobs.Visible = false;           
            
        }
        else if (ddlModule.SelectedValue == "Jobs")
        {
            trCatandJobs.Visible = true;
            trEvents.Visible = false;
            trEventsDiscounts.Visible = false;
            trExpOther.Visible = false;
            trJobCat.Visible = true;
            trJobs.Visible = true;            
        }
        else if (ddlModule.SelectedValue == "Discounts")
        {
            trCatandJobs.Visible = true;
            trEvents.Visible = false;
            trEventsDiscounts.Visible = true;
            trExpOther.Visible = false;
            trJobCat.Visible = true;
            trJobs.Visible = false;            
        }
    }
    protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlCategory.SelectedIndex != 0)
        {
            string Categoty_Name = Convert.ToString(ddlCategory.SelectedValue);
            fillSubCategories(Categoty_Name);
        }
        else
        {
            ddlSubCat.Items.Clear();
            ddlSubCat.Items.Insert(0, "Select Sub Category");
        }
    }
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
    
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string Modules="";
        string Cat = "";
        string SubCat = "";
        string SubCat_Other = "";
        string State="";
        string City="";
        string CompanyName = "";
        string Industry = "";
        string FunctionalArea = "";
        string Role="";
        string Qualification = "";
        string Experience = "";
        string Salary = "";
        string JobDesc = "";
        string KeySkills = "";
        string CompanyProfile = "";
        string EventName="";
        string EventPlace="";
        string StartDate="";
        string EndDate="";
        string Description="";
        string TimeDuration="";
        string Address="";
        string LandMark="";
        string ContactPerson = "";
        string EmailId = "";
        string Phone = "";
        string Mobile="";
        string Fax = "";
        string Area = "";
        string Age = "";
        string jobexpiry = "";
        string edurationtype = "";
        string pincode = "";
        string website = "";
        string loginid="";
        string imagename = "";
        string imagecontenttype = "";
        string specifyany = "";
        string catsub = "";
             
        Modules = Convert.ToString(ddlModule.SelectedValue);
        Cat = Convert.ToString(ddlCategory.SelectedValue);
        SubCat = Convert.ToString(ddlSubCat.SelectedValue);
        SubCat_Other = Convert.ToString(txtOthers.Text);
        State = Convert.ToString(ddlState.SelectedValue);
        City = Convert.ToString(ddlCity.SelectedValue);
        CompanyName = Convert.ToString(txtCompanyname.Text);
        Industry = Convert.ToString(txtJInd.Text);
        FunctionalArea = Convert.ToString(txtJfunarea.Text);
        Role = Convert.ToString(txtJRole.Text);
        Qualification = Convert.ToString(txtJQual.Text);
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
        CompanyProfile = Convert.ToString(txtCompanyProfile.Text);
        EventName = Convert.ToString(txtEveName.Text);
        EventPlace = Convert.ToString(txtEvePlace.Text);
        StartDate = Convert.ToString(txtEveDiStartDate.Text);
        EndDate = Convert.ToString(txtEveDiEndDate.Text);
        Description = Convert.ToString(txtEveDiDesc.Text);
        TimeDuration = Convert.ToString(txtEveDiTime.Text);
        Address = Convert.ToString(txtaddr.Text);
        LandMark = Convert.ToString(txtLandMark.Text);
        ContactPerson = Convert.ToString(txtContPerson.Text);
        EmailId = Convert.ToString(txtemail.Text);
        Phone = Convert.ToString(txtph.Text);
        Mobile = Convert.ToString(txtmobile.Text);
        Fax = Convert.ToString(txtFax.Text);  
      
        DataCS data1 = new DataCS();
        data1.dModule = Modules;
        data1.dCategory = Cat;
        data1.dSubCategory = SubCat;
        data1.dSubCategory_Other = SubCat_Other;
        data1.dState = State;
        data1.dCity = City;
        data1.jcdCompany_Name = CompanyName;
        data1.jIndustry = Industry;
        data1.jFun_Area = FunctionalArea;
        data1.jRole = Role;
        data1.jQualification = Qualification;
        data1.jExp = Experience;
        data1.jSal = Salary;
        data1.jJob_Desc = JobDesc;
        data1.jSkills = KeySkills;
        data1.jcdCompany_Profile = CompanyProfile;
        data1.eEventName = EventName;
        data1.eEventPlace = EventPlace;
        data1.ediStartDate = DateTime.Now.Date;
        data1.ediEndDate = DateTime.Now.Date; 
        data1.ediDescription = Description;
        data1.ediTimeDuration = TimeDuration;
        data1.dAddress = Address;
        data1.dLandMark = LandMark;
        data1.dContact_Person = ContactPerson;
        data1.dEmail = EmailId;
        data1.dPhNumber = Phone;
        data1.dMobile = Mobile;
        data1.dFaxNo = Fax;
        data1.dPostDate = DateTime.Now.Date;
        data1.dExpDate = DateTime.Now.Date;
        data1.dArea = Area;
        data1.jAge = Age;
        data1.jJob_Expiry = DateTime.Now.Date;
        data1.ediDurationType = edurationtype;
        data1.dPinCode = pincode;
        data1.dWebSite = website;
        data1.dLoginId = loginid;
        data1.dImgName = imagename;
        data1.dImgContType = imagecontenttype;
        data1.dSpecifyIfAny = specifyany;
        data1.dCatSub = catsub;
        con.Open();
        Alldata = data1.Data_Insert(data1.dModule, data1.dCategory, data1.dSubCategory, data1.dSubCategory_Other, data1.dState, data1.dCity, data1.dArea,
                                  data1.jcdCompany_Name, data1.jIndustry, data1.jFun_Area, data1.jRole, data1.jQualification, data1.jAge,
                                  data1.jExp, data1.jSal, data1.jJob_Desc, data1.jSkills, data1.jJob_Expiry, data1.jcdCompany_Profile,
                                  data1.eEventName, data1.eEventPlace, data1.ediDurationType, data1.ediStartDate, data1.ediEndDate, data1.ediDescription,
                                  data1.ediTimeDuration, data1.dAddress, data1.dLandMark, data1.dContact_Person, data1.dEmail,
                                  data1.dPhNumber, data1.dMobile, data1.dFaxNo, data1.dWebSite, data1.dPostDate, data1.dExpDate,
                                data1.dPinCode,data1.dLoginId,data1.dImgName,data1.dImgContType,data1.dCatSub);
        con.Close();
        if (ddlModule.SelectedValue == "Category")
        {
            string strScript = "";
            strScript = "alert('Your Category is Posted Successfully.');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
        else if (ddlModule.SelectedValue == "Jobs")
        {
            string strScript = "";
            strScript = "alert('Your Job is Posted Successfully.');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
        else if (ddlModule.SelectedValue == "Events")
        {
            string strScript = "";
            strScript = "alert('Your Event is Posted Successfully.');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
        else if (ddlModule.SelectedValue == "Discounts")
        {
            string strScript = "";
            strScript = "alert('Your Discount is Posted Successfully.');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }

        ddlModule.SelectedIndex = 0;
        ddlCategory.SelectedIndex = 0;
        ddlSubCat.SelectedIndex = 0;
        ddlState.SelectedIndex = 0;
        ddlCity.SelectedIndex = 0;
        ddlExp.SelectedIndex = 0;
        txtaddr.Text = "";
        txtCompanyname.Text = "";
        txtCompanyProfile.Text = "";
        txtContPerson.Text = "";
        txtemail.Text = "";
        txtEveDiDesc.Text = "";
        txtEveDiEndDate.Text = "";
        txtEveDiStartDate.Text = "";
        txtEveDiTime.Text = "";
        txtEveName.Text = "";
        txtEvePlace.Text = "";
        txtFax.Text = "";
        txtJExp.Text = "";
        txtJfunarea.Text = "";
        txtJInd.Text = "";
        txtJkeyskills.Text = "";
        txtJobDesc.Text = "";
        txtJQual.Text = "";
        txtJRole.Text = "";
        txtJSal.Text = "";
        txtLandMark.Text = "";
        txtmobile.Text = "";
        txtph.Text = "";
        txtOthers.Text = "";                                 
    }
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
}
